namespace Inventory_Management_System
{
    partial class Form1
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
            this.contentPane2 = new System.Windows.Forms.Panel();
            this.label_LOGIN_PAGE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_USERNAME = new System.Windows.Forms.TextBox();
            this.contentPane2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPane2
            // 
            this.contentPane2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPane2.Controls.Add(this.label_LOGIN_PAGE);
            this.contentPane2.Controls.Add(this.label1);
            this.contentPane2.Controls.Add(this.label2);
            this.contentPane2.Controls.Add(this.button1);
            this.contentPane2.Controls.Add(this.button2);
            this.contentPane2.Controls.Add(this.textBox_PASSWORD);
            this.contentPane2.Controls.Add(this.button3);
            this.contentPane2.Controls.Add(this.textBox_USERNAME);
            this.contentPane2.Location = new System.Drawing.Point(222, 90);
            this.contentPane2.Name = "contentPane2";
            this.contentPane2.Size = new System.Drawing.Size(900, 500);
            this.contentPane2.TabIndex = 0;
            this.contentPane2.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPane1_Paint);
            // 
            // label_LOGIN_PAGE
            // 
            this.label_LOGIN_PAGE.AutoSize = true;
            this.label_LOGIN_PAGE.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LOGIN_PAGE.Location = new System.Drawing.Point(408, 36);
            this.label_LOGIN_PAGE.Name = "label_LOGIN_PAGE";
            this.label_LOGIN_PAGE.Size = new System.Drawing.Size(123, 23);
            this.label_LOGIN_PAGE.TabIndex = 14;
            this.label_LOGIN_PAGE.Text = "LOGIN PAGE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(534, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "CREATE NEW USER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // textBox_PASSWORD
            // 
            this.textBox_PASSWORD.Location = new System.Drawing.Point(351, 194);
            this.textBox_PASSWORD.Name = "textBox_PASSWORD";
            this.textBox_PASSWORD.Size = new System.Drawing.Size(229, 20);
            this.textBox_PASSWORD.TabIndex = 5;
            this.textBox_PASSWORD.UseSystemPasswordChar = true;
            this.textBox_PASSWORD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_PASSWORD_KeyDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(534, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "EXIT APPLICATION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // textBox_USERNAME
            // 
            this.textBox_USERNAME.Location = new System.Drawing.Point(351, 168);
            this.textBox_USERNAME.Name = "textBox_USERNAME";
            this.textBox_USERNAME.Size = new System.Drawing.Size(229, 20);
            this.textBox_USERNAME.TabIndex = 4;
            this.textBox_USERNAME.UseSystemPasswordChar = true;
            this.textBox_USERNAME.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_USERNAME_KeyDown);            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 734);
            this.Controls.Add(this.contentPane2);
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contentPane2.ResumeLayout(false);
            this.contentPane2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPane2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_PASSWORD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox_USERNAME;
        private System.Windows.Forms.Label label_LOGIN_PAGE;
    }
}

