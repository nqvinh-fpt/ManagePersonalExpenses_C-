namespace ProjectPRN
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(69, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 22);
            textBox1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(69, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 22);
            textBox2.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(69, 189);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 30;
            label4.Text = "Mật khẩu mới ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(69, 145);
            label5.Name = "label5";
            label5.Size = new Size(78, 16);
            label5.TabIndex = 29;
            label5.Text = "Mật khẩu cũ";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(205, 320);
            button2.Margin = new Padding(0, 0, 0, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 43);
            button2.TabIndex = 28;
            button2.Text = "Đăng ký ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(69, 320);
            button1.Margin = new Padding(0, 0, 0, 3);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 27;
            button1.Text = "Đăng nhập ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(56, 48);
            label6.Name = "label6";
            label6.Size = new Size(320, 35);
            label6.TabIndex = 26;
            label6.Text = "THAY ĐỔI MẬT KHẨU";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(69, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 22);
            textBox3.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(69, 99);
            label1.Name = "label1";
            label1.Size = new Size(88, 16);
            label1.TabIndex = 33;
            label1.Text = "Tên tài khoản";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(69, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(299, 22);
            textBox4.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(69, 237);
            label2.Name = "label2";
            label2.Size = new Size(144, 16);
            label2.TabIndex = 35;
            label2.Text = "Xác nhận mật khẩu mới";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
    }
}