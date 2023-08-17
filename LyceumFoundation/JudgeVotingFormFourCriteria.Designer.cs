namespace LyceumFoundation
{
    partial class JudgeVotingFormFourCriteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JudgeVotingFormFourCriteria));
            this.scoreFourthCriteria = new System.Windows.Forms.TextBox();
            this.scoreThirdCriteria = new System.Windows.Forms.TextBox();
            this.scoreSecondCriteria = new System.Windows.Forms.TextBox();
            this.scoreFirstCriteria = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.deparmentLogo = new System.Windows.Forms.PictureBox();
            this.lblJudge = new System.Windows.Forms.Label();
            this.lblSchoolLevel = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblCompetitionName = new System.Windows.Forms.Label();
            this.lblCandidateName = new System.Windows.Forms.Label();
            this.btnNextCandidate = new System.Windows.Forms.Button();
            this.btnPreviousCandidate = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.lblPercentageFourthCriteria = new System.Windows.Forms.Label();
            this.lblPercentageThirdCriteria = new System.Windows.Forms.Label();
            this.lblPercentageSecondCriteria = new System.Windows.Forms.Label();
            this.lblPercentageFirstCriteria = new System.Windows.Forms.Label();
            this.lblFourthCriteria = new System.Windows.Forms.Label();
            this.lblThirdCriteria = new System.Windows.Forms.Label();
            this.lblSecondCriteria = new System.Windows.Forms.Label();
            this.lblFirstCriteria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deparmentLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreFourthCriteria
            // 
            this.scoreFourthCriteria.Font = new System.Drawing.Font("Guardians", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreFourthCriteria.Location = new System.Drawing.Point(662, 579);
            this.scoreFourthCriteria.Name = "scoreFourthCriteria";
            this.scoreFourthCriteria.Size = new System.Drawing.Size(100, 40);
            this.scoreFourthCriteria.TabIndex = 34;
            this.scoreFourthCriteria.Click += new System.EventHandler(this.SelectAllText);
            this.scoreFourthCriteria.TextChanged += new System.EventHandler(this.scoreFourthCriteria_TextChanged);
            this.scoreFourthCriteria.Enter += new System.EventHandler(this.SelectAllText);
            this.scoreFourthCriteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDigitOnly_KeyPress);
            // 
            // scoreThirdCriteria
            // 
            this.scoreThirdCriteria.Font = new System.Drawing.Font("Guardians", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreThirdCriteria.Location = new System.Drawing.Point(449, 579);
            this.scoreThirdCriteria.Name = "scoreThirdCriteria";
            this.scoreThirdCriteria.Size = new System.Drawing.Size(100, 40);
            this.scoreThirdCriteria.TabIndex = 32;
            this.scoreThirdCriteria.Click += new System.EventHandler(this.SelectAllText);
            this.scoreThirdCriteria.Enter += new System.EventHandler(this.SelectAllText);
            this.scoreThirdCriteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDigitOnly_KeyPress);
            // 
            // scoreSecondCriteria
            // 
            this.scoreSecondCriteria.Font = new System.Drawing.Font("Guardians", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreSecondCriteria.Location = new System.Drawing.Point(232, 579);
            this.scoreSecondCriteria.Name = "scoreSecondCriteria";
            this.scoreSecondCriteria.Size = new System.Drawing.Size(100, 40);
            this.scoreSecondCriteria.TabIndex = 31;
            this.scoreSecondCriteria.Click += new System.EventHandler(this.SelectAllText);
            this.scoreSecondCriteria.Enter += new System.EventHandler(this.SelectAllText);
            this.scoreSecondCriteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDigitOnly_KeyPress);
            // 
            // scoreFirstCriteria
            // 
            this.scoreFirstCriteria.Font = new System.Drawing.Font("Guardians", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreFirstCriteria.Location = new System.Drawing.Point(34, 579);
            this.scoreFirstCriteria.Name = "scoreFirstCriteria";
            this.scoreFirstCriteria.Size = new System.Drawing.Size(100, 40);
            this.scoreFirstCriteria.TabIndex = 30;
            this.scoreFirstCriteria.Click += new System.EventHandler(this.SelectAllText);
            this.scoreFirstCriteria.TextChanged += new System.EventHandler(this.scoreFirstCriteria_TextChanged);
            this.scoreFirstCriteria.Enter += new System.EventHandler(this.SelectAllText);
            this.scoreFirstCriteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDigitOnly_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(964, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 51);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // deparmentLogo
            // 
            this.deparmentLogo.BackColor = System.Drawing.Color.Transparent;
            this.deparmentLogo.Location = new System.Drawing.Point(122, 201);
            this.deparmentLogo.Name = "deparmentLogo";
            this.deparmentLogo.Size = new System.Drawing.Size(280, 280);
            this.deparmentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deparmentLogo.TabIndex = 51;
            this.deparmentLogo.TabStop = false;
            // 
            // lblJudge
            // 
            this.lblJudge.AutoSize = true;
            this.lblJudge.BackColor = System.Drawing.Color.Transparent;
            this.lblJudge.Font = new System.Drawing.Font("Arkitech", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJudge.ForeColor = System.Drawing.Color.White;
            this.lblJudge.Location = new System.Drawing.Point(17, 730);
            this.lblJudge.Name = "lblJudge";
            this.lblJudge.Size = new System.Drawing.Size(157, 18);
            this.lblJudge.TabIndex = 50;
            this.lblJudge.Text = "Total Score:";
            // 
            // lblSchoolLevel
            // 
            this.lblSchoolLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolLevel.Font = new System.Drawing.Font("Guardians", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSchoolLevel.ForeColor = System.Drawing.Color.Gold;
            this.lblSchoolLevel.Location = new System.Drawing.Point(436, 268);
            this.lblSchoolLevel.Name = "lblSchoolLevel";
            this.lblSchoolLevel.Size = new System.Drawing.Size(502, 85);
            this.lblSchoolLevel.TabIndex = 49;
            this.lblSchoolLevel.Text = "STEM";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalPoints.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblTotalPoints.Location = new System.Drawing.Point(854, 565);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(142, 60);
            this.lblTotalPoints.TabIndex = 48;
            this.lblTotalPoints.Text = "100%";
            this.lblTotalPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCompetitionName
            // 
            this.lblCompetitionName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetitionName.Font = new System.Drawing.Font("Wonderful Night Personal Use", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCompetitionName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblCompetitionName.Location = new System.Drawing.Point(139, 93);
            this.lblCompetitionName.Name = "lblCompetitionName";
            this.lblCompetitionName.Size = new System.Drawing.Size(747, 96);
            this.lblCompetitionName.TabIndex = 46;
            this.lblCompetitionName.Text = "Competition Name";
            this.lblCompetitionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCandidateName
            // 
            this.lblCandidateName.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidateName.Font = new System.Drawing.Font("HP Simplified Hans", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCandidateName.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblCandidateName.Location = new System.Drawing.Point(425, 344);
            this.lblCandidateName.Name = "lblCandidateName";
            this.lblCandidateName.Size = new System.Drawing.Size(571, 135);
            this.lblCandidateName.TabIndex = 45;
            this.lblCandidateName.Text = "Justin Bieber";
            // 
            // btnNextCandidate
            // 
            this.btnNextCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNextCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCandidate.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNextCandidate.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnNextCandidate.Location = new System.Drawing.Point(607, 689);
            this.btnNextCandidate.Name = "btnNextCandidate";
            this.btnNextCandidate.Size = new System.Drawing.Size(152, 41);
            this.btnNextCandidate.TabIndex = 44;
            this.btnNextCandidate.Text = "NEXT";
            this.btnNextCandidate.UseVisualStyleBackColor = true;
            this.btnNextCandidate.Click += new System.EventHandler(this.btnNextCandidate_Click);
            // 
            // btnPreviousCandidate
            // 
            this.btnPreviousCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPreviousCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousCandidate.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreviousCandidate.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnPreviousCandidate.Location = new System.Drawing.Point(271, 689);
            this.btnPreviousCandidate.Name = "btnPreviousCandidate";
            this.btnPreviousCandidate.Size = new System.Drawing.Size(152, 41);
            this.btnPreviousCandidate.TabIndex = 43;
            this.btnPreviousCandidate.Text = "PREVIOUS";
            this.btnPreviousCandidate.UseVisualStyleBackColor = true;
            this.btnPreviousCandidate.Click += new System.EventHandler(this.btnPreviousCandidate_Click);
            // 
            // btnVote
            // 
            this.btnVote.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVote.Font = new System.Drawing.Font("HP Simplified Hans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVote.Location = new System.Drawing.Point(434, 681);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(162, 57);
            this.btnVote.TabIndex = 42;
            this.btnVote.Text = "LOCKDOWN";
            this.btnVote.UseVisualStyleBackColor = false;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // lblPercentageFourthCriteria
            // 
            this.lblPercentageFourthCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentageFourthCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPercentageFourthCriteria.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblPercentageFourthCriteria.Location = new System.Drawing.Point(768, 588);
            this.lblPercentageFourthCriteria.Name = "lblPercentageFourthCriteria";
            this.lblPercentageFourthCriteria.Size = new System.Drawing.Size(55, 22);
            this.lblPercentageFourthCriteria.TabIndex = 41;
            this.lblPercentageFourthCriteria.Text = "%%";
            // 
            // lblPercentageThirdCriteria
            // 
            this.lblPercentageThirdCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentageThirdCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPercentageThirdCriteria.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblPercentageThirdCriteria.Location = new System.Drawing.Point(555, 588);
            this.lblPercentageThirdCriteria.Name = "lblPercentageThirdCriteria";
            this.lblPercentageThirdCriteria.Size = new System.Drawing.Size(55, 22);
            this.lblPercentageThirdCriteria.TabIndex = 40;
            this.lblPercentageThirdCriteria.Text = "%%";
            // 
            // lblPercentageSecondCriteria
            // 
            this.lblPercentageSecondCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentageSecondCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPercentageSecondCriteria.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblPercentageSecondCriteria.Location = new System.Drawing.Point(338, 588);
            this.lblPercentageSecondCriteria.Name = "lblPercentageSecondCriteria";
            this.lblPercentageSecondCriteria.Size = new System.Drawing.Size(55, 22);
            this.lblPercentageSecondCriteria.TabIndex = 39;
            this.lblPercentageSecondCriteria.Text = "%%";
            // 
            // lblPercentageFirstCriteria
            // 
            this.lblPercentageFirstCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentageFirstCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblPercentageFirstCriteria.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblPercentageFirstCriteria.Location = new System.Drawing.Point(140, 588);
            this.lblPercentageFirstCriteria.Name = "lblPercentageFirstCriteria";
            this.lblPercentageFirstCriteria.Size = new System.Drawing.Size(55, 22);
            this.lblPercentageFirstCriteria.TabIndex = 38;
            this.lblPercentageFirstCriteria.Text = "%%";
            // 
            // lblFourthCriteria
            // 
            this.lblFourthCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblFourthCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFourthCriteria.ForeColor = System.Drawing.Color.Gold;
            this.lblFourthCriteria.Location = new System.Drawing.Point(662, 549);
            this.lblFourthCriteria.Name = "lblFourthCriteria";
            this.lblFourthCriteria.Size = new System.Drawing.Size(172, 22);
            this.lblFourthCriteria.TabIndex = 37;
            this.lblFourthCriteria.Text = " ";
            this.lblFourthCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdCriteria
            // 
            this.lblThirdCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblThirdCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblThirdCriteria.ForeColor = System.Drawing.Color.Gold;
            this.lblThirdCriteria.Location = new System.Drawing.Point(447, 549);
            this.lblThirdCriteria.Name = "lblThirdCriteria";
            this.lblThirdCriteria.Size = new System.Drawing.Size(172, 22);
            this.lblThirdCriteria.TabIndex = 35;
            this.lblThirdCriteria.Text = " ";
            this.lblThirdCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondCriteria
            // 
            this.lblSecondCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblSecondCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSecondCriteria.ForeColor = System.Drawing.Color.Gold;
            this.lblSecondCriteria.Location = new System.Drawing.Point(232, 549);
            this.lblSecondCriteria.Name = "lblSecondCriteria";
            this.lblSecondCriteria.Size = new System.Drawing.Size(172, 22);
            this.lblSecondCriteria.TabIndex = 33;
            this.lblSecondCriteria.Text = " ";
            this.lblSecondCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstCriteria
            // 
            this.lblFirstCriteria.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstCriteria.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFirstCriteria.ForeColor = System.Drawing.Color.Gold;
            this.lblFirstCriteria.Location = new System.Drawing.Point(17, 549);
            this.lblFirstCriteria.Name = "lblFirstCriteria";
            this.lblFirstCriteria.Size = new System.Drawing.Size(172, 22);
            this.lblFirstCriteria.TabIndex = 29;
            this.lblFirstCriteria.Text = " ";
            this.lblFirstCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JudgeVotingFormFourCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.scoreFourthCriteria);
            this.Controls.Add(this.scoreThirdCriteria);
            this.Controls.Add(this.scoreSecondCriteria);
            this.Controls.Add(this.scoreFirstCriteria);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.deparmentLogo);
            this.Controls.Add(this.lblJudge);
            this.Controls.Add(this.lblSchoolLevel);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.lblCompetitionName);
            this.Controls.Add(this.lblCandidateName);
            this.Controls.Add(this.btnNextCandidate);
            this.Controls.Add(this.btnPreviousCandidate);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.lblPercentageFourthCriteria);
            this.Controls.Add(this.lblPercentageThirdCriteria);
            this.Controls.Add(this.lblPercentageSecondCriteria);
            this.Controls.Add(this.lblPercentageFirstCriteria);
            this.Controls.Add(this.lblFourthCriteria);
            this.Controls.Add(this.lblThirdCriteria);
            this.Controls.Add(this.lblSecondCriteria);
            this.Controls.Add(this.lblFirstCriteria);
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JudgeVotingFormFourCriteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%%";
            ((System.ComponentModel.ISupportInitialize)(this.deparmentLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox scoreFourthCriteria;
        private System.Windows.Forms.TextBox scoreThirdCriteria;
        private System.Windows.Forms.TextBox scoreSecondCriteria;
        private System.Windows.Forms.TextBox scoreFirstCriteria;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox deparmentLogo;
        private System.Windows.Forms.Label lblJudge;
        private System.Windows.Forms.Label lblSchoolLevel;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblCompetitionName;
        private System.Windows.Forms.Label lblCandidateName;
        private System.Windows.Forms.Button btnNextCandidate;
        private System.Windows.Forms.Button btnPreviousCandidate;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Label lblPercentageFourthCriteria;
        private System.Windows.Forms.Label lblPercentageThirdCriteria;
        private System.Windows.Forms.Label lblPercentageSecondCriteria;
        private System.Windows.Forms.Label lblPercentageFirstCriteria;
        private System.Windows.Forms.Label lblFourthCriteria;
        private System.Windows.Forms.Label lblThirdCriteria;
        private System.Windows.Forms.Label lblSecondCriteria;
        private System.Windows.Forms.Label lblFirstCriteria;
    }
}