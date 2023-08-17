using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class ScoringDetailsController
    {
        private readonly IScoringDetails scoringDetails;
        ScoringDetailsRepository ScoringRepo;

        public ScoringDetailsController(IScoringDetails ScoringDetails)
        {
            scoringDetails = ScoringDetails;
            ScoringRepo = new ScoringDetailsRepository();

            ScoringDetails.CriteriaScoring = GetAllCriteriaScoring();
            ScoringDetails.SetScoring();
        }

        public List<Criteria> GetAllCriteriaScoring()
        {
            return ScoringRepo.GetCriteriasByEvent(scoringDetails.EventIDBased);
        }

    }
}
