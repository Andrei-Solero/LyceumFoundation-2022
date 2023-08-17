using FoundationDataAccessLibrary;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationBusinessDataAccessLibrary
{
    public class AdminRepository : Repository
    {
        public Admin GetAdminByLoginCode(string LoginCode)
        {
            Admin admin = null;
            this._Query = "select * from [Admin] where LoginCode = @LoginCode";
            this.Parameters.Add(LoginCode);

            var data = this.FetchData();

            if (data.Read())
            {
                admin = new Admin
                {
                    AdminID = int.Parse(data["AdminID"].ToString())
                };
            }

            ResetConnections();
            return admin;
        }
    }
}
