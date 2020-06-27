namespace 学生宿舍管理系统
{
    partial class MainFrm_Stu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_Std_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.晚归管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.晚归登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_Late_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.维修管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_Repair_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增删用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_User_Psw = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Stu_MainFrm_Data = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stu_MainFrm_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生信息管理ToolStripMenuItem,
            this.晚归管理ToolStripMenuItem,
            this.维修管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.Std_MainFrm_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(736, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生信息管理ToolStripMenuItem
            // 
            this.学生信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.Std_MainFrm_Std_Pol});
            this.学生信息管理ToolStripMenuItem.Name = "学生信息管理ToolStripMenuItem";
            this.学生信息管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.学生信息管理ToolStripMenuItem.Text = "学生信息管理";
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // Std_MainFrm_Std_Pol
            // 
            this.Std_MainFrm_Std_Pol.Name = "Std_MainFrm_Std_Pol";
            this.Std_MainFrm_Std_Pol.Size = new System.Drawing.Size(200, 30);
            this.Std_MainFrm_Std_Pol.Text = "查询学生信息";
            this.Std_MainFrm_Std_Pol.Click += new System.EventHandler(this.Std_MainFrm_Std_Pol_Click);
            // 
            // 晚归管理ToolStripMenuItem
            // 
            this.晚归管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.晚归登记ToolStripMenuItem,
            this.Std_MainFrm_Late_Pol});
            this.晚归管理ToolStripMenuItem.Name = "晚归管理ToolStripMenuItem";
            this.晚归管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.晚归管理ToolStripMenuItem.Text = "晚归管理";
            // 
            // 晚归登记ToolStripMenuItem
            // 
            this.晚归登记ToolStripMenuItem.Name = "晚归登记ToolStripMenuItem";
            this.晚归登记ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.晚归登记ToolStripMenuItem.Text = "晚归登记";
            this.晚归登记ToolStripMenuItem.Click += new System.EventHandler(this.晚归登记ToolStripMenuItem_Click);
            // 
            // Std_MainFrm_Late_Pol
            // 
            this.Std_MainFrm_Late_Pol.Name = "Std_MainFrm_Late_Pol";
            this.Std_MainFrm_Late_Pol.Size = new System.Drawing.Size(164, 30);
            this.Std_MainFrm_Late_Pol.Text = "晚归查询";
            this.Std_MainFrm_Late_Pol.Click += new System.EventHandler(this.Std_MainFrm_Late_Pol_Click);
            // 
            // 维修管理ToolStripMenuItem
            // 
            this.维修管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维修登记ToolStripMenuItem,
            this.Std_MainFrm_Repair_Pol});
            this.维修管理ToolStripMenuItem.Name = "维修管理ToolStripMenuItem";
            this.维修管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.维修管理ToolStripMenuItem.Text = "维修管理";
            // 
            // 维修登记ToolStripMenuItem
            // 
            this.维修登记ToolStripMenuItem.Name = "维修登记ToolStripMenuItem";
            this.维修登记ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.维修登记ToolStripMenuItem.Text = "维修登记";
            this.维修登记ToolStripMenuItem.Click += new System.EventHandler(this.维修登记ToolStripMenuItem_Click);
            // 
            // Std_MainFrm_Repair_Pol
            // 
            this.Std_MainFrm_Repair_Pol.Name = "Std_MainFrm_Repair_Pol";
            this.Std_MainFrm_Repair_Pol.Size = new System.Drawing.Size(164, 30);
            this.Std_MainFrm_Repair_Pol.Text = "维修查询";
            this.Std_MainFrm_Repair_Pol.Click += new System.EventHandler(this.Std_MainFrm_Repair_Pol_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增删用户ToolStripMenuItem,
            this.Std_MainFrm_User_Psw});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 增删用户ToolStripMenuItem
            // 
            this.增删用户ToolStripMenuItem.Name = "增删用户ToolStripMenuItem";
            this.增删用户ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.增删用户ToolStripMenuItem.Text = "增删用户";
            this.增删用户ToolStripMenuItem.Click += new System.EventHandler(this.增删用户ToolStripMenuItem_Click);
            // 
            // Std_MainFrm_User_Psw
            // 
            this.Std_MainFrm_User_Psw.Name = "Std_MainFrm_User_Psw";
            this.Std_MainFrm_User_Psw.Size = new System.Drawing.Size(164, 30);
            this.Std_MainFrm_User_Psw.Text = "修改密码";
            this.Std_MainFrm_User_Psw.Click += new System.EventHandler(this.Std_MainFrm_User_Psw_Click);
            // 
            // Std_MainFrm_About
            // 
            this.Std_MainFrm_About.Name = "Std_MainFrm_About";
            this.Std_MainFrm_About.Size = new System.Drawing.Size(58, 28);
            this.Std_MainFrm_About.Text = "关于";
            this.Std_MainFrm_About.Visible = false;
            this.Std_MainFrm_About.Click += new System.EventHandler(this.Std_MainFrm_About_Click);
            // 
            // Stu_MainFrm_Data
            // 
            this.Stu_MainFrm_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stu_MainFrm_Data.Location = new System.Drawing.Point(14, 38);
            this.Stu_MainFrm_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Stu_MainFrm_Data.Name = "Stu_MainFrm_Data";
            this.Stu_MainFrm_Data.RowTemplate.Height = 27;
            this.Stu_MainFrm_Data.Size = new System.Drawing.Size(709, 308);
            this.Stu_MainFrm_Data.TabIndex = 1;
            this.Stu_MainFrm_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stu_MainFrm_Data_CellContentClick);
            // 
            // MainFrm_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 361);
            this.Controls.Add(this.Stu_MainFrm_Data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainFrm_Stu";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.MainFrm_Stu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stu_MainFrm_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 晚归管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_About;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_Std_Pol;
        private System.Windows.Forms.ToolStripMenuItem 晚归登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_Late_Pol;
        private System.Windows.Forms.ToolStripMenuItem 维修登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_Repair_Pol;
        private System.Windows.Forms.ToolStripMenuItem 增删用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_User_Psw;
        private System.Windows.Forms.DataGridView Stu_MainFrm_Data;
    }
}