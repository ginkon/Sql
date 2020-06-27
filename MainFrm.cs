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
    public partial class MainFrm : Form
    {
        public static MainFrm P_MainFrm = null;
        public static string C_name;
        public static string C_type;
        public SqlConnection DataConn = null;//声明一个数据库连接
        public MainFrm(string uname,string utype)
        {
            C_name = uname;
            C_type = utype;
            P_MainFrm = this;
            InitializeComponent();
        }

        private void MainFrm_Std_Add_Click(object sender, EventArgs e)
        {
            Std_Add student_infoAdd = new Std_Add();
            student_infoAdd.Show();//显示学生信息添加窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Del_Click(object sender, EventArgs e)
        {
            Std_Del student_infoDel = new Std_Del();
            student_infoDel.Show();//显示学生信息删除窗口
                                   // this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Alt_Click(object sender, EventArgs e)
        {
            Std_Alt student_infoAlt = new Std_Alt();
            student_infoAlt.Show();//显示学生信息修改窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Pol_Click(object sender, EventArgs e)
        {
            Std_Pol student_infoPol = new Std_Pol();
            student_infoPol.Show();//显示学生信息查询窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Late_Book_Click(object sender, EventArgs e)
        {
            Late_Book student_LateBook = new Late_Book();
            student_LateBook.Show();//显示学生晚归录入窗口
                                    // this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Late_Pol_Click(object sender, EventArgs e)
        {
            Late_Pol student_LatePol = new Late_Pol();
            student_LatePol.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void MainFrm_Repair_Book_Click(object sender, EventArgs e)
        {
            Repair_Book Man_repair_Book = new Repair_Book();
            Man_repair_Book.Show();
            //this.Visible = false;
            this.Hide();
        }

        private void MainFrm_Repair_Pol_Click(object sender, EventArgs e)
        {
            Repair_Pol Man_Repair_Pol = new Repair_Pol();
            Man_Repair_Pol.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void MainFrm_User_AddDel_Click(object sender, EventArgs e)
        {
            User_AddDel User_AddDel_C = new User_AddDel();
            User_AddDel_C.Show();
            // this.Visible = false;
            this.Hide();
        }

        public void MainFrm_User_Psw_Click(object sender, EventArgs e)
        {
            User_ChangePsw User_PswChange = new User_ChangePsw(C_name,C_type);
            User_PswChange.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void MainFrm_About_Click(object sender, EventArgs e)
        {
            About about_me = new About();
            about_me.ShowDialog();
            this.Hide();
        }

        private void MainFrm_Std_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from student ";


            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr["class"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = cmd.ExecuteReader();
            //数据表格绑定数据源
            MainFrm_Data.DataSource = bs;

            conn.Close();
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            MainFrm_Data.Columns[0].HeaderText = "系号";
            MainFrm_Data.Columns[1].HeaderText = "班级";
            MainFrm_Data.Columns[2].HeaderText = "学号";
            MainFrm_Data.Columns[3].HeaderText = "姓名";
            MainFrm_Data.Columns[4].HeaderText = "性别";
            MainFrm_Data.Columns[5].HeaderText = "年龄";
            MainFrm_Data.Columns[6].HeaderText = "电话";
            MainFrm_Data.Columns[7].HeaderText = "门牌号";
            MainFrm_Data.Columns[8].HeaderText = "入住日期";
            MainFrm_Data.Columns[9].HeaderText = "备注";
            for (int i = 0; i < MainFrm_Data.Rows.Count; i++)
            {
                MainFrm_Data.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            /*
            string connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            string DataSql = "select * from student";//SQL语句

            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);

            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "ds的一个表名");//适配器匹配数据
            MainFrm_Data.DataSource = ds;//把dataGridView的数据源设置为ds
            MainFrm_Data.DataMember = "ds的一个表名";
            DataConn.Close();//关闭数据库连接
            DataConn.Dispose();//释放资源
            */

        }
    }
}
