using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationModels
{
    public class Criteria
    {
        public int CriteriaID { get; set; }
        public Event Event { get; set; }
        public string Title { get; set; }
        public int Percentage { get; set; }
    }
}
