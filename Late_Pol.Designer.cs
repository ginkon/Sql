namespace 学生宿舍管理系统
{
    partial class Late_Pol
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
            this.Late_Pol_BtnPol = new System.Windows.Forms.Button();
            this.Late_Pol_BtnCancel = new System.Windows.Forms.Button();
            this.Late_Pol_Date = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Late_Pol_Sno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Late_Pol_Date)).BeginInit();
            this.SuspendLayout();
            // 
            // Late_Pol_BtnPol
            // 
            this.Late_Pol_BtnPol.AutoSize = true;
            this.Late_Pol_BtnPol.Location = new System.Drawing.Point(147, 447);
            this.Late_Pol_BtnPol.Name = "Late_Pol_BtnPol";
            this.Late_Pol_BtnPol.Size = new System.Drawing.Size(85, 25);
            this.Late_Pol_BtnPol.TabIndex = 3;
            this.Late_Pol_BtnPol.Text = "查询（&P）";
            this.Late_Pol_BtnPol.UseVisualStyleBackColor = true;
            this.Late_Pol_BtnPol.Click += new System.EventHandler(this.Late_Pol_BtnPol_Click);
            // 
            // Late_Pol_BtnCancel
            // 
            this.Late_Pol_BtnCancel.AutoSize = true;
            this.Late_Pol_BtnCancel.Location = new System.Drawing.Point(478, 447);
            this.Late_Pol_BtnCancel.Name = "Late_Pol_BtnCancel";
            this.Late_Pol_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.Late_Pol_BtnCancel.TabIndex = 4;
            this.Late_Pol_BtnCancel.Text = "取消（&C）";
            this.Late_Pol_BtnCancel.UseVisualStyleBackColor = true;
            this.Late_Pol_BtnCancel.Click += new System.EventHandler(this.Late_Pol_BtnCancel_Click);
            // 
            // Late_Pol_Date
            // 
            this.Late_Pol_Date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Late_Pol_Date.Location = new System.Drawing.Point(12, 91);
            this.Late_Pol_Date.Name = "Late_Pol_Date";
            this.Late_Pol_Date.RowTemplate.Height = 27;
            this.Late_Pol_Date.Size = new System.Drawing.Size(693, 335);
            this.Late_Pol_Date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入学号：";
            // 
            // Late_Pol_Sno
            // 
            this.Late_Pol_Sno.Location = new System.Drawing.Point(287, 30);
            this.Late_Pol_Sno.Name = "Late_Pol_Sno";
            this.Late_Pol_Sno.Size = new System.Drawing.Size(173, 25);
            this.Late_Pol_Sno.TabIndex = 7;
            // 
            // Late_Pol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 498);
            this.Controls.Add(this.Late_Pol_Sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Late_Pol_Date);
            this.Controls.Add(this.Late_Pol_BtnCancel);
            this.Controls.Add(this.Late_Pol_BtnPol);
            this.Name = "Late_Pol";
            this.Text = "晚归查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Late_Pol_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Late_Pol_Date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Late_Pol_BtnPol;
        private System.Windows.Forms.Button Late_Pol_BtnCancel;
        private System.Windows.Forms.DataGridView Late_Pol_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Late_Pol_Sno;
    }
}