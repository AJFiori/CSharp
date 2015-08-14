namespace Fiori_lab3
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
            this.btnC = new System.Windows.Forms.Button();
            this.lblER = new System.Windows.Forms.Label();
            this.btnE = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.LBLGR = new System.Windows.Forms.Label();
            this.LBLCL = new System.Windows.Forms.Label();
            this.LBLSN = new System.Windows.Forms.Label();
            this.txtCL = new System.Windows.Forms.TextBox();
            this.txtGR = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(156, 172);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 49;
            this.btnC.Text = "Clear";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblER
            // 
            this.lblER.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblER.ForeColor = System.Drawing.Color.Red;
            this.lblER.Location = new System.Drawing.Point(0, 270);
            this.lblER.Name = "lblER";
            this.lblER.Size = new System.Drawing.Size(372, 13);
            this.lblER.TabIndex = 48;
            this.lblER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnE
            // 
            this.btnE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnE.Location = new System.Drawing.Point(244, 172);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 47;
            this.btnE.Text = "Exit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(50, 220);
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(283, 20);
            this.txtOutPut.TabIndex = 46;
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(70, 172);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(75, 23);
            this.btnGrade.TabIndex = 45;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // LBLGR
            // 
            this.LBLGR.AutoSize = true;
            this.LBLGR.Location = new System.Drawing.Point(67, 131);
            this.LBLGR.Name = "LBLGR";
            this.LBLGR.Size = new System.Drawing.Size(67, 13);
            this.LBLGR.TabIndex = 44;
            this.LBLGR.Text = "Enter Grade:";
            // 
            // LBLCL
            // 
            this.LBLCL.AutoSize = true;
            this.LBLCL.Location = new System.Drawing.Point(67, 94);
            this.LBLCL.Name = "LBLCL";
            this.LBLCL.Size = new System.Drawing.Size(63, 13);
            this.LBLCL.TabIndex = 43;
            this.LBLCL.Text = "Enter Class:";
            // 
            // LBLSN
            // 
            this.LBLSN.AutoSize = true;
            this.LBLSN.Location = new System.Drawing.Point(67, 59);
            this.LBLSN.Name = "LBLSN";
            this.LBLSN.Size = new System.Drawing.Size(83, 13);
            this.LBLSN.TabIndex = 42;
            this.LBLSN.Text = "Students Name:";
            // 
            // txtCL
            // 
            this.txtCL.Location = new System.Drawing.Point(156, 94);
            this.txtCL.Name = "txtCL";
            this.txtCL.Size = new System.Drawing.Size(100, 20);
            this.txtCL.TabIndex = 40;
            // 
            // txtGR
            // 
            this.txtGR.Location = new System.Drawing.Point(156, 128);
            this.txtGR.Name = "txtGR";
            this.txtGR.Size = new System.Drawing.Size(100, 20);
            this.txtGR.TabIndex = 41;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(156, 56);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(155, 20);
            this.txtSN.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Math: M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "English: E";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(160, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Science: S";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnE;
            this.ClientSize = new System.Drawing.Size(372, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label lblER;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Label LBLGR;
        private System.Windows.Forms.Label LBLCL;
        private System.Windows.Forms.Label LBLSN;
        private System.Windows.Forms.TextBox txtCL;
        private System.Windows.Forms.TextBox txtGR;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

