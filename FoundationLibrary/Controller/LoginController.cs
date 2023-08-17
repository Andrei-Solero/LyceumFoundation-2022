using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class LoginController
    {
        private readonly ILogin login;
        
        private JugeRepository JudgeRepo;
        public LoginController(ILogin Login)
        {
            login = Login;
            JudgeRepo = new JugeRepository();
        }

        public void JudgeLogin()
        {
            var IsJudgeFound = JudgeRepo.GetJudgeByLoginCode(login.LoginCode);
            if (IsJudgeFound != null)
            {
                login.JudgeInfo = IsJudgeFound;
            }
        }

        private readonly IAdmin admin;
        private AdminRepository AdminRepo;
        public LoginController(IAdmin admin)
        {
            this.admin = admin;
            AdminRepo = new AdminRepository();
        }
        public void AdminLogin()
        {
            var IsAdminFound = AdminRepo.GetAdminByLoginCode(admin.LoginCode);  
            if(IsAdminFound != null)
            {
                admin.Admin = IsAdminFound;
            }
        }

    }
}
