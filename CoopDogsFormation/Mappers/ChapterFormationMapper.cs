using CoopDogsFormation.Dtos;
using CoopDogsFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Mappers
{
    public static class ChapterFormationMapper
    {
        public static AdminChapterFormationDto ConvertChapterFormationToDto(ChapterFormation model)
        {
            return new AdminChapterFormationDto
            {
                Description = model.Description,
                IdChapter = model.IdChapter,
                Title = model.Title,
                UrlVideo = model.UrlVideo,
            };
        }
    }
}
