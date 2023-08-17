using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class ResultsController
    {
        private readonly IResultsView finalResult;
        private ResultsRepository finalScoreController;
        public ResultsController(IResultsView finalResult)
        {
            this.finalResult = finalResult;
            finalScoreController = new ResultsRepository();
        }

        public List<Scoring> GetAllScores(string SchoolLevel)
        {
            return finalScoreController.GetAllResultsByEvent(finalResult.Competition, SchoolLevel);
        }

        public List<Scoring> FinalResult(string SchoolLevel)
        {
            return finalScoreController.FinalResults(finalResult.Competition, SchoolLevel);
        }

    }
}
