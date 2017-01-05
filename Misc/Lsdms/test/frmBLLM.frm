VERSION 5.00
Begin VB.Form frmBLLM 
   Caption         =   "Form1"
   ClientHeight    =   4920
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   11970
   LinkTopic       =   "Form1"
   ScaleHeight     =   4920
   ScaleWidth      =   11970
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtSum2 
      Height          =   375
      Left            =   1440
      TabIndex        =   22
      Top             =   1920
      Width           =   1815
   End
   Begin VB.TextBox txtSum 
      Height          =   375
      Left            =   1440
      TabIndex        =   20
      Top             =   1440
      Width           =   1815
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9000
      TabIndex        =   17
      Top             =   3240
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9000
      TabIndex        =   16
      Top             =   2760
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   9000
      TabIndex        =   15
      Top             =   2280
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   9000
      TabIndex        =   14
      Top             =   1800
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   9000
      TabIndex        =   13
      Top             =   1320
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_dep 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   9000
      TabIndex        =   12
      Top             =   840
      Width           =   1935
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   6240
      TabIndex        =   11
      Top             =   3240
      Width           =   2295
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   6240
      TabIndex        =   10
      Top             =   2760
      Width           =   2295
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   6240
      TabIndex        =   9
      Top             =   2280
      Width           =   2295
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   6240
      TabIndex        =   8
      Top             =   1800
      Width           =   2295
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   6240
      TabIndex        =   7
      Top             =   1320
      Width           =   2295
   End
   Begin VB.TextBox txtChange_in_Lat 
      BeginProperty DataFormat 
         Type            =   1
         Format          =   "0.00"
         HaveTrueFalseNull=   0
         FirstDayOfWeek  =   0
         FirstWeekOfYear =   0
         LCID            =   1033
         SubFormatType   =   1
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   6240
      TabIndex        =   6
      Top             =   840
      Width           =   2295
   End
   Begin VB.TextBox txtNo_of_corners 
      Height          =   375
      Left            =   1440
      TabIndex        =   5
      Top             =   2520
      Width           =   2775
   End
   Begin VB.TextBox txtArea 
      Height          =   375
      Left            =   1440
      TabIndex        =   2
      Top             =   3720
      Width           =   2655
   End
   Begin VB.TextBox txtDoubleArea 
      Height          =   375
      Left            =   1440
      TabIndex        =   1
      Top             =   3120
      Width           =   2655
   End
   Begin VB.CommandButton Process 
      Caption         =   "Process"
      Height          =   735
      Left            =   480
      TabIndex        =   0
      Top             =   240
      Width           =   1575
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ACC"
      Height          =   195
      Index           =   6
      Left            =   720
      TabIndex        =   24
      Top             =   2640
      Width           =   315
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "LEC"
      Height          =   195
      Index           =   5
      Left            =   720
      TabIndex        =   23
      Top             =   2040
      Width           =   300
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "REC"
      Height          =   195
      Index           =   4
      Left            =   720
      TabIndex        =   21
      Top             =   1560
      Width           =   330
   End
   Begin VB.Label Label1 
      Caption         =   "DPA"
      Height          =   255
      Index           =   3
      Left            =   9120
      TabIndex        =   19
      Top             =   360
      Width           =   1815
   End
   Begin VB.Label Label1 
      Caption         =   "DMD"
      Height          =   255
      Index           =   2
      Left            =   6720
      TabIndex        =   18
      Top             =   360
      Width           =   1455
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Area"
      Height          =   195
      Index           =   1
      Left            =   600
      TabIndex        =   4
      Top             =   3840
      Width           =   330
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Double Area"
      Height          =   195
      Index           =   0
      Left            =   360
      TabIndex        =   3
      Top             =   3120
      Width           =   885
   End
End
Attribute VB_Name = "frmBLLM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim cnn As New ADODB.Connection
Dim Coordinate_N() As Double
Dim Coordinate_E() As Double
Dim Stn_Name() As String
Dim No_of_Corners As Integer
Dim Sum_Distances, Sum_Lat, Sum_Dep As Double
Dim Sum_Corr_Lat, Sum_Corr_Dep, Sum_Adj_Lat As Double
Dim Sum_Adj_Dep, Sum_DPA As Double

Dim change_in_lat() As Double
Dim change_in_dep() As Double
Dim N_S() As String
Dim E_W() As String
Dim I() As Integer
Dim K() As Integer
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
Dim nInt As Integer
Dim nRound  As Integer
Sub InitVal()
    pi = 3.14159265358979
    Sum_Distances = 0
    Sum_Lat = 0
    Sum_Dep = 0
    Sum_Corr_Lat = 0
    Sum_Corr_Dep = 0
    Sum_Adj_Lat = 0
    Sum_Adj_Dep = 0
    Sum_DPA = 0
End Sub

Private Sub Form_Load()
    cnn.ConnectionString = "DSN=lsdms;"
    cnn.Open
    LoadCoordinates
    InitVal
End Sub

Private Sub LoadCoordinates()
    Dim rst As New ADODB.Recordset
    Dim x As Integer
    
    rst.Open "select * from tblCoordinates", cnn, adOpenStatic
    If rst.RecordCount > 0 Then
        No_of_Corners = rst.RecordCount - 1
        ReDim Coordinate_N(0 To rst.RecordCount - 1)
        ReDim Coordinate_E(0 To rst.RecordCount - 1)
        ReDim Stn_Name(0 To rst.RecordCount - 1)
        For x = 0 To rst.RecordCount - 1
            Coordinate_N(x) = rst("northing")
            Coordinate_E(x) = rst("easting")
            Stn_Name(x) = rst("stn_name")
            rst.MoveNext
        Next
        rst.Close
    End If
End Sub
Sub RedimArrays()
    ReDim change_in_lat(0 To No_of_Corners)
    ReDim change_in_dep(0 To No_of_Corners)
    ReDim N_S(0 To No_of_Corners)
    ReDim E_W(0 To No_of_Corners)
    ReDim I(0 To No_of_Corners)
    ReDim K(0 To No_of_Corners)
    ReDim L(0 To No_of_Corners)
    ReDim Distance(0 To No_of_Corners)
    ReDim N(0 To No_of_Corners)
    ReDim O(0 To No_of_Corners)
    ReDim P(0 To No_of_Corners)
    ReDim Q(0 To No_of_Corners)
    ReDim Deg(0 To No_of_Corners)
    ReDim Min(0 To No_of_Corners)
    ReDim EW(0 To No_of_Corners)
    ReDim NS(0 To No_of_Corners)
    ReDim W(0 To No_of_Corners)
    ReDim dAzimuth(0 To No_of_Corners)
    ReDim dRadians(0 To No_of_Corners)
    ReDim Lat(0 To No_of_Corners)
    ReDim Dep(0 To No_of_Corners)
    ReDim Corr_Lat(0 To No_of_Corners)
    ReDim Corr_dep(0 To No_of_Corners)
    ReDim Adj_Lat(0 To No_of_Corners)
    ReDim Adj_Dep(0 To No_of_Corners)
    ReDim TD_North(0 To No_of_Corners)
    ReDim TD_East(0 To No_of_Corners)
    ReDim sLine(0 To No_of_Corners)
    ReDim DMD(0 To No_of_Corners)
    ReDim DPA(0 To No_of_Corners)
    ReDim for_plot(0 To No_of_Corners)
End Sub
Sub Computation()
    RedimArrays
    For x = 0 To No_of_Corners
        If x <> 0 And x = No_of_Corners Then
            change_in_lat(x) = Coordinate_N(x) - Coordinate_N(1)
            change_in_dep(x) = Coordinate_E(x) - Coordinate_E(1)
        Else
            change_in_lat(x) = Coordinate_N(x) - Coordinate_N(x + 1)
            change_in_dep(x) = Coordinate_E(x) - Coordinate_E(x + 1)
        End If
        
        If change_in_dep(x) = 0 Then
            If change_in_lat(x) > 0 Then
                N_S(x) = "South"
            Else
                N_S(x) = "North"
            End If
        Else
            N_S(x) = ""
        End If
        
        If N_S(x) = "North" Then
            I(x) = 2
        Else
            I(x) = 0
        End If
        
        If change_in_lat(x) = 0 Then
            If change_in_dep(x) > 0 Then
                E_W(x) = "West"
            Else
                E_W(x) = "East"
            End If
        Else
            E_W(x) = ""
        End If
    
        If E_W(x) = "West" Then
            K(x) = 1
        ElseIf E_W(x) = " " Then
            K(x) = 0
        Else
            K(x) = 3
        End If
    
        L(x) = N_S(x) & E_W(x)
    
        Distance(x) = Sqr((change_in_lat(x) ^ 2) + (change_in_dep(x) ^ 2))

        If x = 0 Then
            Sum_Distances = 0
        Else
            Sum_Distances = Sum_Distances + Distance(x)
        End If
    
        If change_in_lat(x) <> 0 Then
            N(x) = Atn(change_in_dep(x) / change_in_lat(x))
        End If
        
        O(x) = Abs(N(x) * 180 / pi)     'DEGREES in excel replace with multiplying by 180/pi
                                        'radians to degrees (x 180/pi)
                                        'degrees to radians (x pi/180)
    
        P(x) = Format(Int(O(x)), "00")
        
        Q(x) = Format((O(x) - CDbl(P(x))) * 60, "00")

        If L(x) = "" Then
            If change_in_lat(x) > 0 Then
                NS(x) = "S"
            Else
                NS(x) = "N"
            End If
        Else
            NS(x) = ""
        End If

        If L(x) = "" Then
            If Int(Q(x)) = 60 Then
                Deg(x) = Format(Int(CInt(P(x)) + 1), "00")
            Else
                Deg(x) = Format(Int(P(x)), "00")
            End If
        Else
            Deg(x) = "due"
        End If

        If L(x) = "" Then
            If Int(Q(x)) = 60 Then
                Min(x) = "00"
            Else
                Min(x) = Q(x)
            End If
        Else
            Min(x) = L(x)
        End If
        
        If L(x) = "" Then
            If change_in_dep(x) > 0 Then
                EW(x) = "W"
            Else
                EW(x) = "E"
            End If
        Else
            EW(x) = ""
        End If
    
        If Deg(x) = "due" Then
            W(x) = 90 * (I(x) + K(x))
        Else
            W(x) = CDbl(Deg(x)) + (Min(x) / 60)
        End If
        
        If NS(x) = "" Then
            dAzimuth(x) = W(x)
        ElseIf NS(x) = "N" Then
            If EW(x) = "E" Then
                dAzimuth(x) = 180 + W(x)
            Else
                dAzimuth(x) = 180 - W(x)
            End If
        ElseIf NS(x) = "S" Then
            If EW(x) = "E" Then
                dAzimuth(x) = 360 - W(x)
            Else
                dAzimuth(x) = W(x)
            End If
        End If
        
        dRadians(x) = dAzimuth(x) * pi / 180

        Lat(x) = -Distance(x) * Cos(dRadians(x))
    
        Dep(x) = -Distance(x) * Sin(dRadians(x))
        
        If x = 0 Then
            Sum_Lat = 0
            Sum_Dep = 0
        Else
            Sum_Lat = Sum_Lat + Lat(x)
            Sum_Dep = Sum_Dep + Dep(x)
        End If
                   
    Next x
    
    For x = 0 To No_of_Corners
        If x = 0 Then
            Corr_Lat(x) = 0
            Sum_Corr_Lat = 0
            Corr_dep(x) = 0
            Sum_Corr_Dep = 0
        Else
            Corr_Lat(x) = Round((Sum_Lat / Sum_Distances) * Distance(x), 2)
            Corr_dep(x) = Round((Sum_Dep / Sum_Distances) * Distance(x), 2)
            Sum_Corr_Lat = Sum_Corr_Lat + Corr_Lat(x)
            Sum_Corr_Dep = Sum_Corr_Dep + Corr_dep(x)
        End If
        
        Adj_Lat(x) = Lat(x) - Corr_Lat(x)
    
        Adj_Dep(x) = Dep(x) - Corr_dep(x)
    
        If x = 0 Then
            Sum_Adj_Lat = 0
            Sum_Adj_Dep = 0
        Else
            Sum_Adj_Lat = Round(Sum_Adj_Lat + Adj_Lat(x), 2)
            Sum_Adj_Dep = Round(Sum_Adj_Dep + Adj_Dep(x), 2)
        End If
    
        If x = 0 Then
            TD_North(x) = Coordinate_N(x)
            TD_East(x) = Coordinate_E(x)
        Else
            TD_North(x) = TD_North(x - 1) + Adj_Lat(x - 1)
            TD_East(x) = TD_East(x - 1) + Adj_Dep(x - 1)
        End If
    
        If x = 0 Then
            sLine(x) = Trim(Stn_Name(x)) & " - 1"
        ElseIf x = No_of_Corners Then
            sLine(x) = x & " - 1"
        Else
            sLine(x) = x & " - " & x + 1
        End If
    
        If x = 0 Then
            DMD(x) = 0
        ElseIf x = 1 Then
            DMD(x) = change_in_lat(x)
        Else
            DMD(x) = DMD(x - 1) + change_in_lat(x - 1) + change_in_lat(x)
        End If
        
        If x <> 0 Then
            DPA(x) = DMD(x) * change_in_dep(x)
            Sum_DPA = Sum_DPA + DPA(x)
            for_plot(x) = Coordinate_E(x) & ", " & Coordinate_N(x)
        End If
        
        txtChange_in_Lat(x) = DMD(x)
        txtChange_in_dep(x) = DPA(x)
    Next x
    
    nLec = Sqr((Sum_Lat ^ 2) + (Sum_Dep ^ 2))

    nRec = Round(Sum_Distances / nLec)
    nInt = Int(nRec)
    nRound = Format(nRec, "##,") + "000"
    nAcc = "1 : " & Format(nRec, "##,") + "000"
    
    nDoubleArea = Abs(Sum_DPA)
    
    nArea = Abs(nDoubleArea / 2)
    
    txtDoubleArea = nDoubleArea
    txtArea = nArea
    txtSum = nRec
    txtSum2 = nLec
    txtNo_of_corners = nAcc
End Sub


Private Sub Process_Click()
    Computation
End Sub
