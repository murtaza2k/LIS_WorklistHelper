namespace LIS_WorklistHelper
{
    partial class frmLISMaster
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLocations = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabTestMaster = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridTestMaster = new DevExpress.XtraGrid.GridControl();
            this.gridTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridParameters = new DevExpress.XtraGrid.GridControl();
            this.gridProcessingCentre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridMachineMaster = new DevExpress.XtraGrid.GridControl();
            this.gridMachineMasterView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridMachineParamMaster = new DevExpress.XtraGrid.GridControl();
            this.gridMachineParamMasterView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabTestMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTestMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessingCentre)).BeginInit();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineParamMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineParamMasterView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboLocations);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 56);
            this.panel1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(362, 26);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Processing Centre";
            // 
            // cboLocations
            // 
            this.cboLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocations.FormattingEnabled = true;
            this.cboLocations.Location = new System.Drawing.Point(9, 27);
            this.cboLocations.Name = "cboLocations";
            this.cboLocations.Size = new System.Drawing.Size(347, 22);
            this.cboLocations.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1229, 606);
            this.panel2.TabIndex = 2;
            // 
            // tabMain
            // 
            this.tabMain.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabMain.Controls.Add(this.tabTestMaster);
            this.tabMain.Controls.Add(this.tabNavigationPage1);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabTestMaster,
            this.tabNavigationPage1});
            this.tabMain.RegularSize = new System.Drawing.Size(1229, 606);
            this.tabMain.SelectedPage = this.tabTestMaster;
            this.tabMain.Size = new System.Drawing.Size(1229, 606);
            this.tabMain.TabIndex = 1;
            this.tabMain.Text = "Main";
            // 
            // tabTestMaster
            // 
            this.tabTestMaster.Caption = "Test List";
            this.tabTestMaster.Controls.Add(this.splitContainerControl1);
            this.tabTestMaster.Margin = new System.Windows.Forms.Padding(2);
            this.tabTestMaster.Name = "tabTestMaster";
            this.tabTestMaster.Size = new System.Drawing.Size(1229, 579);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridTestMaster);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panel3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1229, 579);
            this.splitContainerControl1.SplitterPosition = 622;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridTestMaster
            // 
            this.gridTestMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTestMaster.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridTestMaster.Location = new System.Drawing.Point(0, 0);
            this.gridTestMaster.MainView = this.gridTest;
            this.gridTestMaster.Margin = new System.Windows.Forms.Padding(2);
            this.gridTestMaster.Name = "gridTestMaster";
            this.gridTestMaster.Size = new System.Drawing.Size(622, 579);
            this.gridTestMaster.TabIndex = 1;
            this.gridTestMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTest,
            this.gridView2});
            this.gridTestMaster.Click += new System.EventHandler(this.gridTestMaster_Click);
            // 
            // gridTest
            // 
            this.gridTest.DetailHeight = 306;
            this.gridTest.GridControl = this.gridTestMaster;
            this.gridTest.Name = "gridTest";
            this.gridTest.OptionsBehavior.Editable = false;
            this.gridTest.OptionsView.ColumnAutoWidth = false;
            this.gridTest.OptionsView.ShowAutoFilterRow = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridParameters);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 579);
            this.panel3.TabIndex = 3;
            // 
            // gridParameters
            // 
            this.gridParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParameters.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridParameters.Location = new System.Drawing.Point(0, 0);
            this.gridParameters.MainView = this.gridProcessingCentre;
            this.gridParameters.Margin = new System.Windows.Forms.Padding(2);
            this.gridParameters.Name = "gridParameters";
            this.gridParameters.Size = new System.Drawing.Size(602, 579);
            this.gridParameters.TabIndex = 2;
            this.gridParameters.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridProcessingCentre,
            this.gridView1});
            // 
            // gridProcessingCentre
            // 
            this.gridProcessingCentre.DetailHeight = 306;
            this.gridProcessingCentre.GridControl = this.gridParameters;
            this.gridProcessingCentre.Name = "gridProcessingCentre";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "MachineMaster";
            this.tabNavigationPage1.Controls.Add(this.splitContainer1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1229, 579);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridMachineMaster);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridMachineParamMaster);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 579);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridMachineMaster
            // 
            this.gridMachineMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMachineMaster.Location = new System.Drawing.Point(0, 0);
            this.gridMachineMaster.MainView = this.gridMachineMasterView;
            this.gridMachineMaster.Name = "gridMachineMaster";
            this.gridMachineMaster.Size = new System.Drawing.Size(427, 579);
            this.gridMachineMaster.TabIndex = 0;
            this.gridMachineMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMachineMasterView});
            this.gridMachineMaster.Click += new System.EventHandler(this.gridMachineMaster_Click);
            // 
            // gridMachineMasterView
            // 
            this.gridMachineMasterView.GridControl = this.gridMachineMaster;
            this.gridMachineMasterView.Name = "gridMachineMasterView";
            this.gridMachineMasterView.OptionsBehavior.Editable = false;
            // 
            // gridMachineParamMaster
            // 
            this.gridMachineParamMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMachineParamMaster.Location = new System.Drawing.Point(0, 0);
            this.gridMachineParamMaster.MainView = this.gridMachineParamMasterView;
            this.gridMachineParamMaster.Name = "gridMachineParamMaster";
            this.gridMachineParamMaster.Size = new System.Drawing.Size(798, 579);
            this.gridMachineParamMaster.TabIndex = 1;
            this.gridMachineParamMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMachineParamMasterView});
            // 
            // gridMachineParamMasterView
            // 
            this.gridMachineParamMasterView.GridControl = this.gridMachineParamMaster;
            this.gridMachineParamMasterView.Name = "gridMachineParamMasterView";
            this.gridMachineParamMasterView.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridParameters;
            this.gridView1.Name = "gridView1";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridTestMaster;
            this.gridView2.Name = "gridView2";
            // 
            // frmLISMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 662);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLISMaster";
            this.Text = "frmLISMaster";
            this.Load += new System.EventHandler(this.frmLISMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabTestMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTestMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProcessingCentre)).EndInit();
            this.tabNavigationPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineMasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineParamMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMachineParamMasterView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLocations;
        private System.Windows.Forms.Button btnLoad;
        private DevExpress.XtraBars.Navigation.TabPane tabMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabTestMaster;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridTestMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTest;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl gridParameters;
        private DevExpress.XtraGrid.Views.Grid.GridView gridProcessingCentre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridMachineMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMachineMasterView;
        private DevExpress.XtraGrid.GridControl gridMachineParamMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMachineParamMasterView;

    }
}