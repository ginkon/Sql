namespace 学生宿舍管理系统
{
    partial class Late_Book
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
            this.Late_Book_DorID = new System.Windows.Forms.TextBox();
            this.Late_Book_Sno = new System.Windows.Forms.TextBox();
            this.Late_Book_Sex = new System.Windows.Forms.ComboBox();
            this.Late_Book_Sname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Late_Book_LateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Late_Book_LateReason = new System.Windows.Forms.TextBox();
            this.Late_Book_BtnBook = new System.Windows.Forms.Button();
            this.Late_Book_BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Late_Book_DorID);
            this.groupBox1.Controls.Add(this.Late_Book_Sno);
            this.groupBox1.Controls.Add(this.Late_Book_Sex);
            this.groupBox1.Controls.Add(this.Late_Book_Sname);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "锁定学生：";
            // 
            // Late_Book_DorID
            // 
            this.Late_Book_DorID.Location = new System.Drawing.Point(105, 222);
            this.Late_Book_DorID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_DorID.Name = "Late_Book_DorID";
            this.Late_Book_DorID.Size = new System.Drawing.Size(173, 28);
            this.Late_Book_DorID.TabIndex = 8;
            // 
            // Late_Book_Sno
            // 
            this.Late_Book_Sno.Location = new System.Drawing.Point(105, 162);
            this.Late_Book_Sno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_Sno.Name = "Late_Book_Sno";
            this.Late_Book_Sno.Size = new System.Drawing.Size(173, 28);
            this.Late_Book_Sno.TabIndex = 7;
            // 
            // Late_Book_Sex
            // 
            this.Late_Book_Sex.FormattingEnabled = true;
            this.Late_Book_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Late_Book_Sex.Location = new System.Drawing.Point(105, 104);
            this.Late_Book_Sex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_Sex.Name = "Late_Book_Sex";
            this.Late_Book_Sex.Size = new System.Drawing.Size(173, 26);
            this.Late_Book_Sex.TabIndex = 6;
            // 
            // Late_Book_Sname
            // 
            this.Late_Book_Sname.Location = new System.Drawing.Point(104, 42);
            this.Late_Book_Sname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_Sname.Name = "Late_Book_Sname";
            this.Late_Book_Sname.Size = new System.Drawing.Size(174, 28);
            this.Late_Book_Sname.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Late_Book_LateTime);
            this.groupBox2.Location = new System.Drawing.Point(362, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(310, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统时间：";
            // 
            // Late_Book_LateTime
            // 
            this.Late_Book_LateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Late_Book_LateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Late_Book_LateTime.Location = new System.Drawing.Point(17, 37);
            this.Late_Book_LateTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_LateTime.Name = "Late_Book_LateTime";
            this.Late_Book_LateTime.Size = new System.Drawing.Size(286, 28);
            this.Late_Book_LateTime.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "宿舍号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Late_Book_LateReason);
            this.groupBox3.Location = new System.Drawing.Point(55, 349);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(693, 172);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "晚归原因：";
            // 
            // Late_Book_LateReason
            // 
            this.Late_Book_LateReason.Location = new System.Drawing.Point(38, 50);
            this.Late_Book_LateReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_LateReason.Multiline = true;
            this.Late_Book_LateReason.Name = "Late_Book_LateReason";
            this.Late_Book_LateReason.Size = new System.Drawing.Size(613, 86);
            this.Late_Book_LateReason.TabIndex = 0;
            // 
            // Late_Book_BtnBook
            // 
            this.Late_Book_BtnBook.AutoSize = true;
            this.Late_Book_BtnBook.Location = new System.Drawing.Point(215, 545);
            this.Late_Book_BtnBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_BtnBook.Name = "Late_Book_BtnBook";
            this.Late_Book_BtnBook.Size = new System.Drawing.Size(99, 30);
            this.Late_Book_BtnBook.TabIndex = 2;
            this.Late_Book_BtnBook.Text = "登记（&E）";
            this.Late_Book_BtnBook.UseVisualStyleBackColor = true;
            this.Late_Book_BtnBook.Click += new System.EventHandler(this.Late_Book_BtnBook_Click);
            // 
            // Late_Book_BtnCancel
            // 
            this.Late_Book_BtnCancel.AutoSize = true;
            this.Late_Book_BtnCancel.Location = new System.Drawing.Point(503, 545);
            this.Late_Book_BtnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Late_Book_BtnCancel.Name = "Late_Book_BtnCancel";
            this.Late_Book_BtnCancel.Size = new System.Drawing.Size(99, 30);
            this.Late_Book_BtnCancel.TabIndex = 3;
            this.Late_Book_BtnCancel.Text = "取消（&C）";
            this.Late_Book_BtnCancel.UseVisualStyleBackColor = true;
            this.Late_Book_BtnCancel.Click += new System.EventHandler(this.Late_Book_BtnCancel_Click);
            // 
            // Late_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 598);
            this.Controls.Add(this.Late_Book_BtnCancel);
            this.Controls.Add(this.Late_Book_BtnBook);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Late_Book";
            this.Text = "晚归登记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Late_Book_FormClosing);
            this.Load += new System.EventHandler(this.Late_Book_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Late_Book_DorID;
        private System.Windows.Forms.TextBox Late_Book_Sno;
        private System.Windows.Forms.ComboBox Late_Book_Sex;
        private System.Windows.Forms.TextBox Late_Book_Sname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Late_Book_LateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Late_Book_LateReason;
        private System.Windows.Forms.Button Late_Book_BtnBook;
        private System.Windows.Forms.Button Late_Book_BtnCancel;
    }
}