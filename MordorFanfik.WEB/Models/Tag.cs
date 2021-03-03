using System.ComponentModel.DataAnnotations;

namespace MordorFanfik.WEB.Models
{
    public class Tag
    {
       [Key] 
       public int Id { get; set; }
       public string NameTag { get; set; }
    }
}
