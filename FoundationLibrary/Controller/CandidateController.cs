using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class CandidateController
    {
        private readonly ICandidate candidate;
        private CandidateRepository candidateRepo;

        public CandidateController(ICandidate candidate)
        {
            this.candidate = candidate;
            candidateRepo = new CandidateRepository();
        }

        public List<Candidate> GetAllCandidatesByEvent()
        {
            return candidateRepo.Candidates(candidate.Competition);
        }

    }
}
