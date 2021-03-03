using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.ViewModels
{
    public class CreateChapterViewModel
    {
        [Display(Name = "Название главы")]
        public string NameChapter { get; set; }

        [Display(Name = "Текст главы")]
        public string TextChapter { get; set; }
        
        public int NumberChapter { get; set; }
    }
}
