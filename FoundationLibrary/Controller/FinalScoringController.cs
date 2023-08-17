using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class FinalScoringController
    {
        private readonly IFinalScoring finalScoring;
        private FinalScoringRepository finalScoreRepo;
        public FinalScoringController(IFinalScoring FinalScoring)
        {
            finalScoring = FinalScoring;
            finalScoreRepo = new FinalScoringRepository();
        }

        public List<Scoring> Scores()
        {
            return finalScoreRepo.GetFinalScoreByEvent(finalScoring.Event);
        }

    }
}
