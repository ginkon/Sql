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
    public partial class Late_Book : Form
    {
        public Late_Book()
        {
            InitializeComponent();
        }

        private void Late_Book_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Late_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Late_Book_BtnBook_Click(object sender, EventArgs e)
        {
            string Late_Book_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection Late_Book_conn = new SqlConnection(Late_Book_connString);

            string Late_Book_sql = "insert into late_stu(sname,sno,sex,dor_ID,late_time,late_reason) values('"+Late_Book_Sname.Text+"','"+Late_Book_Sno.Text+"','"+Late_Book_Sex.Text+"','"+Late_Book_DorID.Text+"','"+Late_Book_LateTime.Text+"','"+Late_Book_LateReason.Text+"')";
            try
            {
                Late_Book_conn.Open();
                SqlCommand Late_Book_Comm = new SqlCommand(Late_Book_sql, Late_Book_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Late_Book_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("学生晚归信息添加成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("学生晚归信息添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Late_Book_conn.Close();
            }
        }

        private void Late_Book_Load(object sender, EventArgs e)
        {

        }
    }
}
