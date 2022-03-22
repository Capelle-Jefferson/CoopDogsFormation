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

        public static Formation ConvertAddFormationFormModelToFormation(AddFormationFormModel formation)
        {
            return new Formation
            {
                Title = formation.Title,
                Description = formation.Description,
            };
        }

        public static AdminFormationDto ConvertFormationsToDto(Formation model)
        {
            return new AdminFormationDto
            {
                IdFormations = model.IdFormations,
                Title = model.Title,
                Description = model.Description,
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
