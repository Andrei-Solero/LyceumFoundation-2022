using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class ResultsRepository : Repository
    {
        public List<Scoring> GetAllResultsByEvent(Event Competition, string Department)
        {
            List<Scoring> scores = new List<Scoring>();

            if (Department == "")
            {
                this._Query = "select * from FinalScoring where [EventID] = @EventID order by CandidateID asc, JudgeID asc";
                this.Parameters.Add(Competition.EventID.ToString());
            }
            else
            {
                this._Query = "select * from FinalScoring where [EventID] = @EventID and [Candidates.FullName] = @Deparment order by CandidateID asc, JudgeID asc";
                this.Parameters.Add(Competition.EventID.ToString());
                this.Parameters.Add(Department);
            } 

            var data = this.FetchData();

            while (data.Read())
            {
                scores.Add(new Scoring
                {
                    Candidate = new Candidate
                    {
                        CandidateID = int.Parse(data["CandidateID"].ToString()),
                        Name = data["Candidates.FullName"].ToString(),
                        Department = new Department
                        {
                            Title = data["Departments.Title"].ToString(),
                            SchoolLevel = data["SchoolLevel.Title"].ToString()
                        }
                    },
                    TotalPoints = float.Parse(data["TotalScore"].ToString()),
                    Judge = new Judge
                    {
                        Name = data["Judges.FullName"].ToString()
                    }
                });
            }

            ResetConnections();
            return scores;
        }

        public List<Scoring> FinalResults(Event Competition, string SchoolLevel)
        {
            List<Scoring> scores = new List<Scoring>();
            this._Query = "select * from FinalResult where [EventID] = @EventID and [SchoolLevel.Title] = @SchoolLevel";

            this.Parameters.Add(Competition.EventID.ToString());
            this.Parameters.Add(SchoolLevel);

            var data = this.FetchData();

            while (data.Read())
            {
                scores.Add(new Scoring
                {
                    Event = new Event
                    {
                        EventID = int.Parse(data["EventID"].ToString()),
                        Title = data["Event.Title"].ToString()
                    },
                    Candidate = new Candidate
                    {
                        CandidateID = int.Parse(data["CandidateID"].ToString()),
                        Name = data["FullName"].ToString(),
                        Department = new Department
                        {
                            SchoolLevel = data["SchoolLevel.Title"].ToString(),
                            Title = data["Departments.Title"].ToString()
                        }
                    },
                    TotalPoints = float.Parse(data["FinalScore"].ToString())
                });
            }

            ResetConnections();
            return scores;
        }

    }
}