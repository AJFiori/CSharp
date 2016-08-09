namespace DailyCensusReport
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.btnNext = new System.Windows.Forms.Button();
            this.lblHelpHeader = new System.Windows.Forms.Label();
            this.pnlPage1 = new System.Windows.Forms.Panel();
            this.lblPg1 = new System.Windows.Forms.Label();
            this.btnHelpExit = new System.Windows.Forms.Button();
            this.pnlPage2 = new System.Windows.Forms.Panel();
            this.lblSubmittingInfoHelp = new System.Windows.Forms.Label();
            this.lblPg2 = new System.Windows.Forms.Label();
            this.pnlPage1.SuspendLayout();
            this.pnlPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(370, 393);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblHelpHeader
            // 
            this.lblHelpHeader.AutoSize = true;
            this.lblHelpHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpHeader.Location = new System.Drawing.Point(15, 20);
            this.lblHelpHeader.Name = "lblHelpHeader";
            this.lblHelpHeader.Size = new System.Drawing.Size(213, 31);
            this.lblHelpHeader.TabIndex = 0;
            this.lblHelpHeader.Text = "Getting Started..";
            // 
            // pnlPage1
            // 
            this.pnlPage1.Controls.Add(this.btnNext);
            this.pnlPage1.Controls.Add(this.lblPg1);
            this.pnlPage1.Controls.Add(this.lblHelpHeader);
            this.pnlPage1.Controls.Add(this.btnHelpExit);
            this.pnlPage1.Location = new System.Drawing.Point(23, 12);
            this.pnlPage1.Name = "pnlPage1";
            this.pnlPage1.Size = new System.Drawing.Size(493, 426);
            this.pnlPage1.TabIndex = 3;
            // 
            // lblPg1
            // 
            this.lblPg1.AutoSize = true;
            this.lblPg1.Location = new System.Drawing.Point(23, 71);
            this.lblPg1.Name = "lblPg1";
            this.lblPg1.Size = new System.Drawing.Size(0, 13);
            this.lblPg1.TabIndex = 1;
            // 
            // btnHelpExit
            // 
            this.btnHelpExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpExit.Location = new System.Drawing.Point(370, 393);
            this.btnHelpExit.Name = "btnHelpExit";
            this.btnHelpExit.Size = new System.Drawing.Size(120, 30);
            this.btnHelpExit.TabIndex = 3;
            this.btnHelpExit.Text = "Exit";
            this.btnHelpExit.UseVisualStyleBackColor = true;
            this.btnHelpExit.Click += new System.EventHandler(this.btnHelpExit_Click);
            // 
            // pnlPage2
            // 
            this.pnlPage2.Controls.Add(this.lblSubmittingInfoHelp);
            this.pnlPage2.Controls.Add(this.lblPg2);
            this.pnlPage2.Location = new System.Drawing.Point(23, 12);
            this.pnlPage2.Name = "pnlPage2";
            this.pnlPage2.Size = new System.Drawing.Size(493, 378);
            this.pnlPage2.TabIndex = 4;
            // 
            // lblSubmittingInfoHelp
            // 
            this.lblSubmittingInfoHelp.AutoSize = true;
            this.lblSubmittingInfoHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittingInfoHelp.Location = new System.Drawing.Point(19, 19);
            this.lblSubmittingInfoHelp.Name = "lblSubmittingInfoHelp";
            this.lblSubmittingInfoHelp.Size = new System.Drawing.Size(285, 31);
            this.lblSubmittingInfoHelp.TabIndex = 2;
            this.lblSubmittingInfoHelp.Text = "Submitting Information";
            // 
            // lblPg2
            // 
            this.lblPg2.AutoSize = true;
            this.lblPg2.Location = new System.Drawing.Point(22, 71);
            this.lblPg2.Name = "lblPg2";
            this.lblPg2.Size = new System.Drawing.Size(0, 13);
            this.lblPg2.TabIndex = 2;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 447);
            this.Controls.Add(this.pnlPage1);
            this.Controls.Add(this.pnlPage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.pnlPage1.ResumeLayout(false);
            this.pnlPage1.PerformLayout();
            this.pnlPage2.ResumeLayout(false);
            this.pnlPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblHelpHeader;
        private System.Windows.Forms.Panel pnlPage1;
        private System.Windows.Forms.Panel pnlPage2;
        private System.Windows.Forms.Label lblPg1;
        private System.Windows.Forms.Label lblPg2;
        private System.Windows.Forms.Label lblSubmittingInfoHelp;
        private System.Windows.Forms.Button btnHelpExit;
    }
}