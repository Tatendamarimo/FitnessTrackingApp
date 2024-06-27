using FitnessTrackingApp.Model;
using FitnessTrackingApp.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FitnessTrackingApp
{
    public partial class MonitoringProgressForm : Form
    {
        private readonly ActivityRepository activityRepository;
        private readonly GoalRepository goalRepository;
        private readonly int userID;

        public MonitoringProgressForm(int userID, int goalID)
        {
            InitializeComponent();
            this.userID = userID;
            activityRepository = new ActivityRepository();
            goalRepository = new GoalRepository();
            // Populate the combo box with activity types
            PopulateActivityTypes();

            // Initialize the form with default metric labels
            UpdateMetricLabels();
        }

        private void PopulateActivityTypes()
        {
            cmbActivityType.Items.Add("Walking");
            cmbActivityType.Items.Add("Running");
            cmbActivityType.Items.Add("Swimming");
            cmbActivityType.Items.Add("Cycling");
            cmbActivityType.Items.Add("Weightlifting");
            cmbActivityType.Items.Add("Yoga");
        }

        private void UpdateMetricLabels()
        {
            string selectedActivityType = cmbActivityType.SelectedItem?.ToString();
            if (selectedActivityType != null)
            {
                switch (selectedActivityType)
                {
                    case "Walking":
                        lblMetric1.Text = "Steps:";
                        lblMetric2.Text = "Distance (km):";
                        lblMetric3.Text = "Duration (min):";
                        break;

                    case "Running":
                        lblMetric1.Text = "Distance (km):";
                        lblMetric2.Text = "Duration (min):";
                        lblMetric3.Text = "Average Pace (min/km):";
                        break;

                    case "Swimming":
                        lblMetric1.Text = "Laps:";
                        lblMetric2.Text = "Distance (m):";
                        lblMetric3.Text = "Duration (min):";
                        break;

                    case "Cycling":
                        lblMetric1.Text = "Distance (km):";
                        lblMetric2.Text = "Duration (min):";
                        lblMetric3.Text = "Average Speed (km/h):";
                        break;

                    case "Weightlifting":
                        lblMetric1.Text = "Sets:";
                        lblMetric2.Text = "Reps:";
                        lblMetric3.Text = "Weight Lifted (kg):";
                        break;

                    case "Yoga":
                        lblMetric1.Text = "Duration (min):";
                        lblMetric2.Text = "Intensity Level:";
                        lblMetric3.Text = "Difficulty Level:";
                        break;
             
                }
            }
        }

        private void cmbActivityType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateMetricLabels();
        }

        private void MonitoringProgressForm_Load(object sender, EventArgs e)
        {
            LoadUserGoals();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get the selected activity type
            string activityType = cmbActivityType.SelectedItem?.ToString();

            // Validate input for metrics
            if (!ValidateMetrics())
            {
                MessageBox.Show("Please enter valid values for metrics.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Get the provided metrics from the user
            double metric1 = Convert.ToDouble(txtMetric1.Text);
            double metric2 = Convert.ToDouble(txtMetric2.Text);
            double metric3 = Convert.ToDouble(txtMetric3.Text);

            // Calculate calories burned based on the provided metrics and activity type
            double caloriesBurned = CalculateCaloriesBurned(activityType, metric1, metric2, metric3);
            richTxtCaloriesBurned.Text = $"Calories Burned:" + caloriesBurned.ToString("0.00") + "Kcal";

            // Check if the user's goal has been achieved
            CheckGoalAchievement(caloriesBurned);
        }

        private double CalculateCaloriesBurned(string activityType, double metric1, double metric2, double metric3)
        {
            double caloriesBurned = metric1 * 0.005 + metric2 * 0.1 + metric3 * 5;

            return caloriesBurned;
        }

        private void LoadUserGoals()
        {
            // Retrieve the user's goals from the database
            List<Goal> goals = goalRepository.GetGoalsByUserID(userID);

            // Bind the goals to the DataGridView
            dgvGoals.DataSource = goals;
        }

        private void CheckGoalAchievement(double caloriesBurned)
        {
            // Retrieve the user's goals from the database
            List<Goal> goals = goalRepository.GetGoalsByUserID(userID);

            // Check if any goals exist for the user
            if (goals.Count > 0)
            {
                bool goalAchieved = false;

                // Iterate through each goal
                foreach (Goal goal in goals)
                {
                    int goalCaloriesToBurn = goal.CaloriesToBurn;

                    // Compare the calories burned to the goal's target calories
                    if (caloriesBurned >= goalCaloriesToBurn)
                    {
                        goalAchieved = true;
                        break; // Exit the loop if any goal is achieved
                    }
                }

                // Update the label based on goal achievement status
                if (goalAchieved)
                {
                    richTxtGoalAchievement.Text = "Goal Achieved!";
                }
                else
                {
                    richTxtGoalAchievement.Text = "Goal Not Achieved";
                }
            }
            else
            {
                // No goals found for the user
                richTxtGoalAchievement.Text = "Goal Not Set";
            }
        }

        private bool ValidateMetrics()
        {
            // Validate that all textboxes contain valid double values
            if (!double.TryParse(txtMetric1.Text, out double metric1) ||
                !double.TryParse(txtMetric2.Text, out double metric2) ||
                !double.TryParse(txtMetric3.Text, out double metric3))
            {
                return false;
            }
            return true;
        }
    }
}