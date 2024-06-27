using FitnessTrackingApp.Model;
using FitnessTrackingApp.Repository;
using System;
using System.Windows.Forms;

namespace FitnessTrackingApp
{
    public partial class GoalSettingForm : Form
    {
        private readonly GoalRepository goalRepository;
        private readonly int userID;
        private readonly string username;

        public GoalSettingForm(int userID, string username)
        {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            goalRepository = new GoalRepository();
        }

        private void GoalSettingForm_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveGoals_Click(object sender, EventArgs e)
        {
            string goalType = cmbGoalType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(goalType))
            {
                MessageBox.Show("Please select a goal type.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtTargetValue.Text, out int targetValue) || targetValue <= 0)
            {
                MessageBox.Show("Target value must be a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCaloriesToBurn.Text, out int caloriesToBurn) || caloriesToBurn <= 0)
            {
                MessageBox.Show("Calories to burn must be a positive integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Goal goal = new Goal(userID, goalType, targetValue, caloriesToBurn);

            // Validate goal before saving
            if (IsGoalValid(goal))
            {
                goalRepository.AddGoal(goal);
                MessageBox.Show("Goal saved successfully!");
                ClearForm();
            }
        }

        private bool IsGoalValid(Goal goal)
        {
            return true;
        }

        private void ClearForm()
        {
            cmbGoalType.SelectedIndex = -1;
            txtTargetValue.Clear();
            txtCaloriesToBurn.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}