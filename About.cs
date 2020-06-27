using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生宿舍管理系统
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_BtnOK_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Visible=false;
            
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
           //MainFrm.P_MainFrm.Show();
        }
    }
}
