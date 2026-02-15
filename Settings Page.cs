using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Settings_Page : Form
    {
        private string connectionString =
            @"Server=DESKTOP-KFIMAUJ;Database=InventoryDB;Trusted_Connection=True;";

        private int selectedUserId = -1;

        public Settings_Page()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);
        }

        private void Settings_Page_Load(object sender, EventArgs e)
        {
            LoadUsers();
            SetupThemeOptions();

            textBox_NEW_PASSWORD.UseSystemPasswordChar = true;
            textBox_CONFRM_PASSWORD.UseSystemPasswordChar = true;

            // Load saved system settings
            comboBox_THEME.SelectedItem = Properties.Settings.Default.AppTheme;
            checkBox_ENABLE_LOW_STOCK_WARNINGS.Checked =
                Properties.Settings.Default.LowStockWarningsEnabled;
            ApplyTheme(Properties.Settings.Default.AppTheme);

            contentPane6.Left = (this.ClientSize.Width - contentPane6.Width) / 2;
            contentPane6.Top = (this.ClientSize.Height - contentPane6.Height) / 2;
        }

        // =========================
        // LOAD USERS (HIDE PASSWORD)
        // =========================
        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT UserID, Username, CreatedAt FROM Users";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView_SHOW_USERS.DataSource = dt;

                // Adjust column headers if needed
                dataGridView_SHOW_USERS.DataSource = dt;

                // Ensure column names match your code
                dataGridView_SHOW_USERS.Columns["UserID"].Name = "UserID";
                dataGridView_SHOW_USERS.Columns["Username"].Name = "Username";
                dataGridView_SHOW_USERS.Columns["CreatedAt"].Name = "CreatedAt";

            }

            dataGridView_SHOW_USERS.ClearSelection();
            selectedUserId = -1;
        }

        // =========================
        // GRID CLICK - FILL TEXTBOXES
        // =========================
        private void dataGridView_SHOW_USERS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_SHOW_USERS.Rows[e.RowIndex];

                // Make sure the columns exist
                if (row.Cells["UserID"].Value != null && row.Cells["Username"].Value != null)
                {
                    selectedUserId = Convert.ToInt32(row.Cells[0].Value); // UserID
                    textBox_UPDATE_USERNAME.Text = row.Cells[1].Value.ToString(); // Username

                    // Passwords are NOT loaded in textboxes
                    textBox_NEW_PASSWORD.Clear();
                    textBox_CONFRM_PASSWORD.Clear();
                }
            }
        }

        // =========================
        // SAVE ACCOUNT SETTINGS
        // =========================
        private void button_SAVE_SETTINGS_1_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Users 
                                 SET Username = @Username
                                 WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", textBox_UPDATE_USERNAME.Text);
                cmd.Parameters.AddWithValue("@UserID", selectedUserId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            // Only update password if user entered one
            if (!string.IsNullOrWhiteSpace(textBox_NEW_PASSWORD.Text))
            {
                if (textBox_NEW_PASSWORD.Text != textBox_CONFRM_PASSWORD.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Users 
                                     SET Password = @Password 
                                     WHERE UserID = @UserID";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Password", textBox_NEW_PASSWORD.Text);
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password updated successfully.");
            }

            LoadUsers();
            ClearFields();
        }

        // =========================
        // DELETE USER
        // =========================
        private void button_DELETE_USER_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("User deleted.");
                ClearFields();
                LoadUsers();
            }
        }

        // =========================
        // CLEAR FIELDS
        // =========================
        private void button_CLEAR_FIELDS_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBox_UPDATE_USERNAME.Clear();
            textBox_NEW_PASSWORD.Clear();
            textBox_CONFRM_PASSWORD.Clear();
            selectedUserId = -1;
            dataGridView_SHOW_USERS.ClearSelection();
        }

        // =========================
        // SYSTEM SETTINGS
        // =========================
        private void SetupThemeOptions()
        {
            comboBox_THEME.Items.Clear();
            comboBox_THEME.Items.Add("Light");
            comboBox_THEME.Items.Add("Dark");

            // Default selection if nothing saved yet
            if (Properties.Settings.Default.AppTheme != null)
                comboBox_THEME.SelectedItem = Properties.Settings.Default.AppTheme;
            else
                comboBox_THEME.SelectedIndex = 0;
        }

        private void button_SAVE_SETTINGS_2_Click(object sender, EventArgs e)
        {
            string theme = comboBox_THEME.SelectedItem.ToString();
            bool lowStockEnabled = checkBox_ENABLE_LOW_STOCK_WARNINGS.Checked;

            Properties.Settings.Default.AppTheme = theme;
            Properties.Settings.Default.LowStockWarningsEnabled = lowStockEnabled;
            Properties.Settings.Default.Save();

            ApplyTheme(theme);

            MessageBox.Show("System settings saved.");
        }

        private void ApplyTheme(string theme)
        {
            if (theme == "Dark")
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                this.ForeColor = Color.Black;
            }
        }

        // =========================
        // NAVIGATION
        // =========================
        private void button_BACK_TO_DASHBORED_Click(object sender, EventArgs e)
        {
            Dashbored d = new Dashbored();
            d.Show();
            this.Hide();
        }

        private void button_LOG_OUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button_EXIT_APPLICATION_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_NEW_PASSWORD_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox_CONFRM_PASSWORD_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView_SHOW_USERS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_SHOW_USERS.Rows[e.RowIndex];

                // Using column indexes instead of names
                selectedUserId = Convert.ToInt32(row.Cells[0].Value); // UserID
                textBox_UPDATE_USERNAME.Text = row.Cells[1].Value.ToString(); // Username

                // Clear passwords
                textBox_NEW_PASSWORD.Clear();
                textBox_CONFRM_PASSWORD.Clear();
            }
        }

        }

        private void checkBox_ENABLE_LOW_STOCK_WARNINGS_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
