<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.pnlStep0 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.labelMoreOptions = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
        Me.txtServer = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblServer = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnLogin = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblPassword = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblUsername = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtUsername = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lblLogin = New System.Windows.Forms.Label
        Me.pnlStep2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.pnlStep2Message = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.lblStep2Message = New System.Windows.Forms.Label
        Me.btnCancelImport = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnImport = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pnlStep2Progress = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.lblImportingFiles = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.pnlStep1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.lblStep1Message = New System.Windows.Forms.Label
        Me.btnExit = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnSelectFiles = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.pnlStep3 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnFinish = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtErrorMessages = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.lvwExcelFiles = New System.Windows.Forms.ListView
        Me.Filename = New System.Windows.Forms.ColumnHeader
        Me.NoOfLots = New System.Windows.Forms.ColumnHeader("apply.gif")
        Me.LotsWithError = New System.Windows.Forms.ColumnHeader
        Me.LotsWithoutError = New System.Windows.Forms.ColumnHeader
        Me.PlottedLots = New System.Windows.Forms.ColumnHeader
        Me.lblErrorDetails = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.cboRegion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.pnlStep0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep0.SuspendLayout()
        CType(Me.pnlStep2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep2.SuspendLayout()
        CType(Me.pnlStep2Message, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep2Message.SuspendLayout()
        CType(Me.pnlStep2Progress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep2Progress.SuspendLayout()
        CType(Me.pnlStep1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep1.SuspendLayout()
        CType(Me.pnlStep3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStep3.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.pnlStep0)
        Me.KryptonPanel.Controls.Add(Me.pnlStep2)
        Me.KryptonPanel.Controls.Add(Me.pnlStep1)
        Me.KryptonPanel.Controls.Add(Me.pnlStep3)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(540, 320)
        Me.KryptonPanel.TabIndex = 0
        '
        'pnlStep0
        '
        Me.pnlStep0.Controls.Add(Me.KryptonLabel1)
        Me.pnlStep0.Controls.Add(Me.cboRegion)
        Me.pnlStep0.Controls.Add(Me.labelMoreOptions)
        Me.pnlStep0.Controls.Add(Me.txtServer)
        Me.pnlStep0.Controls.Add(Me.lblServer)
        Me.pnlStep0.Controls.Add(Me.btnLogin)
        Me.pnlStep0.Controls.Add(Me.lblPassword)
        Me.pnlStep0.Controls.Add(Me.lblUsername)
        Me.pnlStep0.Controls.Add(Me.txtPassword)
        Me.pnlStep0.Controls.Add(Me.txtUsername)
        Me.pnlStep0.Controls.Add(Me.lblLogin)
        Me.pnlStep0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStep0.Location = New System.Drawing.Point(0, 0)
        Me.pnlStep0.Name = "pnlStep0"
        Me.pnlStep0.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep0.TabIndex = 1
        '
        'labelMoreOptions
        '
        Me.labelMoreOptions.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline
        Me.labelMoreOptions.Location = New System.Drawing.Point(212, 227)
        Me.labelMoreOptions.Name = "labelMoreOptions"
        Me.labelMoreOptions.Size = New System.Drawing.Size(65, 14)
        Me.labelMoreOptions.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMoreOptions.TabIndex = 18
        Me.labelMoreOptions.Text = "Show options"
        Me.labelMoreOptions.Values.ExtraText = ""
        Me.labelMoreOptions.Values.Image = Nothing
        Me.labelMoreOptions.Values.Text = "Show options"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(212, 247)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(145, 20)
        Me.txtServer.TabIndex = 17
        Me.txtServer.Visible = False
        '
        'lblServer
        '
        Me.lblServer.Location = New System.Drawing.Point(143, 249)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(47, 20)
        Me.lblServer.TabIndex = 16
        Me.lblServer.Text = "Server:"
        Me.lblServer.Values.ExtraText = ""
        Me.lblServer.Values.Image = Nothing
        Me.lblServer.Values.Text = "Server:"
        Me.lblServer.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(283, 189)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 25)
        Me.btnLogin.TabIndex = 15
        Me.btnLogin.Text = "Login"
        Me.btnLogin.Values.ExtraText = ""
        Me.btnLogin.Values.Image = Nothing
        Me.btnLogin.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnLogin.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnLogin.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnLogin.Values.Text = "Login"
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(143, 128)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(65, 20)
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.Values.ExtraText = ""
        Me.lblPassword.Values.Image = Nothing
        Me.lblPassword.Values.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(143, 105)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(68, 20)
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.Values.ExtraText = ""
        Me.lblUsername.Values.Image = Nothing
        Me.lblUsername.Values.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(212, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(145, 20)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.Text = "xxxxx"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(212, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(145, 20)
        Me.txtUsername.TabIndex = 11
        Me.txtUsername.Text = "thelma"
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLogin.Location = New System.Drawing.Point(209, 60)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(128, 34)
        Me.lblLogin.TabIndex = 10
        Me.lblLogin.Text = "Login Required"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlStep2
        '
        Me.pnlStep2.Controls.Add(Me.pnlStep2Message)
        Me.pnlStep2.Controls.Add(Me.btnCancelImport)
        Me.pnlStep2.Controls.Add(Me.btnImport)
        Me.pnlStep2.Controls.Add(Me.pnlStep2Progress)
        Me.pnlStep2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStep2.Location = New System.Drawing.Point(0, 0)
        Me.pnlStep2.Name = "pnlStep2"
        Me.pnlStep2.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep2.TabIndex = 0
        '
        'pnlStep2Message
        '
        Me.pnlStep2Message.Controls.Add(Me.lblStep2Message)
        Me.pnlStep2Message.Location = New System.Drawing.Point(102, 108)
        Me.pnlStep2Message.Name = "pnlStep2Message"
        Me.pnlStep2Message.Size = New System.Drawing.Size(351, 60)
        Me.pnlStep2Message.TabIndex = 10
        Me.pnlStep2Message.Visible = False
        '
        'lblStep2Message
        '
        Me.lblStep2Message.BackColor = System.Drawing.Color.Transparent
        Me.lblStep2Message.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2Message.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStep2Message.Location = New System.Drawing.Point(4, 3)
        Me.lblStep2Message.Name = "lblStep2Message"
        Me.lblStep2Message.Size = New System.Drawing.Size(344, 60)
        Me.lblStep2Message.TabIndex = 9
        Me.lblStep2Message.Text = "You are about to import 20 Excel files. If you want to continue importing these f" & _
            "iles, click the ""Import"" button below. Otherwise, click ""Cancel""."
        '
        'btnCancelImport
        '
        Me.btnCancelImport.Location = New System.Drawing.Point(342, 283)
        Me.btnCancelImport.Name = "btnCancelImport"
        Me.btnCancelImport.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelImport.TabIndex = 8
        Me.btnCancelImport.Text = "&Cancel"
        Me.btnCancelImport.Values.ExtraText = ""
        Me.btnCancelImport.Values.Image = Nothing
        Me.btnCancelImport.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancelImport.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancelImport.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancelImport.Values.Text = "&Cancel"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(438, 283)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(90, 25)
        Me.btnImport.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.TabIndex = 7
        Me.btnImport.Text = "&Import"
        Me.btnImport.Values.ExtraText = ""
        Me.btnImport.Values.Image = Nothing
        Me.btnImport.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnImport.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnImport.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnImport.Values.Text = "&Import"
        '
        'pnlStep2Progress
        '
        Me.pnlStep2Progress.Controls.Add(Me.lblImportingFiles)
        Me.pnlStep2Progress.Controls.Add(Me.ProgressBar)
        Me.pnlStep2Progress.Location = New System.Drawing.Point(102, 110)
        Me.pnlStep2Progress.Name = "pnlStep2Progress"
        Me.pnlStep2Progress.Size = New System.Drawing.Size(351, 60)
        Me.pnlStep2Progress.TabIndex = 6
        Me.pnlStep2Progress.Visible = False
        '
        'lblImportingFiles
        '
        Me.lblImportingFiles.AutoSize = False
        Me.lblImportingFiles.Location = New System.Drawing.Point(-1, 10)
        Me.lblImportingFiles.Name = "lblImportingFiles"
        Me.lblImportingFiles.Size = New System.Drawing.Size(348, 19)
        Me.lblImportingFiles.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.EllipsisWord
        Me.lblImportingFiles.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImportingFiles.TabIndex = 4
        Me.lblImportingFiles.Text = "Importing files..."
        Me.lblImportingFiles.Values.ExtraText = ""
        Me.lblImportingFiles.Values.Image = Nothing
        Me.lblImportingFiles.Values.Text = "Importing files..."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(3, 35)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(344, 22)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 3
        '
        'pnlStep1
        '
        Me.pnlStep1.Controls.Add(Me.lblStep1Message)
        Me.pnlStep1.Controls.Add(Me.btnExit)
        Me.pnlStep1.Controls.Add(Me.btnSelectFiles)
        Me.pnlStep1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStep1.Location = New System.Drawing.Point(0, 0)
        Me.pnlStep1.Name = "pnlStep1"
        Me.pnlStep1.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep1.TabIndex = 0
        '
        'lblStep1Message
        '
        Me.lblStep1Message.BackColor = System.Drawing.Color.Transparent
        Me.lblStep1Message.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1Message.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStep1Message.Location = New System.Drawing.Point(99, 108)
        Me.lblStep1Message.Name = "lblStep1Message"
        Me.lblStep1Message.Size = New System.Drawing.Size(344, 60)
        Me.lblStep1Message.TabIndex = 10
        Me.lblStep1Message.Text = "Welcome to LSDMS Import Tool. To start using this tool, select the Excel files yo" & _
            "u want to import by using the ""Select files"" button below."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(342, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 25)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.Values.ExtraText = ""
        Me.btnExit.Values.Image = Nothing
        Me.btnExit.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnExit.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnExit.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnExit.Values.Text = "E&xit"
        '
        'btnSelectFiles
        '
        Me.btnSelectFiles.Location = New System.Drawing.Point(438, 283)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(90, 25)
        Me.btnSelectFiles.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFiles.TabIndex = 1
        Me.btnSelectFiles.Text = "&Select files"
        Me.btnSelectFiles.Values.ExtraText = ""
        Me.btnSelectFiles.Values.Image = Nothing
        Me.btnSelectFiles.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnSelectFiles.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnSelectFiles.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnSelectFiles.Values.Text = "&Select files"
        '
        'pnlStep3
        '
        Me.pnlStep3.Controls.Add(Me.btnFinish)
        Me.pnlStep3.Controls.Add(Me.txtErrorMessages)
        Me.pnlStep3.Controls.Add(Me.lvwExcelFiles)
        Me.pnlStep3.Controls.Add(Me.lblErrorDetails)
        Me.pnlStep3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStep3.Location = New System.Drawing.Point(0, 0)
        Me.pnlStep3.Name = "pnlStep3"
        Me.pnlStep3.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep3.TabIndex = 1
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(438, 283)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(90, 25)
        Me.btnFinish.TabIndex = 5
        Me.btnFinish.Text = "&Finish"
        Me.btnFinish.Values.ExtraText = ""
        Me.btnFinish.Values.Image = Nothing
        Me.btnFinish.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnFinish.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnFinish.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnFinish.Values.Text = "&Finish"
        '
        'txtErrorMessages
        '
        Me.txtErrorMessages.Location = New System.Drawing.Point(8, 176)
        Me.txtErrorMessages.Multiline = True
        Me.txtErrorMessages.Name = "txtErrorMessages"
        Me.txtErrorMessages.ReadOnly = True
        Me.txtErrorMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrorMessages.Size = New System.Drawing.Size(520, 96)
        Me.txtErrorMessages.TabIndex = 3
        Me.txtErrorMessages.WordWrap = False
        '
        'lvwExcelFiles
        '
        Me.lvwExcelFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Filename, Me.NoOfLots, Me.LotsWithError, Me.LotsWithoutError, Me.PlottedLots})
        Me.lvwExcelFiles.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwExcelFiles.FullRowSelect = True
        Me.lvwExcelFiles.GridLines = True
        Me.lvwExcelFiles.Location = New System.Drawing.Point(8, 12)
        Me.lvwExcelFiles.MultiSelect = False
        Me.lvwExcelFiles.Name = "lvwExcelFiles"
        Me.lvwExcelFiles.Size = New System.Drawing.Size(520, 127)
        Me.lvwExcelFiles.TabIndex = 0
        Me.lvwExcelFiles.UseCompatibleStateImageBehavior = False
        Me.lvwExcelFiles.View = System.Windows.Forms.View.Details
        '
        'Filename
        '
        Me.Filename.Text = "Filename"
        Me.Filename.Width = 242
        '
        'NoOfLots
        '
        Me.NoOfLots.Text = "No. of Lots"
        Me.NoOfLots.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NoOfLots.Width = 73
        '
        'LotsWithError
        '
        Me.LotsWithError.Text = "for *Review"
        Me.LotsWithError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LotsWithError.Width = 75
        '
        'LotsWithoutError
        '
        Me.LotsWithoutError.Text = "Valid"
        Me.LotsWithoutError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.LotsWithoutError.Width = 44
        '
        'PlottedLots
        '
        Me.PlottedLots.Text = "Imported"
        Me.PlottedLots.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PlottedLots.Width = 63
        '
        'lblErrorDetails
        '
        Me.lblErrorDetails.Location = New System.Drawing.Point(4, 160)
        Me.lblErrorDetails.Name = "lblErrorDetails"
        Me.lblErrorDetails.Size = New System.Drawing.Size(78, 20)
        Me.lblErrorDetails.TabIndex = 4
        Me.lblErrorDetails.Text = "Error details:"
        Me.lblErrorDetails.Values.ExtraText = ""
        Me.lblErrorDetails.Values.Image = Nothing
        Me.lblErrorDetails.Values.Text = "Error details:"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "MS Excel Files|*.xls;*.xlsx;*.xlt"
        Me.OpenFileDialog.Multiselect = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(154, 153)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(52, 20)
        Me.KryptonLabel1.TabIndex = 20
        Me.KryptonLabel1.Text = "Region:"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Region:"
        '
        'cboRegion
        '
        Me.cboRegion.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegion.DropDownWidth = 100
        Me.cboRegion.FormattingEnabled = False
        Me.cboRegion.Items.AddRange(New Object() {"", "reg_01", "reg_02", "reg_03", "reg_4a", "reg_4b", "reg_05", "reg_06", "reg_07", "reg_08", "reg_09", "reg_10", "reg_11", "reg_12", "reg_13", "reg_car", "reg_ncr"})
        Me.cboRegion.Location = New System.Drawing.Point(212, 153)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(91, 21)
        Me.cboRegion.TabIndex = 19
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 320)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Tool (Build 06.28.2010.THELMA)"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.pnlStep0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep0.ResumeLayout(False)
        Me.pnlStep0.PerformLayout()
        CType(Me.pnlStep2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep2.ResumeLayout(False)
        CType(Me.pnlStep2Message, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep2Message.ResumeLayout(False)
        CType(Me.pnlStep2Progress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep2Progress.ResumeLayout(False)
        CType(Me.pnlStep1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep1.ResumeLayout(False)
        CType(Me.pnlStep3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStep3.ResumeLayout(False)
        Me.pnlStep3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents pnlStep2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents pnlStep1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents pnlStep3 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents btnSelectFiles As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lvwExcelFiles As System.Windows.Forms.ListView
    Friend WithEvents Filename As System.Windows.Forms.ColumnHeader
    Friend WithEvents NoOfLots As System.Windows.Forms.ColumnHeader
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnExit As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtErrorMessages As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents LotsWithError As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblErrorDetails As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents pnlStep2Progress As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblImportingFiles As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents btnCancelImport As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnImport As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnFinish As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents lblStep2Message As System.Windows.Forms.Label
    Friend WithEvents lblStep1Message As System.Windows.Forms.Label
    Friend WithEvents pnlStep2Message As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents LotsWithoutError As System.Windows.Forms.ColumnHeader
    Friend WithEvents PlottedLots As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlStep0 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents txtUsername As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblUsername As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblPassword As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnLogin As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtServer As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblServer As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents labelMoreOptions As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboRegion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
End Class
