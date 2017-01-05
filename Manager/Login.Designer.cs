namespace Manager
{
    partial class Login
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
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.labelMoreOptions = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.panelAdditonalOptions = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonBorderEdge1 = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.labelAdditionalOptions = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.textBoxImageServer = new System.Windows.Forms.TextBox();
            this.textBoxDatabaseServer = new System.Windows.Forms.TextBox();
            this.labelImageServer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelDatabaseServer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.labelUsername = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditonalOptions)).BeginInit();
            this.panelAdditonalOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.labelMoreOptions);
            this.kryptonPanel.Controls.Add(this.panelAdditonalOptions);
            this.kryptonPanel.Controls.Add(this.btnLogin);
            this.kryptonPanel.Controls.Add(this.textBoxPassword);
            this.kryptonPanel.Controls.Add(this.textBoxUsername);
            this.kryptonPanel.Controls.Add(this.labelPassword);
            this.kryptonPanel.Controls.Add(this.labelUsername);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(231, 128);
            this.kryptonPanel.TabIndex = 0;
            // 
            // labelMoreOptions
            // 
            this.labelMoreOptions.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline;
            this.labelMoreOptions.Location = new System.Drawing.Point(12, 112);
            this.labelMoreOptions.Name = "labelMoreOptions";
            this.labelMoreOptions.Size = new System.Drawing.Size(65, 14);
            this.labelMoreOptions.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoreOptions.TabIndex = 11;
            this.labelMoreOptions.Text = "Show options";
            this.labelMoreOptions.Values.ExtraText = "";
            this.labelMoreOptions.Values.Image = null;
            this.labelMoreOptions.Values.Text = "Show options";
            this.labelMoreOptions.LinkClicked += new System.EventHandler(this.labelMoreOptions_LinkClicked);
            // 
            // panelAdditonalOptions
            // 
            this.panelAdditonalOptions.Controls.Add(this.kryptonBorderEdge1);
            this.panelAdditonalOptions.Controls.Add(this.labelAdditionalOptions);
            this.panelAdditonalOptions.Controls.Add(this.textBoxImageServer);
            this.panelAdditonalOptions.Controls.Add(this.textBoxDatabaseServer);
            this.panelAdditonalOptions.Controls.Add(this.labelImageServer);
            this.panelAdditonalOptions.Controls.Add(this.labelDatabaseServer);
            this.panelAdditonalOptions.Location = new System.Drawing.Point(12, 132);
            this.panelAdditonalOptions.Name = "panelAdditonalOptions";
            this.panelAdditonalOptions.Size = new System.Drawing.Size(213, 70);
            this.panelAdditonalOptions.TabIndex = 10;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(0, 0);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(213, 1);
            this.kryptonBorderEdge1.TabIndex = 10;
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // labelAdditionalOptions
            // 
            this.labelAdditionalOptions.Location = new System.Drawing.Point(-4, 17);
            this.labelAdditionalOptions.Name = "labelAdditionalOptions";
            this.labelAdditionalOptions.Size = new System.Drawing.Size(116, 20);
            this.labelAdditionalOptions.TabIndex = 5;
            this.labelAdditionalOptions.Text = "Additional Options:";
            this.labelAdditionalOptions.Values.ExtraText = "";
            this.labelAdditionalOptions.Values.Image = null;
            this.labelAdditionalOptions.Values.Text = "Additional Options:";
            // 
            // textBoxImageServer
            // 
            this.textBoxImageServer.Enabled = false;
            this.textBoxImageServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImageServer.Location = new System.Drawing.Point(102, 86);
            this.textBoxImageServer.Name = "textBoxImageServer";
            this.textBoxImageServer.Size = new System.Drawing.Size(111, 22);
            this.textBoxImageServer.TabIndex = 9;
            // 
            // textBoxDatabaseServer
            // 
            this.textBoxDatabaseServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDatabaseServer.Location = new System.Drawing.Point(102, 42);
            this.textBoxDatabaseServer.Name = "textBoxDatabaseServer";
            this.textBoxDatabaseServer.Size = new System.Drawing.Size(111, 22);
            this.textBoxDatabaseServer.TabIndex = 8;
            // 
            // labelImageServer
            // 
            this.labelImageServer.Location = new System.Drawing.Point(3, 86);
            this.labelImageServer.Name = "labelImageServer";
            this.labelImageServer.Size = new System.Drawing.Size(85, 20);
            this.labelImageServer.TabIndex = 7;
            this.labelImageServer.Text = "Image Server:";
            this.labelImageServer.Values.ExtraText = "";
            this.labelImageServer.Values.Image = null;
            this.labelImageServer.Values.Text = "Image Server:";
            // 
            // labelDatabaseServer
            // 
            this.labelDatabaseServer.Location = new System.Drawing.Point(3, 42);
            this.labelDatabaseServer.Name = "labelDatabaseServer";
            this.labelDatabaseServer.Size = new System.Drawing.Size(101, 20);
            this.labelDatabaseServer.TabIndex = 6;
            this.labelDatabaseServer.Text = "Database Server:";
            this.labelDatabaseServer.Values.ExtraText = "";
            this.labelDatabaseServer.Values.Image = null;
            this.labelDatabaseServer.Values.Text = "Database Server:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(155, 83);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 25);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.Values.ExtraText = "";
            this.btnLogin.Values.Image = null;
            this.btnLogin.Values.ImageStates.ImageCheckedNormal = null;
            this.btnLogin.Values.ImageStates.ImageCheckedPressed = null;
            this.btnLogin.Values.ImageStates.ImageCheckedTracking = null;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(86, 55);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '=';
            this.textBoxPassword.Size = new System.Drawing.Size(139, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(86, 29);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(139, 22);
            this.textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(12, 55);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Values.ExtraText = "";
            this.labelPassword.Values.Image = null;
            this.labelPassword.Values.Text = "Password:";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(12, 29);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Values.ExtraText = "";
            this.labelUsername.Values.Image = null;
            this.labelUsername.Values.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 128);
            this.Controls.Add(this.kryptonPanel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login  (Build 07.13.2010)";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAdditonalOptions)).EndInit();
            this.panelAdditonalOptions.ResumeLayout(false);
            this.panelAdditonalOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelAdditionalOptions;
        private System.Windows.Forms.TextBox textBoxImageServer;
        private System.Windows.Forms.TextBox textBoxDatabaseServer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelImageServer;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel labelDatabaseServer;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelAdditonalOptions;
        private ComponentFactory.Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel labelMoreOptions;
    }
}

