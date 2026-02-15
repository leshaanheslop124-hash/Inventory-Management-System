using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Form1 : Form 
    {
        // My SQL connection string
        string connectionString = @"Server=DESKTOP-KFIMAUJ;Database=InventoryDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);

            this.BackColor = Color.FromArgb(166, 166, 166);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            contentPane2.Left = (this.ClientSize.Width - contentPane2.Width) / 2;
            contentPane2.Top = (this.ClientSize.Height - contentPane2.Height) / 2;

            this.AcceptButton = button1;

        }

        // ================= LOGIN BUTTON =================
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_USERNAME.Text.Trim();
            string password = textBox_PASSWORD.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        con.Open();
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("✅ Login successful!");

                            // Open dashboard or products page
                            Dashbored dashboredForm = new Dashbored();
                            dashboredForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("❌ Invalid username or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL connection error: " + ex.Message);
            }
        }

        // ================= EXIT BUTTON =================
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================= CREATE ACCOUNT BUTTON =================
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountPage createForm = new CreateAccountPage();
            createForm.Show();
            this.Hide();
        }

        private void contentPane1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void textBox_USERNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_PASSWORD.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void textBox_PASSWORD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }


    }
}
