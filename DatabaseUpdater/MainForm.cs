using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;

using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;


namespace DatabaseUpdater
{
    public partial class MainForm : Form
    {
        const string CONN_STRING = @"Data Source={0};Initial Catalog=master;Integrated Security=True;Connect Timeout=2";
        static string _instanceName;
        bool _isDbExisting;

        string backupName;
        string restoreName;
        string sqlServerPath;
        string blankBackup;

        
        public MainForm()
        {
            InitializeComponent();

            _instanceName = GetInstanceName();
            backupName = "prs92 [" + DateTime.Now.Month.ToString("00") +
                             DateTime.Now.Day.ToString("00") +
                             DateTime.Now.Year.ToString("0000]") +
                             DateTime.Now.Hour.ToString("[00") +
                             DateTime.Now.Minute.ToString("00]") + ".bak";
            restoreName = "prs92_" + DateTime.Now.Month.ToString("00") +
                                DateTime.Now.Day.ToString("00") +
                                DateTime.Now.Year.ToString("0000") +
                                DateTime.Now.Hour.ToString("00") +
                                DateTime.Now.Minute.ToString("00");
            //static string sqlServerPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\Microsoft SQL Server\MSSQL.1\MSSQL\Data";
            sqlServerPath = GetSQLServerPath() + "\\Data";
            blankBackup = sqlServerPath + @"\prs92 blank [" + DateTime.Now.Month.ToString("00") +
                                                     DateTime.Now.Day.ToString("00") +
                                                     DateTime.Now.Year.ToString("0000]") +
                                                     DateTime.Now.Hour.ToString("[00") +
                                                     DateTime.Now.Minute.ToString("00]") + ".bak";

        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "&Close")
            {
                this.Close();
            } else {
                StartUpdate();
            }            

        }

        private void StartUpdate()
        {
            ShowMessage("START");
            btnStart.Visible = false;
            lblProcessing.Visible = true;

            // Check if this is a server running a sql server instance
            if (_instanceName == string.Empty)
            {
                ShowMessage("Error accessing SQL Server.");
                ShowMessage("Update of [PRS92] database has failed.");
                ShowMessage("END");
                return;
            }

            // Check if PRS92 DB is already existing
            _isDbExisting = IsPRS92DBExisting();
            if (_isDbExisting)
            {
                ShowMessage("An existing [PRS92] database was found.");
                UpdatePRS92Db();
            }
            else
            {
                ShowMessage("No existing [PRS92] database was found. A new one will be created.");
                CreateNewPRS92Db();
            }

            btnStart.Text = "&Close";
            btnStart.Visible = true;
            lblProcessing.Visible = false;

        }

        private void CreateNewPRS92Db()
        {
            // Create new [PRS92] database
            try
            {
                WriteResourceToFile(@"SQL.prs92_blank.bak", blankBackup);
                string sql = string.Format(@"RESTORE DATABASE [PRS92] " +
                                    @"FROM DISK = '{0}' " +
                                    @"     WITH MOVE 'prs92Data' TO N'{1}\prs92.mdf', " +
                                    @"          MOVE 'prs92Log'  TO N'{1}\prs92.ldf' ", blankBackup, sqlServerPath);
                ExecuteQuery(sql);

                File.Delete(blankBackup);
                ShowMessage("A blank [PRS92] database was created.");


                // add PRS92 user
                sql = GetStringResource("SQL.AddPRSUser.sql");
                ExecuteQuery(sql);

            }
            catch (Exception ex)
            {
                string msg = String.Format("\nStack Trace: {0}\nMessage: {1}\nSource: {2}", ex.StackTrace, ex.Message, ex.Source);
                LogErrorToTextFile(msg);

                ShowMessage("An error occured on creating a new [PRS92] database");
                ShowMessage("END");
                return;
            }

            ShowMessage("Successfully created a new [PRS92] database");
            ShowMessage("END");

        }
        private void UpdatePRS92Db()
        {
            string sql;

            // Create a backup of existing PRS92.
            sql = string.Format("BACKUP DATABASE [PRS92] TO DISK='{0}' WITH FORMAT, NAME=N'PRS92 Backup before {1} was applied'", backupName, this.Text);
            if (ExecuteQuery(sql) == string.Empty)
            {
                ShowMessage("A backup of your existing [PRS92] database was created. File: " + backupName);
            }
            else
            {
                ShowMessage("An attempt to backup your existing [PRS92] database has failed.");
                ShowMessage("END");
                return;
            };


            // Drop existing PRS92
            sql = GetStringResource("SQL.DropDB.sql");
            if (ExecuteQuery(sql) == string.Empty)
            {
                ShowMessage("Your existing [PRS92] was dropped.");
            }
            else
            {
                ShowMessage("An attempt to drop your existing [PRS92] has failed.");
                ShowMessage("Make sure no application is using your existing [PRS92] database.");
                ShowMessage("END");
                return;
            };


            // Restore existing PRS92 backup as PRS92{rand}
            sql = string.Format(GetStringResource("SQL.RestoreDB.sql"), backupName, restoreName, sqlServerPath);
            if (ExecuteQuery(sql) == string.Empty)
            {
                ShowMessage("Old [PRS92] restored as [" + restoreName + "].");
            }
            else
            {
                ShowMessage("An error occured on restoring old [PRS92] database as [" + restoreName + "].");
                ShowMessage("END");
                return;
            };

            // Create new [PRS92] database
            try
            {
                WriteResourceToFile(@"SQL.prs92_blank.bak", blankBackup);
                sql = string.Format(@"RESTORE DATABASE [PRS92] " +
                                    @"FROM DISK = '{0}' " +
                                    @"     WITH MOVE 'prs92Data' TO N'{1}\prs92.mdf', " +
                                    @"          MOVE 'prs92Log'  TO N'{1}\prs92.ldf' ", blankBackup,sqlServerPath);
                ExecuteQuery(sql);

                File.Delete(blankBackup);
                ShowMessage("A blank [PRS92] database was created.");
                ShowMessage(String.Format("Copying data from [{0}] database to new [PRS92] database.", restoreName));

                
                // add PRS92 user
                sql = GetStringResource("SQL.AddPRSUser.sql");
                ExecuteQuery(sql);

            }
            catch (Exception ex)
            {
                string msg = String.Format("\nStack Trace: {0}\nMessage: {1}\nSource: {2}", ex.StackTrace, ex.Message, ex.Source);
                LogErrorToTextFile(msg);

                ShowMessage("An error occured on creating a new [PRS92] database");
                ShowMessage("END");
            }

            // Copy data
            sql = String.Format(GetStringResource("SQL.CopyData.sql"),restoreName);
            string result = ExecuteQuery(sql);
            if ( result == string.Empty)
            {
                ShowMessage("Data from old [PRS92] succesfully copied to the new [PRS92] database.");
            }
            else
            {
                ShowMessage("An error occured on copying old [PRS92] data to new [PRS92] database");
                ShowMessage("END");
                return;
            };

            // Drop old [PRS92] database
            sql = string.Format("USE [master];DROP DATABASE [{0}]",restoreName);
            if (ExecuteQuery(sql) == string.Empty)
            {
            }
            else
            {
                ShowMessage(string.Format("An error occured on dropping [{0}] database",restoreName));
                ShowMessage("END");
                return;
            };

            ShowMessage("Successfully updated [PRS92] database");
            ShowMessage("END");



        }



        private string GetSQLServerPath()
        {
            SqlConnection con = new SqlConnection(string.Format(CONN_STRING, _instanceName));
            Server server = new Server(new ServerConnection(con));

            try
            {
                return server.Information.RootDirectory;
            } catch (Exception ex)
            {
                return null;
            }
        }
        private string ExecuteQuery(string sql)
        {
            SqlConnection con = new SqlConnection(string.Format(CONN_STRING, _instanceName));
            Server server = new Server(new ServerConnection(con));

            try
            {
                server.ConnectionContext.ExecuteNonQuery(sql);
                
            }
            catch (Exception ex)
            {
                // Return the error message
                string msg = String.Format("\nStack Trace: {0}\nMessage: {1}\nSource: {2}",ex.StackTrace,ex.Message,ex.Source);
                LogErrorToTextFile(msg);
                return ex.Message;
            }
            return string.Empty;
        }

        private bool IsPRS92DBExisting()
        {
            bool isDbExisting;
            SqlConnection con = new SqlConnection(string.Format(CONN_STRING, _instanceName));
            SqlCommand cmd = new SqlCommand(@"SELECT name FROM sys.databases WHERE name = N'prs92'", con);
            con.Open();
            isDbExisting = (cmd.ExecuteScalar() != null);
            con.Close();
            return isDbExisting;
        }
        private void ShowMessage(string msg)
        {
            lstStatus.Items.Add(@"[" + DateTime.Now.ToString("hh:MM:ss") + "] " + msg + "  " + Convert.ToChar(9));
            lstStatus.Refresh();
            this.Refresh();
            Application.DoEvents();
        }
        private string GetInstanceName()
        {
            SqlConnection con = new SqlConnection(CONN_STRING);
            string instanceName = null;

            // Try (local)
            instanceName = @"(local)";
            try
            {
                con.ConnectionString = string.Format(CONN_STRING, instanceName);
                con.Open();
                return instanceName;

            }catch (Exception ex){
                string msg = String.Format("\nStack Trace: {0}\nMessage: {1}\nSource: {2}", ex.StackTrace, ex.Message, ex.Source);
                LogErrorToTextFile(msg);

            }finally {
                con.Close();
            }

            // Try (local)\SQLEXPRESS
            instanceName = @"(local)\SQLEXPRESS";
            try
            {
                con.ConnectionString = string.Format(CONN_STRING, instanceName);
                con.Open();
                return instanceName;
            }catch (SqlException ex){
                string msg = String.Format("\nStack Trace: {0}\nMessage: {1}\nSource: {2}", ex.StackTrace, ex.Message, ex.Source);
                LogErrorToTextFile(msg);
            }
            finally
            {
                con.Close();
            }

            // If code reached this point, then PRS92 database cannot
            // be found in this computer.
            return string.Empty;

       }

        private string GetStringResource(string fileName)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                string fooResourceName = string.Format("{0}.{1}", assembly.GetName().Name, fileName);

                using (Stream fooStream = assembly.GetManifestResourceStream(fooResourceName))
                {
                    using (StreamReader sr = new StreamReader(fooStream))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch {}

            return string.Empty;
        }
        public static void WriteResourceToFile(string resourceFilename, string fileName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string fooResourceName = string.Format("{0}.{1}", assembly.GetName().Name, resourceFilename);
            using (Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream(fooResourceName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Create);
                byte[] buffer = new byte[0x10000];
                int bytes;
                try
                {
                    while ((bytes = s.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fs.Write(buffer, 0, bytes);
                    }
                }
                finally
                {
                    fs.Flush();
                    fs.Close();
                }
            }
        }

        private void LogErrorToTextFile(string message){
            string logFile = Application.StartupPath + "\\update_error.log";
            message = DateTime.Now.Day.ToString("00") +
                             DateTime.Now.Year.ToString("0000") +
                             DateTime.Now.Hour.ToString("[00") +
                             DateTime.Now.Minute.ToString("00]") + message + Convert.ToChar(13).ToString() + Convert.ToChar(13).ToString();
            File.AppendAllText(logFile, message);
        }






        //SqlCommand cmd = new SqlCommand(string.Empty, con);
        //    cmd.CommandText = @"SELECT name FROM sys.databases WHERE name = N'prs92')";
        //    MessageBox.Show(cmd.ExecuteScalar().ToString());

    }
}