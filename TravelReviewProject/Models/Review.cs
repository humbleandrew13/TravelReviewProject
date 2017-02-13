using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "Date of Review")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfReview { get; set; }
        [Display(Name = "Name of Place Being Reviewed")]
        public string NameOfPlace { get; set; }
        [Display(Name = "Location of Place Being Reviewed")]
        public string LocationOfPlace { get; set; }
        [Display(Name = "Date of Visit")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfVisit { get; set; }
        [Display(Name = "Review Title/Summary")]
        public string ReviewTitle { get; set; }
        [Display(Name = "Detailed Review")]
        public string DetailedReview { get; set; }
        [Display(Name = "Reviewer's Name")]
        public string UserName { get; set; }

        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Score")]
        [Display(Name = "Score")]
        public int ScoreID { get; set; }
        public virtual Score Score { get; set; }
    }
}