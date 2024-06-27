using FitnessTrackingApp.Data;
using FitnessTrackingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FitnessTrackingApp.Repository
{
    public class ActivityRepository
    {
        // Method to add a new activity record to the database
        public void AddActivity(Activity activity)
        {
            string query = "INSERT INTO Activities (UserID, ActivityType, Metric1, Metric2, Metric3) " +
                           "VALUES (@UserID, @ActivityType, @Metric1, @Metric2, @Metric3)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", activity.UserID);
                    command.Parameters.AddWithValue("@ActivityType", activity.ActivityType);
                    command.Parameters.AddWithValue("@Metric1", activity.Metric1);
                    command.Parameters.AddWithValue("@Metric2", activity.Metric2);
                    command.Parameters.AddWithValue("@Metric3", activity.Metric3);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve activities for a specific user from the database
        public List<Activity> GetActivitiesByUserID(int userID)
        {
            List<Activity> activities = new List<Activity>();

            string query = "SELECT UserID, ActivityType, Metric1, Metric2, Metric3 " +
                           "FROM Activities WHERE UserID = @UserID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Activity activity = new Activity
                            {
                                UserID = Convert.ToInt32(reader["UserID"]),
                                ActivityType = reader["ActivityType"].ToString(),
                                Metric1 = reader["Metric1"].ToString(),
                                Metric2 = reader["Metric2"].ToString(),
                                Metric3 = reader["Metric3"].ToString()
                            };
                            activities.Add(activity);
                        }
                    }
                }
            }

            return activities;
        }
    }
}