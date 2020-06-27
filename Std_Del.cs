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
    public partial class Std_Del : Form
    {
        public Std_Del()
        {
            InitializeComponent();
        }

        private void Std_Del_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Std_Del_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Std_Del_BtnDel_Click(object sender, EventArgs e)
        {
            string Std_Del_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection Std_Del_conn = new SqlConnection(Std_Del_connString);

            string Std_Del_sql = "delete from student where sno = '" + Std_Del_Sno.Text+ "'";
            try
            {
                Std_Del_conn.Open();
                SqlCommand Std_Del_Comm = new SqlCommand(Std_Del_sql, Std_Del_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Del_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                if (Return_num == 1)//影响行数为1,删除成功
                {
                    MessageBox.Show("学生信息删除成功！", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("学生信息删除失败", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Std_Del_conn.Close();
            }
        }
    }
}
