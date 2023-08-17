namespace LyceumFoundation
{
    partial class AdminResultsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.resultRefresher = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listResultsSHS = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listResultCollege = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listResults = new System.Windows.Forms.ListView();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(21, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(476, 72);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Results";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // resultRefresher
            // 
            this.resultRefresher.Enabled = true;
            this.resultRefresher.Interval = 3000;
            this.resultRefresher.Tick += new System.EventHandler(this.resultRefresher_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(92, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 1);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Judges Vote";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.listResultsSHS);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(553, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 234);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senior High School";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "- Top 3 Candidates";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(228)))), ((int)(((byte)(146)))));
            this.panel2.Location = new System.Drawing.Point(11, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 8;
            // 
            // listResultsSHS
            // 
            this.listResultsSHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.listResultsSHS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader8,
            this.columnHeader5});
            this.listResultsSHS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listResultsSHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listResultsSHS.FullRowSelect = true;
            this.listResultsSHS.HideSelection = false;
            this.listResultsSHS.Location = new System.Drawing.Point(11, 26);
            this.listResultsSHS.Name = "listResultsSHS";
            this.listResultsSHS.Size = new System.Drawing.Size(507, 183);
            this.listResultsSHS.TabIndex = 8;
            this.listResultsSHS.UseCompatibleStateImageBehavior = false;
            this.listResultsSHS.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Deparment";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Candidate Name";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Final Score";
            this.columnHeader5.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.listResultCollege);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(553, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 245);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "College";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "- Top 3 Candidates";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(228)))), ((int)(((byte)(146)))));
            this.panel3.Location = new System.Drawing.Point(11, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 10;
            // 
            // listResultCollege
            // 
            this.listResultCollege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.listResultCollege.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7});
            this.listResultCollege.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listResultCollege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listResultCollege.FullRowSelect = true;
            this.listResultCollege.HideSelection = false;
            this.listResultCollege.Location = new System.Drawing.Point(11, 31);
            this.listResultCollege.Name = "listResultCollege";
            this.listResultCollege.Size = new System.Drawing.Size(507, 183);
            this.listResultCollege.TabIndex = 9;
            this.listResultCollege.UseCompatibleStateImageBehavior = false;
            this.listResultCollege.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Deparment";
            this.columnHeader6.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Candidate Name";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Final Score";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Department";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Judge";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Judge Point";
            this.columnHeader2.Width = 100;
            // 
            // listResults
            // 
            this.listResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.listResults.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listResults.FullRowSelect = true;
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(21, 129);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(526, 434);
            this.listResults.TabIndex = 0;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(163, 571);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(214, 25);
            this.cmbDepartment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 575);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sort by Candidates:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Lime;
            this.btnRefresh.Location = new System.Drawing.Point(383, 570);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 27);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // AdminResultsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.listResults);
            this.Name = "AdminResultsView";
            this.Size = new System.Drawing.Size(1085, 614);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Timer resultRefresher;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listResultsSHS;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView listResultCollege;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
    }
}
