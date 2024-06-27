namespace FitnessTrackingApp
{
    partial class ActivityForm
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
            this.cmbActivityType = new System.Windows.Forms.ComboBox();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.btnSaveActivity = new System.Windows.Forms.Button();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbActivityType
            // 
            this.cmbActivityType.FormattingEnabled = true;
            this.cmbActivityType.Location = new System.Drawing.Point(370, 76);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(121, 28);
            this.cmbActivityType.TabIndex = 0;
            this.cmbActivityType.SelectedIndexChanged += new System.EventHandler(this.cmbActivityType_SelectedIndexChanged_1);
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(370, 136);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(121, 26);
            this.txtMetric1.TabIndex = 1;
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(370, 187);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(121, 26);
            this.txtMetric2.TabIndex = 2;
            // 
            // txtMetric3
            // 
            this.txtMetric3.Location = new System.Drawing.Point(370, 251);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(121, 26);
            this.txtMetric3.TabIndex = 3;
            // 
            // btnSaveActivity
            // 
            this.btnSaveActivity.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSaveActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveActivity.Location = new System.Drawing.Point(102, 313);
            this.btnSaveActivity.Name = "btnSaveActivity";
            this.btnSaveActivity.Size = new System.Drawing.Size(123, 47);
            this.btnSaveActivity.TabIndex = 7;
            this.btnSaveActivity.Text = "Save";
            this.btnSaveActivity.UseVisualStyleBackColor = false;
            this.btnSaveActivity.Click += new System.EventHandler(this.btnSaveActivity_Click);
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.Location = new System.Drawing.Point(76, 131);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(83, 25);
            this.lblMetric1.TabIndex = 8;
            this.lblMetric1.Text = "Metric1";
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.Location = new System.Drawing.Point(76, 188);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(83, 25);
            this.lblMetric2.TabIndex = 9;
            this.lblMetric2.Text = "Metric2";
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.Location = new System.Drawing.Point(76, 252);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(83, 25);
            this.lblMetric3.TabIndex = 10;
            this.lblMetric3.Text = "Metric3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Activity Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbActivityType);
            this.panel1.Controls.Add(this.lblMetric3);
            this.panel1.Controls.Add(this.txtMetric1);
            this.panel1.Controls.Add(this.lblMetric2);
            this.panel1.Controls.Add(this.txtMetric2);
            this.panel1.Controls.Add(this.lblMetric1);
            this.panel1.Controls.Add(this.txtMetric3);
            this.panel1.Controls.Add(this.btnSaveActivity);
            this.panel1.Location = new System.Drawing.Point(150, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 399);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(223, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 58);
            this.label2.TabIndex = 13;
            this.label2.Text = "ACTIVITY FORM";
            // 
            // ActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityForm";
            this.Text = "ActivityForm";
            this.Load += new System.EventHandler(this.ActivityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Button btnSaveActivity;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}