using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // remove this on final release
                            // MessageBox is needed.

namespace LSDMS
{
    class DataSetValidator
    {
        string ConnString;

        DataSet Dataset;
        List<string> MustBeUniqueList = new List<string>();
        List<string> MustNotBeEmptyList = new List<string>();
        List<RangeDefinition> MustBeBetweenList = new List<RangeDefinition>();
        List<string> MustBeADateList = new List<string>();

        SqlConnection conn;
        


        // events
        public delegate void MustBeUniqueHandler(object myObject, DataColumnChangeEventArgs e);
        public event MustBeUniqueHandler OnMustBeUniqueError;


        class RangeDefinition
        {
            public string ColumnName;
            public decimal Minimum;
            public decimal Maximum;
            public RangeDefinition(string columnName, decimal min, decimal max)
            {
                this.ColumnName = columnName;
                this.Minimum = min;
                this.Maximum = max;
            }

        }
     

        // Constructor
        public DataSetValidator(DataSet ds, string connString)
        {
            ConnString = connString;
            Dataset = ds;

            conn = new SqlConnection(ConnString);
            conn.Open();
        }

        // Methods
        public void StartWatching()
        {
            foreach (DataTable dt in Dataset.Tables)
            {
                dt.ColumnChanging += new DataColumnChangeEventHandler(DataColumnChanging);
            }
        }
        public void StopWatching()
        {
            foreach (DataTable dt in Dataset.Tables)
            {
                dt.ColumnChanging -= new DataColumnChangeEventHandler(DataColumnChanging); ;
            }
        }

        public void ClearErrors(string tableName)
        {
            foreach(DataRow row in Dataset.Tables[tableName].Rows)
            {
                row.ClearErrors();
            }
        }

        public void MustNotBeEmpty(string columnName)
        {
            MustNotBeEmptyList.Add(columnName);
        }
        public void MustBeBetween(string columnName, decimal min, decimal max)
        {
            RangeDefinition rangeDef = new RangeDefinition(columnName.ToLower(), min, max);
            MustBeBetweenList.Add(rangeDef);
        }
        public void MustBeUnique(string columnName)
        {
            MustBeUniqueList.Add(columnName);
        }
        public void MutBeADate(string columnName)
        {
            MustBeADateList.Add(columnName);
        }


        // Events
        private void DataColumnChanging(Object sender, DataColumnChangeEventArgs e)
        {

            string table = sender.ToString();
            string column = e.Column.ToString();
            string columnName = table + "." + column;

            // reset any previous error
            e.Row.SetColumnError(e.Column, String.Empty);

            // Check MustNotBeEmpty
            if (MustNotBeEmptyList.Contains(columnName))
            {
                if (e.ProposedValue == null || string.IsNullOrEmpty(e.ProposedValue.ToString()))
                {
                    e.Row.SetColumnError(e.Column, "Cannot be empty");
                    return;
                }
                else
                {
                    e.Row.SetColumnError(e.Column, String.Empty);
                }
            }

            // Check MustBeADate
            if (MustBeADateList.Contains(columnName))
            {
                if (!string.IsNullOrEmpty(e.ProposedValue.ToString()))
                {
                    try
                    {
                        DateTime date = DateTime.Parse(e.ProposedValue.ToString());
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        e.Row.SetColumnError(e.Column, "Must be a date.");
                    }

                }
                else
                {
                    e.Row.SetColumnError(e.Column, String.Empty);
                    return;
                }
                
                 
            }




            // Check MustBeUnique
            if (MustBeUniqueList.Contains(columnName))
            {
                if (columnName != "Sequence" & columnName != "Lot.LotNo")
                {
                    // START OLD PROCEDURE
                    DataRow[] dr = e.Column.Table.Select(e.Column.ColumnName + "='" + e.ProposedValue.ToString() + "'");
                    if (dr.Length > 0)
                    {
                        // trigger MustBeUnique event here
                        e.Row.SetColumnError(e.Column, "Must be unique. " + e.ProposedValue.ToString() + " already exist.");
                        OnMustBeUniqueError(this, e);
                        return;
                    }
                    else
                    {
                        e.Row.SetColumnError(e.Column, String.Empty);
                    }
                    // END OLD PROCEDURE
                }

                if (table == "Lot" & columnName == "Lot.LotNo")
                {
                    DataTable dt = ((DataTable)sender).ParentRelations["FK_Lot_Section"].ParentTable;

                    //////string cadSurveyNo = dt.Rows[0]["CadSurveyNo"].ToString();
                    //////string municipality = dt.Rows[0]["MunicipalityPsgc"].ToString();
                    //////string cadCaseNo = dt.Rows[0]["CadCaseNo"].ToString();
                    //////string barangay = dt.Rows[0]["BarangayPsgc"].ToString();
                    //////string quadrangle = dt.Rows[0]["Quadrangle"].ToString();
                    //////string section = dt.Rows[0]["SectionId"].ToString();
                    //////string lotNo = e.ProposedValue.ToString();

                    string cadSurveyNo = e.Row["CadSurveyNo"].ToString();
                    string municipality = e.Row["MunicipalityPsgc"].ToString();
                    string cadCaseNo = e.Row["CadCaseNo"].ToString();
                    string barangay = e.Row["BarangayPsgc"].ToString();
                    string quadrangle = e.Row["Quadrangle"].ToString();
                    string section = e.Row["SectionId"].ToString();
                    string lotNo = e.ProposedValue.ToString();

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT(*) FROM Lot WHERE CadSurveyNo = @CadSurveyNo AND " +
                                      "MunicipalityPsgc = @MunicipalityPsgc AND " +
                                      "CadCaseNo = @CadCaseNo AND " +
                                      "BarangayPsgc = @BarangayPsgc AND " +
                                      "Quadrangle = @Quadrangle AND " +
                                      "SectionId = @SectionId AND " +
                                      "LotNo = @LotNo ";
                    cmd.Parameters.AddWithValue("@CadSurveyNo", cadSurveyNo);
                    cmd.Parameters.AddWithValue("@MunicipalityPsgc", municipality);
                    cmd.Parameters.AddWithValue("@CadCaseNo", cadCaseNo);
                    cmd.Parameters.AddWithValue("@BarangayPsgc", barangay);
                    cmd.Parameters.AddWithValue("@Quadrangle", quadrangle);
                    cmd.Parameters.AddWithValue("@SectionId", section);
                    cmd.Parameters.AddWithValue("@LotNo", lotNo);
                    
                    
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        // trigger MustBeUnique event here
                        e.Row.SetColumnError(e.Column, "Must be unique. " + e.ProposedValue.ToString() + " already exist.");
                        OnMustBeUniqueError(this, e);
                        return;
                    }
                    else
                    {
                        e.Row.SetColumnError(e.Column, String.Empty);
                    }
                }

            }



            // Check MustBeBetween
            foreach (RangeDefinition rangeDef in MustBeBetweenList)
            {

                if (e.ProposedValue != null)
                {

                    if (rangeDef.ColumnName.ToLower() == columnName.ToLower())
                    {
                        e.Row.SetColumnError(e.Column, String.Empty);

                        if (!IsNumeric(e.ProposedValue) && (e.ProposedValue != DBNull.Value) && (!string.IsNullOrEmpty(e.ProposedValue.ToString())))
                        {
                            e.Row.SetColumnError(e.Column, "Must be numeric");
                            return;
                        }
                        else
                        {
                            if (e.ProposedValue != DBNull.Value && (!string.IsNullOrEmpty(e.ProposedValue.ToString())))
                            {
                                decimal value = Convert.ToDecimal(e.ProposedValue);
                                if (!(value >= rangeDef.Minimum && value <= rangeDef.Maximum))
                                {
                                    e.Row.SetColumnError(e.Column, "Value must be between " +
                                                         rangeDef.Minimum.ToString() + " and " +
                                                         rangeDef.Maximum.ToString());
                                    return;
                                }
                            }

                        }
                    }


                }
                



            }



        }

        // Helper
        static bool IsNumeric(object Expression)
        {
            double retNum;
            return Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
        }





    }
}
