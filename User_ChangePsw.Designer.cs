namespace 学生宿舍管理系统
{
    partial class User_ChangePsw
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
            this.User_ChangePsw_txtNewPsw = new System.Windows.Forms.TextBox();
            this.User_ChangePsw_txtOldPsw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User_ChangePsw_BtnSub = new System.Windows.Forms.Button();
            this.User_ChangePsw_BtnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.User_ChangePsw_username = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.User_ChangePsw_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.User_ChangePsw_txtNewPsw);
            this.groupBox1.Controls.Add(this.User_ChangePsw_txtOldPsw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // User_ChangePsw_txtNewPsw
            // 
            this.User_ChangePsw_txtNewPsw.Location = new System.Drawing.Point(100, 137);
            this.User_ChangePsw_txtNewPsw.Name = "User_ChangePsw_txtNewPsw";
            this.User_ChangePsw_txtNewPsw.Size = new System.Drawing.Size(209, 25);
            this.User_ChangePsw_txtNewPsw.TabIndex = 3;
            // 
            // User_ChangePsw_txtOldPsw
            // 
            this.User_ChangePsw_txtOldPsw.Location = new System.Drawing.Point(100, 88);
            this.User_ChangePsw_txtOldPsw.Name = "User_ChangePsw_txtOldPsw";
            this.User_ChangePsw_txtOldPsw.Size = new System.Drawing.Size(209, 25);
            this.User_ChangePsw_txtOldPsw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // User_ChangePsw_BtnSub
            // 
            this.User_ChangePsw_BtnSub.AutoSize = true;
            this.User_ChangePsw_BtnSub.Location = new System.Drawing.Point(81, 217);
            this.User_ChangePsw_BtnSub.Name = "User_ChangePsw_BtnSub";
            this.User_ChangePsw_BtnSub.Size = new System.Drawing.Size(85, 25);
            this.User_ChangePsw_BtnSub.TabIndex = 1;
            this.User_ChangePsw_BtnSub.Text = "确定（&E）";
            this.User_ChangePsw_BtnSub.UseVisualStyleBackColor = true;
            this.User_ChangePsw_BtnSub.Click += new System.EventHandler(this.User_ChangePsw_BtnSub_Click);
            // 
            // User_ChangePsw_BtnCancel
            // 
            this.User_ChangePsw_BtnCancel.AutoSize = true;
            this.User_ChangePsw_BtnCancel.Location = new System.Drawing.Point(250, 217);
            this.User_ChangePsw_BtnCancel.Name = "User_ChangePsw_BtnCancel";
            this.User_ChangePsw_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.User_ChangePsw_BtnCancel.TabIndex = 2;
            this.User_ChangePsw_BtnCancel.Text = "取消（&C）";
            this.User_ChangePsw_BtnCancel.UseVisualStyleBackColor = true;
            this.User_ChangePsw_BtnCancel.Click += new System.EventHandler(this.User_ChangePsw_BtnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户名：";
            // 
            // User_ChangePsw_username
            // 
            this.User_ChangePsw_username.Location = new System.Drawing.Point(100, 40);
            this.User_ChangePsw_username.Name = "User_ChangePsw_username";
            this.User_ChangePsw_username.Size = new System.Drawing.Size(209, 25);
            this.User_ChangePsw_username.TabIndex = 5;
            // 
            // User_ChangePsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 273);
            this.Controls.Add(this.User_ChangePsw_BtnCancel);
            this.Controls.Add(this.User_ChangePsw_BtnSub);
            this.Controls.Add(this.groupBox1);
            this.Name = "User_ChangePsw";
            this.Text = "修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_ChangePsw_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button User_ChangePsw_BtnSub;
        private System.Windows.Forms.Button User_ChangePsw_BtnCancel;
        private System.Windows.Forms.TextBox User_ChangePsw_txtNewPsw;
        private System.Windows.Forms.TextBox User_ChangePsw_txtOldPsw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox User_ChangePsw_username;
    }
}