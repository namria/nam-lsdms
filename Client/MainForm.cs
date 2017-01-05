using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Xml;
using System.Data.SqlClient;

namespace LSDMS
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        public string UserName;
        public int Level;

        DataSetValidator validator;
        string ImageServerUrl;
        string ImageServerName;
        string ConnString;

        GheloBytes.LotData lotData;
        GheloBytes.TechDesc techDesc;

        Timer timerMap = new Timer();

        // ==============
        // INITIALIZATION
        // --------------
        public MainForm(string userName, int level)
        {
            UserName = userName;
            Level = level;

            InitializeComponent();
            SetConnectionString();
            SetImageServer();

            HookUpEvents();

            
            // populate region list
            regionPsgcComboBox.DataSource = regionPsgcTableAdapter.GetData();
            FillCadSurvey();

            DefineValidation();
        }

        // ======
        // EVENTS
        // ------


        // form events
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = GheloBytes.Version();

            //set welcome message

            lblWelcomeUser.Text = String.Format("Welcome {0}. Today is {1}.", UserName, DateTime.Now.ToString("MMM dd yyyy"));


            btnCadSurveyNav.PerformClick();
            InitMap();

            FixBoundNullValue();
            HookUpKeyDown(this);

            InitCoordConversionTool();

        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Modifiers == Keys.None)
            {
                switch (e.KeyCode)
                {
                    case Keys.PageDown:
                        GotoPageDown();
                        break;
                    case Keys.PageUp:
                        GotoPageUp();
                        break;
                    case Keys.Up:
                    case Keys.Left:
                        break;
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.F12:
                        //Clipboard.SetDataObject(mapUrlLotDataTextBox.Text);
                        break;
                }

            }
            else
            {
            }

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        // general events
        private void AddNewItem_Click(object sender, EventArgs e)
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    cadSurveyBindingSource.AddNew();
                    break;
                case "Municipality":
                    municipalityBindingSource.AddNew();
                    break;
                case "Case":
                    caseBindingSource.AddNew();
                    break;
                case "Barangay":
                    barangayBindingSource.AddNew();
                    break;
                case "Quadrangle":
                    quadrangleBindingSource.AddNew();
                    break;
                case "Section":
                    sectionBindingSource.AddNew();
                    break;
                case "Lot":
                    tabControlLot.SelectedTab = tabPageLotInfo;
                    lotBindingSource.AddNew();
                    break;
            }

            DisableNavControls(true);
            DisableSaveControl(true);
        }
        private void DeleteItem_Click(object sender, EventArgs e)
        {

            if (!(Level > 1) & kryptonCheckSetNav.CheckedButton.Text != "Lot")
            {
                DeletePrompt frm = new DeletePrompt(ConnString);
                frm.ShowDialog();
                if (!frm.Allow)
                {
                    return;
                }
                frm.Dispose();
            }

            string msg = "Warning: Any child data will also be deleted. \n" +
                        "Are you sure you want to delete this record?";
            if (MessageBox.Show( msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    cadSurveyBindingSource.RemoveCurrent();
                    cadSurveyTableAdapter.Update(lsdmsDataSet.CadSurvey);        
                    break;
                case "Municipality":
                    municipalityBindingSource.RemoveCurrent();
                    municipalityTableAdapter.Update(lsdmsDataSet.Municipality);
                    break;
                case "Case":
                    caseBindingSource.RemoveCurrent();
                    caseTableAdapter.Update(lsdmsDataSet.Case);
                    break;
                case "Barangay":
                    barangayBindingSource.RemoveCurrent();
                    barangayTableAdapter.Update(lsdmsDataSet.Barangay);
                    break;
                case "Quadrangle":
                    quadrangleBindingSource.RemoveCurrent();
                    quadrangleTableAdapter.Update(lsdmsDataSet.Quadrangle);
                    break;
                case "Section":
                    sectionBindingSource.RemoveCurrent();
                    sectionTableAdapter.Update(lsdmsDataSet.Section);
                    break;
                case "Lot":
                    lotBindingSource.RemoveCurrent();
                    lotTableAdapter.Update(lsdmsDataSet.Lot);
                    break;
            }

            EnableDisableControl();

        }
        private void CancelItem_Click(object sender, EventArgs e)
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    cadSurveyBindingSource.CancelEdit();
                    cadSurveyErrorProvider.Clear();
                    UpdateRegionPsgc();
                    validator.ClearErrors("CadSurvey");
                    break;
                case "Municipality":
                    municipalityBindingSource.CancelEdit();
                    municipalityErrorProvider.Clear();
                    UpdateMunicipalityPsgc();
                    validator.ClearErrors("Municipality");
                    break;
                case "Case":
                    caseBindingSource.CancelEdit();
                    caseErrorProvider.Clear();
                    validator.ClearErrors("Case");
                    break;
                case "Barangay":
                    barangayBindingSource.CancelEdit();
                    barangayErrorProvider.Clear();
                    validator.ClearErrors("Barangay");
                    break;
                case "Quadrangle":
                    quadrangleBindingSource.CancelEdit();
                    quadrangleErrorProvider.Clear();
                    validator.ClearErrors("Quadrangle");
                    break;
                case "Section":
                    sectionBindingSource.CancelEdit();
                    sectionErrorProvider.Clear();
                    validator.ClearErrors("Section");
                    break;
                case "Lot":
                    lotBindingSource.CancelEdit();
                    lotErrorProvider.Clear();
                    validator.ClearErrors("Lot");

                    lotDataBindingSource.CancelEdit();
                    lotDataErrorProvider.Clear();
                    lotDataGridView.Refresh();
                    validator.ClearErrors("LotData");
                    
                    techDescBindingSource.CancelEdit();
                    techDescErrorProvider.Clear();
                    techDescGridView.Refresh();
                    validator.ClearErrors("TechDesc");

                    lsdmsDataSet.Lot.RejectChanges();
                    FillLotDataTechDesc();

                    UpdateReferencePoint();

                    break;
            }

            

            DisableNavControls(false);

        }
        private void SaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            validator.StopWatching();

            switch(kryptonCheckSetNav.CheckedButton.Text){
                case "Cad Survey":
                    cadSurveyBindingSource.EndEdit();
                    string cadSurveyNo = ((DataRowView)cadSurveyBindingSource.Current)["CadSurveyNo"].ToString();
                    cadSurveyTableAdapter.Update(lsdmsDataSet.CadSurvey);
                    //cadSurveyTableAdapter.Fill(lsdmsDataSet.CadSurvey);
                    this.FillCadSurvey();
                    listBoxCadSurvey.SelectedValue = cadSurveyNo;
                    break;
                case "Municipality":
                    municipalityBindingSource.EndEdit();
                    string municipalityPsgc = ((DataRowView)municipalityBindingSource.Current)["MunicipalityPsgc"].ToString();
                    municipalityTableAdapter.Update(lsdmsDataSet.Municipality);
                    //municipalityTableAdapter.Fill(lsdmsDataSet.Municipality);
                    this.FillMunicipality();
                    listBoxMunicipality.SelectedValue = municipalityPsgc;
                    break;
                case "Case":
                    caseBindingSource.EndEdit();
                    string caseNo = ((DataRowView)caseBindingSource.Current)["CadCaseNo"].ToString();
                    caseTableAdapter.Update(lsdmsDataSet.Case);
                    //caseTableAdapter.Fill(lsdmsDataSet.Case);
                    this.FillCase();
                    listBoxCase.SelectedValue = caseNo;
                    break;
                case "Barangay":
                    barangayBindingSource.EndEdit();
                    string barangayPsgc = ((DataRowView)barangayBindingSource.Current)["BarangayPsgc"].ToString();
                    barangayTableAdapter.Update(lsdmsDataSet.Barangay);
                    //barangayTableAdapter.Fill(lsdmsDataSet.Barangay);
                    this.FillBarangay();
                    listBoxBarangay.SelectedValue = barangayPsgc;
                    break;
                case "Quadrangle":
                    quadrangleBindingSource.EndEdit();
                    string quadrangle = ((DataRowView)quadrangleBindingSource.Current)["Quadrangle"].ToString();
                    quadrangleTableAdapter.Update(lsdmsDataSet.Quadrangle);
                    this.FillQuadrangle();
                    listBoxQuadrangle.SelectedValue = quadrangle;
                    break;
                case "Section":
                    sectionBindingSource.EndEdit();
                    string sectionId = ((DataRowView)sectionBindingSource.Current)["SectionId"].ToString();
                    sectionTableAdapter.Update(lsdmsDataSet.Section);
                    //sectionTableAdapter.Fill(lsdmsDataSet.Section);
                    this.FillSection();
                    listBoxSection.SelectedValue = sectionId;
                    break;
                case "Lot":

                    DataRowView drv = (DataRowView)lotBindingSource.Current;
                    //if (drv.IsNew | drv.IsEdit & (drv["UserName"] == DBNull.Value))
                    if (drv.IsNew)
                    {
                        drv["UserName"] = UserName;
                        drv["DateAdded"] = DateTime.Now;
                    }

                    lotBindingSource.EndEdit();
                    
                    lotTableAdapter.Update(lsdmsDataSet.Lot);

                    lotDataBindingSource.EndEdit();
                    lotDataTableAdapter.Update(lsdmsDataSet.LotData);

                    techDescBindingSource.EndEdit();
                    techDescTableAdapter.Update(lsdmsDataSet.TechDesc);

                    RefreshMapImage();

                    validator.ClearErrors("LotData");

                    //tabControlLot.SelectedTab = tabPageLotData;
                    ComputeLotData();
                    lotDataGridView.Refresh();
                    //tabControlLot.SelectedTab = tabPageLotInfo;

                    lnkClaim.Visible = (((DataRowView)lotBindingSource.Current)["UserName"] == DBNull.Value);

                    break;
            }
           
            DisableNavControls(false);
            validator.StartWatching();
            UpdateNavLabel();
        }
        private void NavTab_Click(object sender, EventArgs e)
        {

            listBoxCadSurvey.Visible = false;
            listBoxMunicipality.Visible = false;
            listBoxCase.Visible = false;
            listBoxBarangay.Visible = false;
            listBoxQuadrangle.Visible = false;
            listBoxSection.Visible = false;
            listBoxLot.Visible = false;

            foreach (KryptonCheckButton btn in kryptonCheckSetNav.CheckButtons)
            {
                btn.Enabled = false;
            }


            for (int i = 1; i <= tableLayoutPanelNav.RowCount; i = i + 2)
            {
                    tableLayoutPanelNav.RowStyles[i].Height = 0;
            }

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    tableLayoutPanelNav.RowStyles[1].Height = 100;
                    listBoxCadSurvey.Visible = true;
                    
                    tabControlMain.SelectedTab = tabPageCadSurvey;
                    btnCadSurveyNav.Enabled = true;
                    break;
                case "Municipality":
                    tableLayoutPanelNav.RowStyles[3].Height = 100;
                    listBoxMunicipality.Visible = true;
                    tabControlMain.SelectedTab = tabPageMunicipality;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    break;
                case "Case":
                    tableLayoutPanelNav.RowStyles[5].Height = 100;
                    listBoxCase.Visible = true;
                    tabControlMain.SelectedTab = tabPageCase;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    btnBarangayNav.Enabled = true;
                    break;
                case "Barangay":
                    tableLayoutPanelNav.RowStyles[7].Height = 100;
                    listBoxBarangay.Visible = true;
                    tabControlMain.SelectedTab = tabPageBarangay;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    btnBarangayNav.Enabled = true;
                    btnQuadrangleNav.Enabled = true;
                    break;
                case "Quadrangle":
                    tableLayoutPanelNav.RowStyles[9].Height = 100;
                    listBoxQuadrangle.Visible = true;
                    tabControlMain.SelectedTab = tabPageQuadrangle;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    btnBarangayNav.Enabled = true;
                    btnQuadrangleNav.Enabled = true;
                    btnSectionNav.Enabled = true;
                    break;
                case "Section":
                    tableLayoutPanelNav.RowStyles[11].Height = 100;
                    listBoxSection.Visible = true;
                    tabControlMain.SelectedTab = tabPageSection;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    btnBarangayNav.Enabled = true;
                    btnQuadrangleNav.Enabled = true;
                    btnSectionNav.Enabled = true;
                    btnLotNav.Enabled = true;
                    break;
                case "Lot":

                    tabControlLot.SelectedIndex = 0;

                    tableLayoutPanelNav.RowStyles[13].Height = 100;
                    listBoxLot.Visible = true;
                    tabControlMain.SelectedTab = tabPageLot;
                    btnCadSurveyNav.Enabled = true;
                    btnMunicipalityNav.Enabled = true;
                    btnCaseNav.Enabled = true;
                    btnBarangayNav.Enabled = true;
                    btnQuadrangleNav.Enabled = true;
                    btnSectionNav.Enabled = true;
                    btnLotNav.Enabled = true;

                    // kludge
                    // failing to display the values in grid if first run
                    tabControlLot.SelectedTab = tabPageLotData;
                    mapImageLotData.Visible = false;
                    ComputeLotData();
                    tabControlLot.SelectedTab = tabPageLotInfo;
                    mapImageLotData.Visible = true;
                                        
                    break;
            }


            //for (int i = 1; i <= tableLayoutPanelNav.RowCount; i = i + 2)
            //{
            //    if (i != enabledRowIndex)
            //        tableLayoutPanelNav.RowStyles[i].Height = 0;
            //}

            UpdateNavLabel();
        }
        private void LSDMS_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            //// force possible errors
            foreach (DataColumn col in e.Row.Table.Columns)
            {
                e.Row[col] = DBNull.Value;
            }

            switch (sender.ToString())
            {
                case "CadSurvey":
                    break;
                case "Municipality":
                    e.Row["CadSurveyNo"] = ((DataRowView)cadSurveyBindingSource.Current)["CadSurveyNo"].ToString();
                    break;
                case "Case":
                    e.Row["CadSurveyNo"] = ((DataRowView)municipalityBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)municipalityBindingSource.Current)["MunicipalityPsgc"].ToString();
                    break;
                case "Barangay":
                    e.Row["CadSurveyNo"] = ((DataRowView)caseBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)caseBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)caseBindingSource.Current)["CadCaseNo"].ToString();
                    break;
                case "Quadrangle":
                    e.Row["CadSurveyNo"] = ((DataRowView)barangayBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)barangayBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)barangayBindingSource.Current)["CadCaseNo"].ToString();
                    e.Row["BarangayPsgc"] = ((DataRowView)barangayBindingSource.Current)["BarangayPsgc"].ToString();
                    break;
                case "Section":
                    e.Row["CadSurveyNo"] = ((DataRowView)quadrangleBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)quadrangleBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)quadrangleBindingSource.Current)["CadCaseNo"].ToString();
                    e.Row["BarangayPsgc"] = ((DataRowView)quadrangleBindingSource.Current)["BarangayPsgc"].ToString();
                    e.Row["Quadrangle"] = ((DataRowView)quadrangleBindingSource.Current)["Quadrangle"].ToString();
                    break;
                case "Lot":
                    e.Row["CadSurveyNo"] = ((DataRowView)sectionBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)sectionBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)sectionBindingSource.Current)["CadCaseNo"].ToString();
                    e.Row["BarangayPsgc"] = ((DataRowView)sectionBindingSource.Current)["BarangayPsgc"].ToString();
                    e.Row["Quadrangle"] = ((DataRowView)sectionBindingSource.Current)["Quadrangle"].ToString();
                    e.Row["SectionId"] = ((DataRowView)sectionBindingSource.Current)["SectionId"].ToString();
                    break;
                case "LotData":
                    e.Row["CadSurveyNo"] = ((DataRowView)lotBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)lotBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)lotBindingSource.Current)["CadCaseNo"].ToString();
                    e.Row["BarangayPsgc"] = ((DataRowView)lotBindingSource.Current)["BarangayPsgc"].ToString();
                    e.Row["Quadrangle"] = ((DataRowView)lotBindingSource.Current)["Quadrangle"].ToString();
                    e.Row["SectionId"] = ((DataRowView)lotBindingSource.Current)["SectionId"].ToString();
                    e.Row["LotNo"] = ((DataRowView)lotBindingSource.Current)["LotNo"].ToString();
                    e.Row["Sequence"] = e.Row.Table.Rows.Count + 1; 
                    break;
                case "TechDesc":
                    e.Row["CadSurveyNo"] = ((DataRowView)lotBindingSource.Current)["CadSurveyNo"].ToString();
                    e.Row["MunicipalityPsgc"] = ((DataRowView)lotBindingSource.Current)["MunicipalityPsgc"].ToString();
                    e.Row["CadCaseNo"] = ((DataRowView)lotBindingSource.Current)["CadCaseNo"].ToString();
                    e.Row["BarangayPsgc"] = ((DataRowView)lotBindingSource.Current)["BarangayPsgc"].ToString();
                    e.Row["Quadrangle"] = ((DataRowView)lotBindingSource.Current)["Quadrangle"].ToString();
                    e.Row["SectionId"] = ((DataRowView)lotBindingSource.Current)["SectionId"].ToString();
                    e.Row["LotNo"] = ((DataRowView)lotBindingSource.Current)["LotNo"].ToString();
                    e.Row["FromCorner"] = e.Row.Table.Rows.Count + 1;
                    e.Row["ToCorner"] = e.Row.Table.Rows.Count + 2;
                    break;
            }
            DisableNavControls(true);
        }
        private void LSDMS_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            

            // disable navigation controls
            DisableNavControls(true);

            // disable save if there are errors
            DisableSaveControl(e.Row.HasErrors);
        }
        private void LotDataTechDesc_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            DisableNavControls(true);
            DisableSaveControl(e.Row.HasErrors);
        }
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                //Control control = (Control)sender;
                //Control next = control.Parent.GetNextControl(control, true);
                //if (next != null)
                //    next.Focus();
            }
        }

        // control-specific events
        private void splitContainerLot_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainerLotData.Refresh();
            RefreshMapImage();
        }
        private void regionPsgcComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ((DataRowView)cadSurveyBindingSource.Current)["RegionPsgc"] = regionPsgcComboBox.SelectedValue;
            regionPsgcErrorLabel.Text = regionPsgcComboBox.SelectedValue.ToString();
            UpdateProvincePsgc();
        }
        private void provincePsgcComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ((DataRowView)cadSurveyBindingSource.Current)["ProvincePsgc"] = provincePsgcComboBox.SelectedValue;
            provincePsgcErrorLabel.Text = provincePsgcComboBox.SelectedValue.ToString();
            UpdateMunicipalityPsgc();
        }
        private void municipalityPsgcListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ((DataRowView)municipalityBindingSource.Current)["MunicipalityPsgc"] = municipalityPsgcListBox.SelectedValue;
            municipalityPsgcErrorLabel.Text = municipalityPsgcListBox.SelectedValue.ToString();
            UpdateBarangayPsgc();
        }
        private void barangayPsgcListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ((DataRowView)barangayBindingSource.Current)["BarangayPsgc"] = barangayPsgcListBox.SelectedValue;
            barangayPsgcErrorLabel.Text = barangayPsgcListBox.SelectedValue.ToString();
        }
        private void cadSurveyNoSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cadSurveyBindingSource.Filter = "CadSurveyNo LIKE '" + cadSurveyNoSearchTextBox.Text + "%'";
                UpdateRegionPsgc();
                FillMunicipality();
                //FillReferencePoints();
            }
        }
        private void cadSurveyNoSearchTextBox_Enter(object sender, EventArgs e)
        {
            cadSurveyNoSearchTextBox.StateCommon.Content.Color1 = Color.Black;
            if (cadSurveyNoSearchTextBox.Text == "<Enter search term>")
                cadSurveyNoSearchTextBox.Text = string.Empty;
        }
        private void cadSurveyNoSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (cadSurveyNoSearchTextBox.Text == string.Empty)
            {
                cadSurveyNoSearchTextBox.StateCommon.Content.Color1 = Color.Silver;
                cadSurveyNoSearchTextBox.Text = "<Enter search term>";
            }
        }
        private void btnSearchBoxClear_Click(object sender, EventArgs e)
        {
            listBoxCadSurvey.Focus();
            cadSurveyNoSearchTextBox.StateCommon.Content.Color1 = Color.Silver;
            cadSurveyNoSearchTextBox.Text = "<Enter search term>";
            cadSurveyBindingSource.Filter = "CadSurveyNo LIKE '%'";
            UpdateRegionPsgc();
            FillMunicipality();
            //FillReferencePoints();
        }

        private void tabControlLot_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //DataRowView dr1 = (DataRowView)lotBindingSource.Current;
            //DataRowView dr2 = (DataRowView)lotDataBindingSource.Current;
            //DataRowView dr3 = (DataRowView)techDescBindingSource.Current;
            //e.Cancel = (dr1 == null ? false : dr1.Row.HasErrors) | (dr2 == null ? false : dr2.Row.HasErrors) | (dr3 == null ? false : dr3.Row.HasErrors);
            //switch (tabControlLot.SelectedTab.Name)
            //{
            //    case "tabPageLotInfo":
            //        lotBindingSource.EndEdit();
            //        cancel = lsdmsDataSet.Lot.HasErrors;
            //        break;
            //    case "tabPageLotData":
            //        cancel = lsdmsDataSet.LotData.HasErrors;
            //        break;
            //    case "tabPageTechDesc":
            //        cancel = lsdmsDataSet.TechDesc.HasErrors;
            //        break;
            //}

            lotBindingSource.EndEdit();
            bool cancel = (lsdmsDataSet.Lot.HasErrors || lsdmsDataSet.LotData.HasErrors || lsdmsDataSet.TechDesc.HasErrors);;
            
            if (cancel)
                MessageBox.Show("Error(s) on this tab prevents you from switch to \"" + e.TabPage.Text + "\"", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            e.Cancel = cancel;

        }
       
        private void referencePointComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ((DataRowView)lotBindingSource.Current)["ReferencePoint"] = referencePointComboBox.SelectedValue;
            UpdateReferencePointCoordinatesDisplay();
        }


        // data events
        private void cadSurveyBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateRegionPsgc();
            FillMunicipality();
            //FillReferencePoints();
            EnableDisableControl();
        }
        private void municipalityBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateMunicipalityPsgc();
            FillCase();
            EnableDisableControl();
        }
        private void caseBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FillBarangay();
            EnableDisableControl();
        }
        private void barangayBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateBarangayPsgc();
            FillQuadrangle();
            EnableDisableControl();
        }
        private void quadrangleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FillSection();
            EnableDisableControl();
        }
        private void sectionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            FillLot();
            
            EnableDisableControl();

        }
        private void lotBindingSource_PositionChanged(object sender, EventArgs e)
        {



            UpdateReferencePoint();

            FillLotDataTechDesc();

            EnableDisableControl();

            //tabControlLot.Enabled = (lotBindingSource.Count > 0);
            //lotDeleteItem.Enabled = (lotBindingSource.Count > 0);

            
            
            UpdateNavLabel();


            //tabControlLot.SelectedTab = tabPageLotData;
            ComputeLotData();
            lotDataGridView.Refresh();
            //tabControlLot.SelectedTab = tabPageLotInfo;
            lotDataGridView.ResumeLayout();

            if (btnZoomSelectedLotData.Checked & lotData != null)
            {
                lotData.ZoomToSelected();
                mapImageLotData.Refresh();
                mapImageLotData.Tag = mapImageLotData.Map.Zoom;
            }


            if (lotBindingSource.Current != null)
                lnkClaim.Visible  = (((DataRowView)lotBindingSource.Current)["UserName"] == DBNull.Value);

        }


        // map Events
        private void mapImageLotData_Resize(object sender, EventArgs e)
        {
            mapImageLotData.Refresh();
        }
        private void mapImageTechDesc_Resize(object sender, EventArgs e)
        {
            mapImageTechDesc.Refresh();
        }
        private void timerMap_Tick(object sender, EventArgs e)
        {
            // Determine current context
            if (tabControlLot.SelectedTab.Equals(tabPageLotData))
            {
                // Determine if zoom in or zoom out operation
                if (btnZoomInLotData.Capture)
                {
                    mapImageLotData.Map.Zoom -= 20;
                    mapImageLotData.Refresh();
                    mapImageLotData.Tag = mapImageLotData.Map.Zoom;
                }
                if (btnZoomOutLotData.Capture)
                {
                    mapImageLotData.Map.Zoom += 20;
                    mapImageLotData.Refresh();
                    mapImageLotData.Tag = mapImageLotData.Map.Zoom;
                }
            }

            if (tabControlLot.SelectedTab.Equals(tabPageTechDesc))
            {
                // Determine if zoom in or zoom out operation
                if (btnZoomInTechDesc.Capture)
                {
                    mapImageTechDesc.Map.Zoom -= 20;
                    mapImageTechDesc.Refresh();
                    mapImageTechDesc.Tag = mapImageTechDesc.Map.Zoom;
                }
                if (btnZoomOutTechDesc.Capture)
                {
                    mapImageTechDesc.Map.Zoom += 20;
                    mapImageTechDesc.Refresh();
                    mapImageTechDesc.Tag = mapImageTechDesc.Map.Zoom;
                }
            }

        }

        private void btnZoomInLotData_MouseDown(object sender, MouseEventArgs e)
        {
            timerMap.Start();
            btnZoomSelectedLotData.Checked = false;
        }
        private void btnZoomInLotData_MouseUp(object sender, MouseEventArgs e)
        {
            timerMap.Stop();
        }
        private void btnZoomOutLotData_MouseDown(object sender, MouseEventArgs e)
        {
            timerMap.Start();
            btnZoomSelectedLotData.Checked = false;
        }
        private void btnZoomOutLotData_MouseUp(object sender, MouseEventArgs e)
        {
            timerMap.Stop();
        }
        private void btnZoomToExtentLotData_Click(object sender, EventArgs e)
        {
            mapImageLotData.Map.ZoomToExtents();
            mapImageLotData.Refresh();
            mapImageLotData.Tag = mapImageLotData.Map.Zoom;
        }
        private void btnZoomToExtentTechDesc_Click(object sender, EventArgs e)
        {
            mapImageTechDesc.Map.ZoomToExtents();
            mapImageTechDesc.Refresh();
            mapImageTechDesc.Tag = mapImageTechDesc.Map.Zoom;
        }
        private void btnZoomInTechDesc_MouseDown(object sender, MouseEventArgs e)
        {
            timerMap.Start();
        }
        private void btnZoomInTechDesc_MouseUp(object sender, MouseEventArgs e)
        {
            timerMap.Stop();
        }
        private void btnZoomOutTechDesc_MouseDown(object sender, MouseEventArgs e)
        {
            timerMap.Start();
        }
        private void btnZoomOutTechDesc_MouseUp(object sender, MouseEventArgs e)
        {
            timerMap.Stop();
        }

        private void btnZoomSelectedLotData_Click(object sender, EventArgs e)
        {
            lotData.ZoomToSelected();
            mapImageLotData.Refresh();
            mapImageLotData.Tag = mapImageLotData.Map.Zoom;
        }
        private void mapImageLotData_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                mapImageLotData.Map.Zoom += 10;
            }
            else
            {
                mapImageLotData.Map.Zoom -= 10;
            }
        }
        private void mapImageLotData_MouseEnter(object sender, EventArgs e)
        {
            //mapImageLotData.Focus();
        }

 
        // validator events
        private void validator_OnMustBeUniqueError(object myObject, DataColumnChangeEventArgs e)
        {

           


            //string msg = String.Format("You are trying to rename '{0}' to '{1}'. \nHowever, a record having the value '{1}' already exists.\n\nDo you wnat instead to MERGE '{0}' with '{1}'?", e.Row[e.Column].ToString(), e.ProposedValue.ToString());

            //DialogResult result = MessageBox.Show(msg, "Wait!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    // MERGE
            //    string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            //    string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            //    string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            //    string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            //    string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            //    string section = BindingSourceColumn(sectionBindingSource, "SectionId");
            //    string lotNo = BindingSourceColumn(lotBindingSource, "LotNo");

            //    string[] code = new string[] { };
            //    switch (e.Column.Table.TableName)
            //    {
            //        case "CadSurvey":
            //            code = new string[] {cadSurveyNo};
            //            break;
            //        case "Municipality":
            //            code = new string[] { cadSurveyNo, municipality };
            //            break;
            //        case "Case":
            //            code = new string[] { cadSurveyNo, municipality, cadCaseNo };
            //            break;
            //        case "Barangay":
            //            code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay };
            //            break;
            //        case "Quadrangle":
            //            code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle };
            //            break;
            //        case "Section":
            //            code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section };
            //            break;
            //        case "Lot":
            //            code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section, lotNo };
            //            break;
            //    }

            //    MergeRecord(code, e.ProposedValue.ToString());

            //}
            //else 
            //{
            //    //Cancel
            //}

            //MessageBox.Show("Table: " + e.Column.Table.TableName + "  Column: " + e.Column.ColumnName);
            //e.Row.SetColumnError(e.Column, String.Empty);
        }

        // methods
        private void DefineValidation()
        {
            validator = new DataSetValidator(lsdmsDataSet, ConnString);

            // define required fields
            validator.MustNotBeEmpty("CadSurvey.CadSurveyNo");
            validator.MustBeUnique("CadSurvey.CadSurveyNo");
          
            validator.MustNotBeEmpty("CadSurvey.RegionPsgc");
            validator.MustNotBeEmpty("CadSurvey.ProvincePsgc");

            validator.MustBeBetween("CadSurvey.ApprovedTotalCity", 0, 99);
            validator.MustBeBetween("CadSurvey.ApprovedTotalMunicipality", 0, 99);

            
            validator.MustBeBetween("CadSurvey.ApprovedTotalBarangay", 0, 99);
            validator.MustBeBetween("CadSurvey.ApprovedTotalLot", 0, 99);
            validator.MustBeBetween("CadSurvey.ApprovedTotalAreaHectares", 0, 999999);

            validator.MustNotBeEmpty("Municipality.MunicipalityPsgc");
            validator.MustBeUnique("Municipality.MunicipalityPsgc");

            validator.MustNotBeEmpty("Case.CadCaseNo");
            validator.MustBeUnique("Case.CadCaseNo");
            validator.MustBeBetween("Case.ModuleNo", 0, 999);

            validator.MustNotBeEmpty("Barangay.BarangayPsgc");
            validator.MustBeUnique("Barangay.BarangayPsgc");


            validator.MustNotBeEmpty("Quadrangle.Quadrangle");
            validator.MustBeUnique("Quadrangle.Quadrangle");

            

            validator.MustNotBeEmpty("Section.SectionId");
            validator.MustBeUnique("Section.SectionId");
            validator.MustBeBetween("Section.Scale",0,9999999);

            validator.MustNotBeEmpty("Lot.LotNo");
            validator.MustBeUnique("Lot.LotNo");

            validator.MustBeBetween("Lot.SurveyMonthFrom", 1, 12);
            validator.MustBeBetween("Lot.SurveyDayFrom", 1, 31);
            validator.MustBeBetween("Lot.SurveyYearFrom", 1900, 2100);

            validator.MustBeBetween("Lot.SurveyMonthTo", 1, 12);
            validator.MustBeBetween("Lot.SurveyDayTo", 1, 31);
            validator.MustBeBetween("Lot.SurveyYearTo ", 1900, 2100);



            validator.MustBeBetween("Lot.DeclaredArea", 0, 99999999);
            validator.MustBeBetween("Lot.TieLineDegree", 0, 90);
            validator.MustBeBetween("Lot.TieLineMinute", 0, 59);
            validator.MustBeBetween("Lot.TieLineDistance", 0, 9999999);


            validator.MustNotBeEmpty("LotData.Sequence");
            validator.MustBeUnique("LotData.Sequence");
            validator.MustBeBetween("LotData.Sequence", 1, 999);

            validator.MustBeBetween("LotData.PtmX",400,9999999);
            validator.MustBeBetween("LotData.PtmY",400,9999999);

            validator.MustBeBetween("LotData.PrsX", 400, 9999999);
            validator.MustBeBetween("LotData.PrsY", 400, 9999999);

            validator.MustNotBeEmpty("TechDesc.FromCorner");
            validator.MustBeUnique("TechDesc.FromCorner");
            validator.MustNotBeEmpty("TechDesc.ToCorner");
            validator.MustBeUnique("TechDesc.ToCorner");

            validator.MustBeBetween("TechDesc.Distance", 1, 9999999);
            validator.MustBeBetween("TechDesc.Degree", 0, 90);
            validator.MustBeBetween("TechDesc.Minute", 0, 59);
            
            validator.StartWatching();

            validator.OnMustBeUniqueError += new DataSetValidator.MustBeUniqueHandler(validator_OnMustBeUniqueError);

        }
        private void HookUpEvents()
        {
            // disable nav when edited
            lsdmsDataSet.CadSurvey.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Municipality.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Case.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Barangay.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Quadrangle.ColumnChanged +=new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Section.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.Lot.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.LotData.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);
            lsdmsDataSet.TechDesc.ColumnChanged += new DataColumnChangeEventHandler(LSDMS_ColumnChanged);


            // delete lotdata/techdesc row
            lsdmsDataSet.LotData.RowDeleted += new DataRowChangeEventHandler(LotDataTechDesc_RowDeleted);
            lsdmsDataSet.TechDesc.RowDeleted += new DataRowChangeEventHandler(LotDataTechDesc_RowDeleted);


            // new
            lsdmsDataSet.CadSurvey.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Municipality.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Case.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Barangay.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Quadrangle.TableNewRow +=new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Section.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.Lot.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.LotData.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            lsdmsDataSet.TechDesc.TableNewRow += new DataTableNewRowEventHandler(LSDMS_TableNewRow);
            
            // fill data
            cadSurveyBindingSource.PositionChanged += new EventHandler(cadSurveyBindingSource_PositionChanged);
            municipalityBindingSource.PositionChanged += new EventHandler(municipalityBindingSource_PositionChanged);
            caseBindingSource.PositionChanged += new EventHandler(caseBindingSource_PositionChanged);
            barangayBindingSource.PositionChanged += new EventHandler(barangayBindingSource_PositionChanged);
            quadrangleBindingSource.PositionChanged += new EventHandler(quadrangleBindingSource_PositionChanged);
            sectionBindingSource.PositionChanged += new EventHandler(sectionBindingSource_PositionChanged);
            lotBindingSource.PositionChanged += new EventHandler(lotBindingSource_PositionChanged);

            //lotDataGridView.BindingContext[0].Bindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;


            mnuItemLotDataGrid.Click += new EventHandler(mnuItemLotDataGrid_Click);

            

            
        }

  

        
        
        
        
        
        private void EnableDisableControl()
        {
            // Cad Survey
            panelCadSurvey.Enabled = (cadSurveyBindingSource.Count > 0);
            cadSurveyDeleteItem.Enabled = (cadSurveyBindingSource.Count > 0);
            cadSurveyMergeItem.Enabled = (cadSurveyBindingSource.Count > 0);


            // Municipality
            panelMunicipality.Enabled = (municipalityBindingSource.Count > 0);
            municipalityDeleteItem.Enabled = (municipalityBindingSource.Count > 0);
            municipalityMergeItem.Enabled = (municipalityBindingSource.Count > 0);
            municipalityChangeParentItem.Enabled = (municipalityBindingSource.Count > 0);

            // Case
            panelCase.Enabled = (caseBindingSource.Count > 0);
            caseDeleteItem.Enabled = (caseBindingSource.Count > 0);
            caseMergeItem.Enabled = (caseBindingSource.Count > 0);
            caseChangeParentItem.Enabled = (caseBindingSource.Count > 0);

            // Barangay
            panelBarangay.Enabled = (barangayBindingSource.Count > 0);
            barangayDeleteItem.Enabled = (barangayBindingSource.Count > 0);
            barangayMergeItem.Enabled = (barangayBindingSource.Count > 0);
            barangayChangeParentItem.Enabled = (barangayBindingSource.Count > 0);


            // Quadrangle
            panelQuadrangle.Enabled = (quadrangleBindingSource.Count > 0);
            quadrangleDeleteItem.Enabled = (quadrangleBindingSource.Count > 0);
            quadrangleMergeItem.Enabled = (quadrangleBindingSource.Count > 0);
            quadrangleChangeParentItem.Enabled = (quadrangleBindingSource.Count > 0);

            // Section
            panelSection.Enabled = (sectionBindingSource.Count > 0);
            sectionDeleteItem.Enabled = (sectionBindingSource.Count > 0);
            sectionMergeItem.Enabled = (sectionBindingSource.Count > 0);
            sectionChangeParentItem.Enabled = (sectionBindingSource.Count > 0);

            // Lot
            lotDeleteItem.Enabled = (lotBindingSource.Count > 0);
            lotChangeParentItem.Enabled = (lotBindingSource.Count > 0);
            tabControlLot.Enabled = (lotBindingSource.Count > 0);
           
        }









        private void FixBoundNullValue()
        {
            declaredAreaTextBox.DataBindings["Text"].NullValue = string.Empty;
            approvedTotalAreaHectaresTextBox.DataBindings["Text"].NullValue = string.Empty;
            approvedTotalBarangayTextBox.DataBindings["Text"].NullValue = string.Empty;
            approvedTotalCityTextBox.DataBindings["Text"].NullValue = string.Empty;
            approvedTotalLotTextBox.DataBindings["Text"].NullValue = string.Empty;
            approvedTotalMunicipalityTextBox.DataBindings["Text"].NullValue = string.Empty;
            moduleNoTextBox.DataBindings["Text"].NullValue = string.Empty;
            tieLineMinuteTextBox.DataBindings["Text"].NullValue = string.Empty;
            tieLineDegreeTextBox.DataBindings["Text"].NullValue = string.Empty;
            scaleTextBox.DataBindings["Text"].NullValue = string.Empty;
        }
        private void HookUpKeyDown(Control parent)
        {
            
            foreach (Control control in parent.Controls)
            {
                if (control.HasChildren)
                {
                    HookUpKeyDown(control);
                }

                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(ComboBox))
                {
                    control.KeyDown += new KeyEventHandler(Control_KeyDown);
                }
            }
        }
                
        private void DisableNavControls(bool disable)
        {
            disable = !disable;
            tableLayoutPanelNav.Enabled = disable;

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    cadSurveyPositionItem.Enabled = disable;
                    cadSurveyMoveFirstItem.Enabled = disable;
                    cadSurveyMovePreviousItem.Enabled = disable;
                    cadSurveyMoveNextItem.Enabled = disable;
                    cadSurveyMoveLastItem.Enabled = disable;
                    cadSurveyAddNewItem.Enabled = disable;
                    cadSurveyDeleteItem.Enabled = disable;
                    
                    cadSurveyMergeItem.Enabled = disable;

                    cadSurveySaveItem.Enabled = !disable;
                    cadSurveyCancelItem.Enabled = !disable;
                    break;
                case "Municipality":
                    municipalityPositionItem.Enabled = disable;
                    municipalityMoveFirstItem.Enabled = disable;
                    municipalityMovePreviousItem.Enabled = disable;
                    municipalityMoveNextItem.Enabled = disable;
                    municipalityMoveLastItem.Enabled = disable;
                    municipalityAddNewItem.Enabled = disable;
                    municipalityDeleteItem.Enabled = disable;

                    municipalityMergeItem.Enabled = disable;
                    municipalityChangeParentItem.Enabled = disable;

                    municipalitySaveItem.Enabled = !disable;
                    municipalityCancelItem.Enabled = !disable;
                    break;
                case "Case":
                    casePositionItem.Enabled = disable;
                    caseMoveFirstItem.Enabled = disable;
                    caseMovePreviousItem.Enabled = disable;
                    caseMoveNextItem.Enabled = disable;
                    caseMoveLastItem.Enabled = disable;
                    caseAddNewItem.Enabled = disable;
                    caseDeleteItem.Enabled = disable;

                    caseMergeItem.Enabled = disable;
                    caseChangeParentItem.Enabled = disable;

                    caseSaveItem.Enabled = !disable;
                    caseCancelItem.Enabled = !disable;
                    break;
                case "Barangay":
                    barangayPositionItem.Enabled = disable;
                    barangayMoveFirstItem.Enabled = disable;
                    barangayMovePreviousItem.Enabled = disable;
                    barangayMoveNextItem.Enabled = disable;
                    barangayMoveLastItem.Enabled = disable;
                    barangayAddNewItem.Enabled = disable;
                    barangayDeleteItem.Enabled = disable;

                    barangayMergeItem.Enabled = disable;
                    barangayChangeParentItem.Enabled = disable;

                    barangaySaveItem.Enabled = !disable;
                    barangayCancelItem.Enabled = !disable;
                    break;
                case "Quadrangle":
                    quadranglePositionItem.Enabled = disable;
                    quadrangleMoveFirstItem.Enabled = disable;
                    quadrangleMovePreviousItem.Enabled = disable;
                    quadrangleMoveNextItem.Enabled = disable;
                    quadrangleMoveLastItem.Enabled = disable;
                    quadrangleAddNewItem.Enabled = disable;
                    quadrangleDeleteItem.Enabled = disable;

                    quadrangleMergeItem.Enabled = disable;
                    quadrangleChangeParentItem.Enabled = disable;
                    

                    quadrangleSaveItem.Enabled = !disable;
                    quadrangleCancelItem.Enabled = !disable;
                    break;
                case "Section":
                    sectionPositionItem.Enabled = disable;
                    sectionMoveFirstItem.Enabled = disable;
                    sectionMovePreviousItem.Enabled = disable;
                    sectionMoveNextItem.Enabled = disable;
                    sectionMoveLastItem.Enabled = disable;
                    sectionAddNewItem.Enabled = disable;
                    sectionDeleteItem.Enabled = disable;

                    sectionMergeItem.Enabled = disable;
                    sectionChangeParentItem.Enabled = disable;

                    sectionSaveItem.Enabled = !disable;
                    sectionCancelItem.Enabled = !disable;
                    break;
                case "Lot":
                    lotPositionItem.Enabled = disable;
                    lotMoveFirstItem.Enabled = disable;
                    lotMovePreviousItem.Enabled = disable;
                    lotMoveNextItem.Enabled = disable;
                    lotMoveLastItem.Enabled = disable;
                    lotAddNewItem.Enabled = disable;
                    lotDeleteItem.Enabled = disable;

                    lotChangeParentItem.Enabled = disable;

                    lotSaveItem.Enabled = !disable;
                    lotCancelItem.Enabled = !disable;
                    break;
            }
        }
        private void DisableSaveControl(bool disable)
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    cadSurveySaveItem.Enabled = !disable;
                    break;
                case "Municipality":
                    municipalitySaveItem.Enabled = !disable;
                    break;
                case "Case":
                    caseSaveItem.Enabled = !disable;
                    break;
                case "Barangay":
                    barangaySaveItem.Enabled = !disable;
                    break;
                case "Quadrangle":
                    quadrangleSaveItem.Enabled = !disable;
                    break;
                case "Section":
                    sectionSaveItem.Enabled = !disable;
                    break;
                case "Lot":
                    lotSaveItem.Enabled = !disable;
                    break;
            }
            

        }
        
        private void UpdateNavLabel()
        {
            string locationLabel = string.Empty;
            //string separator = " • ";
            string separator = " \\ ";

            // Update nav label

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":

                    btnCadSurveyNav.Values.ExtraText = ((cadSurveyBindingSource.Current != null && ((DataRowView)cadSurveyBindingSource.Current).IsNew ? "<New>" : BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo")));
                    btnMunicipalityNav.Values.ExtraText = municipalityBindingSource.Count.ToString();
                    btnMunicipalityNav.Enabled = (cadSurveyBindingSource.Count > 0);
                    btnCaseNav.Values.ExtraText = "";
                    btnBarangayNav.Values.ExtraText = "";
                    btnQuadrangleNav.Values.ExtraText = "";
                    btnSectionNav.Values.ExtraText = "";
                    btnLotNav.Values.ExtraText = "";
                    locationLabel = btnCadSurveyNav.Values.ExtraText;
                    break;

                case "Municipality":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = ((municipalityBindingSource.Current != null && ((DataRowView)municipalityBindingSource.Current).IsNew ? "<New>" : BindingSourceColumn(municipalityBindingSource, "GEOG_NM")));
                    btnCaseNav.Values.ExtraText = caseBindingSource.Count.ToString();
                    btnCaseNav.Enabled = (municipalityBindingSource.Count > 0);
                    btnBarangayNav.Values.ExtraText = "";
                    btnQuadrangleNav.Values.ExtraText = "";
                    btnSectionNav.Values.ExtraText = "";
                    btnLotNav.Values.ExtraText = "";
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText;
                    break;
                case "Case":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = BindingSourceColumn(municipalityBindingSource, "GEOG_NM");
                    btnCaseNav.Values.ExtraText = ((caseBindingSource.Current != null && ((DataRowView)caseBindingSource.Current).IsNew) ? "<New>" : "Case " + BindingSourceColumn(caseBindingSource, "CadCaseNo"));
                    btnBarangayNav.Values.ExtraText = barangayBindingSource.Count.ToString();
                    btnBarangayNav.Enabled = (caseBindingSource.Count > 0);
                    btnQuadrangleNav.Values.ExtraText = "";
                    btnSectionNav.Values.ExtraText = "";
                    btnLotNav.Values.ExtraText = "";
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText + separator +
                                    btnCaseNav.Values.ExtraText;

                    break;
                case "Barangay":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = BindingSourceColumn(municipalityBindingSource, "GEOG_NM");
                    btnCaseNav.Values.ExtraText = "Case " + BindingSourceColumn(caseBindingSource, "CadCaseNo");
                    btnBarangayNav.Values.ExtraText = ((barangayBindingSource.Current != null && ((DataRowView)barangayBindingSource.Current).IsNew ? "<New>" : BindingSourceColumn(barangayBindingSource, "GEOG_NM")));
                    btnQuadrangleNav.Values.ExtraText = quadrangleBindingSource.Count.ToString();
                    btnQuadrangleNav.Enabled = (barangayBindingSource.Count > 0);
                    btnSectionNav.Values.ExtraText = "";
                    btnLotNav.Values.ExtraText = "";
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText + separator +
                                    btnCaseNav.Values.ExtraText + separator +
                                    btnBarangayNav.Values.ExtraText;
                    break;
                case "Quadrangle":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = BindingSourceColumn(municipalityBindingSource, "GEOG_NM");
                    btnCaseNav.Values.ExtraText = "Case " + BindingSourceColumn(caseBindingSource, "CadCaseNo");
                    btnBarangayNav.Values.ExtraText = BindingSourceColumn(barangayBindingSource, "GEOG_NM"); ;
                    btnQuadrangleNav.Values.ExtraText = ((quadrangleBindingSource.Current != null && ((DataRowView)quadrangleBindingSource.Current).IsNew ? "<New>" : BindingSourceColumn(quadrangleBindingSource, "Quadrangle")));
                    btnSectionNav.Values.ExtraText = sectionBindingSource.Count.ToString();
                    btnSectionNav.Enabled = (quadrangleBindingSource.Count > 0);
                    btnLotNav.Values.ExtraText = "";
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText + separator +
                                    btnCaseNav.Values.ExtraText + separator +
                                    btnBarangayNav.Values.ExtraText + separator +
                                    btnQuadrangleNav.Values.ExtraText;
                    break;
                case "Section":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = BindingSourceColumn(municipalityBindingSource, "GEOG_NM");
                    btnCaseNav.Values.ExtraText = "Case " + BindingSourceColumn(caseBindingSource, "CadCaseNo");
                    btnBarangayNav.Values.ExtraText = BindingSourceColumn(barangayBindingSource, "GEOG_NM");
                    btnQuadrangleNav.Values.ExtraText = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
                    btnSectionNav.Values.ExtraText = ((sectionBindingSource.Current != null && ((DataRowView)sectionBindingSource.Current).IsNew ? "<New>" : "Section " + BindingSourceColumn(sectionBindingSource, "SectionId")));
                    btnLotNav.Values.ExtraText = lotBindingSource.Count.ToString();
                    btnLotNav.Enabled = (sectionBindingSource.Count > 0);
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText + separator +
                                    btnCaseNav.Values.ExtraText + separator +
                                    btnBarangayNav.Values.ExtraText + separator +
                                    btnQuadrangleNav.Values.ExtraText + separator +
                                    btnSectionNav.Values.ExtraText;
                    break;
                case "Lot":
                    btnCadSurveyNav.Values.ExtraText = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
                    btnMunicipalityNav.Values.ExtraText = BindingSourceColumn(municipalityBindingSource, "GEOG_NM");
                    btnCaseNav.Values.ExtraText = "Case " + BindingSourceColumn(caseBindingSource, "CadCaseNo");
                    btnBarangayNav.Values.ExtraText = BindingSourceColumn(barangayBindingSource, "GEOG_NM");
                    btnSectionNav.Values.ExtraText = "Section " + BindingSourceColumn(sectionBindingSource, "SectionId");
                    btnLotNav.Values.ExtraText = ((lotBindingSource.Current != null && ((DataRowView)lotBindingSource.Current).IsNew ? "<New>" : "Lot " + BindingSourceColumn(lotBindingSource, "LotNo")));
                    locationLabel = btnCadSurveyNav.Values.ExtraText + separator +
                                    btnMunicipalityNav.Values.ExtraText + separator +
                                    btnCaseNav.Values.ExtraText + separator +
                                    btnBarangayNav.Values.ExtraText + separator +
                                    btnQuadrangleNav.Values.ExtraText + separator +
                                    btnSectionNav.Values.ExtraText + separator +
                                    btnLotNav.Values.ExtraText;
                    //RefreshLotDataMapImage();
                    break;
            }


            //Update location label
            dataEntryHeaderGroup.ValuesPrimary.Heading = locationLabel;

        }
        private void UpdateRegionPsgc()
        {
            // stop watching changes
            regionPsgcComboBox.SelectedValueChanged -= new EventHandler(regionPsgcComboBox_SelectedValueChanged);

            regionPsgcComboBox.SelectedIndex = -1;
            if (cadSurveyBindingSource.Current != null)
            {
                regionPsgcComboBox.SelectedValue = ((DataRowView)cadSurveyBindingSource.Current)["RegionPsgc"].ToString();
            }

            // start watching changes
            regionPsgcComboBox.SelectedValueChanged += new EventHandler(regionPsgcComboBox_SelectedValueChanged);

            UpdateProvincePsgc();
        }
        private void UpdateProvincePsgc()
        {
            // stop watching changes 
            provincePsgcComboBox.SelectedValueChanged -=new EventHandler(provincePsgcComboBox_SelectedValueChanged);
            provincePsgcComboBox.SelectedIndex = -1;
            provincePsgcComboBox.DataSource = null;
            if (regionPsgcComboBox.SelectedValue != null)
            {
                provincePsgcComboBox.DataSource = provincePsgcTableAdapter.GetDataByRegionPsgc(regionPsgcComboBox.SelectedValue.ToString());
                provincePsgcComboBox.DisplayMember = "GEOG_NM";
                provincePsgcComboBox.ValueMember = "PSGC";
                provincePsgcComboBox.SelectedValue = ((DataRowView)cadSurveyBindingSource.Current)["ProvincePsgc"].ToString();
            }

            // start watching changes 
            provincePsgcComboBox.SelectedValueChanged +=new EventHandler(provincePsgcComboBox_SelectedValueChanged);

            UpdateMunicipalityPsgc();
        }
        private void UpdateMunicipalityPsgc()
        {
            // stop watching changes 
            municipalityPsgcListBox.SelectedValueChanged -= new EventHandler(municipalityPsgcListBox_SelectedValueChanged);
            municipalityPsgcListBox.SelectedIndex = -1;
            municipalityPsgcListBox.DataSource = null;
            municipalityPsgcListBox.DisplayMember = "GEOG_NM";
            municipalityPsgcListBox.ValueMember = "PSGC";
            if (provincePsgcComboBox.SelectedValue != null)
            {
                municipalityPsgcListBox.DataSource = municipalityPsgcTableAdapter.GetDataByProvincePSGC(provincePsgcComboBox.SelectedValue.ToString());
                if (municipalityBindingSource.Current != null)
                    municipalityPsgcListBox.SelectedValue = ((DataRowView)municipalityBindingSource.Current)["MunicipalityPsgc"].ToString();
                    
            }

            // start watching changes 
            municipalityPsgcListBox.SelectedValueChanged += new EventHandler(municipalityPsgcListBox_SelectedValueChanged);
            UpdateBarangayPsgc();
        }
        private void UpdateBarangayPsgc()
        {
            // stop watching changes 
            barangayPsgcListBox.SelectedValueChanged -= new EventHandler(barangayPsgcListBox_SelectedValueChanged);
            barangayPsgcListBox.SelectedIndex = -1;
            barangayPsgcListBox.DataSource = null;
            barangayPsgcListBox.DisplayMember = "GEOG_NM";
            barangayPsgcListBox.ValueMember = "PSGC";
            if (municipalityPsgcListBox.SelectedValue != null)
            {
                barangayPsgcListBox.DataSource = barangayPsgcTableAdapter.GetDataByMunicipalityPSGC(municipalityPsgcListBox.SelectedValue.ToString());
                if (barangayBindingSource.Current != null)
                {
                    barangayPsgcListBox.SelectedValue = ((DataRowView)barangayBindingSource.Current)["BarangayPsgc"].ToString();
                }
            }

            // start watching changes 
            barangayPsgcListBox.SelectedValueChanged += new EventHandler(barangayPsgcListBox_SelectedValueChanged);
        }
        private void UpdateReferencePoint()
        {
            // stop monitoring changes
            referencePointComboBox.SelectedValueChanged -= new EventHandler(referencePointComboBox_SelectedValueChanged);

            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            referencePointComboBox.DataSource = ref_Type_TableTableAdapter.GetDataByProjectNo(cadSurveyNo);
            referencePointComboBox.DisplayMember = "ReferencePoint";
            referencePointComboBox.ValueMember = "ReferencePoint";

            if (lotBindingSource.Current != null)
                referencePointComboBox.SelectedValue = ((DataRowView)lotBindingSource.Current)["ReferencePoint"];

            // update coordinates display
            UpdateReferencePointCoordinatesDisplay();

            // start monitoring changes
            referencePointComboBox.SelectedValueChanged += new EventHandler(referencePointComboBox_SelectedValueChanged);
        }
        private void UpdateReferencePointCoordinatesDisplay()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string referencePoint = BindingSourceColumn(lotBindingSource, "ReferencePoint");
            lblReferencePoint.Text = cadSurveyNo + " : " + referencePoint;
            DataRow coords = RefPointCoords(cadSurveyNo, referencePoint);

            string output = string.Empty;

            if (coords != null)
            {
                string ptmY= coords["True_Northing"] == DBNull.Value ? "0" : coords["True_Northing"].ToString();
                string ptmX = coords["True_Easting"] == DBNull.Value ? "0" : coords["True_Easting"].ToString();
                //string localY = coords["False_Northing"] == null ? "" : coords["False_Northing"].ToString();
                //string localX = coords["False_Easting"] == null ? "" : coords["False_Easting"].ToString();
                //string latitude = coords["latitude"] == null ? "" : coords["latitude"].ToString();
                //string longitude = coords["longitude"] == null ? "" : coords["longitude"].ToString();



                output = String.Format("N: {0}\nE: {1}", String.Format("{0:0,0.00}", Convert.ToDouble(ptmY)).PadLeft(13), String.Format("{0:0,0.00}", Convert.ToDouble(ptmX)).PadLeft(13));
                                
            }

            lblReferencePoint.Text = output;
            //MessageBox.Show(dr["True_Northing"].ToString());
        }
        
        private void RefreshMapImage()
        {
            if (BindingSourceColumn(lotBindingSource, "LotNo") == "")
                return;

            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            string section = BindingSourceColumn(sectionBindingSource, "SectionId");
            string lotNo = BindingSourceColumn(lotBindingSource, "LotNo");

            string cs = cadSurveyTableAdapter.Connection.ConnectionString;


            lotData = new GheloBytes.LotData(cs, cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section, lotNo);
            lotData.ComposeMap();
            lotData.ZoomToSelected();
            
            if (mapImageLotData.Tag == null)
            {
                mapImageLotData.Tag = lotData.Map.Zoom;
            }
            else
            {
                lotData.Map.Zoom = Convert.ToDouble(mapImageLotData.Tag);
            }

            mapImageLotData.Map = lotData.Map;
            mapImageLotData.Refresh();

            techDesc = new GheloBytes.TechDesc(cs, cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section, lotNo);
            techDesc.ComposeMap();


            //if (mapImageTechDesc.Tag == null)
            //{
            //    mapImageTechDesc.Tag = techDesc.Map.Zoom;
            //}
            //else
            //{
            //    techDesc.Map.Zoom = Convert.ToDouble(mapImageTechDesc.Tag);
            //}

            mapImageTechDesc.Map = techDesc.Map;

            mapImageTechDesc.Refresh();
                


        }
        private void ComputeLotData()
        {
            if (lotDataBindingSource.Current == null)
                return;
            // lotDataBindingSource.Current is null if new record
  

            if (!CurrentBindingSource().Equals(lotBindingSource))
                return;

            if (lotDataGridView.Rows.Count == 0)
                return;
            double[] changeInLatList = new double[lotDataGridView.Rows.Count - 1];
            double[] changeInDepList = new double[lotDataGridView.Rows.Count - 1];
            double[] tdDistanceList = new double[lotDataGridView.Rows.Count - 1];
            string[] NSList = new string[lotDataGridView.Rows.Count - 1];
            string[] EWList = new string[lotDataGridView.Rows.Count - 1];
            int[] degreeList = new int[lotDataGridView.Rows.Count - 1];
            int[] minuteList = new int[lotDataGridView.Rows.Count - 1];
            double[] dmdList = new double[lotDataGridView.Rows.Count - 1];
            double[] dpaList = new double[lotDataGridView.Rows.Count - 1];


            foreach (DataGridViewRow row in lotDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    int firstStationIndex = 0;
                    int currentStationIndex = row.Index;
                    int nextStationIndex = row.Index + 1;
                    int prevStationIndex = row.Index - 1;
                    int lastStationIndex = lotDataGridView.NewRowIndex - 1;
                    object value;

                    value = GetCell(firstStationIndex, "Northing").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double firstNorthing = Convert.ToDouble(value);

                    value = GetCell(firstStationIndex, "Easting").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double firstEasting = Convert.ToDouble(value);

                    value = GetCell(currentStationIndex, "Northing").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double currentNorthing = Convert.ToDouble(value);

                    value = GetCell(currentStationIndex, "Easting").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double currentEasting = Convert.ToDouble(value);


                    value = GetCell(nextStationIndex, "Northing").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double nextNorthing = Convert.ToDouble(value);


                    value = GetCell(nextStationIndex, "Easting").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double nextEasting = Convert.ToDouble(value);

                    value = GetCell(nextStationIndex, "Northing").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double lastNorthing = Convert.ToDouble(value);


                    value = GetCell(nextStationIndex, "Easting").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    double lastEasting = Convert.ToDouble(value);




                    //double firstNorthing = Convert.ToDouble(GetCell(firstStationIndex, "Northing").Value);
                    //double firstEasting = Convert.ToDouble(GetCell(firstStationIndex, "Easting").Value);
                    //double currentNorthing = Convert.ToDouble(GetCell(currentStationIndex, "Northing").Value);
                    //double currentEasting = Convert.ToDouble(GetCell(currentStationIndex, "Easting").Value);

                    //double nextNorthing = Convert.ToDouble(GetCell(nextStationIndex, "Northing").Value);
                    //double nextEasting = Convert.ToDouble(GetCell(nextStationIndex, "Easting").Value);
                    //double lastNorthing = Convert.ToDouble(GetCell(lastStationIndex, "Northing").Value);
                    //double lastEasting = Convert.ToDouble(GetCell(lastStationIndex, "Easting").Value);




                    double changeInLat = (currentStationIndex == lastStationIndex) ? currentNorthing - firstNorthing : currentNorthing - nextNorthing;
                    changeInLatList[currentStationIndex] = changeInLat;

                    double changeInDep = (currentStationIndex == lastStationIndex) ? currentEasting - firstEasting : currentEasting - nextEasting;
                    changeInDepList[currentStationIndex] = changeInDep;


                    double tdDistance = Math.Sqrt(Math.Pow(changeInLat, 2) + Math.Pow(changeInDep, 2));
                    tdDistanceList[currentStationIndex] = tdDistance;

                    string NS = ((changeInLat > 0) ? "S" : "N");
                    NSList[currentStationIndex] = NS;

                    string EW = ((changeInDep > 0) ? "W" : "E");
                    EWList[currentStationIndex] = EW;

                    double n = Math.Atan(changeInDep / changeInLat);
                    double o = Math.Abs(n * 180 / Math.PI);
                    o = o.ToString().ToUpper() == "NAN" ? 0 : o;

                    int p = Convert.ToInt32(Math.Truncate(o)); // round down

                    double q = (o - Convert.ToDouble(p)) * 60;

                    int degree = (Convert.ToInt32(q) == 60) ? p + 1 : p;
                    degreeList[currentStationIndex] = degree;

                    int minute = (Convert.ToInt32(q) == 60) ? 0 : Convert.ToInt32(q);
                    minuteList[currentStationIndex] = minute;

                    double dmd = (currentStationIndex == firstStationIndex) ? changeInLat : dmdList[prevStationIndex] + changeInLatList[prevStationIndex] + changeInLatList[currentStationIndex];
                    dmdList[currentStationIndex] = dmd;

                    double dpa = dmd * changeInDep;
                    dpaList[currentStationIndex] = dpa;
                    

                    //GetCell(currentStationIndex, "ChangeInLat").Value = changeInLat;
                    //GetCell(currentStationIndex, "ChangeInDep").Value = changeInDep;
                    //GetCell(currentStationIndex, "TDDistance").Value = tdDistance;
                    GetCell(currentStationIndex, "NS").Value = NS;
                    GetCell(currentStationIndex, "Degree").Value = degree;
                    GetCell(currentStationIndex, "Minute").Value = minute;
                    GetCell(currentStationIndex, "EW").Value = EW;
                    GetCell(currentStationIndex, "Distance").Value = tdDistance.ToString("0.00");
                    //GetCell(currentStationIndex, "DMD").Value = dmd;
                    //GetCell(currentStationIndex, "DPA").Value = dpa;

                }                
            }

            //autofit
            //foreach (DataGridViewColumn col in lotDataGridView.Columns)
            //{
            //    //col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}

            double doubleArea = 0;
            foreach (double dpaArea in dpaList)
            {
                doubleArea += dpaArea;
            }

            double area = doubleArea / 2;


            // compute the area
            if (computedAreaTextBox.Text == String.Empty ||
                computedAreaTextBox.Text != area.ToString("0.00"))
            {
                

                if (area > 99999999 | area < 0)
                {
                    computedAreaTextBox.Text = "0.00";
                } else {
                    computedAreaTextBox.Text = area.ToString("0.00");
                }



                if (((DataRowView)lotDataBindingSource.Current).IsEdit)
                    lotSaveItem.PerformClick();
                    
                    

                //lotSaveItem.PerformClick();
                //lotBindingSource.EndEdit();
                //lotTableAdapter.Update(lsdmsDataSet.Lot);
            }


            if (computedAreaTextBox.Text != declaredAreaTextBox.Text)
            {
                //MessageBox.Show("Warning!: Declared and Computed area is not equal.");
                declaredAreaTextBox.ForeColor = Color.Red;
            }
            else
            {
                declaredAreaTextBox.ForeColor = Color.Black;
            }

        }

        private void SetConnectionString()
        {
            string server = GetSetting("servers", "DatabaseServer", "name");
            ConnString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92";
            cadSurveyTableAdapter.Connection.ConnectionString = ConnString;
            municipalityTableAdapter.Connection.ConnectionString = ConnString;
            caseTableAdapter.Connection.ConnectionString = ConnString;
            barangayTableAdapter.Connection.ConnectionString = ConnString;
            quadrangleTableAdapter.Connection.ConnectionString = ConnString;
            sectionTableAdapter.Connection.ConnectionString = ConnString;
            lotTableAdapter.Connection.ConnectionString = ConnString;

            lotDataTableAdapter.Connection.ConnectionString = ConnString;
            techDescTableAdapter.Connection.ConnectionString = ConnString;
            ref_Type_TableTableAdapter.Connection.ConnectionString = ConnString;

            regionPsgcTableAdapter.Connection.ConnectionString = ConnString;
            provincePsgcTableAdapter.Connection.ConnectionString = ConnString;
            municipalityPsgcTableAdapter.Connection.ConnectionString = ConnString;
            barangayPsgcTableAdapter.Connection.ConnectionString = ConnString;

        }
        private void SetImageServer()
        {
            ImageServerName = GetSetting("servers", "ImageServer", "name");
            ImageServerUrl = @"http://" + ImageServerName + @"/ImageServer/Service.asmx";
        }
        private void SetSetting(string section, string setting, string attribute, string value)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            node.Attributes[attribute].Value = value;
        }

        private void Copy(Stream source, Stream target)
        {
            byte[] buffer = new byte[0x10000];
            int bytes;
            try
            {
                while ((bytes = source.Read(buffer, 0, buffer.Length)) > 0)
                {
                    target.Write(buffer, 0, bytes);
                }
            }
            finally
            {
                target.Flush();
                // Or target.Close(); if you're done here already.
            }
        }
        private void GotoPageDown()
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    btnMunicipalityNav.PerformClick();
                    //municipalityPsgcListBox.Focus();
                    break;
                case "Municipality":
                    btnCaseNav.PerformClick();
                    //cadCaseNoTextBox.Focus();
                    break;
                case "Case":
                    btnBarangayNav.PerformClick();
                    //barangayPsgcListBox.Focus();
                    break;
                case "Barangay":
                    btnSectionNav.PerformClick();
                    //sectionIdTextBox.Focus();
                    break;
                case "Section":
                    btnLotNav.PerformClick();
                    //lotNoTextBox.Focus();
                    break;
                case "Lot":
                    // do nothing
                    break;
            }
        }
        private void GotoPageUp()
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    // do nothing
                    break;
                case "Municipality":
                    btnCadSurveyNav.PerformClick();
                    //cadSurveyNoTextBox.Focus();
                    break;
                case "Case":
                    btnMunicipalityNav.PerformClick();
                    //municipalityPsgcListBox.Focus();
                    break;
                case "Barangay":
                    btnCaseNav.PerformClick();
                    //cadCaseNoTextBox.Focus();
                    break;
                case "Section":
                    btnBarangayNav.PerformClick();
                    //barangayPsgcListBox.Focus();
                    break;
                case "Lot":
                    btnSectionNav.PerformClick();
                    //lotNoTextBox.Focus();
                    break;
            }
        }

        private void InitMap()
        {
            mapImageLotData.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;
            mapImageTechDesc.ActiveTool = SharpMap.Forms.MapBox.Tools.Pan;

            timerMap.Tick += new EventHandler(timerMap_Tick);

            mapImageLotData.MouseWheel +=new MouseEventHandler(mapImageLotData_MouseWheel);
        }

      
      

        // fill data
        private void FillCadSurvey()
        {
            cadSurveyTableAdapter.Fill(lsdmsDataSet.CadSurvey);
            UpdateNavLabel();
        }
        private void FillMunicipality()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            municipalityTableAdapter.FillByCadSurveyNo(lsdmsDataSet.Municipality, cadSurveyNo);
            UpdateNavLabel();
        }
        private void FillCase()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            caseTableAdapter.FillByMunicipality(lsdmsDataSet.Case, cadSurveyNo, municipality);
            UpdateNavLabel();
        }
        private void FillBarangay()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            barangayTableAdapter.FillByCaseNo(lsdmsDataSet.Barangay, cadSurveyNo, municipality, cadCaseNo);
            UpdateNavLabel();
        }
        private void FillQuadrangle()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            quadrangleTableAdapter.FillByBarangay(lsdmsDataSet.Quadrangle, cadSurveyNo, municipality, cadCaseNo, barangay);
            UpdateNavLabel();
        }
        private void FillSection()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            sectionTableAdapter.FillByQuadrangle(lsdmsDataSet.Section, cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle);
            
            UpdateNavLabel();

        }
        private void FillLot()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            string section = BindingSourceColumn(sectionBindingSource, "SectionId");

            if (Level > 1)
            {
                lotTableAdapter.FillBySection(lsdmsDataSet.Lot, cadSurveyNo, municipality, cadCaseNo, barangay, section, quadrangle);
            }
            else
            {
                lotTableAdapter.FillByUser(lsdmsDataSet.Lot, cadSurveyNo, municipality, cadCaseNo, barangay, section, quadrangle, UserName);
            }
            

            UpdateNavLabel();
            
        }
        private void FillLotDataTechDesc()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipalityPsgc = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string caseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangayPsgc = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            string sectionId = BindingSourceColumn(sectionBindingSource, "SectionId");
            string lotNo = BindingSourceColumn(lotBindingSource, "LotNo");
            lotDataTableAdapter.FillByLot(lsdmsDataSet.LotData, cadSurveyNo, municipalityPsgc, caseNo, barangayPsgc,quadrangle, sectionId, lotNo);
            techDescTableAdapter.FillByLot(lsdmsDataSet.TechDesc, cadSurveyNo, municipalityPsgc, caseNo, barangayPsgc,quadrangle, sectionId, lotNo);
            RefreshMapImage();
        }
        private void FillPsgc()
        {
            provincePsgcTableAdapter.Fill(this.psgc.Province);
            regionPsgcTableAdapter.Fill(this.psgc.Region);
            municipalityPsgcTableAdapter.Fill(this.psgc.Municipality);
        }

        private void MergeItem()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            string section = BindingSourceColumn(sectionBindingSource, "SectionId");
            string lotNo = BindingSourceColumn(lotBindingSource, "LotNo");


            string[] code = new string[] { };
            string displayName = "";

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    code = new string[] { cadSurveyNo };
                    displayName = cadSurveyNo;
                    break;
                case "Municipality":
                    code = new string[] { cadSurveyNo, municipality };
                    displayName = listBoxMunicipality.Text;
                    break;
                case "Case":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo };
                    displayName = cadCaseNo;
                    break;
                case "Barangay":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay };
                    displayName = listBoxBarangay.Text;
                    break;
                case "Quadrangle":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle };
                    displayName = quadrangle;
                    break;
                case "Section":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section };
                    displayName = section;
                    break;
                case "Lot":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section, lotNo };
                    displayName = lotNo;
                    break;
            }


            MergeForm frm = new MergeForm(code, displayName);

            frm.ShowDialog();

            if (frm.AffectedRecords > 0)
            {

                switch (kryptonCheckSetNav.CheckedButton.Text)
                {
                    case "Cad Survey":
                        FillCadSurvey();
                        listBoxCadSurvey.SelectedValue = frm.SelectedValue;
                        break;
                    case "Municipality":
                        FillMunicipality();
                        listBoxMunicipality.SelectedValue = frm.SelectedValue;
                        break;
                    case "Case":
                        FillCase();
                        listBoxCase.SelectedValue = frm.SelectedValue;
                        break;
                    case "Barangay":
                        FillBarangay();
                        listBoxBarangay.SelectedValue = frm.SelectedValue;
                        break;
                    case "Quadrangle":
                        FillQuadrangle();
                        listBoxQuadrangle.SelectedValue = frm.SelectedValue;
                        break;
                    case "Section":
                        FillSection();
                        listBoxSection.SelectedValue = frm.SelectedValue;
                        break;
                    case "Lot":
                        FillLot();
                        listBoxLot.SelectedValue = frm.SelectedValue;
                        break;
                }

            }

            frm.Dispose();           
        }
        private void ChangeParent()
        {
            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string municipality = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");
            string cadCaseNo = BindingSourceColumn(caseBindingSource, "CadCaseNo");
            string barangay = BindingSourceColumn(barangayBindingSource, "BarangayPsgc");
            string quadrangle = BindingSourceColumn(quadrangleBindingSource, "Quadrangle");
            string section = BindingSourceColumn(sectionBindingSource, "SectionId");
            string lotNo = BindingSourceColumn(lotBindingSource, "LotNo");


            string[] code = new string[] { };
            string displayName = "";

            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    code = new string[] { cadSurveyNo };
                    displayName = cadSurveyNo;
                    break;
                case "Municipality":
                    code = new string[] { cadSurveyNo, municipality };
                    displayName = listBoxMunicipality.Text;
                    break;
                case "Case":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo };
                    displayName = cadCaseNo;
                    break;
                case "Barangay":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay };
                    displayName = listBoxBarangay.Text;
                    break;
                case "Quadrangle":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle };
                    displayName = quadrangle;
                    break;
                case "Section":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section };
                    displayName = section;
                    break;
                case "Lot":
                    code = new string[] { cadSurveyNo, municipality, cadCaseNo, barangay, quadrangle, section, lotNo };
                    displayName = lotNo;
                    break;
            }

            ChangeParentForm frm = new ChangeParentForm(code, displayName);

            frm.ShowDialog();

            if (frm.AffectedRecords > 0)
            {

                switch (kryptonCheckSetNav.CheckedButton.Text)
                {
                    case "Cad Survey": // this will never happen
                        FillCadSurvey();
                        listBoxCadSurvey.SelectedValue = frm.SelectedValue;
                        break;
                    case "Municipality":
                        listBoxCadSurvey.SelectedValue = frm.SelectedParentValue;
                        FillMunicipality();
                        listBoxMunicipality.SelectedValue = frm.SelectedValue;
                        break;
                    case "Case":
                        listBoxMunicipality.SelectedValue = frm.SelectedParentValue;
                        FillCase();
                        listBoxCase.SelectedValue = frm.SelectedValue;
                        break;
                    case "Barangay":
                        listBoxCase.SelectedValue = frm.SelectedParentValue;
                        FillBarangay();
                        listBoxBarangay.SelectedValue = frm.SelectedValue;
                        break;
                    case "Quadrangle":
                        listBoxBarangay.SelectedValue = frm.SelectedParentValue;
                        FillQuadrangle();
                        listBoxQuadrangle.SelectedValue = frm.SelectedValue;
                        break;
                    case "Section":
                        listBoxQuadrangle.SelectedValue = frm.SelectedParentValue;
                        FillSection();
                        listBoxSection.SelectedValue = frm.SelectedValue;
                        break;
                    case "Lot":
                        listBoxSection.SelectedValue = frm.SelectedParentValue;
                        FillLot();
                        listBoxLot.SelectedValue = frm.SelectedValue;
                        break;
                }
            }

        }


        // functions
        private BindingSource CurrentBindingSource()
        {
            switch (kryptonCheckSetNav.CheckedButton.Text)
            {
                case "Cad Survey":
                    return cadSurveyBindingSource;
                case "Municipality":
                    return municipalityBindingSource;
                case "Case":
                    return caseBindingSource;
                case "Barangay":
                    return barangayBindingSource;
                case "Section":
                    return sectionBindingSource;
                case "Lot":
                    return lotBindingSource;
                default:
                    return null;
            }
        }
        private string BindingSourceColumn(BindingSource bs, string columnName)
        {
            return (bs.Current == null ? string.Empty : ((DataRowView)bs.Current)[columnName].ToString());
        }
        private Image ByteToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }
        private DataGridViewCell GetCell(int rowIndex, string columnName)
        {
            KryptonDataGridView dg = lotDataGridView;

            //foreach (DataGridViewColumn col in dg.Columns)
            //{
            //    Console.WriteLine(col.Name);
            //}


            return dg.Rows[rowIndex].Cells[columnName];
        }
        private DataRow RefPointCoords(string cadSurveyNo, string referencePoint)
        {
            string sql = String.Format(" SELECT True_Northing, True_Easting,   " +
                                       "        False_Northing, False_Easting, " +
                                       "        Latitude, Longitude            " +
                                       " FROM [Ref_Type_Table] WHERE           " +
                                       " Project_No = '{0}' AND                " +
                                       " Ref_Type + ' ' + CAST(Ref_Type_No AS varchar(10)) = '{1}' ", cadSurveyNo, referencePoint);
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(sql, ConnString);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            return (dt.Rows.Count > 0 ? dt.Rows[0] : null);
        }
        private DataTable GetLotData(DataTable dtLotData)
        {

            if (dtLotData.Rows.Count < 0)
                return null;

            double[] changeInLatList = new double[dtLotData.Rows.Count];
            double[] changeInDepList = new double[dtLotData.Rows.Count];
            double[] tdDistanceList = new double[dtLotData.Rows.Count];
            string[] NSList = new string[dtLotData.Rows.Count];
            string[] EWList = new string[dtLotData.Rows.Count];
            int[] degreeList = new int[dtLotData.Rows.Count];
            int[] minuteList = new int[dtLotData.Rows.Count];
            double[] dmdList = new double[dtLotData.Rows.Count];
            double[] dpaList = new double[dtLotData.Rows.Count];

            dtLotData.Columns.Add("NS", typeof(string));
            dtLotData.Columns.Add("Degree", typeof(int));
            dtLotData.Columns.Add("Minute", typeof(int));
            dtLotData.Columns.Add("EW", typeof(string));
            dtLotData.Columns.Add("Distance", typeof(double));
            dtLotData.Columns.Add("Area", typeof(double));

            int rowIndex = -1;
            foreach (DataRow row in dtLotData.Rows)
            {

                rowIndex++;

                int firstStationIndex = 0;
                int currentStationIndex = rowIndex;
                int nextStationIndex = rowIndex + 1;
                int prevStationIndex = rowIndex - 1;
                int lastStationIndex = dtLotData.Rows.Count - 1;
                object value;

                value = dtLotData.Rows[firstStationIndex]["PtmY"];
                //value = GetCell(firstStationIndex, "PtmY").Value;
                if (value == DBNull.Value) { value = "0"; }
                double firstNorthing = Convert.ToDouble(value);

                value = dtLotData.Rows[firstStationIndex]["PtmX"];
                //value = GetCell(firstStationIndex, "PtmX").Value;
                if (value == DBNull.Value) { value = "0"; }
                double firstEasting = Convert.ToDouble(value);


                value = dtLotData.Rows[currentStationIndex]["PtmY"];
                //value = GetCell(currentStationIndex, "PtmY").Value;
                if (value == DBNull.Value) { value = "0"; }
                double currentNorthing = Convert.ToDouble(value);

                value = dtLotData.Rows[currentStationIndex]["PtmX"];
                //value = GetCell(currentStationIndex, "PtmX").Value;
                if (value == DBNull.Value) { value = "0"; }
                double currentEasting = Convert.ToDouble(value);


                double nextNorthing = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex]["PtmY"];
                    //value = GetCell(nextStationIndex, "PtmY").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    nextNorthing = Convert.ToDouble(value);
                }


                double nextEasting = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex]["PtmX"];
                    //value = GetCell(nextStationIndex, "PtmX").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    nextEasting = Convert.ToDouble(value);
                }


                double lastNorthing = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex]["PtmY"];
                    //value = GetCell(nextStationIndex, "PtmY").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    lastNorthing = Convert.ToDouble(value);
                }


                double lastEasting = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex]["PtmX"];
                    //value = GetCell(nextStationIndex, "PtmX").Value;
                    if (value == DBNull.Value) { value = "0"; }
                    lastEasting = Convert.ToDouble(value);
                }



                double changeInLat = (currentStationIndex == lastStationIndex) ? currentNorthing - firstNorthing : currentNorthing - nextNorthing;
                changeInLatList[currentStationIndex] = changeInLat;

                double changeInDep = (currentStationIndex == lastStationIndex) ? currentEasting - firstEasting : currentEasting - nextEasting;
                changeInDepList[currentStationIndex] = changeInDep;


                double tdDistance = Math.Sqrt(Math.Pow(changeInLat, 2) + Math.Pow(changeInDep, 2));
                tdDistanceList[currentStationIndex] = tdDistance;

                string NS = ((changeInLat > 0) ? "S" : "N");
                NSList[currentStationIndex] = NS;

                string EW = ((changeInDep > 0) ? "W" : "E");
                EWList[currentStationIndex] = EW;

                double n = Math.Atan(changeInDep / changeInLat);
                double o = Math.Abs(n * 180 / Math.PI);
                o = o.ToString().ToUpper() == "NAN" ? 0 : o;

                int p = Convert.ToInt32(Math.Truncate(o)); // round down

                double q = (o - Convert.ToDouble(p)) * 60;

                int degree = (Convert.ToInt32(q) == 60) ? p + 1 : p;
                degreeList[currentStationIndex] = degree;

                int minute = (Convert.ToInt32(q) == 60) ? 0 : Convert.ToInt32(q);
                minuteList[currentStationIndex] = minute;

                double dmd = (currentStationIndex == firstStationIndex) ? changeInLat : dmdList[prevStationIndex] + changeInLatList[prevStationIndex] + changeInLatList[currentStationIndex];
                dmdList[currentStationIndex] = dmd;

                double dpa = dmd * changeInDep;
                dpaList[currentStationIndex] = dpa;


                row["NS"] = NS;
                row["Degree"] = degree;
                row["Minute"] = minute;
                row["EW"] = EW;
                row["Distance"] = tdDistance;

            }




            double doubleArea = 0;
            foreach (double dpaArea in dpaList)
            {
                doubleArea += dpaArea;
            }

            double area = doubleArea / 2;

            foreach (DataRow row in dtLotData.Rows)
            {
                row["Area"] = area;
            }
       
            return dtLotData;

        }


        // DIRTY
        private void mnuItemLotDataGrid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("x");
        }
        private void MergeItem_Click(object sender, EventArgs e)
        {
            MergeItem();
        }
        private void ChangeParentItem_Click(object sender, EventArgs e)
        {
            ChangeParent();
        }





        private struct PTM 
        {
            public double Easting;    // Easting
            public double Northing;    // Northing
        }
        private PTM LocalToGridAlgorithm(int LatD, int LatM, double LatS, int LongD, int LongM, double LongS, double OriginY, double OriginX, double FalseNorthing, double FalseEasting, int CentralMeridian)
        {
            PTM functionReturnValue = default(PTM);
            double E2 = 0;
            double A = 0;
            double b = 0;
            double Ko = 0;
            double cons_26 = 0;
            double Pi = 0;
            double Delta_N = 0;
            double Delta_E = 0;
            double Bearing = 0;
            string N_S = null;
            string E_W = null;
            int Quadrant = 0;
            double Azimuth = 0;
            double DistanceX = 0;
            int CM = 0;
            double Lambda = 0;
            double Diff_Long_Min = 0;
            double Diff_Long_Sec = 0;
            double Phi = 0;
            double Phi_Radians = 0;
            double Sin_Phi_Radians = 0;
            double Convergence = 0;
            double t = 0;
            double e2_prime = 0;
            double sec_1 = 0;
            double n = 0;
            double A0 = 0;
            double A1 = 0;
            double A2 = 0;
            double A3 = 0;
            double i = 0;
            double II = 0;
            double III = 0;
            double IV = 0;
            double V = 0;
            double VI = 0;
            double Delta_Lambda_Sec = 0;
            double P = 0;
            double BLLM1_Northing = 0;
            double BLLM1_Easting = 0;
            double DistanceXCost = 0;
            double DistanceXSint = 0;
            double CP2_Northing = 0;
            double CP2_Easting = 0;
            double Mean_Easting = 0;
            double Mean_EastingPrime = 0;
            double Mean_Northing = 0;
            double Even_Northing_18 = 0;
            double q = 0;
            double q2_18 = 0;
            double q4_26 = 0;
            double SumQ = 0;
            double Sum_Ko = 0;
            double Grid_DistanceX = 0;
            double DistanceXprime_Cost = 0;
            double DistanceXprime_Sint = 0;
            double BLLM1_LongDM_DD = 0;

            E2 = 0.006768657997291;
            //e  - eccentricity
            A = 6378206.4;
            //a - equatorial radius
            b = 6356583.8;
            //b - polar radius
            Ko = 0.99995;
            //Ko - scale factor
            cons_26 = 2.6E-05;
            Pi = 3.14159265358979;


            Delta_N = OriginY - FalseNorthing;
            Delta_E = OriginX - FalseEasting;

            if (Delta_N == 0)
            {
                Bearing = 90;
            }
            else
            {
                Bearing = Math.Atan(Delta_E / Delta_N) * 180d / Pi;
            }

            if (Delta_N > 0)
            {
                N_S = "S";
            }
            else
            {
                N_S = "N";
            }

            if (Delta_E > 0)
            {
                E_W = "W";
            }
            else
            {
                E_W = "E";
            }


            //Quadrant
            if (N_S == "N" & E_W == "E")
            {
                Quadrant = 1;
            }
            else if (N_S == "S" & E_W == "E")
            {
                Quadrant = 2;
            }
            else if (N_S == "S" & E_W == "W")
            {
                Quadrant = 3;
            }
            else
            {
                Quadrant = 4;
            }



            //Azimuth with respect to South
            if (Quadrant == 1)
            {
                Azimuth = Bearing + 180d;
            }
            else if (Quadrant == 2)
            {
                Azimuth = Bearing + 360d;
            }
            else if (Quadrant == 3)
            {
                Azimuth = Bearing;
            }
            else
            {
                Azimuth = Bearing + 180d;
            }


            DistanceX = Math.Sqrt((Math.Pow(Delta_N, 2)) + (Math.Pow(Delta_E, 2)));

            //'compute for cm - central meridian
            // CM = 125


            //compute for cm - central meridian
            BLLM1_LongDM_DD = (LongM / 60d) + LongD;


            CM = CentralMeridian;

            //lambda - bllm1_longitude in decimal degree
            Lambda = (((LongS / 60d) + LongM) / 60d) + LongD;


            Diff_Long_Min = (Lambda - CM) * 60d;
            Diff_Long_Sec = Diff_Long_Min * 60d;

            //phi - bllm1_latitude in decimal degree
            Phi = (((LatS / 60d) + LatM) / 60d) + LatD;


            Phi_Radians = Phi * Pi / 180d;

            Sin_Phi_Radians = Math.Sin(Phi_Radians);


            Convergence = (Diff_Long_Sec * Sin_Phi_Radians) / 3600d;

            //grid azimuth (t)
            t = Azimuth - Convergence;

            //------------------------------------------------------ Geographic To Grid -----------------------------------------------

            e2_prime = ((Math.Pow(A, 2)) - (Math.Pow(b, 2))) / (Math.Pow(b, 2));
            sec_1 = (1 / 3600d) * (Pi / 180d);
            n = A / Math.Sqrt(1 - E2 * (Math.Pow(Math.Sin(Phi_Radians), 2)));
            A0 = 1 - (E2 / 4d) - ((3d / 64d) * (Math.Pow(E2, 2))) - ((5d / 256d) * (Math.Pow(E2, 3)));
            A1 = ((3d / 8d) * E2) + ((3d / 32d) * (Math.Pow(E2, 2))) + ((45d / 1024d) * (Math.Pow(E2, 3)));
            A2 = ((15d / 256d) * (Math.Pow(E2, 2))) + ((45d / 1024d) * (Math.Pow(E2, 3)));
            A3 = (35d / 3072d) * (Math.Pow(E2, 3));

            i = A * (A0 * Phi_Radians - A1 * Math.Sin(2 * Phi_Radians) + A2 * Math.Sin(4 * Phi_Radians) - A3 * Math.Sin(6 * Phi_Radians)) * Ko;
            II = ((n * Math.Sin(Phi_Radians) * Math.Cos(Phi_Radians) * (Math.Pow(Math.Sin(sec_1), 2))) / 2) * Ko * 100000000;
            III = ((Math.Pow(Math.Sin(sec_1), 4)) * n * Math.Sin(Phi_Radians) * (Math.Pow(Math.Cos(Phi_Radians), 3)) / 24) * (5 - (Math.Pow(Math.Tan(Phi_Radians), 2)) + 9 * e2_prime * (Math.Pow(Math.Cos(Phi_Radians), 2)) + 4 * (Math.Pow(e2_prime, 2)) * (Math.Pow(Math.Cos(Phi_Radians), 4))) * Ko * 1E+16;
            IV = n * Math.Cos(Phi_Radians) * Math.Sin(sec_1) * Ko * 10000d;
            V = (((Math.Pow(Math.Sin(sec_1), 3)) * n * (Math.Pow(Math.Cos(Phi_Radians), 3))) / 6d) * (1 - (Math.Pow(Math.Tan(Phi_Radians), 2)) + e2_prime * (Math.Pow(Math.Cos(Phi_Radians), 2))) * Ko * 1000000000000.0;
            VI = (((Math.Pow(Math.Sin(sec_1), 5)) * n * (Math.Pow(Math.Cos(Phi_Radians), 5))) / 120d) * (5d - 18d * (Math.Pow(Math.Tan(Phi_Radians), 2)) + (Math.Pow(Math.Tan(Phi_Radians), 4)) + 14d * e2_prime * (Math.Pow(Math.Cos(Phi_Radians), 2)) - 58d * e2_prime * (Math.Pow(Math.Sin(Phi_Radians), 2))) * Ko * 1E+20;

            Delta_Lambda_Sec = (Lambda - CM) * 3600d;
            //same as diff_long_sec
            P = Delta_Lambda_Sec * 0.0001d;

            BLLM1_Northing = i + (II * (Math.Pow(P, 2))) + (III * (Math.Pow(P, 4)));
            BLLM1_Easting = ((VI * (Math.Pow(P, 2)) + V) * (Math.Pow(P, 2)) + IV) * P + 500000d;

            DistanceXCost = DistanceX * Math.Cos(t * Pi / 180d);
            DistanceXSint = DistanceX * Math.Sin(t * Pi / 180d);

            CP2_Northing = BLLM1_Northing - DistanceXCost;
            CP2_Easting = BLLM1_Easting - DistanceXSint;

            Mean_Easting = (BLLM1_Easting + CP2_Easting) / 2;
            Mean_EastingPrime = Mean_Easting - 500000d;
            Mean_Northing = (BLLM1_Northing + CP2_Northing) / 2;

            //for table 18
            Even_Northing_18 = ((1 + ((E2 * (Math.Pow(Math.Cos(Phi_Radians), 2))) / (1 - E2))) / (2 * (Math.Pow(n, 2)))) * (1 / (Math.Pow(Ko, 2))) * 1000000000000.0d;

            q = Mean_EastingPrime * 1E-06;
            //XVIIIq2
            q2_18 = Even_Northing_18 * (Math.Pow(q, 2));
            //000026q4
            q4_26 = cons_26 * (Math.Pow(q, 4));

            SumQ = 1 + q2_18 + q4_26;
            Sum_Ko = SumQ * Ko;

            Grid_DistanceX = DistanceX * Sum_Ko;

            DistanceXprime_Cost = Grid_DistanceX * Math.Cos(t * Pi / 180d);
            DistanceXprime_Sint = Grid_DistanceX * Math.Sin(t * Pi / 180d);




            functionReturnValue.Northing = BLLM1_Northing - DistanceXprime_Cost;
            functionReturnValue.Easting = BLLM1_Easting - DistanceXprime_Sint;

            //functionReturnValue.Northing = Math.Round(functionReturnValue.Northing, 4);
            //functionReturnValue.Easting = Math.Round(functionReturnValue.Easting, 4);
            return functionReturnValue;



        }

        private void InitCoordConversionTool()
        {
            // local to ptm
            ContextMenuStrip mnuLocalPtm = new ContextMenuStrip();
            mnuLocalPtm.Items.Add("Convert Local to PTM", null, ConvertLocalToPtm_Click);
            lotDataGridView.Columns["LocalX"].HeaderCell.ContextMenuStrip = mnuLocalPtm;
            lotDataGridView.Columns["LocalY"].HeaderCell.ContextMenuStrip = mnuLocalPtm;

            // ptm to prs
            ContextMenuStrip mnuPtmPrs = new ContextMenuStrip();
            mnuPtmPrs.Items.Add("Convert PTM to PRS 92", null, ConvertPtmToPrs92_Click);
            lotDataGridView.Columns["PrsX"].HeaderCell.ContextMenuStrip = mnuPtmPrs;
            lotDataGridView.Columns["PrsY"].HeaderCell.ContextMenuStrip = mnuPtmPrs;

        }

        private void ConvertPtmToPrs92_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented!");
        }

        private void ConvertLocalToPtm_Click(object sender, EventArgs e)
        {
            


            string cadSurveyNo = BindingSourceColumn(cadSurveyBindingSource, "CadSurveyNo");
            string referencePoint = BindingSourceColumn(lotBindingSource, "ReferencePoint");

            string regionPsgc = BindingSourceColumn(cadSurveyBindingSource, "RegionPsgc");
            string provincePsgc = BindingSourceColumn(cadSurveyBindingSource, "ProvincePsgc");
            string municipalityPsgc = BindingSourceColumn(municipalityBindingSource, "MunicipalityPsgc");

            int CentralMeridian = GetCentralMeridian(regionPsgc, provincePsgc, municipalityPsgc);


            DataRow coords = RefPointCoords(cadSurveyNo, referencePoint);

            if (coords == null)
            {
                MessageBox.Show("Please set the reference point of this \nlot in the Lot Information tab.",String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
                


            if (CentralMeridian == 0)
            {
                DialogCentralMeridian frm = new DialogCentralMeridian();
                frm.ShowDialog();
                CentralMeridian = frm.CentralMeridian;
                frm.Dispose();
            }
            

            
            string lat;
            string lng;

            double OriginX = 0; 
            double OriginY = 0;

            if (coords == null)
            {
                lat = "0 0 0";
                lng = "0 0 0";
            }
            else
            {
                lat = FixNullValue(coords["Latitude"], "0 0 0").ToString();
                lng = FixNullValue(coords["Longitude"], "0 0 0").ToString();
                OriginX = Convert.ToDouble(FixNullValue(coords["False_Easting"], 0));
                OriginY = Convert.ToDouble(FixNullValue(coords["False_Northing"], 0));
            }


            string[] latitude = lat.Split(new Char[] {' '});
            string[] longitude = lng.ToString().Split(new Char[] { ' ' });

            int LatD = Convert.ToInt32(latitude[0].Replace(@"°", String.Empty));
            int LatM = Convert.ToInt32(latitude[1].Replace(@"'", String.Empty));
            double LatS = Convert.ToDouble(latitude[2].Replace(@"""", String.Empty));

            int LongD = Convert.ToInt32(longitude[0].Replace(@"°", String.Empty));
            int LongM = Convert.ToInt32(longitude[1].Replace(@"'", String.Empty));
            double LongS = Convert.ToDouble(longitude[2].Replace(@"""", String.Empty));

            foreach (DataGridViewRow row in lotDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {

                    double FalseEasting = Convert.ToDouble(FixNullValue(row.Cells["LocalX"].Value, 0));
                    double FalseNorthing = Convert.ToDouble(FixNullValue(row.Cells["LocalY"].Value, 0));

                    if (FalseEasting > 0 & FalseNorthing > 0)
                    {
                        DataGridViewCell ptmX = row.Cells["Easting"];
                        DataGridViewCell ptmY = row.Cells["Northing"];

                        PTM result = LocalToGridAlgorithm(LatD, LatM, LatS, LongD, LongM, LongS, OriginY, OriginX, FalseNorthing, FalseEasting, CentralMeridian);

                        ptmX.Value = result.Easting;
                        ptmY.Value = result.Northing;

                    }
                        

                    
 
                }
            }
        }
        private int GetCentralMeridian(string regionPsgc, string provincePsgc, string municipalityPsgc)
        {
            int retVal = 0;
            

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                string sql =String.Format( @"SELECT Zone FROM PTMZone INNER JOIN " +
                                           @"(SELECT (SELECT name FROM psgc WHERE psgc_cd = '{0}') AS RegionName, " +
                                           @"        (SELECT name FROM psgc WHERE psgc_cd = '{1}') AS ProvinceName, " +
                                           @"        (SELECT name FROM psgc WHERE psgc_cd = '{2}') AS MunicipalityName) AS " +
                                           @"         Criteria ON Criteria.RegionName = Region AND " +
                                           @"         Criteria.ProvinceName = Province AND " +
                                           @"         Criteria.MunicipalityName = Municipality",
                                           regionPsgc,provincePsgc,municipalityPsgc);

                cmd.CommandText = sql;
                
                retVal = Convert.ToInt32(FixNullValue(cmd.ExecuteScalar(),0));
            }

            //MessageBox.Show(String.Format("{0}\n{1}\n{2}\n", regionName , provinceName, municipalityName));

            if (retVal > 0 )
                retVal = (115) + (2 * retVal);

            return retVal;
        }


        // common
        private string Val(string value)
        {
            string returnVal = string.Empty;
            System.Text.RegularExpressions.MatchCollection collection = System.Text.RegularExpressions.Regex.Matches(value, "\\d+");
            foreach (System.Text.RegularExpressions.Match match in collection)
            {
                returnVal += match.ToString();
            }
            return returnVal;
        }
        private object FixNullValue(object value, object defaultValue) 
        {
            if (value == DBNull.Value)
                return defaultValue;
            if (value == null)
                return defaultValue;
            return value;
        }

        private void lnkLogout_LinkClicked(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lnkClaim_LinkClicked(object sender, EventArgs e)
        {
            txtEncoder.Enabled = true;
            txtEncoder.Text = UserName;
            txtEncoder.Enabled = false;
            //((DataRowView)bs.Current)[columnName]
            //DataRowView drv = (DataRowView)lotBindingSource.Current;
        }

    }




}