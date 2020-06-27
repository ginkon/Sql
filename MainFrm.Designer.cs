namespace 学生宿舍管理系统
{
    partial class MainFrm
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
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.MainFrm_Std = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Alt = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Late = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Late_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Late_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User_AddDel = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User_Psw = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_About = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Data = new System.Windows.Forms.DataGridView();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFrm_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Std,
            this.MainFrm_Late,
            this.MainFrm_Repair,
            this.MainFrm_User,
            this.MainFrm_About});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(686, 28);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // MainFrm_Std
            // 
            this.MainFrm_Std.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Std_Add,
            this.MainFrm_Std_Del,
            this.MainFrm_Std_Alt,
            this.MainFrm_Std_Pol});
            this.MainFrm_Std.Name = "MainFrm_Std";
            this.MainFrm_Std.Size = new System.Drawing.Size(111, 24);
            this.MainFrm_Std.Text = "学生信息管理";
            this.MainFrm_Std.Click += new System.EventHandler(this.MainFrm_Std_Click);
            // 
            // MainFrm_Std_Add
            // 
            this.MainFrm_Std_Add.Name = "MainFrm_Std_Add";
            this.MainFrm_Std_Add.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Std_Add.Text = "添加学生信息";
            this.MainFrm_Std_Add.Click += new System.EventHandler(this.MainFrm_Std_Add_Click);
            // 
            // MainFrm_Std_Del
            // 
            this.MainFrm_Std_Del.Name = "MainFrm_Std_Del";
            this.MainFrm_Std_Del.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Std_Del.Text = "删除学生信息";
            this.MainFrm_Std_Del.Click += new System.EventHandler(this.MainFrm_Std_Del_Click);
            // 
            // MainFrm_Std_Alt
            // 
            this.MainFrm_Std_Alt.Name = "MainFrm_Std_Alt";
            this.MainFrm_Std_Alt.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Std_Alt.Text = "修改学生信息";
            this.MainFrm_Std_Alt.Click += new System.EventHandler(this.MainFrm_Std_Alt_Click);
            // 
            // MainFrm_Std_Pol
            // 
            this.MainFrm_Std_Pol.Name = "MainFrm_Std_Pol";
            this.MainFrm_Std_Pol.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Std_Pol.Text = "查询学生信息";
            this.MainFrm_Std_Pol.Click += new System.EventHandler(this.MainFrm_Std_Pol_Click);
            // 
            // MainFrm_Late
            // 
            this.MainFrm_Late.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Late_Book,
            this.MainFrm_Late_Pol});
            this.MainFrm_Late.Name = "MainFrm_Late";
            this.MainFrm_Late.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_Late.Text = "晚归管理";
            // 
            // MainFrm_Late_Book
            // 
            this.MainFrm_Late_Book.Name = "MainFrm_Late_Book";
            this.MainFrm_Late_Book.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Late_Book.Text = "晚归登记";
            this.MainFrm_Late_Book.Click += new System.EventHandler(this.MainFrm_Late_Book_Click);
            // 
            // MainFrm_Late_Pol
            // 
            this.MainFrm_Late_Pol.Name = "MainFrm_Late_Pol";
            this.MainFrm_Late_Pol.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Late_Pol.Text = "晚归查询";
            this.MainFrm_Late_Pol.Click += new System.EventHandler(this.MainFrm_Late_Pol_Click);
            // 
            // MainFrm_Repair
            // 
            this.MainFrm_Repair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Repair_Book,
            this.MainFrm_Repair_Pol});
            this.MainFrm_Repair.Name = "MainFrm_Repair";
            this.MainFrm_Repair.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_Repair.Text = "维修管理";
            // 
            // MainFrm_Repair_Book
            // 
            this.MainFrm_Repair_Book.Name = "MainFrm_Repair_Book";
            this.MainFrm_Repair_Book.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Repair_Book.Text = "维修登记";
            this.MainFrm_Repair_Book.Click += new System.EventHandler(this.MainFrm_Repair_Book_Click);
            // 
            // MainFrm_Repair_Pol
            // 
            this.MainFrm_Repair_Pol.Name = "MainFrm_Repair_Pol";
            this.MainFrm_Repair_Pol.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_Repair_Pol.Text = "维修查询";
            this.MainFrm_Repair_Pol.Click += new System.EventHandler(this.MainFrm_Repair_Pol_Click);
            // 
            // MainFrm_User
            // 
            this.MainFrm_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_User_AddDel,
            this.MainFrm_User_Psw});
            this.MainFrm_User.Name = "MainFrm_User";
            this.MainFrm_User.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_User.Text = "用户管理";
            // 
            // MainFrm_User_AddDel
            // 
            this.MainFrm_User_AddDel.Name = "MainFrm_User_AddDel";
            this.MainFrm_User_AddDel.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_User_AddDel.Text = "增删用户";
            this.MainFrm_User_AddDel.Click += new System.EventHandler(this.MainFrm_User_AddDel_Click);
            // 
            // MainFrm_User_Psw
            // 
            this.MainFrm_User_Psw.Name = "MainFrm_User_Psw";
            this.MainFrm_User_Psw.Size = new System.Drawing.Size(181, 26);
            this.MainFrm_User_Psw.Text = "修改密码";
            this.MainFrm_User_Psw.Click += new System.EventHandler(this.MainFrm_User_Psw_Click);
            // 
            // MainFrm_About
            // 
            this.MainFrm_About.Name = "MainFrm_About";
            this.MainFrm_About.Size = new System.Drawing.Size(51, 24);
            this.MainFrm_About.Text = "关于";
            this.MainFrm_About.Visible = false;
            this.MainFrm_About.Click += new System.EventHandler(this.MainFrm_About_Click);
            // 
            // MainFrm_Data
            // 
            this.MainFrm_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainFrm_Data.Location = new System.Drawing.Point(12, 31);
            this.MainFrm_Data.Name = "MainFrm_Data";
            this.MainFrm_Data.RowTemplate.Height = 27;
            this.MainFrm_Data.Size = new System.Drawing.Size(672, 348);
            this.MainFrm_Data.TabIndex = 4;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 382);
            this.Controls.Add(this.MainFrm_Data);
            this.Controls.Add(this.menuStrip4);
            this.Name = "MainFrm";
            this.Text = "学生信息管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFrm_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Late;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_About;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Add;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Del;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Alt;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Pol;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Late_Book;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Late_Pol;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair_Book;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair_Pol;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User_AddDel;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User_Psw;
        private System.Windows.Forms.DataGridView MainFrm_Data;
    }
}