using FoundationLibrary.Controller;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LyceumFoundation
{
    public partial class AdminLogin : Form, IAdmin
    {
        private LoginController LoginController;
        private readonly JudgeLoginForm judgeLogin;

        public AdminLogin(JudgeLoginForm judgeLogin)
        {
            InitializeComponent();
            LoginController = new LoginController(this);
            this.judgeLogin = judgeLogin;
        }

        public string LoginCode
        { 
            get { return txtLoginCode.Text; } 
            set { txtLoginCode.Text = value; }
        }
        public Admin Admin { get; set; }

        public void Login()
        {
            LoginController.AdminLogin();

            if (Admin != null)
            {
                AdminView admin = new AdminView(this);
                admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cannot find account.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            this.Login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            judgeLogin.Show();
        }
    }
}
