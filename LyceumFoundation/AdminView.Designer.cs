namespace LyceumFoundation
{
    partial class AdminView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFourtEvent = new System.Windows.Forms.Button();
            this.btnThirdEvent = new System.Windows.Forms.Button();
            this.btnSecondEvent = new System.Windows.Forms.Button();
            this.btnFirstEvent = new System.Windows.Forms.Button();
            this.panelScoring = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 69);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1330, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 26);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Final Results";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFourtEvent);
            this.panel2.Controls.Add(this.btnThirdEvent);
            this.panel2.Controls.Add(this.btnSecondEvent);
            this.panel2.Controls.Add(this.btnFirstEvent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 614);
            this.panel2.TabIndex = 1;
            // 
            // btnFourtEvent
            // 
            this.btnFourtEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFourtEvent.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnFourtEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourtEvent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFourtEvent.ForeColor = System.Drawing.Color.White;
            this.btnFourtEvent.Location = new System.Drawing.Point(0, 201);
            this.btnFourtEvent.Name = "btnFourtEvent";
            this.btnFourtEvent.Size = new System.Drawing.Size(265, 67);
            this.btnFourtEvent.TabIndex = 3;
            this.btnFourtEvent.Text = "Musical Play Competition";
            this.btnFourtEvent.UseVisualStyleBackColor = true;
            this.btnFourtEvent.Click += new System.EventHandler(this.btnFourtEvent_Click);
            // 
            // btnThirdEvent
            // 
            this.btnThirdEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThirdEvent.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnThirdEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThirdEvent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThirdEvent.ForeColor = System.Drawing.Color.White;
            this.btnThirdEvent.Location = new System.Drawing.Point(0, 134);
            this.btnThirdEvent.Name = "btnThirdEvent";
            this.btnThirdEvent.Size = new System.Drawing.Size(265, 67);
            this.btnThirdEvent.TabIndex = 2;
            this.btnThirdEvent.Text = "Singing Competition";
            this.btnThirdEvent.UseVisualStyleBackColor = true;
            this.btnThirdEvent.Click += new System.EventHandler(this.btnThirdEvent_Click);
            // 
            // btnSecondEvent
            // 
            this.btnSecondEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecondEvent.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSecondEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondEvent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSecondEvent.ForeColor = System.Drawing.Color.White;
            this.btnSecondEvent.Location = new System.Drawing.Point(0, 67);
            this.btnSecondEvent.Name = "btnSecondEvent";
            this.btnSecondEvent.Size = new System.Drawing.Size(265, 67);
            this.btnSecondEvent.TabIndex = 1;
            this.btnSecondEvent.Text = "Street Dance Competition";
            this.btnSecondEvent.UseVisualStyleBackColor = true;
            this.btnSecondEvent.Click += new System.EventHandler(this.btnSecondEvent_Click);
            // 
            // btnFirstEvent
            // 
            this.btnFirstEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFirstEvent.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnFirstEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstEvent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirstEvent.ForeColor = System.Drawing.Color.White;
            this.btnFirstEvent.Location = new System.Drawing.Point(0, 0);
            this.btnFirstEvent.Name = "btnFirstEvent";
            this.btnFirstEvent.Size = new System.Drawing.Size(265, 67);
            this.btnFirstEvent.TabIndex = 0;
            this.btnFirstEvent.Text = "Hip-Hop Dance Competition";
            this.btnFirstEvent.UseVisualStyleBackColor = true;
            this.btnFirstEvent.Click += new System.EventHandler(this.btnFirstEvent_Click);
            // 
            // panelScoring
            // 
            this.panelScoring.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScoring.Location = new System.Drawing.Point(265, 69);
            this.panelScoring.Name = "panelScoring";
            this.panelScoring.Size = new System.Drawing.Size(1105, 614);
            this.panelScoring.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(265, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 614);
            this.panel3.TabIndex = 0;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1370, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelScoring);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelScoring;
        private System.Windows.Forms.Button btnFourtEvent;
        private System.Windows.Forms.Button btnThirdEvent;
        private System.Windows.Forms.Button btnSecondEvent;
        private System.Windows.Forms.Button btnFirstEvent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
    }
}