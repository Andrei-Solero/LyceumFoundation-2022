using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class JugeRepository : Repository
    {
        public Judge GetJudgeByLoginCode(string LoginCode)
        {
            Judge judge = null;
            this._Query = "select * from [Judges] where LoginCode = @LoginCode";
            this.Parameters.Add(LoginCode);

            var data = this.FetchData();

            if (data.Read())
            {
                judge = new Judge
                {
                    JudgeID = int.Parse(data["JudgeID"].ToString()),
                    Name = data["FullName"].ToString()
                };
            }

            ResetConnections();
            return judge;
        }
    }
}
