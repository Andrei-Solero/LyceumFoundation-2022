using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class FinalScoringRepository : Repository
    {
        public List<Scoring> GetFinalScoreByEvent(Scoring eventCompetition)
        {
            List<Scoring> Scores = new List<Scoring>();
            this._Query = "select * from FinalScoring where [EventID] = @EventID order by TotalScore desc";
            this.Parameters.Add(eventCompetition.Event.EventID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {
                Scores.Add(new Scoring
                {
                    Candidate = new Candidate
                    {
                        CandidateID = int.Parse(data["CandidateID"].ToString()),
                        Name = data["Candidates.FullName"].ToString(),
                        Department = new Department
                        {
                            Title = data["Departments.Title"].ToString()
                        },
                        EventJoined = new Event
                        {
                            Title = data["Event.Title"].ToString()
                        },
                    },
                    Event = new Event
                    {
                        Title = data["Event.Title"].ToString()
                    },
                    Judge = new Judge
                    {
                        Name = "Judges.FullName"
                    },
                    TotalPoints = float.Parse(data["TotalScore"].ToString())
                });
            }

            ResetConnections();
            return Scores;
        }
    }
}
