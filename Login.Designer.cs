namespace ProjectPRN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtAccount = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtAccount
            // 
            txtAccount.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAccount.Location = new Point(73, 116);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(278, 29);
            txtAccount.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(73, 151);
            label4.Name = "label4";
            label4.Size = new Size(91, 24);
            label4.TabIndex = 7;
            label4.Text = "Mật khẩu ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(73, 89);
            label5.Name = "label5";
            label5.Size = new Size(124, 24);
            label5.TabIndex = 6;
            label5.Text = "Tên tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(73, 37);
            label6.Name = "label6";
            label6.Size = new Size(287, 51);
            label6.TabIndex = 5;
            label6.Text = "ĐĂNG NHẬP";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(73, 177);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 29);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MistyRose;
            btnLogin.ForeColor = Color.Red;
            btnLogin.Location = new Point(73, 250);
            btnLogin.Margin = new Padding(0, 0, 0, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 43);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng nhập ";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(225, 250);
            button2.Margin = new Padding(0, 0, 0, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 11;
            button2.Text = "Đăng ký ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 624);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtAccount);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAccount;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button2;
    }
}