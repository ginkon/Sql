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
    public partial class Std_Add : Form
    {
        public Std_Add()
        {
            InitializeComponent();
        }

        private void Std_Add_BtnAdd_Click(object sender, EventArgs e)
        {
            string Std_Add_connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection Std_Add_conn = new SqlConnection(Std_Add_connString);

            string Std_Add_sql = "insert into student(dep_ID,sno,sname,sex,age,dor_ID,class,InTime,tel,Remark) values('" + Std_Add_DepNum.Text + "','" + Std_Add_Sno.Text + "','" + Std_Add_Sname.Text + "','" + Std_Add_Sex.Text + "','" + Std_Add_Sage.Text + "','" + Std_Add_DorID.Text + "','" + Std_Add_Class.Text + "','" + Std_Add_InTime.Text + "','" + Std_Add_Tel.Text + "','" + Std_Add_Remark.Text + "')";
            try
            {
                Std_Add_conn.Open();
                SqlCommand Std_Add_Comm = new SqlCommand(Std_Add_sql, Std_Add_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Add_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("学生信息添加成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Std_Add_DepNum.Text = "";
                    Std_Add_Sno.Text = "";
                    Std_Add_Sname.Text = "";
                    Std_Add_Sex.Text = "";
                    Std_Add_Sage.Text = "";
                    Std_Add_DorID.Text = "";
                    Std_Add_Class.Text = "";
                    Std_Add_Tel.Text = "";
                    Std_Add_Remark.Text = "";
                }
                else
                    MessageBox.Show("学生信息添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                Std_Add_conn.Close();
            }


        }

        private void Std_Add_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Std_Add_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }
    }
}
