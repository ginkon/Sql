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
    public partial class Late_Pol : Form
    {
        public Late_Pol()
        {
            InitializeComponent();
        }

        private void Late_Pol_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Late_Pol_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Late_Pol_BtnPol_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from late_stu where sno = '"+Late_Pol_Sno.Text+"'";
            //cmd.CommandText = "select * from student";//

            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr["class"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = cmd.ExecuteReader();
            //数据表格绑定数据源
            Late_Pol_Date.DataSource = bs;

            conn.Close();
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            Late_Pol_Date.Columns[0].HeaderText = "姓名";
            Late_Pol_Date.Columns[1].HeaderText = "学号";
            Late_Pol_Date.Columns[2].HeaderText = "性别";
            Late_Pol_Date.Columns[3].HeaderText = "宿舍号";
            Late_Pol_Date.Columns[4].HeaderText = "时间";
            Late_Pol_Date.Columns[5].HeaderText = "晚归原因";
            for (int i = 0; i < Late_Pol_Date.Rows.Count; i++)
            {
                Late_Pol_Date.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}
