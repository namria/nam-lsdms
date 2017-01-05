using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using System.Xml;

namespace LSDMS
{
    public partial class MergeForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        string ConnString = String.Empty;

        string[] keys = new string[] { "CadSurveyNo", "MunicipalityPsgc", "CadCaseNo", "BarangayPsgc", "Quadrangle", "SectionId", "LotNo" };
        string[] tables = new string[] { "CadSurvey", "Municipality", "[Case]", "Barangay", "Quadrangle", "Section", "Lot" };
        int index = 0;

        string[] code;
        string keyName;
        string keyValue;
        string tableName;

        string childKeyName;
        string childTableName;

        string whereClause = "";

        string displayName = "";


        private int _AffectedRecords = 0;
        public int AffectedRecords
        {
            get { return _AffectedRecords; }
        }


        public string SelectedValue
        {
            get { return lbxCodes.SelectedValue.ToString(); }
        }


        public string TableName
        {
            get { return tableName; }
        }



        public MergeForm(string[] p, string d)
        {
            code = p;
            displayName = d;
            InitializeComponent();
        }

        private void MergeForm_Load(object sender, EventArgs e)
        {
            Init();
            BindKeys();

        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            string msg = String.Format("You are about to merge '{0}' with '{1}'.\n\n Do you want to continue?", displayName, lbxCodes.ListBox.Text);
            DialogResult result = MessageBox.Show(msg, "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MergeRecord(code, lbxCodes.SelectedValue.ToString());
            }
            this.Close();          
        }
        private void btnCancel_LinkClicked(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Init()
        {

            string server = GetSetting("servers", "DatabaseServer", "name");
            ConnString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92";

            index = code.Length - 1;

            keyName = keys[index];
            keyValue = code[index];
            tableName = tables[index];

            childKeyName = keys[index + 1];
            childTableName = tables[index + 1];

            // construct where clause
            for (int i = 0; i < code.Length - 1; i++)
            {
                whereClause += (keys[i] + "='" + code[i] + "' AND ");
            }

            string msg;

            switch (tableName)
            {
                case "Municipality":
                    msg = String.Format("Merge '{0}' with another record", displayName );
                    break;
                case "Barangay":
                    msg = String.Format("Merge '{0}' with another record", displayName);
                    break;
                default:
                    msg = String.Format("Merge '{0}' with another record", keyValue);
                    break;
            }

            this.Text = msg;
        }
  
        private void MergeRecord2(string[] code, string destinationCode)
        {

            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open();

            string sql = "";

            switch (childTableName)
            {
                case "Municipality":
                    sql = String.Format("SELECT [name] AS {2} FROM {0} INNER JOIN PSGC ON {2} = PSGC.PSGC_CD WHERE " +
                                                            "{1} " +
                                                            "AND " +
                                                            "({2} IN (SELECT {2} FROM {0} WHERE {3}))",
                                                            childTableName,
                                                            whereClause + keyName + "='" + destinationCode + "'",
                                                            childKeyName,
                                                            whereClause + keyName + "='" + keyValue + "'");
                    break;
                case "Barangay":
                    sql = String.Format("SELECT [name] AS {2} FROM {0} INNER JOIN PSGC ON {2} = PSGC.PSGC_CD WHERE " +
                                                            "{1} " +
                                                            "AND " +
                                                            "({2} IN (SELECT {2} FROM {0} WHERE {3}))",
                                                            childTableName,
                                                            whereClause + keyName + "='" + destinationCode + "'",
                                                            childKeyName,
                                                            whereClause + keyName + "='" + keyValue + "'");
                    break;
                default:
                    sql = String.Format("SELECT {2} FROM {0} WHERE " +
                                        "{1} " +
                                        "AND " +
                                        "({2} IN (SELECT {2} FROM {0} WHERE {3}))",
                                        childTableName, 
                                        whereClause + keyName + "='" + destinationCode + "'", 
                                        childKeyName, 
                                        whereClause + keyName + "='" + keyValue + "'");
                    break;
            }




            int count = 0;

            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();

            string duplicateRecords = "";
            while (reader.Read())
            {
                duplicateRecords += "'" + reader[childKeyName].ToString() + "', ";
                count++;
            }

            //MessageBox.Show(sql);
            //Console.WriteLine("XXXX   " + sql);

            if (count > 0)
            {
                duplicateRecords = duplicateRecords.Substring(0, duplicateRecords.LastIndexOf(", "));

                string msg;
                if (count == 1)
                {
                    msg = String.Format("Merging '{0}' with '{1}' will create a duplicate child record. \nThe child record under '{0}' that will cause this conflict is: \n{2} \n\n Resolve this conflict first and try again.", displayName, lbxCodes.ListBox.Text, duplicateRecords);
                }
                else
                {
                    msg = String.Format("Merging '{0}' with '{1}' will create duplicate child records. \nThe child records under '{0}' that will cause these conflicts are: \n{2} \n\n Resolve these conflicts first and try again.", displayName, lbxCodes.ListBox.Text, duplicateRecords);
                }

                MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //throw new Exception(String.Format("Merging '{0}' with '{1}' will create duplicate child records.", keyValue, destinationCode));
            }


            // Proceed with the merging

            sql = String.Format("UPDATE {0} SET {1} = '{2}' WHERE {3}; DELETE FROM {4} WHERE {3}", childTableName, keyName, destinationCode, whereClause + keyName + "='" + keyValue + "'", tableName);

            conn.Close();
            conn.Open();
            cmd.CommandText = sql;
            _AffectedRecords = cmd.ExecuteNonQuery();

            //MessageBox.Show(sql);
            //Console.WriteLine("XXXX   " + sql);
            
        }

        private void BindKeys()
        {
            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open();

            string sql = "";

            switch (tableName)
            {
                case "Municipality":
                    sql = String.Format("SELECT name AS DisplayMember, MunicipalityPsgc AS ValueMember " + 
                                       "FROM [Municipality] " +
                                       "INNER JOIN " + 
                                       "[PSGC] ON [Municipality].MunicipalityPsgc = [PSGC].Psgc_cd " +
                                       "WHERE {0} NOT {1} = '{2}'", whereClause, keyName, keyValue);
                    break;
                case "Barangay":
                    sql = String.Format("SELECT name AS DisplayMember, BarangayPsgc AS ValueMember " +
                                       "FROM [Barangay] " +
                                       "INNER JOIN " +
                                       "[PSGC] ON [Barangay].BarangayPsgc = [PSGC].Psgc_cd " +
                                       "WHERE {0} NOT {1} = '{2}'", whereClause, keyName, keyValue);
                    break;
                default:
                    sql = String.Format("SELECT {0} AS DisplayMember, {0} AS ValueMember FROM {1} WHERE {3} NOT {0} = '{2}'", keyName, tableName, keyValue, whereClause);
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





        private string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }










        private void MergeRecord(string[] code, string destinationCode)
        {

            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            conn.Open();

            

            int index = code.Length;

            for (int i = index; i < tables.Length; i++)
            {
                string table = tables[i];

                string destinationTableName = tables[i];
                string notInKeyName = keys[i];
                string joinClause = String.Empty;

                for (int j = 0; j <= i; j++)
                {
                    if (keyName != keys[j])
                        joinClause += String.Format("Source.{0} = Destination.{0} {1} ",keys[j], (j==i? String.Empty: "AND \n"));
                }

                string sql = String.Format("UPDATE {0} SET {5} = '{6}' WHERE {1} AND {2} NOT IN \n" +
                                            "(SELECT Destination.{2} FROM  \n" +
                                            "   (SELECT * FROM {0} WHERE {1}) AS Source, \n" +
                                            "   (SELECT * FROM {0} WHERE {3}) AS Destination \n" +
                                            "WHERE {4})", 
                                            destinationTableName, 
                                            String.Format("{0} {1}='{2}'", whereClause, keyName, keyValue),
                                            notInKeyName,
                                            String.Format("{0} {1}='{2}'", whereClause, keyName, destinationCode),
                                            joinClause, keyName, destinationCode);

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


            }

            cmd.CommandText = String.Format("DELETE FROM {0} WHERE {1} {2} = '{3}'", tableName, whereClause, keyName, keyValue);
            cmd.ExecuteNonQuery();

            _AffectedRecords = 1;

        }


    }
}