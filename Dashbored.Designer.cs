namespace Inventory_Management_System
{
    partial class Dashbored
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
            this.contentPane1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.contentPane1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPane1
            // 
            this.contentPane1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPane1.Controls.Add(this.button2);
            this.contentPane1.Controls.Add(this.button5);
            this.contentPane1.Controls.Add(this.button1);
            this.contentPane1.Controls.Add(this.panel2);
            this.contentPane1.Controls.Add(this.button3);
            this.contentPane1.Controls.Add(this.button4);
            this.contentPane1.Location = new System.Drawing.Point(251, 93);
            this.contentPane1.Name = "contentPane1";
            this.contentPane1.Size = new System.Drawing.Size(900, 500);
            this.contentPane1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 176);
            this.button1.TabIndex = 2;
            this.button1.Text = "VIEW PRODUCTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_PRODUCTS_PAGE_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 176);
            this.button2.TabIndex = 5;
            this.button2.Text = "VIEW SALES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_SALES_PAGE_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(650, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(850, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "LOG OUT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_LOG_OUT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(214, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 100);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "LETS SEE HOW OUR BUISNESS IS DOING!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOME TO LTH INVENTORY SYSTEM";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 50);
            this.button5.TabIndex = 11;
            this.button5.Text = "SETTINGS";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_SETTINGS_Click);
            // 
            // Dashbored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 737);
            this.Controls.Add(this.contentPane1);
            this.Name = "Dashbored";
            this.Text = "Dashbored";
            this.Load += new System.EventHandler(this.Dashbored_Load);
            this.contentPane1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPane1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}