namespace Fiori_Ch4_lab2
{
    partial class AreaandPerimeter
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
            this.btnE = new System.Windows.Forms.Button();
            this.lblL = new System.Windows.Forms.Label();
            this.lblW = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(32, 142);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 23);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "Calculate";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.btnC.Enter += new System.EventHandler(this.btnC_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(163, 142);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 23);
            this.btnE.TabIndex = 5;
            this.btnE.Text = "Exit";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(29, 19);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(43, 13);
            this.lblL.TabIndex = 2;
            this.lblL.Text = "Length:";
            // 
            // lblW
            // 
            this.lblW.AutoSize = true;
            this.lblW.Location = new System.Drawing.Point(29, 45);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(38, 13);
            this.lblW.TabIndex = 3;
            this.lblW.Text = "Width:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(29, 73);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(32, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "Area:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(29, 98);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(54, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "Perimeter:";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(138, 19);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(100, 20);
            this.txtL.TabIndex = 0;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(138, 45);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(100, 20);
            this.txtW.TabIndex = 1;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(138, 71);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(138, 98);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 3;
            // 
            // AreaandPerimeter
            // 
            this.AcceptButton = this.btnC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnE;
            this.ClientSize = new System.Drawing.Size(267, 207);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnC);
            this.Name = "AreaandPerimeter";
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtP;
    }
}

