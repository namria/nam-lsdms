Imports System.Data.SqlClient
Imports System.Xml

Public Class PsgcForm
    Dim ConnString As String = "Data Source=" & GetSetting("servers", "DatabaseServer", "name") & ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92"


    Public Sub FillRegion(ByVal selectedValue As String)


        Dim sql As String = "SELECT psgc_cd AS PSGC, name AS GEOG_NM, CASE WHEN name = 'Region IX' THEN 'Region VIIII' ELSE name END AS nameOrder FROM Psgc WHERE SUBSTRING(psgc_cd, 3, 7) = '0000000' ORDER BY nameOrder"
        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)


        cboRegion.DataSource = dt
        cboRegion.DisplayMember = "GEOG_NM"
        cboRegion.ValueMember = "PSGC"

        cboRegion.SelectedValue = selectedValue

    End Sub
    Public Sub FillProvince(ByVal region As String, ByVal selectedValue As String)
        Dim sql As String = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 3, 2) = '00' AND SUBSTRING(psgc_cd, 5, 5) = '00000' AND SUBSTRING(psgc_cd,1,2) = SUBSTRING('{0}',1,2)", region)
        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)

        cboProvince.DataSource = dt
        cboProvince.DisplayMember = "GEOG_NM"
        cboProvince.ValueMember = "PSGC"

        cboProvince.SelectedValue = selectedValue

    End Sub
    Public Sub FillMunicipality(ByVal province As String, ByVal selectedValue As String)
        Dim sql As String = String.Format("(SELECT SUBSTRING('{0}',1,4) + 'XX000' AS PSGC,'<Unknown>' AS GEOG_NM) " & _
                                          "UNION ALL (SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 5, 2) = '00' AND SUBSTRING(psgc_cd, 7, 3) = '000' AND SUBSTRING(psgc_cd,1,4) = SUBSTRING('{0}',1,4))", province)
        'Dim sql As String = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 5, 2) = '00' AND SUBSTRING(psgc_cd, 7, 3) = '000' AND SUBSTRING(psgc_cd,1,4) = SUBSTRING('{0}',1,4)", province)

        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)

        cboMunicipality.DataSource = dt
        cboMunicipality.DisplayMember = "GEOG_NM"
        cboMunicipality.ValueMember = "PSGC"

        cboMunicipality.SelectedValue = selectedValue
    End Sub
    Public Sub FillBarangay(ByVal municipality As String, ByVal selectedValue As String)
        Dim sql As String = String.Format("(SELECT SUBSTRING('{0}',1,6) + 'XXX' AS PSGC,'<Unknown>' AS GEOG_NM) " & _
                                          "UNION ALL (SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 7, 3) = '000' AND SUBSTRING(psgc_cd,1,6) = SUBSTRING('{0}',1,6))", municipality)
        'Dim sql As String = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 7, 3) = '000' AND SUBSTRING(psgc_cd,1,6) = SUBSTRING('{0}',1,6)", municipality)
        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)

        cboBarangay.DataSource = dt
        cboBarangay.DisplayMember = "GEOG_NM"
        cboBarangay.ValueMember = "PSGC"

        cboBarangay.ComboBox.SelectedValue = selectedValue

    End Sub
    Function GetSetting(ByVal section As String, ByVal setting As String, ByVal attribute As String) As String

        Dim configFile As String = Application.StartupPath & "\lsdms.xml"
        Dim doc As New XmlDocument()
        doc.Load(configFile)
        Dim node As XmlNode = doc.SelectSingleNode("config/" & section + "/" & setting)
        Return node.Attributes(attribute).Value

    End Function




    Private Sub cboBarangay_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBarangay.SelectedValueChanged
        If (Not cboBarangay.SelectedValue Is Nothing) Then
            btnOk.Enabled = True
        Else
            btnOk.Enabled = False
        End If
    End Sub

    Private Sub cboRegion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegion.SelectedValueChanged
        If Not cboRegion.SelectedValue Is Nothing Then
            FillProvince(cboRegion.SelectedValue.ToString(), "")
        End If
    End Sub

    Private Sub cboProvince_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedValueChanged
        If Not cboProvince.SelectedValue Is Nothing Then
            FillMunicipality(cboProvince.SelectedValue.ToString(), "")
        End If
    End Sub

    Private Sub cboMunicipality_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMunicipality.SelectedValueChanged
        If Not cboMunicipality.SelectedValue Is Nothing Then
            FillBarangay(cboMunicipality.SelectedValue.ToString(), "")
            If cboMunicipality.Text = "<Unknown>" Then
                cboBarangay.ComboBox.SelectedIndex = 0
            End If
        End If
    End Sub



  
    Private Sub cboRegion_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegion.DropDownClosed
        cboRegion.PerformNeedPaint(True)
    End Sub

    Private Sub cboProvince_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.DropDownClosed
        cboProvince.PerformNeedPaint(True)
    End Sub

    Private Sub cboMunicipality_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMunicipality.DropDownClosed
        cboMunicipality.PerformNeedPaint(True)
    End Sub

    Private Sub cboBarangay_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBarangay.DropDownClosed
        cboBarangay.PerformNeedPaint(True)
    End Sub



End Class
