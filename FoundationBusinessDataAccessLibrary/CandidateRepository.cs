using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class CandidateRepository : Repository
    {
        public List<Candidate> Candidates(Event Competition)
        {
            List<Candidate> candidates = new List<Candidate>();
            this._Query = "select * from CandidateDetails where [EventID] = @EventID";
            this.Parameters.Add(Competition.EventID.ToString());

            var data = this.FetchData();

            while (data.Read())
            {
                candidates.Add(new Candidate
                {
                    Name = data["FullName"].ToString(),
                    CandidateID = int.Parse(data["CandidateID"].ToString()),
                    Department = new Department
                    {
                        DepartmentID = int.Parse(data["DeparmentID"].ToString()),
                        Title = data["Departments.Title"].ToString(),
                        SchoolLevel = data["SchoolLevel.Title"].ToString()
                    },
                    EventJoined = new Event
                    {
                        Title = data["Event.Title"].ToString()
                    }
                });
            }

            ResetConnections();
            return candidates;
        }
    }
}
