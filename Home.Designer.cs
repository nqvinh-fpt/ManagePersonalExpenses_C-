namespace ProjectPRN
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnExpense = new Button();
            btnIncome = new Button();
            btnSaving = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgExpense = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtExpenseName = new TextBox();
            txtExpenseDescription = new TextBox();
            txtPrice = new TextBox();
            txtDate = new TextBox();
            txtInvoice = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgExpense).BeginInit();
            SuspendLayout();
            // 
            // btnExpense
            // 
            btnExpense.BackColor = Color.MistyRose;
            btnExpense.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExpense.Location = new Point(77, 40);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(123, 45);
            btnExpense.TabIndex = 1;
            btnExpense.Text = "Chi Tiêu";
            btnExpense.UseVisualStyleBackColor = false;
            btnExpense.Click += btnExpense_Click;
            // 
            // btnIncome
            // 
            btnIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncome.Location = new Point(340, 40);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(123, 45);
            btnIncome.TabIndex = 2;
            btnIncome.Text = "Thu Nhập";
            btnIncome.UseVisualStyleBackColor = true;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnSaving
            // 
            btnSaving.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaving.Location = new Point(560, 40);
            btnSaving.Name = "btnSaving";
            btnSaving.Size = new Size(123, 45);
            btnSaving.TabIndex = 3;
            btnSaving.Text = "Tiết Kiệm ";
            btnSaving.UseVisualStyleBackColor = true;
            btnSaving.Click += btnSaving_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(594, 525);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 45);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa chi tiêu";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(303, 525);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 45);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Thay đổi chi tiêu";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(77, 525);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 45);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgExpense
            // 
            dgExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpense.Location = new Point(77, 109);
            dgExpense.Name = "dgExpense";
            dgExpense.RowHeadersWidth = 51;
            dgExpense.RowTemplate.Height = 29;
            dgExpense.Size = new Size(640, 178);
            dgExpense.TabIndex = 4;
            dgExpense.CellClick += dgExpense_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 300);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên chi tiêu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 300);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 9;
            label2.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 348);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Ngày tạo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 351);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 11;
            label4.Text = "Số tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 389);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Mã hóa đơn";
            // 
            // txtExpenseName
            // 
            txtExpenseName.Location = new Point(180, 300);
            txtExpenseName.Name = "txtExpenseName";
            txtExpenseName.Size = new Size(185, 27);
            txtExpenseName.TabIndex = 13;
            // 
            // txtExpenseDescription
            // 
            txtExpenseDescription.Location = new Point(437, 300);
            txtExpenseDescription.Name = "txtExpenseDescription";
            txtExpenseDescription.Size = new Size(280, 27);
            txtExpenseDescription.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(180, 348);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 15;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(413, 345);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 16;
            // 
            // txtInvoice
            // 
            txtInvoice.Location = new Point(180, 389);
            txtInvoice.Name = "txtInvoice";
            txtInvoice.Size = new Size(125, 27);
            txtInvoice.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Location = new Point(428, 386);
            txtID.Name = "txtID";
            txtID.Size = new Size(185, 27);
            txtID.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 386);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 18;
            label6.Text = "ID chi tiêu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(77, 441);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 52;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(738, 50);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(40, 29);
            btnLogOut.TabIndex = 53;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += button1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 624);
            Controls.Add(btnLogOut);
            Controls.Add(label7);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(txtInvoice);
            Controls.Add(txtDate);
            Controls.Add(txtPrice);
            Controls.Add(txtExpenseDescription);
            Controls.Add(txtExpenseName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgExpense);
            Controls.Add(btnSaving);
            Controls.Add(btnIncome);
            Controls.Add(btnExpense);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Quản Lý Chi Tiêu Cá Nhân";
            Load += Home_Load;
            Leave += Home_Leave;
            ((System.ComponentModel.ISupportInitialize)dgExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExpense;
        private Button btnIncome;
        private Button btnSaving;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgExpense;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtExpenseName;
        private TextBox txtExpenseDescription;
        private TextBox txtPrice;
        private TextBox txtDate;
        private TextBox txtInvoice;
        private TextBox txtID;
        private Label label6;
        private Label label7;
        private Button btnLogOut;
    }
}