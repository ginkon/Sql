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
    public partial class Std_Pol : Form
    {
        public SqlConnection Std_Pol_DataConn = null;//声明一个数据库连接
        public Std_Pol()
        {
            InitializeComponent();
        }

        private void Std_Pol_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void Std_Pol_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Std_Pol_BtnPol_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text == "")
                cmd.CommandText = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text == "")
                cmd.CommandText = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'and dor_ID = '" + Std_Pol_DorID.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text != "")
                cmd.CommandText = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'and dor_ID = '" + Std_Pol_DorID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";//SQL语句
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text == "")
                cmd.CommandText = "select * from student where dor_ID = '" + Std_Pol_DorID.Text + "'";
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text != "")
                cmd.CommandText = "select * from student where dor_ID = '" + Std_Pol_DorID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text != "")
                cmd.CommandText = "select * from student where sno = '" + Std_Pol_Sno.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text != "")
                cmd.CommandText = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";
            else
                cmd.CommandText = "select * from student";
            //cmd.CommandText = "select * from student";//

            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr["class"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = cmd.ExecuteReader();
            //数据表格绑定数据源
            Std_Pol_StdDate.DataSource = bs;

            conn.Close();
            Std_Pol_StdDate.Columns[0].HeaderText = "系号";
            Std_Pol_StdDate.Columns[1].HeaderText = "班级";
            Std_Pol_StdDate.Columns[2].HeaderText = "学号";
            Std_Pol_StdDate.Columns[3].HeaderText = "姓名";
            Std_Pol_StdDate.Columns[4].HeaderText = "性别";
            Std_Pol_StdDate.Columns[5].HeaderText = "年龄";
            Std_Pol_StdDate.Columns[6].HeaderText = "电话";
            Std_Pol_StdDate.Columns[7].HeaderText = "门牌号";
            Std_Pol_StdDate.Columns[8].HeaderText = "入住日期";
            Std_Pol_StdDate.Columns[9].HeaderText = "备注";
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            for (int i = 0; i < Std_Pol_StdDate.Rows.Count; i++)
            {
                Std_Pol_StdDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            //MainFrm_Data.Columns[0].Width = 80;
            //MainFrm_Data.Columns[0].HeaderText = "姓名";
            //MainFrm_Data.Columns[1].HeaderText = "性别";
            //MainFrm_Data.Columns[2].HeaderText = "年龄";
            //MainFrm_Data.Columns[3].HeaderText = "手机";
            //MainFrm_Data.Columns[4].HeaderText = "简介";
            //MainFrm_Data.Columns[5].HeaderText = "ID";
        }
    }
}
