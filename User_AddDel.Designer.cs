namespace 学生宿舍管理系统
{
    partial class User_AddDel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.User_AddDel_AddUserPsw = new System.Windows.Forms.TextBox();
            this.User_AddDel_AddUserType = new System.Windows.Forms.ComboBox();
            this.User_AddDel_AddUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User_AddDel_BtnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.User_AddDel_DelUserType = new System.Windows.Forms.ComboBox();
            this.User_AddDel_DelUserName = new System.Windows.Forms.TextBox();
            this.User_AddDel_BtnDel = new System.Windows.Forms.Button();
            this.User_AddDel_BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.User_AddDel_AddUserPsw);
            this.groupBox1.Controls.Add(this.User_AddDel_AddUserType);
            this.groupBox1.Controls.Add(this.User_AddDel_AddUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.User_AddDel_BtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加用户";
            // 
            // User_AddDel_AddUserPsw
            // 
            this.User_AddDel_AddUserPsw.Location = new System.Drawing.Point(106, 136);
            this.User_AddDel_AddUserPsw.Name = "User_AddDel_AddUserPsw";
            this.User_AddDel_AddUserPsw.Size = new System.Drawing.Size(179, 25);
            this.User_AddDel_AddUserPsw.TabIndex = 6;
            // 
            // User_AddDel_AddUserType
            // 
            this.User_AddDel_AddUserType.FormattingEnabled = true;
            this.User_AddDel_AddUserType.Items.AddRange(new object[] {
            "学生登录",
            "宿管登录",
            "辅导员登录"});
            this.User_AddDel_AddUserType.Location = new System.Drawing.Point(106, 82);
            this.User_AddDel_AddUserType.Name = "User_AddDel_AddUserType";
            this.User_AddDel_AddUserType.Size = new System.Drawing.Size(179, 23);
            this.User_AddDel_AddUserType.TabIndex = 5;
            // 
            // User_AddDel_AddUserName
            // 
            this.User_AddDel_AddUserName.Location = new System.Drawing.Point(106, 36);
            this.User_AddDel_AddUserName.Name = "User_AddDel_AddUserName";
            this.User_AddDel_AddUserName.Size = new System.Drawing.Size(179, 25);
            this.User_AddDel_AddUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "密    码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用    户：";
            // 
            // User_AddDel_BtnAdd
            // 
            this.User_AddDel_BtnAdd.AutoSize = true;
            this.User_AddDel_BtnAdd.Location = new System.Drawing.Point(341, 135);
            this.User_AddDel_BtnAdd.Name = "User_AddDel_BtnAdd";
            this.User_AddDel_BtnAdd.Size = new System.Drawing.Size(85, 25);
            this.User_AddDel_BtnAdd.TabIndex = 0;
            this.User_AddDel_BtnAdd.Text = "添加（&E）";
            this.User_AddDel_BtnAdd.UseVisualStyleBackColor = true;
            this.User_AddDel_BtnAdd.Click += new System.EventHandler(this.User_AddDel_BtnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.User_AddDel_DelUserType);
            this.groupBox2.Controls.Add(this.User_AddDel_DelUserName);
            this.groupBox2.Controls.Add(this.User_AddDel_BtnDel);
            this.groupBox2.Location = new System.Drawing.Point(13, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(459, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "删除用户";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "用户类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "用   户：";
            // 
            // User_AddDel_DelUserType
            // 
            this.User_AddDel_DelUserType.FormattingEnabled = true;
            this.User_AddDel_DelUserType.Items.AddRange(new object[] {
            "学生登录",
            "宿管登录",
            "辅导员登录"});
            this.User_AddDel_DelUserType.Location = new System.Drawing.Point(109, 103);
            this.User_AddDel_DelUserType.Name = "User_AddDel_DelUserType";
            this.User_AddDel_DelUserType.Size = new System.Drawing.Size(179, 23);
            this.User_AddDel_DelUserType.TabIndex = 2;
            // 
            // User_AddDel_DelUserName
            // 
            this.User_AddDel_DelUserName.Location = new System.Drawing.Point(106, 42);
            this.User_AddDel_DelUserName.Name = "User_AddDel_DelUserName";
            this.User_AddDel_DelUserName.Size = new System.Drawing.Size(179, 25);
            this.User_AddDel_DelUserName.TabIndex = 1;
            // 
            // User_AddDel_BtnDel
            // 
            this.User_AddDel_BtnDel.AutoSize = true;
            this.User_AddDel_BtnDel.Location = new System.Drawing.Point(341, 102);
            this.User_AddDel_BtnDel.Name = "User_AddDel_BtnDel";
            this.User_AddDel_BtnDel.Size = new System.Drawing.Size(85, 25);
            this.User_AddDel_BtnDel.TabIndex = 0;
            this.User_AddDel_BtnDel.Text = "删除（&D）";
            this.User_AddDel_BtnDel.UseVisualStyleBackColor = true;
            this.User_AddDel_BtnDel.Click += new System.EventHandler(this.User_AddDel_BtnDel_Click);
            // 
            // User_AddDel_BtnCancel
            // 
            this.User_AddDel_BtnCancel.AutoSize = true;
            this.User_AddDel_BtnCancel.Location = new System.Drawing.Point(209, 380);
            this.User_AddDel_BtnCancel.Name = "User_AddDel_BtnCancel";
            this.User_AddDel_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.User_AddDel_BtnCancel.TabIndex = 2;
            this.User_AddDel_BtnCancel.Text = "取消（&C）";
            this.User_AddDel_BtnCancel.UseVisualStyleBackColor = true;
            this.User_AddDel_BtnCancel.Click += new System.EventHandler(this.User_AddDel_BtnCancel_Click);
            // 
            // User_AddDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 415);
            this.Controls.Add(this.User_AddDel_BtnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_AddDel";
            this.Text = "增删用户";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_AddDel_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox User_AddDel_AddUserPsw;
        private System.Windows.Forms.ComboBox User_AddDel_AddUserType;
        private System.Windows.Forms.TextBox User_AddDel_AddUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button User_AddDel_BtnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox User_AddDel_DelUserType;
        private System.Windows.Forms.TextBox User_AddDel_DelUserName;
        private System.Windows.Forms.Button User_AddDel_BtnDel;
        private System.Windows.Forms.Button User_AddDel_BtnCancel;
    }
}