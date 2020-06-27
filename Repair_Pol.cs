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
    public partial class Repair_Pol : Form
    {
        public Repair_Pol()
        {
            InitializeComponent();
        }

        private void Repair_Pol_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void Repair_Pol_BtnPol_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.;Initial CataLog = Stu_Doemitory;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "select * from repair where dor_ID = '" + Repair_Pol_DorID.Text + "'";

            //SqlDataReader dr = cmd.ExecuteReader();
            //dr.Read();
            //MessageBox.Show(dr["class"].ToString());
            BindingSource bs = new BindingSource();
            bs.DataSource = cmd.ExecuteReader();
            //数据表格绑定数据源
            Repair_Pol_AllDate.DataSource = bs;

            conn.Close();
            Repair_Pol_AllDate.Columns[0].HeaderText = "门牌号";
            Repair_Pol_AllDate.Columns[1].HeaderText = "上报时间";
            Repair_Pol_AllDate.Columns[2].HeaderText = "维修时间";
            Repair_Pol_AllDate.Columns[3].HeaderText = "原因";
            Repair_Pol_AllDate.Columns[4].HeaderText = "维修人员";
            Repair_Pol_AllDate.Columns[5].HeaderText = "维修价格";
            Repair_Pol_AllDate.Columns[6].HeaderText = "维修设备";
            Repair_Pol_AllDate.Columns[7].HeaderText = "维修数量";
            //MainFrm_Data.CurrentRow.HeaderCell.Value = "1";
            for (int i = 0; i < Repair_Pol_AllDate.Rows.Count; i++)
            {
                Repair_Pol_AllDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}
