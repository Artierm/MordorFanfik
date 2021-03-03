using MordorFanfik.WEB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.ViewModels
{
    public class CreateCreationViewModel
    {
        [Display(Name = "Название произведения")]
        public string NameCreation { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Жанр")]
        public Genre Genre { get; set; }
    }
}
