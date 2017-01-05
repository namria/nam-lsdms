namespace LSDMS
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
            System.Windows.Forms.Label tieLineDistanceLabel;
            System.Windows.Forms.Label lotNoLabel;
            System.Windows.Forms.Label tieLineMinuteLabel;
            System.Windows.Forms.Label tieLineDegreeLabel;
            System.Windows.Forms.Label claimantNameLabel;
            System.Windows.Forms.Label tieLineEWLabel;
            System.Windows.Forms.Label tieLineNSLabel;
            System.Windows.Forms.Label computedAreaLabel;
            System.Windows.Forms.Label claimantAddressLabel;
            System.Windows.Forms.Label originalCompletedDateLabel;
            System.Windows.Forms.Label originalCompletedByLabel;
            System.Windows.Forms.Label finalCheckedBy2Label;
            System.Windows.Forms.Label finalCheckedBy1Label;
            System.Windows.Forms.Label declaredAreaLabel;
            System.Windows.Forms.Label originalCheckedDateLabel;
            System.Windows.Forms.Label finalVerifiedByLabel;
            System.Windows.Forms.Label duplicateCheckedDateLabel;
            System.Windows.Forms.Label originalCheckedByLabel;
            System.Windows.Forms.Label duplicateCheckedByLabel;
            System.Windows.Forms.Label referencePointLabel;
            System.Windows.Forms.Label scaleLabel;
            System.Windows.Forms.Label sectionIdLabel;
            System.Windows.Forms.Label barangayPsgcLabel;
            System.Windows.Forms.Label moduleNoLabel;
            System.Windows.Forms.Label cadCaseNoLabel;
            System.Windows.Forms.Label municipalityPsgcLabel;
            System.Windows.Forms.Label coordinateSystemLabel;
            System.Windows.Forms.Label provincePsgcLabel;
            System.Windows.Forms.Label surveySymbolNoLabel;
            System.Windows.Forms.Label regionPsgcLabel;
            System.Windows.Forms.Label previousSurveyNoLabel;
            System.Windows.Forms.Label islandLabel;
            System.Windows.Forms.Label approvedTotalMunicipalityLabel;
            System.Windows.Forms.Label approvedTotalCityLabel;
            System.Windows.Forms.Label approvedTotalBarangayLabel;
            System.Windows.Forms.Label approvedTotalLotLabel;
            System.Windows.Forms.Label approvedTotalAreaHectaresLabel;
            System.Windows.Forms.Label approvalRemarksLabel;
            System.Windows.Forms.Label cadSurveyNoLabel;
            System.Windows.Forms.Label lrcNoLabel;
            System.Windows.Forms.Label quadrangleLabel;
            System.Windows.Forms.Label surveyDateFromLabel;
            System.Windows.Forms.Label lblMonth;
            System.Windows.Forms.Label lblDay;
            System.Windows.Forms.Label lblYear;
            System.Windows.Forms.Label surveyDateToLabel;
            System.Windows.Forms.Label geName2Label;
            System.Windows.Forms.Label quadrangleFormatLabel;
            System.Windows.Forms.Label sectionFormatLabel;
            System.Windows.Forms.Label lblEncoder;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.mainSplitContainer = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.tableLayoutPanelNav = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxQuadrangle = new System.Windows.Forms.ListBox();
            this.quadrangleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.caseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadSurveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lsdmsDataSet = new LSDMS.lsdmsDataSet();
            this.btnQuadrangleNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnMunicipalityNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.listBoxLot = new System.Windows.Forms.ListBox();
            this.lotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxSection = new System.Windows.Forms.ListBox();
            this.listBoxBarangay = new System.Windows.Forms.ListBox();
            this.listBoxCase = new System.Windows.Forms.ListBox();
            this.listBoxMunicipality = new System.Windows.Forms.ListBox();
            this.btnCaseNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnBarangayNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnSectionNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnLotNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnCadSurveyNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.panelCadSurveyNav = new System.Windows.Forms.Panel();
            this.listBoxCadSurvey = new System.Windows.Forms.ListBox();
            this.cadSurveyNoSearchTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSearchBoxClear = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.dataEntryHeaderGroup = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCadSurvey = new System.Windows.Forms.TabPage();
            this.cadSurveyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.cadSurveyCountItem = new System.Windows.Forms.ToolStripLabel();
            this.cadSurveyMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveyMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadSurveyPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.cadSurveySeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadSurveyMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveyMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveySeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cadSurveyAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveyDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveySaveItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveyCancelItem = new System.Windows.Forms.ToolStripButton();
            this.cadSurveySeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cadSurveyMergeItem = new System.Windows.Forms.ToolStripButton();
            this.panelCadSurvey = new System.Windows.Forms.Panel();
            this.regionPsgcErrorLabel = new System.Windows.Forms.Label();
            this.provincePsgcErrorLabel = new System.Windows.Forms.Label();
            this.approvalRemarksTextBox = new System.Windows.Forms.TextBox();
            this.approvedTotalAreaHectaresTextBox = new System.Windows.Forms.TextBox();
            this.regionPsgcComboBox = new System.Windows.Forms.ComboBox();
            this.approvedTotalLotTextBox = new System.Windows.Forms.TextBox();
            this.provincePsgcComboBox = new System.Windows.Forms.ComboBox();
            this.approvedTotalBarangayTextBox = new System.Windows.Forms.TextBox();
            this.cadSurveyNoTextBox = new System.Windows.Forms.TextBox();
            this.approvedTotalCityTextBox = new System.Windows.Forms.TextBox();
            this.approvedTotalMunicipalityTextBox = new System.Windows.Forms.TextBox();
            this.previousSurveyNoTextBox = new System.Windows.Forms.TextBox();
            this.islandTextBox = new System.Windows.Forms.TextBox();
            this.surveySymbolNoTextBox = new System.Windows.Forms.TextBox();
            this.coordinateSystemTextBox = new System.Windows.Forms.TextBox();
            this.tabPageMunicipality = new System.Windows.Forms.TabPage();
            this.panelMunicipality = new System.Windows.Forms.Panel();
            this.municipalityPsgcErrorLabel = new System.Windows.Forms.Label();
            this.municipalityPsgcListBox = new System.Windows.Forms.ListBox();
            this.municipalityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.municipalityCountItem = new System.Windows.Forms.ToolStripLabel();
            this.municipalityMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.municipalityMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.municipalitySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.municipalityPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.municipalitySeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.municipalityMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.municipalityMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.municipalitySeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.municipalityAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.municipalityDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.municipalitySaveItem = new System.Windows.Forms.ToolStripButton();
            this.municipalityCancelItem = new System.Windows.Forms.ToolStripButton();
            this.municipalitySeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.municipalityMergeItem = new System.Windows.Forms.ToolStripButton();
            this.municipalityChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageCase = new System.Windows.Forms.TabPage();
            this.panelCase = new System.Windows.Forms.Panel();
            this.moduleNoTextBox = new System.Windows.Forms.TextBox();
            this.cadCaseNoTextBox = new System.Windows.Forms.TextBox();
            this.caseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.caseCountItem = new System.Windows.Forms.ToolStripLabel();
            this.caseMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.caseMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.caseSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.casePositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.caseSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.caseMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.caseMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.caseSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.caseAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.caseDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.caseSaveItem = new System.Windows.Forms.ToolStripButton();
            this.caseCancelItem = new System.Windows.Forms.ToolStripButton();
            this.caseSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.caseMergeItem = new System.Windows.Forms.ToolStripButton();
            this.caseChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageBarangay = new System.Windows.Forms.TabPage();
            this.panelBarangay = new System.Windows.Forms.Panel();
            this.barangayPsgcErrorLabel = new System.Windows.Forms.Label();
            this.barangayPsgcListBox = new System.Windows.Forms.ListBox();
            this.barangayPsgcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipalityPsgcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincePsgcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionPsgcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.psgc = new LSDMS.Psgc();
            this.barangayBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.barangayCountItem = new System.Windows.Forms.ToolStripLabel();
            this.barangayMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.barangayMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.barangaySeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.barangayPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.barangaySeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.barangayMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.barangayMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.barangaySeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.barangayAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.barangayDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.barangaySaveItem = new System.Windows.Forms.ToolStripButton();
            this.barangayCancelItem = new System.Windows.Forms.ToolStripButton();
            this.barangaySeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.barangayMergeItem = new System.Windows.Forms.ToolStripButton();
            this.barangayChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageQuadrangle = new System.Windows.Forms.TabPage();
            this.panelQuadrangle = new System.Windows.Forms.Panel();
            this.quadrangleTextBox = new System.Windows.Forms.TextBox();
            this.quadrangleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.quadrangleCountItem = new System.Windows.Forms.ToolStripLabel();
            this.quadrangleMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quadranglePositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.quadrangleSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quadrangleMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quadrangleAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleCancelItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.quadrangleMergeItem = new System.Windows.Forms.ToolStripButton();
            this.quadrangleChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageSection = new System.Windows.Forms.TabPage();
            this.panelSection = new System.Windows.Forms.Panel();
            this.scaleTextBox = new System.Windows.Forms.TextBox();
            this.sectionIdTextBox = new System.Windows.Forms.TextBox();
            this.sectionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sectionCountItem = new System.Windows.Forms.ToolStripLabel();
            this.sectionMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.sectionMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.sectionSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sectionPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.sectionSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sectionMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.sectionMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.sectionSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sectionAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sectionDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sectionSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sectionCancelItem = new System.Windows.Forms.ToolStripButton();
            this.sectionSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sectionMergeItem = new System.Windows.Forms.ToolStripButton();
            this.sectionChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.tabPageLot = new System.Windows.Forms.TabPage();
            this.tabControlLot = new System.Windows.Forms.TabControl();
            this.tabPageLotInfo = new System.Windows.Forms.TabPage();
            this.lnkClaim = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.txtEncoder = new System.Windows.Forms.TextBox();
            this.geName2TextBox = new System.Windows.Forms.TextBox();
            this.surveyYearToTextBox = new System.Windows.Forms.TextBox();
            this.surveyDayToTextBox = new System.Windows.Forms.TextBox();
            this.surveyMonthToTextBox = new System.Windows.Forms.TextBox();
            this.surveyMonthFromTextBox = new System.Windows.Forms.TextBox();
            this.surveyYearFromTextBox = new System.Windows.Forms.TextBox();
            this.surveyDayFromTextBox = new System.Windows.Forms.TextBox();
            this.tabControlLotInfo = new System.Windows.Forms.TabControl();
            this.tabPageRemarks = new System.Windows.Forms.TabPage();
            this.lotRemarksTextBox = new System.Windows.Forms.TextBox();
            this.tabPageValidation = new System.Windows.Forms.TabPage();
            this.originalCompletedDateTextBox = new System.Windows.Forms.TextBox();
            this.originalCompletedByTextBox = new System.Windows.Forms.TextBox();
            this.finalCheckedBy2TextBox = new System.Windows.Forms.TextBox();
            this.finalCheckedBy1TextBox = new System.Windows.Forms.TextBox();
            this.originalCheckedDateTextBox = new System.Windows.Forms.TextBox();
            this.duplicateCheckedByTextBox = new System.Windows.Forms.TextBox();
            this.finalVerifiedByTextBox = new System.Windows.Forms.TextBox();
            this.duplicateCheckedDateTextBox = new System.Windows.Forms.TextBox();
            this.originalCheckedByTextBox = new System.Windows.Forms.TextBox();
            this.lblReferencePoint = new System.Windows.Forms.Label();
            this.lrcNoTextBox = new System.Windows.Forms.TextBox();
            this.referencePointComboBox = new System.Windows.Forms.ComboBox();
            this.claimantAddressTextBox = new System.Windows.Forms.TextBox();
            this.declaredAreaTextBox = new System.Windows.Forms.TextBox();
            this.computedAreaTextBox = new System.Windows.Forms.TextBox();
            this.tieLineNSTextBox = new System.Windows.Forms.TextBox();
            this.claimantNameTextBox = new System.Windows.Forms.TextBox();
            this.tieLineEWTextBox = new System.Windows.Forms.TextBox();
            this.tieLineDegreeTextBox = new System.Windows.Forms.TextBox();
            this.lotNoTextBox = new System.Windows.Forms.TextBox();
            this.tieLineMinuteTextBox = new System.Windows.Forms.TextBox();
            this.tieLineDistanceTextBox = new System.Windows.Forms.TextBox();
            this.tabPageLotData = new System.Windows.Forms.TabPage();
            this.splitContainerLotData = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.lotDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.lotDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnZoomSelectedLotData = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnZoomSelectedLotDatax = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZoomToExtentLotData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZoomOutLotData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZoomInLotData = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mapImageLotData = new SharpMap.Forms.MapBox();
            this.tabPageTechDesc = new System.Windows.Forms.TabPage();
            this.splitContainerTechDesc = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.techDescGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.techDescFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescNSColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescDegreeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescMinuteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescEWColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescDistanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techDescBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnZoomToExtentTechDesc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZoomOutTechDesc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnZoomInTechDesc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.mapImageTechDesc = new SharpMap.Forms.MapBox();
            this.lotBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.lotCountItem = new System.Windows.Forms.ToolStripLabel();
            this.lotMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.lotMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.lotSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lotPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.lotSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lotMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.lotMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.lotSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lotAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.lotDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.lotSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lotCancelItem = new System.Windows.Forms.ToolStripButton();
            this.lotSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lotChangeParentItem = new System.Windows.Forms.ToolStripButton();
            this.panelHeader = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lnkLogout = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lblWelcomeUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lnkOptions = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cadSurveyTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.CadSurveyTableAdapter();
            this.municipalityTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.MunicipalityTableAdapter();
            this.kryptonCheckSetNav = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            this.regionPsgcTableAdapter = new LSDMS.PsgcTableAdapters.RegionTableAdapter();
            this.provincePsgcTableAdapter = new LSDMS.PsgcTableAdapters.ProvinceTableAdapter();
            this.municipalityPsgcTableAdapter = new LSDMS.PsgcTableAdapters.MunicipalityTableAdapter();
            this.cadSurveyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.municipalityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.caseTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.CaseTableAdapter();
            this.caseErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.barangayTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.BarangayTableAdapter();
            this.barangayErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.barangayPsgcTableAdapter = new LSDMS.PsgcTableAdapters.BarangayTableAdapter();
            this.sectionTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.SectionTableAdapter();
            this.sectionErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lotTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.LotTableAdapter();
            this.lotErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lotDataTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.LotDataTableAdapter();
            this.lotDataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.techDescTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.TechDescTableAdapter();
            this.techDescErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ref_Type_TableTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.Ref_Type_Table2TableAdapter();
            this.saveShapeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.quadrangleTableAdapter = new LSDMS.lsdmsDataSetTableAdapters.QuadrangleTableAdapter();
            this.quadrangleErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cntxtLotDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuItemLotDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.ref_Type_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Sequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Northing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Easting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrsY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrsX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tieLineDistanceLabel = new System.Windows.Forms.Label();
            lotNoLabel = new System.Windows.Forms.Label();
            tieLineMinuteLabel = new System.Windows.Forms.Label();
            tieLineDegreeLabel = new System.Windows.Forms.Label();
            claimantNameLabel = new System.Windows.Forms.Label();
            tieLineEWLabel = new System.Windows.Forms.Label();
            tieLineNSLabel = new System.Windows.Forms.Label();
            computedAreaLabel = new System.Windows.Forms.Label();
            claimantAddressLabel = new System.Windows.Forms.Label();
            originalCompletedDateLabel = new System.Windows.Forms.Label();
            originalCompletedByLabel = new System.Windows.Forms.Label();
            finalCheckedBy2Label = new System.Windows.Forms.Label();
            finalCheckedBy1Label = new System.Windows.Forms.Label();
            declaredAreaLabel = new System.Windows.Forms.Label();
            originalCheckedDateLabel = new System.Windows.Forms.Label();
            finalVerifiedByLabel = new System.Windows.Forms.Label();
            duplicateCheckedDateLabel = new System.Windows.Forms.Label();
            originalCheckedByLabel = new System.Windows.Forms.Label();
            duplicateCheckedByLabel = new System.Windows.Forms.Label();
            referencePointLabel = new System.Windows.Forms.Label();
            scaleLabel = new System.Windows.Forms.Label();
            sectionIdLabel = new System.Windows.Forms.Label();
            barangayPsgcLabel = new System.Windows.Forms.Label();
            moduleNoLabel = new System.Windows.Forms.Label();
            cadCaseNoLabel = new System.Windows.Forms.Label();
            municipalityPsgcLabel = new System.Windows.Forms.Label();
            coordinateSystemLabel = new System.Windows.Forms.Label();
            provincePsgcLabel = new System.Windows.Forms.Label();
            surveySymbolNoLabel = new System.Windows.Forms.Label();
            regionPsgcLabel = new System.Windows.Forms.Label();
            previousSurveyNoLabel = new System.Windows.Forms.Label();
            islandLabel = new System.Windows.Forms.Label();
            approvedTotalMunicipalityLabel = new System.Windows.Forms.Label();
            approvedTotalCityLabel = new System.Windows.Forms.Label();
            approvedTotalBarangayLabel = new System.Windows.Forms.Label();
            approvedTotalLotLabel = new System.Windows.Forms.Label();
            approvedTotalAreaHectaresLabel = new System.Windows.Forms.Label();
            approvalRemarksLabel = new System.Windows.Forms.Label();
            cadSurveyNoLabel = new System.Windows.Forms.Label();
            lrcNoLabel = new System.Windows.Forms.Label();
            quadrangleLabel = new System.Windows.Forms.Label();
            surveyDateFromLabel = new System.Windows.Forms.Label();
            lblMonth = new System.Windows.Forms.Label();
            lblDay = new System.Windows.Forms.Label();
            lblYear = new System.Windows.Forms.Label();
            surveyDateToLabel = new System.Windows.Forms.Label();
            geName2Label = new System.Windows.Forms.Label();
            quadrangleFormatLabel = new System.Windows.Forms.Label();
            sectionFormatLabel = new System.Windows.Forms.Label();
            lblEncoder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel1)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel2)).BeginInit();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.tableLayoutPanelNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsdmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            this.panelCadSurveyNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntryHeaderGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntryHeaderGroup.Panel)).BeginInit();
            this.dataEntryHeaderGroup.Panel.SuspendLayout();
            this.dataEntryHeaderGroup.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageCadSurvey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyBindingNavigator)).BeginInit();
            this.cadSurveyBindingNavigator.SuspendLayout();
            this.panelCadSurvey.SuspendLayout();
            this.tabPageMunicipality.SuspendLayout();
            this.panelMunicipality.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingNavigator)).BeginInit();
            this.municipalityBindingNavigator.SuspendLayout();
            this.tabPageCase.SuspendLayout();
            this.panelCase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingNavigator)).BeginInit();
            this.caseBindingNavigator.SuspendLayout();
            this.tabPageBarangay.SuspendLayout();
            this.panelBarangay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangayPsgcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityPsgcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincePsgcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPsgcBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.psgc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingNavigator)).BeginInit();
            this.barangayBindingNavigator.SuspendLayout();
            this.tabPageQuadrangle.SuspendLayout();
            this.panelQuadrangle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleBindingNavigator)).BeginInit();
            this.quadrangleBindingNavigator.SuspendLayout();
            this.tabPageSection.SuspendLayout();
            this.panelSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingNavigator)).BeginInit();
            this.sectionBindingNavigator.SuspendLayout();
            this.tabPageLot.SuspendLayout();
            this.tabControlLot.SuspendLayout();
            this.tabPageLotInfo.SuspendLayout();
            this.tabControlLotInfo.SuspendLayout();
            this.tabPageRemarks.SuspendLayout();
            this.tabPageValidation.SuspendLayout();
            this.tabPageLotData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData.Panel1)).BeginInit();
            this.splitContainerLotData.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData.Panel2)).BeginInit();
            this.splitContainerLotData.Panel2.SuspendLayout();
            this.splitContainerLotData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataBindingSource)).BeginInit();
            this.tabPageTechDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc.Panel1)).BeginInit();
            this.splitContainerTechDesc.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc.Panel2)).BeginInit();
            this.splitContainerTechDesc.Panel2.SuspendLayout();
            this.splitContainerTechDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techDescGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDescBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingNavigator)).BeginInit();
            this.lotBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDescErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleErrorProvider)).BeginInit();
            this.cntxtLotDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ref_Type_TableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tieLineDistanceLabel
            // 
            tieLineDistanceLabel.AutoSize = true;
            tieLineDistanceLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tieLineDistanceLabel.Location = new System.Drawing.Point(79, 234);
            tieLineDistanceLabel.Name = "tieLineDistanceLabel";
            tieLineDistanceLabel.Size = new System.Drawing.Size(95, 13);
            tieLineDistanceLabel.TabIndex = 34;
            tieLineDistanceLabel.Text = "Tie Line Distance:";
            // 
            // lotNoLabel
            // 
            lotNoLabel.AutoSize = true;
            lotNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            lotNoLabel.Location = new System.Drawing.Point(81, 21);
            lotNoLabel.Name = "lotNoLabel";
            lotNoLabel.Size = new System.Drawing.Size(46, 13);
            lotNoLabel.TabIndex = 10;
            lotNoLabel.Text = "Lot No:";
            // 
            // tieLineMinuteLabel
            // 
            tieLineMinuteLabel.AutoSize = true;
            tieLineMinuteLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tieLineMinuteLabel.Location = new System.Drawing.Point(79, 208);
            tieLineMinuteLabel.Name = "tieLineMinuteLabel";
            tieLineMinuteLabel.Size = new System.Drawing.Size(88, 13);
            tieLineMinuteLabel.TabIndex = 32;
            tieLineMinuteLabel.Text = "Tie Line Minute:";
            // 
            // tieLineDegreeLabel
            // 
            tieLineDegreeLabel.AutoSize = true;
            tieLineDegreeLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tieLineDegreeLabel.Location = new System.Drawing.Point(79, 182);
            tieLineDegreeLabel.Name = "tieLineDegreeLabel";
            tieLineDegreeLabel.Size = new System.Drawing.Size(88, 13);
            tieLineDegreeLabel.TabIndex = 30;
            tieLineDegreeLabel.Text = "Tie Line Degree:";
            // 
            // claimantNameLabel
            // 
            claimantNameLabel.AutoSize = true;
            claimantNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            claimantNameLabel.Location = new System.Drawing.Point(399, 141);
            claimantNameLabel.Name = "claimantNameLabel";
            claimantNameLabel.Size = new System.Drawing.Size(87, 13);
            claimantNameLabel.TabIndex = 12;
            claimantNameLabel.Text = "Claimant Name:";
            // 
            // tieLineEWLabel
            // 
            tieLineEWLabel.AutoSize = true;
            tieLineEWLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tieLineEWLabel.Location = new System.Drawing.Point(79, 156);
            tieLineEWLabel.Name = "tieLineEWLabel";
            tieLineEWLabel.Size = new System.Drawing.Size(68, 13);
            tieLineEWLabel.TabIndex = 28;
            tieLineEWLabel.Text = "Tie Line EW:";
            // 
            // tieLineNSLabel
            // 
            tieLineNSLabel.AutoSize = true;
            tieLineNSLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            tieLineNSLabel.Location = new System.Drawing.Point(79, 130);
            tieLineNSLabel.Name = "tieLineNSLabel";
            tieLineNSLabel.Size = new System.Drawing.Size(65, 13);
            tieLineNSLabel.TabIndex = 26;
            tieLineNSLabel.Text = "Tie Line NS:";
            // 
            // computedAreaLabel
            // 
            computedAreaLabel.AutoSize = true;
            computedAreaLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            computedAreaLabel.Location = new System.Drawing.Point(399, 241);
            computedAreaLabel.Name = "computedAreaLabel";
            computedAreaLabel.Size = new System.Drawing.Size(90, 13);
            computedAreaLabel.TabIndex = 18;
            computedAreaLabel.Text = "Computed Area:";
            // 
            // claimantAddressLabel
            // 
            claimantAddressLabel.AutoSize = true;
            claimantAddressLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            claimantAddressLabel.Location = new System.Drawing.Point(399, 167);
            claimantAddressLabel.Name = "claimantAddressLabel";
            claimantAddressLabel.Size = new System.Drawing.Size(99, 13);
            claimantAddressLabel.TabIndex = 14;
            claimantAddressLabel.Text = "Claimant Address:";
            // 
            // originalCompletedDateLabel
            // 
            originalCompletedDateLabel.AutoSize = true;
            originalCompletedDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            originalCompletedDateLabel.Location = new System.Drawing.Point(6, 96);
            originalCompletedDateLabel.Name = "originalCompletedDateLabel";
            originalCompletedDateLabel.Size = new System.Drawing.Size(138, 13);
            originalCompletedDateLabel.TabIndex = 42;
            originalCompletedDateLabel.Text = "Original Completed Date:";
            // 
            // originalCompletedByLabel
            // 
            originalCompletedByLabel.AutoSize = true;
            originalCompletedByLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            originalCompletedByLabel.Location = new System.Drawing.Point(6, 70);
            originalCompletedByLabel.Name = "originalCompletedByLabel";
            originalCompletedByLabel.Size = new System.Drawing.Size(126, 13);
            originalCompletedByLabel.TabIndex = 40;
            originalCompletedByLabel.Text = "Original Completed By:";
            // 
            // finalCheckedBy2Label
            // 
            finalCheckedBy2Label.AutoSize = true;
            finalCheckedBy2Label.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            finalCheckedBy2Label.Location = new System.Drawing.Point(345, 122);
            finalCheckedBy2Label.Name = "finalCheckedBy2Label";
            finalCheckedBy2Label.Size = new System.Drawing.Size(103, 13);
            finalCheckedBy2Label.TabIndex = 52;
            finalCheckedBy2Label.Text = "Final Checked By2:";
            // 
            // finalCheckedBy1Label
            // 
            finalCheckedBy1Label.AutoSize = true;
            finalCheckedBy1Label.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            finalCheckedBy1Label.Location = new System.Drawing.Point(345, 96);
            finalCheckedBy1Label.Name = "finalCheckedBy1Label";
            finalCheckedBy1Label.Size = new System.Drawing.Size(103, 13);
            finalCheckedBy1Label.TabIndex = 50;
            finalCheckedBy1Label.Text = "Final Checked By1:";
            // 
            // declaredAreaLabel
            // 
            declaredAreaLabel.AutoSize = true;
            declaredAreaLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            declaredAreaLabel.Location = new System.Drawing.Point(399, 215);
            declaredAreaLabel.Name = "declaredAreaLabel";
            declaredAreaLabel.Size = new System.Drawing.Size(81, 13);
            declaredAreaLabel.TabIndex = 16;
            declaredAreaLabel.Text = "Declared Area:";
            // 
            // originalCheckedDateLabel
            // 
            originalCheckedDateLabel.AutoSize = true;
            originalCheckedDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            originalCheckedDateLabel.Location = new System.Drawing.Point(6, 44);
            originalCheckedDateLabel.Name = "originalCheckedDateLabel";
            originalCheckedDateLabel.Size = new System.Drawing.Size(126, 13);
            originalCheckedDateLabel.TabIndex = 38;
            originalCheckedDateLabel.Text = "Original Checked Date:";
            // 
            // finalVerifiedByLabel
            // 
            finalVerifiedByLabel.AutoSize = true;
            finalVerifiedByLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            finalVerifiedByLabel.Location = new System.Drawing.Point(345, 70);
            finalVerifiedByLabel.Name = "finalVerifiedByLabel";
            finalVerifiedByLabel.Size = new System.Drawing.Size(93, 13);
            finalVerifiedByLabel.TabIndex = 48;
            finalVerifiedByLabel.Text = "Final Verified By:";
            // 
            // duplicateCheckedDateLabel
            // 
            duplicateCheckedDateLabel.AutoSize = true;
            duplicateCheckedDateLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            duplicateCheckedDateLabel.Location = new System.Drawing.Point(345, 44);
            duplicateCheckedDateLabel.Name = "duplicateCheckedDateLabel";
            duplicateCheckedDateLabel.Size = new System.Drawing.Size(133, 13);
            duplicateCheckedDateLabel.TabIndex = 46;
            duplicateCheckedDateLabel.Text = "Duplicate Checked Date:";
            // 
            // originalCheckedByLabel
            // 
            originalCheckedByLabel.AutoSize = true;
            originalCheckedByLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            originalCheckedByLabel.Location = new System.Drawing.Point(6, 18);
            originalCheckedByLabel.Name = "originalCheckedByLabel";
            originalCheckedByLabel.Size = new System.Drawing.Size(114, 13);
            originalCheckedByLabel.TabIndex = 36;
            originalCheckedByLabel.Text = "Original Checked By:";
            // 
            // duplicateCheckedByLabel
            // 
            duplicateCheckedByLabel.AutoSize = true;
            duplicateCheckedByLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            duplicateCheckedByLabel.Location = new System.Drawing.Point(345, 18);
            duplicateCheckedByLabel.Name = "duplicateCheckedByLabel";
            duplicateCheckedByLabel.Size = new System.Drawing.Size(121, 13);
            duplicateCheckedByLabel.TabIndex = 44;
            duplicateCheckedByLabel.Text = "Duplicate Checked By:";
            // 
            // referencePointLabel
            // 
            referencePointLabel.AutoSize = true;
            referencePointLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            referencePointLabel.Location = new System.Drawing.Point(79, 73);
            referencePointLabel.Name = "referencePointLabel";
            referencePointLabel.Size = new System.Drawing.Size(91, 13);
            referencePointLabel.TabIndex = 20;
            referencePointLabel.Text = "Reference Point:";
            // 
            // scaleLabel
            // 
            scaleLabel.AutoSize = true;
            scaleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            scaleLabel.Location = new System.Drawing.Point(95, 114);
            scaleLabel.Name = "scaleLabel";
            scaleLabel.Size = new System.Drawing.Size(36, 13);
            scaleLabel.TabIndex = 12;
            scaleLabel.Text = "Scale:";
            // 
            // sectionIdLabel
            // 
            sectionIdLabel.AutoSize = true;
            sectionIdLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            sectionIdLabel.Location = new System.Drawing.Point(95, 84);
            sectionIdLabel.Name = "sectionIdLabel";
            sectionIdLabel.Size = new System.Drawing.Size(61, 13);
            sectionIdLabel.TabIndex = 8;
            sectionIdLabel.Text = "Section Id:";
            // 
            // barangayPsgcLabel
            // 
            barangayPsgcLabel.AutoSize = true;
            barangayPsgcLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            barangayPsgcLabel.Location = new System.Drawing.Point(84, 70);
            barangayPsgcLabel.Name = "barangayPsgcLabel";
            barangayPsgcLabel.Size = new System.Drawing.Size(59, 13);
            barangayPsgcLabel.TabIndex = 2;
            barangayPsgcLabel.Text = "Barangay:";
            // 
            // moduleNoLabel
            // 
            moduleNoLabel.AutoSize = true;
            moduleNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            moduleNoLabel.Location = new System.Drawing.Point(61, 92);
            moduleNoLabel.Name = "moduleNoLabel";
            moduleNoLabel.Size = new System.Drawing.Size(68, 13);
            moduleNoLabel.TabIndex = 8;
            moduleNoLabel.Text = "Module No:";
            // 
            // cadCaseNoLabel
            // 
            cadCaseNoLabel.AutoSize = true;
            cadCaseNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            cadCaseNoLabel.Location = new System.Drawing.Point(61, 64);
            cadCaseNoLabel.Name = "cadCaseNoLabel";
            cadCaseNoLabel.Size = new System.Drawing.Size(76, 13);
            cadCaseNoLabel.TabIndex = 4;
            cadCaseNoLabel.Text = "Cad Case No:";
            // 
            // municipalityPsgcLabel
            // 
            municipalityPsgcLabel.AutoSize = true;
            municipalityPsgcLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            municipalityPsgcLabel.Location = new System.Drawing.Point(103, 78);
            municipalityPsgcLabel.Name = "municipalityPsgcLabel";
            municipalityPsgcLabel.Size = new System.Drawing.Size(75, 13);
            municipalityPsgcLabel.TabIndex = 2;
            municipalityPsgcLabel.Text = "Municipality:";
            // 
            // coordinateSystemLabel
            // 
            coordinateSystemLabel.AutoSize = true;
            coordinateSystemLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            coordinateSystemLabel.Location = new System.Drawing.Point(71, 157);
            coordinateSystemLabel.Name = "coordinateSystemLabel";
            coordinateSystemLabel.Size = new System.Drawing.Size(106, 13);
            coordinateSystemLabel.TabIndex = 14;
            coordinateSystemLabel.Text = "Coordinate System:";
            // 
            // provincePsgcLabel
            // 
            provincePsgcLabel.AutoSize = true;
            provincePsgcLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            provincePsgcLabel.Location = new System.Drawing.Point(71, 131);
            provincePsgcLabel.Name = "provincePsgcLabel";
            provincePsgcLabel.Size = new System.Drawing.Size(53, 13);
            provincePsgcLabel.TabIndex = 12;
            provincePsgcLabel.Text = "Province:";
            // 
            // surveySymbolNoLabel
            // 
            surveySymbolNoLabel.AutoSize = true;
            surveySymbolNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            surveySymbolNoLabel.Location = new System.Drawing.Point(71, 183);
            surveySymbolNoLabel.Name = "surveySymbolNoLabel";
            surveySymbolNoLabel.Size = new System.Drawing.Size(101, 13);
            surveySymbolNoLabel.TabIndex = 16;
            surveySymbolNoLabel.Text = "Survey Symbol No:";
            // 
            // regionPsgcLabel
            // 
            regionPsgcLabel.AutoSize = true;
            regionPsgcLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            regionPsgcLabel.Location = new System.Drawing.Point(71, 105);
            regionPsgcLabel.Name = "regionPsgcLabel";
            regionPsgcLabel.Size = new System.Drawing.Size(47, 13);
            regionPsgcLabel.TabIndex = 10;
            regionPsgcLabel.Text = "Region:";
            // 
            // previousSurveyNoLabel
            // 
            previousSurveyNoLabel.AutoSize = true;
            previousSurveyNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            previousSurveyNoLabel.Location = new System.Drawing.Point(71, 209);
            previousSurveyNoLabel.Name = "previousSurveyNoLabel";
            previousSurveyNoLabel.Size = new System.Drawing.Size(107, 13);
            previousSurveyNoLabel.TabIndex = 18;
            previousSurveyNoLabel.Text = "Previous Survey No:";
            // 
            // islandLabel
            // 
            islandLabel.AutoSize = true;
            islandLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            islandLabel.Location = new System.Drawing.Point(71, 79);
            islandLabel.Name = "islandLabel";
            islandLabel.Size = new System.Drawing.Size(41, 13);
            islandLabel.TabIndex = 8;
            islandLabel.Text = "Island:";
            // 
            // approvedTotalMunicipalityLabel
            // 
            approvedTotalMunicipalityLabel.AutoSize = true;
            approvedTotalMunicipalityLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvedTotalMunicipalityLabel.Location = new System.Drawing.Point(71, 235);
            approvedTotalMunicipalityLabel.Name = "approvedTotalMunicipalityLabel";
            approvedTotalMunicipalityLabel.Size = new System.Drawing.Size(154, 13);
            approvedTotalMunicipalityLabel.TabIndex = 20;
            approvedTotalMunicipalityLabel.Text = "Approved Total Municipality:";
            // 
            // approvedTotalCityLabel
            // 
            approvedTotalCityLabel.AutoSize = true;
            approvedTotalCityLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvedTotalCityLabel.Location = new System.Drawing.Point(71, 261);
            approvedTotalCityLabel.Name = "approvedTotalCityLabel";
            approvedTotalCityLabel.Size = new System.Drawing.Size(110, 13);
            approvedTotalCityLabel.TabIndex = 22;
            approvedTotalCityLabel.Text = "Approved Total City:";
            // 
            // approvedTotalBarangayLabel
            // 
            approvedTotalBarangayLabel.AutoSize = true;
            approvedTotalBarangayLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvedTotalBarangayLabel.Location = new System.Drawing.Point(71, 287);
            approvedTotalBarangayLabel.Name = "approvedTotalBarangayLabel";
            approvedTotalBarangayLabel.Size = new System.Drawing.Size(139, 13);
            approvedTotalBarangayLabel.TabIndex = 24;
            approvedTotalBarangayLabel.Text = "Approved Total Barangay:";
            // 
            // approvedTotalLotLabel
            // 
            approvedTotalLotLabel.AutoSize = true;
            approvedTotalLotLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvedTotalLotLabel.Location = new System.Drawing.Point(71, 313);
            approvedTotalLotLabel.Name = "approvedTotalLotLabel";
            approvedTotalLotLabel.Size = new System.Drawing.Size(107, 13);
            approvedTotalLotLabel.TabIndex = 26;
            approvedTotalLotLabel.Text = "Approved Total Lot:";
            // 
            // approvedTotalAreaHectaresLabel
            // 
            approvedTotalAreaHectaresLabel.AutoSize = true;
            approvedTotalAreaHectaresLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvedTotalAreaHectaresLabel.Location = new System.Drawing.Point(71, 339);
            approvedTotalAreaHectaresLabel.Name = "approvedTotalAreaHectaresLabel";
            approvedTotalAreaHectaresLabel.Size = new System.Drawing.Size(134, 13);
            approvedTotalAreaHectaresLabel.TabIndex = 28;
            approvedTotalAreaHectaresLabel.Text = "Approved Total Area (Ha)";
            // 
            // approvalRemarksLabel
            // 
            approvalRemarksLabel.AutoSize = true;
            approvalRemarksLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            approvalRemarksLabel.Location = new System.Drawing.Point(71, 365);
            approvalRemarksLabel.Name = "approvalRemarksLabel";
            approvalRemarksLabel.Size = new System.Drawing.Size(102, 13);
            approvalRemarksLabel.TabIndex = 30;
            approvalRemarksLabel.Text = "Approval Remarks:";
            // 
            // cadSurveyNoLabel
            // 
            cadSurveyNoLabel.AutoSize = true;
            cadSurveyNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            cadSurveyNoLabel.Location = new System.Drawing.Point(71, 51);
            cadSurveyNoLabel.Name = "cadSurveyNoLabel";
            cadSurveyNoLabel.Size = new System.Drawing.Size(87, 13);
            cadSurveyNoLabel.TabIndex = 0;
            cadSurveyNoLabel.Text = "Cad Survey No:";
            // 
            // lrcNoLabel
            // 
            lrcNoLabel.AutoSize = true;
            lrcNoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lrcNoLabel.Location = new System.Drawing.Point(81, 47);
            lrcNoLabel.Name = "lrcNoLabel";
            lrcNoLabel.Size = new System.Drawing.Size(47, 13);
            lrcNoLabel.TabIndex = 57;
            lrcNoLabel.Text = "LRC No:";
            // 
            // quadrangleLabel
            // 
            quadrangleLabel.AutoSize = true;
            quadrangleLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quadrangleLabel.Location = new System.Drawing.Point(96, 76);
            quadrangleLabel.Name = "quadrangleLabel";
            quadrangleLabel.Size = new System.Drawing.Size(71, 13);
            quadrangleLabel.TabIndex = 13;
            quadrangleLabel.Text = "Quadrangle:";
            // 
            // surveyDateFromLabel
            // 
            surveyDateFromLabel.AutoSize = true;
            surveyDateFromLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            surveyDateFromLabel.Location = new System.Drawing.Point(399, 47);
            surveyDateFromLabel.Name = "surveyDateFromLabel";
            surveyDateFromLabel.Size = new System.Drawing.Size(84, 13);
            surveyDateFromLabel.TabIndex = 60;
            surveyDateFromLabel.Text = "Start of Survey:";
            // 
            // lblMonth
            // 
            lblMonth.AutoSize = true;
            lblMonth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMonth.ForeColor = System.Drawing.Color.Gray;
            lblMonth.Location = new System.Drawing.Point(499, 28);
            lblMonth.Name = "lblMonth";
            lblMonth.Size = new System.Drawing.Size(38, 13);
            lblMonth.TabIndex = 62;
            lblMonth.Text = "Month";
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDay.ForeColor = System.Drawing.Color.Gray;
            lblDay.Location = new System.Drawing.Point(543, 28);
            lblDay.Name = "lblDay";
            lblDay.Size = new System.Drawing.Size(26, 13);
            lblDay.TabIndex = 63;
            lblDay.Text = "Day";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblYear.ForeColor = System.Drawing.Color.Gray;
            lblYear.Location = new System.Drawing.Point(590, 28);
            lblYear.Name = "lblYear";
            lblYear.Size = new System.Drawing.Size(28, 13);
            lblYear.TabIndex = 64;
            lblYear.Text = "Year";
            // 
            // surveyDateToLabel
            // 
            surveyDateToLabel.AutoSize = true;
            surveyDateToLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            surveyDateToLabel.Location = new System.Drawing.Point(399, 75);
            surveyDateToLabel.Name = "surveyDateToLabel";
            surveyDateToLabel.Size = new System.Drawing.Size(80, 13);
            surveyDateToLabel.TabIndex = 67;
            surveyDateToLabel.Text = "End of Survey:";
            // 
            // geName2Label
            // 
            geName2Label.AutoSize = true;
            geName2Label.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            geName2Label.Location = new System.Drawing.Point(399, 103);
            geName2Label.Name = "geName2Label";
            geName2Label.Size = new System.Drawing.Size(56, 13);
            geName2Label.TabIndex = 72;
            geName2Label.Text = "GE Name:";
            // 
            // quadrangleFormatLabel
            // 
            quadrangleFormatLabel.AutoSize = true;
            quadrangleFormatLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quadrangleFormatLabel.ForeColor = System.Drawing.Color.Gray;
            quadrangleFormatLabel.Location = new System.Drawing.Point(299, 76);
            quadrangleFormatLabel.Name = "quadrangleFormatLabel";
            quadrangleFormatLabel.Size = new System.Drawing.Size(79, 13);
            quadrangleFormatLabel.TabIndex = 63;
            quadrangleFormatLabel.Text = "Ex. 6 31 124 37";
            // 
            // sectionFormatLabel
            // 
            sectionFormatLabel.AutoSize = true;
            sectionFormatLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sectionFormatLabel.ForeColor = System.Drawing.Color.Gray;
            sectionFormatLabel.Location = new System.Drawing.Point(299, 84);
            sectionFormatLabel.Name = "sectionFormatLabel";
            sectionFormatLabel.Size = new System.Drawing.Size(71, 13);
            sectionFormatLabel.TabIndex = 64;
            sectionFormatLabel.Text = "Ex. 1-A-NW-1";
            // 
            // lblEncoder
            // 
            lblEncoder.AutoSize = true;
            lblEncoder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            lblEncoder.Location = new System.Drawing.Point(399, 268);
            lblEncoder.Name = "lblEncoder";
            lblEncoder.Size = new System.Drawing.Size(52, 13);
            lblEncoder.TabIndex = 73;
            lblEncoder.Text = "Encoder:";
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.mainSplitContainer);
            this.kryptonPanel.Controls.Add(this.panelHeader);
            this.kryptonPanel.Controls.Add(this.statusStripMain);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(986, 736);
            this.kryptonPanel.TabIndex = 0;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 76);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanelNav);
            this.mainSplitContainer.Panel1MinSize = 20;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dataEntryHeaderGroup);
            this.mainSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.mainSplitContainer.Size = new System.Drawing.Size(986, 638);
            this.mainSplitContainer.SplitterDistance = 186;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanelNav
            // 
            this.tableLayoutPanelNav.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelNav.ColumnCount = 1;
            this.tableLayoutPanelNav.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNav.Controls.Add(this.listBoxQuadrangle, 0, 9);
            this.tableLayoutPanelNav.Controls.Add(this.btnQuadrangleNav, 0, 8);
            this.tableLayoutPanelNav.Controls.Add(this.btnMunicipalityNav, 0, 2);
            this.tableLayoutPanelNav.Controls.Add(this.listBoxLot, 0, 13);
            this.tableLayoutPanelNav.Controls.Add(this.listBoxSection, 0, 11);
            this.tableLayoutPanelNav.Controls.Add(this.listBoxBarangay, 0, 7);
            this.tableLayoutPanelNav.Controls.Add(this.listBoxCase, 0, 5);
            this.tableLayoutPanelNav.Controls.Add(this.listBoxMunicipality, 0, 3);
            this.tableLayoutPanelNav.Controls.Add(this.btnCaseNav, 0, 4);
            this.tableLayoutPanelNav.Controls.Add(this.btnBarangayNav, 0, 6);
            this.tableLayoutPanelNav.Controls.Add(this.btnSectionNav, 0, 10);
            this.tableLayoutPanelNav.Controls.Add(this.btnLotNav, 0, 12);
            this.tableLayoutPanelNav.Controls.Add(this.btnCadSurveyNav, 0, 0);
            this.tableLayoutPanelNav.Controls.Add(this.panelCadSurveyNav, 0, 1);
            this.tableLayoutPanelNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNav.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelNav.Name = "tableLayoutPanelNav";
            this.tableLayoutPanelNav.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanelNav.RowCount = 14;
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelNav.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.tableLayoutPanelNav.Size = new System.Drawing.Size(186, 638);
            this.tableLayoutPanelNav.TabIndex = 2;
            // 
            // listBoxQuadrangle
            // 
            this.listBoxQuadrangle.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxQuadrangle.DataSource = this.quadrangleBindingSource;
            this.listBoxQuadrangle.DisplayMember = "Quadrangle";
            this.listBoxQuadrangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxQuadrangle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxQuadrangle.FormattingEnabled = true;
            this.listBoxQuadrangle.ItemHeight = 17;
            this.listBoxQuadrangle.Location = new System.Drawing.Point(3, 575);
            this.listBoxQuadrangle.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxQuadrangle.Name = "listBoxQuadrangle";
            this.listBoxQuadrangle.Size = new System.Drawing.Size(180, 4);
            this.listBoxQuadrangle.TabIndex = 39;
            this.listBoxQuadrangle.ValueMember = "Quadrangle";
            // 
            // quadrangleBindingSource
            // 
            this.quadrangleBindingSource.DataMember = "Barangay_Quadrangle";
            this.quadrangleBindingSource.DataSource = this.barangayBindingSource;
            // 
            // barangayBindingSource
            // 
            this.barangayBindingSource.DataMember = "FK_CadSurveyMunicipalityCaseBarangay_CadSurveyMunicipalityCase";
            this.barangayBindingSource.DataSource = this.caseBindingSource;
            // 
            // caseBindingSource
            // 
            this.caseBindingSource.DataMember = "FK_CadSurveyMunicipalityCase_CadSurveyMunicipality";
            this.caseBindingSource.DataSource = this.municipalityBindingSource;
            // 
            // municipalityBindingSource
            // 
            this.municipalityBindingSource.DataMember = "FK_CadSurveyMunicipality_CadSurvey";
            this.municipalityBindingSource.DataSource = this.cadSurveyBindingSource;
            // 
            // cadSurveyBindingSource
            // 
            this.cadSurveyBindingSource.DataMember = "CadSurvey";
            this.cadSurveyBindingSource.DataSource = this.lsdmsDataSet;
            // 
            // lsdmsDataSet
            // 
            this.lsdmsDataSet.DataSetName = "lsdmsDataSet";
            this.lsdmsDataSet.EnforceConstraints = false;
            this.lsdmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnQuadrangleNav
            // 
            this.btnQuadrangleNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuadrangleNav.Location = new System.Drawing.Point(3, 545);
            this.btnQuadrangleNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuadrangleNav.Name = "btnQuadrangleNav";
            this.btnQuadrangleNav.Size = new System.Drawing.Size(180, 30);
            this.btnQuadrangleNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrangleNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnQuadrangleNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnQuadrangleNav.TabIndex = 39;
            this.btnQuadrangleNav.Text = "Quadrangle";
            this.btnQuadrangleNav.Values.ExtraText = "";
            this.btnQuadrangleNav.Values.Image = null;
            this.btnQuadrangleNav.Values.Text = "Quadrangle";
            this.btnQuadrangleNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // btnMunicipalityNav
            // 
            this.btnMunicipalityNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMunicipalityNav.Location = new System.Drawing.Point(3, 455);
            this.btnMunicipalityNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnMunicipalityNav.Name = "btnMunicipalityNav";
            this.btnMunicipalityNav.Size = new System.Drawing.Size(180, 30);
            this.btnMunicipalityNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMunicipalityNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnMunicipalityNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnMunicipalityNav.TabIndex = 35;
            this.btnMunicipalityNav.Text = "Municipality";
            this.btnMunicipalityNav.Values.ExtraText = "";
            this.btnMunicipalityNav.Values.Image = null;
            this.btnMunicipalityNav.Values.Text = "Municipality";
            this.btnMunicipalityNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // listBoxLot
            // 
            this.listBoxLot.DataSource = this.lotBindingSource;
            this.listBoxLot.DisplayMember = "LotNo";
            this.listBoxLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxLot.FormattingEnabled = true;
            this.listBoxLot.ItemHeight = 17;
            this.listBoxLot.Location = new System.Drawing.Point(3, 635);
            this.listBoxLot.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxLot.Name = "listBoxLot";
            this.listBoxLot.Size = new System.Drawing.Size(180, 4);
            this.listBoxLot.TabIndex = 5;
            this.listBoxLot.ValueMember = "LotNo";
            this.listBoxLot.Visible = false;
            // 
            // lotBindingSource
            // 
            this.lotBindingSource.DataMember = "FK_Lot_Section";
            this.lotBindingSource.DataSource = this.sectionBindingSource;
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataMember = "FK_Section_Quadrangle";
            this.sectionBindingSource.DataSource = this.quadrangleBindingSource;
            // 
            // listBoxSection
            // 
            this.listBoxSection.DataSource = this.sectionBindingSource;
            this.listBoxSection.DisplayMember = "SectionId";
            this.listBoxSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxSection.FormattingEnabled = true;
            this.listBoxSection.ItemHeight = 17;
            this.listBoxSection.Location = new System.Drawing.Point(3, 605);
            this.listBoxSection.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxSection.Name = "listBoxSection";
            this.listBoxSection.Size = new System.Drawing.Size(180, 4);
            this.listBoxSection.TabIndex = 4;
            this.listBoxSection.ValueMember = "SectionId";
            this.listBoxSection.Visible = false;
            // 
            // listBoxBarangay
            // 
            this.listBoxBarangay.DataSource = this.barangayBindingSource;
            this.listBoxBarangay.DisplayMember = "GEOG_NM";
            this.listBoxBarangay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxBarangay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxBarangay.FormattingEnabled = true;
            this.listBoxBarangay.ItemHeight = 17;
            this.listBoxBarangay.Location = new System.Drawing.Point(3, 545);
            this.listBoxBarangay.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxBarangay.Name = "listBoxBarangay";
            this.listBoxBarangay.Size = new System.Drawing.Size(180, 4);
            this.listBoxBarangay.TabIndex = 3;
            this.listBoxBarangay.ValueMember = "BarangayPsgc";
            this.listBoxBarangay.Visible = false;
            // 
            // listBoxCase
            // 
            this.listBoxCase.DataSource = this.caseBindingSource;
            this.listBoxCase.DisplayMember = "CadCaseNo";
            this.listBoxCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxCase.FormattingEnabled = true;
            this.listBoxCase.ItemHeight = 17;
            this.listBoxCase.Location = new System.Drawing.Point(3, 515);
            this.listBoxCase.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxCase.Name = "listBoxCase";
            this.listBoxCase.Size = new System.Drawing.Size(180, 4);
            this.listBoxCase.TabIndex = 2;
            this.listBoxCase.ValueMember = "CadCaseNo";
            this.listBoxCase.Visible = false;
            // 
            // listBoxMunicipality
            // 
            this.listBoxMunicipality.DataSource = this.municipalityBindingSource;
            this.listBoxMunicipality.DisplayMember = "GEOG_NM";
            this.listBoxMunicipality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxMunicipality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxMunicipality.FormattingEnabled = true;
            this.listBoxMunicipality.ItemHeight = 17;
            this.listBoxMunicipality.Location = new System.Drawing.Point(3, 485);
            this.listBoxMunicipality.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxMunicipality.Name = "listBoxMunicipality";
            this.listBoxMunicipality.Size = new System.Drawing.Size(180, 4);
            this.listBoxMunicipality.TabIndex = 1;
            this.listBoxMunicipality.ValueMember = "MunicipalityPsgc";
            this.listBoxMunicipality.Visible = false;
            // 
            // btnCaseNav
            // 
            this.btnCaseNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCaseNav.Location = new System.Drawing.Point(3, 485);
            this.btnCaseNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnCaseNav.Name = "btnCaseNav";
            this.btnCaseNav.Size = new System.Drawing.Size(180, 30);
            this.btnCaseNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnCaseNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCaseNav.TabIndex = 35;
            this.btnCaseNav.Text = "Case";
            this.btnCaseNav.Values.ExtraText = "";
            this.btnCaseNav.Values.Image = null;
            this.btnCaseNav.Values.Text = "Case";
            this.btnCaseNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // btnBarangayNav
            // 
            this.btnBarangayNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBarangayNav.Location = new System.Drawing.Point(3, 515);
            this.btnBarangayNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnBarangayNav.Name = "btnBarangayNav";
            this.btnBarangayNav.Size = new System.Drawing.Size(180, 30);
            this.btnBarangayNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarangayNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnBarangayNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnBarangayNav.TabIndex = 35;
            this.btnBarangayNav.Text = "Barangay";
            this.btnBarangayNav.Values.ExtraText = "";
            this.btnBarangayNav.Values.Image = null;
            this.btnBarangayNav.Values.Text = "Barangay";
            this.btnBarangayNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // btnSectionNav
            // 
            this.btnSectionNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSectionNav.Location = new System.Drawing.Point(3, 575);
            this.btnSectionNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnSectionNav.Name = "btnSectionNav";
            this.btnSectionNav.Size = new System.Drawing.Size(180, 30);
            this.btnSectionNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnSectionNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnSectionNav.TabIndex = 35;
            this.btnSectionNav.Text = "Section";
            this.btnSectionNav.Values.ExtraText = "";
            this.btnSectionNav.Values.Image = null;
            this.btnSectionNav.Values.Text = "Section";
            this.btnSectionNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // btnLotNav
            // 
            this.btnLotNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLotNav.Location = new System.Drawing.Point(3, 605);
            this.btnLotNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnLotNav.Name = "btnLotNav";
            this.btnLotNav.Size = new System.Drawing.Size(180, 30);
            this.btnLotNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnLotNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnLotNav.TabIndex = 35;
            this.btnLotNav.Text = "Lot";
            this.btnLotNav.Values.ExtraText = "";
            this.btnLotNav.Values.Image = null;
            this.btnLotNav.Values.Text = "Lot";
            this.btnLotNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // btnCadSurveyNav
            // 
            this.btnCadSurveyNav.Checked = true;
            this.btnCadSurveyNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadSurveyNav.Location = new System.Drawing.Point(3, 3);
            this.btnCadSurveyNav.Margin = new System.Windows.Forms.Padding(0);
            this.btnCadSurveyNav.Name = "btnCadSurveyNav";
            this.btnCadSurveyNav.Size = new System.Drawing.Size(180, 30);
            this.btnCadSurveyNav.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSurveyNav.StateCommon.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnCadSurveyNav.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadSurveyNav.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCadSurveyNav.TabIndex = 0;
            this.btnCadSurveyNav.Text = "Cad Survey";
            this.btnCadSurveyNav.Values.ExtraText = "";
            this.btnCadSurveyNav.Values.Image = null;
            this.btnCadSurveyNav.Values.Text = "Cad Survey";
            this.btnCadSurveyNav.Click += new System.EventHandler(this.NavTab_Click);
            // 
            // panelCadSurveyNav
            // 
            this.panelCadSurveyNav.Controls.Add(this.listBoxCadSurvey);
            this.panelCadSurveyNav.Controls.Add(this.cadSurveyNoSearchTextBox);
            this.panelCadSurveyNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadSurveyNav.Location = new System.Drawing.Point(6, 36);
            this.panelCadSurveyNav.Name = "panelCadSurveyNav";
            this.panelCadSurveyNav.Size = new System.Drawing.Size(174, 416);
            this.panelCadSurveyNav.TabIndex = 36;
            // 
            // listBoxCadSurvey
            // 
            this.listBoxCadSurvey.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxCadSurvey.DataSource = this.cadSurveyBindingSource;
            this.listBoxCadSurvey.DisplayMember = "CadSurveyNo";
            this.listBoxCadSurvey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCadSurvey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxCadSurvey.FormattingEnabled = true;
            this.listBoxCadSurvey.ItemHeight = 17;
            this.listBoxCadSurvey.Location = new System.Drawing.Point(0, 22);
            this.listBoxCadSurvey.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxCadSurvey.Name = "listBoxCadSurvey";
            this.listBoxCadSurvey.Size = new System.Drawing.Size(174, 378);
            this.listBoxCadSurvey.TabIndex = 5;
            this.listBoxCadSurvey.ValueMember = "CadSurveyNo";
            // 
            // cadSurveyNoSearchTextBox
            // 
            this.cadSurveyNoSearchTextBox.AcceptsReturn = true;
            this.cadSurveyNoSearchTextBox.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.btnSearchBoxClear});
            this.cadSurveyNoSearchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.cadSurveyNoSearchTextBox.Location = new System.Drawing.Point(0, 0);
            this.cadSurveyNoSearchTextBox.Name = "cadSurveyNoSearchTextBox";
            this.cadSurveyNoSearchTextBox.Size = new System.Drawing.Size(174, 22);
            this.cadSurveyNoSearchTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.cadSurveyNoSearchTextBox.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadSurveyNoSearchTextBox.TabIndex = 4;
            this.cadSurveyNoSearchTextBox.Text = "<Enter search term>";
            this.cadSurveyNoSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cadSurveyNoSearchTextBox_KeyDown);
            this.cadSurveyNoSearchTextBox.Enter += new System.EventHandler(this.cadSurveyNoSearchTextBox_Enter);
            this.cadSurveyNoSearchTextBox.Leave += new System.EventHandler(this.cadSurveyNoSearchTextBox_Leave);
            // 
            // btnSearchBoxClear
            // 
            this.btnSearchBoxClear.ExtraText = "";
            this.btnSearchBoxClear.Image = null;
            this.btnSearchBoxClear.Text = "";
            this.btnSearchBoxClear.ToolTipTitle = "Clear filter";
            this.btnSearchBoxClear.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.btnSearchBoxClear.UniqueName = "728ABFF0AA454BF3728ABFF0AA454BF3";
            this.btnSearchBoxClear.Click += new System.EventHandler(this.btnSearchBoxClear_Click);
            // 
            // dataEntryHeaderGroup
            // 
            this.dataEntryHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEntryHeaderGroup.HeaderVisibleSecondary = false;
            this.dataEntryHeaderGroup.Location = new System.Drawing.Point(0, 3);
            this.dataEntryHeaderGroup.Name = "dataEntryHeaderGroup";
            // 
            // dataEntryHeaderGroup.Panel
            // 
            this.dataEntryHeaderGroup.Panel.Controls.Add(this.tabControlMain);
            this.dataEntryHeaderGroup.Size = new System.Drawing.Size(795, 635);
            this.dataEntryHeaderGroup.TabIndex = 0;
            this.dataEntryHeaderGroup.Text = "Heading";
            this.dataEntryHeaderGroup.ValuesPrimary.Description = "";
            this.dataEntryHeaderGroup.ValuesPrimary.Heading = "Heading";
            this.dataEntryHeaderGroup.ValuesPrimary.Image = ((System.Drawing.Image)(resources.GetObject("dataEntryHeaderGroup.ValuesPrimary.Image")));
            this.dataEntryHeaderGroup.ValuesSecondary.Description = "";
            this.dataEntryHeaderGroup.ValuesSecondary.Heading = "Description";
            this.dataEntryHeaderGroup.ValuesSecondary.Image = null;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlMain.Controls.Add(this.tabPageCadSurvey);
            this.tabControlMain.Controls.Add(this.tabPageMunicipality);
            this.tabControlMain.Controls.Add(this.tabPageCase);
            this.tabControlMain.Controls.Add(this.tabPageBarangay);
            this.tabControlMain.Controls.Add(this.tabPageQuadrangle);
            this.tabControlMain.Controls.Add(this.tabPageSection);
            this.tabControlMain.Controls.Add(this.tabPageLot);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(793, 603);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            // 
            // tabPageCadSurvey
            // 
            this.tabPageCadSurvey.AutoScroll = true;
            this.tabPageCadSurvey.Controls.Add(this.cadSurveyBindingNavigator);
            this.tabPageCadSurvey.Controls.Add(this.panelCadSurvey);
            this.tabPageCadSurvey.Location = new System.Drawing.Point(4, 4);
            this.tabPageCadSurvey.Name = "tabPageCadSurvey";
            this.tabPageCadSurvey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadSurvey.Size = new System.Drawing.Size(784, 595);
            this.tabPageCadSurvey.TabIndex = 0;
            this.tabPageCadSurvey.Text = "CadSurvey";
            this.tabPageCadSurvey.UseVisualStyleBackColor = true;
            // 
            // cadSurveyBindingNavigator
            // 
            this.cadSurveyBindingNavigator.AddNewItem = null;
            this.cadSurveyBindingNavigator.BindingSource = this.cadSurveyBindingSource;
            this.cadSurveyBindingNavigator.CountItem = this.cadSurveyCountItem;
            this.cadSurveyBindingNavigator.DeleteItem = null;
            this.cadSurveyBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cadSurveyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadSurveyMoveFirstItem,
            this.cadSurveyMovePreviousItem,
            this.cadSurveySeparator1,
            this.cadSurveyPositionItem,
            this.cadSurveyCountItem,
            this.cadSurveySeparator2,
            this.cadSurveyMoveNextItem,
            this.cadSurveyMoveLastItem,
            this.cadSurveySeparator3,
            this.cadSurveyAddNewItem,
            this.cadSurveyDeleteItem,
            this.cadSurveySaveItem,
            this.cadSurveyCancelItem,
            this.cadSurveySeparator4,
            this.cadSurveyMergeItem});
            this.cadSurveyBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.cadSurveyBindingNavigator.MoveFirstItem = this.cadSurveyMoveFirstItem;
            this.cadSurveyBindingNavigator.MoveLastItem = this.cadSurveyMoveLastItem;
            this.cadSurveyBindingNavigator.MoveNextItem = this.cadSurveyMoveNextItem;
            this.cadSurveyBindingNavigator.MovePreviousItem = this.cadSurveyMovePreviousItem;
            this.cadSurveyBindingNavigator.Name = "cadSurveyBindingNavigator";
            this.cadSurveyBindingNavigator.PositionItem = this.cadSurveyPositionItem;
            this.cadSurveyBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.cadSurveyBindingNavigator.TabIndex = 1;
            this.cadSurveyBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // cadSurveyCountItem
            // 
            this.cadSurveyCountItem.Name = "cadSurveyCountItem";
            this.cadSurveyCountItem.Size = new System.Drawing.Size(35, 22);
            this.cadSurveyCountItem.Text = "of {0}";
            this.cadSurveyCountItem.ToolTipText = "Total number of items";
            // 
            // cadSurveyMoveFirstItem
            // 
            this.cadSurveyMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadSurveyMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyMoveFirstItem.Image")));
            this.cadSurveyMoveFirstItem.Name = "cadSurveyMoveFirstItem";
            this.cadSurveyMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.cadSurveyMoveFirstItem.Text = "Move first";
            // 
            // cadSurveyMovePreviousItem
            // 
            this.cadSurveyMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadSurveyMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyMovePreviousItem.Image")));
            this.cadSurveyMovePreviousItem.Name = "cadSurveyMovePreviousItem";
            this.cadSurveyMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.cadSurveyMovePreviousItem.Text = "Move previous";
            // 
            // cadSurveySeparator1
            // 
            this.cadSurveySeparator1.Name = "cadSurveySeparator1";
            this.cadSurveySeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cadSurveyPositionItem
            // 
            this.cadSurveyPositionItem.AccessibleName = "Position";
            this.cadSurveyPositionItem.AutoSize = false;
            this.cadSurveyPositionItem.Name = "cadSurveyPositionItem";
            this.cadSurveyPositionItem.Size = new System.Drawing.Size(50, 21);
            this.cadSurveyPositionItem.Text = "0";
            this.cadSurveyPositionItem.ToolTipText = "Current position";
            // 
            // cadSurveySeparator2
            // 
            this.cadSurveySeparator2.Name = "cadSurveySeparator2";
            this.cadSurveySeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cadSurveyMoveNextItem
            // 
            this.cadSurveyMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadSurveyMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyMoveNextItem.Image")));
            this.cadSurveyMoveNextItem.Name = "cadSurveyMoveNextItem";
            this.cadSurveyMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.cadSurveyMoveNextItem.Text = "Move next";
            // 
            // cadSurveyMoveLastItem
            // 
            this.cadSurveyMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cadSurveyMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyMoveLastItem.Image")));
            this.cadSurveyMoveLastItem.Name = "cadSurveyMoveLastItem";
            this.cadSurveyMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.cadSurveyMoveLastItem.Text = "Move last";
            // 
            // cadSurveySeparator3
            // 
            this.cadSurveySeparator3.Name = "cadSurveySeparator3";
            this.cadSurveySeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cadSurveyAddNewItem
            // 
            this.cadSurveyAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyAddNewItem.Image")));
            this.cadSurveyAddNewItem.Name = "cadSurveyAddNewItem";
            this.cadSurveyAddNewItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyAddNewItem.Size = new System.Drawing.Size(49, 22);
            this.cadSurveyAddNewItem.Text = "&Add";
            this.cadSurveyAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // cadSurveyDeleteItem
            // 
            this.cadSurveyDeleteItem.Enabled = false;
            this.cadSurveyDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyDeleteItem.Image")));
            this.cadSurveyDeleteItem.Name = "cadSurveyDeleteItem";
            this.cadSurveyDeleteItem.RightToLeftAutoMirrorImage = true;
            this.cadSurveyDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.cadSurveyDeleteItem.Text = "&Delete";
            this.cadSurveyDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // cadSurveySaveItem
            // 
            this.cadSurveySaveItem.Enabled = false;
            this.cadSurveySaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveySaveItem.Image")));
            this.cadSurveySaveItem.Name = "cadSurveySaveItem";
            this.cadSurveySaveItem.Size = new System.Drawing.Size(51, 22);
            this.cadSurveySaveItem.Text = "&Save";
            this.cadSurveySaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // cadSurveyCancelItem
            // 
            this.cadSurveyCancelItem.Enabled = false;
            this.cadSurveyCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("cadSurveyCancelItem.Image")));
            this.cadSurveyCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadSurveyCancelItem.Name = "cadSurveyCancelItem";
            this.cadSurveyCancelItem.Size = new System.Drawing.Size(63, 22);
            this.cadSurveyCancelItem.Text = "&Cancel";
            this.cadSurveyCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // cadSurveySeparator4
            // 
            this.cadSurveySeparator4.Name = "cadSurveySeparator4";
            this.cadSurveySeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // cadSurveyMergeItem
            // 
            this.cadSurveyMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.cadSurveyMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cadSurveyMergeItem.Name = "cadSurveyMergeItem";
            this.cadSurveyMergeItem.Size = new System.Drawing.Size(61, 22);
            this.cadSurveyMergeItem.Text = "&Merge";
            this.cadSurveyMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // panelCadSurvey
            // 
            this.panelCadSurvey.AutoScroll = true;
            this.panelCadSurvey.Controls.Add(this.regionPsgcErrorLabel);
            this.panelCadSurvey.Controls.Add(this.provincePsgcErrorLabel);
            this.panelCadSurvey.Controls.Add(cadSurveyNoLabel);
            this.panelCadSurvey.Controls.Add(this.approvalRemarksTextBox);
            this.panelCadSurvey.Controls.Add(approvalRemarksLabel);
            this.panelCadSurvey.Controls.Add(this.approvedTotalAreaHectaresTextBox);
            this.panelCadSurvey.Controls.Add(approvedTotalAreaHectaresLabel);
            this.panelCadSurvey.Controls.Add(this.regionPsgcComboBox);
            this.panelCadSurvey.Controls.Add(this.approvedTotalLotTextBox);
            this.panelCadSurvey.Controls.Add(this.provincePsgcComboBox);
            this.panelCadSurvey.Controls.Add(approvedTotalLotLabel);
            this.panelCadSurvey.Controls.Add(this.approvedTotalBarangayTextBox);
            this.panelCadSurvey.Controls.Add(approvedTotalBarangayLabel);
            this.panelCadSurvey.Controls.Add(this.cadSurveyNoTextBox);
            this.panelCadSurvey.Controls.Add(this.approvedTotalCityTextBox);
            this.panelCadSurvey.Controls.Add(approvedTotalCityLabel);
            this.panelCadSurvey.Controls.Add(this.approvedTotalMunicipalityTextBox);
            this.panelCadSurvey.Controls.Add(approvedTotalMunicipalityLabel);
            this.panelCadSurvey.Controls.Add(this.previousSurveyNoTextBox);
            this.panelCadSurvey.Controls.Add(islandLabel);
            this.panelCadSurvey.Controls.Add(previousSurveyNoLabel);
            this.panelCadSurvey.Controls.Add(this.islandTextBox);
            this.panelCadSurvey.Controls.Add(this.surveySymbolNoTextBox);
            this.panelCadSurvey.Controls.Add(regionPsgcLabel);
            this.panelCadSurvey.Controls.Add(surveySymbolNoLabel);
            this.panelCadSurvey.Controls.Add(provincePsgcLabel);
            this.panelCadSurvey.Controls.Add(this.coordinateSystemTextBox);
            this.panelCadSurvey.Controls.Add(coordinateSystemLabel);
            this.panelCadSurvey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadSurvey.Enabled = false;
            this.panelCadSurvey.Location = new System.Drawing.Point(3, 3);
            this.panelCadSurvey.Name = "panelCadSurvey";
            this.panelCadSurvey.Size = new System.Drawing.Size(778, 589);
            this.panelCadSurvey.TabIndex = 41;
            // 
            // regionPsgcErrorLabel
            // 
            this.regionPsgcErrorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "RegionPsgc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.regionPsgcErrorLabel.Location = new System.Drawing.Point(432, 102);
            this.regionPsgcErrorLabel.Name = "regionPsgcErrorLabel";
            this.regionPsgcErrorLabel.Size = new System.Drawing.Size(1, 21);
            this.regionPsgcErrorLabel.TabIndex = 37;
            // 
            // provincePsgcErrorLabel
            // 
            this.provincePsgcErrorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ProvincePsgc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.provincePsgcErrorLabel.Location = new System.Drawing.Point(432, 127);
            this.provincePsgcErrorLabel.Name = "provincePsgcErrorLabel";
            this.provincePsgcErrorLabel.Size = new System.Drawing.Size(1, 21);
            this.provincePsgcErrorLabel.TabIndex = 38;
            // 
            // approvalRemarksTextBox
            // 
            this.approvalRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovalRemarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.approvalRemarksTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvalRemarksTextBox.Location = new System.Drawing.Point(231, 362);
            this.approvalRemarksTextBox.Multiline = true;
            this.approvalRemarksTextBox.Name = "approvalRemarksTextBox";
            this.approvalRemarksTextBox.Size = new System.Drawing.Size(200, 51);
            this.approvalRemarksTextBox.TabIndex = 16;
            // 
            // approvedTotalAreaHectaresTextBox
            // 
            this.approvedTotalAreaHectaresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovedTotalAreaHectares", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.approvedTotalAreaHectaresTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvedTotalAreaHectaresTextBox.Location = new System.Drawing.Point(231, 336);
            this.approvedTotalAreaHectaresTextBox.Name = "approvedTotalAreaHectaresTextBox";
            this.approvedTotalAreaHectaresTextBox.Size = new System.Drawing.Size(84, 22);
            this.approvedTotalAreaHectaresTextBox.TabIndex = 15;
            this.approvedTotalAreaHectaresTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // regionPsgcComboBox
            // 
            this.regionPsgcComboBox.DisplayMember = "GEOG_NM";
            this.regionPsgcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionPsgcComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.regionPsgcComboBox.FormattingEnabled = true;
            this.regionPsgcComboBox.Location = new System.Drawing.Point(231, 102);
            this.regionPsgcComboBox.Name = "regionPsgcComboBox";
            this.regionPsgcComboBox.Size = new System.Drawing.Size(200, 21);
            this.regionPsgcComboBox.TabIndex = 6;
            this.ToolTip.SetToolTip(this.regionPsgcComboBox, "Select from the list");
            this.regionPsgcComboBox.ValueMember = "PSGC";
            // 
            // approvedTotalLotTextBox
            // 
            this.approvedTotalLotTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovedTotalLot", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.approvedTotalLotTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvedTotalLotTextBox.Location = new System.Drawing.Point(231, 310);
            this.approvedTotalLotTextBox.Name = "approvedTotalLotTextBox";
            this.approvedTotalLotTextBox.Size = new System.Drawing.Size(84, 22);
            this.approvedTotalLotTextBox.TabIndex = 14;
            this.approvedTotalLotTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // provincePsgcComboBox
            // 
            this.provincePsgcComboBox.DisplayMember = "GEOG_NM";
            this.provincePsgcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provincePsgcComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.provincePsgcComboBox.FormattingEnabled = true;
            this.provincePsgcComboBox.Location = new System.Drawing.Point(231, 127);
            this.provincePsgcComboBox.Name = "provincePsgcComboBox";
            this.provincePsgcComboBox.Size = new System.Drawing.Size(200, 21);
            this.provincePsgcComboBox.TabIndex = 7;
            this.ToolTip.SetToolTip(this.provincePsgcComboBox, "Select from the list");
            this.provincePsgcComboBox.ValueMember = "PSGC";
            // 
            // approvedTotalBarangayTextBox
            // 
            this.approvedTotalBarangayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovedTotalBarangay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.approvedTotalBarangayTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvedTotalBarangayTextBox.Location = new System.Drawing.Point(231, 284);
            this.approvedTotalBarangayTextBox.Name = "approvedTotalBarangayTextBox";
            this.approvedTotalBarangayTextBox.Size = new System.Drawing.Size(84, 22);
            this.approvedTotalBarangayTextBox.TabIndex = 13;
            this.approvedTotalBarangayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cadSurveyNoTextBox
            // 
            this.cadSurveyNoTextBox.CausesValidation = false;
            this.cadSurveyNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "CadSurveyNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cadSurveyNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cadSurveyNoTextBox.Location = new System.Drawing.Point(231, 48);
            this.cadSurveyNoTextBox.Name = "cadSurveyNoTextBox";
            this.cadSurveyNoTextBox.Size = new System.Drawing.Size(200, 22);
            this.cadSurveyNoTextBox.TabIndex = 1;
            this.ToolTip.SetToolTip(this.cadSurveyNoTextBox, "Sample: CAD 509, CAD 1058-D");
            // 
            // approvedTotalCityTextBox
            // 
            this.approvedTotalCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovedTotalCity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.approvedTotalCityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvedTotalCityTextBox.Location = new System.Drawing.Point(231, 258);
            this.approvedTotalCityTextBox.Name = "approvedTotalCityTextBox";
            this.approvedTotalCityTextBox.Size = new System.Drawing.Size(84, 22);
            this.approvedTotalCityTextBox.TabIndex = 12;
            this.approvedTotalCityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // approvedTotalMunicipalityTextBox
            // 
            this.approvedTotalMunicipalityTextBox.CausesValidation = false;
            this.approvedTotalMunicipalityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "ApprovedTotalMunicipality", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.approvedTotalMunicipalityTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.approvedTotalMunicipalityTextBox.Location = new System.Drawing.Point(231, 232);
            this.approvedTotalMunicipalityTextBox.Name = "approvedTotalMunicipalityTextBox";
            this.approvedTotalMunicipalityTextBox.Size = new System.Drawing.Size(84, 22);
            this.approvedTotalMunicipalityTextBox.TabIndex = 11;
            this.approvedTotalMunicipalityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // previousSurveyNoTextBox
            // 
            this.previousSurveyNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "PreviousSurveyNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.previousSurveyNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.previousSurveyNoTextBox.Location = new System.Drawing.Point(231, 206);
            this.previousSurveyNoTextBox.Name = "previousSurveyNoTextBox";
            this.previousSurveyNoTextBox.Size = new System.Drawing.Size(155, 22);
            this.previousSurveyNoTextBox.TabIndex = 10;
            // 
            // islandTextBox
            // 
            this.islandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "Island", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.islandTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.islandTextBox.Location = new System.Drawing.Point(231, 76);
            this.islandTextBox.Name = "islandTextBox";
            this.islandTextBox.Size = new System.Drawing.Size(200, 22);
            this.islandTextBox.TabIndex = 5;
            this.ToolTip.SetToolTip(this.islandTextBox, "Sample: Luzon, Visayas, Mindanao, Panay");
            // 
            // surveySymbolNoTextBox
            // 
            this.surveySymbolNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "SurveySymbolNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surveySymbolNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveySymbolNoTextBox.Location = new System.Drawing.Point(231, 180);
            this.surveySymbolNoTextBox.Name = "surveySymbolNoTextBox";
            this.surveySymbolNoTextBox.Size = new System.Drawing.Size(155, 22);
            this.surveySymbolNoTextBox.TabIndex = 9;
            // 
            // coordinateSystemTextBox
            // 
            this.coordinateSystemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadSurveyBindingSource, "CoordinateSystem", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.coordinateSystemTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.coordinateSystemTextBox.Location = new System.Drawing.Point(231, 154);
            this.coordinateSystemTextBox.Name = "coordinateSystemTextBox";
            this.coordinateSystemTextBox.Size = new System.Drawing.Size(200, 22);
            this.coordinateSystemTextBox.TabIndex = 8;
            // 
            // tabPageMunicipality
            // 
            this.tabPageMunicipality.AutoScroll = true;
            this.tabPageMunicipality.Controls.Add(this.panelMunicipality);
            this.tabPageMunicipality.Controls.Add(this.municipalityBindingNavigator);
            this.tabPageMunicipality.Location = new System.Drawing.Point(4, 4);
            this.tabPageMunicipality.Name = "tabPageMunicipality";
            this.tabPageMunicipality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMunicipality.Size = new System.Drawing.Size(784, 595);
            this.tabPageMunicipality.TabIndex = 1;
            this.tabPageMunicipality.Text = "Municipality";
            this.tabPageMunicipality.UseVisualStyleBackColor = true;
            // 
            // panelMunicipality
            // 
            this.panelMunicipality.Controls.Add(municipalityPsgcLabel);
            this.panelMunicipality.Controls.Add(this.municipalityPsgcErrorLabel);
            this.panelMunicipality.Controls.Add(this.municipalityPsgcListBox);
            this.panelMunicipality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMunicipality.Enabled = false;
            this.panelMunicipality.Location = new System.Drawing.Point(3, 28);
            this.panelMunicipality.Name = "panelMunicipality";
            this.panelMunicipality.Size = new System.Drawing.Size(778, 564);
            this.panelMunicipality.TabIndex = 10;
            // 
            // municipalityPsgcErrorLabel
            // 
            this.municipalityPsgcErrorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.municipalityBindingSource, "MunicipalityPsgc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.municipalityPsgcErrorLabel.Location = new System.Drawing.Point(306, 106);
            this.municipalityPsgcErrorLabel.Name = "municipalityPsgcErrorLabel";
            this.municipalityPsgcErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.municipalityPsgcErrorLabel.TabIndex = 9;
            // 
            // municipalityPsgcListBox
            // 
            this.municipalityPsgcListBox.DisplayMember = "GEOG_NM";
            this.municipalityPsgcListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.municipalityPsgcListBox.Location = new System.Drawing.Point(106, 106);
            this.municipalityPsgcListBox.Name = "municipalityPsgcListBox";
            this.municipalityPsgcListBox.Size = new System.Drawing.Size(194, 199);
            this.municipalityPsgcListBox.TabIndex = 17;
            this.municipalityPsgcListBox.ValueMember = "PSGC";
            // 
            // municipalityBindingNavigator
            // 
            this.municipalityBindingNavigator.AddNewItem = null;
            this.municipalityBindingNavigator.BindingSource = this.municipalityBindingSource;
            this.municipalityBindingNavigator.CountItem = this.municipalityCountItem;
            this.municipalityBindingNavigator.DeleteItem = null;
            this.municipalityBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.municipalityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.municipalityMoveFirstItem,
            this.municipalityMovePreviousItem,
            this.municipalitySeparator1,
            this.municipalityPositionItem,
            this.municipalityCountItem,
            this.municipalitySeparator2,
            this.municipalityMoveNextItem,
            this.municipalityMoveLastItem,
            this.municipalitySeparator3,
            this.municipalityAddNewItem,
            this.municipalityDeleteItem,
            this.municipalitySaveItem,
            this.municipalityCancelItem,
            this.municipalitySeparator4,
            this.municipalityMergeItem,
            this.municipalityChangeParentItem});
            this.municipalityBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.municipalityBindingNavigator.MoveFirstItem = this.municipalityMoveFirstItem;
            this.municipalityBindingNavigator.MoveLastItem = this.municipalityMoveLastItem;
            this.municipalityBindingNavigator.MoveNextItem = this.municipalityMoveNextItem;
            this.municipalityBindingNavigator.MovePreviousItem = this.municipalityMovePreviousItem;
            this.municipalityBindingNavigator.Name = "municipalityBindingNavigator";
            this.municipalityBindingNavigator.PositionItem = this.municipalityPositionItem;
            this.municipalityBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.municipalityBindingNavigator.TabIndex = 8;
            this.municipalityBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // municipalityCountItem
            // 
            this.municipalityCountItem.Name = "municipalityCountItem";
            this.municipalityCountItem.Size = new System.Drawing.Size(33, 22);
            this.municipalityCountItem.Text = "of {0}";
            this.municipalityCountItem.ToolTipText = "Total number of items";
            // 
            // municipalityMoveFirstItem
            // 
            this.municipalityMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.municipalityMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityMoveFirstItem.Image")));
            this.municipalityMoveFirstItem.Name = "municipalityMoveFirstItem";
            this.municipalityMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.municipalityMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.municipalityMoveFirstItem.Text = "Move first";
            // 
            // municipalityMovePreviousItem
            // 
            this.municipalityMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.municipalityMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityMovePreviousItem.Image")));
            this.municipalityMovePreviousItem.Name = "municipalityMovePreviousItem";
            this.municipalityMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.municipalityMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.municipalityMovePreviousItem.Text = "Move previous";
            // 
            // municipalitySeparator1
            // 
            this.municipalitySeparator1.Name = "municipalitySeparator1";
            this.municipalitySeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // municipalityPositionItem
            // 
            this.municipalityPositionItem.AccessibleName = "Position";
            this.municipalityPositionItem.AutoSize = false;
            this.municipalityPositionItem.Name = "municipalityPositionItem";
            this.municipalityPositionItem.Size = new System.Drawing.Size(50, 21);
            this.municipalityPositionItem.Text = "0";
            this.municipalityPositionItem.ToolTipText = "Current position";
            // 
            // municipalitySeparator2
            // 
            this.municipalitySeparator2.Name = "municipalitySeparator2";
            this.municipalitySeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // municipalityMoveNextItem
            // 
            this.municipalityMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.municipalityMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityMoveNextItem.Image")));
            this.municipalityMoveNextItem.Name = "municipalityMoveNextItem";
            this.municipalityMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.municipalityMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.municipalityMoveNextItem.Text = "Move next";
            // 
            // municipalityMoveLastItem
            // 
            this.municipalityMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.municipalityMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityMoveLastItem.Image")));
            this.municipalityMoveLastItem.Name = "municipalityMoveLastItem";
            this.municipalityMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.municipalityMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.municipalityMoveLastItem.Text = "Move last";
            // 
            // municipalitySeparator3
            // 
            this.municipalitySeparator3.Name = "municipalitySeparator3";
            this.municipalitySeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // municipalityAddNewItem
            // 
            this.municipalityAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityAddNewItem.Image")));
            this.municipalityAddNewItem.Name = "municipalityAddNewItem";
            this.municipalityAddNewItem.RightToLeftAutoMirrorImage = true;
            this.municipalityAddNewItem.Size = new System.Drawing.Size(48, 22);
            this.municipalityAddNewItem.Text = "&Add";
            this.municipalityAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // municipalityDeleteItem
            // 
            this.municipalityDeleteItem.Enabled = false;
            this.municipalityDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityDeleteItem.Image")));
            this.municipalityDeleteItem.Name = "municipalityDeleteItem";
            this.municipalityDeleteItem.RightToLeftAutoMirrorImage = true;
            this.municipalityDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.municipalityDeleteItem.Text = "&Delete";
            this.municipalityDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // municipalitySaveItem
            // 
            this.municipalitySaveItem.Enabled = false;
            this.municipalitySaveItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalitySaveItem.Image")));
            this.municipalitySaveItem.Name = "municipalitySaveItem";
            this.municipalitySaveItem.Size = new System.Drawing.Size(50, 22);
            this.municipalitySaveItem.Text = "&Save";
            this.municipalitySaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // municipalityCancelItem
            // 
            this.municipalityCancelItem.Enabled = false;
            this.municipalityCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityCancelItem.Image")));
            this.municipalityCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.municipalityCancelItem.Name = "municipalityCancelItem";
            this.municipalityCancelItem.Size = new System.Drawing.Size(61, 22);
            this.municipalityCancelItem.Text = "&Cancel";
            this.municipalityCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // municipalitySeparator4
            // 
            this.municipalitySeparator4.Name = "municipalitySeparator4";
            this.municipalitySeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // municipalityMergeItem
            // 
            this.municipalityMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.municipalityMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.municipalityMergeItem.Name = "municipalityMergeItem";
            this.municipalityMergeItem.Size = new System.Drawing.Size(60, 22);
            this.municipalityMergeItem.Text = "&Merge";
            this.municipalityMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // municipalityChangeParentItem
            // 
            this.municipalityChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("municipalityChangeParentItem.Image")));
            this.municipalityChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.municipalityChangeParentItem.Name = "municipalityChangeParentItem";
            this.municipalityChangeParentItem.Size = new System.Drawing.Size(104, 22);
            this.municipalityChangeParentItem.Text = "&Change parent";
            this.municipalityChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // tabPageCase
            // 
            this.tabPageCase.AutoScroll = true;
            this.tabPageCase.Controls.Add(this.panelCase);
            this.tabPageCase.Controls.Add(this.caseBindingNavigator);
            this.tabPageCase.Location = new System.Drawing.Point(4, 4);
            this.tabPageCase.Name = "tabPageCase";
            this.tabPageCase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCase.Size = new System.Drawing.Size(784, 595);
            this.tabPageCase.TabIndex = 2;
            this.tabPageCase.Text = "Case";
            this.tabPageCase.UseVisualStyleBackColor = true;
            // 
            // panelCase
            // 
            this.panelCase.Controls.Add(cadCaseNoLabel);
            this.panelCase.Controls.Add(this.moduleNoTextBox);
            this.panelCase.Controls.Add(moduleNoLabel);
            this.panelCase.Controls.Add(this.cadCaseNoTextBox);
            this.panelCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCase.Enabled = false;
            this.panelCase.Location = new System.Drawing.Point(3, 28);
            this.panelCase.Name = "panelCase";
            this.panelCase.Size = new System.Drawing.Size(778, 564);
            this.panelCase.TabIndex = 11;
            // 
            // moduleNoTextBox
            // 
            this.moduleNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "ModuleNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.moduleNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.moduleNoTextBox.Location = new System.Drawing.Point(159, 89);
            this.moduleNoTextBox.Name = "moduleNoTextBox";
            this.moduleNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.moduleNoTextBox.TabIndex = 20;
            this.moduleNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cadCaseNoTextBox
            // 
            this.cadCaseNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.caseBindingSource, "CadCaseNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cadCaseNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cadCaseNoTextBox.Location = new System.Drawing.Point(159, 61);
            this.cadCaseNoTextBox.Name = "cadCaseNoTextBox";
            this.cadCaseNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.cadCaseNoTextBox.TabIndex = 18;
            // 
            // caseBindingNavigator
            // 
            this.caseBindingNavigator.AddNewItem = null;
            this.caseBindingNavigator.BindingSource = this.caseBindingSource;
            this.caseBindingNavigator.CountItem = this.caseCountItem;
            this.caseBindingNavigator.DeleteItem = null;
            this.caseBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.caseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseMoveFirstItem,
            this.caseMovePreviousItem,
            this.caseSeparator1,
            this.casePositionItem,
            this.caseCountItem,
            this.caseSeparator2,
            this.caseMoveNextItem,
            this.caseMoveLastItem,
            this.caseSeparator3,
            this.caseAddNewItem,
            this.caseDeleteItem,
            this.caseSaveItem,
            this.caseCancelItem,
            this.caseSeparator4,
            this.caseMergeItem,
            this.caseChangeParentItem});
            this.caseBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.caseBindingNavigator.MoveFirstItem = this.caseMoveFirstItem;
            this.caseBindingNavigator.MoveLastItem = this.caseMoveLastItem;
            this.caseBindingNavigator.MoveNextItem = this.caseMoveNextItem;
            this.caseBindingNavigator.MovePreviousItem = this.caseMovePreviousItem;
            this.caseBindingNavigator.Name = "caseBindingNavigator";
            this.caseBindingNavigator.PositionItem = this.casePositionItem;
            this.caseBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.caseBindingNavigator.TabIndex = 10;
            this.caseBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // caseCountItem
            // 
            this.caseCountItem.Name = "caseCountItem";
            this.caseCountItem.Size = new System.Drawing.Size(33, 22);
            this.caseCountItem.Text = "of {0}";
            this.caseCountItem.ToolTipText = "Total number of items";
            // 
            // caseMoveFirstItem
            // 
            this.caseMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caseMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("caseMoveFirstItem.Image")));
            this.caseMoveFirstItem.Name = "caseMoveFirstItem";
            this.caseMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.caseMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.caseMoveFirstItem.Text = "Move first";
            // 
            // caseMovePreviousItem
            // 
            this.caseMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caseMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("caseMovePreviousItem.Image")));
            this.caseMovePreviousItem.Name = "caseMovePreviousItem";
            this.caseMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.caseMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.caseMovePreviousItem.Text = "Move previous";
            // 
            // caseSeparator1
            // 
            this.caseSeparator1.Name = "caseSeparator1";
            this.caseSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // casePositionItem
            // 
            this.casePositionItem.AccessibleName = "Position";
            this.casePositionItem.AutoSize = false;
            this.casePositionItem.Name = "casePositionItem";
            this.casePositionItem.Size = new System.Drawing.Size(50, 21);
            this.casePositionItem.Text = "0";
            this.casePositionItem.ToolTipText = "Current position";
            // 
            // caseSeparator2
            // 
            this.caseSeparator2.Name = "caseSeparator2";
            this.caseSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // caseMoveNextItem
            // 
            this.caseMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caseMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("caseMoveNextItem.Image")));
            this.caseMoveNextItem.Name = "caseMoveNextItem";
            this.caseMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.caseMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.caseMoveNextItem.Text = "Move next";
            // 
            // caseMoveLastItem
            // 
            this.caseMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caseMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("caseMoveLastItem.Image")));
            this.caseMoveLastItem.Name = "caseMoveLastItem";
            this.caseMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.caseMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.caseMoveLastItem.Text = "Move last";
            // 
            // caseSeparator3
            // 
            this.caseSeparator3.Name = "caseSeparator3";
            this.caseSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // caseAddNewItem
            // 
            this.caseAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("caseAddNewItem.Image")));
            this.caseAddNewItem.Name = "caseAddNewItem";
            this.caseAddNewItem.RightToLeftAutoMirrorImage = true;
            this.caseAddNewItem.Size = new System.Drawing.Size(48, 22);
            this.caseAddNewItem.Text = "&Add";
            this.caseAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // caseDeleteItem
            // 
            this.caseDeleteItem.Enabled = false;
            this.caseDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("caseDeleteItem.Image")));
            this.caseDeleteItem.Name = "caseDeleteItem";
            this.caseDeleteItem.RightToLeftAutoMirrorImage = true;
            this.caseDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.caseDeleteItem.Text = "&Delete";
            this.caseDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // caseSaveItem
            // 
            this.caseSaveItem.Enabled = false;
            this.caseSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("caseSaveItem.Image")));
            this.caseSaveItem.Name = "caseSaveItem";
            this.caseSaveItem.Size = new System.Drawing.Size(50, 22);
            this.caseSaveItem.Text = "&Save";
            this.caseSaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // caseCancelItem
            // 
            this.caseCancelItem.Enabled = false;
            this.caseCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("caseCancelItem.Image")));
            this.caseCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.caseCancelItem.Name = "caseCancelItem";
            this.caseCancelItem.Size = new System.Drawing.Size(61, 22);
            this.caseCancelItem.Text = "&Cancel";
            this.caseCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // caseSeparator4
            // 
            this.caseSeparator4.Name = "caseSeparator4";
            this.caseSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // caseMergeItem
            // 
            this.caseMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.caseMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.caseMergeItem.Name = "caseMergeItem";
            this.caseMergeItem.Size = new System.Drawing.Size(60, 22);
            this.caseMergeItem.Text = "&Merge";
            this.caseMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // caseChangeParentItem
            // 
            this.caseChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("caseChangeParentItem.Image")));
            this.caseChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.caseChangeParentItem.Name = "caseChangeParentItem";
            this.caseChangeParentItem.Size = new System.Drawing.Size(104, 22);
            this.caseChangeParentItem.Text = "&Change parent";
            this.caseChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // tabPageBarangay
            // 
            this.tabPageBarangay.AutoScroll = true;
            this.tabPageBarangay.Controls.Add(this.panelBarangay);
            this.tabPageBarangay.Controls.Add(this.barangayBindingNavigator);
            this.tabPageBarangay.Location = new System.Drawing.Point(4, 4);
            this.tabPageBarangay.Name = "tabPageBarangay";
            this.tabPageBarangay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarangay.Size = new System.Drawing.Size(784, 595);
            this.tabPageBarangay.TabIndex = 3;
            this.tabPageBarangay.Text = "Barangay";
            this.tabPageBarangay.UseVisualStyleBackColor = true;
            // 
            // panelBarangay
            // 
            this.panelBarangay.Controls.Add(barangayPsgcLabel);
            this.panelBarangay.Controls.Add(this.barangayPsgcErrorLabel);
            this.panelBarangay.Controls.Add(this.barangayPsgcListBox);
            this.panelBarangay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarangay.Enabled = false;
            this.panelBarangay.Location = new System.Drawing.Point(3, 28);
            this.panelBarangay.Name = "panelBarangay";
            this.panelBarangay.Size = new System.Drawing.Size(778, 564);
            this.panelBarangay.TabIndex = 13;
            // 
            // barangayPsgcErrorLabel
            // 
            this.barangayPsgcErrorLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangayBindingSource, "BarangayPsgc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.barangayPsgcErrorLabel.Location = new System.Drawing.Point(288, 95);
            this.barangayPsgcErrorLabel.Name = "barangayPsgcErrorLabel";
            this.barangayPsgcErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.barangayPsgcErrorLabel.TabIndex = 12;
            // 
            // barangayPsgcListBox
            // 
            this.barangayPsgcListBox.DataSource = this.barangayPsgcBindingSource;
            this.barangayPsgcListBox.DisplayMember = "GEOG_NM";
            this.barangayPsgcListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.barangayPsgcListBox.Location = new System.Drawing.Point(87, 95);
            this.barangayPsgcListBox.Name = "barangayPsgcListBox";
            this.barangayPsgcListBox.Size = new System.Drawing.Size(195, 212);
            this.barangayPsgcListBox.TabIndex = 12;
            this.barangayPsgcListBox.ValueMember = "PSGC";
            // 
            // barangayPsgcBindingSource
            // 
            this.barangayPsgcBindingSource.DataMember = "Municipality_Barangay";
            this.barangayPsgcBindingSource.DataSource = this.municipalityPsgcBindingSource;
            // 
            // municipalityPsgcBindingSource
            // 
            this.municipalityPsgcBindingSource.DataMember = "Province_Municipality";
            this.municipalityPsgcBindingSource.DataSource = this.provincePsgcBindingSource;
            // 
            // provincePsgcBindingSource
            // 
            this.provincePsgcBindingSource.DataMember = "Region_Province";
            this.provincePsgcBindingSource.DataSource = this.regionPsgcBindingSource;
            // 
            // regionPsgcBindingSource
            // 
            this.regionPsgcBindingSource.DataMember = "Region";
            this.regionPsgcBindingSource.DataSource = this.psgc;
            // 
            // psgc
            // 
            this.psgc.DataSetName = "Psgc";
            this.psgc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barangayBindingNavigator
            // 
            this.barangayBindingNavigator.AddNewItem = null;
            this.barangayBindingNavigator.BindingSource = this.barangayBindingSource;
            this.barangayBindingNavigator.CountItem = this.barangayCountItem;
            this.barangayBindingNavigator.DeleteItem = null;
            this.barangayBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.barangayBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangayMoveFirstItem,
            this.barangayMovePreviousItem,
            this.barangaySeparator1,
            this.barangayPositionItem,
            this.barangayCountItem,
            this.barangaySeparator2,
            this.barangayMoveNextItem,
            this.barangayMoveLastItem,
            this.barangaySeparator3,
            this.barangayAddNewItem,
            this.barangayDeleteItem,
            this.barangaySaveItem,
            this.barangayCancelItem,
            this.barangaySeparator4,
            this.barangayMergeItem,
            this.barangayChangeParentItem});
            this.barangayBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.barangayBindingNavigator.MoveFirstItem = this.barangayMoveFirstItem;
            this.barangayBindingNavigator.MoveLastItem = this.barangayMoveLastItem;
            this.barangayBindingNavigator.MoveNextItem = this.barangayMoveNextItem;
            this.barangayBindingNavigator.MovePreviousItem = this.barangayMovePreviousItem;
            this.barangayBindingNavigator.Name = "barangayBindingNavigator";
            this.barangayBindingNavigator.PositionItem = this.barangayPositionItem;
            this.barangayBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.barangayBindingNavigator.TabIndex = 10;
            this.barangayBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // barangayCountItem
            // 
            this.barangayCountItem.Name = "barangayCountItem";
            this.barangayCountItem.Size = new System.Drawing.Size(33, 22);
            this.barangayCountItem.Text = "of {0}";
            this.barangayCountItem.ToolTipText = "Total number of items";
            // 
            // barangayMoveFirstItem
            // 
            this.barangayMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barangayMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayMoveFirstItem.Image")));
            this.barangayMoveFirstItem.Name = "barangayMoveFirstItem";
            this.barangayMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.barangayMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.barangayMoveFirstItem.Text = "Move first";
            // 
            // barangayMovePreviousItem
            // 
            this.barangayMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barangayMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayMovePreviousItem.Image")));
            this.barangayMovePreviousItem.Name = "barangayMovePreviousItem";
            this.barangayMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.barangayMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.barangayMovePreviousItem.Text = "Move previous";
            // 
            // barangaySeparator1
            // 
            this.barangaySeparator1.Name = "barangaySeparator1";
            this.barangaySeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // barangayPositionItem
            // 
            this.barangayPositionItem.AccessibleName = "Position";
            this.barangayPositionItem.AutoSize = false;
            this.barangayPositionItem.Name = "barangayPositionItem";
            this.barangayPositionItem.Size = new System.Drawing.Size(50, 21);
            this.barangayPositionItem.Text = "0";
            this.barangayPositionItem.ToolTipText = "Current position";
            // 
            // barangaySeparator2
            // 
            this.barangaySeparator2.Name = "barangaySeparator2";
            this.barangaySeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // barangayMoveNextItem
            // 
            this.barangayMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barangayMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayMoveNextItem.Image")));
            this.barangayMoveNextItem.Name = "barangayMoveNextItem";
            this.barangayMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.barangayMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.barangayMoveNextItem.Text = "Move next";
            // 
            // barangayMoveLastItem
            // 
            this.barangayMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barangayMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayMoveLastItem.Image")));
            this.barangayMoveLastItem.Name = "barangayMoveLastItem";
            this.barangayMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.barangayMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.barangayMoveLastItem.Text = "Move last";
            // 
            // barangaySeparator3
            // 
            this.barangaySeparator3.Name = "barangaySeparator3";
            this.barangaySeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // barangayAddNewItem
            // 
            this.barangayAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayAddNewItem.Image")));
            this.barangayAddNewItem.Name = "barangayAddNewItem";
            this.barangayAddNewItem.RightToLeftAutoMirrorImage = true;
            this.barangayAddNewItem.Size = new System.Drawing.Size(48, 22);
            this.barangayAddNewItem.Text = "&Add";
            this.barangayAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // barangayDeleteItem
            // 
            this.barangayDeleteItem.Enabled = false;
            this.barangayDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayDeleteItem.Image")));
            this.barangayDeleteItem.Name = "barangayDeleteItem";
            this.barangayDeleteItem.RightToLeftAutoMirrorImage = true;
            this.barangayDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.barangayDeleteItem.Text = "&Delete";
            this.barangayDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // barangaySaveItem
            // 
            this.barangaySaveItem.Enabled = false;
            this.barangaySaveItem.Image = ((System.Drawing.Image)(resources.GetObject("barangaySaveItem.Image")));
            this.barangaySaveItem.Name = "barangaySaveItem";
            this.barangaySaveItem.Size = new System.Drawing.Size(50, 22);
            this.barangaySaveItem.Text = "&Save";
            this.barangaySaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // barangayCancelItem
            // 
            this.barangayCancelItem.Enabled = false;
            this.barangayCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayCancelItem.Image")));
            this.barangayCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barangayCancelItem.Name = "barangayCancelItem";
            this.barangayCancelItem.Size = new System.Drawing.Size(61, 22);
            this.barangayCancelItem.Text = "&Cancel";
            this.barangayCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // barangaySeparator4
            // 
            this.barangaySeparator4.Name = "barangaySeparator4";
            this.barangaySeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // barangayMergeItem
            // 
            this.barangayMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.barangayMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barangayMergeItem.Name = "barangayMergeItem";
            this.barangayMergeItem.Size = new System.Drawing.Size(60, 22);
            this.barangayMergeItem.Text = "&Merge";
            this.barangayMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // barangayChangeParentItem
            // 
            this.barangayChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("barangayChangeParentItem.Image")));
            this.barangayChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barangayChangeParentItem.Name = "barangayChangeParentItem";
            this.barangayChangeParentItem.Size = new System.Drawing.Size(104, 22);
            this.barangayChangeParentItem.Text = "&Change parent";
            this.barangayChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // tabPageQuadrangle
            // 
            this.tabPageQuadrangle.Controls.Add(this.panelQuadrangle);
            this.tabPageQuadrangle.Controls.Add(this.quadrangleBindingNavigator);
            this.tabPageQuadrangle.Location = new System.Drawing.Point(4, 4);
            this.tabPageQuadrangle.Name = "tabPageQuadrangle";
            this.tabPageQuadrangle.Size = new System.Drawing.Size(784, 595);
            this.tabPageQuadrangle.TabIndex = 6;
            this.tabPageQuadrangle.Text = "tabPage1";
            this.tabPageQuadrangle.UseVisualStyleBackColor = true;
            // 
            // panelQuadrangle
            // 
            this.panelQuadrangle.Controls.Add(quadrangleFormatLabel);
            this.panelQuadrangle.Controls.Add(quadrangleLabel);
            this.panelQuadrangle.Controls.Add(this.quadrangleTextBox);
            this.panelQuadrangle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuadrangle.Enabled = false;
            this.panelQuadrangle.Location = new System.Drawing.Point(0, 25);
            this.panelQuadrangle.Name = "panelQuadrangle";
            this.panelQuadrangle.Size = new System.Drawing.Size(784, 570);
            this.panelQuadrangle.TabIndex = 13;
            // 
            // quadrangleTextBox
            // 
            this.quadrangleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quadrangleBindingSource, "Quadrangle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.quadrangleTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.quadrangleTextBox.Location = new System.Drawing.Point(173, 73);
            this.quadrangleTextBox.Name = "quadrangleTextBox";
            this.quadrangleTextBox.Size = new System.Drawing.Size(120, 22);
            this.quadrangleTextBox.TabIndex = 12;
            this.ToolTip.SetToolTip(this.quadrangleTextBox, "Separate coordinate values using space");
            // 
            // quadrangleBindingNavigator
            // 
            this.quadrangleBindingNavigator.AddNewItem = null;
            this.quadrangleBindingNavigator.BindingSource = this.quadrangleBindingSource;
            this.quadrangleBindingNavigator.CountItem = this.quadrangleCountItem;
            this.quadrangleBindingNavigator.DeleteItem = null;
            this.quadrangleBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.quadrangleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadrangleMoveFirstItem,
            this.quadrangleMovePreviousItem,
            this.quadrangleSeparator1,
            this.quadranglePositionItem,
            this.quadrangleCountItem,
            this.quadrangleSeparator2,
            this.quadrangleMoveNextItem,
            this.quadrangleMoveLastItem,
            this.quadrangleSeparator3,
            this.quadrangleAddNewItem,
            this.quadrangleDeleteItem,
            this.quadrangleSaveItem,
            this.quadrangleCancelItem,
            this.quadrangleSeparator4,
            this.quadrangleMergeItem,
            this.quadrangleChangeParentItem});
            this.quadrangleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quadrangleBindingNavigator.MoveFirstItem = this.quadrangleMoveFirstItem;
            this.quadrangleBindingNavigator.MoveLastItem = this.quadrangleMoveLastItem;
            this.quadrangleBindingNavigator.MoveNextItem = this.quadrangleMoveNextItem;
            this.quadrangleBindingNavigator.MovePreviousItem = this.quadrangleMovePreviousItem;
            this.quadrangleBindingNavigator.Name = "quadrangleBindingNavigator";
            this.quadrangleBindingNavigator.PositionItem = this.quadranglePositionItem;
            this.quadrangleBindingNavigator.Size = new System.Drawing.Size(784, 25);
            this.quadrangleBindingNavigator.TabIndex = 3;
            this.quadrangleBindingNavigator.Text = "bindingNavigator1";
            // 
            // quadrangleCountItem
            // 
            this.quadrangleCountItem.Name = "quadrangleCountItem";
            this.quadrangleCountItem.Size = new System.Drawing.Size(33, 22);
            this.quadrangleCountItem.Text = "of {0}";
            this.quadrangleCountItem.ToolTipText = "Total number of items";
            // 
            // quadrangleMoveFirstItem
            // 
            this.quadrangleMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quadrangleMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleMoveFirstItem.Image")));
            this.quadrangleMoveFirstItem.Name = "quadrangleMoveFirstItem";
            this.quadrangleMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.quadrangleMoveFirstItem.Text = "Move first";
            // 
            // quadrangleMovePreviousItem
            // 
            this.quadrangleMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quadrangleMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleMovePreviousItem.Image")));
            this.quadrangleMovePreviousItem.Name = "quadrangleMovePreviousItem";
            this.quadrangleMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.quadrangleMovePreviousItem.Text = "Move previous";
            // 
            // quadrangleSeparator1
            // 
            this.quadrangleSeparator1.Name = "quadrangleSeparator1";
            this.quadrangleSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // quadranglePositionItem
            // 
            this.quadranglePositionItem.AccessibleName = "Position";
            this.quadranglePositionItem.AutoSize = false;
            this.quadranglePositionItem.Name = "quadranglePositionItem";
            this.quadranglePositionItem.Size = new System.Drawing.Size(50, 22);
            this.quadranglePositionItem.Text = "0";
            this.quadranglePositionItem.ToolTipText = "Current position";
            // 
            // quadrangleSeparator2
            // 
            this.quadrangleSeparator2.Name = "quadrangleSeparator2";
            this.quadrangleSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // quadrangleMoveNextItem
            // 
            this.quadrangleMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quadrangleMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleMoveNextItem.Image")));
            this.quadrangleMoveNextItem.Name = "quadrangleMoveNextItem";
            this.quadrangleMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.quadrangleMoveNextItem.Text = "Move next";
            // 
            // quadrangleMoveLastItem
            // 
            this.quadrangleMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quadrangleMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleMoveLastItem.Image")));
            this.quadrangleMoveLastItem.Name = "quadrangleMoveLastItem";
            this.quadrangleMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.quadrangleMoveLastItem.Text = "Move last";
            // 
            // quadrangleSeparator3
            // 
            this.quadrangleSeparator3.Name = "quadrangleSeparator3";
            this.quadrangleSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // quadrangleAddNewItem
            // 
            this.quadrangleAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleAddNewItem.Image")));
            this.quadrangleAddNewItem.Name = "quadrangleAddNewItem";
            this.quadrangleAddNewItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleAddNewItem.Size = new System.Drawing.Size(48, 22);
            this.quadrangleAddNewItem.Text = "&Add";
            this.quadrangleAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // quadrangleDeleteItem
            // 
            this.quadrangleDeleteItem.Enabled = false;
            this.quadrangleDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleDeleteItem.Image")));
            this.quadrangleDeleteItem.Name = "quadrangleDeleteItem";
            this.quadrangleDeleteItem.RightToLeftAutoMirrorImage = true;
            this.quadrangleDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.quadrangleDeleteItem.Text = "&Delete";
            this.quadrangleDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // quadrangleSaveItem
            // 
            this.quadrangleSaveItem.Enabled = false;
            this.quadrangleSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleSaveItem.Image")));
            this.quadrangleSaveItem.Name = "quadrangleSaveItem";
            this.quadrangleSaveItem.Size = new System.Drawing.Size(50, 22);
            this.quadrangleSaveItem.Text = "&Save";
            this.quadrangleSaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // quadrangleCancelItem
            // 
            this.quadrangleCancelItem.Enabled = false;
            this.quadrangleCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleCancelItem.Image")));
            this.quadrangleCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quadrangleCancelItem.Name = "quadrangleCancelItem";
            this.quadrangleCancelItem.Size = new System.Drawing.Size(61, 22);
            this.quadrangleCancelItem.Text = "&Cancel";
            this.quadrangleCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // quadrangleSeparator4
            // 
            this.quadrangleSeparator4.Name = "quadrangleSeparator4";
            this.quadrangleSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // quadrangleMergeItem
            // 
            this.quadrangleMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.quadrangleMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quadrangleMergeItem.Name = "quadrangleMergeItem";
            this.quadrangleMergeItem.Size = new System.Drawing.Size(60, 22);
            this.quadrangleMergeItem.Text = "&Merge";
            this.quadrangleMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // quadrangleChangeParentItem
            // 
            this.quadrangleChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("quadrangleChangeParentItem.Image")));
            this.quadrangleChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quadrangleChangeParentItem.Name = "quadrangleChangeParentItem";
            this.quadrangleChangeParentItem.Size = new System.Drawing.Size(104, 22);
            this.quadrangleChangeParentItem.Text = "&Change parent";
            this.quadrangleChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // tabPageSection
            // 
            this.tabPageSection.AutoScroll = true;
            this.tabPageSection.Controls.Add(this.panelSection);
            this.tabPageSection.Controls.Add(this.sectionBindingNavigator);
            this.tabPageSection.Location = new System.Drawing.Point(4, 4);
            this.tabPageSection.Name = "tabPageSection";
            this.tabPageSection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSection.Size = new System.Drawing.Size(784, 595);
            this.tabPageSection.TabIndex = 4;
            this.tabPageSection.Text = "Section";
            this.tabPageSection.UseVisualStyleBackColor = true;
            // 
            // panelSection
            // 
            this.panelSection.Controls.Add(sectionFormatLabel);
            this.panelSection.Controls.Add(sectionIdLabel);
            this.panelSection.Controls.Add(this.scaleTextBox);
            this.panelSection.Controls.Add(scaleLabel);
            this.panelSection.Controls.Add(this.sectionIdTextBox);
            this.panelSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSection.Location = new System.Drawing.Point(3, 28);
            this.panelSection.Name = "panelSection";
            this.panelSection.Size = new System.Drawing.Size(778, 564);
            this.panelSection.TabIndex = 15;
            // 
            // scaleTextBox
            // 
            this.scaleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource, "Scale", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.scaleTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.scaleTextBox.Location = new System.Drawing.Point(193, 111);
            this.scaleTextBox.Name = "scaleTextBox";
            this.scaleTextBox.Size = new System.Drawing.Size(100, 22);
            this.scaleTextBox.TabIndex = 13;
            // 
            // sectionIdTextBox
            // 
            this.sectionIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sectionBindingSource, "SectionId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sectionIdTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sectionIdTextBox.Location = new System.Drawing.Point(193, 81);
            this.sectionIdTextBox.Name = "sectionIdTextBox";
            this.sectionIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.sectionIdTextBox.TabIndex = 9;
            // 
            // sectionBindingNavigator
            // 
            this.sectionBindingNavigator.AddNewItem = null;
            this.sectionBindingNavigator.BindingSource = this.sectionBindingSource;
            this.sectionBindingNavigator.CountItem = this.sectionCountItem;
            this.sectionBindingNavigator.DeleteItem = null;
            this.sectionBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.sectionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectionMoveFirstItem,
            this.sectionMovePreviousItem,
            this.sectionSeparator1,
            this.sectionPositionItem,
            this.sectionCountItem,
            this.sectionSeparator2,
            this.sectionMoveNextItem,
            this.sectionMoveLastItem,
            this.sectionSeparator3,
            this.sectionAddNewItem,
            this.sectionDeleteItem,
            this.sectionSaveItem,
            this.sectionCancelItem,
            this.sectionSeparator4,
            this.sectionMergeItem,
            this.sectionChangeParentItem});
            this.sectionBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.sectionBindingNavigator.MoveFirstItem = this.sectionMoveFirstItem;
            this.sectionBindingNavigator.MoveLastItem = this.sectionMoveLastItem;
            this.sectionBindingNavigator.MoveNextItem = this.sectionMoveNextItem;
            this.sectionBindingNavigator.MovePreviousItem = this.sectionMovePreviousItem;
            this.sectionBindingNavigator.Name = "sectionBindingNavigator";
            this.sectionBindingNavigator.PositionItem = this.sectionPositionItem;
            this.sectionBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.sectionBindingNavigator.TabIndex = 14;
            this.sectionBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // sectionCountItem
            // 
            this.sectionCountItem.Name = "sectionCountItem";
            this.sectionCountItem.Size = new System.Drawing.Size(33, 22);
            this.sectionCountItem.Text = "of {0}";
            this.sectionCountItem.ToolTipText = "Total number of items";
            // 
            // sectionMoveFirstItem
            // 
            this.sectionMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionMoveFirstItem.Image")));
            this.sectionMoveFirstItem.Name = "sectionMoveFirstItem";
            this.sectionMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.sectionMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.sectionMoveFirstItem.Text = "Move first";
            // 
            // sectionMovePreviousItem
            // 
            this.sectionMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionMovePreviousItem.Image")));
            this.sectionMovePreviousItem.Name = "sectionMovePreviousItem";
            this.sectionMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.sectionMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.sectionMovePreviousItem.Text = "Move previous";
            // 
            // sectionSeparator1
            // 
            this.sectionSeparator1.Name = "sectionSeparator1";
            this.sectionSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // sectionPositionItem
            // 
            this.sectionPositionItem.AccessibleName = "Position";
            this.sectionPositionItem.AutoSize = false;
            this.sectionPositionItem.Name = "sectionPositionItem";
            this.sectionPositionItem.Size = new System.Drawing.Size(50, 21);
            this.sectionPositionItem.Text = "0";
            this.sectionPositionItem.ToolTipText = "Current position";
            // 
            // sectionSeparator2
            // 
            this.sectionSeparator2.Name = "sectionSeparator2";
            this.sectionSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // sectionMoveNextItem
            // 
            this.sectionMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionMoveNextItem.Image")));
            this.sectionMoveNextItem.Name = "sectionMoveNextItem";
            this.sectionMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.sectionMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.sectionMoveNextItem.Text = "Move next";
            // 
            // sectionMoveLastItem
            // 
            this.sectionMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sectionMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionMoveLastItem.Image")));
            this.sectionMoveLastItem.Name = "sectionMoveLastItem";
            this.sectionMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.sectionMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.sectionMoveLastItem.Text = "Move last";
            // 
            // sectionSeparator3
            // 
            this.sectionSeparator3.Name = "sectionSeparator3";
            this.sectionSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // sectionAddNewItem
            // 
            this.sectionAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionAddNewItem.Image")));
            this.sectionAddNewItem.Name = "sectionAddNewItem";
            this.sectionAddNewItem.RightToLeftAutoMirrorImage = true;
            this.sectionAddNewItem.Size = new System.Drawing.Size(48, 22);
            this.sectionAddNewItem.Text = "&Add";
            this.sectionAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // sectionDeleteItem
            // 
            this.sectionDeleteItem.Enabled = false;
            this.sectionDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionDeleteItem.Image")));
            this.sectionDeleteItem.Name = "sectionDeleteItem";
            this.sectionDeleteItem.RightToLeftAutoMirrorImage = true;
            this.sectionDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.sectionDeleteItem.Text = "&Delete";
            this.sectionDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // sectionSaveItem
            // 
            this.sectionSaveItem.Enabled = false;
            this.sectionSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionSaveItem.Image")));
            this.sectionSaveItem.Name = "sectionSaveItem";
            this.sectionSaveItem.Size = new System.Drawing.Size(50, 22);
            this.sectionSaveItem.Text = "&Save";
            this.sectionSaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // sectionCancelItem
            // 
            this.sectionCancelItem.Enabled = false;
            this.sectionCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionCancelItem.Image")));
            this.sectionCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sectionCancelItem.Name = "sectionCancelItem";
            this.sectionCancelItem.Size = new System.Drawing.Size(61, 22);
            this.sectionCancelItem.Text = "&Cancel";
            this.sectionCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // sectionSeparator4
            // 
            this.sectionSeparator4.Name = "sectionSeparator4";
            this.sectionSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // sectionMergeItem
            // 
            this.sectionMergeItem.Image = global::LSDMS.Properties.Resources.copy;
            this.sectionMergeItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sectionMergeItem.Name = "sectionMergeItem";
            this.sectionMergeItem.Size = new System.Drawing.Size(60, 22);
            this.sectionMergeItem.Text = "&Merge";
            this.sectionMergeItem.Click += new System.EventHandler(this.MergeItem_Click);
            // 
            // sectionChangeParentItem
            // 
            this.sectionChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("sectionChangeParentItem.Image")));
            this.sectionChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sectionChangeParentItem.Name = "sectionChangeParentItem";
            this.sectionChangeParentItem.Size = new System.Drawing.Size(104, 22);
            this.sectionChangeParentItem.Text = "&Change parent";
            this.sectionChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // tabPageLot
            // 
            this.tabPageLot.AutoScroll = true;
            this.tabPageLot.Controls.Add(this.tabControlLot);
            this.tabPageLot.Controls.Add(this.lotBindingNavigator);
            this.tabPageLot.Location = new System.Drawing.Point(4, 4);
            this.tabPageLot.Name = "tabPageLot";
            this.tabPageLot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLot.Size = new System.Drawing.Size(784, 595);
            this.tabPageLot.TabIndex = 5;
            this.tabPageLot.Text = "Lot";
            this.tabPageLot.UseVisualStyleBackColor = true;
            // 
            // tabControlLot
            // 
            this.tabControlLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlLot.Controls.Add(this.tabPageLotInfo);
            this.tabControlLot.Controls.Add(this.tabPageLotData);
            this.tabControlLot.Controls.Add(this.tabPageTechDesc);
            this.tabControlLot.Enabled = false;
            this.tabControlLot.Location = new System.Drawing.Point(3, 50);
            this.tabControlLot.Name = "tabControlLot";
            this.tabControlLot.SelectedIndex = 0;
            this.tabControlLot.Size = new System.Drawing.Size(778, 545);
            this.tabControlLot.TabIndex = 55;
            this.tabControlLot.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlLot_Selecting);
            // 
            // tabPageLotInfo
            // 
            this.tabPageLotInfo.AutoScroll = true;
            this.tabPageLotInfo.Controls.Add(this.lnkClaim);
            this.tabPageLotInfo.Controls.Add(this.txtEncoder);
            this.tabPageLotInfo.Controls.Add(lblEncoder);
            this.tabPageLotInfo.Controls.Add(geName2Label);
            this.tabPageLotInfo.Controls.Add(this.geName2TextBox);
            this.tabPageLotInfo.Controls.Add(this.surveyYearToTextBox);
            this.tabPageLotInfo.Controls.Add(this.surveyDayToTextBox);
            this.tabPageLotInfo.Controls.Add(this.surveyMonthToTextBox);
            this.tabPageLotInfo.Controls.Add(surveyDateToLabel);
            this.tabPageLotInfo.Controls.Add(this.surveyMonthFromTextBox);
            this.tabPageLotInfo.Controls.Add(this.surveyYearFromTextBox);
            this.tabPageLotInfo.Controls.Add(lblYear);
            this.tabPageLotInfo.Controls.Add(lblDay);
            this.tabPageLotInfo.Controls.Add(lblMonth);
            this.tabPageLotInfo.Controls.Add(this.surveyDayFromTextBox);
            this.tabPageLotInfo.Controls.Add(surveyDateFromLabel);
            this.tabPageLotInfo.Controls.Add(this.tabControlLotInfo);
            this.tabPageLotInfo.Controls.Add(this.lblReferencePoint);
            this.tabPageLotInfo.Controls.Add(lrcNoLabel);
            this.tabPageLotInfo.Controls.Add(this.lrcNoTextBox);
            this.tabPageLotInfo.Controls.Add(this.referencePointComboBox);
            this.tabPageLotInfo.Controls.Add(this.claimantAddressTextBox);
            this.tabPageLotInfo.Controls.Add(referencePointLabel);
            this.tabPageLotInfo.Controls.Add(declaredAreaLabel);
            this.tabPageLotInfo.Controls.Add(this.declaredAreaTextBox);
            this.tabPageLotInfo.Controls.Add(claimantAddressLabel);
            this.tabPageLotInfo.Controls.Add(computedAreaLabel);
            this.tabPageLotInfo.Controls.Add(tieLineNSLabel);
            this.tabPageLotInfo.Controls.Add(this.computedAreaTextBox);
            this.tabPageLotInfo.Controls.Add(this.tieLineNSTextBox);
            this.tabPageLotInfo.Controls.Add(this.claimantNameTextBox);
            this.tabPageLotInfo.Controls.Add(tieLineEWLabel);
            this.tabPageLotInfo.Controls.Add(this.tieLineEWTextBox);
            this.tabPageLotInfo.Controls.Add(claimantNameLabel);
            this.tabPageLotInfo.Controls.Add(tieLineDegreeLabel);
            this.tabPageLotInfo.Controls.Add(this.tieLineDegreeTextBox);
            this.tabPageLotInfo.Controls.Add(this.lotNoTextBox);
            this.tabPageLotInfo.Controls.Add(tieLineMinuteLabel);
            this.tabPageLotInfo.Controls.Add(this.tieLineMinuteTextBox);
            this.tabPageLotInfo.Controls.Add(lotNoLabel);
            this.tabPageLotInfo.Controls.Add(tieLineDistanceLabel);
            this.tabPageLotInfo.Controls.Add(this.tieLineDistanceTextBox);
            this.tabPageLotInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageLotInfo.Name = "tabPageLotInfo";
            this.tabPageLotInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLotInfo.Size = new System.Drawing.Size(770, 519);
            this.tabPageLotInfo.TabIndex = 0;
            this.tabPageLotInfo.Text = "Lot Information";
            this.tabPageLotInfo.UseVisualStyleBackColor = true;
            // 
            // lnkClaim
            // 
            this.lnkClaim.Location = new System.Drawing.Point(608, 271);
            this.lnkClaim.Name = "lnkClaim";
            this.lnkClaim.Size = new System.Drawing.Size(41, 20);
            this.lnkClaim.TabIndex = 75;
            this.lnkClaim.Text = "Claim";
            this.ToolTip.SetToolTip(this.lnkClaim, "Click this if you encoded this lot.");
            this.lnkClaim.Values.ExtraText = "";
            this.lnkClaim.Values.Image = null;
            this.lnkClaim.Values.Text = "Claim";
            this.lnkClaim.Visible = false;
            this.lnkClaim.LinkClicked += new System.EventHandler(this.lnkClaim_LinkClicked);
            // 
            // txtEncoder
            // 
            this.txtEncoder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEncoder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtEncoder.Location = new System.Drawing.Point(502, 268);
            this.txtEncoder.Name = "txtEncoder";
            this.txtEncoder.ReadOnly = true;
            this.txtEncoder.Size = new System.Drawing.Size(100, 22);
            this.txtEncoder.TabIndex = 74;
            this.txtEncoder.TabStop = false;
            this.txtEncoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // geName2TextBox
            // 
            this.geName2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "GEName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.geName2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.geName2TextBox.Location = new System.Drawing.Point(502, 100);
            this.geName2TextBox.Name = "geName2TextBox";
            this.geName2TextBox.Size = new System.Drawing.Size(212, 22);
            this.geName2TextBox.TabIndex = 14;
            // 
            // surveyYearToTextBox
            // 
            this.surveyYearToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyYearTo", true));
            this.surveyYearToTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyYearToTextBox.Location = new System.Drawing.Point(578, 72);
            this.surveyYearToTextBox.MaxLength = 4;
            this.surveyYearToTextBox.Name = "surveyYearToTextBox";
            this.surveyYearToTextBox.Size = new System.Drawing.Size(53, 22);
            this.surveyYearToTextBox.TabIndex = 13;
            this.surveyYearToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surveyDayToTextBox
            // 
            this.surveyDayToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyDayTo", true));
            this.surveyDayToTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyDayToTextBox.Location = new System.Drawing.Point(540, 72);
            this.surveyDayToTextBox.MaxLength = 2;
            this.surveyDayToTextBox.Name = "surveyDayToTextBox";
            this.surveyDayToTextBox.Size = new System.Drawing.Size(32, 22);
            this.surveyDayToTextBox.TabIndex = 12;
            this.surveyDayToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surveyMonthToTextBox
            // 
            this.surveyMonthToTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyMonthTo", true));
            this.surveyMonthToTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyMonthToTextBox.Location = new System.Drawing.Point(502, 72);
            this.surveyMonthToTextBox.MaxLength = 2;
            this.surveyMonthToTextBox.Name = "surveyMonthToTextBox";
            this.surveyMonthToTextBox.Size = new System.Drawing.Size(32, 22);
            this.surveyMonthToTextBox.TabIndex = 11;
            this.surveyMonthToTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surveyMonthFromTextBox
            // 
            this.surveyMonthFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyMonthFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surveyMonthFromTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyMonthFromTextBox.Location = new System.Drawing.Point(502, 44);
            this.surveyMonthFromTextBox.MaxLength = 2;
            this.surveyMonthFromTextBox.Name = "surveyMonthFromTextBox";
            this.surveyMonthFromTextBox.Size = new System.Drawing.Size(32, 22);
            this.surveyMonthFromTextBox.TabIndex = 8;
            this.surveyMonthFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surveyYearFromTextBox
            // 
            this.surveyYearFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyYearFrom", true));
            this.surveyYearFromTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyYearFromTextBox.Location = new System.Drawing.Point(578, 44);
            this.surveyYearFromTextBox.MaxLength = 4;
            this.surveyYearFromTextBox.Name = "surveyYearFromTextBox";
            this.surveyYearFromTextBox.Size = new System.Drawing.Size(53, 22);
            this.surveyYearFromTextBox.TabIndex = 10;
            this.surveyYearFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surveyDayFromTextBox
            // 
            this.surveyDayFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "SurveyDayFrom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.surveyDayFromTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.surveyDayFromTextBox.Location = new System.Drawing.Point(540, 44);
            this.surveyDayFromTextBox.MaxLength = 2;
            this.surveyDayFromTextBox.Name = "surveyDayFromTextBox";
            this.surveyDayFromTextBox.Size = new System.Drawing.Size(32, 22);
            this.surveyDayFromTextBox.TabIndex = 9;
            this.surveyDayFromTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControlLotInfo
            // 
            this.tabControlLotInfo.Controls.Add(this.tabPageRemarks);
            this.tabControlLotInfo.Controls.Add(this.tabPageValidation);
            this.tabControlLotInfo.Location = new System.Drawing.Point(82, 302);
            this.tabControlLotInfo.Multiline = true;
            this.tabControlLotInfo.Name = "tabControlLotInfo";
            this.tabControlLotInfo.SelectedIndex = 0;
            this.tabControlLotInfo.Size = new System.Drawing.Size(650, 199);
            this.tabControlLotInfo.TabIndex = 59;
            // 
            // tabPageRemarks
            // 
            this.tabPageRemarks.Controls.Add(this.lotRemarksTextBox);
            this.tabPageRemarks.Location = new System.Drawing.Point(4, 22);
            this.tabPageRemarks.Name = "tabPageRemarks";
            this.tabPageRemarks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemarks.Size = new System.Drawing.Size(642, 173);
            this.tabPageRemarks.TabIndex = 0;
            this.tabPageRemarks.Text = "Remarks";
            this.tabPageRemarks.UseVisualStyleBackColor = true;
            // 
            // lotRemarksTextBox
            // 
            this.lotRemarksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "Remarks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lotRemarksTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotRemarksTextBox.Location = new System.Drawing.Point(3, 3);
            this.lotRemarksTextBox.MaxLength = 500;
            this.lotRemarksTextBox.Multiline = true;
            this.lotRemarksTextBox.Name = "lotRemarksTextBox";
            this.lotRemarksTextBox.Size = new System.Drawing.Size(636, 167);
            this.lotRemarksTextBox.TabIndex = 19;
            // 
            // tabPageValidation
            // 
            this.tabPageValidation.Controls.Add(originalCheckedByLabel);
            this.tabPageValidation.Controls.Add(this.originalCompletedDateTextBox);
            this.tabPageValidation.Controls.Add(originalCompletedDateLabel);
            this.tabPageValidation.Controls.Add(this.originalCompletedByTextBox);
            this.tabPageValidation.Controls.Add(this.finalCheckedBy2TextBox);
            this.tabPageValidation.Controls.Add(originalCompletedByLabel);
            this.tabPageValidation.Controls.Add(finalCheckedBy2Label);
            this.tabPageValidation.Controls.Add(duplicateCheckedByLabel);
            this.tabPageValidation.Controls.Add(this.finalCheckedBy1TextBox);
            this.tabPageValidation.Controls.Add(this.originalCheckedDateTextBox);
            this.tabPageValidation.Controls.Add(this.duplicateCheckedByTextBox);
            this.tabPageValidation.Controls.Add(finalCheckedBy1Label);
            this.tabPageValidation.Controls.Add(duplicateCheckedDateLabel);
            this.tabPageValidation.Controls.Add(this.finalVerifiedByTextBox);
            this.tabPageValidation.Controls.Add(this.duplicateCheckedDateTextBox);
            this.tabPageValidation.Controls.Add(originalCheckedDateLabel);
            this.tabPageValidation.Controls.Add(this.originalCheckedByTextBox);
            this.tabPageValidation.Controls.Add(finalVerifiedByLabel);
            this.tabPageValidation.Location = new System.Drawing.Point(4, 22);
            this.tabPageValidation.Name = "tabPageValidation";
            this.tabPageValidation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageValidation.Size = new System.Drawing.Size(642, 173);
            this.tabPageValidation.TabIndex = 1;
            this.tabPageValidation.Text = "Validation";
            this.tabPageValidation.UseVisualStyleBackColor = true;
            // 
            // originalCompletedDateTextBox
            // 
            this.originalCompletedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "OriginalCompletedDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalCompletedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.originalCompletedDateTextBox.Location = new System.Drawing.Point(144, 93);
            this.originalCompletedDateTextBox.Name = "originalCompletedDateTextBox";
            this.originalCompletedDateTextBox.Size = new System.Drawing.Size(150, 22);
            this.originalCompletedDateTextBox.TabIndex = 23;
            // 
            // originalCompletedByTextBox
            // 
            this.originalCompletedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "OriginalCompletedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalCompletedByTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.originalCompletedByTextBox.Location = new System.Drawing.Point(144, 67);
            this.originalCompletedByTextBox.Name = "originalCompletedByTextBox";
            this.originalCompletedByTextBox.Size = new System.Drawing.Size(150, 22);
            this.originalCompletedByTextBox.TabIndex = 22;
            // 
            // finalCheckedBy2TextBox
            // 
            this.finalCheckedBy2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "FinalCheckedBy2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.finalCheckedBy2TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.finalCheckedBy2TextBox.Location = new System.Drawing.Point(478, 119);
            this.finalCheckedBy2TextBox.Name = "finalCheckedBy2TextBox";
            this.finalCheckedBy2TextBox.Size = new System.Drawing.Size(150, 22);
            this.finalCheckedBy2TextBox.TabIndex = 28;
            // 
            // finalCheckedBy1TextBox
            // 
            this.finalCheckedBy1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "FinalCheckedBy1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.finalCheckedBy1TextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.finalCheckedBy1TextBox.Location = new System.Drawing.Point(478, 93);
            this.finalCheckedBy1TextBox.Name = "finalCheckedBy1TextBox";
            this.finalCheckedBy1TextBox.Size = new System.Drawing.Size(150, 22);
            this.finalCheckedBy1TextBox.TabIndex = 27;
            // 
            // originalCheckedDateTextBox
            // 
            this.originalCheckedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "OriginalCheckedDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalCheckedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.originalCheckedDateTextBox.Location = new System.Drawing.Point(144, 41);
            this.originalCheckedDateTextBox.Name = "originalCheckedDateTextBox";
            this.originalCheckedDateTextBox.Size = new System.Drawing.Size(150, 22);
            this.originalCheckedDateTextBox.TabIndex = 21;
            // 
            // duplicateCheckedByTextBox
            // 
            this.duplicateCheckedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "DuplicateCheckedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.duplicateCheckedByTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.duplicateCheckedByTextBox.Location = new System.Drawing.Point(478, 15);
            this.duplicateCheckedByTextBox.Name = "duplicateCheckedByTextBox";
            this.duplicateCheckedByTextBox.Size = new System.Drawing.Size(150, 22);
            this.duplicateCheckedByTextBox.TabIndex = 24;
            // 
            // finalVerifiedByTextBox
            // 
            this.finalVerifiedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "FinalVerifiedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.finalVerifiedByTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.finalVerifiedByTextBox.Location = new System.Drawing.Point(478, 67);
            this.finalVerifiedByTextBox.Name = "finalVerifiedByTextBox";
            this.finalVerifiedByTextBox.Size = new System.Drawing.Size(150, 22);
            this.finalVerifiedByTextBox.TabIndex = 26;
            // 
            // duplicateCheckedDateTextBox
            // 
            this.duplicateCheckedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "DuplicateCheckedDate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.duplicateCheckedDateTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.duplicateCheckedDateTextBox.Location = new System.Drawing.Point(478, 41);
            this.duplicateCheckedDateTextBox.Name = "duplicateCheckedDateTextBox";
            this.duplicateCheckedDateTextBox.Size = new System.Drawing.Size(150, 22);
            this.duplicateCheckedDateTextBox.TabIndex = 25;
            // 
            // originalCheckedByTextBox
            // 
            this.originalCheckedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "OriginalCheckedBy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.originalCheckedByTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.originalCheckedByTextBox.Location = new System.Drawing.Point(144, 15);
            this.originalCheckedByTextBox.Name = "originalCheckedByTextBox";
            this.originalCheckedByTextBox.Size = new System.Drawing.Size(150, 22);
            this.originalCheckedByTextBox.TabIndex = 20;
            // 
            // lblReferencePoint
            // 
            this.lblReferencePoint.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencePoint.ForeColor = System.Drawing.Color.Gray;
            this.lblReferencePoint.Location = new System.Drawing.Point(232, 94);
            this.lblReferencePoint.Name = "lblReferencePoint";
            this.lblReferencePoint.Size = new System.Drawing.Size(137, 30);
            this.lblReferencePoint.TabIndex = 58;
            this.lblReferencePoint.Text = "coords";
            // 
            // lrcNoTextBox
            // 
            this.lrcNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "LRCNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lrcNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lrcNoTextBox.Location = new System.Drawing.Point(219, 44);
            this.lrcNoTextBox.Name = "lrcNoTextBox";
            this.lrcNoTextBox.Size = new System.Drawing.Size(100, 22);
            this.lrcNoTextBox.TabIndex = 2;
            // 
            // referencePointComboBox
            // 
            this.referencePointComboBox.DisplayMember = "ReferencePoint";
            this.referencePointComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referencePointComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.referencePointComboBox.FormattingEnabled = true;
            this.referencePointComboBox.Location = new System.Drawing.Point(219, 70);
            this.referencePointComboBox.Name = "referencePointComboBox";
            this.referencePointComboBox.Size = new System.Drawing.Size(102, 21);
            this.referencePointComboBox.TabIndex = 2;
            this.ToolTip.SetToolTip(this.referencePointComboBox, "Reference Point must be encoded in GNIS");
            this.referencePointComboBox.ValueMember = "ReferencePoint";
            // 
            // claimantAddressTextBox
            // 
            this.claimantAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "ClaimantAddress", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.claimantAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.claimantAddressTextBox.Location = new System.Drawing.Point(502, 164);
            this.claimantAddressTextBox.Multiline = true;
            this.claimantAddressTextBox.Name = "claimantAddressTextBox";
            this.claimantAddressTextBox.Size = new System.Drawing.Size(212, 42);
            this.claimantAddressTextBox.TabIndex = 16;
            // 
            // declaredAreaTextBox
            // 
            this.declaredAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "DeclaredArea", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.declaredAreaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.declaredAreaTextBox.Location = new System.Drawing.Point(502, 212);
            this.declaredAreaTextBox.Name = "declaredAreaTextBox";
            this.declaredAreaTextBox.Size = new System.Drawing.Size(100, 22);
            this.declaredAreaTextBox.TabIndex = 17;
            this.declaredAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // computedAreaTextBox
            // 
            this.computedAreaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "ComputedArea", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.computedAreaTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.computedAreaTextBox.Location = new System.Drawing.Point(502, 240);
            this.computedAreaTextBox.Name = "computedAreaTextBox";
            this.computedAreaTextBox.ReadOnly = true;
            this.computedAreaTextBox.Size = new System.Drawing.Size(100, 22);
            this.computedAreaTextBox.TabIndex = 18;
            this.computedAreaTextBox.TabStop = false;
            this.computedAreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tieLineNSTextBox
            // 
            this.tieLineNSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "TieLineNS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tieLineNSTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tieLineNSTextBox.Location = new System.Drawing.Point(219, 127);
            this.tieLineNSTextBox.MaxLength = 1;
            this.tieLineNSTextBox.Name = "tieLineNSTextBox";
            this.tieLineNSTextBox.Size = new System.Drawing.Size(32, 22);
            this.tieLineNSTextBox.TabIndex = 3;
            // 
            // claimantNameTextBox
            // 
            this.claimantNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "ClaimantName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.claimantNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.claimantNameTextBox.Location = new System.Drawing.Point(502, 136);
            this.claimantNameTextBox.Name = "claimantNameTextBox";
            this.claimantNameTextBox.Size = new System.Drawing.Size(212, 22);
            this.claimantNameTextBox.TabIndex = 15;
            // 
            // tieLineEWTextBox
            // 
            this.tieLineEWTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "TieLineEW", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tieLineEWTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tieLineEWTextBox.Location = new System.Drawing.Point(219, 153);
            this.tieLineEWTextBox.MaxLength = 1;
            this.tieLineEWTextBox.Name = "tieLineEWTextBox";
            this.tieLineEWTextBox.Size = new System.Drawing.Size(32, 22);
            this.tieLineEWTextBox.TabIndex = 4;
            // 
            // tieLineDegreeTextBox
            // 
            this.tieLineDegreeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "TieLineDegree", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tieLineDegreeTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tieLineDegreeTextBox.Location = new System.Drawing.Point(219, 179);
            this.tieLineDegreeTextBox.Name = "tieLineDegreeTextBox";
            this.tieLineDegreeTextBox.Size = new System.Drawing.Size(100, 22);
            this.tieLineDegreeTextBox.TabIndex = 5;
            this.tieLineDegreeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lotNoTextBox
            // 
            this.lotNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "LotNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lotNoTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lotNoTextBox.Location = new System.Drawing.Point(219, 18);
            this.lotNoTextBox.Name = "lotNoTextBox";
            this.lotNoTextBox.Size = new System.Drawing.Size(150, 22);
            this.lotNoTextBox.TabIndex = 1;
            // 
            // tieLineMinuteTextBox
            // 
            this.tieLineMinuteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "TieLineMinute", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tieLineMinuteTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tieLineMinuteTextBox.Location = new System.Drawing.Point(219, 205);
            this.tieLineMinuteTextBox.Name = "tieLineMinuteTextBox";
            this.tieLineMinuteTextBox.Size = new System.Drawing.Size(100, 22);
            this.tieLineMinuteTextBox.TabIndex = 6;
            this.tieLineMinuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tieLineDistanceTextBox
            // 
            this.tieLineDistanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lotBindingSource, "TieLineDistance", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tieLineDistanceTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tieLineDistanceTextBox.Location = new System.Drawing.Point(219, 231);
            this.tieLineDistanceTextBox.Name = "tieLineDistanceTextBox";
            this.tieLineDistanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.tieLineDistanceTextBox.TabIndex = 7;
            this.tieLineDistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPageLotData
            // 
            this.tabPageLotData.AutoScroll = true;
            this.tabPageLotData.Controls.Add(this.splitContainerLotData);
            this.tabPageLotData.Location = new System.Drawing.Point(4, 22);
            this.tabPageLotData.Name = "tabPageLotData";
            this.tabPageLotData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLotData.Size = new System.Drawing.Size(770, 519);
            this.tabPageLotData.TabIndex = 1;
            this.tabPageLotData.Text = "Lot Data";
            this.tabPageLotData.UseVisualStyleBackColor = true;
            // 
            // splitContainerLotData
            // 
            this.splitContainerLotData.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerLotData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLotData.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLotData.Name = "splitContainerLotData";
            this.splitContainerLotData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLotData.Panel1
            // 
            this.splitContainerLotData.Panel1.Controls.Add(this.lotDataGridView);
            // 
            // splitContainerLotData.Panel2
            // 
            this.splitContainerLotData.Panel2.Controls.Add(this.btnZoomSelectedLotData);
            this.splitContainerLotData.Panel2.Controls.Add(this.btnZoomSelectedLotDatax);
            this.splitContainerLotData.Panel2.Controls.Add(this.btnZoomToExtentLotData);
            this.splitContainerLotData.Panel2.Controls.Add(this.btnZoomOutLotData);
            this.splitContainerLotData.Panel2.Controls.Add(this.btnZoomInLotData);
            this.splitContainerLotData.Panel2.Controls.Add(this.mapImageLotData);
            this.splitContainerLotData.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.splitContainerLotData.Size = new System.Drawing.Size(764, 513);
            this.splitContainerLotData.SplitterDistance = 254;
            this.splitContainerLotData.TabIndex = 56;
            this.splitContainerLotData.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerLot_SplitterMoved);
            // 
            // lotDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.lotDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lotDataGridView.AutoGenerateColumns = false;
            this.lotDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.lotDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sequence,
            this.Northing,
            this.Easting,
            this.PrsY,
            this.PrsX,
            this.LocalY,
            this.LocalX,
            this.NS,
            this.Degree,
            this.Minute,
            this.EW,
            this.Distance});
            this.lotDataGridView.DataSource = this.lotDataBindingSource;
            this.lotDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lotDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lotDataGridView.Name = "lotDataGridView";
            this.lotDataGridView.RowHeadersWidth = 30;
            this.lotDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lotDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.lotDataGridView.Size = new System.Drawing.Size(764, 254);
            this.lotDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.lotDataGridView.TabIndex = 1;
            // 
            // lotDataBindingSource
            // 
            this.lotDataBindingSource.DataMember = "FK_LotData_Lot";
            this.lotDataBindingSource.DataSource = this.lotBindingSource;
            // 
            // btnZoomSelectedLotData
            // 
            this.btnZoomSelectedLotData.Checked = true;
            this.btnZoomSelectedLotData.Location = new System.Drawing.Point(15, 154);
            this.btnZoomSelectedLotData.Name = "btnZoomSelectedLotData";
            this.btnZoomSelectedLotData.Size = new System.Drawing.Size(99, 40);
            this.btnZoomSelectedLotData.TabIndex = 14;
            this.btnZoomSelectedLotData.Text = "Selection";
            this.btnZoomSelectedLotData.Values.ExtraText = "";
            this.btnZoomSelectedLotData.Values.Image = global::LSDMS.Properties.Resources.zoomLot;
            this.btnZoomSelectedLotData.Values.Text = "Selection";
            this.btnZoomSelectedLotData.Click += new System.EventHandler(this.btnZoomSelectedLotData_Click);
            // 
            // btnZoomSelectedLotDatax
            // 
            this.btnZoomSelectedLotDatax.Location = new System.Drawing.Point(15, 199);
            this.btnZoomSelectedLotDatax.Name = "btnZoomSelectedLotDatax";
            this.btnZoomSelectedLotDatax.Size = new System.Drawing.Size(99, 40);
            this.btnZoomSelectedLotDatax.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomSelectedLotDatax.TabIndex = 12;
            this.btnZoomSelectedLotDatax.Text = "Selection";
            this.btnZoomSelectedLotDatax.Values.ExtraText = "";
            this.btnZoomSelectedLotDatax.Values.Image = global::LSDMS.Properties.Resources.zoomLot;
            this.btnZoomSelectedLotDatax.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomSelectedLotDatax.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomSelectedLotDatax.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomSelectedLotDatax.Values.Text = "Selection";
            this.btnZoomSelectedLotDatax.Visible = false;
            this.btnZoomSelectedLotDatax.Click += new System.EventHandler(this.btnZoomSelectedLotData_Click);
            // 
            // btnZoomToExtentLotData
            // 
            this.btnZoomToExtentLotData.Location = new System.Drawing.Point(15, 108);
            this.btnZoomToExtentLotData.Name = "btnZoomToExtentLotData";
            this.btnZoomToExtentLotData.Size = new System.Drawing.Size(99, 40);
            this.btnZoomToExtentLotData.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomToExtentLotData.TabIndex = 11;
            this.btnZoomToExtentLotData.Text = "Extent";
            this.btnZoomToExtentLotData.Values.ExtraText = "";
            this.btnZoomToExtentLotData.Values.Image = global::LSDMS.Properties.Resources.zoomExtent;
            this.btnZoomToExtentLotData.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomToExtentLotData.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomToExtentLotData.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomToExtentLotData.Values.Text = "Extent";
            this.btnZoomToExtentLotData.Click += new System.EventHandler(this.btnZoomToExtentLotData_Click);
            // 
            // btnZoomOutLotData
            // 
            this.btnZoomOutLotData.Location = new System.Drawing.Point(15, 62);
            this.btnZoomOutLotData.Name = "btnZoomOutLotData";
            this.btnZoomOutLotData.Size = new System.Drawing.Size(99, 40);
            this.btnZoomOutLotData.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomOutLotData.TabIndex = 10;
            this.btnZoomOutLotData.Text = "Zoom Out";
            this.btnZoomOutLotData.Values.ExtraText = "";
            this.btnZoomOutLotData.Values.Image = global::LSDMS.Properties.Resources.zoomOut;
            this.btnZoomOutLotData.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomOutLotData.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomOutLotData.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomOutLotData.Values.Text = "Zoom Out";
            this.btnZoomOutLotData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutLotData_MouseDown);
            this.btnZoomOutLotData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutLotData_MouseUp);
            // 
            // btnZoomInLotData
            // 
            this.btnZoomInLotData.Location = new System.Drawing.Point(15, 16);
            this.btnZoomInLotData.Name = "btnZoomInLotData";
            this.btnZoomInLotData.Size = new System.Drawing.Size(99, 40);
            this.btnZoomInLotData.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomInLotData.StateNormal.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomInLotData.TabIndex = 9;
            this.btnZoomInLotData.Text = "Zoom In";
            this.btnZoomInLotData.Values.ExtraText = "";
            this.btnZoomInLotData.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomInLotData.Values.Image")));
            this.btnZoomInLotData.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomInLotData.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomInLotData.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomInLotData.Values.Text = "Zoom In";
            this.btnZoomInLotData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomInLotData_MouseDown);
            this.btnZoomInLotData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomInLotData_MouseUp);
            // 
            // mapImageLotData
            // 
            this.mapImageLotData.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapImageLotData.BackColor = System.Drawing.Color.White;
            this.mapImageLotData.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapImageLotData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapImageLotData.FineZoomFactor = 10;
            this.mapImageLotData.Location = new System.Drawing.Point(0, 0);
            this.mapImageLotData.Name = "mapImageLotData";
            this.mapImageLotData.QueryLayerIndex = 0;
            this.mapImageLotData.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapImageLotData.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapImageLotData.Size = new System.Drawing.Size(764, 254);
            this.mapImageLotData.TabIndex = 13;
            this.mapImageLotData.Text = "mapBox1";
            this.mapImageLotData.WheelZoomMagnitude = 2;
            // 
            // tabPageTechDesc
            // 
            this.tabPageTechDesc.AutoScroll = true;
            this.tabPageTechDesc.Controls.Add(this.splitContainerTechDesc);
            this.tabPageTechDesc.Location = new System.Drawing.Point(4, 22);
            this.tabPageTechDesc.Name = "tabPageTechDesc";
            this.tabPageTechDesc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTechDesc.Size = new System.Drawing.Size(770, 519);
            this.tabPageTechDesc.TabIndex = 2;
            this.tabPageTechDesc.Text = "Technical Description";
            this.tabPageTechDesc.UseVisualStyleBackColor = true;
            // 
            // splitContainerTechDesc
            // 
            this.splitContainerTechDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainerTechDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTechDesc.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTechDesc.Name = "splitContainerTechDesc";
            this.splitContainerTechDesc.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTechDesc.Panel1
            // 
            this.splitContainerTechDesc.Panel1.Controls.Add(this.techDescGridView);
            // 
            // splitContainerTechDesc.Panel2
            // 
            this.splitContainerTechDesc.Panel2.Controls.Add(this.btnZoomToExtentTechDesc);
            this.splitContainerTechDesc.Panel2.Controls.Add(this.btnZoomOutTechDesc);
            this.splitContainerTechDesc.Panel2.Controls.Add(this.btnZoomInTechDesc);
            this.splitContainerTechDesc.Panel2.Controls.Add(this.mapImageTechDesc);
            this.splitContainerTechDesc.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.HighProfile;
            this.splitContainerTechDesc.Size = new System.Drawing.Size(764, 513);
            this.splitContainerTechDesc.SplitterDistance = 254;
            this.splitContainerTechDesc.TabIndex = 57;
            // 
            // techDescGridView
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.techDescGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.techDescGridView.AutoGenerateColumns = false;
            this.techDescGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.techDescFromColumn,
            this.techDescToColumn,
            this.techDescNSColumn,
            this.techDescDegreeColumn,
            this.techDescMinuteColumn,
            this.techDescEWColumn,
            this.techDescDistanceColumn});
            this.techDescGridView.DataSource = this.techDescBindingSource;
            this.techDescGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techDescGridView.Location = new System.Drawing.Point(0, 0);
            this.techDescGridView.Name = "techDescGridView";
            this.techDescGridView.RowHeadersWidth = 30;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.techDescGridView.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.techDescGridView.Size = new System.Drawing.Size(764, 254);
            this.techDescGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.techDescGridView.TabIndex = 3;
            // 
            // techDescFromColumn
            // 
            this.techDescFromColumn.DataPropertyName = "FromCorner";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.techDescFromColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.techDescFromColumn.HeaderText = "From";
            this.techDescFromColumn.Name = "techDescFromColumn";
            this.techDescFromColumn.Width = 50;
            // 
            // techDescToColumn
            // 
            this.techDescToColumn.DataPropertyName = "ToCorner";
            this.techDescToColumn.HeaderText = "To";
            this.techDescToColumn.Name = "techDescToColumn";
            this.techDescToColumn.Width = 50;
            // 
            // techDescNSColumn
            // 
            this.techDescNSColumn.DataPropertyName = "NS";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.techDescNSColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.techDescNSColumn.HeaderText = "NS";
            this.techDescNSColumn.Name = "techDescNSColumn";
            this.techDescNSColumn.Width = 50;
            // 
            // techDescDegreeColumn
            // 
            this.techDescDegreeColumn.DataPropertyName = "Degree";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.techDescDegreeColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.techDescDegreeColumn.HeaderText = "Degree";
            this.techDescDegreeColumn.Name = "techDescDegreeColumn";
            this.techDescDegreeColumn.Width = 50;
            // 
            // techDescMinuteColumn
            // 
            this.techDescMinuteColumn.DataPropertyName = "Minute";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.techDescMinuteColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.techDescMinuteColumn.HeaderText = "Minute";
            this.techDescMinuteColumn.Name = "techDescMinuteColumn";
            this.techDescMinuteColumn.Width = 50;
            // 
            // techDescEWColumn
            // 
            this.techDescEWColumn.DataPropertyName = "EW";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.techDescEWColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.techDescEWColumn.HeaderText = "EW";
            this.techDescEWColumn.Name = "techDescEWColumn";
            this.techDescEWColumn.Width = 50;
            // 
            // techDescDistanceColumn
            // 
            this.techDescDistanceColumn.DataPropertyName = "Distance";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.techDescDistanceColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.techDescDistanceColumn.HeaderText = "Distance (m)";
            this.techDescDistanceColumn.Name = "techDescDistanceColumn";
            // 
            // techDescBindingSource
            // 
            this.techDescBindingSource.DataMember = "FK_TechDesc_Lot";
            this.techDescBindingSource.DataSource = this.lotBindingSource;
            // 
            // btnZoomToExtentTechDesc
            // 
            this.btnZoomToExtentTechDesc.Location = new System.Drawing.Point(15, 108);
            this.btnZoomToExtentTechDesc.Name = "btnZoomToExtentTechDesc";
            this.btnZoomToExtentTechDesc.Size = new System.Drawing.Size(99, 40);
            this.btnZoomToExtentTechDesc.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomToExtentTechDesc.TabIndex = 14;
            this.btnZoomToExtentTechDesc.Text = "Extent";
            this.btnZoomToExtentTechDesc.Values.ExtraText = "";
            this.btnZoomToExtentTechDesc.Values.Image = global::LSDMS.Properties.Resources.zoomExtent;
            this.btnZoomToExtentTechDesc.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomToExtentTechDesc.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomToExtentTechDesc.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomToExtentTechDesc.Values.Text = "Extent";
            this.btnZoomToExtentTechDesc.Click += new System.EventHandler(this.btnZoomToExtentTechDesc_Click);
            // 
            // btnZoomOutTechDesc
            // 
            this.btnZoomOutTechDesc.Location = new System.Drawing.Point(15, 62);
            this.btnZoomOutTechDesc.Name = "btnZoomOutTechDesc";
            this.btnZoomOutTechDesc.Size = new System.Drawing.Size(99, 40);
            this.btnZoomOutTechDesc.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomOutTechDesc.TabIndex = 13;
            this.btnZoomOutTechDesc.Text = "Zoom Out";
            this.btnZoomOutTechDesc.Values.ExtraText = "";
            this.btnZoomOutTechDesc.Values.Image = global::LSDMS.Properties.Resources.zoomOut;
            this.btnZoomOutTechDesc.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomOutTechDesc.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomOutTechDesc.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomOutTechDesc.Values.Text = "Zoom Out";
            this.btnZoomOutTechDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutTechDesc_MouseDown);
            this.btnZoomOutTechDesc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomOutTechDesc_MouseUp);
            // 
            // btnZoomInTechDesc
            // 
            this.btnZoomInTechDesc.Location = new System.Drawing.Point(15, 16);
            this.btnZoomInTechDesc.Name = "btnZoomInTechDesc";
            this.btnZoomInTechDesc.Size = new System.Drawing.Size(99, 40);
            this.btnZoomInTechDesc.StateCommon.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomInTechDesc.StateNormal.Content.Image.ImageH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnZoomInTechDesc.TabIndex = 12;
            this.btnZoomInTechDesc.Text = "Zoom In";
            this.btnZoomInTechDesc.Values.ExtraText = "";
            this.btnZoomInTechDesc.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomInTechDesc.Values.Image")));
            this.btnZoomInTechDesc.Values.ImageStates.ImageCheckedNormal = null;
            this.btnZoomInTechDesc.Values.ImageStates.ImageCheckedPressed = null;
            this.btnZoomInTechDesc.Values.ImageStates.ImageCheckedTracking = null;
            this.btnZoomInTechDesc.Values.Text = "Zoom In";
            this.btnZoomInTechDesc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomInTechDesc_MouseDown);
            this.btnZoomInTechDesc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnZoomInTechDesc_MouseUp);
            // 
            // mapImageTechDesc
            // 
            this.mapImageTechDesc.ActiveTool = SharpMap.Forms.MapBox.Tools.None;
            this.mapImageTechDesc.BackColor = System.Drawing.Color.White;
            this.mapImageTechDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapImageTechDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapImageTechDesc.FineZoomFactor = 10;
            this.mapImageTechDesc.Location = new System.Drawing.Point(0, 0);
            this.mapImageTechDesc.Name = "mapImageTechDesc";
            this.mapImageTechDesc.QueryLayerIndex = 0;
            this.mapImageTechDesc.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapImageTechDesc.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.mapImageTechDesc.Size = new System.Drawing.Size(764, 254);
            this.mapImageTechDesc.TabIndex = 15;
            this.mapImageTechDesc.Text = "mapBox1";
            this.mapImageTechDesc.WheelZoomMagnitude = 2;
            // 
            // lotBindingNavigator
            // 
            this.lotBindingNavigator.AddNewItem = null;
            this.lotBindingNavigator.BindingSource = this.lotBindingSource;
            this.lotBindingNavigator.CountItem = this.lotCountItem;
            this.lotBindingNavigator.DeleteItem = null;
            this.lotBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lotBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lotMoveFirstItem,
            this.lotMovePreviousItem,
            this.lotSeparator1,
            this.lotPositionItem,
            this.lotCountItem,
            this.lotSeparator2,
            this.lotMoveNextItem,
            this.lotMoveLastItem,
            this.lotSeparator3,
            this.lotAddNewItem,
            this.lotDeleteItem,
            this.lotSaveItem,
            this.lotCancelItem,
            this.lotSeparator4,
            this.lotChangeParentItem});
            this.lotBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.lotBindingNavigator.MoveFirstItem = this.lotMoveFirstItem;
            this.lotBindingNavigator.MoveLastItem = this.lotMoveLastItem;
            this.lotBindingNavigator.MoveNextItem = this.lotMoveNextItem;
            this.lotBindingNavigator.MovePreviousItem = this.lotMovePreviousItem;
            this.lotBindingNavigator.Name = "lotBindingNavigator";
            this.lotBindingNavigator.PositionItem = this.lotPositionItem;
            this.lotBindingNavigator.Size = new System.Drawing.Size(778, 25);
            this.lotBindingNavigator.TabIndex = 54;
            this.lotBindingNavigator.Text = "cadSurveyBindingNavigator";
            // 
            // lotCountItem
            // 
            this.lotCountItem.Name = "lotCountItem";
            this.lotCountItem.Size = new System.Drawing.Size(35, 22);
            this.lotCountItem.Text = "of {0}";
            this.lotCountItem.ToolTipText = "Total number of items";
            // 
            // lotMoveFirstItem
            // 
            this.lotMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lotMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("lotMoveFirstItem.Image")));
            this.lotMoveFirstItem.Name = "lotMoveFirstItem";
            this.lotMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.lotMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.lotMoveFirstItem.Text = "Move first";
            // 
            // lotMovePreviousItem
            // 
            this.lotMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lotMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("lotMovePreviousItem.Image")));
            this.lotMovePreviousItem.Name = "lotMovePreviousItem";
            this.lotMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.lotMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.lotMovePreviousItem.Text = "Move previous";
            // 
            // lotSeparator1
            // 
            this.lotSeparator1.Name = "lotSeparator1";
            this.lotSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // lotPositionItem
            // 
            this.lotPositionItem.AccessibleName = "Position";
            this.lotPositionItem.AutoSize = false;
            this.lotPositionItem.Name = "lotPositionItem";
            this.lotPositionItem.Size = new System.Drawing.Size(50, 21);
            this.lotPositionItem.Text = "0";
            this.lotPositionItem.ToolTipText = "Current position";
            // 
            // lotSeparator2
            // 
            this.lotSeparator2.Name = "lotSeparator2";
            this.lotSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lotMoveNextItem
            // 
            this.lotMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lotMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("lotMoveNextItem.Image")));
            this.lotMoveNextItem.Name = "lotMoveNextItem";
            this.lotMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.lotMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.lotMoveNextItem.Text = "Move next";
            // 
            // lotMoveLastItem
            // 
            this.lotMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lotMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("lotMoveLastItem.Image")));
            this.lotMoveLastItem.Name = "lotMoveLastItem";
            this.lotMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.lotMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.lotMoveLastItem.Text = "Move last";
            // 
            // lotSeparator3
            // 
            this.lotSeparator3.Name = "lotSeparator3";
            this.lotSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // lotAddNewItem
            // 
            this.lotAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("lotAddNewItem.Image")));
            this.lotAddNewItem.Name = "lotAddNewItem";
            this.lotAddNewItem.RightToLeftAutoMirrorImage = true;
            this.lotAddNewItem.Size = new System.Drawing.Size(49, 22);
            this.lotAddNewItem.Text = "&Add";
            this.lotAddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // lotDeleteItem
            // 
            this.lotDeleteItem.Enabled = false;
            this.lotDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("lotDeleteItem.Image")));
            this.lotDeleteItem.Name = "lotDeleteItem";
            this.lotDeleteItem.RightToLeftAutoMirrorImage = true;
            this.lotDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.lotDeleteItem.Text = "&Delete";
            this.lotDeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // lotSaveItem
            // 
            this.lotSaveItem.Enabled = false;
            this.lotSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lotSaveItem.Image")));
            this.lotSaveItem.Name = "lotSaveItem";
            this.lotSaveItem.Size = new System.Drawing.Size(51, 22);
            this.lotSaveItem.Text = "&Save";
            this.lotSaveItem.Click += new System.EventHandler(this.SaveItem_Click);
            // 
            // lotCancelItem
            // 
            this.lotCancelItem.Enabled = false;
            this.lotCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("lotCancelItem.Image")));
            this.lotCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lotCancelItem.Name = "lotCancelItem";
            this.lotCancelItem.Size = new System.Drawing.Size(63, 22);
            this.lotCancelItem.Text = "&Cancel";
            this.lotCancelItem.Click += new System.EventHandler(this.CancelItem_Click);
            // 
            // lotSeparator4
            // 
            this.lotSeparator4.Name = "lotSeparator4";
            this.lotSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // lotChangeParentItem
            // 
            this.lotChangeParentItem.Enabled = false;
            this.lotChangeParentItem.Image = ((System.Drawing.Image)(resources.GetObject("lotChangeParentItem.Image")));
            this.lotChangeParentItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lotChangeParentItem.Name = "lotChangeParentItem";
            this.lotChangeParentItem.Size = new System.Drawing.Size(105, 22);
            this.lotChangeParentItem.Text = "&Change parent";
            this.lotChangeParentItem.Click += new System.EventHandler(this.ChangeParentItem_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lnkLogout);
            this.panelHeader.Controls.Add(this.lblWelcomeUser);
            this.panelHeader.Controls.Add(this.lnkOptions);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(986, 76);
            this.panelHeader.StateNormal.Color1 = System.Drawing.Color.White;
            this.panelHeader.StateNormal.Image = global::LSDMS.Properties.Resources.header;
            this.panelHeader.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.TopLeft;
            this.panelHeader.TabIndex = 37;
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.KeyTip;
            this.lnkLogout.Location = new System.Drawing.Point(934, 17);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(43, 14);
            this.lnkLogout.TabIndex = 2;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.Values.ExtraText = "";
            this.lnkLogout.Values.Image = null;
            this.lnkLogout.Values.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.EventHandler(this.lnkLogout_LinkClicked);
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(892, 50);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(88, 20);
            this.lblWelcomeUser.TabIndex = 1;
            this.lblWelcomeUser.Text = "Welcome user";
            this.lblWelcomeUser.Values.ExtraText = "";
            this.lblWelcomeUser.Values.Image = null;
            this.lblWelcomeUser.Values.Text = "Welcome user";
            // 
            // lnkOptions
            // 
            this.lnkOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkOptions.Location = new System.Drawing.Point(670, 11);
            this.lnkOptions.Name = "lnkOptions";
            this.lnkOptions.Size = new System.Drawing.Size(54, 20);
            this.lnkOptions.TabIndex = 0;
            this.lnkOptions.Text = "Options";
            this.lnkOptions.Values.ExtraText = "";
            this.lnkOptions.Values.Image = null;
            this.lnkOptions.Values.Text = "Options";
            this.lnkOptions.Visible = false;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.statusStripMain.Location = new System.Drawing.Point(0, 714);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStripMain.Size = new System.Drawing.Size(986, 22);
            this.statusStripMain.TabIndex = 36;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel.Text = "<status>";
            // 
            // cadSurveyTableAdapter
            // 
            this.cadSurveyTableAdapter.ClearBeforeFill = true;
            // 
            // municipalityTableAdapter
            // 
            this.municipalityTableAdapter.ClearBeforeFill = true;
            // 
            // kryptonCheckSetNav
            // 
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnMunicipalityNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnCadSurveyNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnCaseNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnBarangayNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnSectionNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnLotNav);
            this.kryptonCheckSetNav.CheckButtons.Add(this.btnQuadrangleNav);
            this.kryptonCheckSetNav.CheckedButton = this.btnCadSurveyNav;
            // 
            // regionPsgcTableAdapter
            // 
            this.regionPsgcTableAdapter.ClearBeforeFill = true;
            // 
            // provincePsgcTableAdapter
            // 
            this.provincePsgcTableAdapter.ClearBeforeFill = true;
            // 
            // municipalityPsgcTableAdapter
            // 
            this.municipalityPsgcTableAdapter.ClearBeforeFill = true;
            // 
            // cadSurveyErrorProvider
            // 
            this.cadSurveyErrorProvider.ContainerControl = this;
            this.cadSurveyErrorProvider.DataMember = "";
            this.cadSurveyErrorProvider.DataSource = this.cadSurveyBindingSource;
            // 
            // municipalityErrorProvider
            // 
            this.municipalityErrorProvider.ContainerControl = this;
            this.municipalityErrorProvider.DataSource = this.municipalityBindingSource;
            // 
            // caseTableAdapter
            // 
            this.caseTableAdapter.ClearBeforeFill = true;
            // 
            // caseErrorProvider
            // 
            this.caseErrorProvider.ContainerControl = this;
            this.caseErrorProvider.DataSource = this.caseBindingSource;
            // 
            // barangayTableAdapter
            // 
            this.barangayTableAdapter.ClearBeforeFill = true;
            // 
            // barangayErrorProvider
            // 
            this.barangayErrorProvider.ContainerControl = this;
            this.barangayErrorProvider.DataSource = this.barangayBindingSource;
            // 
            // barangayPsgcTableAdapter
            // 
            this.barangayPsgcTableAdapter.ClearBeforeFill = true;
            // 
            // sectionTableAdapter
            // 
            this.sectionTableAdapter.ClearBeforeFill = true;
            // 
            // sectionErrorProvider
            // 
            this.sectionErrorProvider.ContainerControl = this;
            this.sectionErrorProvider.DataSource = this.sectionBindingSource;
            // 
            // lotTableAdapter
            // 
            this.lotTableAdapter.ClearBeforeFill = true;
            // 
            // lotErrorProvider
            // 
            this.lotErrorProvider.ContainerControl = this;
            this.lotErrorProvider.DataSource = this.lotBindingSource;
            // 
            // lotDataTableAdapter
            // 
            this.lotDataTableAdapter.ClearBeforeFill = true;
            // 
            // lotDataErrorProvider
            // 
            this.lotDataErrorProvider.ContainerControl = this;
            this.lotDataErrorProvider.DataSource = this.lotBindingSource;
            // 
            // techDescTableAdapter
            // 
            this.techDescTableAdapter.ClearBeforeFill = true;
            // 
            // techDescErrorProvider
            // 
            this.techDescErrorProvider.ContainerControl = this;
            this.techDescErrorProvider.DataSource = this.lotBindingSource;
            // 
            // ref_Type_TableTableAdapter
            // 
            this.ref_Type_TableTableAdapter.ClearBeforeFill = true;
            // 
            // saveShapeFileDialog
            // 
            this.saveShapeFileDialog.FileName = "lotdata.zip";
            this.saveShapeFileDialog.Filter = "Zip file|*.zip";
            // 
            // quadrangleTableAdapter
            // 
            this.quadrangleTableAdapter.ClearBeforeFill = true;
            // 
            // quadrangleErrorProvider
            // 
            this.quadrangleErrorProvider.ContainerControl = this;
            this.quadrangleErrorProvider.DataSource = this.quadrangleBindingSource;
            // 
            // cntxtLotDataGrid
            // 
            this.cntxtLotDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemLotDataGrid});
            this.cntxtLotDataGrid.Name = "cntxtLotDataGrid";
            this.cntxtLotDataGrid.Size = new System.Drawing.Size(198, 26);
            // 
            // mnuItemLotDataGrid
            // 
            this.mnuItemLotDataGrid.Name = "mnuItemLotDataGrid";
            this.mnuItemLotDataGrid.Size = new System.Drawing.Size(197, 22);
            this.mnuItemLotDataGrid.Text = "mnuItemDeleteLotData";
            // 
            // ref_Type_TableBindingSource
            // 
            this.ref_Type_TableBindingSource.DataMember = "Ref_Type_Table";
            this.ref_Type_TableBindingSource.DataSource = this.lsdmsDataSet;
            // 
            // Sequence
            // 
            this.Sequence.DataPropertyName = "Sequence";
            this.Sequence.HeaderText = "Sequence";
            this.Sequence.Name = "Sequence";
            this.Sequence.Width = 60;
            // 
            // Northing
            // 
            this.Northing.DataPropertyName = "PtmY";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Northing.DefaultCellStyle = dataGridViewCellStyle2;
            this.Northing.HeaderText = "PTM Northing";
            this.Northing.Name = "Northing";
            this.Northing.Width = 120;
            // 
            // Easting
            // 
            this.Easting.DataPropertyName = "PtmX";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Easting.DefaultCellStyle = dataGridViewCellStyle3;
            this.Easting.HeaderText = "PTM Easting";
            this.Easting.Name = "Easting";
            // 
            // PrsY
            // 
            this.PrsY.DataPropertyName = "PrsY";
            this.PrsY.HeaderText = "PRS 92 Northing";
            this.PrsY.Name = "PrsY";
            // 
            // PrsX
            // 
            this.PrsX.DataPropertyName = "PrsX";
            this.PrsX.HeaderText = "PRS 92 Easting";
            this.PrsX.Name = "PrsX";
            // 
            // LocalY
            // 
            this.LocalY.DataPropertyName = "LocalY";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LocalY.DefaultCellStyle = dataGridViewCellStyle4;
            this.LocalY.HeaderText = "Local Northing";
            this.LocalY.Name = "LocalY";
            // 
            // LocalX
            // 
            this.LocalX.DataPropertyName = "LocalX";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LocalX.DefaultCellStyle = dataGridViewCellStyle5;
            this.LocalX.HeaderText = "Local Easting";
            this.LocalX.Name = "LocalX";
            // 
            // NS
            // 
            this.NS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NS.DefaultCellStyle = dataGridViewCellStyle6;
            this.NS.HeaderText = "NS";
            this.NS.Name = "NS";
            this.NS.ReadOnly = true;
            this.NS.Width = 35;
            // 
            // Degree
            // 
            this.Degree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Degree.DefaultCellStyle = dataGridViewCellStyle7;
            this.Degree.HeaderText = "Degree";
            this.Degree.Name = "Degree";
            this.Degree.ReadOnly = true;
            this.Degree.Width = 50;
            // 
            // Minute
            // 
            this.Minute.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Minute.DefaultCellStyle = dataGridViewCellStyle8;
            this.Minute.HeaderText = "Minute";
            this.Minute.Name = "Minute";
            this.Minute.ReadOnly = true;
            this.Minute.Width = 50;
            // 
            // EW
            // 
            this.EW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.EW.DefaultCellStyle = dataGridViewCellStyle9;
            this.EW.HeaderText = "EW";
            this.EW.Name = "EW";
            this.EW.ReadOnly = true;
            this.EW.Width = 35;
            // 
            // Distance
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Distance.DefaultCellStyle = dataGridViewCellStyle10;
            this.Distance.HeaderText = "Distance";
            this.Distance.Name = "Distance";
            this.Distance.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 736);
            this.Controls.Add(this.kryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LSDMS (Build ??.??.????)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel1)).EndInit();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer.Panel2)).EndInit();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanelNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lsdmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            this.panelCadSurveyNav.ResumeLayout(false);
            this.panelCadSurveyNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntryHeaderGroup.Panel)).EndInit();
            this.dataEntryHeaderGroup.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEntryHeaderGroup)).EndInit();
            this.dataEntryHeaderGroup.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCadSurvey.ResumeLayout(false);
            this.tabPageCadSurvey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyBindingNavigator)).EndInit();
            this.cadSurveyBindingNavigator.ResumeLayout(false);
            this.cadSurveyBindingNavigator.PerformLayout();
            this.panelCadSurvey.ResumeLayout(false);
            this.panelCadSurvey.PerformLayout();
            this.tabPageMunicipality.ResumeLayout(false);
            this.tabPageMunicipality.PerformLayout();
            this.panelMunicipality.ResumeLayout(false);
            this.panelMunicipality.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityBindingNavigator)).EndInit();
            this.municipalityBindingNavigator.ResumeLayout(false);
            this.municipalityBindingNavigator.PerformLayout();
            this.tabPageCase.ResumeLayout(false);
            this.tabPageCase.PerformLayout();
            this.panelCase.ResumeLayout(false);
            this.panelCase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caseBindingNavigator)).EndInit();
            this.caseBindingNavigator.ResumeLayout(false);
            this.caseBindingNavigator.PerformLayout();
            this.tabPageBarangay.ResumeLayout(false);
            this.tabPageBarangay.PerformLayout();
            this.panelBarangay.ResumeLayout(false);
            this.panelBarangay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangayPsgcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityPsgcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincePsgcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionPsgcBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.psgc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingNavigator)).EndInit();
            this.barangayBindingNavigator.ResumeLayout(false);
            this.barangayBindingNavigator.PerformLayout();
            this.tabPageQuadrangle.ResumeLayout(false);
            this.tabPageQuadrangle.PerformLayout();
            this.panelQuadrangle.ResumeLayout(false);
            this.panelQuadrangle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleBindingNavigator)).EndInit();
            this.quadrangleBindingNavigator.ResumeLayout(false);
            this.quadrangleBindingNavigator.PerformLayout();
            this.tabPageSection.ResumeLayout(false);
            this.tabPageSection.PerformLayout();
            this.panelSection.ResumeLayout(false);
            this.panelSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingNavigator)).EndInit();
            this.sectionBindingNavigator.ResumeLayout(false);
            this.sectionBindingNavigator.PerformLayout();
            this.tabPageLot.ResumeLayout(false);
            this.tabPageLot.PerformLayout();
            this.tabControlLot.ResumeLayout(false);
            this.tabPageLotInfo.ResumeLayout(false);
            this.tabPageLotInfo.PerformLayout();
            this.tabControlLotInfo.ResumeLayout(false);
            this.tabPageRemarks.ResumeLayout(false);
            this.tabPageRemarks.PerformLayout();
            this.tabPageValidation.ResumeLayout(false);
            this.tabPageValidation.PerformLayout();
            this.tabPageLotData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData.Panel1)).EndInit();
            this.splitContainerLotData.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData.Panel2)).EndInit();
            this.splitContainerLotData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLotData)).EndInit();
            this.splitContainerLotData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lotDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataBindingSource)).EndInit();
            this.tabPageTechDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc.Panel1)).EndInit();
            this.splitContainerTechDesc.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc.Panel2)).EndInit();
            this.splitContainerTechDesc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTechDesc)).EndInit();
            this.splitContainerTechDesc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.techDescGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDescBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotBindingNavigator)).EndInit();
            this.lotBindingNavigator.ResumeLayout(false);
            this.lotBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadSurveyErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipalityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caseErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lotDataErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techDescErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadrangleErrorProvider)).EndInit();
            this.cntxtLotDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ref_Type_TableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer mainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNav;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnMunicipalityNav;
        private System.Windows.Forms.ListBox listBoxLot;
        private System.Windows.Forms.ListBox listBoxSection;
        private System.Windows.Forms.ListBox listBoxBarangay;
        private System.Windows.Forms.ListBox listBoxCase;
        private System.Windows.Forms.ListBox listBoxMunicipality;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnCaseNav;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnBarangayNav;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnSectionNav;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnLotNav;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnCadSurveyNav;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup dataEntryHeaderGroup;
        private lsdmsDataSet lsdmsDataSet;
        private System.Windows.Forms.BindingSource cadSurveyBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.CadSurveyTableAdapter cadSurveyTableAdapter;
        private System.Windows.Forms.BindingSource municipalityBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.MunicipalityTableAdapter municipalityTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet kryptonCheckSetNav;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private Psgc psgc;
        private System.Windows.Forms.BindingSource regionPsgcBindingSource;
        private LSDMS.PsgcTableAdapters.RegionTableAdapter regionPsgcTableAdapter;
        private System.Windows.Forms.BindingSource provincePsgcBindingSource;
        private LSDMS.PsgcTableAdapters.ProvinceTableAdapter provincePsgcTableAdapter;
        private System.Windows.Forms.BindingSource municipalityPsgcBindingSource;
        private LSDMS.PsgcTableAdapters.MunicipalityTableAdapter municipalityPsgcTableAdapter;
        private System.Windows.Forms.ErrorProvider cadSurveyErrorProvider;
        private System.Windows.Forms.ErrorProvider municipalityErrorProvider;
        private System.Windows.Forms.BindingSource caseBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.CaseTableAdapter caseTableAdapter;
        private System.Windows.Forms.ErrorProvider caseErrorProvider;
        private System.Windows.Forms.BindingSource barangayBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.BarangayTableAdapter barangayTableAdapter;
        private System.Windows.Forms.ErrorProvider barangayErrorProvider;
        private System.Windows.Forms.BindingSource barangayPsgcBindingSource;
        private LSDMS.PsgcTableAdapters.BarangayTableAdapter barangayPsgcTableAdapter;
        private System.Windows.Forms.BindingSource sectionBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.SectionTableAdapter sectionTableAdapter;
        private System.Windows.Forms.ErrorProvider sectionErrorProvider;
        private System.Windows.Forms.BindingSource lotBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.LotTableAdapter lotTableAdapter;
        private System.Windows.Forms.ErrorProvider lotErrorProvider;
        private System.Windows.Forms.BindingSource lotDataBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.LotDataTableAdapter lotDataTableAdapter;
        private System.Windows.Forms.ErrorProvider lotDataErrorProvider;
        private System.Windows.Forms.BindingSource techDescBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.TechDescTableAdapter techDescTableAdapter;
        private System.Windows.Forms.ErrorProvider techDescErrorProvider;
        private LSDMS.lsdmsDataSetTableAdapters.Ref_Type_Table2TableAdapter ref_Type_TableTableAdapter;
        private System.Windows.Forms.SaveFileDialog saveShapeFileDialog;
        private System.Windows.Forms.Panel panelCadSurveyNav;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCadSurvey;
        private System.Windows.Forms.Panel panelCadSurvey;
        private System.Windows.Forms.TextBox approvalRemarksTextBox;
        private System.Windows.Forms.TextBox approvedTotalAreaHectaresTextBox;
        private System.Windows.Forms.ComboBox regionPsgcComboBox;
        private System.Windows.Forms.TextBox approvedTotalLotTextBox;
        private System.Windows.Forms.ComboBox provincePsgcComboBox;
        private System.Windows.Forms.TextBox approvedTotalBarangayTextBox;
        private System.Windows.Forms.TextBox cadSurveyNoTextBox;
        private System.Windows.Forms.TextBox approvedTotalCityTextBox;
        private System.Windows.Forms.TextBox approvedTotalMunicipalityTextBox;
        private System.Windows.Forms.TextBox previousSurveyNoTextBox;
        private System.Windows.Forms.TextBox islandTextBox;
        private System.Windows.Forms.TextBox surveySymbolNoTextBox;
        private System.Windows.Forms.TextBox coordinateSystemTextBox;
        private System.Windows.Forms.Label provincePsgcErrorLabel;
        private System.Windows.Forms.Label regionPsgcErrorLabel;
        private System.Windows.Forms.BindingNavigator cadSurveyBindingNavigator;
        private System.Windows.Forms.ToolStripLabel cadSurveyCountItem;
        private System.Windows.Forms.ToolStripButton cadSurveyMoveFirstItem;
        private System.Windows.Forms.ToolStripButton cadSurveyMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator cadSurveySeparator1;
        private System.Windows.Forms.ToolStripTextBox cadSurveyPositionItem;
        private System.Windows.Forms.ToolStripSeparator cadSurveySeparator2;
        private System.Windows.Forms.ToolStripButton cadSurveyMoveNextItem;
        private System.Windows.Forms.ToolStripButton cadSurveyMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator cadSurveySeparator3;
        private System.Windows.Forms.ToolStripButton cadSurveyAddNewItem;
        private System.Windows.Forms.ToolStripButton cadSurveyDeleteItem;
        private System.Windows.Forms.ToolStripButton cadSurveySaveItem;
        private System.Windows.Forms.ToolStripButton cadSurveyCancelItem;
        private System.Windows.Forms.TabPage tabPageMunicipality;
        private System.Windows.Forms.Panel panelMunicipality;
        private System.Windows.Forms.Label municipalityPsgcErrorLabel;
        private System.Windows.Forms.ListBox municipalityPsgcListBox;
        private System.Windows.Forms.BindingNavigator municipalityBindingNavigator;
        private System.Windows.Forms.ToolStripLabel municipalityCountItem;
        private System.Windows.Forms.ToolStripButton municipalityMoveFirstItem;
        private System.Windows.Forms.ToolStripButton municipalityMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator municipalitySeparator1;
        private System.Windows.Forms.ToolStripTextBox municipalityPositionItem;
        private System.Windows.Forms.ToolStripSeparator municipalitySeparator2;
        private System.Windows.Forms.ToolStripButton municipalityMoveNextItem;
        private System.Windows.Forms.ToolStripButton municipalityMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator municipalitySeparator3;
        private System.Windows.Forms.ToolStripButton municipalityAddNewItem;
        private System.Windows.Forms.ToolStripButton municipalityDeleteItem;
        private System.Windows.Forms.ToolStripButton municipalitySaveItem;
        private System.Windows.Forms.ToolStripButton municipalityCancelItem;
        private System.Windows.Forms.TabPage tabPageCase;
        private System.Windows.Forms.Panel panelCase;
        private System.Windows.Forms.TextBox moduleNoTextBox;
        private System.Windows.Forms.TextBox cadCaseNoTextBox;
        private System.Windows.Forms.BindingNavigator caseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel caseCountItem;
        private System.Windows.Forms.ToolStripButton caseMoveFirstItem;
        private System.Windows.Forms.ToolStripButton caseMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator caseSeparator1;
        private System.Windows.Forms.ToolStripTextBox casePositionItem;
        private System.Windows.Forms.ToolStripSeparator caseSeparator2;
        private System.Windows.Forms.ToolStripButton caseMoveNextItem;
        private System.Windows.Forms.ToolStripButton caseMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator caseSeparator3;
        private System.Windows.Forms.ToolStripButton caseAddNewItem;
        private System.Windows.Forms.ToolStripButton caseDeleteItem;
        private System.Windows.Forms.ToolStripButton caseSaveItem;
        private System.Windows.Forms.ToolStripButton caseCancelItem;
        private System.Windows.Forms.TabPage tabPageBarangay;
        private System.Windows.Forms.Panel panelBarangay;
        private System.Windows.Forms.Label barangayPsgcErrorLabel;
        private System.Windows.Forms.ListBox barangayPsgcListBox;
        private System.Windows.Forms.BindingNavigator barangayBindingNavigator;
        private System.Windows.Forms.ToolStripLabel barangayCountItem;
        private System.Windows.Forms.ToolStripButton barangayMoveFirstItem;
        private System.Windows.Forms.ToolStripButton barangayMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator barangaySeparator1;
        private System.Windows.Forms.ToolStripTextBox barangayPositionItem;
        private System.Windows.Forms.ToolStripSeparator barangaySeparator2;
        private System.Windows.Forms.ToolStripButton barangayMoveNextItem;
        private System.Windows.Forms.ToolStripButton barangayMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator barangaySeparator3;
        private System.Windows.Forms.ToolStripButton barangayAddNewItem;
        private System.Windows.Forms.ToolStripButton barangayDeleteItem;
        private System.Windows.Forms.ToolStripButton barangaySaveItem;
        private System.Windows.Forms.ToolStripButton barangayCancelItem;
        private System.Windows.Forms.TabPage tabPageSection;
        private System.Windows.Forms.Panel panelSection;
        private System.Windows.Forms.TextBox scaleTextBox;
        private System.Windows.Forms.TextBox sectionIdTextBox;
        private System.Windows.Forms.BindingNavigator sectionBindingNavigator;
        private System.Windows.Forms.ToolStripLabel sectionCountItem;
        private System.Windows.Forms.ToolStripButton sectionMoveFirstItem;
        private System.Windows.Forms.ToolStripButton sectionMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator sectionSeparator1;
        private System.Windows.Forms.ToolStripTextBox sectionPositionItem;
        private System.Windows.Forms.ToolStripSeparator sectionSeparator2;
        private System.Windows.Forms.ToolStripButton sectionMoveNextItem;
        private System.Windows.Forms.ToolStripButton sectionMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator sectionSeparator3;
        private System.Windows.Forms.ToolStripButton sectionAddNewItem;
        private System.Windows.Forms.ToolStripButton sectionDeleteItem;
        private System.Windows.Forms.ToolStripButton sectionSaveItem;
        private System.Windows.Forms.ToolStripButton sectionCancelItem;
        private System.Windows.Forms.TabPage tabPageLot;
        private System.Windows.Forms.TabControl tabControlLot;
        private System.Windows.Forms.TabPage tabPageLotInfo;
        private System.Windows.Forms.ComboBox referencePointComboBox;
        private System.Windows.Forms.TextBox claimantAddressTextBox;
        private System.Windows.Forms.TextBox duplicateCheckedByTextBox;
        private System.Windows.Forms.TextBox duplicateCheckedDateTextBox;
        private System.Windows.Forms.TextBox originalCheckedByTextBox;
        private System.Windows.Forms.TextBox finalVerifiedByTextBox;
        private System.Windows.Forms.TextBox originalCheckedDateTextBox;
        private System.Windows.Forms.TextBox finalCheckedBy1TextBox;
        private System.Windows.Forms.TextBox finalCheckedBy2TextBox;
        private System.Windows.Forms.TextBox declaredAreaTextBox;
        private System.Windows.Forms.TextBox originalCompletedByTextBox;
        private System.Windows.Forms.TextBox originalCompletedDateTextBox;
        private System.Windows.Forms.TextBox computedAreaTextBox;
        private System.Windows.Forms.TextBox tieLineNSTextBox;
        private System.Windows.Forms.TextBox claimantNameTextBox;
        private System.Windows.Forms.TextBox tieLineEWTextBox;
        private System.Windows.Forms.TextBox tieLineDegreeTextBox;
        private System.Windows.Forms.TextBox lotNoTextBox;
        private System.Windows.Forms.TextBox tieLineMinuteTextBox;
        private System.Windows.Forms.TextBox tieLineDistanceTextBox;
        private System.Windows.Forms.TabPage tabPageLotData;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerLotData;
        private System.Windows.Forms.TabPage tabPageTechDesc;
        private System.Windows.Forms.BindingNavigator lotBindingNavigator;
        private System.Windows.Forms.ToolStripLabel lotCountItem;
        private System.Windows.Forms.ToolStripButton lotMoveFirstItem;
        private System.Windows.Forms.ToolStripButton lotMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator lotSeparator1;
        private System.Windows.Forms.ToolStripTextBox lotPositionItem;
        private System.Windows.Forms.ToolStripSeparator lotSeparator2;
        private System.Windows.Forms.ToolStripButton lotMoveNextItem;
        private System.Windows.Forms.ToolStripButton lotMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator lotSeparator3;
        private System.Windows.Forms.ToolStripButton lotAddNewItem;
        private System.Windows.Forms.ToolStripButton lotDeleteItem;
        private System.Windows.Forms.ToolStripButton lotSaveItem;
        private System.Windows.Forms.ToolStripButton lotCancelItem;
        private System.Windows.Forms.TextBox lotRemarksTextBox;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescFromColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescToColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescNSColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescDegreeColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescMinuteColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescEWColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn techDescDistanceColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer splitContainerTechDesc;
        private System.Windows.Forms.TextBox lrcNoTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkOptions;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Northing;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Easting;
        //private System.Windows.Forms.DataGridViewTextBoxColumn LocalY;
        //private System.Windows.Forms.DataGridViewTextBoxColumn LocalX;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomToExtentLotData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomOutLotData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomInLotData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomToExtentTechDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomOutTechDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomInTechDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnZoomSelectedLotDatax;
        private System.Windows.Forms.ListBox listBoxCadSurvey;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cadSurveyNoSearchTextBox;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny btnSearchBoxClear;
        private SharpMap.Forms.MapBox mapImageLotData;
        private SharpMap.Forms.MapBox mapImageTechDesc;
        private System.Windows.Forms.BindingSource quadrangleBindingSource;
        private LSDMS.lsdmsDataSetTableAdapters.QuadrangleTableAdapter quadrangleTableAdapter;
        private System.Windows.Forms.TabPage tabPageQuadrangle;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnQuadrangleNav;
        private System.Windows.Forms.ListBox listBoxQuadrangle;
        private System.Windows.Forms.BindingNavigator quadrangleBindingNavigator;
        private System.Windows.Forms.ToolStripButton quadrangleAddNewItem;
        private System.Windows.Forms.ToolStripLabel quadrangleCountItem;
        private System.Windows.Forms.ToolStripButton quadrangleDeleteItem;
        private System.Windows.Forms.ToolStripButton quadrangleMoveFirstItem;
        private System.Windows.Forms.ToolStripButton quadrangleMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator quadrangleSeparator1;
        private System.Windows.Forms.ToolStripTextBox quadranglePositionItem;
        private System.Windows.Forms.ToolStripSeparator quadrangleSeparator2;
        private System.Windows.Forms.ToolStripButton quadrangleMoveNextItem;
        private System.Windows.Forms.ToolStripButton quadrangleMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator quadrangleSeparator3;
        private System.Windows.Forms.ToolStripButton quadrangleSaveItem;
        private System.Windows.Forms.TextBox quadrangleTextBox;
        private System.Windows.Forms.Panel panelQuadrangle;
        private System.Windows.Forms.ToolStripButton quadrangleCancelItem;
        private System.Windows.Forms.ErrorProvider quadrangleErrorProvider;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView lotDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView techDescGridView;
        //private System.Windows.Forms.DataGridViewTextBoxColumn sequenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescNSColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescDegreeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescMinuteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescEWColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techDescDistanceColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnZoomSelectedLotData;
        private System.Windows.Forms.ContextMenuStrip cntxtLotDataGrid;
        private System.Windows.Forms.ToolStripMenuItem mnuItemLotDataGrid;
        private System.Windows.Forms.BindingSource ref_Type_TableBindingSource;
        private System.Windows.Forms.Label lblReferencePoint;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabControl tabControlLotInfo;
        private System.Windows.Forms.TabPage tabPageRemarks;
        private System.Windows.Forms.TabPage tabPageValidation;
        private System.Windows.Forms.TextBox surveyDayFromTextBox;
        private System.Windows.Forms.TextBox surveyYearFromTextBox;
        private System.Windows.Forms.TextBox surveyMonthFromTextBox;
        private System.Windows.Forms.TextBox surveyDayToTextBox;
        private System.Windows.Forms.TextBox surveyMonthToTextBox;
        private System.Windows.Forms.TextBox surveyYearToTextBox;
        private System.Windows.Forms.TextBox geName2TextBox;
        private System.Windows.Forms.ToolStripSeparator cadSurveySeparator4;
        private System.Windows.Forms.ToolStripButton cadSurveyMergeItem;
        private System.Windows.Forms.ToolStripSeparator caseSeparator4;
        private System.Windows.Forms.ToolStripButton caseMergeItem;
        private System.Windows.Forms.ToolStripSeparator quadrangleSeparator4;
        private System.Windows.Forms.ToolStripButton quadrangleMergeItem;
        private System.Windows.Forms.ToolStripSeparator sectionSeparator4;
        private System.Windows.Forms.ToolStripButton sectionMergeItem;
        private System.Windows.Forms.ToolStripSeparator lotSeparator4;
        private System.Windows.Forms.ToolStripSeparator municipalitySeparator4;
        private System.Windows.Forms.ToolStripButton municipalityMergeItem;
        private System.Windows.Forms.ToolStripSeparator barangaySeparator4;
        private System.Windows.Forms.ToolStripButton barangayMergeItem;
        private System.Windows.Forms.ToolStripButton lotChangeParentItem;
        private System.Windows.Forms.ToolStripButton sectionChangeParentItem;
        private System.Windows.Forms.ToolStripButton barangayChangeParentItem;
        private System.Windows.Forms.ToolStripButton quadrangleChangeParentItem;
        private System.Windows.Forms.ToolStripButton municipalityChangeParentItem;
        private System.Windows.Forms.ToolStripButton caseChangeParentItem;
        private System.Windows.Forms.TextBox txtEncoder;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblWelcomeUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkLogout;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkClaim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Northing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Easting;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrsY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrsX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn EW;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        
    }
}

