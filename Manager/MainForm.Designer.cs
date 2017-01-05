namespace Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pa = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnSkin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTextualQuery = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSettings = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.headerPageContainer = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.pnlSpatialQuery = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tblMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSpatialMap = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.mapControl = new AxManifold.Interop.AxComponentControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgSelection = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLeftPane = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSelection = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.chkExportEntireDrawing = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lnkExportToExcel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lnkExportToShape = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.btnSelectGap = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSelectAreaError = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSelectNone = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSelectOverlapping = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbRegion = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbProvince = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbCadSurvey = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbMunicipality = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbCase = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbBarangay = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbQuadrangle = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmbSection = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pnlFilterStatus = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pbrAsyc = new System.Windows.Forms.ProgressBar();
            this.btnFilter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblFilter = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSelection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblProjection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlUsers = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.dgUsers = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccess = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSaveUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlTextualQuery = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tblTextualQuery = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTextualQueryResult = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.grdTextualQuery = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lblTextualQueryResult = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pnlTextualQueryOptions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cbxSelectAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.lblTextualQueryOptions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbxTextualQueryColumns = new ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox();
            this.btnExecute = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgCriteria = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.colColumnName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOperator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colCriteriaValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAndOr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuTextualQuery = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemClear = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSettings = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlReports = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rptReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPageReportLotData = new System.Windows.Forms.TabPage();
            this.btnLoadReportLotData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbxReportLotDataLot = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataSection = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataQuadrangle = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataBarangay = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataCase = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataMunicipality = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportLotDataCadSurveyNo = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lblReportLotDataLotNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataSection = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataQuadrangle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataBarangay = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataCase = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataMunicipality = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportLotDataCadSurveyNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tabPageReportCustom1 = new System.Windows.Forms.TabPage();
            this.btnLoadReportCustom1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbxReportCustom1Lot = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1Section = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1Quadrangle = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1Barangay = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1Case = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1Municipality = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lbxReportCustom1CadSurveyNo = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.lblReportCustom1LotNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1Section = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1Quadrangle = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1Barangay = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1Case = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1Municipality = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblReportCustom1CadSurveyNo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tabPageReportEncodedPerUser = new System.Windows.Forms.TabPage();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblRptEndDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblRptStartDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnRptLoadEncodedLotsPerUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbRptEncodedLotsUsers = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.lblUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tabPageSummaryOfEncodedLots = new System.Windows.Forms.TabPage();
            this.btnRptLoadEncodedLotsSummary = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUsers = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnReports = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSpatialQuery = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.contextMenuUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.GetSqlLotDataBW = new System.ComponentModel.BackgroundWorker();
            this.checkSetNavigation = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.checkSetSelection = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.ExecuteQueryAsyncBW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pa)).BeginInit();
            this.pa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPageContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerPageContainer.Panel)).BeginInit();
            this.headerPageContainer.Panel.SuspendLayout();
            this.headerPageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSpatialQuery)).BeginInit();
            this.pnlSpatialQuery.SuspendLayout();
            this.tblMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSpatialMap)).BeginInit();
            this.pnlSpatialMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelection)).BeginInit();
            this.tblLeftPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelection)).BeginInit();
            this.pnlSelection.SuspendLayout();
            this.flowFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterStatus)).BeginInit();
            this.pnlFilterStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUsers)).BeginInit();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQuery)).BeginInit();
            this.pnlTextualQuery.SuspendLayout();
            this.tblTextualQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQueryResult)).BeginInit();
            this.pnlTextualQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTextualQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQueryOptions)).BeginInit();
            this.pnlTextualQueryOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCriteria)).BeginInit();
            this.contextMenuTextualQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSettings)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReports)).BeginInit();
            this.pnlReports.SuspendLayout();
            this.tabControlReports.SuspendLayout();
            this.tabPageReportLotData.SuspendLayout();
            this.tabPageReportCustom1.SuspendLayout();
            this.tabPageReportEncodedPerUser.SuspendLayout();
            this.tabPageSummaryOfEncodedLots.SuspendLayout();
            this.contextMenuUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pa
            // 
            this.pa.Controls.Add(this.btnSkin);
            this.pa.Controls.Add(this.btnTextualQuery);
            this.pa.Controls.Add(this.btnSettings);
            this.pa.Controls.Add(this.headerPageContainer);
            this.pa.Controls.Add(this.btnUsers);
            this.pa.Controls.Add(this.btnReports);
            this.pa.Controls.Add(this.btnSpatialQuery);
            this.pa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pa.Location = new System.Drawing.Point(0, 0);
            this.pa.Margin = new System.Windows.Forms.Padding(0);
            this.pa.Name = "pa";
            this.pa.Size = new System.Drawing.Size(1093, 741);
            this.pa.TabIndex = 0;
            // 
            // btnSkin
            // 
            this.btnSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSkin.Location = new System.Drawing.Point(702, 42);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(20, 20);
            this.btnSkin.TabIndex = 14;
            this.btnSkin.Values.ExtraText = "";
            this.btnSkin.Values.Image = null;
            this.btnSkin.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSkin.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSkin.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSkin.Values.Text = "";
            this.btnSkin.Visible = false;
            this.btnSkin.Click += new System.EventHandler(this.btnSkin_Click);
            // 
            // btnTextualQuery
            // 
            this.btnTextualQuery.Location = new System.Drawing.Point(150, 12);
            this.btnTextualQuery.Name = "btnTextualQuery";
            this.btnTextualQuery.Size = new System.Drawing.Size(132, 50);
            this.btnTextualQuery.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTextualQuery.StateCommon.Border.Rounding = 5;
            this.btnTextualQuery.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTextualQuery.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnTextualQuery.TabIndex = 15;
            this.btnTextualQuery.Text = "Textual Query";
            this.btnTextualQuery.Values.ExtraText = "";
            this.btnTextualQuery.Values.Image = global::Manager.Properties.Resources.file_find;
            this.btnTextualQuery.Values.Text = "Textual Query";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(564, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(132, 50);
            this.btnSettings.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSettings.StateCommon.Border.Rounding = 5;
            this.btnSettings.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSettings.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Change Settings";
            this.btnSettings.Values.ExtraText = "";
            this.btnSettings.Values.Image = global::Manager.Properties.Resources.settings;
            this.btnSettings.Values.Text = "Change Settings";
            this.btnSettings.Visible = false;
            // 
            // headerPageContainer
            // 
            this.headerPageContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPageContainer.Location = new System.Drawing.Point(12, 68);
            this.headerPageContainer.Name = "headerPageContainer";
            // 
            // headerPageContainer.Panel
            // 
            this.headerPageContainer.Panel.Controls.Add(this.pnlSpatialQuery);
            this.headerPageContainer.Panel.Controls.Add(this.pnlUsers);
            this.headerPageContainer.Panel.Controls.Add(this.pnlTextualQuery);
            this.headerPageContainer.Panel.Controls.Add(this.pnlSettings);
            this.headerPageContainer.Panel.Controls.Add(this.pnlReports);
            this.headerPageContainer.Size = new System.Drawing.Size(1069, 661);
            this.headerPageContainer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.headerPageContainer.StateCommon.Border.Rounding = 5;
            this.headerPageContainer.TabIndex = 12;
            this.headerPageContainer.Text = "Spatial Query";
            this.headerPageContainer.ValuesPrimary.Description = "";
            this.headerPageContainer.ValuesPrimary.Heading = "Spatial Query";
            this.headerPageContainer.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("headerPageContainer.ValuesPrimary.Image")));
            this.headerPageContainer.ValuesSecondary.Description = "";
            this.headerPageContainer.ValuesSecondary.Heading = "Description";
            this.headerPageContainer.ValuesSecondary.Image = null;
            // 
            // pnlSpatialQuery
            // 
            this.pnlSpatialQuery.Controls.Add(this.tblMainContainer);
            this.pnlSpatialQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpatialQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlSpatialQuery.Name = "pnlSpatialQuery";
            this.pnlSpatialQuery.Size = new System.Drawing.Size(1067, 608);
            this.pnlSpatialQuery.TabIndex = 9;
            // 
            // tblMainContainer
            // 
            this.tblMainContainer.BackColor = System.Drawing.Color.Transparent;
            this.tblMainContainer.ColumnCount = 3;
            this.tblMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tblMainContainer.Controls.Add(this.pnlSpatialMap, 1, 0);
            this.tblMainContainer.Controls.Add(this.tblLeftPane, 0, 0);
            this.tblMainContainer.Controls.Add(this.kryptonPanel1, 2, 0);
            this.tblMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tblMainContainer.Name = "tblMainContainer";
            this.tblMainContainer.RowCount = 1;
            this.tblMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainContainer.Size = new System.Drawing.Size(1067, 608);
            this.tblMainContainer.TabIndex = 0;
            // 
            // pnlSpatialMap
            // 
            this.pnlSpatialMap.Controls.Add(this.mapControl);
            this.pnlSpatialMap.Controls.Add(this.splitter1);
            this.pnlSpatialMap.Controls.Add(this.dgSelection);
            this.pnlSpatialMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSpatialMap.Location = new System.Drawing.Point(170, 3);
            this.pnlSpatialMap.Name = "pnlSpatialMap";
            this.pnlSpatialMap.Size = new System.Drawing.Size(894, 602);
            this.pnlSpatialMap.TabIndex = 25;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Enabled = true;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(894, 505);
            this.mapControl.TabIndex = 26;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 505);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(894, 3);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // dgSelection
            // 
            this.dgSelection.AllowUserToAddRows = false;
            this.dgSelection.AllowUserToDeleteRows = false;
            this.dgSelection.AllowUserToResizeRows = false;
            this.dgSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dgSelection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSelection.Location = new System.Drawing.Point(0, 508);
            this.dgSelection.MultiSelect = false;
            this.dgSelection.Name = "dgSelection";
            this.dgSelection.ReadOnly = true;
            this.dgSelection.RowHeadersVisible = false;
            this.dgSelection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelection.Size = new System.Drawing.Size(894, 94);
            this.dgSelection.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgSelection.TabIndex = 0;
            this.dgSelection.Visible = false;
            this.dgSelection.SelectionChanged += new System.EventHandler(this.dgSelection_SelectionChanged);
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Visible = false;
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Visible = false;
            // 
            // tblLeftPane
            // 
            this.tblLeftPane.ColumnCount = 1;
            this.tblLeftPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLeftPane.Controls.Add(this.pnlSelection, 0, 3);
            this.tblLeftPane.Controls.Add(this.flowFilter, 0, 1);
            this.tblLeftPane.Controls.Add(this.lblFilter, 0, 0);
            this.tblLeftPane.Controls.Add(this.lblSelection, 0, 2);
            this.tblLeftPane.Controls.Add(this.lblProjection, 0, 4);
            this.tblLeftPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLeftPane.Location = new System.Drawing.Point(3, 3);
            this.tblLeftPane.Name = "tblLeftPane";
            this.tblLeftPane.RowCount = 5;
            this.tblLeftPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeftPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeftPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeftPane.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLeftPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLeftPane.Size = new System.Drawing.Size(161, 602);
            this.tblLeftPane.TabIndex = 20;
            // 
            // pnlSelection
            // 
            this.pnlSelection.Controls.Add(this.chkExportEntireDrawing);
            this.pnlSelection.Controls.Add(this.lnkExportToExcel);
            this.pnlSelection.Controls.Add(this.lnkExportToShape);
            this.pnlSelection.Controls.Add(this.btnSelectGap);
            this.pnlSelection.Controls.Add(this.btnSelectAreaError);
            this.pnlSelection.Controls.Add(this.btnSelectNone);
            this.pnlSelection.Controls.Add(this.btnSelectOverlapping);
            this.pnlSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSelection.Location = new System.Drawing.Point(3, 355);
            this.pnlSelection.Name = "pnlSelection";
            this.pnlSelection.Size = new System.Drawing.Size(155, 248);
            this.pnlSelection.TabIndex = 21;
            // 
            // chkExportEntireDrawing
            // 
            this.chkExportEntireDrawing.Location = new System.Drawing.Point(55, 170);
            this.chkExportEntireDrawing.Name = "chkExportEntireDrawing";
            this.chkExportEntireDrawing.Size = new System.Drawing.Size(102, 20);
            this.chkExportEntireDrawing.TabIndex = 6;
            this.chkExportEntireDrawing.Text = "entire drawing";
            this.chkExportEntireDrawing.Values.ExtraText = "";
            this.chkExportEntireDrawing.Values.Image = null;
            this.chkExportEntireDrawing.Values.Text = "entire drawing";
            // 
            // lnkExportToExcel
            // 
            this.lnkExportToExcel.Location = new System.Drawing.Point(46, 199);
            this.lnkExportToExcel.Name = "lnkExportToExcel";
            this.lnkExportToExcel.Size = new System.Drawing.Size(80, 20);
            this.lnkExportToExcel.TabIndex = 5;
            this.lnkExportToExcel.Text = "Export to .xls";
            this.lnkExportToExcel.Values.ExtraText = "";
            this.lnkExportToExcel.Values.Image = null;
            this.lnkExportToExcel.Values.Text = "Export to .xls";
            this.lnkExportToExcel.LinkClicked += new System.EventHandler(this.lnkExportToExcel_LinkClicked);
            // 
            // lnkExportToShape
            // 
            this.lnkExportToShape.Location = new System.Drawing.Point(41, 151);
            this.lnkExportToShape.Name = "lnkExportToShape";
            this.lnkExportToShape.Size = new System.Drawing.Size(86, 20);
            this.lnkExportToShape.TabIndex = 4;
            this.lnkExportToShape.Text = "Export to .shp";
            this.lnkExportToShape.Values.ExtraText = "";
            this.lnkExportToShape.Values.Image = null;
            this.lnkExportToShape.Values.Text = "Export to .shp";
            this.lnkExportToShape.LinkClicked += new System.EventHandler(this.lnkExportToShape_LinkClicked);
            // 
            // btnSelectGap
            // 
            this.btnSelectGap.Location = new System.Drawing.Point(35, 65);
            this.btnSelectGap.Name = "btnSelectGap";
            this.btnSelectGap.Size = new System.Drawing.Size(90, 25);
            this.btnSelectGap.TabIndex = 2;
            this.btnSelectGap.Text = "Lots with Gap";
            this.btnSelectGap.Values.ExtraText = "";
            this.btnSelectGap.Values.Image = null;
            this.btnSelectGap.Values.Text = "Lots with Gap";
            this.btnSelectGap.Click += new System.EventHandler(this.btnSelectGap_Click);
            // 
            // btnSelectAreaError
            // 
            this.btnSelectAreaError.Location = new System.Drawing.Point(35, 96);
            this.btnSelectAreaError.Name = "btnSelectAreaError";
            this.btnSelectAreaError.Size = new System.Drawing.Size(90, 25);
            this.btnSelectAreaError.TabIndex = 3;
            this.btnSelectAreaError.Text = "Area error";
            this.btnSelectAreaError.Values.ExtraText = "";
            this.btnSelectAreaError.Values.Image = null;
            this.btnSelectAreaError.Values.Text = "Area error";
            this.btnSelectAreaError.Click += new System.EventHandler(this.btnSelectAreaError_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Checked = true;
            this.btnSelectNone.Location = new System.Drawing.Point(35, 3);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(90, 25);
            this.btnSelectNone.TabIndex = 0;
            this.btnSelectNone.Text = "Select none";
            this.btnSelectNone.Values.ExtraText = "";
            this.btnSelectNone.Values.Image = null;
            this.btnSelectNone.Values.Text = "Select none";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectOverlapping
            // 
            this.btnSelectOverlapping.Location = new System.Drawing.Point(35, 34);
            this.btnSelectOverlapping.Name = "btnSelectOverlapping";
            this.btnSelectOverlapping.Size = new System.Drawing.Size(90, 25);
            this.btnSelectOverlapping.TabIndex = 1;
            this.btnSelectOverlapping.Text = "Overlapping";
            this.btnSelectOverlapping.Values.ExtraText = "";
            this.btnSelectOverlapping.Values.Image = null;
            this.btnSelectOverlapping.Values.Text = "Overlapping";
            this.btnSelectOverlapping.Click += new System.EventHandler(this.btnSelectOverlapping_Click);
            // 
            // flowFilter
            // 
            this.flowFilter.BackColor = System.Drawing.Color.Transparent;
            this.flowFilter.Controls.Add(this.cmbRegion);
            this.flowFilter.Controls.Add(this.cmbProvince);
            this.flowFilter.Controls.Add(this.cmbCadSurvey);
            this.flowFilter.Controls.Add(this.cmbMunicipality);
            this.flowFilter.Controls.Add(this.cmbCase);
            this.flowFilter.Controls.Add(this.cmbBarangay);
            this.flowFilter.Controls.Add(this.cmbQuadrangle);
            this.flowFilter.Controls.Add(this.cmbSection);
            this.flowFilter.Controls.Add(this.pnlFilterStatus);
            this.flowFilter.Location = new System.Drawing.Point(3, 38);
            this.flowFilter.Name = "flowFilter";
            this.flowFilter.Size = new System.Drawing.Size(152, 276);
            this.flowFilter.TabIndex = 19;
            // 
            // cmbRegion
            // 
            this.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegion.DropDownWidth = 200;
            this.cmbRegion.FormattingEnabled = false;
            this.cmbRegion.Location = new System.Drawing.Point(3, 3);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(147, 21);
            this.cmbRegion.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRegion.TabIndex = 1;
            this.cmbRegion.SelectedValueChanged += new System.EventHandler(this.cmbRegion_SelectedValueChanged);
            // 
            // cmbProvince
            // 
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.DropDownWidth = 200;
            this.cmbProvince.FormattingEnabled = false;
            this.cmbProvince.Location = new System.Drawing.Point(3, 30);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(147, 21);
            this.cmbProvince.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvince.TabIndex = 2;
            this.cmbProvince.SelectedValueChanged += new System.EventHandler(this.cmbProvince_SelectedValueChanged);
            // 
            // cmbCadSurvey
            // 
            this.cmbCadSurvey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadSurvey.DropDownWidth = 200;
            this.cmbCadSurvey.FormattingEnabled = false;
            this.cmbCadSurvey.Location = new System.Drawing.Point(3, 57);
            this.cmbCadSurvey.Name = "cmbCadSurvey";
            this.cmbCadSurvey.Size = new System.Drawing.Size(147, 21);
            this.cmbCadSurvey.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCadSurvey.TabIndex = 3;
            this.cmbCadSurvey.SelectedValueChanged += new System.EventHandler(this.cmbCadSurvey_SelectedValueChanged);
            // 
            // cmbMunicipality
            // 
            this.cmbMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipality.DropDownWidth = 200;
            this.cmbMunicipality.FormattingEnabled = false;
            this.cmbMunicipality.Location = new System.Drawing.Point(3, 84);
            this.cmbMunicipality.Name = "cmbMunicipality";
            this.cmbMunicipality.Size = new System.Drawing.Size(147, 21);
            this.cmbMunicipality.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipality.TabIndex = 4;
            this.cmbMunicipality.SelectedValueChanged += new System.EventHandler(this.cmbMunicipality_SelectedValueChanged);
            // 
            // cmbCase
            // 
            this.cmbCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCase.DropDownWidth = 200;
            this.cmbCase.FormattingEnabled = false;
            this.cmbCase.Location = new System.Drawing.Point(3, 111);
            this.cmbCase.Name = "cmbCase";
            this.cmbCase.Size = new System.Drawing.Size(147, 21);
            this.cmbCase.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCase.TabIndex = 5;
            this.cmbCase.SelectedValueChanged += new System.EventHandler(this.cmbCase_SelectedValueChanged);
            // 
            // cmbBarangay
            // 
            this.cmbBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarangay.DropDownWidth = 200;
            this.cmbBarangay.FormattingEnabled = false;
            this.cmbBarangay.Location = new System.Drawing.Point(3, 138);
            this.cmbBarangay.Name = "cmbBarangay";
            this.cmbBarangay.Size = new System.Drawing.Size(147, 21);
            this.cmbBarangay.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarangay.TabIndex = 6;
            this.cmbBarangay.SelectedValueChanged += new System.EventHandler(this.cmbBarangay_SelectedValueChanged);
            // 
            // cmbQuadrangle
            // 
            this.cmbQuadrangle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuadrangle.DropDownWidth = 200;
            this.cmbQuadrangle.FormattingEnabled = false;
            this.cmbQuadrangle.Location = new System.Drawing.Point(3, 165);
            this.cmbQuadrangle.Name = "cmbQuadrangle";
            this.cmbQuadrangle.Size = new System.Drawing.Size(147, 21);
            this.cmbQuadrangle.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuadrangle.TabIndex = 7;
            this.cmbQuadrangle.SelectedValueChanged += new System.EventHandler(this.cmbQuadrangle_SelectedValueChanged);
            // 
            // cmbSection
            // 
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.DropDownWidth = 200;
            this.cmbSection.FormattingEnabled = false;
            this.cmbSection.Location = new System.Drawing.Point(3, 192);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(147, 21);
            this.cmbSection.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.TabIndex = 8;
            // 
            // pnlFilterStatus
            // 
            this.pnlFilterStatus.Controls.Add(this.pbrAsyc);
            this.pnlFilterStatus.Controls.Add(this.btnFilter);
            this.pnlFilterStatus.Controls.Add(this.btnCancel);
            this.pnlFilterStatus.Location = new System.Drawing.Point(3, 219);
            this.pnlFilterStatus.Name = "pnlFilterStatus";
            this.pnlFilterStatus.Size = new System.Drawing.Size(147, 52);
            this.pnlFilterStatus.TabIndex = 18;
            // 
            // pbrAsyc
            // 
            this.pbrAsyc.Location = new System.Drawing.Point(3, 3);
            this.pbrAsyc.Name = "pbrAsyc";
            this.pbrAsyc.Size = new System.Drawing.Size(144, 12);
            this.pbrAsyc.TabIndex = 4;
            this.pbrAsyc.Visible = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(32, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(90, 25);
            this.btnFilter.TabIndex = 7;
            this.btnFilter.Text = "Apply";
            this.btnFilter.Values.ExtraText = "";
            this.btnFilter.Values.Image = null;
            this.btnFilter.Values.ImageStates.ImageCheckedNormal = null;
            this.btnFilter.Values.ImageStates.ImageCheckedPressed = null;
            this.btnFilter.Values.ImageStates.ImageCheckedTracking = null;
            this.btnFilter.Values.Text = "Apply";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Values.ExtraText = "";
            this.btnCancel.Values.Image = null;
            this.btnCancel.Values.ImageStates.ImageCheckedNormal = null;
            this.btnCancel.Values.ImageStates.ImageCheckedPressed = null;
            this.btnCancel.Values.ImageStates.ImageCheckedTracking = null;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblFilter.Location = new System.Drawing.Point(3, 3);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 29);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter";
            this.lblFilter.Values.ExtraText = "";
            this.lblFilter.Values.Image = null;
            this.lblFilter.Values.Text = "Filter";
            // 
            // lblSelection
            // 
            this.lblSelection.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblSelection.Location = new System.Drawing.Point(3, 320);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(92, 29);
            this.lblSelection.TabIndex = 20;
            this.lblSelection.Text = "Selection";
            this.lblSelection.Values.ExtraText = "";
            this.lblSelection.Values.Image = null;
            this.lblSelection.Values.Text = "Selection";
            // 
            // lblProjection
            // 
            this.lblProjection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProjection.Location = new System.Drawing.Point(3, 609);
            this.lblProjection.Name = "lblProjection";
            this.lblProjection.Size = new System.Drawing.Size(155, 14);
            this.lblProjection.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblProjection.TabIndex = 22;
            this.lblProjection.Text = "Projection: PTM";
            this.lblProjection.Values.ExtraText = "";
            this.lblProjection.Values.Image = null;
            this.lblProjection.Values.Text = "Projection: PTM";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Location = new System.Drawing.Point(1070, 3);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1, 492);
            this.kryptonPanel1.TabIndex = 21;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.kryptonPanel2);
            this.pnlUsers.Controls.Add(this.btnSaveUser);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1067, 608);
            this.pnlUsers.TabIndex = 11;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.dgUsers);
            this.kryptonPanel2.Location = new System.Drawing.Point(25, 59);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(445, 214);
            this.kryptonPanel2.TabIndex = 2;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToResizeRows = false;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colPassword,
            this.colAccess});
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.Location = new System.Drawing.Point(0, 0);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 25;
            this.dgUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgUsers.Size = new System.Drawing.Size(445, 214);
            this.dgUsers.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgUsers.TabIndex = 0;
            // 
            // colUsername
            // 
            this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colUsername.DataPropertyName = "Username";
            this.colUsername.FillWeight = 189.6907F;
            this.colUsername.HeaderText = "User name";
            this.colUsername.Name = "colUsername";
            // 
            // colPassword
            // 
            this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPassword.DataPropertyName = "Password";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.colPassword.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPassword.FillWeight = 10.30928F;
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            // 
            // colAccess
            // 
            this.colAccess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAccess.DataPropertyName = "Access";
            this.colAccess.HeaderText = "Access level";
            this.colAccess.Name = "colAccess";
            this.colAccess.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(25, 28);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(90, 25);
            this.btnSaveUser.TabIndex = 1;
            this.btnSaveUser.Text = "&Save";
            this.btnSaveUser.Values.ExtraText = "";
            this.btnSaveUser.Values.Image = null;
            this.btnSaveUser.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSaveUser.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSaveUser.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSaveUser.Values.Text = "&Save";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pnlTextualQuery
            // 
            this.pnlTextualQuery.Controls.Add(this.tblTextualQuery);
            this.pnlTextualQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextualQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlTextualQuery.Name = "pnlTextualQuery";
            this.pnlTextualQuery.Size = new System.Drawing.Size(1067, 608);
            this.pnlTextualQuery.TabIndex = 12;
            // 
            // tblTextualQuery
            // 
            this.tblTextualQuery.BackColor = System.Drawing.Color.Transparent;
            this.tblTextualQuery.ColumnCount = 1;
            this.tblTextualQuery.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTextualQuery.Controls.Add(this.pnlTextualQueryResult, 0, 1);
            this.tblTextualQuery.Controls.Add(this.pnlTextualQueryOptions, 0, 0);
            this.tblTextualQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTextualQuery.Location = new System.Drawing.Point(0, 0);
            this.tblTextualQuery.Name = "tblTextualQuery";
            this.tblTextualQuery.RowCount = 2;
            this.tblTextualQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblTextualQuery.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTextualQuery.Size = new System.Drawing.Size(1067, 608);
            this.tblTextualQuery.TabIndex = 2;
            // 
            // pnlTextualQueryResult
            // 
            this.pnlTextualQueryResult.Controls.Add(this.grdTextualQuery);
            this.pnlTextualQueryResult.Controls.Add(this.lblTextualQueryResult);
            this.pnlTextualQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextualQueryResult.Location = new System.Drawing.Point(3, 203);
            this.pnlTextualQueryResult.Name = "pnlTextualQueryResult";
            this.pnlTextualQueryResult.Size = new System.Drawing.Size(1061, 402);
            this.pnlTextualQueryResult.TabIndex = 1;
            // 
            // grdTextualQuery
            // 
            this.grdTextualQuery.AllowUserToAddRows = false;
            this.grdTextualQuery.AllowUserToDeleteRows = false;
            this.grdTextualQuery.AllowUserToResizeRows = false;
            this.grdTextualQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTextualQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTextualQuery.Location = new System.Drawing.Point(0, 29);
            this.grdTextualQuery.Name = "grdTextualQuery";
            this.grdTextualQuery.RowHeadersVisible = false;
            this.grdTextualQuery.RowHeadersWidth = 20;
            this.grdTextualQuery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdTextualQuery.Size = new System.Drawing.Size(1061, 373);
            this.grdTextualQuery.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.grdTextualQuery.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.grdTextualQuery.TabIndex = 1;
            // 
            // lblTextualQueryResult
            // 
            this.lblTextualQueryResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextualQueryResult.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblTextualQueryResult.Location = new System.Drawing.Point(0, 0);
            this.lblTextualQueryResult.Name = "lblTextualQueryResult";
            this.lblTextualQueryResult.Size = new System.Drawing.Size(1061, 29);
            this.lblTextualQueryResult.TabIndex = 13;
            this.lblTextualQueryResult.Text = "Result";
            this.lblTextualQueryResult.Values.ExtraText = "";
            this.lblTextualQueryResult.Values.Image = null;
            this.lblTextualQueryResult.Values.Text = "Result";
            // 
            // pnlTextualQueryOptions
            // 
            this.pnlTextualQueryOptions.Controls.Add(this.cbxSelectAll);
            this.pnlTextualQueryOptions.Controls.Add(this.lblTextualQueryOptions);
            this.pnlTextualQueryOptions.Controls.Add(this.kryptonLabel3);
            this.pnlTextualQueryOptions.Controls.Add(this.kryptonLabel1);
            this.pnlTextualQueryOptions.Controls.Add(this.kryptonLabel2);
            this.pnlTextualQueryOptions.Controls.Add(this.lbxTextualQueryColumns);
            this.pnlTextualQueryOptions.Controls.Add(this.btnExecute);
            this.pnlTextualQueryOptions.Controls.Add(this.dgCriteria);
            this.pnlTextualQueryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextualQueryOptions.Location = new System.Drawing.Point(3, 3);
            this.pnlTextualQueryOptions.Name = "pnlTextualQueryOptions";
            this.pnlTextualQueryOptions.Size = new System.Drawing.Size(1061, 194);
            this.pnlTextualQueryOptions.TabIndex = 0;
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.Location = new System.Drawing.Point(14, 172);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(73, 20);
            this.cbxSelectAll.TabIndex = 13;
            this.cbxSelectAll.Text = "Select All";
            this.cbxSelectAll.Values.ExtraText = "";
            this.cbxSelectAll.Values.Image = null;
            this.cbxSelectAll.Values.Text = "Select All";
            this.cbxSelectAll.CheckedChanged += new System.EventHandler(this.cbxSelectAll_CheckedChanged);
            // 
            // lblTextualQueryOptions
            // 
            this.lblTextualQueryOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTextualQueryOptions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.lblTextualQueryOptions.Location = new System.Drawing.Point(0, 0);
            this.lblTextualQueryOptions.Name = "lblTextualQueryOptions";
            this.lblTextualQueryOptions.Size = new System.Drawing.Size(1061, 29);
            this.lblTextualQueryOptions.TabIndex = 12;
            this.lblTextualQueryOptions.Text = "Options";
            this.lblTextualQueryOptions.Values.ExtraText = "";
            this.lblTextualQueryOptions.Values.Image = null;
            this.lblTextualQueryOptions.Values.Text = "Options";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(686, 46);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Text = "STEP 3.     Execute";
            this.kryptonLabel3.Values.ExtraText = "";
            this.kryptonLabel3.Values.Image = null;
            this.kryptonLabel3.Values.Text = "STEP 3.     Execute";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(222, 49);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(145, 20);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Text = "STEP 2.     Set the criteria";
            this.kryptonLabel1.Values.ExtraText = "";
            this.kryptonLabel1.Values.Image = null;
            this.kryptonLabel1.Values.Text = "STEP 2.     Set the criteria";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 49);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(148, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Text = "STEP 1.     Select columns";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "STEP 1.     Select columns";
            // 
            // lbxTextualQueryColumns
            // 
            this.lbxTextualQueryColumns.CheckOnClick = true;
            this.lbxTextualQueryColumns.Location = new System.Drawing.Point(9, 68);
            this.lbxTextualQueryColumns.Name = "lbxTextualQueryColumns";
            this.lbxTextualQueryColumns.Padding = new System.Windows.Forms.Padding(5);
            this.lbxTextualQueryColumns.Size = new System.Drawing.Size(196, 105);
            this.lbxTextualQueryColumns.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(696, 93);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(90, 25);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.Values.ExtraText = "";
            this.btnExecute.Values.Image = null;
            this.btnExecute.Values.ImageStates.ImageCheckedNormal = null;
            this.btnExecute.Values.ImageStates.ImageCheckedPressed = null;
            this.btnExecute.Values.ImageStates.ImageCheckedTracking = null;
            this.btnExecute.Values.Text = "Execute";
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dgCriteria
            // 
            this.dgCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCriteria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColumnName,
            this.colOperator,
            this.colCriteriaValue,
            this.colAndOr});
            this.dgCriteria.ContextMenuStrip = this.contextMenuTextualQuery;
            this.dgCriteria.Location = new System.Drawing.Point(222, 68);
            this.dgCriteria.MultiSelect = false;
            this.dgCriteria.Name = "dgCriteria";
            this.dgCriteria.RowHeadersVisible = false;
            this.dgCriteria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCriteria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCriteria.Size = new System.Drawing.Size(401, 119);
            this.dgCriteria.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgCriteria.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgCriteria.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCriteria.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCriteria.TabIndex = 11;
            this.dgCriteria.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgCriteria_RowValidating);
            // 
            // colColumnName
            // 
            this.colColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colColumnName.HeaderText = "Column";
            this.colColumnName.MinimumWidth = 120;
            this.colColumnName.Name = "colColumnName";
            this.colColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colOperator
            // 
            this.colOperator.HeaderText = "Operator";
            this.colOperator.Items.AddRange(new object[] {
            "=",
            "<>",
            ">",
            "<",
            ">=",
            "<=",
            "LIKE"});
            this.colOperator.MinimumWidth = 60;
            this.colOperator.Name = "colOperator";
            this.colOperator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperator.Width = 60;
            // 
            // colCriteriaValue
            // 
            this.colCriteriaValue.HeaderText = "Value";
            this.colCriteriaValue.MinimumWidth = 100;
            this.colCriteriaValue.Name = "colCriteriaValue";
            // 
            // colAndOr
            // 
            this.colAndOr.HeaderText = "And/Or";
            this.colAndOr.Items.AddRange(new object[] {
            "",
            "AND",
            "OR"});
            this.colAndOr.MinimumWidth = 60;
            this.colAndOr.Name = "colAndOr";
            this.colAndOr.Width = 60;
            // 
            // contextMenuTextualQuery
            // 
            this.contextMenuTextualQuery.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contextMenuTextualQuery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemRemove,
            this.mnuItemClear});
            this.contextMenuTextualQuery.Name = "contextMenuTextualQuery";
            this.contextMenuTextualQuery.Size = new System.Drawing.Size(115, 48);
            this.contextMenuTextualQuery.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuTextualQuery_ItemClicked);
            // 
            // mnuItemRemove
            // 
            this.mnuItemRemove.Name = "mnuItemRemove";
            this.mnuItemRemove.Size = new System.Drawing.Size(114, 22);
            this.mnuItemRemove.Text = "Remove";
            // 
            // mnuItemClear
            // 
            this.mnuItemClear.Name = "mnuItemClear";
            this.mnuItemClear.Size = new System.Drawing.Size(114, 22);
            this.mnuItemClear.Text = "Clear";
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.kryptonButton3);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(1067, 608);
            this.pnlSettings.TabIndex = 7;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(0, 20);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton3.TabIndex = 0;
            this.kryptonButton3.Text = "sadfsadfasdf";
            this.kryptonButton3.Values.ExtraText = "";
            this.kryptonButton3.Values.Image = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedNormal = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedPressed = null;
            this.kryptonButton3.Values.ImageStates.ImageCheckedTracking = null;
            this.kryptonButton3.Values.Text = "sadfsadfasdf";
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.rptReportViewer);
            this.pnlReports.Controls.Add(this.tabControlReports);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(1067, 608);
            this.pnlReports.TabIndex = 10;
            // 
            // rptReportViewer
            // 
            this.rptReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rptReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReportViewer.Location = new System.Drawing.Point(0, 109);
            this.rptReportViewer.Name = "rptReportViewer";
            this.rptReportViewer.Padding = new System.Windows.Forms.Padding(5);
            this.rptReportViewer.Size = new System.Drawing.Size(1067, 499);
            this.rptReportViewer.TabIndex = 7;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabPageReportLotData);
            this.tabControlReports.Controls.Add(this.tabPageReportCustom1);
            this.tabControlReports.Controls.Add(this.tabPageReportEncodedPerUser);
            this.tabControlReports.Controls.Add(this.tabPageSummaryOfEncodedLots);
            this.tabControlReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlReports.Location = new System.Drawing.Point(0, 0);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1067, 109);
            this.tabControlReports.TabIndex = 6;
            this.tabControlReports.SelectedIndexChanged += new System.EventHandler(this.tabControlReports_SelectedIndexChanged);
            // 
            // tabPageReportLotData
            // 
            this.tabPageReportLotData.Controls.Add(this.btnLoadReportLotData);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataLot);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataSection);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataQuadrangle);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataBarangay);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataCase);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataMunicipality);
            this.tabPageReportLotData.Controls.Add(this.lbxReportLotDataCadSurveyNo);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataLotNo);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataSection);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataQuadrangle);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataBarangay);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataCase);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataMunicipality);
            this.tabPageReportLotData.Controls.Add(this.lblReportLotDataCadSurveyNo);
            this.tabPageReportLotData.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportLotData.Name = "tabPageReportLotData";
            this.tabPageReportLotData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportLotData.Size = new System.Drawing.Size(1059, 83);
            this.tabPageReportLotData.TabIndex = 0;
            this.tabPageReportLotData.Text = "Lot Data Report";
            this.tabPageReportLotData.UseVisualStyleBackColor = true;
            // 
            // btnLoadReportLotData
            // 
            this.btnLoadReportLotData.Location = new System.Drawing.Point(809, 29);
            this.btnLoadReportLotData.Name = "btnLoadReportLotData";
            this.btnLoadReportLotData.Size = new System.Drawing.Size(78, 40);
            this.btnLoadReportLotData.TabIndex = 2;
            this.btnLoadReportLotData.Text = "Load Report";
            this.btnLoadReportLotData.Values.ExtraText = "";
            this.btnLoadReportLotData.Values.Image = null;
            this.btnLoadReportLotData.Values.ImageStates.ImageCheckedNormal = null;
            this.btnLoadReportLotData.Values.ImageStates.ImageCheckedPressed = null;
            this.btnLoadReportLotData.Values.ImageStates.ImageCheckedTracking = null;
            this.btnLoadReportLotData.Values.Text = "Load Report";
            this.btnLoadReportLotData.Click += new System.EventHandler(this.btnLoadReportLotData_Click);
            // 
            // lbxReportLotDataLot
            // 
            this.lbxReportLotDataLot.Location = new System.Drawing.Point(703, 21);
            this.lbxReportLotDataLot.Name = "lbxReportLotDataLot";
            this.lbxReportLotDataLot.Size = new System.Drawing.Size(100, 56);
            this.lbxReportLotDataLot.TabIndex = 9;
            // 
            // lbxReportLotDataSection
            // 
            this.lbxReportLotDataSection.Location = new System.Drawing.Point(597, 21);
            this.lbxReportLotDataSection.Name = "lbxReportLotDataSection";
            this.lbxReportLotDataSection.Size = new System.Drawing.Size(100, 56);
            this.lbxReportLotDataSection.TabIndex = 8;
            // 
            // lbxReportLotDataQuadrangle
            // 
            this.lbxReportLotDataQuadrangle.Location = new System.Drawing.Point(491, 21);
            this.lbxReportLotDataQuadrangle.Name = "lbxReportLotDataQuadrangle";
            this.lbxReportLotDataQuadrangle.Size = new System.Drawing.Size(100, 56);
            this.lbxReportLotDataQuadrangle.TabIndex = 7;
            // 
            // lbxReportLotDataBarangay
            // 
            this.lbxReportLotDataBarangay.Location = new System.Drawing.Point(358, 21);
            this.lbxReportLotDataBarangay.Name = "lbxReportLotDataBarangay";
            this.lbxReportLotDataBarangay.Size = new System.Drawing.Size(127, 56);
            this.lbxReportLotDataBarangay.TabIndex = 6;
            // 
            // lbxReportLotDataCase
            // 
            this.lbxReportLotDataCase.Location = new System.Drawing.Point(272, 21);
            this.lbxReportLotDataCase.Name = "lbxReportLotDataCase";
            this.lbxReportLotDataCase.Size = new System.Drawing.Size(80, 56);
            this.lbxReportLotDataCase.TabIndex = 5;
            // 
            // lbxReportLotDataMunicipality
            // 
            this.lbxReportLotDataMunicipality.Location = new System.Drawing.Point(139, 21);
            this.lbxReportLotDataMunicipality.Name = "lbxReportLotDataMunicipality";
            this.lbxReportLotDataMunicipality.Size = new System.Drawing.Size(127, 56);
            this.lbxReportLotDataMunicipality.TabIndex = 4;
            // 
            // lbxReportLotDataCadSurveyNo
            // 
            this.lbxReportLotDataCadSurveyNo.Location = new System.Drawing.Point(6, 21);
            this.lbxReportLotDataCadSurveyNo.Name = "lbxReportLotDataCadSurveyNo";
            this.lbxReportLotDataCadSurveyNo.Size = new System.Drawing.Size(127, 56);
            this.lbxReportLotDataCadSurveyNo.TabIndex = 3;
            // 
            // lblReportLotDataLotNo
            // 
            this.lblReportLotDataLotNo.Location = new System.Drawing.Point(703, 4);
            this.lblReportLotDataLotNo.Name = "lblReportLotDataLotNo";
            this.lblReportLotDataLotNo.Size = new System.Drawing.Size(48, 20);
            this.lblReportLotDataLotNo.TabIndex = 16;
            this.lblReportLotDataLotNo.Text = "Lot No";
            this.lblReportLotDataLotNo.Values.ExtraText = "";
            this.lblReportLotDataLotNo.Values.Image = null;
            this.lblReportLotDataLotNo.Values.Text = "Lot No";
            // 
            // lblReportLotDataSection
            // 
            this.lblReportLotDataSection.Location = new System.Drawing.Point(597, 4);
            this.lblReportLotDataSection.Name = "lblReportLotDataSection";
            this.lblReportLotDataSection.Size = new System.Drawing.Size(51, 20);
            this.lblReportLotDataSection.TabIndex = 15;
            this.lblReportLotDataSection.Text = "Section";
            this.lblReportLotDataSection.Values.ExtraText = "";
            this.lblReportLotDataSection.Values.Image = null;
            this.lblReportLotDataSection.Values.Text = "Section";
            // 
            // lblReportLotDataQuadrangle
            // 
            this.lblReportLotDataQuadrangle.Location = new System.Drawing.Point(491, 4);
            this.lblReportLotDataQuadrangle.Name = "lblReportLotDataQuadrangle";
            this.lblReportLotDataQuadrangle.Size = new System.Drawing.Size(75, 20);
            this.lblReportLotDataQuadrangle.TabIndex = 14;
            this.lblReportLotDataQuadrangle.Text = "Quadrangle";
            this.lblReportLotDataQuadrangle.Values.ExtraText = "";
            this.lblReportLotDataQuadrangle.Values.Image = null;
            this.lblReportLotDataQuadrangle.Values.Text = "Quadrangle";
            // 
            // lblReportLotDataBarangay
            // 
            this.lblReportLotDataBarangay.Location = new System.Drawing.Point(358, 4);
            this.lblReportLotDataBarangay.Name = "lblReportLotDataBarangay";
            this.lblReportLotDataBarangay.Size = new System.Drawing.Size(61, 20);
            this.lblReportLotDataBarangay.TabIndex = 13;
            this.lblReportLotDataBarangay.Text = "Barangay";
            this.lblReportLotDataBarangay.Values.ExtraText = "";
            this.lblReportLotDataBarangay.Values.Image = null;
            this.lblReportLotDataBarangay.Values.Text = "Barangay";
            // 
            // lblReportLotDataCase
            // 
            this.lblReportLotDataCase.Location = new System.Drawing.Point(272, 4);
            this.lblReportLotDataCase.Name = "lblReportLotDataCase";
            this.lblReportLotDataCase.Size = new System.Drawing.Size(36, 20);
            this.lblReportLotDataCase.TabIndex = 12;
            this.lblReportLotDataCase.Text = "Case";
            this.lblReportLotDataCase.Values.ExtraText = "";
            this.lblReportLotDataCase.Values.Image = null;
            this.lblReportLotDataCase.Values.Text = "Case";
            // 
            // lblReportLotDataMunicipality
            // 
            this.lblReportLotDataMunicipality.Location = new System.Drawing.Point(139, 4);
            this.lblReportLotDataMunicipality.Name = "lblReportLotDataMunicipality";
            this.lblReportLotDataMunicipality.Size = new System.Drawing.Size(77, 20);
            this.lblReportLotDataMunicipality.TabIndex = 11;
            this.lblReportLotDataMunicipality.Text = "Municipality";
            this.lblReportLotDataMunicipality.Values.ExtraText = "";
            this.lblReportLotDataMunicipality.Values.Image = null;
            this.lblReportLotDataMunicipality.Values.Text = "Municipality";
            // 
            // lblReportLotDataCadSurveyNo
            // 
            this.lblReportLotDataCadSurveyNo.Location = new System.Drawing.Point(6, 4);
            this.lblReportLotDataCadSurveyNo.Name = "lblReportLotDataCadSurveyNo";
            this.lblReportLotDataCadSurveyNo.Size = new System.Drawing.Size(91, 20);
            this.lblReportLotDataCadSurveyNo.TabIndex = 10;
            this.lblReportLotDataCadSurveyNo.Text = "Cad Survey No";
            this.lblReportLotDataCadSurveyNo.Values.ExtraText = "";
            this.lblReportLotDataCadSurveyNo.Values.Image = null;
            this.lblReportLotDataCadSurveyNo.Values.Text = "Cad Survey No";
            // 
            // tabPageReportCustom1
            // 
            this.tabPageReportCustom1.Controls.Add(this.btnLoadReportCustom1);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Lot);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Section);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Quadrangle);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Barangay);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Case);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1Municipality);
            this.tabPageReportCustom1.Controls.Add(this.lbxReportCustom1CadSurveyNo);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1LotNo);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1Section);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1Quadrangle);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1Barangay);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1Case);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1Municipality);
            this.tabPageReportCustom1.Controls.Add(this.lblReportCustom1CadSurveyNo);
            this.tabPageReportCustom1.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportCustom1.Name = "tabPageReportCustom1";
            this.tabPageReportCustom1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportCustom1.Size = new System.Drawing.Size(1059, 83);
            this.tabPageReportCustom1.TabIndex = 1;
            this.tabPageReportCustom1.Text = "BL Form No. 700-2A";
            this.tabPageReportCustom1.UseVisualStyleBackColor = true;
            // 
            // btnLoadReportCustom1
            // 
            this.btnLoadReportCustom1.Location = new System.Drawing.Point(809, 30);
            this.btnLoadReportCustom1.Name = "btnLoadReportCustom1";
            this.btnLoadReportCustom1.Size = new System.Drawing.Size(78, 40);
            this.btnLoadReportCustom1.TabIndex = 45;
            this.btnLoadReportCustom1.Text = "Load Report";
            this.btnLoadReportCustom1.Values.ExtraText = "";
            this.btnLoadReportCustom1.Values.Image = null;
            this.btnLoadReportCustom1.Values.ImageStates.ImageCheckedNormal = null;
            this.btnLoadReportCustom1.Values.ImageStates.ImageCheckedPressed = null;
            this.btnLoadReportCustom1.Values.ImageStates.ImageCheckedTracking = null;
            this.btnLoadReportCustom1.Values.Text = "Load Report";
            this.btnLoadReportCustom1.Click += new System.EventHandler(this.btnLoadReportCustom1_Click);
            // 
            // lbxReportCustom1Lot
            // 
            this.lbxReportCustom1Lot.Location = new System.Drawing.Point(703, 21);
            this.lbxReportCustom1Lot.Name = "lbxReportCustom1Lot";
            this.lbxReportCustom1Lot.Size = new System.Drawing.Size(100, 56);
            this.lbxReportCustom1Lot.TabIndex = 37;
            // 
            // lbxReportCustom1Section
            // 
            this.lbxReportCustom1Section.Location = new System.Drawing.Point(597, 21);
            this.lbxReportCustom1Section.Name = "lbxReportCustom1Section";
            this.lbxReportCustom1Section.Size = new System.Drawing.Size(100, 56);
            this.lbxReportCustom1Section.TabIndex = 36;
            // 
            // lbxReportCustom1Quadrangle
            // 
            this.lbxReportCustom1Quadrangle.Location = new System.Drawing.Point(491, 21);
            this.lbxReportCustom1Quadrangle.Name = "lbxReportCustom1Quadrangle";
            this.lbxReportCustom1Quadrangle.Size = new System.Drawing.Size(100, 56);
            this.lbxReportCustom1Quadrangle.TabIndex = 35;
            // 
            // lbxReportCustom1Barangay
            // 
            this.lbxReportCustom1Barangay.Location = new System.Drawing.Point(358, 21);
            this.lbxReportCustom1Barangay.Name = "lbxReportCustom1Barangay";
            this.lbxReportCustom1Barangay.Size = new System.Drawing.Size(127, 56);
            this.lbxReportCustom1Barangay.TabIndex = 34;
            // 
            // lbxReportCustom1Case
            // 
            this.lbxReportCustom1Case.Location = new System.Drawing.Point(272, 21);
            this.lbxReportCustom1Case.Name = "lbxReportCustom1Case";
            this.lbxReportCustom1Case.Size = new System.Drawing.Size(80, 56);
            this.lbxReportCustom1Case.TabIndex = 33;
            // 
            // lbxReportCustom1Municipality
            // 
            this.lbxReportCustom1Municipality.Location = new System.Drawing.Point(139, 21);
            this.lbxReportCustom1Municipality.Name = "lbxReportCustom1Municipality";
            this.lbxReportCustom1Municipality.Size = new System.Drawing.Size(127, 56);
            this.lbxReportCustom1Municipality.TabIndex = 32;
            // 
            // lbxReportCustom1CadSurveyNo
            // 
            this.lbxReportCustom1CadSurveyNo.Location = new System.Drawing.Point(6, 21);
            this.lbxReportCustom1CadSurveyNo.Name = "lbxReportCustom1CadSurveyNo";
            this.lbxReportCustom1CadSurveyNo.Size = new System.Drawing.Size(127, 56);
            this.lbxReportCustom1CadSurveyNo.TabIndex = 31;
            // 
            // lblReportCustom1LotNo
            // 
            this.lblReportCustom1LotNo.Location = new System.Drawing.Point(703, 4);
            this.lblReportCustom1LotNo.Name = "lblReportCustom1LotNo";
            this.lblReportCustom1LotNo.Size = new System.Drawing.Size(48, 20);
            this.lblReportCustom1LotNo.TabIndex = 44;
            this.lblReportCustom1LotNo.Text = "Lot No";
            this.lblReportCustom1LotNo.Values.ExtraText = "";
            this.lblReportCustom1LotNo.Values.Image = null;
            this.lblReportCustom1LotNo.Values.Text = "Lot No";
            // 
            // lblReportCustom1Section
            // 
            this.lblReportCustom1Section.Location = new System.Drawing.Point(597, 4);
            this.lblReportCustom1Section.Name = "lblReportCustom1Section";
            this.lblReportCustom1Section.Size = new System.Drawing.Size(51, 20);
            this.lblReportCustom1Section.TabIndex = 43;
            this.lblReportCustom1Section.Text = "Section";
            this.lblReportCustom1Section.Values.ExtraText = "";
            this.lblReportCustom1Section.Values.Image = null;
            this.lblReportCustom1Section.Values.Text = "Section";
            // 
            // lblReportCustom1Quadrangle
            // 
            this.lblReportCustom1Quadrangle.Location = new System.Drawing.Point(491, 4);
            this.lblReportCustom1Quadrangle.Name = "lblReportCustom1Quadrangle";
            this.lblReportCustom1Quadrangle.Size = new System.Drawing.Size(75, 20);
            this.lblReportCustom1Quadrangle.TabIndex = 42;
            this.lblReportCustom1Quadrangle.Text = "Quadrangle";
            this.lblReportCustom1Quadrangle.Values.ExtraText = "";
            this.lblReportCustom1Quadrangle.Values.Image = null;
            this.lblReportCustom1Quadrangle.Values.Text = "Quadrangle";
            // 
            // lblReportCustom1Barangay
            // 
            this.lblReportCustom1Barangay.Location = new System.Drawing.Point(358, 4);
            this.lblReportCustom1Barangay.Name = "lblReportCustom1Barangay";
            this.lblReportCustom1Barangay.Size = new System.Drawing.Size(61, 20);
            this.lblReportCustom1Barangay.TabIndex = 41;
            this.lblReportCustom1Barangay.Text = "Barangay";
            this.lblReportCustom1Barangay.Values.ExtraText = "";
            this.lblReportCustom1Barangay.Values.Image = null;
            this.lblReportCustom1Barangay.Values.Text = "Barangay";
            // 
            // lblReportCustom1Case
            // 
            this.lblReportCustom1Case.Location = new System.Drawing.Point(272, 4);
            this.lblReportCustom1Case.Name = "lblReportCustom1Case";
            this.lblReportCustom1Case.Size = new System.Drawing.Size(36, 20);
            this.lblReportCustom1Case.TabIndex = 40;
            this.lblReportCustom1Case.Text = "Case";
            this.lblReportCustom1Case.Values.ExtraText = "";
            this.lblReportCustom1Case.Values.Image = null;
            this.lblReportCustom1Case.Values.Text = "Case";
            // 
            // lblReportCustom1Municipality
            // 
            this.lblReportCustom1Municipality.Location = new System.Drawing.Point(139, 4);
            this.lblReportCustom1Municipality.Name = "lblReportCustom1Municipality";
            this.lblReportCustom1Municipality.Size = new System.Drawing.Size(77, 20);
            this.lblReportCustom1Municipality.TabIndex = 39;
            this.lblReportCustom1Municipality.Text = "Municipality";
            this.lblReportCustom1Municipality.Values.ExtraText = "";
            this.lblReportCustom1Municipality.Values.Image = null;
            this.lblReportCustom1Municipality.Values.Text = "Municipality";
            // 
            // lblReportCustom1CadSurveyNo
            // 
            this.lblReportCustom1CadSurveyNo.Location = new System.Drawing.Point(6, 4);
            this.lblReportCustom1CadSurveyNo.Name = "lblReportCustom1CadSurveyNo";
            this.lblReportCustom1CadSurveyNo.Size = new System.Drawing.Size(91, 20);
            this.lblReportCustom1CadSurveyNo.TabIndex = 38;
            this.lblReportCustom1CadSurveyNo.Text = "Cad Survey No";
            this.lblReportCustom1CadSurveyNo.Values.ExtraText = "";
            this.lblReportCustom1CadSurveyNo.Values.Image = null;
            this.lblReportCustom1CadSurveyNo.Values.Text = "Cad Survey No";
            // 
            // tabPageReportEncodedPerUser
            // 
            this.tabPageReportEncodedPerUser.Controls.Add(this.dtpEndDate);
            this.tabPageReportEncodedPerUser.Controls.Add(this.lblRptEndDate);
            this.tabPageReportEncodedPerUser.Controls.Add(this.lblRptStartDate);
            this.tabPageReportEncodedPerUser.Controls.Add(this.dtpStartDate);
            this.tabPageReportEncodedPerUser.Controls.Add(this.btnRptLoadEncodedLotsPerUser);
            this.tabPageReportEncodedPerUser.Controls.Add(this.cmbRptEncodedLotsUsers);
            this.tabPageReportEncodedPerUser.Controls.Add(this.lblUser);
            this.tabPageReportEncodedPerUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageReportEncodedPerUser.Name = "tabPageReportEncodedPerUser";
            this.tabPageReportEncodedPerUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReportEncodedPerUser.Size = new System.Drawing.Size(1059, 83);
            this.tabPageReportEncodedPerUser.TabIndex = 2;
            this.tabPageReportEncodedPerUser.Text = "Encoded Lots per User";
            this.tabPageReportEncodedPerUser.UseVisualStyleBackColor = true;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(302, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(93, 22);
            this.dtpEndDate.TabIndex = 6;
            // 
            // lblRptEndDate
            // 
            this.lblRptEndDate.Location = new System.Drawing.Point(238, 53);
            this.lblRptEndDate.Name = "lblRptEndDate";
            this.lblRptEndDate.Size = new System.Drawing.Size(63, 20);
            this.lblRptEndDate.TabIndex = 5;
            this.lblRptEndDate.Text = "End Date:";
            this.lblRptEndDate.Values.ExtraText = "";
            this.lblRptEndDate.Values.Image = null;
            this.lblRptEndDate.Values.Text = "End Date:";
            // 
            // lblRptStartDate
            // 
            this.lblRptStartDate.Location = new System.Drawing.Point(54, 53);
            this.lblRptStartDate.Name = "lblRptStartDate";
            this.lblRptStartDate.Size = new System.Drawing.Size(68, 20);
            this.lblRptStartDate.TabIndex = 4;
            this.lblRptStartDate.Text = "Start Date:";
            this.lblRptStartDate.Values.ExtraText = "";
            this.lblRptStartDate.Values.Image = null;
            this.lblRptStartDate.Values.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(123, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(93, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // btnRptLoadEncodedLotsPerUser
            // 
            this.btnRptLoadEncodedLotsPerUser.Location = new System.Drawing.Point(431, 27);
            this.btnRptLoadEncodedLotsPerUser.Name = "btnRptLoadEncodedLotsPerUser";
            this.btnRptLoadEncodedLotsPerUser.Size = new System.Drawing.Size(90, 32);
            this.btnRptLoadEncodedLotsPerUser.TabIndex = 2;
            this.btnRptLoadEncodedLotsPerUser.Text = "Load";
            this.btnRptLoadEncodedLotsPerUser.Values.ExtraText = "";
            this.btnRptLoadEncodedLotsPerUser.Values.Image = null;
            this.btnRptLoadEncodedLotsPerUser.Values.ImageStates.ImageCheckedNormal = null;
            this.btnRptLoadEncodedLotsPerUser.Values.ImageStates.ImageCheckedPressed = null;
            this.btnRptLoadEncodedLotsPerUser.Values.ImageStates.ImageCheckedTracking = null;
            this.btnRptLoadEncodedLotsPerUser.Values.Text = "Load";
            this.btnRptLoadEncodedLotsPerUser.Click += new System.EventHandler(this.btnRptLoadEncodedLotsPerUser_Click);
            // 
            // cmbRptEncodedLotsUsers
            // 
            this.cmbRptEncodedLotsUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRptEncodedLotsUsers.DropDownWidth = 140;
            this.cmbRptEncodedLotsUsers.FormattingEnabled = false;
            this.cmbRptEncodedLotsUsers.Location = new System.Drawing.Point(123, 19);
            this.cmbRptEncodedLotsUsers.Name = "cmbRptEncodedLotsUsers";
            this.cmbRptEncodedLotsUsers.Size = new System.Drawing.Size(129, 21);
            this.cmbRptEncodedLotsUsers.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(76, 21);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User:";
            this.lblUser.Values.ExtraText = "";
            this.lblUser.Values.Image = null;
            this.lblUser.Values.Text = "User:";
            // 
            // tabPageSummaryOfEncodedLots
            // 
            this.tabPageSummaryOfEncodedLots.Controls.Add(this.btnRptLoadEncodedLotsSummary);
            this.tabPageSummaryOfEncodedLots.Location = new System.Drawing.Point(4, 22);
            this.tabPageSummaryOfEncodedLots.Name = "tabPageSummaryOfEncodedLots";
            this.tabPageSummaryOfEncodedLots.Size = new System.Drawing.Size(1059, 83);
            this.tabPageSummaryOfEncodedLots.TabIndex = 3;
            this.tabPageSummaryOfEncodedLots.Text = "Summary of Encoded Lots";
            this.tabPageSummaryOfEncodedLots.UseVisualStyleBackColor = true;
            // 
            // btnRptLoadEncodedLotsSummary
            // 
            this.btnRptLoadEncodedLotsSummary.Location = new System.Drawing.Point(24, 20);
            this.btnRptLoadEncodedLotsSummary.Name = "btnRptLoadEncodedLotsSummary";
            this.btnRptLoadEncodedLotsSummary.Size = new System.Drawing.Size(90, 32);
            this.btnRptLoadEncodedLotsSummary.TabIndex = 3;
            this.btnRptLoadEncodedLotsSummary.Text = "Load";
            this.btnRptLoadEncodedLotsSummary.Values.ExtraText = "";
            this.btnRptLoadEncodedLotsSummary.Values.Image = null;
            this.btnRptLoadEncodedLotsSummary.Values.ImageStates.ImageCheckedNormal = null;
            this.btnRptLoadEncodedLotsSummary.Values.ImageStates.ImageCheckedPressed = null;
            this.btnRptLoadEncodedLotsSummary.Values.ImageStates.ImageCheckedTracking = null;
            this.btnRptLoadEncodedLotsSummary.Values.Text = "Load";
            this.btnRptLoadEncodedLotsSummary.Click += new System.EventHandler(this.btnRptLoadEncodedLotsSummary_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(426, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(132, 50);
            this.btnUsers.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUsers.StateCommon.Border.Rounding = 5;
            this.btnUsers.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnUsers.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.Values.ExtraText = "";
            this.btnUsers.Values.Image = global::Manager.Properties.Resources.users;
            this.btnUsers.Values.Text = "Manage Users";
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(288, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(132, 50);
            this.btnReports.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnReports.StateCommon.Border.Rounding = 5;
            this.btnReports.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnReports.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Create Reports";
            this.btnReports.Values.ExtraText = "";
            this.btnReports.Values.Image = global::Manager.Properties.Resources.file_chart;
            this.btnReports.Values.Text = "Create Reports";
            // 
            // btnSpatialQuery
            // 
            this.btnSpatialQuery.Location = new System.Drawing.Point(12, 12);
            this.btnSpatialQuery.Name = "btnSpatialQuery";
            this.btnSpatialQuery.Size = new System.Drawing.Size(132, 50);
            this.btnSpatialQuery.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)
                        | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSpatialQuery.StateCommon.Border.Rounding = 5;
            this.btnSpatialQuery.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSpatialQuery.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSpatialQuery.TabIndex = 6;
            this.btnSpatialQuery.Text = "Spatial Query";
            this.btnSpatialQuery.Values.ExtraText = "";
            this.btnSpatialQuery.Values.Image = global::Manager.Properties.Resources.network_find;
            this.btnSpatialQuery.Values.Text = "Spatial Query";
            // 
            // contextMenuUsers
            // 
            this.contextMenuUsers.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.contextMenuUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeleteUser});
            this.contextMenuUsers.Name = "contextMenuUsers";
            this.contextMenuUsers.Size = new System.Drawing.Size(108, 26);
            this.contextMenuUsers.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuUsers_ItemClicked);
            // 
            // mnuDeleteUser
            // 
            this.mnuDeleteUser.Name = "mnuDeleteUser";
            this.mnuDeleteUser.Size = new System.Drawing.Size(107, 22);
            this.mnuDeleteUser.Text = "Delete";
            // 
            // GetSqlLotDataBW
            // 
            this.GetSqlLotDataBW.WorkerReportsProgress = true;
            this.GetSqlLotDataBW.WorkerSupportsCancellation = true;
            this.GetSqlLotDataBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetSqlLotDataBW_DoWork);
            this.GetSqlLotDataBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetSqlLotDataBW_RunWorkerCompleted);
            this.GetSqlLotDataBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.GetSqlLotDataBW_ProgressChanged);
            // 
            // checkSetNavigation
            // 
            this.checkSetNavigation.CheckButtons.Add(this.btnReports);
            this.checkSetNavigation.CheckButtons.Add(this.btnSpatialQuery);
            this.checkSetNavigation.CheckButtons.Add(this.btnUsers);
            this.checkSetNavigation.CheckButtons.Add(this.btnSettings);
            this.checkSetNavigation.CheckButtons.Add(this.btnTextualQuery);
            this.checkSetNavigation.CheckedButtonChanged += new System.EventHandler(this.checkSetNavigation_CheckedButtonChanged);
            // 
            // checkSetSelection
            // 
            this.checkSetSelection.CheckButtons.Add(this.btnSelectGap);
            this.checkSetSelection.CheckButtons.Add(this.btnSelectAreaError);
            this.checkSetSelection.CheckButtons.Add(this.btnSelectNone);
            this.checkSetSelection.CheckButtons.Add(this.btnSelectOverlapping);
            this.checkSetSelection.CheckedButton = this.btnSelectNone;
            // 
            // ExecuteQueryAsyncBW
            // 
            this.ExecuteQueryAsyncBW.WorkerReportsProgress = true;
            this.ExecuteQueryAsyncBW.WorkerSupportsCancellation = true;
            this.ExecuteQueryAsyncBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ExecuteQueryAsyncBW_DoWork);
            this.ExecuteQueryAsyncBW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ExecuteQueryAsyncBW_RunWorkerCompleted);
            this.ExecuteQueryAsyncBW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ExecuteQueryAsyncBW_ProgressChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 741);
            this.Controls.Add(this.pa);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "LSDMS Manager (Build 07.13.2010)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pa)).EndInit();
            this.pa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPageContainer.Panel)).EndInit();
            this.headerPageContainer.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPageContainer)).EndInit();
            this.headerPageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSpatialQuery)).EndInit();
            this.pnlSpatialQuery.ResumeLayout(false);
            this.tblMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSpatialMap)).EndInit();
            this.pnlSpatialMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelection)).EndInit();
            this.tblLeftPane.ResumeLayout(false);
            this.tblLeftPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSelection)).EndInit();
            this.pnlSelection.ResumeLayout(false);
            this.pnlSelection.PerformLayout();
            this.flowFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFilterStatus)).EndInit();
            this.pnlFilterStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUsers)).EndInit();
            this.pnlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQuery)).EndInit();
            this.pnlTextualQuery.ResumeLayout(false);
            this.tblTextualQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQueryResult)).EndInit();
            this.pnlTextualQueryResult.ResumeLayout(false);
            this.pnlTextualQueryResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTextualQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTextualQueryOptions)).EndInit();
            this.pnlTextualQueryOptions.ResumeLayout(false);
            this.pnlTextualQueryOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCriteria)).EndInit();
            this.contextMenuTextualQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSettings)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlReports)).EndInit();
            this.pnlReports.ResumeLayout(false);
            this.tabControlReports.ResumeLayout(false);
            this.tabPageReportLotData.ResumeLayout(false);
            this.tabPageReportLotData.PerformLayout();
            this.tabPageReportCustom1.ResumeLayout(false);
            this.tabPageReportCustom1.PerformLayout();
            this.tabPageReportEncodedPerUser.ResumeLayout(false);
            this.tabPageReportEncodedPerUser.PerformLayout();
            this.tabPageSummaryOfEncodedLots.ResumeLayout(false);
            this.contextMenuUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pa;
        private System.ComponentModel.BackgroundWorker GetSqlLotDataBW;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet checkSetNavigation;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSpatialQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnReports;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSpatialQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlReports;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup headerPageContainer;
        private System.Windows.Forms.ProgressBar pbrAsyc;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbProvince;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRegion;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCadSurvey;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbCase;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbMunicipality;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbBarangay;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbQuadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbSection;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFilterStatus;
        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSkin;
        private System.Windows.Forms.TableLayoutPanel tblMainContainer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblFilter;
        private System.Windows.Forms.TableLayoutPanel tblLeftPane;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSelection;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet checkSetSelection;
        private System.ComponentModel.BackgroundWorker ExecuteQueryAsyncBW;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblProjection;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnTextualQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlTextualQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSelection;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSelectGap;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSelectAreaError;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSelectNone;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSelectOverlapping;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExecute;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView grdTextualQuery;
        private System.Windows.Forms.TableLayoutPanel tblTextualQuery;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlTextualQueryOptions;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckedListBox lbxTextualQueryColumns;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgCriteria;
        private System.Windows.Forms.ContextMenuStrip contextMenuTextualQuery;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuItemClear;
        private System.Windows.Forms.DataGridViewComboBoxColumn colColumnName;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCriteriaValue;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAndOr;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTextualQueryOptions;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlTextualQueryResult;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblTextualQueryResult;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox cbxSelectAll;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSaveUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteUser;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadReportLotData;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataCadSurveyNo;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataMunicipality;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataQuadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataBarangay;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataCase;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataSection;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportLotDataLot;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlSpatialMap;
        private AxManifold.Interop.AxComponentControl mapControl;
        private System.Windows.Forms.Splitter splitter1;
        private Microsoft.Reporting.WinForms.ReportViewer rptReportViewer;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabPageReportLotData;
        private System.Windows.Forms.TabPage tabPageReportCustom1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataCadSurveyNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataMunicipality;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataCase;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataBarangay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataQuadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataSection;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportLotDataLotNo;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Lot;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Section;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Quadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Barangay;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Case;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1Municipality;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox lbxReportCustom1CadSurveyNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1LotNo;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1Section;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1Quadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1Barangay;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1Case;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1Municipality;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblReportCustom1CadSurveyNo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLoadReportCustom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAccess;
        private System.Windows.Forms.TabPage tabPageReportEncodedPerUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUser;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbRptEncodedLotsUsers;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRptLoadEncodedLotsPerUser;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRptStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblRptEndDate;
        private System.Windows.Forms.TabPage tabPageSummaryOfEncodedLots;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRptLoadEncodedLotsSummary;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkExportToShape;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkExportToExcel;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chkExportEntireDrawing;
    }
}

