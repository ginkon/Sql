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
    public partial class Std_Alt : Form
    {
        public Std_Alt()
        {
            InitializeComponent();
        }

        private void Std_Alt_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Std_Alt_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Std_Alt_BtnOK_Click(object sender, EventArgs e)
        {
            string Std_Alt_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection Std_Alt_conn = new SqlConnection(Std_Alt_connString);

            string Std_Alt_sql = "update student set dep_ID = '" + Std_Alt_DepID.Text + "',class = '" + Std_Alt_Class.Text + "',sname = '" + Std_Alt_Sname.Text + "',sex = '" + Std_Alt_Sex.Text + "',age = '" + Std_Alt_Age.Text + "',tel = '" + Std_Alt_Tel.Text + "',dor_ID = '" + Std_Alt_DorID.Text + "',InTime = '" + Std_Alt_InTime.Text + "',remark = '" + Std_Alt_Remark.Text + "' where sno = '"+Std_Alt_Sno.Text+"'";
            try
            {
                Std_Alt_conn.Open();
                SqlCommand Std_Alt_Comm = new SqlCommand(Std_Alt_sql, Std_Alt_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Alt_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                if (Return_num == 1)//影响行数为1,修改成功
                {
                    MessageBox.Show("学生信息修改成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Std_Alt_DepID.Text = "";
                    Std_Alt_Sno.Text = "";
                    Std_Alt_Sname.Text = "";
                    Std_Alt_Sex.Text = "";
                    Std_Alt_Age.Text = "";
                    Std_Alt_DorID.Text = "";
                    Std_Alt_Class.Text = "";
                    Std_Alt_Tel.Text = "";
                    Std_Alt_Remark.Text = "";
                }
                else
                    MessageBox.Show("学生信息修改失败", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Std_Alt_conn.Close();
            }
        }
    }
}
