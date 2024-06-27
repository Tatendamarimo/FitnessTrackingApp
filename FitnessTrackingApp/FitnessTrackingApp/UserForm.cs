using FitnessTrackingApp.Model;
using FitnessTrackingApp.Repository;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace FitnessTrackingApp
{
    public partial class UserForm : Form
    {
        private readonly UserRepository userRepository;
        private int loginAttempts = 0;
        private bool loginLocked = false;

        public UserForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate username format (letters and numbers only)
            if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Username can only contain letters and numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // Validate password length and character requirements
            if (password.Length != 12 || !Regex.IsMatch(password, "[a-z]") || !Regex.IsMatch(password, "[A-Z]"))
            {
                MessageBox.Show("Password must be 12 characters long and contain at least one lowercase and one uppercase letter.", "Password Requirement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Check if passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if username already exists
            if (userRepository.GetUserByUsername(username) != null)
            {
                MessageBox.Show("Username already exists. Please choose a different username.", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Registration successful
            User newUser = new User(username, password);
            userRepository.AddUser(newUser);
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLogin.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (loginLocked)
            {
                return;
            }

            string username = txtUser.Text;
            string password = txtPass.Text;

            User user = userRepository.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open DashboardForm with user ID
                Dashboard dashboardForm = new Dashboard(user.UserID, username);
                dashboardForm.Show();
                this.Hide(); // Hide login form
            }
            else
            {
                loginAttempts++;

                int attemptsLeft = 4 - loginAttempts;

                if (attemptsLeft > 0)
                {
                    MessageBox.Show($"Invalid username or password. {attemptsLeft} attempts left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Login is disabled. Please wait for one minute before attempting again.", "Login Disabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.Enabled = false;
                    loginLocked = true;
                    ThreadPool.QueueUserWorkItem(state =>
                    {
                        Thread.Sleep(60000); // Lock login for 1 minute
                        loginAttempts = 0;
                        loginLocked = false;
                        Invoke(new Action(() => btnLogin.Enabled = true));
                    });
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { // Calculates the target X position for panel2
            int targetX = ClientSize.Width - panel2.Width - SystemInformation.VerticalScrollBarWidth;
            int distanceToMove = 50;

            // Moves the panel image to the right
            panel_img.Left += distanceToMove;

            // Checks if the panel image has reached or crossed the target position
            if (panel_img.Right >= targetX)
            {
                panel_img.Left = targetX - panel_img.Width + panel2.Width; // Align panel image's right edge with the right edge of panel2
                timer1.Stop();
                panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        { // Calculates the target X position for panel1
            int targetX = 0; // Align with the left edge of the form
            int distanceToMove = 50;

            // Moves the panel image to the left
            panel_img.Left -= distanceToMove;

            // Checks if the panel image has reached or crossed the target position
            if (panel_img.Left <= targetX)
            {
                timer2.Stop();
                panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            timer1.Start();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 255, 255, 255);
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}