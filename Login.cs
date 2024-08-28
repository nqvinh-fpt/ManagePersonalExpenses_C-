using Microsoft.Data.SqlClient;
using System.Data;
using ProjectPRN.Models;
using System.Xml.Linq;
using System.Runtime.Intrinsics.Arm;
using WinForms_ADO;

namespace ProjectPRN
{
    public partial class Login : Form
    {
        string useNameSave;
        string passwordSave;
        public Login(string useName, string password)
        {
            this.useNameSave = useName;
            this.passwordSave = password;
            InitializeComponent();
        }
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            if (useNameSave != null && passwordSave != null && useNameSave.ToString().Length > 0 && passwordSave.ToString().Length > 0)
            {
                txtAccount.Text = useNameSave.ToString();
                txtPassword.Text = passwordSave.ToString();
            }
        }
        DataProvider dp = new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if (txtAccount.Text == null||txtPassword.Text==null ||txtAccount.Text.Length==0||txtPassword.Text.Length==0)
            {
                MessageBox.Show("Tài khoản,mật khẩu không được để trống");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    String strSQl = "select * from Users " +
                        "where UserName = @acc " +
                        "and Password = @pass";
                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@acc",txtAccount.Text),
                    new SqlParameter("@pass",txtPassword.Text)
                };
                    Boolean check = false;
                    using (IDataReader dr = dp.executeQuery2(strSQl, parameters))
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Đăng nhập thành công");
                            check = true;
                            dr.Close();
                            //dong file
                            //chuyen ten nguoi sang trang khac

                        }
                        else
                        {

                            MessageBox.Show("Đăng nhập thất bại !");
                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }

                    }
                    if (check)
                    {
                        String budgetId = GetIdByAccount(txtAccount.Text);
                        Home f = new Home(budgetId);
                        f.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đăng nhập thất bại ! " + ex.Message);
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            
        }

        private string GetIdByAccount(string text)
        {
            String strSQl = "select * from Users " +
                    "where UserName=@acc ";
            SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@acc",txtAccount.Text)
                };
            using (IDataReader dr = dp.executeQuery2(strSQl, parameters))
            {
                if (dr.Read())
                {
                    return dr.GetInt32(8).ToString();
                }
            }
            return "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
