namespace FitnessTrackingApp
{
    partial class GoalSettingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaloriesToBurn = new System.Windows.Forms.TextBox();
            this.btnSaveGoals = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGoalType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target Value";
            // 
            // txtTargetValue
            // 
            this.txtTargetValue.Location = new System.Drawing.Point(306, 122);
            this.txtTargetValue.Multiline = true;
            this.txtTargetValue.Name = "txtTargetValue";
            this.txtTargetValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtTargetValue.Size = new System.Drawing.Size(161, 39);
            this.txtTargetValue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Calorites to Burn";
            // 
            // txtCaloriesToBurn
            // 
            this.txtCaloriesToBurn.Location = new System.Drawing.Point(306, 206);
            this.txtCaloriesToBurn.Multiline = true;
            this.txtCaloriesToBurn.Name = "txtCaloriesToBurn";
            this.txtCaloriesToBurn.Size = new System.Drawing.Size(161, 39);
            this.txtCaloriesToBurn.TabIndex = 4;
            // 
            // btnSaveGoals
            // 
            this.btnSaveGoals.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGoals.Location = new System.Drawing.Point(86, 278);
            this.btnSaveGoals.Name = "btnSaveGoals";
            this.btnSaveGoals.Size = new System.Drawing.Size(134, 48);
            this.btnSaveGoals.TabIndex = 5;
            this.btnSaveGoals.Text = "Save Goal";
            this.btnSaveGoals.UseVisualStyleBackColor = false;
            this.btnSaveGoals.Click += new System.EventHandler(this.btnSaveGoals_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(333, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 48);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Goal Type";
            // 
            // cmbGoalType
            // 
            this.cmbGoalType.FormattingEnabled = true;
            this.cmbGoalType.Items.AddRange(new object[] {
            "Walking",
            "Running",
            "Swimming",
            "Cycling ",
            "Weightlifting ",
            "Yoga"});
            this.cmbGoalType.Location = new System.Drawing.Point(306, 48);
            this.cmbGoalType.Name = "cmbGoalType";
            this.cmbGoalType.Size = new System.Drawing.Size(161, 28);
            this.cmbGoalType.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbGoalType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTargetValue);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnSaveGoals);
            this.panel1.Controls.Add(this.txtCaloriesToBurn);
            this.panel1.Location = new System.Drawing.Point(150, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 388);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(161, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 57);
            this.label1.TabIndex = 13;
            this.label1.Text = "GOAL SETTING FORM";
            // 
            // GoalSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoalSettingForm";
            this.Text = "GoalSettingForm";
            this.Load += new System.EventHandler(this.GoalSettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTargetValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaloriesToBurn;
        private System.Windows.Forms.Button btnSaveGoals;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGoalType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}