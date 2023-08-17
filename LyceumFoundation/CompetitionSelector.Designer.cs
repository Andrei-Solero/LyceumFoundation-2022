namespace LyceumFoundation
{
    partial class CompetitionSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionSelector));
            this.btnSinging = new System.Windows.Forms.Button();
            this.btnMusical = new System.Windows.Forms.Button();
            this.btnHiphop = new System.Windows.Forms.Button();
            this.btnStreetDance = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinging
            // 
            this.btnSinging.BackColor = System.Drawing.Color.Maroon;
            this.btnSinging.FlatAppearance.BorderSize = 3;
            this.btnSinging.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinging.Font = new System.Drawing.Font("Guardians", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSinging.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSinging.Location = new System.Drawing.Point(297, 599);
            this.btnSinging.Name = "btnSinging";
            this.btnSinging.Size = new System.Drawing.Size(424, 53);
            this.btnSinging.TabIndex = 7;
            this.btnSinging.Text = "Singing";
            this.btnSinging.UseVisualStyleBackColor = false;
            this.btnSinging.Click += new System.EventHandler(this.btnSinging_Click);
            // 
            // btnMusical
            // 
            this.btnMusical.BackColor = System.Drawing.Color.Maroon;
            this.btnMusical.FlatAppearance.BorderSize = 3;
            this.btnMusical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusical.Font = new System.Drawing.Font("Guardians", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMusical.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMusical.Location = new System.Drawing.Point(297, 472);
            this.btnMusical.Name = "btnMusical";
            this.btnMusical.Size = new System.Drawing.Size(424, 53);
            this.btnMusical.TabIndex = 6;
            this.btnMusical.Text = "Musical Play";
            this.btnMusical.UseVisualStyleBackColor = false;
            this.btnMusical.Click += new System.EventHandler(this.btnMusical_Click);
            // 
            // btnHiphop
            // 
            this.btnHiphop.BackColor = System.Drawing.Color.Maroon;
            this.btnHiphop.FlatAppearance.BorderSize = 3;
            this.btnHiphop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiphop.Font = new System.Drawing.Font("Guardians", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHiphop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHiphop.Location = new System.Drawing.Point(297, 344);
            this.btnHiphop.Name = "btnHiphop";
            this.btnHiphop.Size = new System.Drawing.Size(424, 53);
            this.btnHiphop.TabIndex = 5;
            this.btnHiphop.Text = "Hip-Hop";
            this.btnHiphop.UseVisualStyleBackColor = false;
            this.btnHiphop.Click += new System.EventHandler(this.btnHiphop_Click);
            // 
            // btnStreetDance
            // 
            this.btnStreetDance.BackColor = System.Drawing.Color.Maroon;
            this.btnStreetDance.FlatAppearance.BorderSize = 3;
            this.btnStreetDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStreetDance.Font = new System.Drawing.Font("Guardians", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStreetDance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStreetDance.Location = new System.Drawing.Point(297, 218);
            this.btnStreetDance.Name = "btnStreetDance";
            this.btnStreetDance.Size = new System.Drawing.Size(424, 53);
            this.btnStreetDance.TabIndex = 4;
            this.btnStreetDance.Text = "Street Dance Competition";
            this.btnStreetDance.UseVisualStyleBackColor = false;
            this.btnStreetDance.Click += new System.EventHandler(this.btnStreetDance_Click);
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
            this.btnClose.Location = new System.Drawing.Point(964, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 51);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CompetitionSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSinging);
            this.Controls.Add(this.btnMusical);
            this.Controls.Add(this.btnHiphop);
            this.Controls.Add(this.btnStreetDance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompetitionSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompetitionSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinging;
        private System.Windows.Forms.Button btnMusical;
        private System.Windows.Forms.Button btnHiphop;
        private System.Windows.Forms.Button btnStreetDance;
        private System.Windows.Forms.Button btnClose;
    }
}