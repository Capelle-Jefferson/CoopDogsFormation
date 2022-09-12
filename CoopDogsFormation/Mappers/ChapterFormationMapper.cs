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
        public static ChapterFormationDto ConvertChapterFormationToDto(ChapterFormation model)
        {
            return new ChapterFormationDto
            {
                Description = model.Description.Replace("\\n", "\n"),
                IdChapter = model.IdChapter,
                Number = model.ChapterNumber,
                Title = model.Title,
                UrlVideo = model.UrlVideo,
                IdFormation = model.IdFormation,
            };
        }
    }
}
