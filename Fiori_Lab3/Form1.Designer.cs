namespace Fiori_Lab3
{
    partial class Form1
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
            this.btnE = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.LBLGR = new System.Windows.Forms.Label();
            this.LBLCL = new System.Windows.Forms.Label();
            this.LBLSN = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.txtGR = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblER = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnE
            // 
            this.btnE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnE.Location = new System.Drawing.Point(193, 158);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 36;
            this.btnE.Text = "Exit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click_1);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(1, 200);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(283, 20);
            this.txtOutPut.TabIndex = 35;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(19, 158);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 33;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click_1);
            // 
            // LBLGR
            // 
            this.LBLGR.AutoSize = true;
            this.LBLGR.Location = new System.Drawing.Point(16, 117);
            this.LBLGR.Name = "LBLGR";
            this.LBLGR.Size = new System.Drawing.Size(67, 13);
            this.LBLGR.TabIndex = 32;
            this.LBLGR.Text = "Enter Grade:";
            // 
            // LBLCL
            // 
            this.LBLCL.AutoSize = true;
            this.LBLCL.Location = new System.Drawing.Point(16, 80);
            this.LBLCL.Name = "LBLCL";
            this.LBLCL.Size = new System.Drawing.Size(63, 13);
            this.LBLCL.TabIndex = 31;
            this.LBLCL.Text = "Enter Class:";
            // 
            // LBLSN
            // 
            this.LBLSN.AutoSize = true;
            this.LBLSN.Location = new System.Drawing.Point(16, 45);
            this.LBLSN.Name = "LBLSN";
            this.LBLSN.Size = new System.Drawing.Size(83, 13);
            this.LBLSN.TabIndex = 30;
            this.LBLSN.Text = "Students Name:";
            // 
            // txtCL
            // 
            this.txtCL.Location = new System.Drawing.Point(105, 80);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(100, 20);
            this.txtCL.TabIndex = 1;
            // 
            // txtGR
            // 
            this.txtGR.Location = new System.Drawing.Point(105, 114);
            this.txtGR.Name = "txtGR";
            this.txtGR.Size = new System.Drawing.Size(100, 20);
            this.txtGR.TabIndex = 2;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(105, 42);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(155, 20);
            this.txtSN.TabIndex = 0;
            // 
            // lblER
            // 
            this.lblER.AutoSize = true;
            this.lblER.ForeColor = System.Drawing.Color.Red;
            this.lblER.Location = new System.Drawing.Point(27, 240);
            this.lblER.Name = "lblER";
            this.lblER.Size = new System.Drawing.Size(0, 13);
            this.lblER.TabIndex = 37;
            this.lblER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(105, 158);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 38;
            this.btnC.Text = "Clear";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnE;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.lblER);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.LBLGR);
            this.Controls.Add(this.LBLCL);
            this.Controls.Add(this.LBLSN);
            this.Controls.Add(this.txtCL);
            this.Controls.Add(this.txtGR);
            this.Controls.Add(this.txtSN);
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label LBLGR;
        private System.Windows.Forms.Label LBLCL;
        private System.Windows.Forms.Label LBLSN;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.TextBox txtGR;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblER;
        private System.Windows.Forms.Button btnC;
    }
}

