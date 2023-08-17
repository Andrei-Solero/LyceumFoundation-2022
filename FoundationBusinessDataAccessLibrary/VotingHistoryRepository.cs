using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class VotingHistoryRepository : Repository
    {

        public Scoring GetVoteHistoryByJudgeCandidateEvent(Scoring scoring)
        {
            Scoring scores = new Scoring();
            this._Query = "select * from CriterionScoring where [EventID] = @EventID " +
                "and [JudgeID] = @JudgeID and [CandidateID] = @CandidateID";

            this.Parameters.Add(scoring.Event.EventID.ToString());
            this.Parameters.Add(scoring.Judge.JudgeID.ToString());
            this.Parameters.Add(scoring.Candidate.CandidateID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {   
                scores.CriteriaPointsID.Add(int.Parse(data["CriterionScoringID"].ToString()));
                scores.CriteriaScores.Add(decimal.Parse(data["Score"].ToString()));
                scores.Criterias.Add(new Criteria
                {
                    CriteriaID = int.Parse(data["CriteriaID"].ToString()),
                });
            }

            ResetConnections();
            return scores;
        }

        public void UpdateCriteriaVote(Scoring scoring)
        {
            for (int i = 0; i < scoring.CriteriaScores.Count; i++)
            {
                this._Query = "update [CriterionScoring] set [Score] = @Score where [EventID] = @EventID " +
                 "and [JudgeID] = @JudgeID and [CandidateID] = @CandidateID and [CriterionScoringID] = @CriterionScoringID";

                this.Parameters.Add(scoring.CriteriaScores[i].ToString());
                this.Parameters.Add(scoring.Event.EventID.ToString());
                this.Parameters.Add(scoring.Judge.JudgeID.ToString());
                this.Parameters.Add(scoring.Candidate.CandidateID.ToString());
                this.Parameters.Add(scoring.CriteriaPointsID[i].ToString());

                this.ModifyData();
                ResetConnections();
            }

            UpdateTotalPoints(scoring);
        }


        private void UpdateTotalPoints(Scoring scoring)
        {
            this._Query = "update [MainScoring] set [TotalScore] = @TotalPoints where [EventID] = @EventID " +
                "and [JudgeID] = @JudgeID and [CandidateID] = @CandidateID";

            this.Parameters.Add(scoring.TotalPoints.ToString());
            this.Parameters.Add(scoring.Event.EventID.ToString());
            this.Parameters.Add(scoring.Judge.JudgeID.ToString());
            this.Parameters.Add(scoring.Candidate.CandidateID.ToString());

            this.ModifyData();
            ResetConnections();
        }

    }
}
