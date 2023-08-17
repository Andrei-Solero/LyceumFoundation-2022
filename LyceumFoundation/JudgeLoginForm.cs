using FoundationLibrary;
using FoundationLibrary.Controller;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LyceumFoundation
{
    public partial class JudgeLoginForm : Form, ILogin
    {
        LoginController loginController;
        public JudgeLoginForm()
        {
            InitializeComponent();
            loginController = new LoginController(this);
        }

        public string LoginCode 
        { 
            get { return txtLoginCode.Text; }
            set { txtLoginCode.Text = value; }
        }
        public Judge JudgeInfo { get; set; }

        public bool Login()
        {
            loginController.JudgeLogin();
            return (JudgeInfo != null) ? true : false;            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login() == true)
            {
                CompetitionSelector competition = new CompetitionSelector(JudgeInfo, this);
                competition.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin admin = new AdminLogin(this);
            admin.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
