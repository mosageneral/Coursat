using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coursat.Models
{
    public class Category
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "اسم اللغه البرمجيه")]
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}