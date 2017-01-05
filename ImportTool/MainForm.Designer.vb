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
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.KryptonPanel.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.KryptonPanel.Size = New System.Drawing.Size(540, 320)
        Me.KryptonPanel.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.KryptonPanel.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.KryptonPanel.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.KryptonPanel.TabIndex = 0
        '
        'pnlStep0
        '
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
        Me.pnlStep0.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep0.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep0.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep0.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep0.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep0.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep0.TabIndex = 1
        '
        'labelMoreOptions
        '
        Me.labelMoreOptions.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.labelMoreOptions.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.NeverUnderline
        Me.labelMoreOptions.Location = New System.Drawing.Point(212, 203)
        Me.labelMoreOptions.Name = "labelMoreOptions"
        Me.labelMoreOptions.OverrideFocus.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.OverrideFocus.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideFocus.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverrideFocus.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideFocus.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverrideNotVisited.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.OverrideNotVisited.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideNotVisited.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverrideNotVisited.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideNotVisited.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverridePressed.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.OverridePressed.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverridePressed.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverridePressed.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverridePressed.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverrideVisited.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.OverrideVisited.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideVisited.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.OverrideVisited.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.OverrideVisited.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.labelMoreOptions.Size = New System.Drawing.Size(65, 14)
        Me.labelMoreOptions.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.labelMoreOptions.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.StateNormal.ShortText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMoreOptions.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.labelMoreOptions.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.labelMoreOptions.TabIndex = 18
        Me.labelMoreOptions.Text = "Show options"
        Me.labelMoreOptions.Values.ExtraText = ""
        Me.labelMoreOptions.Values.Image = Nothing
        Me.labelMoreOptions.Values.Text = "Show options"
        '
        'txtServer
        '
        Me.txtServer.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtServer.Location = New System.Drawing.Point(212, 223)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtServer.Size = New System.Drawing.Size(145, 22)
        Me.txtServer.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtServer.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtServer.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtServer.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtServer.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtServer.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtServer.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtServer.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtServer.TabIndex = 17
        Me.txtServer.Visible = False
        '
        'lblServer
        '
        Me.lblServer.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblServer.Location = New System.Drawing.Point(143, 225)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblServer.Size = New System.Drawing.Size(44, 19)
        Me.lblServer.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblServer.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblServer.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblServer.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblServer.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblServer.TabIndex = 16
        Me.lblServer.Text = "Server:"
        Me.lblServer.Values.ExtraText = ""
        Me.lblServer.Values.Image = Nothing
        Me.lblServer.Values.Text = "Server:"
        Me.lblServer.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnLogin.Location = New System.Drawing.Point(283, 165)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnLogin.Size = New System.Drawing.Size(74, 25)
        Me.btnLogin.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnLogin.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnLogin.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnLogin.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnLogin.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.lblPassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblPassword.Location = New System.Drawing.Point(143, 128)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblPassword.Size = New System.Drawing.Size(60, 19)
        Me.lblPassword.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblPassword.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblPassword.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblPassword.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblPassword.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.Values.ExtraText = ""
        Me.lblPassword.Values.Image = Nothing
        Me.lblPassword.Values.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblUsername.Location = New System.Drawing.Point(143, 105)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblUsername.Size = New System.Drawing.Size(63, 19)
        Me.lblUsername.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblUsername.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblUsername.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblUsername.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblUsername.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblUsername.TabIndex = 13
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.Values.ExtraText = ""
        Me.lblUsername.Values.Image = Nothing
        Me.lblUsername.Values.Text = "Username:"
        '
        'txtPassword
        '
        Me.txtPassword.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtPassword.Location = New System.Drawing.Point(212, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(145, 22)
        Me.txtPassword.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtPassword.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtPassword.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtPassword.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtPassword.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtPassword.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtPassword.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtPassword.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtUsername.Location = New System.Drawing.Point(212, 103)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtUsername.Size = New System.Drawing.Size(145, 22)
        Me.txtUsername.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtUsername.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtUsername.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtUsername.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtUsername.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtUsername.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtUsername.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtUsername.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtUsername.TabIndex = 11
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
        Me.pnlStep2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep2.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep2.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2.TabIndex = 0
        '
        'pnlStep2Message
        '
        Me.pnlStep2Message.Controls.Add(Me.lblStep2Message)
        Me.pnlStep2Message.Location = New System.Drawing.Point(102, 108)
        Me.pnlStep2Message.Name = "pnlStep2Message"
        Me.pnlStep2Message.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep2Message.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep2Message.Size = New System.Drawing.Size(351, 60)
        Me.pnlStep2Message.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2Message.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2Message.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
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
        Me.btnCancelImport.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnCancelImport.Location = New System.Drawing.Point(342, 283)
        Me.btnCancelImport.Name = "btnCancelImport"
        Me.btnCancelImport.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnCancelImport.Size = New System.Drawing.Size(90, 25)
        Me.btnCancelImport.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnCancelImport.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnCancelImport.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnCancelImport.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnCancelImport.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.btnImport.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnImport.Location = New System.Drawing.Point(438, 283)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnImport.Size = New System.Drawing.Size(90, 25)
        Me.btnImport.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnImport.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnImport.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnImport.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnImport.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.pnlStep2Progress.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep2Progress.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep2Progress.Size = New System.Drawing.Size(351, 60)
        Me.pnlStep2Progress.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2Progress.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2Progress.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep2Progress.TabIndex = 6
        Me.pnlStep2Progress.Visible = False
        '
        'lblImportingFiles
        '
        Me.lblImportingFiles.AutoSize = False
        Me.lblImportingFiles.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblImportingFiles.Location = New System.Drawing.Point(-1, 10)
        Me.lblImportingFiles.Name = "lblImportingFiles"
        Me.lblImportingFiles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblImportingFiles.Size = New System.Drawing.Size(348, 19)
        Me.lblImportingFiles.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblImportingFiles.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.EllipsisWord
        Me.lblImportingFiles.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblImportingFiles.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblImportingFiles.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblImportingFiles.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblImportingFiles.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblImportingFiles.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblImportingFiles.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImportingFiles.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblImportingFiles.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.pnlStep1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep1.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep1.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep1.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep1.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
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
        Me.btnExit.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnExit.Location = New System.Drawing.Point(342, 283)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnExit.Size = New System.Drawing.Size(90, 25)
        Me.btnExit.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnExit.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnExit.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnExit.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnExit.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.btnSelectFiles.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnSelectFiles.Location = New System.Drawing.Point(438, 283)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnSelectFiles.Size = New System.Drawing.Size(90, 25)
        Me.btnSelectFiles.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFiles.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnSelectFiles.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnSelectFiles.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnSelectFiles.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnSelectFiles.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.pnlStep3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.pnlStep3.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient
        Me.pnlStep3.Size = New System.Drawing.Size(540, 320)
        Me.pnlStep3.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep3.StateDisabled.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep3.StateNormal.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.pnlStep3.TabIndex = 1
        '
        'btnFinish
        '
        Me.btnFinish.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.btnFinish.Location = New System.Drawing.Point(438, 283)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.OverrideDefault.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideDefault.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.OverrideDefault.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.OverrideDefault.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideDefault.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.OverrideDefault.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideDefault.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.OverrideFocus.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideFocus.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.OverrideFocus.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideFocus.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.OverrideFocus.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideFocus.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.OverrideFocus.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.OverrideFocus.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.btnFinish.Size = New System.Drawing.Size(90, 25)
        Me.btnFinish.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.StateCommon.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateCommon.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateCommon.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateDisabled.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateDisabled.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.StateDisabled.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateDisabled.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateDisabled.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateDisabled.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateNormal.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateNormal.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.StateNormal.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateNormal.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateNormal.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateNormal.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StatePressed.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.StatePressed.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StatePressed.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.StatePressed.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StatePressed.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StatePressed.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StatePressed.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateTracking.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateTracking.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.btnFinish.StateTracking.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.btnFinish.StateTracking.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateTracking.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.btnFinish.StateTracking.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.btnFinish.StateTracking.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
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
        Me.txtErrorMessages.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone
        Me.txtErrorMessages.Location = New System.Drawing.Point(8, 176)
        Me.txtErrorMessages.Multiline = True
        Me.txtErrorMessages.Name = "txtErrorMessages"
        Me.txtErrorMessages.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.txtErrorMessages.ReadOnly = True
        Me.txtErrorMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtErrorMessages.Size = New System.Drawing.Size(520, 96)
        Me.txtErrorMessages.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtErrorMessages.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtErrorMessages.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtErrorMessages.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtErrorMessages.StateDisabled.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtErrorMessages.StateDisabled.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.txtErrorMessages.StateNormal.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.txtErrorMessages.StateNormal.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
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
        Me.lblErrorDetails.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl
        Me.lblErrorDetails.Location = New System.Drawing.Point(4, 160)
        Me.lblErrorDetails.Name = "lblErrorDetails"
        Me.lblErrorDetails.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.[Global]
        Me.lblErrorDetails.Size = New System.Drawing.Size(72, 19)
        Me.lblErrorDetails.StateCommon.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblErrorDetails.StateCommon.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateCommon.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.StateCommon.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateCommon.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.StateDisabled.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblErrorDetails.StateDisabled.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateDisabled.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.StateDisabled.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateDisabled.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.StateNormal.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.lblErrorDetails.StateNormal.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateNormal.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.StateNormal.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.lblErrorDetails.StateNormal.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.lblErrorDetails.TabIndex = 4
        Me.lblErrorDetails.Text = "Error details:"
        Me.lblErrorDetails.Values.ExtraText = ""
        Me.lblErrorDetails.Values.Image = Nothing
        Me.lblErrorDetails.Values.Text = "Error details:"
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "MS Excel Files|*.xls;*.xlsx;*.xlt"
        Me.OpenFileDialog.Multiselect = True
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
        Me.StateActive.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateActive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Header.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Header.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateActive.Header.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Header.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.StateActive.Header.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Header.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.StateActive.Header.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateActive.Header.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Header.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Header.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateCommon.Header.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Header.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.StateCommon.Header.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Header.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.StateCommon.Header.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateCommon.Header.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.StateInactive.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateInactive.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Header.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Header.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Inherit
        Me.StateInactive.Header.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Header.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Inherit
        Me.StateInactive.Header.Content.LongText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Header.Content.LongText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.StateInactive.Header.Content.ShortText.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit
        Me.StateInactive.Header.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.Inherit
        Me.Text = "Import Tool (Build 11.19.2008)"
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
End Class
