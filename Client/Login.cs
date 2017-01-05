using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Xml;
using System.Data.SqlClient;

namespace LSDMS
{
    public partial class Login : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        int Level;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = GheloBytes.Version();

            textBoxDatabaseServer.Text = GetSetting("servers", "DatabaseServer", "name");
            textBoxImageServer.Text = GetSetting("servers", "ImageServer", "name");
        }
        private void labelMoreOptions_LinkClicked(object sender, EventArgs e)
        {
            if (labelMoreOptions.Text == "Show options")
            {
                labelMoreOptions.Text = "Hide options";

                this.Height += panelAdditonalOptions.Size.Height;
            }
            else
            {
                labelMoreOptions.Text = "Show options";
                this.Height -= panelAdditonalOptions.Size.Height;
            }
        }

        private string GetSetting(string section, string setting, string attribute)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            return node.Attributes[attribute].Value;
        }
        private void SetSetting(string section, string setting, string attribute, string value)
        {
            string configFile = Application.StartupPath + @"\lsdms.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);

            XmlNode node = doc.SelectSingleNode("config/" + section + "/" + setting);
            node.Attributes[attribute].Value = value;
            doc.Save(configFile);
        }


        private bool IsValidUser(string username, string password)
        {
            string server = textBoxDatabaseServer.Text;
            string connString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92;";
            bool retVal = false;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = "SELECT Access FROM [lsdms_users] WHERE Username = @Username AND Password = @Password";


                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();


                object level = cmd.ExecuteScalar();

                if (level != null)
                {
                    Level = (int)cmd.ExecuteScalar();
                    retVal = true;
                }
                else
                {
                    retVal = false;
                }

                
            }

            return retVal;
        }
        private bool IsConnectionOk()
        {
            string server = textBoxDatabaseServer.Text;
            string connString = @"Data Source=" + server + ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92;Connect Timeout=5";
            bool retVal = false;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    retVal = true;
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    retVal = false;
                }
                
            }
            return retVal;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (IsConnectionOk())
            {
                if (IsValidUser(textBoxUsername.Text, textBoxPassword.Text))
                {
                    LogUserIn();
                }
                else
                {
                    MessageBox.Show("Login failed!", "LSDMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Cannot connect to database server.", "LSDMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnLogin.PerformClick();
            }
        }

        private void LogUserIn()
        {
            SetSetting("servers", "DatabaseServer", "name", textBoxDatabaseServer.Text);
            SetSetting("servers", "ImageServer", "name", textBoxImageServer.Text);
            this.Hide();
            MainForm mainForm = new MainForm(textBoxUsername.Text, Level);
            mainForm.Show();
        }
        


    }
}