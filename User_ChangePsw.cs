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
    public partial class User_ChangePsw : Form
    {
        public static string Uname;
        public static string Utype;
        public User_ChangePsw(string USER_name,string User_type)
        {
            Uname = USER_name;
            Utype = User_type;
            InitializeComponent();
        }

        private void User_ChangePsw_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void User_ChangePsw_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void User_ChangePsw_BtnSub_Click(object sender, EventArgs e)
        {
            string User_ChangePsw_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection User_ChangePsw_conn = new SqlConnection(User_ChangePsw_connString);

            string User_ChangePsw_check = "select count(*) from userlogin where username = '" + User_ChangePsw_username.Text + "'and password = '" + User_ChangePsw_txtOldPsw.Text + "'";
            User_ChangePsw_conn.Open();
            SqlCommand User_ChangePsw_checkComm = new SqlCommand(User_ChangePsw_check, User_ChangePsw_conn);
            int Return_checkNum = (int)User_ChangePsw_checkComm.ExecuteScalar();
            if (Return_checkNum == 1)
            {


                string User_ChangePsw_sql = "update userlogin set password = '" + User_ChangePsw_txtNewPsw.Text + "' where username = '" + User_ChangePsw_username.Text + "'";
                try
                {
                    //User_ChangePsw_conn.Open();
                    SqlCommand User_ChangePsw_Comm = new SqlCommand(User_ChangePsw_sql, User_ChangePsw_conn);
                    int Return_num = (int)User_ChangePsw_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                    if (Return_num == 1)//影响行数为1,修改成功
                    {
                        MessageBox.Show("修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("修改失败", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    User_ChangePsw_conn.Close();
                }
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "用户名或密码错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
            
        }
    }
}
