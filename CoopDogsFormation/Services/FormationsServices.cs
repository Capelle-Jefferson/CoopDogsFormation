using CoopDogsFormation.Dtos;
using CoopDogsFormation.Mappers;
using CoopDogsFormation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Services
{
    public class FormationsServices
    {
        #region Const
        private const string FilePath = "wwwroot/Files";
        private const string DirName = "Videos";

        #endregion Const

        public dogsformationsContext Context { get; set; }

        public FormationsServices()
        {
            Context = new dogsformationsContext();
        }

        #region Formation
        public FormationDto GetAdminFormation(int id, bool withChapter = true)
        {
            Formation model = Context.Formations
                    .FirstOrDefault(formation => formation.IdFormations == id);
            if (withChapter)
                model.ChapterFormations = Context.ChapterFormations.Where(chap => chap.IdFormation == id).ToList();
            return FormationMapper.ConvertFormationsToDto(model);
        }

        public List<FormationDto> GetAdminFormation()
        {
            List<Formation> formations = Context.Formations.ToList();
            formations.ForEach(f =>
                f.ChapterFormations = Context.ChapterFormations.Where(chap => chap.IdFormation == f.IdFormations).ToList());
            return formations
                    .Select(formation => FormationMapper.ConvertFormationsToDto(formation))
                    .ToList();
        }

        public Tuple<bool, string> AddFormation(AddFormationFormModel formation)
        {
            try
            {
                Context.Formations.Add(
                    FormationMapper.ConvertAddFormationFormModelToFormation(formation));
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Titre déjà existant");
            }
            return new Tuple<bool, string>(true, "La formation à bien été ajoutée !");
        }

        public Tuple<bool, string> DeleteFormation(int id)
        {
            try
            {
                Context.Formations.Remove(Context.Formations.FirstOrDefault(formation => formation.IdFormations == id));
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }
            return new Tuple<bool, string>(true, "La formation à bien été supprimée !");
        }

        public Tuple<bool, string> UpdateFormation(int id, AddFormationFormModel formation)
        {
            try
            {
                Formation f = Context.Formations.FirstOrDefault(formation => formation.IdFormations == id);
                f.Title = formation.Title;
                f.Description = formation.Description;
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }

            return new Tuple<bool, string>(true, "La formation à bien été modifiée !");
        }
        #endregion Formation


        #region Chapitre
        public ChapterFormationDto GetChapter(int chapterId)
        {
            return ChapterFormationMapper.ConvertChapterFormationToDto(Context.ChapterFormations
                .FirstOrDefault(chap => chap.IdChapter == chapterId));
        }

        public Tuple<bool, string> AddChapter(AddChapterFormationFormModel chapter)
        {
            try
            {
                Context.ChapterFormations.Add(
                    FormationMapper.ConvertAddChapterFormationFormModelToChapterFormation(chapter));
                Context.SaveChanges();

                // Enregistrement de la vidéo
                if (chapter.File != null)
                    AddVideos(chapter.File);
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur c'est produite");
            }
            return new Tuple<bool, string>(true, "Le chapitre de la formation à bien été ajouté !");
        }

        public Tuple<bool, string> DeleteChapter(int idChapter, int idFormation)
        {
            try
            {
                // Récupération de tout les chapitres
                List<ChapterFormation> chapters = Context.ChapterFormations
                    .Where(chap => chap.IdFormation == idFormation)
                    .ToList();
                // Décrémente le numéro des chapitres supérieur à celui supprimé
                int numberSup = chapters.FirstOrDefault(c => c.IdChapter == idChapter).ChapterNumber;
                chapters.ForEach(chapter =>
                {
                    if (chapter.ChapterNumber > numberSup)
                        chapter.ChapterNumber--;
                });

                // Récupération du chapitre à supprimer
                ChapterFormation chapterDelete = Context.ChapterFormations.FirstOrDefault(chapter => chapter.IdChapter == idChapter);

                // Suppression de la vidéo associé au chapitre
                if (!string.IsNullOrEmpty(chapterDelete.UrlVideo))
                    File.Delete(string.Concat(FilePath, "/", DirName, "/", chapterDelete.UrlVideo));

                // Suppression du chapitre
                Context.ChapterFormations.Remove(chapterDelete);
                Context.SaveChanges();
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }
            return new Tuple<bool, string>(true, "Le chapitre à bien été supprimé !");
        }

        public Tuple<bool, string> UpdateChapter(int id, AddChapterFormationFormModel chapter)
        {
            try
            {
                ChapterFormation updatedChapter = Context.ChapterFormations.FirstOrDefault(c => c.IdChapter == id);
                updatedChapter.Title = chapter.Title;
                updatedChapter.Description = chapter.Description;
                Context.SaveChanges();

                // Enregistrement de la vidéo
                if (chapter.File != null)
                {
                    AddVideos(chapter.File);
                    // Suppression de l'ancienne vidéo associé au chapitre
                    if (!string.IsNullOrEmpty(updatedChapter.UrlVideo))
                        File.Delete(string.Concat(FilePath, "/", DirName, "/", updatedChapter.UrlVideo));
                }
            }
            catch
            {
                return new Tuple<bool, string>(false, "Une erreur est survenue :'( ");
            }

            return new Tuple<bool, string>(true, "Le chapitre à bien été modifié !");
        }
        #endregion Chapitre


        #region AutresMethodes
        /// <summary>
        /// Sauvegarde du fichier 
        /// </summary>
        /// <param name="file"></param>
        private void AddVideos(IFormFile file)
        {
            var uploads = Path.Combine(FilePath, DirName);
            var filePath = Path.Combine(uploads, file.FileName);
            file.CopyTo(new FileStream(filePath, FileMode.Create));
        }
        #endregion AutresMethodes

    }
}
