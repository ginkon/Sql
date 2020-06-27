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
    public partial class Repair_Book : Form
    {
        public Repair_Book()
        {
            InitializeComponent();
        }

        private void Repair_Book_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Repair_Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Repair_Book_BtnSubmit_Click(object sender, EventArgs e)
        {
            string Repair_Book_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection Repair_Book_conn = new SqlConnection(Repair_Book_connString);

            string Repair_Book_sql = "insert into repair(dor_ID,reportTime,rep_time,rep_Reason,rep_Man,rep_Price,fixing,rep_num) values('" + Repair_Book_DorID.Text + "','" + Repair_Book_BookTime.Text + "','" + Repair_Book_RepairTime.Text + "','"+Repair_Book_RepReason.Text+"','" + Repair_Book_RepMan.Text + "','" +Repair_Book_Price.Text+ "','" + Repair_Book_Fixing.Text + "','" + Repair_Book_RepNum.Value.ToString() + "')";
            try
            {
                Repair_Book_conn.Open();
                SqlCommand Repair_Book_Comm = new SqlCommand(Repair_Book_sql, Repair_Book_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Repair_Book_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("提交成功！", "提交成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Repair_Book_DorID.Text = "";
                    Repair_Book_RepReason.Text = "";
                    Repair_Book_RepMan.Text = "";
                    Repair_Book_Price.Text = "";
                    Repair_Book_Fixing.Text = "";
                }
                else
                    MessageBox.Show("提交失败", "提交失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Repair_Book_conn.Close();
            }
        }
    }
}
