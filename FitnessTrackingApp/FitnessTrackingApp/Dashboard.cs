using System;
using System.Windows.Forms;

namespace FitnessTrackingApp
{
    public partial class Dashboard : Form
    {
        private readonly int userID;
        private readonly int goalID;
        private string username;

        public Dashboard(int userID, string username)
        {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            // Display the welcome message with the username
            lblWelcomeMessage.Text = "Welcome, " + username + "!";
            // Display the username in the label
            lblUsername.Text = "Logged in as: " + username;
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnGoalForm_Click_1(object sender, EventArgs e)
        {
            // Open GoalForm with user ID
            loadform(new GoalSettingForm(userID, username));
        }

        private void btnActivityForm_Click_1(object sender, EventArgs e)
        {
            // Open ActivityForm with user ID
            loadform(new ActivityForm(userID));
        }

        private void btnMonitoringPregress_Click(object sender, EventArgs e)
        {
            loadform(new MonitoringProgressForm(userID, goalID));
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}