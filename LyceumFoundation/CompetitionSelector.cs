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
    public partial class CompetitionSelector : Form
    {
        private readonly Judge judgeInfo;
        private readonly JudgeLoginForm judgeLogin;

        public CompetitionSelector(Judge judgeInfo, JudgeLoginForm judgeLogin)
        {
            InitializeComponent();
            this.judgeInfo = judgeInfo;
            this.judgeLogin = judgeLogin;
        }

        private void SetCompetition(int EventID, int NumberOfCriteria)
        {
            Scoring competition = new Scoring
            {
                Event = new Event { EventID = EventID },
                Judge = judgeInfo
            };

            switch (NumberOfCriteria)
            {
                case 4:
                    JudgeVotingFormFourCriteria fourCriteria = new JudgeVotingFormFourCriteria(competition, this);
                    fourCriteria.Show();
                    break;
                case 5:
                    JudgeVotingForm votingForm = new JudgeVotingForm(competition, this);
                    votingForm.Show();
                    break;
            }

            this.Hide();
        }

        private void btnStreetDance_Click(object sender, EventArgs e)
        {
            SetCompetition(2, 5);
        }

        private void btnHiphop_Click(object sender, EventArgs e)
        {
            SetCompetition(1, 4);
        }

        private void btnMusical_Click(object sender, EventArgs e)
        {
            SetCompetition(3, 4);
        }

        private void btnSinging_Click(object sender, EventArgs e)
        {
            SetCompetition(4, 4);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            judgeLogin.Show();
            this.Close();
        }
    }
}
