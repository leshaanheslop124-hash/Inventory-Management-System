using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{

    public partial class CreateAccountPage : Form
    {
        // SAME connection style as your Products page
        string connectionString =
            @"Server=DESKTOP-KFIMAUJ;Database=InventoryDB;Trusted_Connection=True;";


        private void CreateAccountPage_Load(object sender, EventArgs e) 
        {
            contentPane3.Left = (this.ClientSize.Width - contentPane3.Width) / 2;
            contentPane3.Top = (this.ClientSize.Height - contentPane3.Height) / 2;
        }
        
        public CreateAccountPage()
        {
            InitializeComponent();


            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);
        }

        private void button_CREATE_ACCOUNT_Click(object sender, EventArgs e)
        {
            string username = textBox_USERNAME.Text.Trim();
            string password = textBox_PASSWORD.Text;
            string confirmPassword = textBox_CONFIRM_PASSWORD.Text;

            // 1️⃣ Basic validation
            if (username == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 2️⃣ Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int userExists = (int)checkCmd.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Choose another one.");
                        return;
                    }
                }

                // 3️⃣ Insert new user
                string insertQuery =
                    "INSERT INTO Users (Username, Password) VALUES (@username, @password)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password); // plain text for now

                    insertCmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("✅ Account created successfully!");

            // 4️⃣ Go back to login
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void button_BACK_TO_LOGIN_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

