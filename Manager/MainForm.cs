using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using System.IO; 

namespace Manager
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {


        string ConnString;
        PanelSwitcher Pages;

        SqlDataAdapter daUsers;
        DataTable dtUsers = new DataTable();


        // Initialization 
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            Init();
            LoadMap();

            //CreateButtons();
            Pages = new PanelSwitcher(new Panel[] { pnlSpatialQuery, pnlReports, pnlUsers, pnlSettings, pnlTextualQuery });

            btnSpatialQuery.Checked = true;

        }



        // Method
        private void Init()
        {
            string server = GetSetting("servers", "DatabaseServer", "name");
            ConnString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92";


            // init spatial query
            InitSpatialQuery();


            // init textual query
            InitTextualQuery();


            // init users
            InitUsers();


            // init reports
            InitReport();

            
        }


        private void InitSpatialQuery()
        {
            FillRegion();
            FillProvince();
            btnSelectAreaError.Click += new EventHandler(spatialSelection_Click);
            btnSelectGap.Click += new EventHandler(spatialSelection_Click);
            btnSelectOverlapping.Click += new EventHandler(spatialSelection_Click);
        }

        private void spatialSelection_Click(object sender, EventArgs e)
        {
            dgSelection.Visible = true;
        }

        private void InitReport()
        {
            DataTable dt = new DataTable();

            dt = GetSqlTable(@"SELECT CadSurveyNo FROM [CadSurvey]");

            lbxReportLotDataMunicipality.DataSource = null;

            lbxReportLotDataCadSurveyNo.DataSource = dt;
            lbxReportLotDataCadSurveyNo.ValueMember = "CadSurveyNo";
            lbxReportLotDataCadSurveyNo.DisplayMember = "CadSurveyNo";
            lbxReportLotDataCadSurveyNo.SelectedIndex = -1;

            

            lbxReportLotDataCadSurveyNo.SelectedValueChanged += new EventHandler(lbxReportLotDataCadSurveyNo_SelectedValueChanged);
            lbxReportLotDataMunicipality.SelectedValueChanged += new EventHandler(lbxReportLotDataMunicipality_SelectedValueChanged);
            lbxReportLotDataCase.SelectedValueChanged += new EventHandler(lbxReportLotDataCase_SelectedValueChanged);
            lbxReportLotDataBarangay.SelectedValueChanged += new EventHandler(lbxReportLotDataBarangay_SelectedValueChanged);
            lbxReportLotDataQuadrangle.SelectedValueChanged += new EventHandler(lbxReportLotDataQuadrangle_SelectedValueChanged);
            lbxReportLotDataSection.SelectedValueChanged += new EventHandler(lbxReportLotDataSection_SelectedValueChanged);


            lbxReportCustom1CadSurveyNo.DataSource = null;
            lbxReportCustom1CadSurveyNo.DataSource = dt;
            lbxReportCustom1CadSurveyNo.ValueMember = "CadSurveyNo";
            lbxReportCustom1CadSurveyNo.DisplayMember = "CadSurveyNo";
            lbxReportCustom1CadSurveyNo.SelectedIndex = -1;



            lbxReportCustom1CadSurveyNo.SelectedValueChanged += new EventHandler(lbxReportCustom1CadSurveyNo_SelectedValueChanged);
            lbxReportCustom1Municipality.SelectedValueChanged += new EventHandler(lbxReportCustom1Municipality_SelectedValueChanged);
            lbxReportCustom1Case.SelectedValueChanged += new EventHandler(lbxReportCustom1Case_SelectedValueChanged);
            lbxReportCustom1Barangay.SelectedValueChanged += new EventHandler(lbxReportCustom1Barangay_SelectedValueChanged);
            lbxReportCustom1Quadrangle.SelectedValueChanged += new EventHandler(lbxReportCustom1Quadrangle_SelectedValueChanged);
            lbxReportCustom1Section.SelectedValueChanged += new EventHandler(lbxReportCustom1Section_SelectedValueChanged);




            // Encoded Lot per User
            DataTable dtUsers = GetSqlTable("SELECT UserName FROM [lsdms_users]");
            DataRow dr = dtUsers.NewRow();
            dr["UserName"] = "<All Users>";
            dtUsers.Rows.InsertAt(dr, 0);
            cmbRptEncodedLotsUsers.DisplayMember = "UserName";
            cmbRptEncodedLotsUsers.ValueMember = "UserName";
            cmbRptEncodedLotsUsers.DataSource= dtUsers;

         


        }

        private void lbxReportLotDataCadSurveyNo_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT MunicipalityPsgc, name AS MunicipalityName FROM [Municipality] INNER JOIN [psgc] ON [Municipality].[MunicipalityPsgc] = [psgc].[psgc_cd] WHERE CadSurveyNo =  '{0}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataCase.DataSource = null;

            lbxReportLotDataMunicipality.DataSource = dt;
            lbxReportLotDataMunicipality.ValueMember = "MunicipalityPsgc";
            lbxReportLotDataMunicipality.DisplayMember = "MunicipalityName";
            
            
        }
        private void lbxReportLotDataMunicipality_SelectedValueChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT CadCaseNo FROM [Case] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataBarangay.DataSource = null;

            lbxReportLotDataCase.DataSource = dt;
            lbxReportLotDataCase.ValueMember = "CadCaseNo";
            lbxReportLotDataCase.DisplayMember = "CadCaseNo";

            
        }
        private void lbxReportLotDataCase_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT BarangayPsgc, name AS BarangayName FROM [Barangay] INNER JOIN [psgc] ON [Barangay].[BarangayPsgc] = [psgc].[psgc_cd] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataCase.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataQuadrangle.DataSource = null;

            lbxReportLotDataBarangay.DataSource = dt;
            lbxReportLotDataBarangay.ValueMember = "BarangayPsgc";
            lbxReportLotDataBarangay.DisplayMember = "BarangayName";
        }
        private void lbxReportLotDataBarangay_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT Quadrangle FROM [Quadrangle] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataCase.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataBarangay.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataSection.DataSource = null;

            lbxReportLotDataQuadrangle.DataSource = dt;
            lbxReportLotDataQuadrangle.ValueMember = "Quadrangle";
            lbxReportLotDataQuadrangle.DisplayMember = "Quadrangle";
        }
        private void lbxReportLotDataQuadrangle_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT SectionId FROM [Section] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataCase.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataBarangay.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataQuadrangle.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataLot.DataSource = null;

            lbxReportLotDataSection.DataSource = dt;
            lbxReportLotDataSection.ValueMember = "SectionId";
            lbxReportLotDataSection.DisplayMember = "SectionId";
        }
        private void lbxReportLotDataSection_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT LotNo FROM [Lot] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}' AND SectionId = '{5}'",
                                        FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataCase.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataBarangay.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataQuadrangle.SelectedValue, "").ToString(),
                                        FixNull(lbxReportLotDataSection.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportLotDataLot.DataSource = dt;
            lbxReportLotDataLot.ValueMember = "LotNo";
            lbxReportLotDataLot.DisplayMember = "LotNo";
            lbxReportLotDataLot.SelectedIndex = -1;
        }

        private void lbxReportCustom1CadSurveyNo_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT MunicipalityPsgc, name AS MunicipalityName FROM [Municipality] INNER JOIN [psgc] ON [Municipality].[MunicipalityPsgc] = [psgc].[psgc_cd] WHERE CadSurveyNo =  '{0}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Case.DataSource = null;

            lbxReportCustom1Municipality.DataSource = dt;
            lbxReportCustom1Municipality.ValueMember = "MunicipalityPsgc";
            lbxReportCustom1Municipality.DisplayMember = "MunicipalityName";


        }
        private void lbxReportCustom1Municipality_SelectedValueChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT CadCaseNo FROM [Case] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Barangay.DataSource = null;

            lbxReportCustom1Case.DataSource = dt;
            lbxReportCustom1Case.ValueMember = "CadCaseNo";
            lbxReportCustom1Case.DisplayMember = "CadCaseNo";


        }
        private void lbxReportCustom1Case_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT BarangayPsgc, name AS BarangayName FROM [Barangay] INNER JOIN [psgc] ON [Barangay].[BarangayPsgc] = [psgc].[psgc_cd] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Case.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Quadrangle.DataSource = null;

            lbxReportCustom1Barangay.DataSource = dt;
            lbxReportCustom1Barangay.ValueMember = "BarangayPsgc";
            lbxReportCustom1Barangay.DisplayMember = "BarangayName";
        }
        private void lbxReportCustom1Barangay_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT Quadrangle FROM [Quadrangle] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Case.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Barangay.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Section.DataSource = null;

            lbxReportCustom1Quadrangle.DataSource = dt;
            lbxReportCustom1Quadrangle.ValueMember = "Quadrangle";
            lbxReportCustom1Quadrangle.DisplayMember = "Quadrangle";
        }
        private void lbxReportCustom1Quadrangle_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT SectionId FROM [Section] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Case.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Barangay.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Quadrangle.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Lot.DataSource = null;

            lbxReportCustom1Section.DataSource = dt;
            lbxReportCustom1Section.ValueMember = "SectionId";
            lbxReportCustom1Section.DisplayMember = "SectionId";
        }
        private void lbxReportCustom1Section_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            string sql = String.Format(@"SELECT LotNo FROM [Lot] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}' AND SectionId = '{5}'",
                                        FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Case.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Barangay.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Quadrangle.SelectedValue, "").ToString(),
                                        FixNull(lbxReportCustom1Section.SelectedValue, "").ToString());
            dt = GetSqlTable(sql);

            lbxReportCustom1Lot.DataSource = dt;
            lbxReportCustom1Lot.ValueMember = "LotNo";
            lbxReportCustom1Lot.DisplayMember = "LotNo";
            lbxReportCustom1Lot.SelectedIndex = -1;
        }


        
        

        private object FixNull(object value, object defaultValue)
        {
            if (value == null || value == DBNull.Value)
            {
                return defaultValue;
            }
            else
            {
                return value;
            }
        }
       
        private void InitUsers()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            string sql = @"SELECT * FROM [lsdms_users] ORDER BY Username";
            daUsers = new SqlDataAdapter(sql, ConnString);

            // Insert command
            daUsers.InsertCommand = new SqlCommand(@"INSERT INTO [lsdms_users](Username, Password, Access) VALUES(@Username,@Password,@Access)", conn);
            daUsers.InsertCommand.Parameters.Add("@Username", SqlDbType.VarChar, 20, "Username");
            daUsers.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar, 20, "Password");
            daUsers.InsertCommand.Parameters.Add("@Access", SqlDbType.Int, 1, "Access");

            // Update command
            daUsers.UpdateCommand = new SqlCommand(@"UPDATE [lsdms_users] SET Username = @Username, Password = @Password, Access = @Access WHERE Username = @oldUsername", conn);
            daUsers.UpdateCommand.Parameters.Add("@Username", SqlDbType.VarChar, 20, "Username");
            daUsers.UpdateCommand.Parameters.Add("@Password", SqlDbType.VarChar, 20, "Password");
            daUsers.UpdateCommand.Parameters.Add("@Access", SqlDbType.Int, 1, "Access");
            daUsers.UpdateCommand.Parameters.Add("@oldUsername", SqlDbType.VarChar, 20, "Username");
            daUsers.UpdateCommand.Parameters["@oldUsername"].SourceVersion = DataRowVersion.Original;

            // Delete command
            daUsers.DeleteCommand = new SqlCommand(@"DELETE FROM [lsdms_users] WHERE Username = @Username", conn);
            daUsers.DeleteCommand.Parameters.Add("@Username", SqlDbType.VarChar, 20, "Username");

            daUsers.Fill(dtUsers);
            
            DataTable dtAccess = new DataTable();
            dtAccess.Columns.Add("Access", typeof(int));
            dtAccess.Columns.Add("AccessLabel", typeof(string));

            dtAccess.Rows.Add(2, "Administrator");
            dtAccess.Rows.Add(1, "Encoder");

            colAccess.DisplayMember = "AccessLabel";
            colAccess.ValueMember = "Access";
            colAccess.DataSource = dtAccess;

            dgUsers.DataSource = dtUsers;

            
        }
        private void InitTextualQuery()
        {
            string sql = @"SELECT COLUMN_NAME, (CASE WHEN Numeric_Precision IS NULL THEN 'True' ELSE 'False' END) + '|' + COLUMN_NAME AS [Data] FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lsdmsTextualQuery'";
            DataTable dt = GetSqlTable(sql);

            lbxTextualQueryColumns.ListBox.DataSource = dt;
            lbxTextualQueryColumns.ListBox.DisplayMember = "COLUMN_NAME";
            lbxTextualQueryColumns.ListBox.ValueMember = "COLUMN_NAME";


            colColumnName.DataSource = dt;
            colColumnName.DisplayMember = "COLUMN_NAME";
            colColumnName.ValueMember = "Data";
        }




        private void LoadMap()
        {
            string mapFile = Application.StartupPath + @"\map.map";
            string componentName = "Map";

            mapControl.RenderSelection = true;
            mapControl.DocumentPath = mapFile;
            mapControl.ComponentName = componentName;
        }
        private void ExecuteQuery(string sql)
        {
            Manifold.Interop.Query tempQuery = mapControl.get_Document().NewQuery("", false);
            tempQuery.Text = sql;
            tempQuery.Run();

            mapControl.get_Document().ComponentSet.Remove(tempQuery);
        }
        private void FillRegion()
        {
            string sql = @"SELECT name AS DisplayMember, psgc_cd AS ValueMember, CASE WHEN name = 'Region IX' THEN 'Region VIIII' ELSE name END AS nameOrder FROM Psgc WHERE SUBSTRING(psgc_cd, 3, 7) = '0000000' ORDER BY nameOrder";
            cmbRegion.DataSource = GetSqlTable(sql);
            cmbRegion.DisplayMember = "DisplayMember";
            cmbRegion.ValueMember = "ValueMember";
        }
        private void FillProvince()
        {
            string regionPsgc = cmbRegion.SelectedValue.ToString();
            string sql = String.Format("SELECT '*All Province' AS DisplayMember, NULL AS ValueMember  UNION ALL SELECT name AS DisplayMember, psgc_cd AS ValueMember FROM PSGC WHERE SUBSTRING(psgc_cd,1,2) = SUBSTRING('{0}',1,2) AND SUBSTRING(psgc_cd,5,2) = '00' AND NOT psgc_cd = '{0}' ORDER BY DisplayMember", regionPsgc);
            cmbProvince.DataSource = GetSqlTable(sql);
            cmbProvince.DisplayMember = "DisplayMember";
            cmbProvince.ValueMember = "ValueMember";
        }
        private void FillCadSurvey()
        {
            string sql = String.Empty;
            if (cmbProvince.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Project' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT CadSurveyNo AS DisplayMember, CadSurveyNo AS ValueMember FROM CadSurvey WHERE RegionPsgc = '{0}'", cmbRegion.SelectedValue.ToString());
            }
            else
            {
                sql = String.Format("SELECT '*All Project' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT CadSurveyNo AS DisplayMember, CadSurveyNo AS ValueMember FROM CadSurvey WHERE ProvincePsgc = '{0}'", cmbProvince.SelectedValue.ToString());
            }


            cmbCadSurvey.DataSource = GetSqlTable(sql);
            cmbCadSurvey.DisplayMember = "DisplayMember";
            cmbCadSurvey.ValueMember = "ValueMember";
        }
        private void FillMunicipality()
        {
            string sql = String.Empty;
            if (cmbCadSurvey.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Municipality' AS DisplayMember, NULL AS ValueMember");
            }
            else
            {
                sql = String.Format("SELECT '*All Municipality' AS DisplayMember, NULL AS ValueMember  UNION ALL SELECT name AS DisplayMember, psgc_cd AS ValueMember FROM PSGC INNER JOIN Municipality ON PSGC.psgc_cd = Municipality.MunicipalityPsgc WHERE CadSurveyNo = '{0}' ORDER BY DisplayMember", cmbCadSurvey.SelectedValue.ToString());
            }

            cmbMunicipality.DataSource = GetSqlTable(sql);
            cmbMunicipality.DisplayMember = "DisplayMember";
            cmbMunicipality.ValueMember = "ValueMember";
        }
        private void FillCase()
        {
            string sql = String.Empty;
            if (cmbMunicipality.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Case' AS DisplayMember, NULL AS ValueMember");
            }
            else
            {
                sql = String.Format("SELECT '*All Case' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT CadCaseNo AS DisplayMember, CadCaseNo AS ValueMember FROM [Case] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' ORDER BY DisplayMember", cmbCadSurvey.SelectedValue.ToString(), cmbMunicipality.SelectedValue.ToString());
            }

            cmbCase.DataSource = GetSqlTable(sql);
            cmbCase.DisplayMember = "DisplayMember";
            cmbCase.ValueMember = "ValueMember";
        }
        private void FillBarangay()
        {
            string sql = String.Empty;

            if (cmbCase.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Barangay' AS DisplayMember, NULL AS ValueMember");
            }
            else
            {
                sql = String.Format("SELECT '*All Barangay' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT name AS DisplayMember, psgc_cd AS ValueMember FROM PSGC INNER JOIN Barangay ON PSGC.psgc_cd = Barangay.BarangayPsgc WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' ORDER BY DisplayMember", cmbCadSurvey.SelectedValue.ToString(), cmbMunicipality.SelectedValue.ToString(), cmbCase.SelectedValue.ToString());
            }

            cmbBarangay.DataSource = GetSqlTable(sql);
            cmbBarangay.DisplayMember = "DisplayMember";
            cmbBarangay.ValueMember = "ValueMember";
        }
        private void FillQuadrangle()
        {
            string sql = String.Empty;

            if (cmbBarangay.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Quadrangle' AS DisplayMember, NULL AS ValueMember");
            }
            else
            {
                sql = String.Format("SELECT '*All Quadrangle' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT Quadrangle AS DisplayMember, Quadrangle AS ValueMember FROM Quadrangle WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' ORDER BY DisplayMember", cmbCadSurvey.SelectedValue.ToString(), cmbMunicipality.SelectedValue.ToString(), cmbCase.SelectedValue.ToString(), cmbBarangay.SelectedValue.ToString());
            }

            cmbQuadrangle.DataSource = GetSqlTable(sql);
            cmbQuadrangle.ValueMember = "ValueMember";
            cmbQuadrangle.DisplayMember = "DisplayMember";

        }
        private void FillSection()
        {
            string sql = String.Empty;

            if (cmbQuadrangle.SelectedValue == DBNull.Value)
            {
                sql = String.Format("SELECT '*All Section' AS DisplayMember, NULL AS ValueMember");
            }
            else
            {
                sql = String.Format("SELECT '*All Section' AS DisplayMember, NULL AS ValueMember UNION ALL SELECT SectionId AS DisplayMember, SectionId AS ValueMember FROM Section WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}' ORDER BY DisplayMember", cmbCadSurvey.SelectedValue.ToString(), cmbMunicipality.SelectedValue.ToString(), cmbCase.SelectedValue.ToString(), cmbBarangay.SelectedValue.ToString(), cmbQuadrangle.SelectedValue.ToString());
            }

            cmbSection.DataSource = GetSqlTable(sql);
            cmbSection.ValueMember = "ValueMember";
            cmbSection.DisplayMember = "DisplayMember";
        }

        private void ClearSelection(string tableName)
        {
            string sql = String.Format("UPDATE [{0}] SET [Selection (I)] = False", tableName);
            ExecuteQuery(sql);
        }

 

        // Function
        private int GetSqlLotData(string whereClause, BackgroundWorker worker)
        {
            int recordCount = 0;
            //string sql = String.Format("SELECT * FROM [LotData] WHERE {0}", whereClause);

            string sql = String.Format("SELECT LotData.*, Lot.ClaimantName, Lot.DeclaredArea, Lot.ComputedArea, ProvinceTable.name AS [ProvinceName], MunicipalityTable.name AS [MunicipalityName], BarangayTable.name AS [BarangayName]" +
                                        "FROM CadSurvey INNER JOIN " +
                                        "Municipality ON CadSurvey.CadSurveyNo = Municipality.CadSurveyNo INNER JOIN " +
                                          "[Case] ON Municipality.CadSurveyNo = [Case].CadSurveyNo AND " +
                                          "Municipality.MunicipalityPsgc = [Case].MunicipalityPsgc INNER JOIN " +
                                          "Barangay ON [Case].CadSurveyNo = Barangay.CadSurveyNo AND [Case].MunicipalityPsgc = Barangay.MunicipalityPsgc AND " +
                                          "[Case].CadCaseNo = Barangay.CadCaseNo INNER JOIN " +
                                          "Quadrangle ON Barangay.CadSurveyNo = Quadrangle.CadSurveyNo AND " +
                                          "Barangay.MunicipalityPsgc = Quadrangle.MunicipalityPsgc AND Barangay.CadCaseNo = Quadrangle.CadCaseNo AND " +
                                          "Barangay.BarangayPsgc = Quadrangle.BarangayPsgc INNER JOIN " +
                                          "Section ON Quadrangle.CadSurveyNo = Section.CadSurveyNo AND Quadrangle.MunicipalityPsgc = Section.MunicipalityPsgc AND " +
                                          "Quadrangle.CadCaseNo = Section.CadCaseNo AND Quadrangle.BarangayPsgc = Section.BarangayPsgc AND " +
                                          "Quadrangle.Quadrangle = Section.Quadrangle INNER JOIN " +
                                          "Lot ON Section.CadSurveyNo = Lot.CadSurveyNo AND Section.MunicipalityPsgc = Lot.MunicipalityPsgc AND " +
                                          "Section.CadCaseNo = Lot.CadCaseNo AND Section.BarangayPsgc = Lot.BarangayPsgc AND " +
                                          "Section.Quadrangle = Lot.Quadrangle AND Section.SectionId = Lot.SectionId INNER JOIN " +
                                          "LotData ON Lot.CadSurveyNo = LotData.CadSurveyNo AND Lot.MunicipalityPsgc = LotData.MunicipalityPsgc AND " +
                                          "Lot.CadCaseNo = LotData.CadCaseNo AND Lot.BarangayPsgc = LotData.BarangayPsgc AND " +
                                          "Lot.Quadrangle = LotData.Quadrangle AND Lot.SectionId = LotData.SectionId AND Lot.LotNo = LotData.LotNo INNER JOIN " +
                                          "psgc AS ProvinceTable ON CadSurvey.ProvincePsgc = ProvinceTable.psgc_cd INNER JOIN " +
                                          "psgc AS MunicipalityTable ON Municipality.MunicipalityPsgc = MunicipalityTable.psgc_cd INNER JOIN " +
                                          "psgc AS BarangayTable ON Barangay.BarangayPsgc = BarangayTable.psgc_cd " +
                                          "WHERE {0}", whereClause);


            Console.WriteLine(sql);

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Create query object that will be used to populate LotData table inside map file
                Manifold.Interop.Query tempQuery = mapControl.get_Document().NewQuery(String.Empty, false);

                // Clear LotData table inside map file
                string manifoldSql = "DELETE FROM [LotData]";
                tempQuery.Text = manifoldSql;
                tempQuery.Run();


                recordCount = dt.Rows.Count;
                int i = 0;

                // Run through the data fetched from Sql Server and insert them in LotData inside map file
                foreach (DataRow dr in dt.Rows)
                {
                    manifoldSql = String.Format(@"INSERT INTO [LotData](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, Sequence, PtmX, PtmY, ClaimantName, DeclaredArea, ComputedArea, ProvinceName, MunicipalityName, BarangayName) " +
                                                @"VALUES(""{0}"",""{1}"",""{2}"",""{3}"",""{4}"",""{5}"",""{6}"",""{7}"",""{8}"",""{9}"",""{10}"",""{11}"",""{12}"",""{13}"",""{14}"",""{15}"")",
                                                 dr["CadSurveyNo"].ToString(),
                                                 dr["MunicipalityPsgc"].ToString(),
                                                 dr["CadCaseNo"].ToString(),
                                                 dr["BarangayPsgc"].ToString(),
                                                 dr["Quadrangle"].ToString(),
                                                 dr["SectionId"].ToString(),
                                                 dr["LotNo"].ToString(),
                                                 dr["Sequence"].ToString(),
                                                 dr["PtmX"].ToString(),
                                                 dr["PtmY"].ToString(),
                                                 dr["ClaimantName"].ToString(),
                                                 dr["DeclaredArea"].ToString(),
                                                 dr["ComputedArea"].ToString(),
                                                 dr["ProvinceName"].ToString(),
                                                 dr["MunicipalityName"].ToString(),
                                                 dr["BarangayName"].ToString());
                    tempQuery.Text = manifoldSql;
                    tempQuery.Run();

                    i++;

                    decimal progress = Decimal.Divide(i, recordCount) * 100;

                    // Report progress
                    worker.ReportProgress(Convert.ToInt32(progress));
                    if (worker.CancellationPending)
                    {
                        return recordCount;
                    }

                }




                // Remove query object
                mapControl.get_Document().ComponentSet.Remove(tempQuery);

                // Refresh linked components
                mapControl.get_Document().RefreshAllLinked();

                mapControl.ZoomToFit();

            }

            return recordCount;

        }
        private string CreateWhereClause()
        {

            string whereClause = String.Empty;

            // Province
            if (cmbProvince.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(@" [CadSurvey].ProvincePsgc = '{0}' ", cmbProvince.SelectedValue.ToString());
            }
            else
            {
                // If no province is selected, then filter LotData using Region. Region ALWAYS have value
                whereClause += String.Format(@" [CadSurvey].RegionPsgc = '{0}' ", cmbRegion.SelectedValue.ToString());
            }

            // CadSurvey
            if (cmbCadSurvey.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [CadSurvey].CadSurveyNo = '{0}' ", cmbCadSurvey.SelectedValue.ToString());
            }


            // Municipality
            if (cmbMunicipality.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [Municipality].MunicipalityPsgc = '{0}' ", cmbMunicipality.SelectedValue.ToString());
            }


            // Case
            if (cmbCase.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [Case].CadCaseNo = '{0}' ", cmbCase.SelectedValue.ToString());
            }

            // Barangay
            if (cmbBarangay.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [Barangay].BarangayPsgc= '{0}' ", cmbBarangay.SelectedValue.ToString());
            }

            // Quadrangle

            if (cmbQuadrangle.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [Quadrangle].Quadrangle = '{0}' ", cmbQuadrangle.SelectedValue.ToString());
            }


            // Section
            if (cmbSection.SelectedValue != DBNull.Value)
            {
                whereClause += String.Format(" AND [Section].SectionId = '{0}' ", cmbSection.SelectedValue.ToString());
            }

            return whereClause;
        }
        private string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }
        private DataTable GetSqlTable(string sql)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }
        private DataTable GetManifoldTable(string sql)
        {
            DataTable dt = new DataTable("Result");

            Manifold.Interop.Query tempQuery = mapControl.get_Document().NewQuery("", false);
            tempQuery.Text = sql;
            tempQuery.Run();

            foreach (Manifold.Interop.Column col in tempQuery.Table.ColumnSet)
            {
                dt.Columns.Add(col.Name, typeof(String));
            }

            for (int i = 0; i < tempQuery.Table.RecordSet.Count; i++)
            {
                DataRow dr = dt.NewRow();
                foreach (Manifold.Interop.Column col in tempQuery.Table.ColumnSet)
                {
                    string data = tempQuery.Table.RecordSet[i].get_Data(col).ToString();
                    dr[col.Name] = data;
                }
                dt.Rows.Add(dr);
            }



            mapControl.get_Document().ComponentSet.Remove(tempQuery);


            return dt;
        }
        private DataTable GetLotData(DataTable dtLotData, string NorthingColumnName, string EastingColumnName)
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

            dtLotData.Columns.Add("TieLine", typeof(string));
            dtLotData.Columns.Add("NS", typeof(string));
            dtLotData.Columns.Add("Degree", typeof(int));
            dtLotData.Columns.Add("Minute", typeof(int));
            dtLotData.Columns.Add("EW", typeof(string));
            dtLotData.Columns.Add("Bearing", typeof(string));
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

                value = dtLotData.Rows[firstStationIndex][NorthingColumnName];
                //value = GetCell(firstStationIndex, NorthingColumnName).Value;
                if (value == DBNull.Value) { value = "0"; }
                double firstNorthing = Convert.ToDouble(value);

                value = dtLotData.Rows[firstStationIndex][EastingColumnName];
                //value = GetCell(firstStationIndex, EastingColumnName).Value;
                if (value == DBNull.Value) { value = "0"; }
                double firstEasting = Convert.ToDouble(value);


                value = dtLotData.Rows[currentStationIndex][NorthingColumnName];
                //value = GetCell(currentStationIndex, NorthingColumnName).Value;
                if (value == DBNull.Value) { value = "0"; }
                double currentNorthing = Convert.ToDouble(value);

                value = dtLotData.Rows[currentStationIndex][EastingColumnName];
                //value = GetCell(currentStationIndex, EastingColumnName).Value;
                if (value == DBNull.Value) { value = "0"; }
                double currentEasting = Convert.ToDouble(value);


                double nextNorthing = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex][NorthingColumnName];
                    //value = GetCell(nextStationIndex, NorthingColumnName).Value;
                    if (value == DBNull.Value) { value = "0"; }
                    nextNorthing = Convert.ToDouble(value);
                }


                double nextEasting = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex][EastingColumnName];
                    //value = GetCell(nextStationIndex, EastingColumnName).Value;
                    if (value == DBNull.Value) { value = "0"; }
                    nextEasting = Convert.ToDouble(value);
                }


                double lastNorthing = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex][NorthingColumnName];
                    //value = GetCell(nextStationIndex, NorthingColumnName).Value;
                    if (value == DBNull.Value) { value = "0"; }
                    lastNorthing = Convert.ToDouble(value);
                }


                double lastEasting = 0;
                if (dtLotData.Rows.Count > nextStationIndex)
                {
                    value = dtLotData.Rows[nextStationIndex][EastingColumnName];
                    //value = GetCell(nextStationIndex, EastingColumnName).Value;
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


                if (rowIndex + 1 == dtLotData.Rows.Count)
                {
                    row["TieLine"] = (rowIndex + 1).ToString() + " - 1";
                }
                else
                {
                    row["TieLine"] = (rowIndex + 1).ToString() + " - " + (rowIndex + 2).ToString();
                }

                row["NS"] = NS;
                row["Degree"] = degree;
                row["Minute"] = minute;
                row["EW"] = EW;
                row["Bearing"] = String.Format("{0}{1}-{2}{3}", NS, degree.ToString("00"), minute.ToString("00"), EW);
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



        private void LoadReportEncodedLotsPerUser()
        {

            this.rptReportViewer.Reset();
            this.rptReportViewer.LocalReport.ReportEmbeddedResource = "Manager.Reports.EncodedLotsPerUser.rdlc";

            string whereClause = String.Format(" DateAdded BETWEEN CAST('{0}' AS DateTime) AND CAST('{1} 23:59:59' AS DateTime) ", dtpStartDate.Value.ToString("MMM dd yyyy"), dtpEndDate.Value.ToString("MMM dd yyyy"));
            if (cmbRptEncodedLotsUsers.Text != "<All Users>")
            {
                whereClause = whereClause + String.Format(" AND UPPER(UserName) = UPPER('{0}')", cmbRptEncodedLotsUsers.Text);
            }

            DataTable dt = GetSqlTable(String.Format("SELECT * FROM [lsdmsEncodedLotPerUser] WHERE {0}", whereClause));

            rptReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("lsdmsEncodedLotPerUser", dt));
            this.rptReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptReportViewer.RefreshReport();

        }
        private void LoadReportLotDataComputation()
        {

            if (lbxReportLotDataLot.SelectedValue == null)
                return;

            this.rptReportViewer.Reset();
            this.rptReportViewer.LocalReport.ReportEmbeddedResource = "Manager.Reports.ReportLotData.rdlc";

            string cadSurveyNo = FixNull(lbxReportLotDataCadSurveyNo.SelectedValue, "").ToString();
            string municipalityPsgc = FixNull(lbxReportLotDataMunicipality.SelectedValue, "").ToString();
            string cadCaseNo = FixNull(lbxReportLotDataCase.SelectedValue, "").ToString();
            string barangayPsgc = FixNull(lbxReportLotDataBarangay.SelectedValue, "").ToString();
            string quadrangle = FixNull(lbxReportLotDataQuadrangle.SelectedValue, "").ToString();
            string sectionId = FixNull(lbxReportLotDataSection.SelectedValue, "").ToString();
            string lotNo = FixNull(lbxReportLotDataLot.SelectedValue, "").ToString();

            string sql = String.Format(@"SELECT * FROM [lsdmsLotDataReport] WHERE [Survey No] = '{0}' AND [Municipality] = '{1}' AND [Case No] = '{2}' AND [Barangay] = '{3}' AND [Quadrangle] = '{4}' AND [Section] = '{5}' AND [Lot No] = '{6}'",
                                        cadSurveyNo, municipalityPsgc, cadCaseNo, barangayPsgc, quadrangle, sectionId, lotNo);

            SqlDataAdapter da = new SqlDataAdapter(sql, ConnString);
            DataTable dt = new DataTable();

            da.Fill(dt);

            rptReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("lsdmsLotDataReport", dt));


            this.rptReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptReportViewer.RefreshReport();
        }
        private void LoadReportCustom1()
        {
            if (lbxReportCustom1Lot.SelectedValue == null)
                return;

            this.rptReportViewer.Reset();
            this.rptReportViewer.LocalReport.ReportEmbeddedResource = "Manager.Reports.ReportCustom1.rdlc";

            string cadSurveyNo = FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString();
            string municipalityPsgc = FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString();
            string cadCaseNo = FixNull(lbxReportCustom1Case.SelectedValue, "").ToString();
            string barangayPsgc = FixNull(lbxReportCustom1Barangay.SelectedValue, "").ToString();
            string quadrangle = FixNull(lbxReportCustom1Quadrangle.SelectedValue, "").ToString();
            string sectionId = FixNull(lbxReportCustom1Section.SelectedValue, "").ToString();
            string lotNo = FixNull(lbxReportCustom1Lot.SelectedValue, "").ToString();

            string sql = String.Format(@"SELECT * FROM [lsdmsLotDataReport] WHERE [Survey No] = '{0}' AND [Municipality] = '{1}' AND [Case No] = '{2}' AND [Barangay] = '{3}' AND [Quadrangle] = '{4}' AND [Section] = '{5}' AND [Lot No] = '{6}'",
                                        cadSurveyNo, municipalityPsgc, cadCaseNo, barangayPsgc, quadrangle, sectionId, lotNo);

            SqlDataAdapter da = new SqlDataAdapter(sql, ConnString);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dt = GetLotData(dt, "PTM Northing", "PTM Easting");

            dt.Columns.Add("Sketch", typeof(byte[]));

            if (dt.Rows.Count > 0)
            {
                dt.Rows[0]["Sketch"] = Sketch();
            }
            


            rptReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("lsdmsLotDataReport", dt));


            this.rptReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rptReportViewer.RefreshReport();

        }
        private void LoadReportEncodedLotsSummary()
        {

            string sql = @"SELECT     dbo.Lot.CadSurveyNo, 
                                      ISNULL(Region.name,'Unknown') AS Region, ISNULL(Province.name,'Unknown') AS Province, ISNULL(Municipality.name,'Unknown') AS Municipality, dbo.Lot.CadCaseNo, 
                                        ISNULL(Barangay.name,'Unknown') AS Barangay, dbo.Lot.Quadrangle, dbo.Lot.SectionId, COUNT(dbo.Lot.LotNo) AS LotCount, GETDATE() AS AsOf
                            FROM         dbo.psgc AS Province INNER JOIN
                        dbo.psgc AS Municipality ON Province.psgc_cd = SUBSTRING(Municipality.psgc_cd, 1, 4) + '00000' INNER JOIN
                        dbo.psgc AS Region ON SUBSTRING(Province.psgc_cd, 1, 2) + '0000000' = Region.psgc_cd RIGHT OUTER JOIN
                        dbo.psgc AS Barangay RIGHT OUTER JOIN
                        dbo.Lot ON Barangay.psgc_cd = dbo.Lot.BarangayPsgc ON Municipality.psgc_cd = dbo.Lot.MunicipalityPsgc
GROUP BY Region.name, Province.name, Municipality.name, Barangay.name, dbo.Lot.CadSurveyNo, dbo.Lot.CadCaseNo, dbo.Lot.Quadrangle, dbo.Lot.SectionId
ORDER BY ISNULL(Region.name,'Z'), ISNULL(Province.name,'Z'), ISNULL(Municipality.name,'Z'), ISNULL(Barangay.name,'Z')";

            this.rptReportViewer.Reset();
            this.rptReportViewer.LocalReport.ReportEmbeddedResource = "Manager.Reports.EncodedLotsSummary.rdlc";
            
            List<Microsoft.Reporting.WinForms.ReportParameter> parameters = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            
            DataTable dt = GetSqlTable(sql);

            if(dt.Rows.Count > 0)
                parameters.Add(new Microsoft.Reporting.WinForms.ReportParameter("AS_OF", dt.Rows[0]["AsOf"].ToString()));

            this.rptReportViewer.LocalReport.SetParameters(parameters);

            rptReportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("lsdmsEncodedLotsSummary", dt));
            this.rptReportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rptReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;

            
            this.rptReportViewer.RefreshReport();



        }


        private byte[] Sketch()
        {
            byte[] content;

            string cadSurveyNo = FixNull(lbxReportCustom1CadSurveyNo.SelectedValue, "").ToString();
            string municipalityPsgc = FixNull(lbxReportCustom1Municipality.SelectedValue, "").ToString();
            string cadCaseNo = FixNull(lbxReportCustom1Case.SelectedValue, "").ToString();
            string barangayPsgc = FixNull(lbxReportCustom1Barangay.SelectedValue, "").ToString();
            string quadrangle = FixNull(lbxReportCustom1Quadrangle.SelectedValue, "").ToString();
            string sectionId = FixNull(lbxReportCustom1Section.SelectedValue, "").ToString();
            string lotNo = FixNull(lbxReportCustom1Lot.SelectedValue, "").ToString();

            string whereClause = String.Format(" Lot.CadSurveyNo = '{0}' AND Lot.MunicipalityPsgc = '{1}' AND Lot.CadCaseNo = '{2}' AND " +
                                               " Lot.BarangayPSgc = '{3}' AND Lot.Quadrangle = '{4}' AND Lot.SectionId = '{5}' AND Lot.LotNo = '{6}'", 
                                               cadSurveyNo,municipalityPsgc,cadCaseNo, 
                                               barangayPsgc, quadrangle, sectionId, lotNo );

            string sql = String.Format("SELECT LotData.*, Lot.ClaimantName, Lot.DeclaredArea, Lot.ComputedArea, ProvinceTable.name AS [ProvinceName], MunicipalityTable.name AS [MunicipalityName], BarangayTable.name AS [BarangayName]" +
                                        "FROM CadSurvey INNER JOIN " +
                                        "Municipality ON CadSurvey.CadSurveyNo = Municipality.CadSurveyNo INNER JOIN " +
                                          "[Case] ON Municipality.CadSurveyNo = [Case].CadSurveyNo AND " +
                                          "Municipality.MunicipalityPsgc = [Case].MunicipalityPsgc INNER JOIN " +
                                          "Barangay ON [Case].CadSurveyNo = Barangay.CadSurveyNo AND [Case].MunicipalityPsgc = Barangay.MunicipalityPsgc AND " +
                                          "[Case].CadCaseNo = Barangay.CadCaseNo INNER JOIN " +
                                          "Quadrangle ON Barangay.CadSurveyNo = Quadrangle.CadSurveyNo AND " +
                                          "Barangay.MunicipalityPsgc = Quadrangle.MunicipalityPsgc AND Barangay.CadCaseNo = Quadrangle.CadCaseNo AND " +
                                          "Barangay.BarangayPsgc = Quadrangle.BarangayPsgc INNER JOIN " +
                                          "Section ON Quadrangle.CadSurveyNo = Section.CadSurveyNo AND Quadrangle.MunicipalityPsgc = Section.MunicipalityPsgc AND " +
                                          "Quadrangle.CadCaseNo = Section.CadCaseNo AND Quadrangle.BarangayPsgc = Section.BarangayPsgc AND " +
                                          "Quadrangle.Quadrangle = Section.Quadrangle INNER JOIN " +
                                          "Lot ON Section.CadSurveyNo = Lot.CadSurveyNo AND Section.MunicipalityPsgc = Lot.MunicipalityPsgc AND " +
                                          "Section.CadCaseNo = Lot.CadCaseNo AND Section.BarangayPsgc = Lot.BarangayPsgc AND " +
                                          "Section.Quadrangle = Lot.Quadrangle AND Section.SectionId = Lot.SectionId INNER JOIN " +
                                          "LotData ON Lot.CadSurveyNo = LotData.CadSurveyNo AND Lot.MunicipalityPsgc = LotData.MunicipalityPsgc AND " +
                                          "Lot.CadCaseNo = LotData.CadCaseNo AND Lot.BarangayPsgc = LotData.BarangayPsgc AND " +
                                          "Lot.Quadrangle = LotData.Quadrangle AND Lot.SectionId = LotData.SectionId AND Lot.LotNo = LotData.LotNo INNER JOIN " +
                                          "psgc AS ProvinceTable ON CadSurvey.ProvincePsgc = ProvinceTable.psgc_cd INNER JOIN " +
                                          "psgc AS MunicipalityTable ON Municipality.MunicipalityPsgc = MunicipalityTable.psgc_cd INNER JOIN " +
                                          "psgc AS BarangayTable ON Barangay.BarangayPsgc = BarangayTable.psgc_cd " +
                                          "WHERE {0}", whereClause);

            int recordCount = 0;

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                // Create query object that will be used to populate LotDataReport table inside map file
                Manifold.Interop.Query tempQuery = mapControl.get_Document().NewQuery(String.Empty, false);

                // Clear LotData table inside map file
                string manifoldSql = "DELETE FROM [LotDataReport]";
                tempQuery.Text = manifoldSql;
                tempQuery.Run();


                recordCount = dt.Rows.Count;
                int i = 0;

                // Run through the data fetched from Sql Server and insert them in LotData inside map file
                foreach (DataRow dr in dt.Rows)
                {
                    manifoldSql = String.Format(@"INSERT INTO [LotDataReport](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, Sequence, PtmX, PtmY, ClaimantName, DeclaredArea, ComputedArea, ProvinceName, MunicipalityName, BarangayName) " +
                                                @"VALUES(""{0}"",""{1}"",""{2}"",""{3}"",""{4}"",""{5}"",""{6}"",""{7}"",""{8}"",""{9}"",""{10}"",""{11}"",""{12}"",""{13}"",""{14}"",""{15}"")",
                                                 dr["CadSurveyNo"].ToString(),
                                                 dr["MunicipalityPsgc"].ToString(),
                                                 dr["CadCaseNo"].ToString(),
                                                 dr["BarangayPsgc"].ToString(),
                                                 dr["Quadrangle"].ToString(),
                                                 dr["SectionId"].ToString(),
                                                 dr["LotNo"].ToString(),
                                                 dr["Sequence"].ToString(),
                                                 dr["PtmX"].ToString(),
                                                 dr["PtmY"].ToString(),
                                                 dr["ClaimantName"].ToString(),
                                                 dr["DeclaredArea"].ToString(),
                                                 dr["ComputedArea"].ToString(),
                                                 dr["ProvinceName"].ToString(),
                                                 dr["MunicipalityName"].ToString(),
                                                 dr["BarangayName"].ToString());
                    tempQuery.Text = manifoldSql;
                    tempQuery.Run();

                    i++;

                    //decimal progress = Decimal.Divide(i, recordCount) * 100;

                    // Report progress
                    //worker.ReportProgress(Convert.ToInt32(progress));
                    //if (worker.CancellationPending)
                    //{
                    //    return recordCount;
                    //}

                }


                if (recordCount < 1)
                    return null;

                // Remove query object
                mapControl.get_Document().ComponentSet.Remove(tempQuery);

                // Refresh linked components
                mapControl.get_Document().RefreshAllLinked();

                Manifold.Interop.Map mapReport = (Manifold.Interop.Map)mapControl.get_Document().ComponentSet["MapReport"];

 
                string tempImage = DateTime.Now.Ticks.ToString();
                string tempImageFile = Application.StartupPath + @"\" + tempImage + ".jpg";
                string tempXmlFile = Application.StartupPath + @"\" + tempImage + ".xml";
                

                

                Manifold.Interop.Rect rect = mapReport.Application.NewRect(mapReport.Box.XMin - (10),
                                                                           mapReport.Box.YMin - (10),
                                                                           mapReport.Box.XMax + (10),
                                                                           mapReport.Box.YMax + (10));


                //mapReport.RenderAreaTo(tempImage, 500, 350, rect, false);
                mapReport.RenderTo(tempImage, 500, 500, false);
                

                


                Manifold.Interop.Component img = mapControl.get_Document().ComponentSet[tempImage];

                Manifold.Interop.ExportJpeg exporter = (Manifold.Interop.ExportJpeg)mapControl.get_Document().NewExport("JPEG");
                exporter.Quality = Manifold.Interop.JpegQuality.JpegQualityHigh;
                exporter.Export(img, tempImageFile, Manifold.Interop.ConvertPrompt.PromptNone);
                


                //mapControl.set_Component(mapReport);

                FileInfo info = new FileInfo(tempImageFile);

                content = new byte[info.Length];
                FileStream imagestream = info.OpenRead();
                imagestream.Read(content, 0, content.Length);
                imagestream.Close();

                File.Delete(tempImageFile);
                File.Delete(tempXmlFile);

            }
            return content;

        }



        // Events
        private void mapControl_Enter(object sender, EventArgs e)
        {

        }
        private void checkSetNavigation_CheckedButtonChanged(object sender, EventArgs e)
        {
            string header = String.Empty;
            switch (checkSetNavigation.CheckedButton.Name)
            {
                case "btnSpatialQuery":
                    Pages.Show(pnlSpatialQuery);
                    header = "Spatial Query";
                    break;
                case "btnReports":
                    Pages.Show(pnlReports);
                    header = "Create Reports";
                    break;
                case "btnUsers":
                    Pages.Show(pnlUsers);
                    header = "Manage Users";
                    break;
                case "btnSettings":
                    Pages.Show(pnlSettings);
                    header = "Change Settings";
                    break;
                case "btnTextualQuery":
                    Pages.Show(pnlTextualQuery);
                    header = "Textual Query";
                    break;
            }
             
            headerPageContainer.Text = header;
            headerPageContainer.ValuesPrimary.Image = new Bitmap(checkSetNavigation.CheckedButton.Values.Image, new Size(24, 24));
        }

        private void cmbRegion_SelectedValueChanged(object sender, EventArgs e)
        {
            FillProvince();
            FillCadSurvey();
        }
        private void cmbProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCadSurvey();
            cmbCadSurvey.Visible = (cmbProvince.SelectedValue != DBNull.Value);
        }
        private void cmbCadSurvey_SelectedValueChanged(object sender, EventArgs e)
        {
            FillMunicipality();
            cmbMunicipality.Visible = (cmbCadSurvey.SelectedValue != DBNull.Value);
        }
        private void cmbMunicipality_SelectedValueChanged(object sender, EventArgs e)
        {
            FillCase();
            cmbCase.Visible = (cmbMunicipality.SelectedValue != DBNull.Value);
        }
        private void cmbCase_SelectedValueChanged(object sender, EventArgs e)
        {
            FillBarangay();
            cmbBarangay.Visible = (cmbCase.SelectedValue != DBNull.Value);
        }
        private void cmbBarangay_SelectedValueChanged(object sender, EventArgs e)
        {
            FillQuadrangle();
            cmbQuadrangle.Visible = (cmbBarangay.SelectedValue != DBNull.Value);
        }
        private void cmbQuadrangle_SelectedValueChanged(object sender, EventArgs e)
        {
            FillSection();
            cmbSection.Visible = (cmbQuadrangle.SelectedValue != DBNull.Value);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            GetSqlLotDataBW.CancelAsync();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            btnFilter.Visible = false;

            btnCancel.Visible = true;
            pbrAsyc.Visible = true;
            string whereClause = CreateWhereClause();
            GetSqlLotDataBW.RunWorkerAsync(whereClause);

            btnSelectNone.PerformClick();
        }

        // Export
        private void lnkExportToShape_LinkClicked(object sender, EventArgs e)
        {
            string dwgName = "LotDataArea Drawing";
            Manifold.Interop.Drawing dwg = (Manifold.Interop.Drawing)mapControl.get_Document().ComponentSet[dwgName];
            Manifold.Interop.Drawing dwgToExport = mapControl.get_Document().NewDrawing("temp", dwg.CoordinateSystem, false);

            if (!chkExportEntireDrawing.Checked)
            {
                //string dwgName = "LotDataArea Drawing";
                //Manifold.Interop.Drawing dwg = (Manifold.Interop.Drawing)mapControl.get_Document().ComponentSet[dwgName];
                //Manifold.Interop.Drawing dwgToExport = mapControl.get_Document().NewDrawing("temp", dwg.CoordinateSystem, false);


                //dwgToExport = mapControl.get_Document().NewDrawing("temp", dwg.CoordinateSystem, false);


                if (dwg.Selection.Count == 0)
                {
                    MessageBox.Show("Nothing to export.");
                    return;
                }

                // duplicate columnset
                Manifold.Interop.Table tbl = (Manifold.Interop.Table)dwgToExport.OwnedTable;

                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "CadSurveyNo");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "MunicipalityPsgc");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "CadCaseNo");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "BarangayPsgc");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "Quadrangle");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "SectionId");
                AddColumn(tbl, Manifold.Interop.ColumnType.ColumnTypeAText, "LotNo");

                string sql = String.Format(@"INSERT INTO [{0}]([Geom (I)], CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo) SELECT [Geom (I)], CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo FROM [{1}] WHERE [Selection (I)] = True", dwgToExport.Name, dwgName);
                //string sql = String.Format(@"INSERT INTO [{0}]([Geom (I)]) SELECT [Geom (I)] FROM [{1}] WHERE [Selection (I)] = True", dwgToExport.Name, dwgName);
                ExecuteQuery(sql);
            }    


            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".shp";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = String.Format("exported_data_{0: MMddyyyy}", DateTime.Now);
            saveFileDialog.Filter = "Shape files (.shp)|*.shp";


            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;


            if (chkExportEntireDrawing.Checked)
            {
                if (fileName.Trim() != String.Empty) 
                    mapControl.get_Document().NewExport("SHP").Export((Manifold.Interop.Component)dwg, fileName, Manifold.Interop.ConvertPrompt.PromptNone);
            }
            else
            {
                if (fileName.Trim() != String.Empty) 
                    mapControl.get_Document().NewExport("SHP").Export((Manifold.Interop.Component)dwgToExport, fileName, Manifold.Interop.ConvertPrompt.PromptNone);
            }

            mapControl.get_Document().ComponentSet.Remove(dwgToExport);
        }

        private void AddColumn(Manifold.Interop.Table tbl, Manifold.Interop.ColumnType type, string columnName)
        {
            Manifold.Interop.Column col = tbl.ColumnSet.NewColumn();
            col.Name = columnName;
            col.set_Type(type);
            tbl.ColumnSet.Add(col);
        }

        private void lnkExportToExcel_LinkClicked(object sender, EventArgs e)
        {
            string dwgName = "LotDataArea Drawing";
            Manifold.Interop.Drawing dwg = (Manifold.Interop.Drawing)mapControl.get_Document().ComponentSet[dwgName];
            if (dwg.Selection.Count == 0)
            {
                MessageBox.Show("Nothing to export.");
                return;
            }
            

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FileName = String.Format("exported_data_{0: MMddyyyy}", DateTime.Now);
            saveFileDialog.Filter = "MS Excel files (.xls)|*.xls";

            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;

            if (fileName.Trim() != String.Empty)
            {
                DataSet ds = new DataSet();
                ds.Tables.Add((DataTable)dgSelection.DataSource);
                ExportToExcel(ds, fileName);
            }
        }
        


        private void btnSkin_Click(object sender, EventArgs e)
        {
            if (kryptonManager.GlobalPaletteMode == PaletteModeManager.Office2007Blue)
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.SparkleOrange;
            }
            else
            {
                kryptonManager.GlobalPaletteMode = PaletteModeManager.Office2007Blue;
            }
        }


        // multi-threading events
        private void GetSqlLotDataBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnFilter.Visible = true;

            btnCancel.Visible = false;
            pbrAsyc.Visible = false;
            pbrAsyc.Value = 0;
        }
        private void GetSqlLotDataBW_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetSqlLotData(e.Argument.ToString(), sender as BackgroundWorker);

        }
        private void GetSqlLotDataBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbrAsyc.Value = e.ProgressPercentage;
        }

        private void ExecuteQueryAsyncBW_DoWork(object sender, DoWorkEventArgs e)
        {
            ExecuteQuery(e.Argument.ToString());
            ((BackgroundWorker)sender).ReportProgress(100);
        }
        private void ExecuteQueryAsyncBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mapControl.Refresh();
        }
        private void ExecuteQueryAsyncBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string sql = "SELECT " +
                         "CadSurveyNo AS [Cad Survey No], " +
                         "MunicipalityName AS [Municipality], " +
                         "CadCaseNo AS [Case No], " +
                         "BarangayName AS [Barangay], " +
                         "Quadrangle AS [Quadrangle], " +
                         "SectionId AS [Section], " +
                         "LotNo AS [Lot No], " +
                         "DeclaredArea AS [Declared Area], " +
                         "ComputedArea AS [Computed Area], " +
                         "[X (I)] AS [X], [Y (I)] AS [Y] " +
                         "FROM [LotDataArea Drawing] WHERE [Selection (I)] = True";
            //sql = "SELECT * FROM [LotDataArea Drawing] WHERE [Selection (I)] = True";
            dgSelection.DataSource = GetManifoldTable(sql);
        }


        private void btnSelectOverlapping_Click(object sender, EventArgs e)
        {
            ClearSelection("LotDataArea Drawing");
            string sql = "UPDATE " +
                         "(SELECT [LotDataArea Drawing].[Selection (I)] FROM [LotDataArea Drawing] " +
                         "INNER JOIN [LotDataArea Drawing] AS [LotDataArea Drawing2] " +
                         "ON INTERSECTS([LotDataArea Drawing].[GEOM (I)],[LotDataArea Drawing2].[GEOM (I)])) " +
                         "SET [LotDataArea Drawing].[Selection (I)] = True";
            ExecuteQueryAsyncBW.RunWorkerAsync(sql);
        }
        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [LotDataArea Drawing] SET [Selection (I)] = False";
            ExecuteQueryAsyncBW.RunWorkerAsync(sql);
            dgSelection.Visible = false;
        }
        private void btnSelectAreaError_Click(object sender, EventArgs e)
        {
            ClearSelection("LotDataArea Drawing");
            string sql = "UPDATE [LotDataArea Drawing] SET [Selection (I)] = True WHERE ([DeclaredArea]-[ComputedArea]) > 1 ";
            ExecuteQueryAsyncBW.RunWorkerAsync(sql);
        }
        private void btnSelectGap_Click(object sender, EventArgs e)
        {
            ClearSelection("LotDataArea Drawing");
            string sql = "UPDATE " +
                        "(SELECT [LotDataArea Drawing].[Selection (I)] FROM [LotDataArea Drawing] " +
                        "INNER JOIN [LotDataArea Drawing] AS [LotDataArea Drawing2] " +
                        "ON NOT TOUCHES([LotDataArea Drawing].[GEOM (I)],[LotDataArea Drawing2].[GEOM (I)]) AND INTERSECTS(Buffer([LotDataArea Drawing].[GEOM (I)], 1, \"m\"),[LotDataArea Drawing2].[GEOM (I)]) ) " +
                        "SET [LotDataArea Drawing].[Selection (I)] = True";
            ExecuteQueryAsyncBW.RunWorkerAsync(sql);
        }


        private void dgSelection_SelectionChanged(object sender, EventArgs e)
        {
            if (dgSelection.SelectedRows.Count > 0)
            {
                int row = dgSelection.SelectedRows[0].Index;
                double x = Convert.ToDouble(dgSelection[dgSelection.Columns["X"].Index, row].Value);
                double y = Convert.ToDouble(dgSelection[dgSelection.Columns["Y"].Index, row].Value);

                mapControl.Center = mapControl.Application.NewPoint(x, y);
            }




        }
        private void dgCriteria_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            // make sure Operator has a value
            if (dgCriteria["colOperator", e.RowIndex].Value == null)
                dgCriteria["colOperator", e.RowIndex].Value = "=";


            // make sure And/Or has a value is more than 1 criteria
            int lastCriteriaRowIndex = dgCriteria.NewRowIndex - 1;


            foreach (DataGridViewRow dr in dgCriteria.Rows)
            {
                // if this is not the last criteria row and not the new row, then it must 
                // have a value in its And/Or
                if (dr.Index != lastCriteriaRowIndex & !dr.IsNewRow)
                {
                    if (dgCriteria["colAndOr", dr.Index].Value == null)
                    {
                        dgCriteria["colAndOr", dr.Index].Value = "AND";
                    }
                    else
                    {
                        if (dgCriteria["colAndOr", dr.Index].Value.ToString() == String.Empty)
                        {
                            dgCriteria["colAndOr", dr.Index].Value = "AND";
                        }
                    }
                }
            }
        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            string whereClause = "";

            if (lbxTextualQueryColumns.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please select at least one column to display.");
                return;
            }


            if (!dgCriteria.Rows[0].IsNewRow)
            {
                foreach (DataGridViewRow dr in dgCriteria.Rows)
                {
                    if (!dr.IsNewRow)
                    {
                        string colColumnName = dgCriteria["colColumnName", dr.Index].FormattedValue.ToString();
                        bool isString = (dgCriteria["colColumnName", dr.Index].Value.ToString().Replace("|" + colColumnName, String.Empty) == "True");
                        string colOperator = dgCriteria["colOperator", dr.Index].Value.ToString();
                        string colCriteriaValue = dgCriteria["colCriteriaValue", dr.Index].Value.ToString();
                        string colAndOr = "";
                        if (dgCriteria["colAndOr", dr.Index].Value != null)
                            colAndOr = dgCriteria["colAndOr", dr.Index].Value.ToString();

                        colCriteriaValue = (isString ? "'" + (colOperator == "LIKE" ? "%" + colCriteriaValue + "%" : colCriteriaValue) + "'" : colCriteriaValue);


                        whereClause += String.Format("[{0}] {1} {2} {3}\n", colColumnName, colOperator, colCriteriaValue, colAndOr);

                    }
                }
            }
            if (whereClause != String.Empty)
                whereClause = " WHERE " + whereClause;


            string columns = "";

            for (int i = 0; i < lbxTextualQueryColumns.Items.Count; i++)
            {
                if (lbxTextualQueryColumns.GetItemChecked(i))
                {
                    string col = lbxTextualQueryColumns.GetItemText(lbxTextualQueryColumns.Items[i]);
                    columns += String.Format("[{0}],", col);
                }
            }

            
            columns = columns.Substring(0, columns.LastIndexOf(","));


            string sql = String.Format(@"SELECT {0} FROM [lsdmsTextualQuery] {1}", columns, whereClause);
            grdTextualQuery.DataSource = GetSqlTable(sql);

            lblTextualQueryResult.Text = String.Format("Result ({0} rows)", ((DataTable)grdTextualQuery.DataSource).Rows.Count);
            

        }
        private void contextMenuTextualQuery_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Remove":

                    if (dgCriteria.SelectedRows.Count > 0 & dgCriteria.SelectedRows[0].Index != dgCriteria.NewRowIndex)
                    {
                        dgCriteria.Rows.Remove(dgCriteria.SelectedRows[0]);
                    }
                    break;

                case "Clear":
                    dgCriteria.Rows.Clear();
                    break;

                case "":
                    break;

                default:
                    break;
            }
        }

        private void cbxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSelectAll.Checked)
            {
                for (int i = 0; i < lbxTextualQueryColumns.Items.Count; i++)
                {
                    lbxTextualQueryColumns.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < lbxTextualQueryColumns.Items.Count; i++)
                {
                    lbxTextualQueryColumns.SetItemChecked(i, false);
                }
            }
        }

        private void contextMenuUsers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Delete")
            {
                if (dgUsers.SelectedRows.Count > 0)
                    dgUsers.Rows.Remove(dgUsers.SelectedRows[0]);
            }
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try {
                if (daUsers.Update(dtUsers) > 0)
                {
                    MessageBox.Show("Changes saved successfully.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (SqlException ex) {
                MessageBox.Show(ex.Message);
                dtUsers.RejectChanges();
            }
                
            
        }
        private void btnLoadReportLotData_Click(object sender, EventArgs e)
        {
            LoadReportLotDataComputation();
        }
        private void btnLoadReportCustom1_Click(object sender, EventArgs e)
        {
            LoadReportCustom1();
        }
        private void tabControlReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rptReportViewer.Reset();
        }

        private void btnRptLoadEncodedLotsPerUser_Click(object sender, EventArgs e)
        {
            LoadReportEncodedLotsPerUser();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRptLoadEncodedLotsSummary_Click(object sender, EventArgs e)
        {
            LoadReportEncodedLotsSummary();
        }







        public static void ExportToExcel(DataSet source, string fileName)
        {

            System.IO.StreamWriter excelDoc;

            excelDoc = new System.IO.StreamWriter(fileName);
            const string startExcelXML = "<xml version>\r\n<Workbook " +
                  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                  "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                  "office:spreadsheet\">\r\n <Styles>\r\n " +
                  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                  "\r\n <Protection/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                  "</Styles>\r\n ";
            const string endExcelXML = "</Workbook>";

            int rowCount = 0;
            int sheetCount = 1;
            /*
           <xml version>
           <Workbook xmlns="urn:schemas-microsoft-com:office:spreadsheet"
           xmlns:o="urn:schemas-microsoft-com:office:office"
           xmlns:x="urn:schemas-microsoft-com:office:excel"
           xmlns:ss="urn:schemas-microsoft-com:office:spreadsheet">
           <Styles>
           <Style ss:ID="Default" ss:Name="Normal">
             <Alignment ss:Vertical="Bottom"/>
             <Borders/>
             <Font/>
             <Interior/>
             <NumberFormat/>
             <Protection/>
           </Style>
           <Style ss:ID="BoldColumn">
             <Font x:Family="Swiss" ss:Bold="1"/>
           </Style>
           <Style ss:ID="StringLiteral">
             <NumberFormat ss:Format="@"/>
           </Style>
           <Style ss:ID="Decimal">
             <NumberFormat ss:Format="0.0000"/>
           </Style>
           <Style ss:ID="Integer">
             <NumberFormat ss:Format="0"/>
           </Style>
           <Style ss:ID="DateLiteral">
             <NumberFormat ss:Format="mm/dd/yyyy;@"/>
           </Style>
           </Styles>
           <Worksheet ss:Name="Sheet1">
           </Worksheet>
           </Workbook>
           */
            excelDoc.Write(startExcelXML);
            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
            excelDoc.Write("<Table>");
            excelDoc.Write("<Row>");
            for (int x = 0; x < source.Tables[0].Columns.Count; x++)
            {
                excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                excelDoc.Write(source.Tables[0].Columns[x].ColumnName);
                excelDoc.Write("</Data></Cell>");
            }
            excelDoc.Write("</Row>");
            foreach (DataRow x in source.Tables[0].Rows)
            {
                rowCount++;
                //if the number of rows is > 64000 create a new page to continue output

                if (rowCount == 64000)
                {
                    rowCount = 0;
                    sheetCount++;
                    excelDoc.Write("</Table>");
                    excelDoc.Write(" </Worksheet>");
                    excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                    excelDoc.Write("<Table>");
                }
                excelDoc.Write("<Row>"); //ID=" + rowCount + "

                for (int y = 0; y < source.Tables[0].Columns.Count; y++)
                {
                    System.Type rowType;
                    rowType = x[y].GetType();
                    switch (rowType.ToString())
                    {
                        case "System.String":
                            string XMLstring = x[y].ToString();
                            XMLstring = XMLstring.Trim();
                            XMLstring = XMLstring.Replace("&", "&amp;");
                            XMLstring = XMLstring.Replace(">", "&gt;");
                            XMLstring = XMLstring.Replace("<", "&lt;");
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                            excelDoc.Write(XMLstring);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DateTime":
                            //Excel has a specific Date Format of YYYY-MM-DD followed by  

                            //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000

                            //The Following Code puts the date stored in XMLDate 

                            //to the format above

                            DateTime XMLDate = (DateTime)x[y];
                            string XMLDatetoString = ""; //Excel Converted Date

                            XMLDatetoString = XMLDate.Year.ToString() +
                                 "-" +
                                 (XMLDate.Month < 10 ? "0" +
                                 XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                 "-" +
                                 (XMLDate.Day < 10 ? "0" +
                                 XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                 "T" +
                                 (XMLDate.Hour < 10 ? "0" +
                                 XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                 ":" +
                                 (XMLDate.Minute < 10 ? "0" +
                                 XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                 ":" +
                                 (XMLDate.Second < 10 ? "0" +
                                 XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                 ".000";
                            excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                         "<Data ss:Type=\"DateTime\">");
                            excelDoc.Write(XMLDatetoString);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Boolean":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                        "<Data ss:Type=\"String\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                    "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Decimal":
                        case "System.Double":
                            excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                  "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DBNull":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                  "<Data ss:Type=\"String\">");
                            excelDoc.Write("");
                            excelDoc.Write("</Data></Cell>");
                            break;
                        default:
                            throw (new Exception(rowType.ToString() + " not handled."));
                    }
                }
                excelDoc.Write("</Row>");
            }
            excelDoc.Write("</Table>");
            excelDoc.Write(" </Worksheet>");
            excelDoc.Write(endExcelXML);
            excelDoc.Close();
        }
    
    }
}