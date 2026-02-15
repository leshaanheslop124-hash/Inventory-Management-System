namespace Inventory_Management_System
{
    partial class Sales_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentPane4 = new System.Windows.Forms.Panel();
            this.comboBox_PRODUCT_LIST = new System.Windows.Forms.ComboBox();
            this.dataGridView_SALES = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_QUANTITY_SOLD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox_PRICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TOTAL_AMOUNT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.contentPane4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SALES)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPane4
            // 
            this.contentPane4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPane4.Controls.Add(this.label3);
            this.contentPane4.Controls.Add(this.button7);
            this.contentPane4.Controls.Add(this.comboBox_PRODUCT_LIST);
            this.contentPane4.Controls.Add(this.label5);
            this.contentPane4.Controls.Add(this.dataGridView_SALES);
            this.contentPane4.Controls.Add(this.textBox_TOTAL_AMOUNT);
            this.contentPane4.Controls.Add(this.button1);
            this.contentPane4.Controls.Add(this.label4);
            this.contentPane4.Controls.Add(this.button2);
            this.contentPane4.Controls.Add(this.textBox_PRICE);
            this.contentPane4.Controls.Add(this.button3);
            this.contentPane4.Controls.Add(this.button6);
            this.contentPane4.Controls.Add(this.button4);
            this.contentPane4.Controls.Add(this.button5);
            this.contentPane4.Controls.Add(this.label2);
            this.contentPane4.Controls.Add(this.textBox_QUANTITY_SOLD);
            this.contentPane4.Controls.Add(this.label1);
            this.contentPane4.Location = new System.Drawing.Point(239, 90);
            this.contentPane4.Name = "contentPane4";
            this.contentPane4.Size = new System.Drawing.Size(900, 500);
            this.contentPane4.TabIndex = 17;
            // 
            // comboBox_PRODUCT_LIST
            // 
            this.comboBox_PRODUCT_LIST.FormattingEnabled = true;
            this.comboBox_PRODUCT_LIST.Location = new System.Drawing.Point(205, 178);
            this.comboBox_PRODUCT_LIST.Name = "comboBox_PRODUCT_LIST";
            this.comboBox_PRODUCT_LIST.Size = new System.Drawing.Size(121, 21);
            this.comboBox_PRODUCT_LIST.TabIndex = 0;
            this.comboBox_PRODUCT_LIST.SelectedIndexChanged += new System.EventHandler(this.comboBox_PRODUCT_LIST_SelectedIndexChanged_1);
            // 
            // dataGridView_SALES
            // 
            this.dataGridView_SALES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SALES.Location = new System.Drawing.Point(348, 118);
            this.dataGridView_SALES.Name = "dataGridView_SALES";
            this.dataGridView_SALES.Size = new System.Drawing.Size(537, 281);
            this.dataGridView_SALES.TabIndex = 1;
            this.dataGridView_SALES.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SALES_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(878, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOG_OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_LOG_OFF_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(700, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "EXIT APPLICATION";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_EXIT_APPLICATION_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "PROCESS SALES";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_PROCESS_SALES_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(160, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "VIEW SALES";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_VIEW_SALES_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_CLEAR_Click);
            // 
            // textBox_QUANTITY_SOLD
            // 
            this.textBox_QUANTITY_SOLD.Location = new System.Drawing.Point(205, 221);
            this.textBox_QUANTITY_SOLD.Name = "textBox_QUANTITY_SOLD";
            this.textBox_QUANTITY_SOLD.Size = new System.Drawing.Size(121, 20);
            this.textBox_QUANTITY_SOLD.TabIndex = 7;
            this.textBox_QUANTITY_SOLD.TextChanged += new System.EventHandler(this.textBox_QUANTITY_SOLD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PRODUCT LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "QUANTITY SOLD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(374, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "SALES PAGE";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(688, 87);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "BACK TO DASHBORED";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_BACK_TO_DASHBORED_Click);
            // 
            // textBox_PRICE
            // 
            this.textBox_PRICE.Location = new System.Drawing.Point(205, 265);
            this.textBox_PRICE.Name = "textBox_PRICE";
            this.textBox_PRICE.ReadOnly = true;
            this.textBox_PRICE.Size = new System.Drawing.Size(121, 20);
            this.textBox_PRICE.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "PRICE";
            // 
            // textBox_TOTAL_AMOUNT
            // 
            this.textBox_TOTAL_AMOUNT.Location = new System.Drawing.Point(205, 303);
            this.textBox_TOTAL_AMOUNT.Name = "textBox_TOTAL_AMOUNT";
            this.textBox_TOTAL_AMOUNT.ReadOnly = true;
            this.textBox_TOTAL_AMOUNT.Size = new System.Drawing.Size(121, 20);
            this.textBox_TOTAL_AMOUNT.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "TOTAL AMOUNT";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(160, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(166, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "PRINT RECIEPT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_PRINT_RECIEPT_Click);
            // 
            // Sales_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 732);
            this.Controls.Add(this.contentPane4);
            this.Name = "Sales_Page";
            this.Text = "Sales_Page";
            this.Load += new System.EventHandler(this.Sales_Page_Load);
            this.contentPane4.ResumeLayout(false);
            this.contentPane4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SALES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPane4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox_PRODUCT_LIST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_SALES;
        private System.Windows.Forms.TextBox textBox_TOTAL_AMOUNT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_PRICE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_QUANTITY_SOLD;
        private System.Windows.Forms.Label label1;
    }
}