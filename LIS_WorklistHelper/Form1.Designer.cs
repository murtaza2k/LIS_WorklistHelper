namespace LIS_WorklistHelper
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HIMSCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DoctorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DHANo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DHCCNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1019, 416);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HIMSCode,
            this.DoctorName,
            this.DHANo,
            this.DHCCNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // HIMSCode
            // 
            this.HIMSCode.Caption = "HIMSCode";
            this.HIMSCode.FieldName = "HIMSCode";
            this.HIMSCode.Name = "HIMSCode";
            this.HIMSCode.OptionsColumn.AllowEdit = false;
            this.HIMSCode.Visible = true;
            this.HIMSCode.VisibleIndex = 0;
            // 
            // DoctorName
            // 
            this.DoctorName.Caption = "DoctorName";
            this.DoctorName.FieldName = "DoctorName";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.OptionsColumn.AllowEdit = false;
            this.DoctorName.Visible = true;
            this.DoctorName.VisibleIndex = 1;
            // 
            // DHANo
            // 
            this.DHANo.Caption = "DHANo";
            this.DHANo.FieldName = "DHANo";
            this.DHANo.Name = "DHANo";
            this.DHANo.Visible = true;
            this.DHANo.VisibleIndex = 2;
            // 
            // DHCCNo
            // 
            this.DHCCNo.Caption = "DHCCNo";
            this.DHCCNo.FieldName = "DHCCNo";
            this.DHCCNo.Name = "DHCCNo";
            this.DHCCNo.Visible = true;
            this.DHCCNo.VisibleIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 484);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn HIMSCode;
        private DevExpress.XtraGrid.Columns.GridColumn DoctorName;
        private DevExpress.XtraGrid.Columns.GridColumn DHANo;
        private DevExpress.XtraGrid.Columns.GridColumn DHCCNo;

    }
}

