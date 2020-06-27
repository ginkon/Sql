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
    public partial class User_AddDel : Form
    {
        public User_AddDel()
        {
            InitializeComponent();
        }

        private void User_AddDel_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void User_AddDel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void User_AddDel_BtnAdd_Click(object sender, EventArgs e)
        {
            string User_Add_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection User_Add_conn = new SqlConnection(User_Add_connString);

            string User_AddDel_sql = "insert into userlogin(username,password,usertype) values('" + User_AddDel_AddUserName.Text + "','" + User_AddDel_AddUserPsw.Text + "','" + User_AddDel_AddUserType.Text + "')";
            try
            {
                User_Add_conn.Open();
                SqlCommand User_Add_Comm = new SqlCommand(User_AddDel_sql, User_Add_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)User_Add_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("添加成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                User_Add_conn.Close();
            }
        }

        private void User_AddDel_BtnDel_Click(object sender, EventArgs e)
        {
            string User_Del_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection User_Del_conn = new SqlConnection(User_Del_connString);

            string User_Del_sql = "delete from userlogin where username = '" + User_AddDel_DelUserName.Text + "' and usertype = '" + User_AddDel_DelUserType.Text + "'";
            try
            {
                User_Del_conn.Open();
                SqlCommand User_Del_Comm = new SqlCommand(User_Del_sql, User_Del_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)User_Del_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("删除成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("删除失败", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                User_Del_conn.Close();
            }
        }
    }
}
