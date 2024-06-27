using FitnessTrackingApp.Data;
using FitnessTrackingApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FitnessTrackingApp.Repository
{
    public class GoalRepository
    {
        // Method to add a new goal to the database
        public void AddGoal(Goal goal)
        {
            // Query to insert a new goal into the database
            string query = "INSERT INTO Goals (UserID, GoalType, TargetValue, CaloriesToBurn) " +
                           "VALUES (@UserID, @GoalType, @TargetValue, @CaloriesToBurn)";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@UserID", goal.UserID);
                    command.Parameters.AddWithValue("@GoalType", goal.GoalType);
                    command.Parameters.AddWithValue("@TargetValue", goal.TargetValue);
                    command.Parameters.AddWithValue("@CaloriesToBurn", goal.CaloriesToBurn);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve goals by user ID
        public List<Goal> GetGoalsByUserID(int userID)
        {
            List<Goal> goals = new List<Goal>();

            // Query to retrieve goals for a specific user from the database
            string query = "SELECT GoalID, UserID, GoalType, TargetValue, CaloriesToBurn " +
                   "FROM Goals WHERE UserID = '" + userID + "'";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add userID parameter to the query
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Iterate through the result set and create Goal objects
                        while (reader.Read())
                        {
                            Goal goal = new Goal
                            {
                                GoalID = Convert.ToInt32(reader["GoalID"]),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                GoalType = reader["GoalType"].ToString(),
                                TargetValue = Convert.ToInt32(reader["TargetValue"]),
                                CaloriesToBurn = Convert.ToInt32(reader["CaloriesToBurn"])
                            };
                            goals.Add(goal);
                        }
                    }
                }
            }

            return goals;
        }

        // Method to update an existing goal in the database
        public void UpdateGoal(Goal goal)
        {
            // Query to update an existing goal in the database
            string query = "UPDATE Goals SET GoalType = @GoalType, TargetValue = @TargetValue, " +
                           "CaloriesToBurn = @CaloriesToBurn WHERE GoalID = @GoalID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@GoalID", goal.GoalID);
                    command.Parameters.AddWithValue("@GoalType", goal.GoalType);
                    command.Parameters.AddWithValue("@TargetValue", goal.TargetValue);
                    command.Parameters.AddWithValue("@CaloriesToBurn", goal.CaloriesToBurn);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to delete a goal from the database
        public void DeleteGoal(int goalID)
        {
            // Query to delete a goal from the database
            string query = "DELETE FROM Goals WHERE GoalID = @GoalID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add goalID parameter to the query
                    command.Parameters.AddWithValue("@GoalID", goalID);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}