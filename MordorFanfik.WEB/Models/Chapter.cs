using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MordorFanfik.WEB.Models
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }
      
        [MaxLength(31),MinLength(1)]
        public string NameChapter { get; set; }

        public string TextChapter { get; set; }
        public int NumberChapter { get; set; }

        public Creation CreationId { get; set; }
    }
}
