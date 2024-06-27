using FitnessTrackingApp.Model;
using FitnessTrackingApp.Repository;
using System;
using System.Windows.Forms;

namespace FitnessTrackingApp
{
    public partial class ActivityForm : Form
    {
        private readonly ActivityRepository activityRepository;
        private readonly int userID;

        public ActivityForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            activityRepository = new ActivityRepository(); // Initialize the repository
            UpdateMetricLabels(); // Populate activity types
            PopulateActivityTypes();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
        }

        private void cmbActivityType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Update metric labels based on the selected activity type
            UpdateMetricLabels();
        }

        private void PopulateActivityTypes()
        {
            // Populate the activity type dropdown with activity types
            cmbActivityType.Items.AddRange(new object[] { "Walking", "Running", "Swimming", "Cycling", "Weightlifting", "Yoga" });
        }

        private void UpdateMetricLabels()
        {
            string activityType = cmbActivityType.SelectedItem?.ToString();

            // Update metric labels based on the selected activity type
            switch (activityType)
            {
                case "Walking":
                    lblMetric1.Text = "Steps:";
                    lblMetric2.Text = "Distance (km):";
                    lblMetric3.Text = "Duration (min):";
                    break;

                case "Running":
                    lblMetric1.Text = "Distance (kilometers):";
                    lblMetric2.Text = "Duration (minutes):";
                    lblMetric3.Text = "Average Pace (mins/km):";
                    break;

                case "Swimming":
                    lblMetric1.Text = "Laps:";
                    lblMetric2.Text = "Distance (m):";
                    lblMetric3.Text = "Duration (min):";
                    break;

                case "Cycling":
                    lblMetric1.Text = "Distance (kilometers):";
                    lblMetric2.Text = "Duration (minutes):";
                    lblMetric3.Text = "Average Speed (km/h):";
                    break;

                case "Weightlifting":
                    lblMetric1.Text = "Sets:";
                    lblMetric2.Text = "Reps:";
                    lblMetric3.Text = "Weight Lifted (kg):";
                    break;

                case "Yoga":
                    lblMetric1.Text = "Duration (minutes):";
                    lblMetric2.Text = "Intensity Level:";
                    lblMetric3.Text = "Difficulty Level:";
                    break;

                default:
                    // Reset metric labels to defaults
                    lblMetric1.Text = "Metric 1:";
                    lblMetric2.Text = "Metric 2:";
                    lblMetric3.Text = "Metric 3:";
                    break;
            }
        }

        private void btnSaveActivity_Click(object sender, EventArgs e)
        {
            string selectedActivity = cmbActivityType.SelectedItem?.ToString();
            string metric1 = txtMetric1.Text;
            string metric2 = txtMetric2.Text;
            string metric3 = txtMetric3.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(selectedActivity) || string.IsNullOrWhiteSpace(metric1) ||
                string.IsNullOrWhiteSpace(metric2) || string.IsNullOrWhiteSpace(metric3))
            {
                MessageBox.Show("Please enter values for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create Activity object
            Activity activity = new Activity(userID, selectedActivity, metric1, metric2, metric3);

            try
            {
                // Save activity to database
                activityRepository.AddActivity(activity);
                MessageBox.Show("Activity saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the activity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            // Clear the ComboBox selection and TextBox values
            cmbActivityType.SelectedIndex = -1;
            txtMetric1.Clear();
            txtMetric2.Clear();
            txtMetric3.Clear();
        }
    }
}