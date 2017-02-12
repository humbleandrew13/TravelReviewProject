using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }
        [Display(Name = "Score")]
        public int ReviewScore { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}