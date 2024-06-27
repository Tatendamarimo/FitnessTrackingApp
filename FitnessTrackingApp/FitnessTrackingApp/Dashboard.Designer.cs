namespace FitnessTrackingApp
{
    partial class Dashboard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMonitoringPregress = new System.Windows.Forms.Button();
            this.panelside = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnActivityForm = new System.Windows.Forms.Button();
            this.btnGoalForm = new System.Windows.Forms.Button();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelside.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessTrackingApp.Properties.Resources.ft;
            this.pictureBox1.Location = new System.Drawing.Point(72, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 154);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnMonitoringPregress
            // 
            this.btnMonitoringPregress.BackColor = System.Drawing.Color.DimGray;
            this.btnMonitoringPregress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMonitoringPregress.FlatAppearance.BorderSize = 0;
            this.btnMonitoringPregress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitoringPregress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoringPregress.ForeColor = System.Drawing.Color.White;
            this.btnMonitoringPregress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitoringPregress.Location = new System.Drawing.Point(0, 353);
            this.btnMonitoringPregress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMonitoringPregress.Name = "btnMonitoringPregress";
            this.btnMonitoringPregress.Size = new System.Drawing.Size(300, 46);
            this.btnMonitoringPregress.TabIndex = 2;
            this.btnMonitoringPregress.Text = "Monitor Progress ";
            this.btnMonitoringPregress.UseVisualStyleBackColor = false;
            this.btnMonitoringPregress.Click += new System.EventHandler(this.btnMonitoringPregress_Click);
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DimGray;
            this.panelside.Controls.Add(this.btnExit);
            this.panelside.Controls.Add(this.lblUsername);
            this.panelside.Controls.Add(this.btnActivityForm);
            this.panelside.Controls.Add(this.btnGoalForm);
            this.panelside.Controls.Add(this.btnMonitoringPregress);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 46);
            this.panelside.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(300, 646);
            this.panelside.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 409);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(300, 46);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(50, 597);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(88, 21);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // btnActivityForm
            // 
            this.btnActivityForm.BackColor = System.Drawing.Color.DimGray;
            this.btnActivityForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActivityForm.FlatAppearance.BorderSize = 0;
            this.btnActivityForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivityForm.ForeColor = System.Drawing.Color.White;
            this.btnActivityForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivityForm.Location = new System.Drawing.Point(0, 297);
            this.btnActivityForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActivityForm.Name = "btnActivityForm";
            this.btnActivityForm.Size = new System.Drawing.Size(300, 46);
            this.btnActivityForm.TabIndex = 5;
            this.btnActivityForm.Text = "Record Activity ";
            this.btnActivityForm.UseVisualStyleBackColor = false;
            this.btnActivityForm.Click += new System.EventHandler(this.btnActivityForm_Click_1);
            // 
            // btnGoalForm
            // 
            this.btnGoalForm.BackColor = System.Drawing.Color.DimGray;
            this.btnGoalForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoalForm.FlatAppearance.BorderSize = 0;
            this.btnGoalForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoalForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoalForm.ForeColor = System.Drawing.Color.White;
            this.btnGoalForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoalForm.Location = new System.Drawing.Point(0, 241);
            this.btnGoalForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGoalForm.Name = "btnGoalForm";
            this.btnGoalForm.Size = new System.Drawing.Size(300, 46);
            this.btnGoalForm.TabIndex = 4;
            this.btnGoalForm.Text = "Set Goal";
            this.btnGoalForm.UseVisualStyleBackColor = false;
            this.btnGoalForm.Click += new System.EventHandler(this.btnGoalForm_Click_1);
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(23, 28);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(103, 24);
            this.lblWelcomeMessage.TabIndex = 0;
            this.lblWelcomeMessage.Text = "Welcome";
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.lblWelcomeMessage);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(300, 46);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(900, 646);
            this.mainpanel.TabIndex = 4;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(1155, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(45, 46);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1200, 46);
            this.panelheader.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelside.ResumeLayout(false);
            this.panelside.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMonitoringPregress;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnActivityForm;
        private System.Windows.Forms.Button btnGoalForm;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnExit;
    }
}