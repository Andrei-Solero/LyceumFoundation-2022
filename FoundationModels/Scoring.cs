using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationModels
{
    public class Scoring
    {
        public Event Event { get; set; }
        public Judge Judge { get; set; }
        public Candidate Candidate { get; set; }
        public List<int> CriteriaPointsID { get; set; } = new List<int>();
        public List<Criteria> Criterias { get; set; } = new List<Criteria>();
        public List<decimal> CriteriaScores { get; set; } = new List<decimal>();
        public float TotalPoints { get; set; }
    }
}
