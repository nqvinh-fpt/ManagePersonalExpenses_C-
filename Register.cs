using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_ADO;

namespace ProjectPRN
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        DataProvider dp = new DataProvider();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string password =txtPassword.Text;
            string passwordConfirm=txtConfirmPassword.Text;
            if (!password.Equals(passwordConfirm))
            {
                MessageBox.Show("The password is not the same as the confirmation password!");
                Register register =new Register();
                register.Show();
                this.Hide();
            }
            else
            {
                string srtSQL = "INSERT [dbo].[Budgets] ( [UnitPrice], [Status],[ExpenseID]) VALUES ( 80000000,N'on',4)" +
                    "INSERT [dbo].[Users] ( [UserName], [Name],[Address], [Phone], [Email], [DateOfBith], [Password], [BudgetID]) VALUES ( @userName,@name,@address,@phone,@email,@dob,@pass,4 )";
                SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@userName",txtUserName.Text),
                new SqlParameter("@name",txtName.Text),
                new SqlParameter("@address",txtAddress.Text),
                new SqlParameter("@phone",txtPhone.Text),
                new SqlParameter("@email",txtEmail.Text),
                new SqlParameter("@dob",txtDob.Text),
                new SqlParameter("@pass",txtPassword.Text)
            };
                if (dp.executeNonQuery(srtSQL, parameters))
                {
                    MessageBox.Show("Create new account success!");

                    Login login = new Login(txtUserName.Text,txtPassword.Text);
                    login.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("add fail");
                }
                
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
