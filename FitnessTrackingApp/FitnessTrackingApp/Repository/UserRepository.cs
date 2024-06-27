using FitnessTrackingApp.Data;
using FitnessTrackingApp.Model;
using System;
using System.Data.SqlClient;

namespace FitnessTrackingApp.Repository
{
    public class UserRepository
    {
        // Method to add a new user to the database
        public void AddUser(User user)
        {
            // Query to insert new user into the database
            string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

            // Using statement ensures proper disposal of resources
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the query
                    command.Parameters.AddWithValue("@Username", user.Username);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    // Execute the query
                    command.ExecuteNonQuery();
                }
            }
        }

        // Method to retrieve user by username
        public User GetUserByUsername(string username)
        {
            User user = null;

            // Query to retrieve user from the database
            string query = "SELECT UserID, Username, Password FROM Users WHERE Username = @Username";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add username parameter to the query
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if user exists
                        if (reader.Read())
                        {
                            // Create a new User object
                            user = new User(reader["Username"].ToString(), reader["Password"].ToString());
                            user.UserID = Convert.ToInt32(reader["UserID"]);
                        }
                    }
                }
            }

            return user;
        }

        // Method to retrieve a user by their ID
        public User GetUserByID(int userID)
        {
            User user = null;

            // SQL query to retrieve user by ID
            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@UserID", userID);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Check if a user with the given ID exists
                    if (reader.Read())
                    {
                        // Create a new User object with data from the database
                        user = new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                        };
                    }
                }
            }

            return user;
        }
    }
}