namespace FitnessTrackingApp.Model
{
    public class User
    {
        // Properties
        private int userID;

        private string username;
        private string password;

        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        // Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public User()
        {
        }

        // Method to update user's password
        public void UpdatePassword(string newPassword)
        {
            Password = newPassword;
        }

        // Method to reset user's password to a default value
        public void ResetPassword()
        {
            // Set password to a default value
            Password = "PasswordReseted123";
        }
    }
}