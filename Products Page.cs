using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Products_Page : Form
    {
        // My connection string
        private string connectionString =
            @"Server=DESKTOP-KFIMAUJ;Database=InventoryDB;Trusted_Connection=True;";

        private int currentProductId = -1;

        public Products_Page()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1366, 768);
        }

        // ================= FORM LOAD =================
        private void Products_Page_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
            HighlightLowStock();
            ShowLowStockWarning();

            contentPane5.Left = (this.ClientSize.Width - contentPane5.Width) / 2;
            contentPane5.Top = (this.ClientSize.Height - contentPane5.Height) / 2;
        }

        // ================= LOAD ALL PRODUCTS =================
        private void LoadAllProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        ProductID, 
                        ProductName, 
                        Quantity, 
                        Price, 
                        ReorderLevel,
                        Category,
                        CASE 
                            WHEN Quantity <= ReorderLevel THEN 'LOW STOCK'
                            ELSE 'OK'
                        END AS StockStatus
                    FROM Products
                ";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }

            dataGridViewProducts.ClearSelection();
            FormatGrid();
        }

        // ================= FORMAT GRID =================
        private void FormatGrid()
        {
            // Make certain columns read-only
            dataGridViewProducts.Columns["ProductID"].ReadOnly = true;
            dataGridViewProducts.Columns["StockStatus"].ReadOnly = true;

            dataGridViewProducts.Columns["StockStatus"].HeaderText = "Stock Status";
            dataGridViewProducts.Columns["ReorderLevel"].HeaderText = "Reorder Level";
        }

        // ================= HIGHLIGHT LOW STOCK =================
        private void HighlightLowStock()
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells["Quantity"].Value == null) continue;

                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int reorderLevel = Convert.ToInt32(row.Cells["ReorderLevel"].Value);

                if (qty <= reorderLevel)
                {
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    row.Cells["StockStatus"].Style.ForeColor = Color.Red;
                    row.Cells["StockStatus"].Style.Font =
                        new Font(dataGridViewProducts.Font, FontStyle.Bold);
                }
                else
                {
                    row.Cells["StockStatus"].Style.ForeColor = Color.Green;
                }
            }
        }

        // ================= POPUP WARNING =================
        private void ShowLowStockWarning()
        {
            StringBuilder msg = new StringBuilder();

            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                if (row.Cells["Quantity"].Value == null) continue;

                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int reorderLevel = Convert.ToInt32(row.Cells["ReorderLevel"].Value);

                if (qty <= reorderLevel)
                {
                    msg.AppendLine(
                        $"{row.Cells["ProductName"].Value} — {qty} left (Reorder Level: {reorderLevel})"
                    );
                }
            }

            if (msg.Length > 0)
            {
                MessageBox.Show(
                    "⚠ LOW STOCK ALERT\n\n" +
                    msg +
                    "\n\nPlease update stock on this page.",
                    "Inventory Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // ================= ADD PRODUCT =================
        private void button_ADD_PRODUCTS_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" ||
                txtQuantity.Text == "" ||
                txtPrice.Text == "" ||
                txtReorderLevel.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "INSERT INTO Products (ProductName, Quantity, Price, ReorderLevel, Category) " +
                    "VALUES (@name, @qty, @price, @reorder, @category)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@reorder", int.Parse(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product added successfully");
            LoadAllProducts();
            ClearFields();
        }

        // ================= UPDATE PRODUCT =================
        private void button_UPDATE_PRODUCTS_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Select a product first");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query =
                    "UPDATE Products SET ProductName=@name, Quantity=@qty, Price=@price, ReorderLevel=@reorder, Category=@category " +
                    "WHERE ProductID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtProductID.Text));
                cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                cmd.Parameters.AddWithValue("@qty", int.Parse(txtQuantity.Text));
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@reorder", int.Parse(txtReorderLevel.Text));
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product updated successfully");
            LoadAllProducts();
            ClearFields();
        }

        // ================= DELETE PRODUCT =================
        private void button_DELETE_PRODUCTS_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
            {
                MessageBox.Show("Select a product first");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Products WHERE ProductID=@id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtProductID.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Product deleted successfully");
            LoadAllProducts();
            ClearFields();
        }

        // ================= GRID CLICK =================
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

            txtProductID.Text = row.Cells["ProductID"].Value.ToString();
            txtProductName.Text = row.Cells["ProductName"].Value.ToString();
            txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtReorderLevel.Text = row.Cells["ReorderLevel"].Value.ToString();
            txtCategory.Text = row.Cells["Category"].Value.ToString();
        }

        // ================= CLEAR =================
        private void button_CLEAR_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridViewProducts.ClearSelection();
            currentProductId = -1;
        }

        private void ClearFields()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtReorderLevel.Clear();
            txtCategory.Clear();
        }

        // ================= NAVIGATION =================
        private void button_BACK_TO_DASHBORED_Click(object sender, EventArgs e)
        {
            Dashbored dashbored = new Dashbored();
            dashbored.Show();
            this.Hide();
        }

        private void button_LOG_OUT_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
