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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPRN
{
    public partial class IncomeHome : Form
    {
        string idSave;
        public IncomeHome()
        {
            InitializeComponent();
        }
        DataProvider dp = new DataProvider();
        string budgetId;
        public IncomeHome(string budget)
        {
            this.budgetId = budget;
            InitializeComponent();

        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomeHome f = new IncomeHome(budgetId);
            f.Show();
            this.Hide();
        }

        private void IncomeHome_Load(object sender, EventArgs e)
        {

            List<Income> expenseList = new List<Income>();
            String strSQL = "select " +
                "[IncomeID]" +
                ",[BudgetID]" +
                ",[IncomeName]" +
                ",[DateStart]" +
                ",[Description]" +
                ",[IncomePrice]" +
                ",[Status]" +
                "from Incomes" +
                " where Incomes.BudgetID= " + budgetId + "";

            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())
                {
                    Income c = new Income()
                    {
                        IncomeId = dr.GetInt32(0),
                        BudgetId = dr.GetInt32(1),
                        IncomeName = dr.GetString(2).ToString(),
                        DateStart = dr.GetString(3).ToString(),
                        Description = dr.GetString(4).ToString(),
                        IncomePrice = dr.GetDecimal(5),
                        Status = dr.GetString(6).ToString(),
                    };
                    expenseList.Add(c);
                }
            }
            dgIncome.DataSource = expenseList;
            if (expenseList.Count > 0 && expenseList != null)
            {
                label7.Text = "Tổng số tiền thu nhập: " + SumIncomePrice();
                if (SumExpensePrice() > SumIncomePrice())
                {
                    MessageBox.Show("Số tiền chi tiêu vượt quá thu nhập");
                }
            }

        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Home f = new Home(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string srtSQL = "INSERT [dbo].[Incomes] ( " +
                "[BudgetID]," +
            " [IncomeName]," +
            "[DateStart]," +
            " [Description]," +
            " [IncomePrice]," +
            " [Status]) " +
            "VALUES (" + budgetId + ",@incomeName,@incomeDate,@incomeDescription,@incomePrice,N'on')";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@incomeName",txtIncomeName.Text),
                new SqlParameter("@incomeDescription",txtIncomeDescription.Text),
                new SqlParameter("@incomePrice",txtPrice.Text),
                new SqlParameter("@incomeDate",DateTime.Now.ToString("dd/MM/yyyy"))
            };
            if (dp.executeNonQuery(srtSQL, parameters))
            {
                MessageBox.Show("Tạo chi tiêu mới thành công!");
                IncomeHome f = new IncomeHome(budgetId);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tạo chi tiêu mới không thành công");
            }
        }

        public decimal SumExpensePrice()
        {
            Boolean checkExpense = false;
            checkExpense = checkExpenseList();
            if (checkExpense)
            {
                String strSQL = "SELECT SUM(ExpensePrice) FROM Expenses where BudgetID= " + budgetId + "";

                using (IDataReader dr = dp.executeQuery2(strSQL))
                {

                    while (dr.Read())
                    {
                        return dr.GetDecimal(0);

                    }
                }
                return 0;
            }
            return 0;

        }

        private bool checkExpenseList()
        {
            List<Expense> expenseList = new List<Expense>();
            String strSQL = "select " +
                "Expenses.[ExpenseId]," +
                "Expenses.[BudgetId]," +
                "Expenses.[ExpenseName]," +
                "Expenses.[Description]," +
                "Expenses.[ExpensePrice]," +
                "Expenses.[Date]," +
                "Expenses.[Invoice]" +
                "from Expenses" +
                " where Expenses.BudgetID= " + budgetId + "";

            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())
                {
                    Expense c = new Expense()
                    {
                        ExpenseId = dr.GetInt32(0),
                        BudgetId = dr.GetInt32(1),
                        ExpenseName = dr.GetString(2).ToString(),
                        Description = dr.GetString(3).ToString(),
                        ExpensePrice = dr.GetDecimal(4),
                        Date = dr.GetString(5).ToString(),
                        Invoice = dr.GetString(6).ToString(),
                    };
                    expenseList.Add(c);
                }
            }
            if (expenseList != null && expenseList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal SumIncomePrice()
        {
            String strSQL = "SELECT SUM(IncomePrice) FROM Incomes where BudgetID= " + budgetId + "";

            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())
                {
                    return dr.GetDecimal(0);
                }
            }
            return 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idSave != null && checkGetID(idSave))
            {
                string srtSQL = "update [dbo].[Incomes]" +
                    "  set IncomeName = @name ,DateStart= @date,IncomePrice = @price,Description= @description where IncomeID = @id";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",idSave),
                new SqlParameter("@name",txtIncomeName.Text),
                new SqlParameter("@date",DateTime.Now.ToString("dd/MM/yyyy")),
                new SqlParameter("@price",txtPrice.Text),
                new SqlParameter("@description",txtIncomeDescription.Text),
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Thay đổi thành công");
                    IncomeHome f = new IncomeHome(budgetId);
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
        public Boolean checkGetID(string id)
        {
            List<Income> list = new List<Income>();
            String strSQL = "select * from Incomes where Incomes.IncomeID = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",idSave)
            };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    Income c = new Income()
                    {
                        IncomeId = dr.GetInt32(0),
                        BudgetId = dr.GetInt32(1),
                        IncomeName = dr.GetString(2).ToString(),
                        DateStart = dr.GetString(3).ToString(),
                        Description = dr.GetString(4).ToString(),
                        IncomePrice = dr.GetDecimal(5),
                        Status = dr.GetString(6).ToString(),
                    };
                    list.Add(c);

                }
            }
            if (list.Count > 0) { return true; }
            return false;
        }

        private void dgIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            idSave = dgIncome.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtIncomeName.Text = dgIncome.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();//khi click vao dong nao chon dong day

            txtIncomeDescription.Text = dgIncome.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPrice.Text = dgIncome.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idSave != null && checkGetID(idSave))
            {
                string srtSQL = "delete from Incomes where IncomeId = @id";
                SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("@id",idSave.ToString())
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Xóa thành công ");
                    IncomeHome f = new IncomeHome(budgetId);
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

        private void dgIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
