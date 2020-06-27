using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生宿舍管理系统
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_UserType_SelectedIndexChanged(object sender, EventArgs e)
        {
           // login_UserType.SelectedIndex = 0;//设置组合框初始值为第一项
        }

        public void login_btnLogin_Click(object sender, EventArgs e)
        {
            string username = login_txtName.Text.Trim();
            string password = login_txtPsw.Text.Trim();
            string usertype = login_UserType.Text;
            string connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection login_conn = new SqlConnection(connString);
            string login_sql = string.Format("select count(*) from Userlogin where username = '{0}' and password = '{1}' and usertype = '{2}' ", username, password,usertype);
            try
            {
                login_conn.Open();
                SqlCommand login_comm = new SqlCommand(login_sql, login_conn);
                int login_flag = (int)login_comm.ExecuteScalar();
                if(login_flag==1)
                {
                    // MessageBox.Show("欢迎进入学生宿舍管理系统", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (login_UserType.Text == "学生登录")
                    {
                        MainFrm_Stu mainfrm_stu = new MainFrm_Stu(username,password);
                        mainfrm_stu.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MainFrm mainForm = new MainFrm(username,password);
                        mainForm.Show();//打开主窗体
                        this.Visible = false;//登录窗体隐藏
                    }

                }
                else
                {
                    login_txtPsw.Text = "";//如果账号或者密码错误，则清空密码
                    MessageBox.Show("账号或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                login_conn.Close();//关闭数据库连接
            }
        }

        private void login_btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
