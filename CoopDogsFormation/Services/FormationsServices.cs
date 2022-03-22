using CoopDogsFormation.Dtos;
using CoopDogsFormation.Mappers;
using CoopDogsFormation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Services
{
    public class FormationsServices
    {
        public dogsformationsContext Context { get; set; }

        public FormationsServices()
        {
            Context = new dogsformationsContext();
        }

        public List<AdminFormationDto> GetAdminFormation()
        {
            return Context.Formations
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
            catch (DbUpdateException ex)
            {
                return new Tuple<bool, string>(false, "Titre déjà existant");
            }
            return new Tuple<bool, string>(true, "La formation à bien été ajouté !");
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
                return new Tuple<bool, string>(true, "Une erreur est survenue :'( ");
            }
            return new Tuple<bool, string>(true, "La formation à bien été supprimé !");
        }
    }
}
