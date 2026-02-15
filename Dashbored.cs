using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Dashbored : Form
    {
        public Dashbored()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);
        }

        private void Dashbored_Load(object sender, EventArgs e)
        {
            contentPane1.Left = (this.ClientSize.Width - contentPane1.Width) / 2;
            contentPane1.Top = (this.ClientSize.Height - contentPane1.Height) / 2;
        }

        private void button_PRODUCTS_PAGE_Click(object sender, EventArgs e)
        {
            // Opens the Products Page
            Products_Page productsForm = new Products_Page();
            productsForm.Show();
            this.Hide();
        }

        private void button_SALES_PAGE_Click(object sender, EventArgs e)
        {
            // Opens the Sales Page
            Sales_Page salesForm = new Sales_Page();
            salesForm.Show();
            this.Hide();     
        }

        private void button_LOG_OUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button_SETTINGS_Click(object sender, EventArgs e)
        {
           Settings_Page settingsForm = new Settings_Page();
            settingsForm.Show();
            this.Hide();
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}