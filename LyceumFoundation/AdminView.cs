using FoundationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace LyceumFoundation
{
    public partial class AdminView : Form
    {
        AdminResultsView adminView;
        private readonly AdminLogin adminLogin;

        public AdminView(AdminLogin adminLogin)
        {
            InitializeComponent();
            this.adminLogin = adminLogin;
        }

        private void SetCompetition(int eventID, string title)
        {
            Event competition = new Event
            {
                EventID = eventID,
                Title = title
            };

            adminView = new AdminResultsView(competition);
            this.panelScoring.Controls.Clear();
            this.panelScoring.Controls.Add(adminView);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {

        }

        private void btnFirstEvent_Click(object sender, EventArgs e)
        {
            SetCompetition(1, "Hip-Hop Dance Competition");
        }

        private void btnSecondEvent_Click(object sender, EventArgs e)
        {
            SetCompetition(2, "Street Dance Competition");
        }

        private void btnThirdEvent_Click(object sender, EventArgs e)
        {
            SetCompetition(4, "Singing Competition");
        }

        private void btnFourtEvent_Click(object sender, EventArgs e)
        {
            SetCompetition(3, "Musical Play Competition");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            adminLogin.Show();
        }
    }
}
