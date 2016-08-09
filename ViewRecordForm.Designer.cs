namespace DailyCensusReport
{
    partial class ViewRecordForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRecordForm));
            this.HospitalDepartmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SE265_AJF1130DataSet2 = new DailyCensusReport.SE265_AJF1130DataSet2();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.txtSetDate = new System.Windows.Forms.TextBox();
            this.txtSearchDate = new System.Windows.Forms.TextBox();
            this.rvViewRecords = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUnitName = new System.Windows.Forms.ComboBox();
            this.btnViewAllRecords = new System.Windows.Forms.Button();
            this.HospitalDepartmentsTableAdapter = new DailyCensusReport.SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // HospitalDepartmentsBindingSource
            // 
            this.HospitalDepartmentsBindingSource.DataMember = "HospitalDepartments";
            this.HospitalDepartmentsBindingSource.DataSource = this.SE265_AJF1130DataSet2;
            // 
            // SE265_AJF1130DataSet2
            // 
            this.SE265_AJF1130DataSet2.DataSetName = "SE265_AJF1130DataSet2";
            this.SE265_AJF1130DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Location = new System.Drawing.Point(582, 12);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(162, 21);
            this.btnSearchDate.TabIndex = 0;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDate.Location = new System.Drawing.Point(298, 8);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(122, 24);
            this.lblSearchDate.TabIndex = 1;
            this.lblSearchDate.Text = "Search By Date:";
            // 
            // txtSetDate
            // 
            this.txtSetDate.Location = new System.Drawing.Point(480, 12);
            this.txtSetDate.Name = "txtSetDate";
            this.txtSetDate.Size = new System.Drawing.Size(70, 20);
            this.txtSetDate.TabIndex = 2;
            // 
            // txtSearchDate
            // 
            this.txtSearchDate.Location = new System.Drawing.Point(426, 12);
            this.txtSearchDate.MaxLength = 10;
            this.txtSearchDate.Name = "txtSearchDate";
            this.txtSearchDate.Size = new System.Drawing.Size(150, 20);
            this.txtSearchDate.TabIndex = 3;
            // 
            // rvViewRecords
            // 
            reportDataSource1.Name = "DateSearchViewer";
            reportDataSource1.Value = this.HospitalDepartmentsBindingSource;
            this.rvViewRecords.LocalReport.DataSources.Add(reportDataSource1);
            this.rvViewRecords.LocalReport.ReportEmbeddedResource = "DailyCensusReport.Report2.rdlc";
            this.rvViewRecords.Location = new System.Drawing.Point(12, 90);
            this.rvViewRecords.Name = "rvViewRecords";
            this.rvViewRecords.Size = new System.Drawing.Size(1017, 338);
            this.rvViewRecords.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search By Unit:";
            // 
            // cbUnitName
            // 
            this.cbUnitName.DisplayMember = "Please Select A Unit";
            this.cbUnitName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnitName.FormattingEnabled = true;
            this.cbUnitName.Location = new System.Drawing.Point(426, 46);
            this.cbUnitName.Name = "cbUnitName";
            this.cbUnitName.Size = new System.Drawing.Size(150, 21);
            this.cbUnitName.TabIndex = 6;
            this.cbUnitName.SelectedIndexChanged += new System.EventHandler(this.cbUnitName_SelectedIndexChanged);
            // 
            // btnViewAllRecords
            // 
            this.btnViewAllRecords.Location = new System.Drawing.Point(582, 47);
            this.btnViewAllRecords.Name = "btnViewAllRecords";
            this.btnViewAllRecords.Size = new System.Drawing.Size(162, 21);
            this.btnViewAllRecords.TabIndex = 7;
            this.btnViewAllRecords.Text = "View All Record(s)";
            this.btnViewAllRecords.UseVisualStyleBackColor = true;
            this.btnViewAllRecords.Click += new System.EventHandler(this.btnViewAllRecords_Click);
            // 
            // HospitalDepartmentsTableAdapter
            // 
            this.HospitalDepartmentsTableAdapter.ClearBeforeFill = true;
            // 
            // ViewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 448);
            this.Controls.Add(this.btnViewAllRecords);
            this.Controls.Add(this.cbUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rvViewRecords);
            this.Controls.Add(this.txtSearchDate);
            this.Controls.Add(this.txtSetDate);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.btnSearchDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.ViewRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDepartmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SE265_AJF1130DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.TextBox txtSetDate;
        private System.Windows.Forms.TextBox txtSearchDate;
        private System.Windows.Forms.BindingSource HospitalDepartmentsBindingSource;
        private SE265_AJF1130DataSet2 SE265_AJF1130DataSet2;
        private SE265_AJF1130DataSet2TableAdapters.HospitalDepartmentsTableAdapter HospitalDepartmentsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvViewRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnitName;
        private System.Windows.Forms.Button btnViewAllRecords;
    }
}