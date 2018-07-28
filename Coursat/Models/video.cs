using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursat.Models
{
    public class video
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "أسم المحاضرة ")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "محتوى المحاضرة")]
        public string Src { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}