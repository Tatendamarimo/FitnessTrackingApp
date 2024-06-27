namespace FitnessTrackingApp
{
    partial class MonitoringProgressForm
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cmbActivityType = new System.Windows.Forms.ComboBox();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtGoalAchievement = new System.Windows.Forms.RichTextBox();
            this.richTxtCaloriesBurned = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(329, 421);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 45);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cmbActivityType
            // 
            this.cmbActivityType.FormattingEnabled = true;
            this.cmbActivityType.Location = new System.Drawing.Point(286, 221);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(121, 28);
            this.cmbActivityType.TabIndex = 7;
            this.cmbActivityType.SelectedIndexChanged += new System.EventHandler(this.cmbActivityType_SelectedIndexChanged_1);
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.Location = new System.Drawing.Point(24, 264);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(83, 25);
            this.lblMetric1.TabIndex = 8;
            this.lblMetric1.Text = "Metric1";
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.Location = new System.Drawing.Point(24, 302);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(83, 25);
            this.lblMetric2.TabIndex = 9;
            this.lblMetric2.Text = "Metric2";
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.Location = new System.Drawing.Point(24, 345);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(83, 25);
            this.lblMetric3.TabIndex = 10;
            this.lblMetric3.Text = "Metric3";
            // 
            // dgvGoals
            // 
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoals.Location = new System.Drawing.Point(24, 13);
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.RowHeadersWidth = 62;
            this.dgvGoals.RowTemplate.Height = 28;
            this.dgvGoals.Size = new System.Drawing.Size(720, 186);
            this.dgvGoals.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtMetric3);
            this.panel1.Controls.Add(this.txtMetric2);
            this.panel1.Controls.Add(this.txtMetric1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTxtGoalAchievement);
            this.panel1.Controls.Add(this.richTxtCaloriesBurned);
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.dgvGoals);
            this.panel1.Controls.Add(this.lblMetric3);
            this.panel1.Controls.Add(this.cmbActivityType);
            this.panel1.Controls.Add(this.lblMetric2);
            this.panel1.Controls.Add(this.lblMetric1);
            this.panel1.Location = new System.Drawing.Point(66, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 503);
            this.panel1.TabIndex = 14;
            // 
            // txtMetric3
            // 
            this.txtMetric3.Location = new System.Drawing.Point(287, 347);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(120, 26);
            this.txtMetric3.TabIndex = 19;
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(286, 307);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(120, 26);
            this.txtMetric2.TabIndex = 18;
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(286, 263);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(120, 26);
            this.txtMetric1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activity";
            // 
            // richTxtGoalAchievement
            // 
            this.richTxtGoalAchievement.Location = new System.Drawing.Point(528, 305);
            this.richTxtGoalAchievement.Name = "richTxtGoalAchievement";
            this.richTxtGoalAchievement.ReadOnly = true;
            this.richTxtGoalAchievement.Size = new System.Drawing.Size(216, 63);
            this.richTxtGoalAchievement.TabIndex = 15;
            this.richTxtGoalAchievement.Text = "";
            // 
            // richTxtCaloriesBurned
            // 
            this.richTxtCaloriesBurned.Location = new System.Drawing.Point(528, 216);
            this.richTxtCaloriesBurned.Name = "richTxtCaloriesBurned";
            this.richTxtCaloriesBurned.ReadOnly = true;
            this.richTxtCaloriesBurned.Size = new System.Drawing.Size(216, 68);
            this.richTxtCaloriesBurned.TabIndex = 14;
            this.richTxtCaloriesBurned.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(219, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 58);
            this.label2.TabIndex = 15;
            this.label2.Text = "PROGRESS FORM";
            // 
            // MonitoringProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitoringProgressForm";
            this.Text = "MonitoringProgressForm";
            this.Load += new System.EventHandler(this.MonitoringProgressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTxtCaloriesBurned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtGoalAchievement;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.Label label2;
    }
}