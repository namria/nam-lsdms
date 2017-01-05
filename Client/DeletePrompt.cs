using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;

namespace LSDMS
{
    public partial class DeletePrompt : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        string ConnString;

        public bool Allow = false;

        public DeletePrompt(string connString)
        {
            ConnString = connString;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            if (IsAdministrator(txtUsername.Text, txtPassword.Text)) 
            {
                this.Allow = true;
                this.Close();
            } 
        }


        private bool IsAdministrator(string username, string password)
        {
            bool retVal = false;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "SELECT Access FROM [lsdms_users] WHERE Username = @Username AND Password = @Password";


                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();


                object access = cmd.ExecuteScalar();

                if (access != null)
                {
                    retVal = ((int)access > 1);
                }
                else
                {
                    retVal = false;
                }
            }

            return retVal;
        }


    }
}