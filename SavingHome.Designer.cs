namespace ProjectPRN
{
    partial class SavingHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingHome));
            txtID = new TextBox();
            label6 = new Label();
            txtDate = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgSaving = new DataGridView();
            btnSaving = new Button();
            btnIncome = new Button();
            btnExpense = new Button();
            txtInterest = new TextBox();
            label5 = new Label();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgSaving).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(187, 404);
            txtID.Name = "txtID";
            txtID.Size = new Size(185, 27);
            txtID.TabIndex = 52;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 404);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 51;
            label6.Text = "ID thu nhập";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(420, 356);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(125, 27);
            txtDate.TabIndex = 50;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(187, 359);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 49;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(444, 311);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 27);
            txtDescription.TabIndex = 48;
            // 
            // txtName
            // 
            txtName.Location = new Point(187, 311);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 362);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 46;
            label4.Text = "Số tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 359);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 45;
            label3.Text = "Ngày tạo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(387, 311);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 44;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 311);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 43;
            label1.Text = "Tên thu nhập";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(573, 466);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 45);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Xóa thu nhập";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(310, 466);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 45);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Thay đổi tiết kiệm ";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(84, 466);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 45);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgSaving
            // 
            dgSaving.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSaving.Location = new Point(84, 120);
            dgSaving.Name = "dgSaving";
            dgSaving.RowHeadersWidth = 51;
            dgSaving.RowTemplate.Height = 29;
            dgSaving.Size = new Size(640, 178);
            dgSaving.TabIndex = 39;
            dgSaving.CellClick += dgSaving_CellClick;
            // 
            // btnSaving
            // 
            btnSaving.BackColor = Color.MistyRose;
            btnSaving.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaving.Location = new Point(600, 43);
            btnSaving.Name = "btnSaving";
            btnSaving.Size = new Size(123, 45);
            btnSaving.TabIndex = 38;
            btnSaving.Text = "Tiết Kiệm ";
            btnSaving.UseVisualStyleBackColor = false;
            btnSaving.Click += btnSaving_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = SystemColors.ControlLight;
            btnIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncome.Location = new Point(347, 43);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(123, 45);
            btnIncome.TabIndex = 37;
            btnIncome.Text = "Thu Nhập";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnExpense
            // 
            btnExpense.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExpense.Location = new Point(83, 43);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(123, 45);
            btnExpense.TabIndex = 36;
            btnExpense.Text = "Chi Tiêu";
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnExpense_Click;
            // 
            // txtInterest
            // 
            txtInterest.Location = new Point(646, 359);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(77, 27);
            txtInterest.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 362);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 53;
            label5.Text = "Thời hạn";
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(752, 43);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(40, 29);
            btnLogOut.TabIndex = 55;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // SavingHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 624);
            Controls.Add(btnLogOut);
            Controls.Add(txtInterest);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(txtDate);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgSaving);
            Controls.Add(btnSaving);
            Controls.Add(btnIncome);
            Controls.Add(btnExpense);
            Name = "SavingHome";
            Text = "Quản Lý Chi Tiêu Cá Nhân";
            Load += SavingHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgSaving).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label6;
        private TextBox txtDate;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgSaving;
        private Button btnSaving;
        private Button btnIncome;
        private Button btnExpense;
        private TextBox txtInterest;
        private Label label5;
        private Button btnLogOut;
    }
}