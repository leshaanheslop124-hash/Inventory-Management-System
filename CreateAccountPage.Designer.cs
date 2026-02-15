namespace Inventory_Management_System
{
    partial class CreateAccountPage
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
            this.contentPane3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox_USERNAME = new System.Windows.Forms.TextBox();
            this.textBox_PASSWORD = new System.Windows.Forms.TextBox();
            this.textBox_CONFIRM_PASSWORD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contentPane3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPane3
            // 
            this.contentPane3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contentPane3.Controls.Add(this.label8);
            this.contentPane3.Controls.Add(this.button3);
            this.contentPane3.Controls.Add(this.label7);
            this.contentPane3.Controls.Add(this.button4);
            this.contentPane3.Controls.Add(this.button5);
            this.contentPane3.Controls.Add(this.label6);
            this.contentPane3.Controls.Add(this.textBox_USERNAME);
            this.contentPane3.Controls.Add(this.textBox_PASSWORD);
            this.contentPane3.Controls.Add(this.label5);
            this.contentPane3.Controls.Add(this.textBox_CONFIRM_PASSWORD);
            this.contentPane3.Location = new System.Drawing.Point(193, 85);
            this.contentPane3.Name = "contentPane3";
            this.contentPane3.Size = new System.Drawing.Size(900, 500);
            this.contentPane3.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(658, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "EXIT APPLICATION";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 54);
            this.button4.TabIndex = 5;
            this.button4.Text = "BACK TO LOGIN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_BACK_TO_LOGIN_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(379, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 24);
            this.button5.TabIndex = 6;
            this.button5.Text = "CREATE ACCOUNT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_CREATE_ACCOUNT_Click);
            // 
            // textBox_USERNAME
            // 
            this.textBox_USERNAME.Location = new System.Drawing.Point(349, 129);
            this.textBox_USERNAME.Name = "textBox_USERNAME";
            this.textBox_USERNAME.Size = new System.Drawing.Size(237, 20);
            this.textBox_USERNAME.TabIndex = 7;
            // 
            // textBox_PASSWORD
            // 
            this.textBox_PASSWORD.Location = new System.Drawing.Point(349, 155);
            this.textBox_PASSWORD.Name = "textBox_PASSWORD";
            this.textBox_PASSWORD.Size = new System.Drawing.Size(237, 20);
            this.textBox_PASSWORD.TabIndex = 8;
            this.textBox_PASSWORD.UseSystemPasswordChar = true;
            // 
            // textBox_CONFIRM_PASSWORD
            // 
            this.textBox_CONFIRM_PASSWORD.Location = new System.Drawing.Point(349, 181);
            this.textBox_CONFIRM_PASSWORD.Name = "textBox_CONFIRM_PASSWORD";
            this.textBox_CONFIRM_PASSWORD.Size = new System.Drawing.Size(237, 20);
            this.textBox_CONFIRM_PASSWORD.TabIndex = 9;
            this.textBox_CONFIRM_PASSWORD.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "CREATE ACCOUNT PAGE";
            // 
            // CreateAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 734);
            this.Controls.Add(this.contentPane3);
            this.Name = "CreateAccountPage";
            this.Text = "CreateAccountPage";
            this.Load += new System.EventHandler(this.CreateAccountPage_Load);
            this.contentPane3.ResumeLayout(false);
            this.contentPane3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel contentPane3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_USERNAME;
        private System.Windows.Forms.TextBox textBox_PASSWORD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CONFIRM_PASSWORD;
    }
}