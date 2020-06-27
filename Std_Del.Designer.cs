namespace 学生宿舍管理系统
{
    partial class Std_Del
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
            this.Std_Del_BtnDel = new System.Windows.Forms.Button();
            this.Std_Del_BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Std_Del_Sno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Std_Del_BtnDel
            // 
            this.Std_Del_BtnDel.AutoSize = true;
            this.Std_Del_BtnDel.Location = new System.Drawing.Point(51, 142);
            this.Std_Del_BtnDel.Name = "Std_Del_BtnDel";
            this.Std_Del_BtnDel.Size = new System.Drawing.Size(175, 25);
            this.Std_Del_BtnDel.TabIndex = 0;
            this.Std_Del_BtnDel.Text = "删除当前学生信息（&D）";
            this.Std_Del_BtnDel.UseVisualStyleBackColor = true;
            this.Std_Del_BtnDel.Click += new System.EventHandler(this.Std_Del_BtnDel_Click);
            // 
            // Std_Del_BtnCancel
            // 
            this.Std_Del_BtnCancel.AutoSize = true;
            this.Std_Del_BtnCancel.Location = new System.Drawing.Point(98, 203);
            this.Std_Del_BtnCancel.Name = "Std_Del_BtnCancel";
            this.Std_Del_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.Std_Del_BtnCancel.TabIndex = 1;
            this.Std_Del_BtnCancel.Text = "取消（&C）";
            this.Std_Del_BtnCancel.UseVisualStyleBackColor = true;
            this.Std_Del_BtnCancel.Click += new System.EventHandler(this.Std_Del_BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入要删除学生的学号：";
            // 
            // Std_Del_Sno
            // 
            this.Std_Del_Sno.Location = new System.Drawing.Point(67, 88);
            this.Std_Del_Sno.Name = "Std_Del_Sno";
            this.Std_Del_Sno.Size = new System.Drawing.Size(143, 25);
            this.Std_Del_Sno.TabIndex = 3;
            // 
            // Std_Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 262);
            this.Controls.Add(this.Std_Del_Sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Std_Del_BtnCancel);
            this.Controls.Add(this.Std_Del_BtnDel);
            this.Name = "Std_Del";
            this.Text = "删除学生信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Std_Del_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Std_Del_BtnDel;
        private System.Windows.Forms.Button Std_Del_BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Std_Del_Sno;
    }
}