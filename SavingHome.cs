using Microsoft.Data.SqlClient;
using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_ADO;

namespace ProjectPRN
{
    public partial class SavingHome : Form
    {
        public SavingHome()
        {
            InitializeComponent();
        }
        DataProvider dp = new DataProvider();
        string budgetId;
        public SavingHome(string budget)
        {
            this.budgetId = budget;
            InitializeComponent();

        }

        private void SavingHome_Load(object sender, EventArgs e)
        {
            List<Saving> expenseList = new List<Saving>();
            String strSQL = "select " +
                "[SaveId]" +
                ",[BankId]" +
                ",[SaveName]" +
                ",[DateStart]" +
                ",[Interest]" +
                ",[Description]" +
                ",[SavePrice]" +
                "from Savings" +
                " where Savings.BankId= " + budgetId + "";

            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())
                {
                    Saving c = new Saving()
                    {
                        SaveId = dr.GetInt32(0),
                        BankId = dr.GetInt32(1),
                        SaveName = dr.GetString(2).ToString(),
                        DateStart = dr.GetString(3).ToString(),
                        Interest = dr.GetString(4).ToString(),
                        Description = dr.GetString(5).ToString(),
                        SavePrice = dr.GetDecimal(6),
                    };
                    expenseList.Add(c);
                }
            }
            dgSaving.DataSource = expenseList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string srtSQL = "INSERT [dbo].[Savings] ( " +
                "[BankId]" +
                ",[SaveName]" +
                ",[DateStart]" +
                ",[Interest]" +
                ",[Description]" +
                ",[SavePrice]" +
                ",[status]) " +
            "VALUES (" + budgetId + ",@savingName,@savingDate,@savingInterest,@savingDescription,@savingPrice,N'on')";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@savingName",txtName.Text),
                new SqlParameter("@savingDate",txtDate.Text),
                new SqlParameter("@savingInterest",txtInterest.Text),
                new SqlParameter("@savingDescription",txtDescription.Text),
                new SqlParameter("@savingPrice",txtPrice.Text),
            };
            if (dp.executeNonQuery(srtSQL, parameters))
            {
                MessageBox.Show("Tạo chi tiêu mới thành công!");
                SavingHome f = new SavingHome(budgetId);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tạo chi tiêu mới không thành công");
            }
        }

        private void dgSaving_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtID.Text = dgSaving.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgSaving.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();//khi click vao dong nao chon dong day
            txtDate.Text = dgSaving.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtInterest.Text = dgSaving.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtDescription.Text = dgSaving.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtPrice.Text = dgSaving.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
        }
        public Boolean checkGetID(string id)
        {
            List<Saving> list = new List<Saving>();
            String strSQL = "select * from Savings where Savings.SaveId = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",txtID.Text)
            };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    Saving c = new Saving()
                    {
                        SaveId = dr.GetInt32(0),
                        BankId = dr.GetInt32(1),
                        SaveName = dr.GetString(2).ToString(),
                        DateStart = dr.GetString(3).ToString(),
                        Interest = dr.GetString(4).ToString(),
                        Description = dr.GetString(5).ToString(),
                        SavePrice = dr.GetDecimal(6),
                    };
                    list.Add(c);

                }
            }
            if (list.Count > 0) { return true; }
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && checkGetID(txtID.Text))
            {
                string srtSQL = "update [dbo].[Savings]" +
                    "  set SaveName = @name ,DateStart= @date,Interest = @interest,Description= @description ,SavePrice = @price where SaveId = @id";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@date",txtDate.Text),
                new SqlParameter("@interest",txtInterest.Text),
                new SqlParameter("@description",txtDescription.Text),
                new SqlParameter("@price",txtPrice.Text),
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Thay đổi thành công");
                    SavingHome f = new SavingHome(budgetId);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thay đổi lỗi");
                }
            }
            else
            {
                MessageBox.Show("Không tìm được thu nhập");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && checkGetID(txtID.Text))
            {
                string srtSQL = "delete from Savings where SaveID = @id";
                SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("@id",txtID.Text)
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Xóa thành công ");
                    SavingHome f = new SavingHome(budgetId);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không tìm được thu nhập ");
            }
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Home f = new Home(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomeHome f = new IncomeHome(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            SavingHome f = new SavingHome(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
