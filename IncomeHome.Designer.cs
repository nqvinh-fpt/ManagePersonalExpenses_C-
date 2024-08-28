namespace ProjectPRN
{
    partial class IncomeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeHome));
            btnSaving = new Button();
            btnIncome = new Button();
            btnExpense = new Button();
            txtPrice = new TextBox();
            txtIncomeDescription = new TextBox();
            txtIncomeName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgIncome = new DataGridView();
            label7 = new Label();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgIncome).BeginInit();
            SuspendLayout();
            // 
            // btnSaving
            // 
            btnSaving.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaving.Location = new Point(607, 40);
            btnSaving.Name = "btnSaving";
            btnSaving.Size = new Size(123, 45);
            btnSaving.TabIndex = 6;
            btnSaving.Text = "Tiết Kiệm ";
            btnSaving.UseVisualStyleBackColor = true;
            btnSaving.Click += btnSaving_Click;
            // 
            // btnIncome
            // 
            btnIncome.BackColor = Color.MistyRose;
            btnIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIncome.Location = new Point(354, 40);
            btnIncome.Name = "btnIncome";
            btnIncome.Size = new Size(123, 45);
            btnIncome.TabIndex = 5;
            btnIncome.Text = "Thu Nhập";
            btnIncome.UseVisualStyleBackColor = false;
            btnIncome.Click += btnIncome_Click;
            // 
            // btnExpense
            // 
            btnExpense.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExpense.Location = new Point(90, 40);
            btnExpense.Name = "btnExpense";
            btnExpense.Size = new Size(123, 45);
            btnExpense.TabIndex = 4;
            btnExpense.Text = "Chi Tiêu";
            btnExpense.UseVisualStyleBackColor = true;
            btnExpense.Click += btnExpense_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(194, 356);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 31;
            // 
            // txtIncomeDescription
            // 
            txtIncomeDescription.Location = new Point(451, 308);
            txtIncomeDescription.Name = "txtIncomeDescription";
            txtIncomeDescription.Size = new Size(280, 27);
            txtIncomeDescription.TabIndex = 30;
            // 
            // txtIncomeName
            // 
            txtIncomeName.Location = new Point(194, 308);
            txtIncomeName.Name = "txtIncomeName";
            txtIncomeName.Size = new Size(185, 27);
            txtIncomeName.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 359);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 27;
            label4.Text = "Số tiền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 308);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 25;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 308);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 24;
            label1.Text = "Tên thu nhập";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(580, 534);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 45);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa thu nhập";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(317, 534);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 45);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Thay đổi thu nhập";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(91, 534);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 45);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgIncome
            // 
            dgIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIncome.Location = new Point(91, 117);
            dgIncome.Name = "dgIncome";
            dgIncome.RowHeadersWidth = 51;
            dgIncome.RowTemplate.Height = 29;
            dgIncome.Size = new Size(640, 178);
            dgIncome.TabIndex = 20;
            dgIncome.CellClick += dgIncome_CellClick;
            dgIncome.CellContentClick += dgIncome_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(91, 455);
            label7.Name = "label7";
            label7.Size = new Size(0, 28);
            label7.TabIndex = 53;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundImage = (Image)resources.GetObject("btnLogOut.BackgroundImage");
            btnLogOut.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogOut.Location = new Point(757, 40);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(40, 29);
            btnLogOut.TabIndex = 54;
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // IncomeHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(822, 624);
            Controls.Add(btnLogOut);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(txtIncomeDescription);
            Controls.Add(txtIncomeName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgIncome);
            Controls.Add(btnSaving);
            Controls.Add(btnIncome);
            Controls.Add(btnExpense);
            Name = "IncomeHome";
            Text = "Quản Lý Chi Tiêu Cá Nhân";
            Load += IncomeHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgIncome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaving;
        private Button btnIncome;
        private Button btnExpense;
        private TextBox txtPrice;
        private TextBox txtIncomeDescription;
        private TextBox txtIncomeName;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgIncome;
        private Label label7;
        private Button btnLogOut;
    }
}