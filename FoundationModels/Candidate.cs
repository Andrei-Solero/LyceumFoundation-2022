using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationModels
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
        public Event EventJoined { get; set; }
    }
}
