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
    public partial class MainFrm_Stu : Form
    {
        public static MainFrm_Stu S_MainFrm = null;
        public static string C_name;
        public static string C_type;
        public SqlConnection DataConn = null;//声明一个数据库连接
        public MainFrm_Stu(string uname,string utype)
        {
            C_name = uname;
            C_type = utype;
            S_MainFrm = this;
            InitializeComponent();
        }

        private void MainFrm_Std_Add_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Std_Del_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Std_Alt_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Std_Pol_Click(object sender, EventArgs e)
        {

        }

        private void Std_MainFrm_Std_Pol_Click(object sender, EventArgs e)
        {
            Std_Pol studentuser_stuPol = new Std_Pol();
            studentuser_stuPol.Show();
            this.Hide();
        }

        private void Std_MainFrm_Late_Pol_Click(object sender, EventArgs e)
        {
            Late_Pol studenteuser_latePol = new Late_Pol();
            studenteuser_latePol.Show();
            this.Hide();
        }

        private void Std_MainFrm_Repair_Pol_Click(object sender, EventArgs e)
        {
            Repair_Pol studentuser_repPol = new Repair_Pol();
            studentuser_repPol.Show();
            this.Hide();
        }

        private void Std_MainFrm_User_Psw_Click(object sender, EventArgs e)
        {
            User_ChangePsw studentuser_changePSW = new User_ChangePsw(C_name, C_type);
            studentuser_changePSW.Show();
            this.Hide();
        }

        private void Std_MainFrm_About_Click(object sender, EventArgs e)
        {
            About studentuser_about = new About();
            studentuser_about.Show();
            this.Hide();
        }

        private void MainFrm_Stu_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from student where sname = '"+C_name+"'";


            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr["class"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = cmd.ExecuteReader();
            //数据表格绑定数据源
            Stu_MainFrm_Data.DataSource = bs;

            conn.Close();
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            Stu_MainFrm_Data.Columns[0].HeaderText = "系号";
            Stu_MainFrm_Data.Columns[1].HeaderText = "班级";
            Stu_MainFrm_Data.Columns[2].HeaderText = "学号";
            Stu_MainFrm_Data.Columns[3].HeaderText = "姓名";
            Stu_MainFrm_Data.Columns[4].HeaderText = "性别";
            Stu_MainFrm_Data.Columns[5].HeaderText = "年龄";
            Stu_MainFrm_Data.Columns[6].HeaderText = "电话";
            Stu_MainFrm_Data.Columns[7].HeaderText = "门牌号";
            Stu_MainFrm_Data.Columns[8].HeaderText = "入住日期";
            Stu_MainFrm_Data.Columns[9].HeaderText = "备注";
            for (int i = 0; i < Stu_MainFrm_Data.Rows.Count; i++)
            {
                Stu_MainFrm_Data.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            /*
            string connString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            string DataSql = "select * from student";//SQL语句

            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);

            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");//适配器匹配数据
            Stu_MainFrm_Data.DataSource = ds;//把dataGridView的数据源设置为ds
            Stu_MainFrm_Data.DataMember = "student";
            DataConn.Close();//关闭数据库连接
            DataConn.Dispose();//释放资源
            */
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 晚归登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 维修登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 增删用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生用户无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Stu_MainFrm_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
