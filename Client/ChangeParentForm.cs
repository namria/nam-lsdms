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

namespace LSDMS
{
    public partial class ChangeParentForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        string ConnString = String.Empty;

        string[] keys = new string[] { "CadSurveyNo", "MunicipalityPsgc", "CadCaseNo", "BarangayPsgc", "Quadrangle", "SectionId", "LotNo" };
        string[] tables = new string[] { "CadSurvey", "Municipality", "[Case]", "Barangay", "Quadrangle", "Section", "Lot" };
        int index = 0;

        string[] code;
        string keyName;
        string keyValue;
        string tableName;

        string parentKeyName;
        string parentKeyValue;
        string parentTableName;


        string whereClause = "";

        string displayName = "";



        private int _AffectedRecords = 0;
        public int AffectedRecords
        {
            get { return _AffectedRecords; }
        }


        public string SelectedValue
        {
            get { return keyValue; }
        }

        public string SelectedParentValue
        {
            get { return lbxCodes.SelectedValue.ToString(); }
        }




        
        public ChangeParentForm(string[] p, string d)
        {
            code = p;
            displayName = d;
            InitializeComponent();
        }

        private void btnCancel_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeParentForm_Load(object sender, EventArgs e)
        {
            Init();
            BindKeys();
        }

        private void Init()
        {
            string server = GetSetting("servers", "DatabaseServer", "name");
            ConnString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92";

            index = code.Length - 1;

            keyName = keys[index];
            keyValue = code[index];
            tableName = tables[index];


            parentKeyName = keys[index - 1];
            parentKeyValue = code[index - 1];
            parentTableName = tables[index - 1];


            // construct where clause
            for (int i = 0; i < code.Length - 2; i++)
            {
                whereClause += (keys[i] + "='" + code[i] + "' AND ");
            }

                                
        }





        private void BindKeys()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open();

            string sql = "";


            switch (parentTableName)
            {
                case "Municipality":
                    sql = String.Format("SELECT name AS DisplayMember, MunicipalityPsgc AS ValueMember " +
                                       "FROM [Municipality] " +
                                       "INNER JOIN " +
                                       "[PSGC] ON [Municipality].MunicipalityPsgc = [PSGC].Psgc_cd " +
                                       "WHERE {2} NOT {0} = '{1}'", parentKeyName, parentKeyValue, whereClause);
                    break;
                case "Barangay":
                    sql = String.Format("SELECT name AS DisplayMember, BarangayPsgc AS ValueMember " +
                                       "FROM [Barangay] " +
                                       "INNER JOIN " +
                                       "[PSGC] ON [Barangay].BarangayPsgc = [PSGC].Psgc_cd " +
                                       "WHERE {2} NOT {0} = '{1}'", parentKeyName, parentKeyValue, whereClause);
                    break;
                default:
                    sql = String.Format("SELECT {0} AS DisplayMember, {0} AS ValueMember FROM {1} WHERE {3} NOT {0} = '{2}'", parentKeyName, parentTableName, parentKeyValue, whereClause);
                    break;
            }



            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            lbxCodes.DataSource = dt;
            lbxCodes.DisplayMember = "DisplayMember";
            lbxCodes.ValueMember = "ValueMember";


        }






        private void ChangeParent(string[] childCode, string destinationParentCode)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();


            cmd.Connection = conn;
            conn.Open();

           
            string sql = "";

            // If destination parent code exist, check if no conflict will occur in child table
            sql = String.Format("SELECT COUNT(*) FROM {0} WHERE {1}", tableName, whereClause + parentKeyName + "='" + destinationParentCode + "' AND " + keyName + "='" + keyValue + "'");

            cmd.CommandText = sql;

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                MessageBox.Show(String.Format("Moving '{0}' under '{1}' will create duplicate value. ", displayName, lbxCodes.ListBox.Text),"Error!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Everything is ok, move the record to destination


            string updateWhereClause = "";
            for (int i = 0; i < childCode.Length - 1; i++)
            {
                updateWhereClause += (keys[i] + "='" + childCode[i] + "' AND ");
            }
            updateWhereClause += keyName + "='" + keyValue + "'";
            sql = String.Format("UPDATE {0} SET {1} = '{2}' WHERE {3}", tableName, parentKeyName, destinationParentCode, updateWhereClause);

            cmd.CommandText = sql;
            _AffectedRecords = cmd.ExecuteNonQuery();

        }


        private string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }

        private void btnChangeParent_Click(object sender, EventArgs e)
        {
            string msg = String.Format("You are about to change the parent of '{0}' to '{1}'.\n\n Do you want to continue?", displayName, lbxCodes.ListBox.Text);
            DialogResult result = MessageBox.Show(msg, "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ChangeParent(code, lbxCodes.SelectedValue.ToString());
            }
            this.Close();    
        }

    }
}