using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelReviewProject.Models
{
    public class Score
    {
        public int ScoreID { get; set;}
        public int ReviewScore { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}