using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Models
{
    public class Creation
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(31), MinLength(1)]
        public string NameCreation { get; set; }

        [MaxLength(255), MinLength(50)]
        public string ShortDescription { get; set; }

        public List<Tag> Tags { get; set; }
        public Genre GenreCreation { get; set; }
        public List<Chapter> Chapters { get; set; }
        public IdentityUser UserId { get; set; }
    }
 }

