using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface ICandidate
    {
        Event Competition { get; set; }

        List<Candidate> GetCandidates();
        void SetCandidateDetails();
    }
}
