using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class ScoringDetailsRepository : Repository
    {
        public List<Criteria> GetCriteriasByEvent(Event EventIDData)
        {
            List<Criteria> Criterias = new List<Criteria>();
            this._Query = "select * from EventCriterias where EventID = @EventID";

            this.Parameters.Add(EventIDData.EventID.ToString());
            var data = this.FetchData();

            while (data.Read())
            {
                Criterias.Add(new Criteria
                {
                    CriteriaID = int.Parse(data["CriteriaID"].ToString()),
                    Title = data["Criteria.Title"].ToString(),
                    Percentage = int.Parse(data["Percentage"].ToString())
                });
            }

            ResetConnections();
            return Criterias;
        }
    }
}
