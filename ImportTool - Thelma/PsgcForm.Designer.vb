<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PsgcForm
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel
        Me.btnAbort = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.lblMessage = New System.Windows.Forms.Label
        Me.lblBarangay = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblMunicipality = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.lblProvince = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnCancel = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnOk = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.cboBarangay = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboMunicipality = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboProvince = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.cboRegion = New ComponentFactory.Krypton.Toolkit.KryptonComboBox
        Me.lblRegion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.KryptonPanel1)
        Me.KryptonPanel.Controls.Add(Me.lblRegion)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(361, 319)
        Me.KryptonPanel.TabIndex = 0
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.btnAbort)
        Me.KryptonPanel1.Controls.Add(Me.lblMessage)
        Me.KryptonPanel1.Controls.Add(Me.lblBarangay)
        Me.KryptonPanel1.Controls.Add(Me.lblMunicipality)
        Me.KryptonPanel1.Controls.Add(Me.lblProvince)
        Me.KryptonPanel1.Controls.Add(Me.KryptonLabel1)
        Me.KryptonPanel1.Controls.Add(Me.btnCancel)
        Me.KryptonPanel1.Controls.Add(Me.btnOk)
        Me.KryptonPanel1.Controls.Add(Me.cboBarangay)
        Me.KryptonPanel1.Controls.Add(Me.cboMunicipality)
        Me.KryptonPanel1.Controls.Add(Me.cboProvince)
        Me.KryptonPanel1.Controls.Add(Me.cboRegion)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(361, 319)
        Me.KryptonPanel1.TabIndex = 10
        '
        'btnAbort
        '
        Me.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.btnAbort.Location = New System.Drawing.Point(12, 282)
        Me.btnAbort.Name = "btnAbort"
        Me.btnAbort.Size = New System.Drawing.Size(67, 25)
        Me.btnAbort.TabIndex = 11
        Me.btnAbort.Text = "&Abort"
        Me.btnAbort.Values.ExtraText = ""
        Me.btnAbort.Values.Image = Nothing
        Me.btnAbort.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnAbort.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnAbort.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnAbort.Values.Text = "&Abort"
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(19, 24)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(330, 77)
        Me.lblMessage.TabIndex = 10
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBarangay
        '
        Me.lblBarangay.Location = New System.Drawing.Point(56, 197)
        Me.lblBarangay.Name = "lblBarangay"
        Me.lblBarangay.Size = New System.Drawing.Size(56, 19)
        Me.lblBarangay.TabIndex = 9
        Me.lblBarangay.Text = "Barangay"
        Me.lblBarangay.Values.ExtraText = ""
        Me.lblBarangay.Values.Image = Nothing
        Me.lblBarangay.Values.Text = "Barangay"
        '
        'lblMunicipality
        '
        Me.lblMunicipality.Location = New System.Drawing.Point(57, 168)
        Me.lblMunicipality.Name = "lblMunicipality"
        Me.lblMunicipality.Size = New System.Drawing.Size(71, 19)
        Me.lblMunicipality.TabIndex = 9
        Me.lblMunicipality.Text = "Municipality"
        Me.lblMunicipality.Values.ExtraText = ""
        Me.lblMunicipality.Values.Image = Nothing
        Me.lblMunicipality.Values.Text = "Municipality"
        '
        'lblProvince
        '
        Me.lblProvince.Location = New System.Drawing.Point(57, 143)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(53, 19)
        Me.lblProvince.TabIndex = 9
        Me.lblProvince.Text = "Province"
        Me.lblProvince.Values.ExtraText = ""
        Me.lblProvince.Values.Image = Nothing
        Me.lblProvince.Values.Text = "Province"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(57, 118)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(45, 19)
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Text = "Region"
        Me.KryptonLabel1.Values.ExtraText = ""
        Me.KryptonLabel1.Values.Image = Nothing
        Me.KryptonLabel1.Values.Text = "Region"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(85, 282)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 25)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Skip this lot"
        Me.btnCancel.Values.ExtraText = ""
        Me.btnCancel.Values.Image = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnCancel.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnCancel.Values.Text = "&Skip this lot"
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(282, 282)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(67, 25)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "&Ok"
        Me.btnOk.Values.ExtraText = ""
        Me.btnOk.Values.Image = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedNormal = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedPressed = Nothing
        Me.btnOk.Values.ImageStates.ImageCheckedTracking = Nothing
        Me.btnOk.Values.Text = "&Ok"
        '
        'cboBarangay
        '
        Me.cboBarangay.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.cboBarangay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBarangay.DropDownWidth = 250
        Me.cboBarangay.FormattingEnabled = False
        Me.cboBarangay.Location = New System.Drawing.Point(140, 199)
        Me.cboBarangay.Name = "cboBarangay"
        Me.cboBarangay.Size = New System.Drawing.Size(154, 21)
        Me.cboBarangay.TabIndex = 3
        '
        'cboMunicipality
        '
        Me.cboMunicipality.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.cboMunicipality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMunicipality.DropDownWidth = 250
        Me.cboMunicipality.FormattingEnabled = False
        Me.cboMunicipality.Location = New System.Drawing.Point(140, 172)
        Me.cboMunicipality.Name = "cboMunicipality"
        Me.cboMunicipality.Size = New System.Drawing.Size(154, 21)
        Me.cboMunicipality.TabIndex = 2
        '
        'cboProvince
        '
        Me.cboProvince.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.cboProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProvince.DropDownWidth = 250
        Me.cboProvince.FormattingEnabled = False
        Me.cboProvince.Location = New System.Drawing.Point(140, 145)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(154, 21)
        Me.cboProvince.TabIndex = 1
        '
        'cboRegion
        '
        Me.cboRegion.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRegion.DropDownWidth = 250
        Me.cboRegion.FormattingEnabled = False
        Me.cboRegion.Location = New System.Drawing.Point(140, 116)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(154, 21)
        Me.cboRegion.TabIndex = 0
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(22, 104)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(45, 19)
        Me.lblRegion.TabIndex = 9
        Me.lblRegion.Text = "Region"
        Me.lblRegion.Values.ExtraText = ""
        Me.lblRegion.Values.Image = Nothing
        Me.lblRegion.Values.Text = "Region"
        '
        'PsgcForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.KryptonPanel)
        Me.Name = "PsgcForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Psgc"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        Me.KryptonPanel1.PerformLayout()
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
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents lblBarangay As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMunicipality As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblProvince As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnCancel As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOk As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents cboBarangay As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboMunicipality As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboProvince As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents cboRegion As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents lblRegion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnAbort As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
