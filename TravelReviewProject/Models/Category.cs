using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}