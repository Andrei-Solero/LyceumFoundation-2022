using FoundationLibrary;
using FoundationLibrary.Controller;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LyceumFoundation
{
    public partial class JudgeVotingFormFourCriteria : Form, IScoringDetails, IVoting, ICandidate, IVoteHistory
    {
        private readonly CompetitionSelector competition;
        public JudgeVotingFormFourCriteria(Scoring Competition, CompetitionSelector competition)
        {
            InitializeComponent();

            EventIDBased = Competition.Event;
            JudgeData = Competition.Judge;
            scoringController = new ScoringDetailsController(this);

            votingController = new VotingController(this);

            this.Competition = Competition.Event;
            candidateController = new CandidateController(this);
            SetCandidateDetails();

            voteHistoryController = new VoteHistoryController(this);
            SetVoteLogs();

            lblJudge.Text = Competition.Judge.Name;
            this.competition = competition;

            this.lblCompetitionName.Text = SetCompetitionTitle(Competition.Event.EventID);

        }

        private string SetCompetitionTitle(int eventID)
        {
            string eventTitle = "";
            if (eventID == 1) eventTitle = "Hip Hop Competition";
            else if (eventID == 3) eventTitle = "Musical Play Competition";
            else if (eventID == 4) eventTitle = "Singing Competition";

            return eventTitle;
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;
            text.SelectAll();
        }

        private void TextDigitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            TextBox txt = sender as TextBox;
            if (e.KeyChar == '.' && txt.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        #region VotingHistoryAndScoreUpdating

        VoteHistoryController voteHistoryController;
        public Scoring ScoreLogs { get; set; }
        private bool HasFoundVoteLogs;

        public Scoring VoteHistory()
        {
            return voteHistoryController.VoteHistoryDetails();
        }

        public void UpdateVoteLogs()
        {
            ScoreLogs = new Scoring
            {
                Event = new Event { EventID = EventIDBased.EventID },
                Candidate = new Candidate { CandidateID = GetCandidates()[candidateCounter].CandidateID },
                Judge = new Judge { JudgeID = JudgeData.JudgeID },
                CriteriaPointsID =
                {
                    int.Parse(scoreFirstCriteria.Tag.ToString()),
                    int.Parse(scoreSecondCriteria.Tag.ToString()),
                    int.Parse(scoreThirdCriteria.Tag.ToString()),
                    int.Parse(scoreFourthCriteria.Tag.ToString()),
                },
                Criterias =
                {
                    new Criteria { CriteriaID = int.Parse(scoreFirstCriteria.Tag.ToString()) },
                    new Criteria { CriteriaID = int.Parse(scoreSecondCriteria.Tag.ToString()) },
                    new Criteria { CriteriaID = int.Parse(scoreThirdCriteria.Tag.ToString()) },
                    new Criteria { CriteriaID = int.Parse(scoreFourthCriteria.Tag.ToString()) },
                },
                CriteriaScores =
                {
                    decimal.Parse( scoreFirstCriteria.Text),
                    decimal.Parse( scoreSecondCriteria.Text),
                    decimal.Parse( scoreThirdCriteria.Text),
                    decimal.Parse( scoreFourthCriteria.Text),

                },
                TotalPoints = (float)float.Parse(scoreFirstCriteria.Text) + float.Parse(scoreSecondCriteria.Text)
                            + float.Parse(scoreThirdCriteria.Text) + float.Parse(scoreFourthCriteria.Text)
            };
            voteHistoryController.UpdateVoteLogs();
        }

        private void SetVoteLogs()
        {
            try
            {
                ScoreLogs = new Scoring
                {
                    Event = EventIDBased,
                    Judge = JudgeData,
                    Candidate = GetCandidates()[candidateCounter]
                };
                var scoreLogs = VoteHistory();
                scoreFirstCriteria.Text = scoreLogs.CriteriaScores[0].ToString();
                scoreSecondCriteria.Text = scoreLogs.CriteriaScores[1].ToString();
                scoreThirdCriteria.Text = scoreLogs.CriteriaScores[2].ToString();
                scoreFourthCriteria.Text = scoreLogs.CriteriaScores[3].ToString();

                scoreFirstCriteria.Tag = scoreLogs.CriteriaPointsID[0];
                scoreSecondCriteria.Tag = scoreLogs.CriteriaPointsID[1];
                scoreThirdCriteria.Tag = scoreLogs.CriteriaPointsID[2];
                scoreFourthCriteria.Tag = scoreLogs.CriteriaPointsID[3];
                HasFoundVoteLogs = true;

            }
            catch
            {
                HasFoundVoteLogs = false;
                ResetScoring();

                scoreFirstCriteria.Tag = null;
                scoreSecondCriteria.Tag = null;
                scoreThirdCriteria.Tag = null;
                scoreFourthCriteria.Tag = null;
            }
        }

        #endregion

        #region ICandidateInterface

        private CandidateController candidateController;
        private int candidateCounter = 0;
        public Event Competition { get; set; }

        public List<Candidate> GetCandidates()
        {
            var candidates = candidateController.GetAllCandidatesByEvent();
            return candidates;
        }

        public void SetCandidateDetails()
        {
            var candidateDetails = GetCandidates();

            if (candidateDetails.Count > 1)
            {
                lblCandidateName.Text = candidateDetails[candidateCounter].Name;
                //lblDepartmentName.Text = candidateDetails[candidateCounter].Department.Title;
                lblSchoolLevel.Text = candidateDetails[candidateCounter].Department.Title;

                ProcessorImage image = new ProcessorImage();
                deparmentLogo.Image = Image.FromFile(image.Image(candidateDetails[candidateCounter].Department.DepartmentID.ToString()));
            }
            else
            {
                MessageBox.Show("No Candidates Found for this Event");
                btnVote.Enabled = false;
                btnNextCandidate.Enabled = false;
                btnPreviousCandidate.Enabled = false;
            }
        }

        #endregion

        #region IScoringDetailsInterface

        private ScoringDetailsController scoringController;
        public Event EventIDBased { get; set; }
        public List<Criteria> CriteriaScoring { get; set; }


        public void SetScoring()
        {
            lblFirstCriteria.Text = CriteriaScoring[0].Title;
            lblSecondCriteria.Text = CriteriaScoring[1].Title;
            lblThirdCriteria.Text = CriteriaScoring[2].Title;
            lblFourthCriteria.Text = CriteriaScoring[3].Title;

            lblFirstCriteria.Tag = CriteriaScoring[0].CriteriaID.ToString();
            lblSecondCriteria.Tag = CriteriaScoring[1].CriteriaID.ToString();
            lblThirdCriteria.Tag = CriteriaScoring[2].CriteriaID.ToString();
            lblFourthCriteria.Tag = CriteriaScoring[3].CriteriaID.ToString();

            lblPercentageFirstCriteria.Text = $"{CriteriaScoring[0].Percentage.ToString()}%";
            lblPercentageSecondCriteria.Text = $"{CriteriaScoring[1].Percentage.ToString()}%";
            lblPercentageThirdCriteria.Text = $"{CriteriaScoring[2].Percentage.ToString()}%";
            lblPercentageFourthCriteria.Text = $"{CriteriaScoring[3].Percentage.ToString()}%";
        }

        #endregion

        #region IVotingInterface

        private VotingController votingController;
        private Judge JudgeData;

        public Scoring ScoreDetails { get; set; }


        private void SetVotingData()
        {

            this.ScoreDetails = new Scoring
            {
                Event = new Event { EventID = EventIDBased.EventID },
                Judge = new Judge { JudgeID = JudgeData.JudgeID },
                Candidate = new Candidate { CandidateID = GetCandidates()[candidateCounter].CandidateID },
                Criterias = CriteriaScoring,
                CriteriaScores =
                    {
                        decimal.Parse(scoreFirstCriteria.Text),
                        decimal.Parse(scoreSecondCriteria.Text),
                        decimal.Parse(scoreThirdCriteria.Text),
                        decimal.Parse(scoreFourthCriteria.Text)
                    },
                TotalPoints = (float)float.Parse(scoreFirstCriteria.Text) + float.Parse(scoreSecondCriteria.Text)
                        + float.Parse(scoreThirdCriteria.Text) + float.Parse(scoreFourthCriteria.Text)
            };
        }

        private void ResetScoring()
        {
            scoreFirstCriteria.Text = 0.ToString();
            scoreSecondCriteria.Text = 0.ToString();
            scoreThirdCriteria.Text = 0.ToString();
            scoreFourthCriteria.Text = 0.ToString();
        }

        public void SubmitVote()
        {
            SetVotingData();
            votingController.SubmitVote();

            ResetScoring();
        }

        #endregion


        private void btnPreviousCandidate_Click(object sender, EventArgs e)
        {
            if (candidateCounter > 0)
            {
                candidateCounter--;
                SetCandidateDetails();
                SetVoteLogs();
            }
        }

        private void btnNextCandidate_Click(object sender, EventArgs e)
        {
            if (candidateCounter < GetCandidates().Count - 1)
            {
                candidateCounter++;
                SetCandidateDetails();
                SetVoteLogs();
            }
            else
            {
                DialogResult finalCandidate = MessageBox.Show("Last Candidate has been voted. Thank you for your votes!\n\n\n" +
                    "Do you wish to select another event?", "Final Voting", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (finalCandidate == DialogResult.Yes)
                {
                    competition.Show();
                    this.Close();
                    this.Dispose();
                }
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(scoreFirstCriteria.Text) <= 1
                || decimal.Parse(scoreSecondCriteria.Text) <= 1
                || decimal.Parse(scoreThirdCriteria.Text) <= 1
                || decimal.Parse(scoreFourthCriteria.Text) <= 1)
            {
                DialogResult validateScore = MessageBox.Show("Some criteria points are too low, are you sure you want to save vote?", "Vote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (validateScore == DialogResult.Yes)
                {
                    if (HasFoundVoteLogs == true)
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to change your previous vote?", "Vote Log Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            UpdateVoteLogs();
                            btnNextCandidate_Click(sender, e);
                        }
                    }
                    else
                    {
                        SubmitVote();
                        btnNextCandidate_Click(sender, e);
                    }
                }
            }
            else
            {
                if (HasFoundVoteLogs == true)
                {
                    DialogResult dialog = MessageBox.Show("Are you sure you want to change your previous vote?", "Vote Log Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        UpdateVoteLogs();
                        btnNextCandidate_Click(sender, e);
                    }
                }
                else
                {
                    SubmitVote();
                    btnNextCandidate_Click(sender, e);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            competition.Show();
            this.Close();
            this.Dispose();
        }

        private void scoreFirstCriteria_TextChanged(object sender, EventArgs e)
        {
            if (scoreFirstCriteria.Text != "")
            {
                decimal value;
                if (decimal.TryParse(scoreFirstCriteria.Text, out value))
                {
                    if (value > CriteriaScoring[0].Percentage)
                    {
                        scoreFirstCriteria.Text = CriteriaScoring[0].Percentage.ToString();
                    }
                }
            }
        }

        private void scoreSecondCriteria_TextChanged(object sender, EventArgs e)
        {
            if (scoreSecondCriteria.Text != "")
            {
                decimal value;
                if (decimal.TryParse(scoreSecondCriteria.Text, out value))
                {
                    if (value > CriteriaScoring[1].Percentage)
                    {
                        scoreSecondCriteria.Text = CriteriaScoring[1].Percentage.ToString();
                    }
                }
            }
        }

        private void scoreThirdCriteria_TextChanged(object sender, EventArgs e)
        {
            if (scoreSecondCriteria.Text != "")
            {
                decimal value;
                if (decimal.TryParse(scoreThirdCriteria.Text, out value))
                {
                    if (value > CriteriaScoring[2].Percentage)
                    {
                        scoreThirdCriteria.Text = CriteriaScoring[2].Percentage.ToString();
                    }
                }
            }
        }

        private void scoreFourthCriteria_TextChanged(object sender, EventArgs e)
        {
            if (scoreFourthCriteria.Text != "")
            {
                decimal value;
                if (decimal.TryParse(scoreFourthCriteria.Text, out value))
                {
                    if (value > CriteriaScoring[3].Percentage)
                    {
                        scoreFourthCriteria.Text = CriteriaScoring[3].Percentage.ToString();
                    }
                }

                var TotalPoints = (float)float.Parse(scoreFirstCriteria.Text) + float.Parse(scoreSecondCriteria.Text)
                                + float.Parse(scoreThirdCriteria.Text) + float.Parse(scoreFourthCriteria.Text);
                lblTotalPoints.Text = TotalPoints.ToString();
            }
        }
    }
}
