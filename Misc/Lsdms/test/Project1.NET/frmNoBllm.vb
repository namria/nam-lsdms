Option Strict Off
Option Explicit On
Friend Class frmNoBllm
	Inherits System.Windows.Forms.Form
	Dim cnn As New ADODB.Connection
	Dim Coordinate_N() As Double
	Dim Coordinate_E() As Double
	Dim Stn_Name() As String
	Dim No_of_Corners As Short
	Dim Sum_Distances, Sum_Lat As Object
	Dim Sum_Dep As Double
	Dim Sum_Corr_Lat, Sum_Corr_Dep As Object
	Dim Sum_Adj_Lat As Double
	Dim Sum_Adj_Dep As Object
	Dim Sum_DPA As Double
	
	'for Bllm
	Dim BLLM_N As Double
	Dim BLLM_E As Double
	Dim BLLMchange_in_lat As Double
	Dim BLLMchange_in_dep As Double
	Dim BLLMN_S As String
	Dim BLLME_W As String
	Dim BLLMI As Short
	Dim BLLMK As Short
	Dim BLLML As String
	Dim BLLMDistance As Double
	Dim BLLMN As Double
	Dim BLLMO As Double
	Dim BLLMP As String
	Dim BLLMQ As String
	Dim BLLMDeg As String
	Dim BLLMMin As String
	Dim BLLMEW As String
	Dim BLLMNS As String
	Dim BLLMW As Double
	Dim BLLMAzimuth As Double
	Dim BLLMRadians As Double
	Dim BLLMLat As Double
	Dim BLLMDep As Double
	Dim BLLMCorr_Lat As Double
	Dim BLLMCorr_dep As Double
	Dim BLLMAdj_Lat As Double
	Dim BLLMAdj_Dep As Double
	Dim BLLMTD_North As Double
	Dim BLLMTD_East As Double
	
	'for corners
	Dim change_in_lat() As Double
	Dim change_in_dep() As Double
	Dim N_S() As String
	Dim E_W() As String
	Dim I() As Short
	Dim K() As Short
	Dim L() As String
	Dim Distance() As Double
	Dim N() As Double
	Dim O() As Double
	Dim P() As String
	Dim Q() As String
	Dim Deg() As String
	Dim Min() As String
	Dim EW() As String
	Dim NS() As String
	Dim W() As Double
	Dim dAzimuth() As Double
	Dim dRadians() As Double
	Dim Lat() As Double
	Dim Dep() As Double
	Dim Corr_Lat() As Double
	Dim Corr_dep() As Double
	Dim Adj_Lat() As Double
	Dim Adj_Dep() As Double
	Dim TD_North() As Double
	Dim TD_East() As Double
	Dim sLine() As String
	Dim DMD() As Double
	Dim DPA() As Double
	Dim for_plot() As String
	
	Dim pi As Double
	Dim nLec As Double
	Dim nRec As Double
	Dim nAcc As String
	Dim nDoubleArea As Double
	Dim nArea As Double
	
	Sub InitVal()
		pi = 3.14159265358979
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sum_Distances = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sum_Lat = 0
		Sum_Dep = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Corr_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sum_Corr_Lat = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Corr_Dep. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sum_Corr_Dep = 0
		Sum_Adj_Lat = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Adj_Dep. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Sum_Adj_Dep = 0
		Sum_DPA = 0
		BLLM_N = 721228.62 'Reference pt - northing
		BLLM_E = 462450.22 'Reference pt - easting
	End Sub
	
	Private Sub frmNoBllm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        cnn.ConnectionString = "DSN=prs92;uid=prs92;pwd=prs92"
		cnn.Open()
		LoadCoordinates()
		InitVal()
	End Sub
	
	Private Sub LoadCoordinates()
		Dim rst As New ADODB.Recordset
		Dim x As Short
		
        rst.Open("select * from lotdata where LotNo='2125'", cnn, ADODB.CursorTypeEnum.adOpenStatic)
		If rst.RecordCount > 0 Then
			No_of_Corners = rst.RecordCount
			'UPGRADE_WARNING: Lower bound of array Coordinate_N was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim Coordinate_N(rst.RecordCount)
			'UPGRADE_WARNING: Lower bound of array Coordinate_E was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim Coordinate_E(rst.RecordCount)
			'UPGRADE_WARNING: Lower bound of array Stn_Name was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim Stn_Name(rst.RecordCount)
			For x = 1 To rst.RecordCount
                Coordinate_N(x) = rst.Fields("ptmy").Value
                Coordinate_E(x) = rst.Fields("ptmx").Value
                Stn_Name(x) = rst.Fields("sequence").Value
				rst.MoveNext()
			Next 
			rst.Close()
		End If
	End Sub
	Sub RedimArrays()
		'UPGRADE_WARNING: Lower bound of array change_in_lat was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim change_in_lat(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array change_in_dep was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim change_in_dep(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array N_S was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim N_S(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array E_W was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim E_W(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array I was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim I(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array K was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim K(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array L was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim L(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Distance was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Distance(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array N was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim N(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array O was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim O(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array P was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim P(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Q was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Q(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Deg was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Deg(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Min was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Min(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array EW was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim EW(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array NS was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim NS(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array W was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim W(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array dAzimuth was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim dAzimuth(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array dRadians was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim dRadians(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Lat was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Lat(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Dep was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Dep(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Corr_Lat was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Corr_Lat(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Corr_dep was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Corr_dep(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Adj_Lat was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Adj_Lat(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array Adj_Dep was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim Adj_Dep(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array TD_North was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim TD_North(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array TD_East was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim TD_East(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array sLine was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim sLine(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array DMD was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim DMD(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array DPA was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim DPA(No_of_Corners)
		'UPGRADE_WARNING: Lower bound of array for_plot was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		ReDim for_plot(No_of_Corners)
	End Sub
	Sub BLLMComputation()
		If Coordinate_N(1) <> 0 Then
			BLLMchange_in_lat = BLLM_N - Coordinate_N(1)
		Else
			BLLMchange_in_lat = 0
		End If
		If Coordinate_E(1) <> 0 Then
			BLLMchange_in_dep = BLLM_E - Coordinate_E(1)
		Else
			BLLMchange_in_dep = 0
		End If
		
		If BLLMchange_in_dep = 0 Then
			If BLLMchange_in_lat > 0 Then
				BLLMN_S = "South"
			Else
				BLLMN_S = "North"
			End If
		Else
			BLLMN_S = ""
		End If
		
		If BLLMN_S = "North" Then
			BLLMI = 2
		Else
			BLLMI = 0
		End If
		
		If BLLMchange_in_lat = 0 Then
			If BLLMchange_in_dep > 0 Then
				BLLME_W = "West"
			Else
				BLLME_W = "East"
			End If
		Else
			BLLME_W = ""
		End If
		
		If BLLME_W = "West" Then
			BLLMK = 1
		ElseIf BLLME_W = " " Then 
			BLLMK = 0
		Else
			BLLMK = 3
		End If
		
		BLLML = BLLMN_S & BLLME_W
		
		BLLMDistance = System.Math.Sqrt((BLLMchange_in_lat ^ 2) + (BLLMchange_in_dep ^ 2)) 'M - Distance
		
		If BLLMchange_in_lat <> 0 Then
			BLLMN = System.Math.Atan(BLLMchange_in_dep / BLLMchange_in_lat)
		End If
		
		BLLMO = System.Math.Abs(BLLMN * 180 / pi) 'DEGREES in excel replace with multiplying by 180/pi
		'radians to degrees (x 180/pi)
		'degrees to radians (x pi/180)
		
		BLLMP = VB6.Format(Int(BLLMO), "00")
		
		BLLMQ = VB6.Format((BLLMO - CDbl(BLLMP)) * 60, "00")
		
		If BLLML = "" Then
			If BLLMchange_in_lat > 0 Then
				BLLMNS = "S" 'R - N/S
			Else
				BLLMNS = "N"
			End If
		Else
			BLLMNS = ""
		End If
		
		If BLLML = "" Then
			If Int(CDbl(BLLMQ)) = 60 Then
				BLLMDeg = VB6.Format(Int(CShort(BLLMP) + 1), "00") 'S - Deg
			Else
				BLLMDeg = VB6.Format(Int(CDbl(BLLMP)), "00")
			End If
		Else
			BLLMDeg = "due"
		End If
		
		If BLLML = "" Then
			If Int(CDbl(BLLMQ)) = 60 Then
				BLLMMin = "00" 'T - Min
			Else
				BLLMMin = BLLMQ
			End If
		Else
			BLLMMin = BLLML
		End If
		
		If BLLML = "" Then
			If BLLMchange_in_dep > 0 Then
				BLLMEW = "W" 'U - EW
			Else
				BLLMEW = "E"
			End If
		Else
			BLLMEW = ""
		End If
		
		If BLLMDeg = "due" Then
			BLLMW = 90 * (BLLMI + BLLMK)
		Else
			BLLMW = CDbl(BLLMDeg) + (CDbl(BLLMMin) / 60)
		End If
		
		If BLLMNS = "" Then
			BLLMAzimuth = BLLMW
		ElseIf BLLMNS = "N" Then 
			If BLLMEW = "E" Then
				BLLMAzimuth = 180 + BLLMW
			Else
				BLLMAzimuth = 180 - BLLMW
			End If
		ElseIf BLLMNS = "S" Then 
			If BLLMEW = "E" Then
				BLLMAzimuth = 360 - BLLMW
			Else
				BLLMAzimuth = BLLMW
			End If
		End If
		
		BLLMRadians = BLLMAzimuth * pi / 180
		
		BLLMLat = -BLLMDistance * System.Math.Cos(BLLMRadians)
		
		BLLMDep = -BLLMDistance * System.Math.Sin(BLLMRadians)
		
		BLLMAdj_Lat = BLLMLat - BLLMCorr_Lat
		
		BLLMAdj_Dep = BLLMDep - BLLMCorr_dep
		
		BLLMTD_North = BLLM_N
		BLLMTD_East = BLLM_E
	End Sub
	Sub Computation()
		Dim x As Object
		RedimArrays()
		For x = 1 To No_of_Corners
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If x = No_of_Corners Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				change_in_lat(x) = Coordinate_N(x) - Coordinate_N(1)
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				change_in_dep(x) = Coordinate_E(x) - Coordinate_E(1)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				change_in_lat(x) = Coordinate_N(x) - Coordinate_N(x + 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				change_in_dep(x) = Coordinate_E(x) - Coordinate_E(x + 1)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If change_in_dep(x) = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If change_in_lat(x) > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					N_S(x) = "South"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					N_S(x) = "North"
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				N_S(x) = ""
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If N_S(x) = "North" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				I(x) = 2
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				I(x) = 0
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If change_in_lat(x) = 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If change_in_dep(x) > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					E_W(x) = "West"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					E_W(x) = "East"
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				E_W(x) = ""
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If E_W(x) = "West" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				K(x) = 1
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf E_W(x) = " " Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				K(x) = 0
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				K(x) = 3
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			L(x) = N_S(x) & E_W(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Distance(x) = System.Math.Sqrt((change_in_lat(x) ^ 2) + (change_in_dep(x) ^ 2)) 'M - Distance
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Distances = Sum_Distances + Distance(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If change_in_lat(x) <> 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				N(x) = System.Math.Atan(change_in_dep(x) / change_in_lat(x))
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			O(x) = System.Math.Abs(N(x) * 180 / pi) 'DEGREES in excel replace with multiplying by 180/pi
			'radians to degrees (x 180/pi)
			'degrees to radians (x pi/180)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			P(x) = VB6.Format(Int(O(x)), "00")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Q(x) = VB6.Format((O(x) - CDbl(P(x))) * 60, "00")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If L(x) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If change_in_lat(x) > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					NS(x) = "S" 'R - N/S
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					NS(x) = "N"
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				NS(x) = ""
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If L(x) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Int(CDbl(Q(x))) = 60 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Deg(x) = VB6.Format(Int(CShort(P(x)) + 1), "00") 'S - Deg
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Deg(x) = VB6.Format(Int(CDbl(P(x))), "00")
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Deg(x) = "due"
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If L(x) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Int(CDbl(Q(x))) = 60 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Min(x) = "00" 'T - Min
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Min(x) = Q(x)
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Min(x) = L(x)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If L(x) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If change_in_dep(x) > 0 Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					EW(x) = "W" 'U - EW
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					EW(x) = "E"
				End If
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				EW(x) = ""
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Deg(x) = "due" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				W(x) = 90 * (I(x) + K(x))
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				W(x) = CDbl(Deg(x)) + (CDbl(Min(x)) / 60)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If NS(x) = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dAzimuth(x) = W(x) 'X - Azimuth
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf NS(x) = "N" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If EW(x) = "E" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dAzimuth(x) = 180 + W(x)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dAzimuth(x) = 180 - W(x)
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ElseIf NS(x) = "S" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If EW(x) = "E" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dAzimuth(x) = 360 - W(x)
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dAzimuth(x) = W(x)
				End If
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dRadians(x) = dAzimuth(x) * pi / 180 'Y - Radians
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Lat(x) = -Distance(x) * System.Math.Cos(dRadians(x)) 'AA - Lat
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Dep(x) = -Distance(x) * System.Math.Sin(dRadians(x)) 'AB - Dep
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Lat = Sum_Lat + Lat(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Dep = Sum_Dep + Dep(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtDistance.Text = CStr(Distance(x))
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtTNS.Text = NS(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtTDeg.Text = Deg(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtTMin.Text = Min(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Me.txtTEW.Text = EW(x)
		Next x
		
		For x = 1 To No_of_Corners
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Corr_Lat(x) = System.Math.Round((Sum_Lat / Sum_Distances) * Distance(x), 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Corr_dep(x) = System.Math.Round((Sum_Dep / Sum_Distances) * Distance(x), 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Corr_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Corr_Lat = Sum_Corr_Lat + Corr_Lat(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Corr_Dep. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Corr_Dep = Sum_Corr_Dep + Corr_dep(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Adj_Lat(x) = Lat(x) - Corr_Lat(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Adj_Dep(x) = Dep(x) - Corr_dep(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Adj_Lat = System.Math.Round(Sum_Adj_Lat + Adj_Lat(x), 2)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Adj_Dep. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_Adj_Dep = System.Math.Round(Sum_Adj_Dep + Adj_Dep(x), 2)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If x = 1 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				TD_North(x) = BLLMTD_North + BLLMAdj_Lat
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				TD_East(x) = BLLMTD_East + BLLMAdj_Dep
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				TD_North(x) = TD_North(x - 1) + Adj_Lat(x - 1)
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				TD_East(x) = TD_East(x - 1) + Adj_Dep(x - 1)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If x = No_of_Corners Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sLine(x) = x & " - 1"
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				sLine(x) = x & " - " & x + 1
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If x = 1 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				DMD(x) = change_in_lat(x)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				DMD(x) = DMD(x - 1) + change_in_lat(x - 1) + change_in_lat(x)
			End If
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DPA(x) = DMD(x) * change_in_dep(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Sum_DPA = Sum_DPA + DPA(x)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			for_plot(x) = Coordinate_E(x) & ", " & Coordinate_N(x)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtChange_in_Lat(x).Text = CStr(DMD(x))
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtChange_in_dep(x).Text = CStr(DPA(x))
		Next x
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		nLec = System.Math.Round(System.Math.Sqrt((Sum_Lat ^ 2) + (Sum_Dep ^ 2)), 15)
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		nRec = System.Math.Round(Sum_Distances / nLec)
		
		nAcc = "1 : " & VB6.Format(nRec, "##,") & "000"
		
		nDoubleArea = System.Math.Abs(Sum_DPA)
		
		nArea = System.Math.Abs(nDoubleArea / 2)
		
		txtDoubleArea.Text = CStr(nDoubleArea)
		txtArea.Text = CStr(nArea)
		txtSum.Text = CStr(nRec)
		txtSum2.Text = CStr(nLec)
		txtNo_of_corners.Text = nAcc
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Lat. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtLat.Text = Sum_Lat
		txtDep.Text = CStr(Sum_Dep)
		'UPGRADE_WARNING: Couldn't resolve default property of object Sum_Distances. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtDistance.Text = Sum_Distances
	End Sub
	
	
	Private Sub Process_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Process.Click
		BLLMComputation()
		Computation()
	End Sub
End Class