namespace 学生宿舍管理系统
{
    partial class Std_Pol
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Std_Pol_DepID = new System.Windows.Forms.TextBox();
            this.Std_Pol_DorID = new System.Windows.Forms.TextBox();
            this.Std_Pol_Sno = new System.Windows.Forms.TextBox();
            this.Std_Pol_BtnPol = new System.Windows.Forms.Button();
            this.Std_Pol_StdDate = new System.Windows.Forms.DataGridView();
            this.Std_Pol_BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Std_Pol_StdDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "系号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "宿舍号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号：";
            // 
            // Std_Pol_DepID
            // 
            this.Std_Pol_DepID.Location = new System.Drawing.Point(85, 6);
            this.Std_Pol_DepID.Name = "Std_Pol_DepID";
            this.Std_Pol_DepID.Size = new System.Drawing.Size(150, 25);
            this.Std_Pol_DepID.TabIndex = 3;
            // 
            // Std_Pol_DorID
            // 
            this.Std_Pol_DorID.Location = new System.Drawing.Point(341, 6);
            this.Std_Pol_DorID.Name = "Std_Pol_DorID";
            this.Std_Pol_DorID.Size = new System.Drawing.Size(167, 25);
            this.Std_Pol_DorID.TabIndex = 4;
            // 
            // Std_Pol_Sno
            // 
            this.Std_Pol_Sno.Location = new System.Drawing.Point(599, 6);
            this.Std_Pol_Sno.Name = "Std_Pol_Sno";
            this.Std_Pol_Sno.Size = new System.Drawing.Size(156, 25);
            this.Std_Pol_Sno.TabIndex = 5;
            // 
            // Std_Pol_BtnPol
            // 
            this.Std_Pol_BtnPol.AutoSize = true;
            this.Std_Pol_BtnPol.Location = new System.Drawing.Point(211, 84);
            this.Std_Pol_BtnPol.Name = "Std_Pol_BtnPol";
            this.Std_Pol_BtnPol.Size = new System.Drawing.Size(85, 25);
            this.Std_Pol_BtnPol.TabIndex = 6;
            this.Std_Pol_BtnPol.Text = "查询（&E）";
            this.Std_Pol_BtnPol.UseVisualStyleBackColor = true;
            this.Std_Pol_BtnPol.Click += new System.EventHandler(this.Std_Pol_BtnPol_Click);
            // 
            // Std_Pol_StdDate
            // 
            this.Std_Pol_StdDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Std_Pol_StdDate.Location = new System.Drawing.Point(12, 147);
            this.Std_Pol_StdDate.Name = "Std_Pol_StdDate";
            this.Std_Pol_StdDate.RowTemplate.Height = 27;
            this.Std_Pol_StdDate.Size = new System.Drawing.Size(770, 338);
            this.Std_Pol_StdDate.TabIndex = 7;
            // 
            // Std_Pol_BtnCancel
            // 
            this.Std_Pol_BtnCancel.AutoSize = true;
            this.Std_Pol_BtnCancel.Location = new System.Drawing.Point(518, 84);
            this.Std_Pol_BtnCancel.Name = "Std_Pol_BtnCancel";
            this.Std_Pol_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.Std_Pol_BtnCancel.TabIndex = 8;
            this.Std_Pol_BtnCancel.Text = "取消（&C）";
            this.Std_Pol_BtnCancel.UseVisualStyleBackColor = true;
            this.Std_Pol_BtnCancel.Click += new System.EventHandler(this.Std_Pol_BtnCancel_Click);
            // 
            // Std_Pol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 497);
            this.Controls.Add(this.Std_Pol_BtnCancel);
            this.Controls.Add(this.Std_Pol_StdDate);
            this.Controls.Add(this.Std_Pol_BtnPol);
            this.Controls.Add(this.Std_Pol_Sno);
            this.Controls.Add(this.Std_Pol_DorID);
            this.Controls.Add(this.Std_Pol_DepID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Std_Pol";
            this.Text = "学生信息查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Std_Pol_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Std_Pol_StdDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Std_Pol_DepID;
        private System.Windows.Forms.TextBox Std_Pol_DorID;
        private System.Windows.Forms.TextBox Std_Pol_Sno;
        private System.Windows.Forms.Button Std_Pol_BtnPol;
        private System.Windows.Forms.DataGridView Std_Pol_StdDate;
        private System.Windows.Forms.Button Std_Pol_BtnCancel;
    }
}