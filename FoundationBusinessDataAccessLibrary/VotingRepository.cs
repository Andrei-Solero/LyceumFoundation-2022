using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace FoundationBusinessDataAccessLibrary
{
    public class VotingRepository : Repository
    {
        public void SubmitVote(Scoring scoring)
        {
            this._Query = "insert into [MainScoring]([EventID], [JudgeID], [CandidateID], [TotalScore])" +
                "values(@EventID, @JudgeID, @CandidateID, @TotalScore)";

            this.Parameters.Add(scoring.Event.EventID.ToString());
            this.Parameters.Add(scoring.Judge.JudgeID.ToString());
            this.Parameters.Add(scoring.Candidate.CandidateID.ToString());
            this.Parameters.Add(scoring.TotalPoints.ToString());

            this.ModifyData();
            ResetConnections();

            this.SaveCriterionScoring(scoring);
        }

        private void SaveCriterionScoring(Scoring scoring)
        {
            for (int i = 0; i < scoring.CriteriaScores.Count; i++)
            {
                this._Query = "insert into [CriterionScoring]([EventID], [CriteriaID], " +
                    "[JudgeID], [CandidateID], [Score])" +
                "values(@EventID, @CriteriaID, @JudgeID, @CandidateID, @Score)";

                this.Parameters.Add(scoring.Event.EventID.ToString());
                this.Parameters.Add(scoring.Criterias[i].CriteriaID.ToString());
                this.Parameters.Add(scoring.Judge.JudgeID.ToString());
                this.Parameters.Add(scoring.Candidate.CandidateID.ToString());
                this.Parameters.Add(scoring.CriteriaScores[i].ToString());

                this.ModifyData();
                ResetConnections();
            }
        }
    }
}
