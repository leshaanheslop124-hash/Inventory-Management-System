using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Sales_Page : Form
    {
        //My Connection String
        string connectionString =
            @"Server=DESKTOP-KFIMAUJ;Database=InventoryDB;Trusted_Connection=True;";

        public Sales_Page()
        {
            InitializeComponent();


            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);
        }

        private void Sales_Page_Load(object sender, EventArgs e)
        {
            LoadProducts();

            contentPane4.Left = (this.ClientSize.Width - contentPane4.Width) / 2;
            contentPane4.Top = (this.ClientSize.Height - contentPane4.Height) / 2;
        }

        // ================= LOAD PRODUCTS =================
        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ProductID, ProductName, Price FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox_PRODUCT_LIST.DisplayMember = "ProductName";
                comboBox_PRODUCT_LIST.ValueMember = "ProductID";
                comboBox_PRODUCT_LIST.DataSource = dt;
                comboBox_PRODUCT_LIST.SelectedIndex = -1;
            }
        }

        // ================= PRODUCT SELECT =================
        private void comboBox_PRODUCT_LIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_PRODUCT_LIST.SelectedIndex != -1)
            {
                DataRowView row = (DataRowView)comboBox_PRODUCT_LIST.SelectedItem;
                textBox_PRICE.Text = row["Price"].ToString();
            }
        }

        // ================= CALCULATE TOTAL =================
        private void textBox_QUANTITY_SOLD_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox_PRICE.Text, out decimal price) &&
                int.TryParse(textBox_QUANTITY_SOLD.Text, out int qty))
            {
                textBox_TOTAL_AMOUNT.Text = (price * qty).ToString("0.00");
            }
            else
            {
                textBox_TOTAL_AMOUNT.Clear();
            }
        }

        // ================= PROCESS SALES =================
        private void button_PROCESS_SALES_Click(object sender, EventArgs e)
        {
            if (comboBox_PRODUCT_LIST.SelectedIndex == -1 ||
                textBox_QUANTITY_SOLD.Text == "")
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            int productId = Convert.ToInt32(comboBox_PRODUCT_LIST.SelectedValue);
            int quantitySold = Convert.ToInt32(textBox_QUANTITY_SOLD.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check stock
                SqlCommand checkStock = new SqlCommand(
                    "SELECT Quantity FROM Products WHERE ProductID=@id", con);
                checkStock.Parameters.AddWithValue("@id", productId);

                int stock = Convert.ToInt32(checkStock.ExecuteScalar());

                if (quantitySold > stock)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }

                // Insert sale
                SqlCommand insertSale = new SqlCommand(
                    "INSERT INTO Sales (ProductID, QuantitySold) VALUES (@id, @qty)", con);
                insertSale.Parameters.AddWithValue("@id", productId);
                insertSale.Parameters.AddWithValue("@qty", quantitySold);
                insertSale.ExecuteNonQuery();

                // Update stock
                SqlCommand updateStock = new SqlCommand(
                    "UPDATE Products SET Quantity = Quantity - @qty WHERE ProductID=@id", con);
                updateStock.Parameters.AddWithValue("@qty", quantitySold);
                updateStock.Parameters.AddWithValue("@id", productId);
                updateStock.ExecuteNonQuery();
            }

            MessageBox.Show("Sale processed successfully!");
            ClearFields();
        }

        // ================= VIEW SALES =================
        private void button_VIEW_SALES_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT s.SaleID,
                           p.ProductName,
                           s.QuantitySold,
                           (s.QuantitySold * p.Price) AS TotalAmount,
                           s.SaleDate
                    FROM Sales s
                    JOIN Products p ON s.ProductID = p.ProductID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_SALES.DataSource = dt;
            }
        }

        // ================= CLEAR =================
        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            comboBox_PRODUCT_LIST.SelectedIndex = -1;
            textBox_QUANTITY_SOLD.Clear();
            textBox_PRICE.Clear();
            textBox_TOTAL_AMOUNT.Clear();
        }

        // ================= NAV BUTTONS =================
        private void button_BACK_TO_DASHBORED_Click(object sender, EventArgs e)
        {
            Dashbored dashbored = new Dashbored();
            dashbored.Show();
            this.Hide();
        }

        private void button_EXIT_APPLICATION_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_LOG_OFF_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button_PRINT_RECIEPT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Receipt feature coming soon 🙂");
        }
        private void dataGridView_SALES_CellContentClick(
         object sender,
         DataGridViewCellEventArgs e)
        {
            // You can leave this empty if you don’t need it
        }

        private void comboBox_PRODUCT_LIST_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox_PRODUCT_LIST.SelectedItem is DataRowView row)
            {
                textBox_PRICE.Text = Convert.ToDecimal(row["Price"]).ToString("0.00");
            }
        }
    }
}
