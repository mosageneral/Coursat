using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursat.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "أسم الكورس")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "وصف الكورس")]
        public string Description { get; set; }
        [Display(Name = "صورة الكورس")]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<video> videos { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}