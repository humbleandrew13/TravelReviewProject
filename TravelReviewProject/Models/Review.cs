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

        public DateTime DateOfReview { get; set; }
        public string NameOfPlace { get; set; }
        public string LocationOfPlace { get; set; }
        public DateTime DateOfVisit { get; set; }
        public string ReviewTitle { get; set; }
        public string DetailedReview { get; set; }
        public string UserName { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Score")]
        public int ScoreID { get; set; }
        public virtual Score Score { get; set; }
    }
}