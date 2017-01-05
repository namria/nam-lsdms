Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Imports System.Runtime.InteropServices


Public Class MainForm
    Dim ConnString As String = "Data Source=" & GetSetting("servers", "DatabaseServer", "name") & ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92"
    Dim ImportSteps As StepHandler
    Dim Panel2Steps As StepHandler

    Dim UserName As String
    Dim Level As Integer



    Private Sub ImportFiles()
        Dim Application As Object = CreateObject("Excel.Application")
        Dim Worksheet As New Object
        Dim Workbook As New Object



        Dim con As New SqlClient.SqlConnection(ConnString)



        con.Open()

        pnlStep2Progress.Show()


        ' Disable "Import" and "Cancel" button
        btnImport.Enabled = False
        btnCancelImport.Enabled = False

        Dim filename As String = String.Empty
        Dim i As Integer = 0

        ProgressBar.Minimum = 0
        ProgressBar.Maximum = OpenFileDialog.FileNames.Length
        ProgressBar.Step = 1



        Dim PrevLocationError As String = String.Empty
        Dim PrevBarangayPsgc As String = String.Empty
        Dim PrevProvinceName As String = String.Empty
        Dim PrevMunicipalityName As String = String.Empty
        Dim PrevBarangayName As String = String.Empty


        ' Run through the files
        For Each filename In OpenFileDialog.FileNames
            Dim errorMessages As String = String.Empty

            'xxxDim Workbook As Object
            Dim fileInfo As New System.IO.FileInfo(filename)
            Dim LotCount As Integer = 0
            Dim ValidLotCount As Integer = 0
            Dim ImportedCount As Integer = 0

            ' Refresh progressbar
            ProgressBar.PerformStep()
            lblImportingFiles.Text = "Reading " & fileInfo.Name & "..."
            lblImportingFiles.Refresh()
            pnlStep1.Refresh()


            ' Open workbook
            Workbook = Application.Workbooks.Open(filename)
            'xxxDim Worksheet As Object

            'Dim PrevLocationError As String = String.Empty
            'Dim PrevBarangayPsgc As String = String.Empty
            'Dim PrevProvinceName As String = String.Empty
            'Dim PrevMunicipalityName As String = String.Empty
            'Dim PrevBarangayName As String = String.Empty

            ' Run through sheets
            For Each Worksheet In Workbook.Worksheets
                Dim HasError As Boolean = False
                Dim LotNo As String
                Dim CadSurveyNo As String = String.Empty
                Dim CaseNo As String = String.Empty
                Dim RegionName As String
                Dim RegionPsgc As String = ""
                Dim ProvinceName As String
                Dim ProvincePsgc As String = ""
                Dim MunicipalityName As String
                Dim MunicipalityPsgc As String = ""
                Dim BarangayName As String
                Dim BarangayPsgc As String
                Dim SectionId As String
                Dim ClaimantName As String
                Dim Quadrangle As String
                Dim Island As String
                Dim GeodeticEngineer As String
                Dim DateSurveyedFrom As String = String.Empty
                Dim DateSurveyedTo As String = String.Empty
                Dim LRCNo As String
                Dim DeclaredArea As Double = 0
                Dim ComputedArea As Double = 0

                Dim ReferencePoint As String = String.Empty


                LotNo = Trim(Worksheet.Cells("7", "C").Value)

                ' Make sure LotNo doesn't excess 10 characters
                If LotNo.Length > 50 Then
                    LotNo = LotNo.Substring(0, 50)
                End If



                RegionName = ""
                ProvinceName = Trim(Worksheet.Cells("13", "C").Value)
                MunicipalityName = Trim(Worksheet.Cells("12", "C").Value)
                BarangayName = Trim(Worksheet.Cells("11", "C").Value)

                ' ERROR HANDLER START =============================================================================
                Try ' WHEN DEBUGGING, comment this line

                    Dim isSheetTemplate As Boolean = False
                    isSheetTemplate = (NullToString(Worksheet.Cells("7", "A").Value, String.Empty).Contains("Lot No")) And _
                                      (NullToString(Worksheet.Cells("8", "A").Value, String.Empty).Contains("Owner") Or _
                                       NullToString(Worksheet.Cells("8", "A").Value, String.Empty).Contains("Claimant") Or _
                                       NullToString(Worksheet.Cells("8", "A").Value, String.Empty).Contains("Caimant")) And _
                                      (NullToString(Worksheet.Cells("9", "A").Value, String.Empty).Contains("Cad Survey No"))

                    'If Not LotNo = String.Empty Then
                    If isSheetTemplate And Not LotNo = String.Empty Then

                        LotCount += 1
                        ValidLotCount += 1

                        ' Field Checking starts here
                        ' ==========================

                        Dim cellC9 As String = NullToString(Worksheet.Cells("9", "C").Value, String.Empty)

                        ' Clean up extra spaces
                        While cellC9.Contains("  ")
                            cellC9 = cellC9.Replace("  ", " ")
                        End While
                        cellC9 = cellC9.ToUpper()


                        Dim delimeter As String

                        If cellC9.Contains(";") Then
                            delimeter = ";"
                        Else
                            delimeter = " C"
                        End If



                        ' *** CadSurveyNo
                        CadSurveyNo = Trim(cellC9)

                        Try
                            CadSurveyNo = CadSurveyNo.Substring(0, CadSurveyNo.LastIndexOf(delimeter))
                        Catch ex As Exception
                        End Try

                        ' CadsurveyNo must not be empty
                        If CadSurveyNo = String.Empty Then
                            CadSurveyNo = "<Unknown>"
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Cad survey no is empty." & "; "
                            HasError = True
                        End If

                        ' If CadSurveyNo is Numeric, insert "CAD" before CadSurveyNo
                        CadSurveyNo = IIf(IsNumeric(CadSurveyNo), "CAD " & CadSurveyNo, CadSurveyNo)


                        ' *** CaseNo

                        If cellC9.Contains(";") Then

                            CaseNo = Trim(cellC9)
                            If CaseNo.Contains(";") Then
                                CaseNo = CaseNo.Substring(CaseNo.IndexOf(";"), CaseNo.Length() - CaseNo.IndexOf(";"))
                                CaseNo = CaseNo.Replace(";", String.Empty)
                                CaseNo = CaseNo.Trim()
                            Else
                                CaseNo = String.Empty
                            End If

                        Else

                            Try
                                CaseNo = Trim(cellC9)
                                If CaseNo.LastIndexOf(delimeter) > 0 Then
                                    If CaseNo.Substring(CaseNo.LastIndexOf(delimeter) + 1, 1).ToUpper() = "C" Then
                                        CaseNo = Trim(CaseNo.Substring(CaseNo.LastIndexOf(delimeter), CaseNo.Length - CaseNo.LastIndexOf(delimeter)).ToString())
                                    Else
                                        CaseNo = String.Empty
                                    End If
                                Else
                                    CaseNo = String.Empty
                                End If

                            Catch ex As Exception
                            End Try

                            If CaseNo.Contains(";") Then
                                CaseNo = CaseNo.Replace(";", String.Empty)
                            End If

                        End If



                        ' CaseNo must not be empty
                        If CaseNo = String.Empty Then
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Case No is empty." & "; "

                            '4Monitoring
                            CaseNo = "<Unknown>"
                            '4Monitoring

                            HasError = True
                        End If


                        Dim cellC10 As String = NullToString(Worksheet.Cells("10", "C").Value, String.Empty)

                        '*** SectionId
                        SectionId = cellC10
                        If SectionId.Contains(";") Then
                            SectionId = SectionId.Substring(SectionId.IndexOf(";"), SectionId.Length() - SectionId.IndexOf(";"))
                            SectionId = Trim(SectionId.Replace(";", String.Empty))
                        Else
                            SectionId = String.Empty
                        End If

                        If SectionId = String.Empty Then
                            SectionId = "<Unknown>"
                            HasError = True
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Section ID is empty." & "; "
                        End If




                        '*** Quadrangle
                        Quadrangle = cellC10
                        If Quadrangle.Contains(";") Then
                            Quadrangle = Quadrangle.Substring(0, Quadrangle.IndexOf(";"))
                        Else
                            Quadrangle = cellC10
                        End If
                        Quadrangle = IIf(Quadrangle = String.Empty, "<Unknown>", Quadrangle)




                        ' *** DeclaredArea
                        Try
                            DeclaredArea = Convert.ToDouble(Val((Worksheet.Cells("19", "C").Value.ToString() + "").Replace(",", String.Empty)))
                        Catch ex As Exception
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Error in Declared area." & "; "
                            HasError = True
                        End Try

                        ' *** ComputedArea
                        Try
                            ComputedArea = Convert.ToDouble(Val((Worksheet.Cells("29", "C").Value.ToString() + "").Replace(",", String.Empty)))
                        Catch ex As Exception
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Error in Computed area." & "; "
                            HasError = True
                        End Try



                        ' *** DateSurveyedFrom
                        ClaimantName = (Worksheet.Cells("8", "C").Value & "").Replace("'", " ").Trim()
                        Island = (Worksheet.Cells("14", "C").Value & "").Replace("'", " ").Trim()
                        GeodeticEngineer = (Worksheet.Cells("15", "C").Value & "").Replace("'", " ").Trim()
                        LRCNo = (Worksheet.Cells("18", "C").Value & "").Replace("'", " ").Trim()
                        Console.WriteLine(filename & "   " & LotNo)

                        Try
                            DateSurveyedFrom = SplitDateToFrom(Worksheet.Cells("16", "C").Value)(0)
                            DateSurveyedTo = SplitDateToFrom(Worksheet.Cells("16", "C").Value)(1)
                        Catch ex As Exception
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Error in Survey date." & "; "
                            HasError = True
                        End Try




                        '*** Reference Point
                        ReferencePoint = Trim(Worksheet.Cells("22", "A").Value)


                        '*** Barangay

                        If Not PrevBarangayPsgc = String.Empty And (PrevProvinceName = ProvinceName And PrevMunicipalityName = MunicipalityName And PrevBarangayName = BarangayName) Then
                            BarangayPsgc = PrevBarangayPsgc

                        Else
                            BarangayPsgc = GetBarangayLocation(BarangayName, MunicipalityName, ProvinceName, LotNo, PrevLocationError)
                        End If


                        If BarangayPsgc.Contains("X") Then
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & PrevLocationError & "; "
                            HasError = True
                        End If

                        If BarangayPsgc = String.Empty Then
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Location cannot be identified." & "; "
                            HasError = True
                        ElseIf BarangayPsgc = "0" Then
                            GoTo Abort
                        Else
                            RegionPsgc = BarangayPsgc.Substring(0, 2) & "0000000"
                            ProvincePsgc = BarangayPsgc.Substring(0, 4) & "00000"
                            MunicipalityPsgc = BarangayPsgc.Substring(0, 6) & "000"

                            PrevBarangayPsgc = BarangayPsgc
                            PrevProvinceName = ProvinceName
                            PrevMunicipalityName = MunicipalityName
                            PrevBarangayName = BarangayName
                        End If



                        '*** Points
                        i = 42
                        While IsNumeric(Worksheet.Cells(i.ToString(), "A").Value)
                            Dim Sequence As Integer = (i - 41)


                            Dim PtmX As String = NullToString(Worksheet.Cells(i.ToString(), "D").Value, "x").Replace(",", "")
                            Dim PtmY As String = NullToString(Worksheet.Cells(i.ToString(), "C").Value, "x").Replace(",", "")

                            If IsNumeric(PtmX) And IsNumeric(PtmY) Then
                                If Convert.ToDouble(PtmX) > 9999999 Then
                                    errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Easting coordinates exceeded normal values. (Station " & Sequence.ToString() & ")" & "; "
                                    HasError = True
                                End If
                                If Convert.ToDouble(PtmY) > 9999999 Then
                                    errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Northing coordinates exceeded normal value. (Station " & Sequence.ToString() & ")" & "; "
                                    HasError = True
                                End If


                            Else
                                errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Error in Coordinates. (Station " & Sequence.ToString() & ")" & "; "
                                HasError = True
                            End If

                            i += 1
                        End While


                        ' Truncation Error Checking
                        If CadSurveyNo.Length() > 20 Then
                            CadSurveyNo = CadSurveyNo.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Cad Survey No exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If CaseNo.Length() > 20 Then
                            CaseNo = CaseNo.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Case No exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If SectionId.Length() > 20 Then
                            SectionId = SectionId.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Section ID exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If DateSurveyedFrom.Length() > 20 Then
                            DateSurveyedFrom = DateSurveyedFrom.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Date Surveyed From exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If DateSurveyedTo.Length() > 20 Then
                            DateSurveyedTo = DateSurveyedTo.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Date Surveyed To exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If Island.Length() > 20 Then
                            Island = Island.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Island exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If GeodeticEngineer.Length() > 200 Then
                            GeodeticEngineer = GeodeticEngineer.Substring(0, 200)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Geodetic Engineer exceeded 200 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If Quadrangle.Length() > 50 Then
                            Quadrangle = Quadrangle.Substring(0, 50)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Quadrangle exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If SectionId.Length() > 20 Then
                            SectionId = SectionId.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Section ID exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If ClaimantName.Length() > 200 Then
                            ClaimantName = ClaimantName.Substring(0, 200)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Claimant Name exceeded 200 characters. Data was truncated." & "; "
                            HasError = True
                        End If
                        If LRCNo.Length() > 50 Then
                            LRCNo = LRCNo.Substring(0, 50)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "LRC No exceeded 50 characters. Data was truncated." & "; "
                            HasError = True
                        End If

                        If DeclaredArea > 100000000 Then
                            DeclaredArea = 0
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Declared area exceeds 99,999,999." & "; "
                            HasError = True
                        End If
                        If ComputedArea > 100000000 Then
                            ComputedArea = 0
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Computed area exceeds 99,999,999." & "; "
                            HasError = True
                        End If

                        If ReferencePoint.Length() > 20 Then
                            ReferencePoint = ReferencePoint.Substring(0, 20)
                            errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Reference point exceeded 20 characters. Data was truncated." & "; "
                            HasError = True
                        End If

                        ' ==========================
                        ' Field Checking ends here




                        ' Cleanup
                        CadSurveyNo = CadSurveyNo.Replace("'", "''")
                        DateSurveyedFrom = DateSurveyedFrom.Replace("'", "''")
                        DateSurveyedTo = DateSurveyedTo.Replace("'", "''")
                        Island = Island.Replace("'", "''")
                        CaseNo = CaseNo.Replace("'", "''")
                        GeodeticEngineer = GeodeticEngineer.Replace("'", "''")
                        Quadrangle = Quadrangle.Replace("'", "''")
                        SectionId = SectionId.Replace("'", "''")
                        LotNo = LotNo.Replace("'", "''")
                        ClaimantName = ClaimantName.Replace("'", "''")
                        LRCNo = LRCNo.Replace("'", "''")
                        ReferencePoint = ReferencePoint.Replace("'", "''")






                        ' Actual Import of data starts here
                        ' =================================
                        '    ' CadSurvey
                        If IsUnique(con, String.Format("CadSurvey| CadSurveyNo = '{0}'", CadSurveyNo)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [CadSurvey](CadSurveyNo, RegionPsgc, ProvincePsgc, Island) VALUES('{0}','{1}','{2}','{3}')", _
                                        CadSurveyNo, RegionPsgc, ProvincePsgc, Island), con)
                        Else
                            'Update
                            ExecuteQuery(String.Format("UPDATE [CadSurvey] SET RegionPsgc = '{1}', ProvincePsgc = '{2}', Island =  '{3}' WHERE CadSurveyNo = '{0}'", _
                                        CadSurveyNo, RegionPsgc, ProvincePsgc, Island), con)
                        End If

                        ' Municipality
                        ExecuteQuery("ALTER TABLE [Municipality] NOCHECK CONSTRAINT ALL", con)
                        If IsUnique(con, String.Format("Municipality| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'", CadSurveyNo, MunicipalityPsgc)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [Municipality](CadSurveyNo, MunicipalityPsgc) VALUES('{0}','{1}')", _
                                        CadSurveyNo, MunicipalityPsgc), con)
                        End If
                        ExecuteQuery("ALTER TABLE [Municipality] CHECK CONSTRAINT ALL", con)

                        ' Case
                        If IsUnique(con, String.Format("Case| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'| CadCaseNo = '{2}'", CadSurveyNo, MunicipalityPsgc, CaseNo)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [Case](CadSurveyNo, MunicipalityPsgc, CadCaseNo) VALUES('{0}','{1}','{2}')", _
                                        CadSurveyNo, MunicipalityPsgc, CaseNo), con)
                        Else
                            'Update
                            ' SINCE GEName is removed from CASE, then no more fields to update
                            'ExecuteQuery(String.Format("UPDATE [Case] SET GEName = '{3}' WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' ", _
                            '            CadSurveyNo, MunicipalityPsgc, CaseNo), con)
                        End If

                        ' Barangay
                        If IsUnique(con, String.Format("Barangay| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'| CadCaseNo = '{2}'| BarangayPsgc = '{3}'", CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [Barangay](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc) VALUES('{0}','{1}','{2}','{3}')", _
                                        CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc), con)
                        End If


                        ' Quadrangle
                        If IsUnique(con, String.Format("Quadrangle| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'| CadCaseNo = '{2}'| BarangayPsgc = '{3}'| Quadrangle = '{4}' ", CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [Quadrangle](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle) VALUES('{0}','{1}','{2}','{3}', '{4}')", _
                                        CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle), con)
                        End If

                        ' Section
                        If IsUnique(con, String.Format("Section| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'| CadCaseNo = '{2}'| BarangayPsgc = '{3}'| Quadrangle = '{4}'| SectionId = '{5}' ", CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId)) Then
                            'Insert
                            ExecuteQuery(String.Format("INSERT INTO [Section](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId) VALUES('{0}','{1}','{2}','{3}', '{4}', '{5}')", _
                                        CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId), con)
                            'Else
                            '    'Update
                            '    ExecuteQuery(String.Format("UPDATE [Section] SET Quadrangle = '{5}' WHERE CadSurveyNo ='{0}' AND MunicipalityPsgc ='{1}' AND CadCaseNo ='{2}' AND BarangayPsgc ='{3}' AND SectionId  ='{4}' ", _
                            '                CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, SectionId, Quadrangle), con)
                        End If

                        ' Lot
                        'Insert
                        ExecuteQuery(String.Format("DELETE FROM [Lot] WHERE CadSurveyNo = '{0}' AND MunicipalityPsgc = '{1}' AND CadCaseNo = '{2}' AND BarangayPsgc = '{3}' AND Quadrangle = '{4}' AND SectionId = '{5}'  AND LotNo = '{6}';", _
                                   CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo), con)
                        ExecuteQuery(String.Format("INSERT INTO [Lot](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, ClaimantName, DeclaredArea, LRCNo, Remarks, ComputedArea, GEName, UserName, ReferencePoint, DateAdded) VALUES('{0}','{1}','{2}','{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', '{10}', {11}, '{12}', '{13}','{14}', GetDate())", _
                                   CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, ClaimantName, Convert.ToDecimal(DeclaredArea), LRCNo, "Imported from: " & filename.Replace("'", "''") & "\" & Worksheet.Name.ToString().Replace("'", "''") & vbCrLf & DateTime.Now.ToString(), Convert.ToDecimal(ComputedArea), GeodeticEngineer, UserName, ReferencePoint), con)
                        ImportedCount += 1

                        ' Points
                        i = 42
                        While IsNumeric(Worksheet.Cells(i.ToString(), "A").Value)
                            Dim Sequence As Integer = (i - 41)
                            Dim PtmX As String = NullToString(Worksheet.Cells(i.ToString(), "D").Value, "").Replace(",", "")
                            Dim PtmY As String = NullToString(Worksheet.Cells(i.ToString(), "C").Value, "").Replace(",", "")
                            If IsNumeric(PtmX) And IsNumeric(PtmY) Then
                                If Convert.ToDouble(PtmX) > 9999999 Then
                                    PtmX = "NULL"
                                    'errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Easting coordinates exceeded normal values. (Station " & Sequence.ToString() & ")" & "; "
                                    'HasError = True
                                End If
                                If Convert.ToDouble(PtmY) > 9999999 Then
                                    PtmY = "NULL"
                                    'errorMessages = errorMessages & "Lot no " & LotNo & ": " & "Northing coordinates exceeded normal value. (Station " & Sequence.ToString() & ")" & "; "
                                    'HasError = True
                                End If
                            Else
                                PtmX = "NULL"
                                PtmY = "NULL"
                            End If

                            If IsUnique(con, String.Format("LotData| CadSurveyNo = '{0}'| MunicipalityPsgc = '{1}'| CadCaseNo = '{2}'| BarangayPsgc = '{3}'| Quadrangle = '{4}'| SectionId = '{5}'| LotNo = '{6}'| Sequence = {7}", CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, Sequence)) Then
                                Dim coordSysX As String = "PtmX"
                                Dim coordSysY As String = "PtmY"


                                If Not PtmX = "NULL" And Not PtmY = "NULL" Then
                                    If Convert.ToDouble(PtmY) < 100000 And Convert.ToDouble(PtmX) < 100000 Then
                                        coordSysX = "LocalX"
                                        coordSysY = "LocalY"
                                    End If

                                End If


                                'Insert
                                ExecuteQuery(String.Format("INSERT INTO [LotData](CadSurveyNo, MunicipalityPsgc, CadCaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, Sequence, {10}, {11}) VALUES('{0}','{1}','{2}','{3}', '{4}', '{5}', '{6}', {7}, {8}, {9})", _
                                            CadSurveyNo, MunicipalityPsgc, CaseNo, BarangayPsgc, Quadrangle, SectionId, LotNo, Sequence, PtmX, PtmY, coordSysX, coordSysY), con)
                            End If
                            i += 1
                        End While







                        ' ===============================
                        ' Actual Import of data ends here

                    Else
                        ' Not a template or No Lot no
                        'LotNo is Empty
                        If isSheetTemplate Then
                            errorMessages = errorMessages & "Worksheet (" & Worksheet.Name & ") has no Lot No.; "
                            LotCount += 1
                        Else
                            Dim mukhangTemplate As Boolean = False
                            mukhangTemplate = (Not NullToString(Worksheet.Cells("7", "A").Value, String.Empty) = "") Or _
                                              (Not NullToString(Worksheet.Cells("8", "A").Value, String.Empty) = "") Or _
                                              (Not NullToString(Worksheet.Cells("9", "A").Value, String.Empty) = "")
                            LotCount += 1
                            errorMessages = errorMessages & "Check if this is a valid template. (" & Worksheet.Name & "); "
                        End If
                    End If


                Catch ex As Exception ' WHEN DEBUGGING, comment this section
                    MessageBox.Show("An unhandled error occured. Please check the " & vbCrLf & "worksheet " & Worksheet.Name & vbCrLf & "on file " & filename, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    errorMessages = errorMessages & "Lot no " & LotNo & ": " & "An unhandled error occured. Please check the worksheet (" & Worksheet.Name & "). The Error is """ & ex.Message() & """; "
                    HasError = True
                End Try
                ' ERROR HANDLER END =============================================================================

                ' If worksheet has error, subtract 1 from ValidLotCount
                If HasError Then
                    ValidLotCount -= 1
                End If



            Next ' Run through sheets

            ' Reflect new information gathered
            lvwExcelFiles.Items.Add(fileInfo.Name, fileInfo.Name, String.Empty)
            lvwExcelFiles.Items(fileInfo.Name).SubItems.AddRange(New String() {LotCount.ToString(), (LotCount - ValidLotCount).ToString(), ValidLotCount.ToString(), ImportedCount.ToString()})
            lvwExcelFiles.Items(fileInfo.Name).Tag = errorMessages


            LogMessage(fileInfo.Name & vbTab & LotCount.ToString() & vbTab & (LotCount - ValidLotCount).ToString() & vbTab & ValidLotCount.ToString() & vbTab & ImportedCount.ToString() & vbTab & errorMessages & vbCrLf)


            If Not errorMessages = String.Empty Then
                lvwExcelFiles.Items(fileInfo.Name).ForeColor = Color.Red
            End If


            'Workbook.Close(False)

        Next    ' Run through files


Abort:


        ImportSteps.Show(pnlStep3)
        pnlStep3.Refresh()



        ' Enable "Import" and "Cancel" button
        btnImport.Enabled = True
        btnCancelImport.Enabled = True

        pnlStep2Progress.Hide()


        con.Close()

        ' Clean up
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
        GC.WaitForPendingFinalizers()

        Marshal.FinalReleaseComObject(Worksheet)

        Workbook.Close(False)
        Marshal.FinalReleaseComObject(Workbook)

        Application.Quit()
        Marshal.FinalReleaseComObject(Application)

        Application = Nothing

    End Sub



    Private Sub ExecuteQuery(ByVal sql As String, ByVal con As SqlConnection)
        Dim cmd As New SqlClient.SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Function GetBarangayLocation(ByVal brgyName As String, ByVal munName As String, ByVal provName As String, ByVal lotNo As String, ByRef PrevLocationError As String) As String
        Dim brgyPsgc As String
        Dim munPsgc As String
        Dim provPsgc As String
        Dim regPsgc As String
        Dim message As String
        Dim frm As New PsgcForm


        brgyPsgc = GetExactMatchBarangayPsgc(brgyName, String.Empty)

        If Not brgyPsgc = String.Empty Then
            Return brgyPsgc
        Else
            munPsgc = GetExactMatchMunicipalityPsgc(munName)
            If Not munPsgc = String.Empty Then
                'MUN is known, PROV is known, REG is known
                provPsgc = munPsgc.Substring(0, 4) & "00000"
                regPsgc = provPsgc.Substring(0, 2) & "0000000"

                brgyPsgc = GetExactMatchBarangayPsgc(brgyName, munPsgc)
                If Not brgyPsgc = String.Empty Then
                    Return brgyPsgc
                End If

                frm.FillRegion(regPsgc)
                frm.cboRegion.Enabled = False

                frm.cboProvince.SelectedValue = provPsgc
                frm.cboProvince.Enabled = False

                frm.cboMunicipality.SelectedValue = munPsgc
                frm.cboMunicipality.Enabled = False

                message = "No single match was found for the barangay named """ & brgyName & """."
            Else
                provPsgc = Me.GetExactMatchProvincePsgc(provName)
                If Not provPsgc = String.Empty Then
                    'PROV is known, REG is known
                    regPsgc = provPsgc.Substring(0, 2) & "0000000"

                    frm.FillRegion(regPsgc)
                    frm.cboRegion.Enabled = False

                    frm.cboProvince.SelectedValue = provPsgc
                    frm.cboProvince.Enabled = False

                    message = "No single match was found for the municipality named """ & munName & ", " & brgyName & """."
                Else
                    frm.FillRegion("")
                    message = "No single match was found for the province named """ & provName & ", " & munName & ", " & brgyName & """."
                End If

            End If

            PrevLocationError = message

            'prompt for BRGY
            frm.lblMessage.Text = message
            frm.Text = "PSGC for Lot No " & lotNo
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                ' OK
                brgyPsgc = frm.cboBarangay.SelectedValue.ToString()

            ElseIf frm.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' CANCEL
                brgyPsgc = String.Empty
            Else
                ' ABORT
                brgyPsgc = "0"

            End If

            frm.Close()
            Me.Refresh()

        End If


        Return brgyPsgc
    End Function


    Private Function GetBarangayLocationKILLED(ByVal brgyName As String, ByVal munName As String, ByVal provName As String, ByRef errorMessages As String, ByVal lotNo As String) As String
        Dim brgyPsgc As String
        Dim munPsgc As String
        Dim provPsgc As String
        Dim regPsgc As String
        Dim message As String
        Dim frm As New PsgcForm


        brgyPsgc = GetExactMatchBarangayPsgc(brgyName, String.Empty)

        If Not brgyPsgc = String.Empty Then
            Return brgyPsgc
        Else
            munPsgc = GetExactMatchMunicipalityPsgc(munName)
            If Not munPsgc = String.Empty Then
                'MUN is known, PROV is known, REG is known
                provPsgc = munPsgc.Substring(0, 4) & "00000"
                regPsgc = provPsgc.Substring(0, 2) & "0000000"

                brgyPsgc = GetExactMatchBarangayPsgc(brgyName, munPsgc)
                If Not brgyPsgc = String.Empty Then
                    Return brgyPsgc
                End If

                frm.FillRegion(regPsgc)
                frm.cboRegion.Enabled = False

                frm.cboProvince.SelectedValue = provPsgc
                frm.cboProvince.Enabled = False

                frm.cboMunicipality.SelectedValue = munPsgc
                frm.cboMunicipality.Enabled = False

                message = "No single match was found for the barangay named """ & brgyName & """."
                errorMessages = errorMessages & "Lot no " & lotNo & ": " & message & "; "


            Else
                provPsgc = Me.GetExactMatchProvincePsgc(provName)
                If Not provPsgc = String.Empty Then
                    'PROV is known, REG is known
                    regPsgc = provPsgc.Substring(0, 2) & "0000000"

                    frm.FillRegion(regPsgc)
                    frm.cboRegion.Enabled = False

                    frm.cboProvince.SelectedValue = provPsgc
                    frm.cboProvince.Enabled = False

                    message = "No single match was found for the municipality named """ & munName & ", " & brgyName & """."
                    errorMessages = errorMessages & "Lot no " & lotNo & ": " & message & "; "

                Else
                    frm.FillRegion("")
                    message = "No single match was found for the province named """ & provName & ", " & munName & ", " & brgyName & """."
                    errorMessages = errorMessages & "Lot no " & lotNo & ": " & message & "; "
                End If

            End If

            'prompt for BRGY
            frm.lblMessage.Text = message
            frm.Text = "PSGC for Lot No " & lotNo
            frm.ShowDialog()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                ' OK
                brgyPsgc = frm.cboBarangay.SelectedValue.ToString()

            ElseIf frm.DialogResult = Windows.Forms.DialogResult.Cancel Then
                ' CANCEL
                brgyPsgc = String.Empty
            Else
                ' ABORT
                brgyPsgc = "0"

            End If

            frm.Close()
            Me.Refresh()

        End If


        Return brgyPsgc
    End Function

    Private Sub LogMessage(ByVal Message As String)
        Dim logFile As String = Application.StartupPath & "\log.txt"

        My.Computer.FileSystem.WriteAllText(logFile, Message, True)

    End Sub
    Private Function SplitDateToFrom(ByVal stringDate As String) As String()
        Dim retVal(1) As String
        Dim dateFrom As Date
        Dim dateTo As Date

        ' If its already a date
        If IsDate(stringDate) Then
            retVal(0) = stringDate
            retVal(1) = String.Empty
            Return retVal
        End If

        ' If its blank
        If IsNothing(stringDate) Then
            retVal(0) = String.Empty
            retVal(1) = String.Empty
            Return retVal
        End If

        If IsDate(stringDate.Split("-")(0)) And IsDate(stringDate.Split("-")(1)) Then
            dateFrom = CDate(stringDate.Split("-")(0))
            dateTo = CDate(stringDate.Split("-")(1))
            retVal(0) = dateFrom.ToString("MM/dd/yyyy")
            retVal(1) = dateTo.ToString("MM/dd/yyyy")
        End If

        If IsDate(stringDate.Split("-")(0)) And Not IsDate(stringDate.Split("-")(1)) Then
            dateFrom = CDate(stringDate.Split("-")(0))

            dateTo = CDate(stringDate.Split("-")(1))

            dateTo = CDate(dateFrom.Month & "/" & stringDate.Split("-")(1))
            dateFrom = CDate(dateFrom.Month & "/" & dateFrom.Day & "/" & dateTo.Year)

            retVal(0) = dateFrom.ToString("MM/dd/yyyy")
            retVal(1) = dateTo.ToString("MM/dd/yyyy")
        Else
            retVal(0) = stringDate
            retVal(1) = String.Empty
        End If

        Return retVal
    End Function
    Private Function IsUnique(ByVal con As SqlConnection, ByVal params As String) As Boolean
        Dim retVal As Boolean = False
        Dim i As Integer = 0
        Dim columnName As String
        Dim value As String
        Dim sql As String = ""
        Dim args As String() = params.Split("|")
        Dim tableName As String = args(0)

        sql = "SELECT COUNT(*) FROM [" & tableName & "] WHERE "

        'primary keys
        For i = 1 To args.Length - 1
            'columnName = args(i).Split("=")(0)
            'value = args(i).Split("=")(1)
            columnName = args(i).Substring(0, args(i).IndexOf("="))
            value = args(i).Substring(args(i).IndexOf("=") + 1, args(i).Length() - args(i).IndexOf("=") - 1)
            sql &= IIf(i = args.Length - 1, columnName & " = " & value, columnName & " = " & value & " AND ")
        Next

        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Return (cmd.ExecuteScalar() = 0)
    End Function

    Private Function IsUniqueKILLED(ByVal con As SqlConnection, ByVal params As String) As Boolean
        Dim retVal As Boolean = False
        Dim i As Integer = 0
        Dim columnName As String
        Dim value As String
        Dim sql As String = ""
        Dim args As String() = params.Split("|")
        Dim tableName As String = args(0)

        sql = "SELECT COUNT(*) FROM [" & tableName & "] WHERE "

        'primary keys
        For i = 1 To args.Length - 1
            'columnName = args(i).Split("=")(0)
            'value = args(i).Split("=")(1)
            columnName = args(i).Substring(0, args(i).IndexOf("="))
            value = args(i).Substring(args(i).IndexOf("=") + 1, args(i).Length() - args(i).IndexOf("=") - 1)
            sql &= IIf(i = args.Length - 1, columnName & " = " & value, columnName & " = " & value & " AND ")
        Next

        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Return (cmd.ExecuteScalar() = 0)
    End Function


    Private Function GetSetting(ByVal section As String, ByVal setting As String, ByVal attribute As String) As String

        Dim configFile As String = Application.StartupPath & "\lsdms.xml"
        Dim doc As New XmlDocument()
        doc.Load(configFile)
        Dim node As XmlNode = doc.SelectSingleNode("config/" & section + "/" & setting)
        Return node.Attributes(attribute).Value

    End Function

    Private Function GetExactMatchProvincePsgc(ByVal province As String) As String
        Dim sql As String = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 2, 2) = '00' AND SUBSTRING(psgc_cd, 5, 5) = '00000' AND name = '{0}'", province.Replace("'", "''"))
        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)


        If dt.Rows.Count = 1 Then
            Return dt.Rows(0)("PSGC").ToString()
        Else
            Return String.Empty
        End If

    End Function
    Private Function GetExactMatchMunicipalityPsgc(ByVal municipality As String) As String
        Dim sql As String = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM Psgc WHERE NOT SUBSTRING(psgc_cd, 5, 2) = '00' AND SUBSTRING(psgc_cd, 7, 3) = '000' AND name = '{0}'", municipality.Replace("'", "''"))
        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)


        If dt.Rows.Count = 1 Then
            Return dt.Rows(0)("PSGC").ToString()
        Else
            Return String.Empty
        End If

    End Function
    Private Function GetExactMatchBarangayPsgc(ByVal barangay As String, ByVal municipalityPsgc As String) As String
        Dim sql As String

        If municipalityPsgc = String.Empty Then
            sql = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM PSGC WHERE NOT SUBSTRING(psgc_cd, 7, 3) = '000' AND name = '{0}'", barangay.Replace("'", "''"))
        Else
            sql = String.Format("SELECT psgc_cd AS PSGC, name AS GEOG_NM FROM PSGC WHERE NOT SUBSTRING(psgc_cd, 7, 3) = '000' AND name = '{0}' AND SUBSTRING(psgc_cd, 1, 6) + '000' = '{1}'", barangay.Replace("'", "''"), municipalityPsgc)
        End If

        Dim con As New SqlClient.SqlConnection(ConnString)
        Dim cmd As New SqlClient.SqlCommand(sql, con)

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(sql, con)
        da.Fill(dt)


        If dt.Rows.Count = 1 Then
            Return dt.Rows(0)("PSGC").ToString()
        Else
            Return String.Empty
        End If

    End Function

    Private Function NullToString(ByVal value As Object, ByVal replaceNullWith As String) As String
        If value Is Nothing Then
            Return replaceNullWith
        Else
            If value.ToString.Trim() = String.Empty Then
                Return replaceNullWith
            Else
                Return value.ToString()
            End If
        End If

    End Function

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Init()


    End Sub

    Private Sub Init()
        ImportSteps = New StepHandler(pnlStep0, pnlStep1, pnlStep2, pnlStep3)
        ImportSteps.Show(pnlStep0)

        Panel2Steps = New StepHandler(pnlStep2Message, pnlStep2Progress)
        Panel2Steps.Show(pnlStep2Message)


        txtServer.Text = GetSetting("servers", "DatabaseServer", "name")

    End Sub

    Private Sub btnSelectFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFiles.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImportSteps.Show(pnlStep2)
            lblStep2Message.Text = "You are about to import " & OpenFileDialog.FileNames.Length.ToString() & " Excel files. If you want to continue importing these files, click the ""Import"" button below. Otherwise, click ""Cancel""."
        End If
    End Sub
    Private Sub btnCancelImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelImport.Click
        Me.Close()
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub lvwExcelFiles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwExcelFiles.SelectedIndexChanged
        If lvwExcelFiles.SelectedItems.Count > 0 Then
            txtErrorMessages.Text = lvwExcelFiles.SelectedItems(0).Tag.ToString().Replace("; ", vbCrLf)
            lblErrorDetails.Text = "*Review details for " & lvwExcelFiles.SelectedItems(0).Text
        End If
    End Sub
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Panel2Steps.Show(pnlStep2Progress)
        ImportFiles()
    End Sub
    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        'Me.Close()
        'Application.Restart()
        Me.Init()
        Me.ImportSteps.Show(Me.pnlStep1)
    End Sub








    Private Function IsConnectionOk() As Boolean
        Dim server As String = txtServer.Text
        Dim connString As String = "Data Source=" & server & ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92;Connect Timeout=5"
        Dim retVal As Boolean = False
        Using conn As New SqlConnection(connString)
            Try
                conn.Open()
                retVal = True
            Catch ex As Exception
                Dim msg As String = ex.Message
                retVal = False
            End Try

        End Using
        Return retVal
    End Function




    Private Function IsValidUser(ByVal username As String, ByVal password As String) As Boolean
        Dim server As String = txtServer.Text
        Dim connString As String = "Data Source=" & server & ";Initial Catalog=prs92;Persist Security Info=True;User ID=prs92;Password=prs92;"
        Dim retVal As Boolean = False
        Using conn As New SqlConnection(connString)
            Dim cmd As New SqlCommand()

            cmd.Connection = conn
            cmd.CommandText = "SELECT Access FROM [lsdms_users] WHERE Username = @Username AND Password = @Password"


            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            conn.Open()


            Dim level__1 As Object = cmd.ExecuteScalar()

            If level__1 IsNot Nothing Then
                Level = CInt(cmd.ExecuteScalar())
                retVal = True
            Else
                retVal = False
            End If


        End Using

        Return retVal
    End Function


    Private Sub LogUserIn()
        SetSetting("servers", "DatabaseServer", "name", txtServer.Text)
        ImportSteps.Show(Me.pnlStep1)
        UserName = txtUsername.Text
        Me.Text = Me.Text & "        User: " & UserName
    End Sub

    Private Sub SetSetting(ByVal section As String, ByVal setting As String, ByVal attribute As String, ByVal value As String)
        Dim configFile As String = Application.StartupPath & "\lsdms.xml"
        Dim doc As New XmlDocument()
        doc.Load(configFile)

        Dim node As XmlNode = doc.SelectSingleNode("config/" & section & "/" & setting)
        node.Attributes(attribute).Value = value
        doc.Save(configFile)
    End Sub


    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If IsConnectionOk() Then
            If IsValidUser(txtUsername.Text, txtPassword.Text) Then
                LogUserIn()
            Else
                MessageBox.Show("Login failed!", "LSDMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Else
            MessageBox.Show("Cannot connect to database server.", "LSDMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub







    Private Sub labelMoreOptions_LinkClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelMoreOptions.LinkClicked
        lblServer.Visible = Not lblServer.Visible
        txtServer.Visible = Not txtServer.Visible
    End Sub

    Private Sub MainForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If

    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
