using CoopDogsFormation.Dtos;
using CoopDogsFormation.Models;
using CoopDogsFormation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Mappers
{
    public class FormationMapper
    {
        static UsersServices UsersServices { get; set; }

        public FormationMapper()
        {
            UsersServices = new UsersServices();
        }

        public static Formation ConvertAddFormationFormModelToFormation(AddFormationFormModel model)
        {
            return new Formation
            {
                Title = model.Title,
                Description = model.Description,
                CreatedDate = DateTime.Today,
            };
        }

        public static ChapterFormation ConvertAddChapterFormationFormModelToChapterFormation(AddChapterFormationFormModel model)
        {
            return new ChapterFormation
            {
                ChapterNumber = model.Number,
                Description = model.Description,
                IdFormation = model.IdFormation,
                Title = model.Title,
                UrlVideo = model.File?.FileName,
            };
        }

        public static FormationDto ConvertWithoutFormationsToDto(Formation model)
        {
            return new FormationDto
            {
                IdFormations = model.IdFormations,
                Title = model.Title,
                Description = model.Description,
                CreatedDate = model.CreatedDate,
            };
        }

        public static FormationDto ConvertFormationsToDto(Formation model)
        {
            return new FormationDto
            {
                IdFormations = model.IdFormations,
                Title = model.Title,
                Description = model.Description.Replace("\\n", "\n"),
                CreatedDate = model.CreatedDate,
                Users = model.UserFormations
                    .Select(user => UsersServices.GetUser(user.IdUser))
                    .ToList(),
                ChapterFormations = model.ChapterFormations
                    .Select(chapter => ChapterFormationMapper.ConvertChapterFormationToDto(chapter))
                    .ToList(),
            };
        }
    }
}
