using FoundationLibrary.Controller;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LyceumFoundation
{
    public partial class AdminResultsView : UserControl, IResultsView, ICandidate
    {
        public Event Competition { get; set; }
        private ResultsController resultController;
        private CandidateController candidateController;
        public AdminResultsView(Event Competition)
        {
            InitializeComponent();

            this.Competition = Competition;
            resultController = new ResultsController(this);
            candidateController = new CandidateController(this);

            lblHeader.Text = $"Results for {Competition.Title}";

            SetResults("");
            CollegeFinalResults();
            SHSFinalResults(); 
            SetCandidateDetails();
        }

        public List<Candidate> GetCandidates()
        {
            return candidateController.GetAllCandidatesByEvent();
        }

        public void SetCandidateDetails()
        {
            foreach (var candidate in GetCandidates())
            {
                cmbDepartment.Items.Add(candidate.Name);
            }
        }

        public void SetResults(string SchooLevel)
        {
            var results = resultController.GetAllScores(SchooLevel);
            listResults.Items.Clear();


            foreach (var result in results)
            {
                ListViewItem items = new ListViewItem();
                items = listResults.Items.Add($"{result.Candidate.Department.Title}");
                items.SubItems.Add(result.Judge.Name.ToString());
                items.SubItems.Add(result.TotalPoints.ToString());
            }
        }

        public List<Scoring> SetFinalResults(string SchoolLevel)
        {
            var finalResults = resultController.FinalResult(SchoolLevel);
            return finalResults;
        }

        private int counter = 0;
        private void CollegeFinalResults()
        {
            var collegeResults = SetFinalResults("College");
            listResultCollege.Items.Clear();

            foreach (var result in collegeResults)
            {
                ListViewItem items = new ListViewItem();
                
                items = listResultCollege.Items.Add(result.Candidate.Department.Title);
                
                items.SubItems.Add(result.Candidate.Name);
                items.SubItems.Add(result.TotalPoints.ToString());
                if (counter < 3)
                {
                    items.ForeColor = Color.FromArgb(26, 41, 48);
                    items.BackColor = Color.FromArgb(146, 228, 146);
                }
                counter++;
            }
        }

        private void SHSFinalResults()
        {
            var collegeResults = SetFinalResults("Senior High School");
            listResultsSHS.Items.Clear();

            foreach (var result in collegeResults)
            {
                ListViewItem items = new ListViewItem();
                
                items = listResultsSHS.Items.Add(result.Candidate.Department.Title);
                
                items.SubItems.Add(result.Candidate.Name);
                items.SubItems.Add(result.TotalPoints.ToString());
                if (counter < 3)
                {
                    items.ForeColor = Color.FromArgb(26, 41, 48);
                    items.BackColor = Color.FromArgb(146, 228, 146);
                }

                counter++;
            }
        }

        private void resultRefresher_Tick(object sender, EventArgs e)
        {
            if (cmbDepartment.Text == "")
            {
                SetResults("");
            }
            else
            {
                SetResults(cmbDepartment.Text);
            }
            
            CollegeFinalResults();
            SHSFinalResults();

            counter = 0;
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SetResults("");
            cmbDepartment.Text = "";
        }
    }
}
