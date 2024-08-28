using Microsoft.Data.SqlClient;
using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinForms_ADO;

namespace ProjectPRN
{
    public partial class Home : Form
    {
        DataProvider dp = new DataProvider();
        string budgetId;
        public Home(string budget)
        {
            this.budgetId = budget;
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
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
            dgExpense.DataSource = expenseList;
            if (expenseList != null && expenseList.Count>0)
            {
                label7.Text = "Tổng số tiền chi tiêu: " + SumExpensePrice();
                if (SumExpensePrice() > SumIncomePrice())
                {
                    MessageBox.Show("Số tiền chi tiêu vượt quá thu nhập");
                }
            }
        }

        private bool checkIncomeList()
        {
            List<Income> IncomeList = new List<Income>();
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
                    IncomeList.Add(c);
                }
            }
            if (IncomeList.Count > 0 && IncomeList != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Home_Leave(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public decimal SumExpensePrice()
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
        public decimal SumIncomePrice()
        {
            Boolean checkImcome = false;
            checkImcome = checkIncomeList();
            if (checkImcome)
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
            }return 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string srtSQL = "INSERT [dbo].[Expenses] ( [BudgetID]," +
            " [ExpenseName]," +
            "[Description]," +
            " [ExpensePrice]," +
            " [Date]," +
            " [Invoice]) " +
            "VALUES (" + budgetId + ",@expenseName,@expenseDescription,@expensePrice,N'@expenseDate',@expenseInvoice)";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@expenseName",txtExpenseName.Text),
                new SqlParameter("@expenseDescription",txtExpenseDescription.Text),
                new SqlParameter("@expensePrice",txtPrice.Text),
                new SqlParameter("@expenseDate",txtDate.Text),
                new SqlParameter("@expenseInvoice",txtInvoice.Text)
            };
            if (dp.executeNonQuery(srtSQL, parameters))
            {
                MessageBox.Show("Tạo chi tiêu mới thành công!");
                Home f = new Home(budgetId);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tạo chi tiêu mới không thành công");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && checkGetID(txtID.Text))
            {
                string srtSQL = "update [dbo].[Expenses]" +
                    "  set ExpenseName = @name ,Description= @description,ExpensePrice = @price,Date= @date,Invoice= @invoice where ExpenseID = @id";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@name",txtExpenseName.Text),
                new SqlParameter("@description",txtExpenseDescription.Text),
                new SqlParameter("@price",txtPrice.Text),
                new SqlParameter("@date",txtDate.Text),
                new SqlParameter("@invoice",txtInvoice.Text),
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Thay đổi thành công");
                    Home f = new Home(budgetId);
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
                MessageBox.Show("Không tìm được chi tiêu");
            }
        }

        private void dgExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtID.Text = dgExpense.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtExpenseName.Text = dgExpense.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();//khi click vao dong nao chon dong day
            txtExpenseDescription.Text = dgExpense.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtPrice.Text = dgExpense.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtDate.Text = dgExpense.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            txtInvoice.Text = dgExpense.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
        }

        public Boolean checkGetID(string id)
        {
            List<Expense> list = new List<Expense>();
            String strSQL = "select * from Expenses where Expenses.ExpenseID = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id",txtID.Text)
            };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
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
                    list.Add(c);

                }
            }
            if (list.Count > 0) { return true; }
            return false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && checkGetID(txtID.Text))
            {
                string srtSQL = "delete from Expenses where ExpenseId = @id";
                SqlParameter[] parameters = new SqlParameter[] {
             new SqlParameter("@id",txtID.Text)
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Xóa thành công ");
                    Home f = new Home(budgetId);
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
                MessageBox.Show("Không tìm được chi tiêu");
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            IncomeHome f = new IncomeHome(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            Home f = new Home(budgetId);
            f.Show();
            this.Hide();
        }

        private void btnSaving_Click(object sender, EventArgs e)
        {
            SavingHome f = new SavingHome(budgetId);
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
