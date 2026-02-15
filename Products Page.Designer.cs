namespace Inventory_Management_System
{
    partial class Products_Page
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.contentPane5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.contentPane5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPane5
            // 
            this.contentPane5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPane5.Controls.Add(this.label7);
            this.contentPane5.Controls.Add(this.txtCategory);
            this.contentPane5.Controls.Add(this.button1);
            this.contentPane5.Controls.Add(this.label13);
            this.contentPane5.Controls.Add(this.button2);
            this.contentPane5.Controls.Add(this.button7);
            this.contentPane5.Controls.Add(this.button3);
            this.contentPane5.Controls.Add(this.label12);
            this.contentPane5.Controls.Add(this.button4);
            this.contentPane5.Controls.Add(this.label11);
            this.contentPane5.Controls.Add(this.button5);
            this.contentPane5.Controls.Add(this.label10);
            this.contentPane5.Controls.Add(this.txtReorderLevel);
            this.contentPane5.Controls.Add(this.label9);
            this.contentPane5.Controls.Add(this.txtPrice);
            this.contentPane5.Controls.Add(this.label8);
            this.contentPane5.Controls.Add(this.txtQuantity);
            this.contentPane5.Controls.Add(this.button6);
            this.contentPane5.Controls.Add(this.txtProductName);
            this.contentPane5.Controls.Add(this.txtProductID);
            this.contentPane5.Controls.Add(this.dataGridViewProducts);
            this.contentPane5.Location = new System.Drawing.Point(239, 101);
            this.contentPane5.Name = "contentPane5";
            this.contentPane5.Size = new System.Drawing.Size(900, 500);
            this.contentPane5.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "EXIT APPLICATION";
            this.button1.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(876, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "LOG OUT";
            this.button2.Click += new System.EventHandler(this.button_LOG_OUT_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "DELETE";
            this.button3.Click += new System.EventHandler(this.button_DELETE_PRODUCTS_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "UPDATE";
            this.button4.Click += new System.EventHandler(this.button_UPDATE_PRODUCTS_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ADD";
            this.button5.Click += new System.EventHandler(this.button_ADD_PRODUCTS_Click);
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(150, 290);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(193, 20);
            this.txtReorderLevel.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(150, 252);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(150, 211);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(193, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(150, 176);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(193, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(150, 93);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(193, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Location = new System.Drawing.Point(369, 58);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(520, 323);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "PRODUCT PAGE";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 386);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(330, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "CLEAR";
            this.button6.Click += new System.EventHandler(this.button_CLEAR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "PRODUCT ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "RECORDER LEVEL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "PRODUCT NAME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "PRICE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "QUANTITY";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(695, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 23);
            this.button7.TabIndex = 18;
            this.button7.Text = "BACK TO DASHBORED";
            this.button7.Click += new System.EventHandler(this.button_BACK_TO_DASHBORED_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "CATEGORY";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(150, 139);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(193, 20);
            this.txtCategory.TabIndex = 21;
            // 
            // Products_Page
            // 
            this.ClientSize = new System.Drawing.Size(1416, 728);
            this.Controls.Add(this.contentPane5);
            this.Name = "Products_Page";
            this.Text = "Products Page";
            this.Load += new System.EventHandler(this.Products_Page_Load);
            this.contentPane5.ResumeLayout(false);
            this.contentPane5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel contentPane5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}
