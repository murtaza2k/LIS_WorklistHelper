namespace LIS_WorklistHelper
{
    partial class frmWorklist
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMRN = new System.Windows.Forms.TextBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbPending = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRegistrationCentre = new System.Windows.Forms.ComboBox();
            this.btnShowWorklist = new System.Windows.Forms.Button();
            this.dtpWorkList = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLocations = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gridTestList = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DeptName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TestCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TestPrintAs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SampleStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SampleType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gridWorklistPatient = new DevExpress.XtraGrid.GridControl();
            this.gridPatientList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VstNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Regno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PatSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PCDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalTests = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Accepted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SNR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Rejected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotAccepted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LabNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridWorkHeader = new DevExpress.XtraGrid.GridControl();
            this.grdHeader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.WLId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WLName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SourceCentreCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProcessCentreCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WLDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WLTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Valid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorklistPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMRN);
            this.panel1.Controls.Add(this.rdbAll);
            this.panel1.Controls.Add(this.rdbPending);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboRegistrationCentre);
            this.panel1.Controls.Add(this.btnShowWorklist);
            this.panel1.Controls.Add(this.dtpWorkList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboLocations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 84);
            this.panel1.TabIndex = 0;
            // 
            // txtMRN
            // 
            this.txtMRN.Location = new System.Drawing.Point(735, 46);
            this.txtMRN.Name = "txtMRN";
            this.txtMRN.Size = new System.Drawing.Size(140, 26);
            this.txtMRN.TabIndex = 8;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(648, 47);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(42, 22);
            this.rdbAll.TabIndex = 7;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "All";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbPending
            // 
            this.rdbPending.AutoSize = true;
            this.rdbPending.Location = new System.Drawing.Point(648, 23);
            this.rdbPending.Name = "rdbPending";
            this.rdbPending.Size = new System.Drawing.Size(79, 22);
            this.rdbPending.TabIndex = 6;
            this.rdbPending.Text = "Pending";
            this.rdbPending.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source Centre";
            // 
            // cboRegistrationCentre
            // 
            this.cboRegistrationCentre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegistrationCentre.FormattingEnabled = true;
            this.cboRegistrationCentre.Location = new System.Drawing.Point(327, 38);
            this.cboRegistrationCentre.Name = "cboRegistrationCentre";
            this.cboRegistrationCentre.Size = new System.Drawing.Size(298, 26);
            this.cboRegistrationCentre.TabIndex = 4;
            // 
            // btnShowWorklist
            // 
            this.btnShowWorklist.Location = new System.Drawing.Point(1227, 38);
            this.btnShowWorklist.Name = "btnShowWorklist";
            this.btnShowWorklist.Size = new System.Drawing.Size(120, 27);
            this.btnShowWorklist.TabIndex = 3;
            this.btnShowWorklist.Text = "Show";
            this.btnShowWorklist.UseVisualStyleBackColor = true;
            this.btnShowWorklist.Click += new System.EventHandler(this.btnShowWorklist_Click);
            // 
            // dtpWorkList
            // 
            this.dtpWorkList.CustomFormat = "yyyy-MM-dd";
            this.dtpWorkList.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkList.Location = new System.Drawing.Point(735, 19);
            this.dtpWorkList.Name = "dtpWorkList";
            this.dtpWorkList.Size = new System.Drawing.Size(140, 26);
            this.dtpWorkList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processing Centre";
            // 
            // cboLocations
            // 
            this.cboLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocations.FormattingEnabled = true;
            this.cboLocations.Location = new System.Drawing.Point(12, 38);
            this.cboLocations.Name = "cboLocations";
            this.cboLocations.Size = new System.Drawing.Size(298, 26);
            this.cboLocations.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 363);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gridTestList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1350, 251);
            this.panel6.TabIndex = 1;
            // 
            // gridTestList
            // 
            this.gridTestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTestList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridTestList.Location = new System.Drawing.Point(0, 0);
            this.gridTestList.MainView = this.gridView3;
            this.gridTestList.Name = "gridTestList";
            this.gridTestList.Size = new System.Drawing.Size(1350, 251);
            this.gridTestList.TabIndex = 2;
            this.gridTestList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DeptName,
            this.TestCode,
            this.TestPrintAs,
            this.SampleStatus,
            this.SampleType});
            this.gridView3.GridControl = this.gridTestList;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            // 
            // DeptName
            // 
            this.DeptName.Caption = "DeptName";
            this.DeptName.FieldName = "DeptName";
            this.DeptName.Name = "DeptName";
            this.DeptName.Visible = true;
            this.DeptName.VisibleIndex = 0;
            // 
            // TestCode
            // 
            this.TestCode.Caption = "TestCode";
            this.TestCode.FieldName = "TestCode";
            this.TestCode.Name = "TestCode";
            this.TestCode.Visible = true;
            this.TestCode.VisibleIndex = 1;
            // 
            // TestPrintAs
            // 
            this.TestPrintAs.Caption = "TestPrintAs";
            this.TestPrintAs.FieldName = "TestPrintAs";
            this.TestPrintAs.Name = "TestPrintAs";
            this.TestPrintAs.Visible = true;
            this.TestPrintAs.VisibleIndex = 2;
            // 
            // SampleStatus
            // 
            this.SampleStatus.Caption = "SampleStatus";
            this.SampleStatus.FieldName = "SampleStatus";
            this.SampleStatus.Name = "SampleStatus";
            this.SampleStatus.Visible = true;
            this.SampleStatus.VisibleIndex = 3;
            // 
            // SampleType
            // 
            this.SampleType.Caption = "SampleType";
            this.SampleType.FieldName = "SampleType";
            this.SampleType.Name = "SampleType";
            this.SampleType.Visible = true;
            this.SampleType.VisibleIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.gridWorklistPatient);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 106);
            this.panel5.TabIndex = 0;
            // 
            // gridWorklistPatient
            // 
            this.gridWorklistPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWorklistPatient.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridWorklistPatient.Location = new System.Drawing.Point(0, 0);
            this.gridWorklistPatient.MainView = this.gridPatientList;
            this.gridWorklistPatient.Name = "gridWorklistPatient";
            this.gridWorklistPatient.Size = new System.Drawing.Size(1350, 106);
            this.gridWorklistPatient.TabIndex = 1;
            this.gridWorklistPatient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPatientList});
            this.gridWorklistPatient.Click += new System.EventHandler(this.gridWorklistPatient_Click);
            // 
            // gridPatientList
            // 
            this.gridPatientList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WStatus,
            this.VstNo,
            this.Regno,
            this.PatientName,
            this.PatSex,
            this.Age,
            this.PCDescription,
            this.DoctorName,
            this.TotalTests,
            this.Accepted,
            this.SNR,
            this.Rejected,
            this.NotAccepted,
            this.LabNo});
            this.gridPatientList.GridControl = this.gridWorklistPatient;
            this.gridPatientList.Name = "gridPatientList";
            this.gridPatientList.OptionsBehavior.Editable = false;
            this.gridPatientList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridPatientList.OptionsView.ShowAutoFilterRow = true;
            // 
            // WStatus
            // 
            this.WStatus.Caption = "Status";
            this.WStatus.FieldName = "Status";
            this.WStatus.Name = "WStatus";
            this.WStatus.Visible = true;
            this.WStatus.VisibleIndex = 0;
            // 
            // VstNo
            // 
            this.VstNo.Caption = "VstNo";
            this.VstNo.FieldName = "VstNo";
            this.VstNo.Name = "VstNo";
            this.VstNo.Visible = true;
            this.VstNo.VisibleIndex = 1;
            // 
            // Regno
            // 
            this.Regno.Caption = "Regno";
            this.Regno.FieldName = "Regno";
            this.Regno.Name = "Regno";
            this.Regno.Visible = true;
            this.Regno.VisibleIndex = 2;
            // 
            // PatientName
            // 
            this.PatientName.Caption = "PatientName";
            this.PatientName.FieldName = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.Visible = true;
            this.PatientName.VisibleIndex = 3;
            // 
            // PatSex
            // 
            this.PatSex.Caption = "PatSex";
            this.PatSex.FieldName = "PatSex";
            this.PatSex.Name = "PatSex";
            this.PatSex.Visible = true;
            this.PatSex.VisibleIndex = 4;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 5;
            // 
            // PCDescription
            // 
            this.PCDescription.Caption = "PCDescription";
            this.PCDescription.FieldName = "PCDescription";
            this.PCDescription.Name = "PCDescription";
            this.PCDescription.Visible = true;
            this.PCDescription.VisibleIndex = 6;
            // 
            // DoctorName
            // 
            this.DoctorName.Caption = "DoctorName";
            this.DoctorName.FieldName = "DoctorName";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Visible = true;
            this.DoctorName.VisibleIndex = 7;
            // 
            // TotalTests
            // 
            this.TotalTests.Caption = "TotalTests";
            this.TotalTests.FieldName = "TotalTests";
            this.TotalTests.Name = "TotalTests";
            this.TotalTests.Visible = true;
            this.TotalTests.VisibleIndex = 8;
            // 
            // Accepted
            // 
            this.Accepted.Caption = "Accepted";
            this.Accepted.FieldName = "Accepted";
            this.Accepted.Name = "Accepted";
            this.Accepted.Visible = true;
            this.Accepted.VisibleIndex = 9;
            // 
            // SNR
            // 
            this.SNR.Caption = "SNR";
            this.SNR.FieldName = "SNR";
            this.SNR.Name = "SNR";
            this.SNR.Visible = true;
            this.SNR.VisibleIndex = 10;
            // 
            // Rejected
            // 
            this.Rejected.Caption = "Rejected";
            this.Rejected.FieldName = "Rejected";
            this.Rejected.Name = "Rejected";
            this.Rejected.Visible = true;
            this.Rejected.VisibleIndex = 11;
            // 
            // NotAccepted
            // 
            this.NotAccepted.Caption = "NotAccepted";
            this.NotAccepted.FieldName = "NotAccepted";
            this.NotAccepted.Name = "NotAccepted";
            this.NotAccepted.Visible = true;
            this.NotAccepted.VisibleIndex = 12;
            // 
            // LabNo
            // 
            this.LabNo.Caption = "LabNo";
            this.LabNo.FieldName = "LabNo";
            this.LabNo.Name = "LabNo";
            this.LabNo.Visible = true;
            this.LabNo.VisibleIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridWorkHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 170);
            this.panel3.TabIndex = 0;
            // 
            // gridWorkHeader
            // 
            this.gridWorkHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWorkHeader.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridWorkHeader.Location = new System.Drawing.Point(0, 0);
            this.gridWorkHeader.MainView = this.grdHeader;
            this.gridWorkHeader.Name = "gridWorkHeader";
            this.gridWorkHeader.Size = new System.Drawing.Size(1350, 170);
            this.gridWorkHeader.TabIndex = 0;
            this.gridWorkHeader.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdHeader});
            this.gridWorkHeader.Click += new System.EventHandler(this.gridWorkHeader_Click);
            this.grdHeader.FocusedRowChanged += grdHeader_FocusedRowChanged;
            
            // 
            // grdHeader
            // 
            this.grdHeader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.WLId,
            this.WLName,
            this.SourceCentreCode,
            this.ProcessCentreCode,
            this.WLDate,
            this.WLTime,
            this.Status,
            this.Valid});
            this.grdHeader.GridControl = this.gridWorkHeader;
            this.grdHeader.Name = "grdHeader";
            this.grdHeader.OptionsBehavior.Editable = false;
            this.grdHeader.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdHeader.OptionsView.ShowAutoFilterRow = true;
            // 
            // WLId
            // 
            this.WLId.Caption = "WLId";
            this.WLId.FieldName = "WLId";
            this.WLId.Name = "WLId";
            this.WLId.Visible = true;
            this.WLId.VisibleIndex = 0;
            // 
            // WLName
            // 
            this.WLName.Caption = "WLName";
            this.WLName.FieldName = "WLName";
            this.WLName.Name = "WLName";
            this.WLName.Visible = true;
            this.WLName.VisibleIndex = 1;
            // 
            // SourceCentreCode
            // 
            this.SourceCentreCode.Caption = "SourceCentreCode";
            this.SourceCentreCode.FieldName = "SourceCentreCode";
            this.SourceCentreCode.Name = "SourceCentreCode";
            this.SourceCentreCode.Visible = true;
            this.SourceCentreCode.VisibleIndex = 2;
            // 
            // ProcessCentreCode
            // 
            this.ProcessCentreCode.Caption = "ProcessCentreCode";
            this.ProcessCentreCode.FieldName = "ProcessCentreCode";
            this.ProcessCentreCode.Name = "ProcessCentreCode";
            this.ProcessCentreCode.Visible = true;
            this.ProcessCentreCode.VisibleIndex = 3;
            // 
            // WLDate
            // 
            this.WLDate.Caption = "WLDate";
            this.WLDate.FieldName = "WLDate";
            this.WLDate.Name = "WLDate";
            this.WLDate.Visible = true;
            this.WLDate.VisibleIndex = 4;
            // 
            // WLTime
            // 
            this.WLTime.Caption = "WLTime";
            this.WLTime.FieldName = "WLTime";
            this.WLTime.Name = "WLTime";
            // 
            // Status
            // 
            this.Status.Caption = "Status";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 5;
            // 
            // Valid
            // 
            this.Valid.Caption = "Valid";
            this.Valid.FieldName = "Valid";
            this.Valid.Name = "Valid";
            this.Valid.Visible = true;
            this.Valid.VisibleIndex = 6;
            // 
            // frmWorklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 617);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmWorklist";
            this.Text = "Worklist";
            this.Load += new System.EventHandler(this.frmWorklist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWorklistPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatientList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWorkHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdHeader)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLocations;
        private System.Windows.Forms.DateTimePicker dtpWorkList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridWorkHeader;
        private DevExpress.XtraGrid.Views.Grid.GridView grdHeader;
        private System.Windows.Forms.Button btnShowWorklist;
        private DevExpress.XtraGrid.Columns.GridColumn WLId;
        private DevExpress.XtraGrid.Columns.GridColumn WLName;
        private DevExpress.XtraGrid.Columns.GridColumn SourceCentreCode;
        private DevExpress.XtraGrid.Columns.GridColumn ProcessCentreCode;
        private DevExpress.XtraGrid.Columns.GridColumn WLDate;
        private DevExpress.XtraGrid.Columns.GridColumn WLTime;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Valid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboRegistrationCentre;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbPending;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraGrid.GridControl gridWorklistPatient;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPatientList;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraGrid.GridControl gridTestList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn WStatus;
        private DevExpress.XtraGrid.Columns.GridColumn VstNo;
        private DevExpress.XtraGrid.Columns.GridColumn Regno;
        private DevExpress.XtraGrid.Columns.GridColumn PatientName;
        private DevExpress.XtraGrid.Columns.GridColumn PatSex;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn PCDescription;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorName;
        private DevExpress.XtraGrid.Columns.GridColumn TotalTests;
        private DevExpress.XtraGrid.Columns.GridColumn Accepted;
        private DevExpress.XtraGrid.Columns.GridColumn SNR;
        private DevExpress.XtraGrid.Columns.GridColumn Rejected;
        private DevExpress.XtraGrid.Columns.GridColumn NotAccepted;
        private DevExpress.XtraGrid.Columns.GridColumn LabNo;
        private System.Windows.Forms.TextBox txtMRN;
        private DevExpress.XtraGrid.Columns.GridColumn DeptName;
        private DevExpress.XtraGrid.Columns.GridColumn TestCode;
        private DevExpress.XtraGrid.Columns.GridColumn TestPrintAs;
        private DevExpress.XtraGrid.Columns.GridColumn SampleStatus;
        private DevExpress.XtraGrid.Columns.GridColumn SampleType;
    }
}