VERSION 5.00
Begin VB.Form frmNoBllm 
   Caption         =   "Form1"
   ClientHeight    =   7500
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   13875
   LinkTopic       =   "Form1"
   ScaleHeight     =   7500
   ScaleWidth      =   13875
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   5
      Left            =   7920
      TabIndex        =   65
      Top             =   4080
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   5
      Left            =   7080
      TabIndex        =   64
      Top             =   4080
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   5
      Left            =   6360
      TabIndex        =   63
      Top             =   4080
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   5
      Left            =   5640
      TabIndex        =   62
      Top             =   4080
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   5
      Left            =   4320
      TabIndex        =   61
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   4
      Left            =   7920
      TabIndex        =   60
      Top             =   3600
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   4
      Left            =   7080
      TabIndex        =   59
      Top             =   3600
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   4
      Left            =   6360
      TabIndex        =   58
      Top             =   3600
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   4
      Left            =   5640
      TabIndex        =   57
      Top             =   3600
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   4
      Left            =   4320
      TabIndex        =   56
      Top             =   3600
      Width           =   1095
   End
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   3
      Left            =   7920
      TabIndex        =   55
      Top             =   3120
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   3
      Left            =   7080
      TabIndex        =   54
      Top             =   3120
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   3
      Left            =   6360
      TabIndex        =   53
      Top             =   3120
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   3
      Left            =   5640
      TabIndex        =   52
      Top             =   3120
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   3
      Left            =   4320
      TabIndex        =   51
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   2
      Left            =   7920
      TabIndex        =   50
      Top             =   2640
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   2
      Left            =   7080
      TabIndex        =   49
      Top             =   2640
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   2
      Left            =   6360
      TabIndex        =   48
      Top             =   2640
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   2
      Left            =   5640
      TabIndex        =   47
      Top             =   2640
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   2
      Left            =   4320
      TabIndex        =   46
      Top             =   2640
      Width           =   1095
   End
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   1
      Left            =   7920
      TabIndex        =   45
      Top             =   2160
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   1
      Left            =   7080
      TabIndex        =   44
      Top             =   2160
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   1
      Left            =   6360
      TabIndex        =   43
      Top             =   2160
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   1
      Left            =   5640
      TabIndex        =   42
      Top             =   2160
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   1
      Left            =   4320
      TabIndex        =   41
      Top             =   2160
      Width           =   1095
   End
   Begin VB.TextBox txtTEW 
      Height          =   375
      Index           =   0
      Left            =   7920
      TabIndex        =   40
      Top             =   1680
      Width           =   375
   End
   Begin VB.TextBox txtTMin 
      Height          =   375
      Index           =   0
      Left            =   7080
      TabIndex        =   39
      Top             =   1680
      Width           =   495
   End
   Begin VB.TextBox txtTDeg 
      Height          =   375
      Index           =   0
      Left            =   6360
      TabIndex        =   38
      Top             =   1680
      Width           =   495
   End
   Begin VB.TextBox txtTNS 
      Height          =   375
      Index           =   0
      Left            =   5640
      TabIndex        =   37
      Top             =   1680
      Width           =   375
   End
   Begin VB.TextBox txtTDistance 
      Height          =   375
      Index           =   0
      Left            =   4320
      TabIndex        =   36
      Top             =   1680
      Width           =   1095
   End
   Begin VB.TextBox txtDistance 
      Height          =   375
      Left            =   1200
      TabIndex        =   29
      Top             =   5040
      Width           =   2175
   End
   Begin VB.TextBox txtDep 
      Height          =   375
      Left            =   1200
      TabIndex        =   27
      Top             =   4560
      Width           =   2175
   End
   Begin VB.TextBox txtLat 
      Height          =   375
      Left            =   1200
      TabIndex        =   25
      Top             =   4080
      Width           =   2175
   End
   Begin VB.TextBox txtSum2 
      Height          =   375
      Left            =   1200
      TabIndex        =   22
      Top             =   1680
      Width           =   1815
   End
   Begin VB.TextBox txtSum 
      Height          =   375
      Left            =   1200
      TabIndex        =   20
      Top             =   1200
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
      Left            =   11640
      TabIndex        =   17
      Top             =   4080
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
      Left            =   11640
      TabIndex        =   16
      Top             =   3600
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
      Left            =   11640
      TabIndex        =   15
      Top             =   3120
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
      Left            =   11640
      TabIndex        =   14
      Top             =   2640
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
      Left            =   11640
      TabIndex        =   13
      Top             =   2160
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
      Left            =   11640
      TabIndex        =   12
      Top             =   1680
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
      Left            =   8880
      TabIndex        =   11
      Top             =   4080
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
      Left            =   8880
      TabIndex        =   10
      Top             =   3600
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
      Left            =   8880
      TabIndex        =   9
      Top             =   3120
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
      Left            =   8880
      TabIndex        =   8
      Top             =   2640
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
      Left            =   8880
      TabIndex        =   7
      Top             =   2160
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
      Left            =   8880
      TabIndex        =   6
      Top             =   1680
      Width           =   2295
   End
   Begin VB.TextBox txtNo_of_corners 
      Height          =   375
      Left            =   1200
      TabIndex        =   5
      Top             =   2280
      Width           =   2775
   End
   Begin VB.TextBox txtArea 
      Height          =   375
      Left            =   1200
      TabIndex        =   2
      Top             =   3480
      Width           =   2655
   End
   Begin VB.TextBox txtDoubleArea 
      Height          =   375
      Left            =   1200
      TabIndex        =   1
      Top             =   2880
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
      Caption         =   "Distance"
      Height          =   255
      Index           =   14
      Left            =   4560
      TabIndex        =   35
      Top             =   1200
      Width           =   735
   End
   Begin VB.Label Label1 
      Caption         =   "NS"
      Height          =   255
      Index           =   13
      Left            =   5640
      TabIndex        =   34
      Top             =   1200
      Width           =   375
   End
   Begin VB.Label Label1 
      Caption         =   "Deg"
      Height          =   255
      Index           =   12
      Left            =   6360
      TabIndex        =   33
      Top             =   1200
      Width           =   375
   End
   Begin VB.Label Label1 
      Caption         =   "Min"
      Height          =   255
      Index           =   11
      Left            =   7080
      TabIndex        =   32
      Top             =   1200
      Width           =   375
   End
   Begin VB.Label Label1 
      Caption         =   "EW"
      Height          =   255
      Index           =   10
      Left            =   7800
      TabIndex        =   31
      Top             =   1200
      Width           =   375
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Sum distances"
      Height          =   315
      Index           =   9
      Left            =   240
      TabIndex        =   30
      Top             =   5160
      Width           =   1035
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Sum dep"
      Height          =   195
      Index           =   8
      Left            =   240
      TabIndex        =   28
      Top             =   4680
      Width           =   630
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Sum lat"
      Height          =   195
      Index           =   7
      Left            =   360
      TabIndex        =   26
      Top             =   4200
      Width           =   525
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "ACC"
      Height          =   195
      Index           =   6
      Left            =   360
      TabIndex        =   24
      Top             =   2400
      Width           =   315
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "LEC"
      Height          =   195
      Index           =   5
      Left            =   360
      TabIndex        =   23
      Top             =   1800
      Width           =   300
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "REC"
      Height          =   195
      Index           =   4
      Left            =   360
      TabIndex        =   21
      Top             =   1320
      Width           =   330
   End
   Begin VB.Label Label1 
      Caption         =   "DPA"
      Height          =   255
      Index           =   3
      Left            =   11760
      TabIndex        =   19
      Top             =   1200
      Width           =   1815
   End
   Begin VB.Label Label1 
      Caption         =   "DMD"
      Height          =   255
      Index           =   2
      Left            =   9360
      TabIndex        =   18
      Top             =   1200
      Width           =   1455
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Area"
      Height          =   195
      Index           =   1
      Left            =   240
      TabIndex        =   4
      Top             =   3600
      Width           =   330
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "Double Area"
      Height          =   195
      Index           =   0
      Left            =   0
      TabIndex        =   3
      Top             =   2880
      Width           =   885
   End
End
Attribute VB_Name = "frmNoBllm"
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

'for Bllm
Dim BLLM_N As Double
Dim BLLM_E As Double
Dim BLLMchange_in_lat As Double
Dim BLLMchange_in_dep As Double
Dim BLLMN_S As String
Dim BLLME_W As String
Dim BLLMI As Integer
Dim BLLMK As Integer
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
    BLLM_N = 721228.62      'Reference pt - northing
    BLLM_E = 462450.22      'Reference pt - easting
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
    
    rst.Open "select * from tblCoordinates where lot_no='2130' order by stn_name", cnn, adOpenStatic
    If rst.RecordCount > 0 Then
        No_of_Corners = rst.RecordCount
        ReDim Coordinate_N(1 To rst.RecordCount)
        ReDim Coordinate_E(1 To rst.RecordCount)
        ReDim Stn_Name(1 To rst.RecordCount)
        For x = 1 To rst.RecordCount
            Coordinate_N(x) = rst("northing")
            Coordinate_E(x) = rst("easting")
            Stn_Name(x) = rst("stn_name")
            rst.MoveNext
        Next
        rst.Close
    End If
End Sub
Sub RedimArrays()
    ReDim change_in_lat(1 To No_of_Corners)
    ReDim change_in_dep(1 To No_of_Corners)
    ReDim N_S(1 To No_of_Corners)
    ReDim E_W(1 To No_of_Corners)
    ReDim I(1 To No_of_Corners)
    ReDim K(1 To No_of_Corners)
    ReDim L(1 To No_of_Corners)
    ReDim Distance(1 To No_of_Corners)
    ReDim N(1 To No_of_Corners)
    ReDim O(1 To No_of_Corners)
    ReDim P(1 To No_of_Corners)
    ReDim Q(1 To No_of_Corners)
    ReDim Deg(1 To No_of_Corners)
    ReDim Min(1 To No_of_Corners)
    ReDim EW(1 To No_of_Corners)
    ReDim NS(1 To No_of_Corners)
    ReDim W(1 To No_of_Corners)
    ReDim dAzimuth(1 To No_of_Corners)
    ReDim dRadians(1 To No_of_Corners)
    ReDim Lat(1 To No_of_Corners)
    ReDim Dep(1 To No_of_Corners)
    ReDim Corr_Lat(1 To No_of_Corners)
    ReDim Corr_dep(1 To No_of_Corners)
    ReDim Adj_Lat(1 To No_of_Corners)
    ReDim Adj_Dep(1 To No_of_Corners)
    ReDim TD_North(1 To No_of_Corners)
    ReDim TD_East(1 To No_of_Corners)
    ReDim sLine(1 To No_of_Corners)
    ReDim DMD(1 To No_of_Corners)
    ReDim DPA(1 To No_of_Corners)
    ReDim for_plot(1 To No_of_Corners)
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

    BLLMDistance = Sqr((BLLMchange_in_lat ^ 2) + (BLLMchange_in_dep ^ 2))   'M - Distance
    
    If BLLMchange_in_lat <> 0 Then
        BLLMN = Atn(BLLMchange_in_dep / BLLMchange_in_lat)
    End If
    
    BLLMO = Abs(BLLMN * 180 / pi)     'DEGREES in excel replace with multiplying by 180/pi
                                    'radians to degrees (x 180/pi)
                                    'degrees to radians (x pi/180)

    BLLMP = Format(Int(BLLMO), "00")
    
    BLLMQ = Format((BLLMO - CDbl(BLLMP)) * 60, "00")

    If BLLML = "" Then
        If BLLMchange_in_lat > 0 Then
            BLLMNS = "S"                    'R - N/S
        Else
            BLLMNS = "N"
        End If
    Else
        BLLMNS = ""
    End If

    If BLLML = "" Then
        If Int(BLLMQ) = 60 Then
            BLLMDeg = Format(Int(CInt(BLLMP) + 1), "00")        'S - Deg
        Else
            BLLMDeg = Format(Int(BLLMP), "00")
        End If
    Else
        BLLMDeg = "due"
    End If

    If BLLML = "" Then
        If Int(BLLMQ) = 60 Then
            BLLMMin = "00"                                      'T - Min
        Else
            BLLMMin = BLLMQ
        End If
    Else
        BLLMMin = BLLML
    End If
    
    If BLLML = "" Then
        If BLLMchange_in_dep > 0 Then
            BLLMEW = "W"                                       'U - EW
        Else
            BLLMEW = "E"
        End If
    Else
        BLLMEW = ""
    End If

    If BLLMDeg = "due" Then
        BLLMW = 90 * (BLLMI + BLLMK)
    Else
        BLLMW = CDbl(BLLMDeg) + (BLLMMin / 60)
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

    BLLMLat = -BLLMDistance * Cos(BLLMRadians)

    BLLMDep = -BLLMDistance * Sin(BLLMRadians)
    
    BLLMAdj_Lat = BLLMLat - BLLMCorr_Lat
    
    BLLMAdj_Dep = BLLMDep - BLLMCorr_dep
    
    BLLMTD_North = BLLM_N
    BLLMTD_East = BLLM_E
End Sub
Sub Computation()
    RedimArrays
    For x = 1 To No_of_Corners
        If x = No_of_Corners Then
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
    
        Distance(x) = Sqr((change_in_lat(x) ^ 2) + (change_in_dep(x) ^ 2))      'M - Distance

        Sum_Distances = Sum_Distances + Distance(x)
    
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
                NS(x) = "S"                                 'R - N/S
            Else
                NS(x) = "N"
            End If
        Else
            NS(x) = ""
        End If

        If L(x) = "" Then
            If Int(Q(x)) = 60 Then
                Deg(x) = Format(Int(CInt(P(x)) + 1), "00")      'S - Deg
            Else
                Deg(x) = Format(Int(P(x)), "00")
            End If
        Else
            Deg(x) = "due"
        End If

        If L(x) = "" Then
            If Int(Q(x)) = 60 Then
                Min(x) = "00"                           'T - Min
            Else
                Min(x) = Q(x)
            End If
        Else
            Min(x) = L(x)
        End If
        
        If L(x) = "" Then
            If change_in_dep(x) > 0 Then
                EW(x) = "W"                         'U - EW
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
            dAzimuth(x) = W(x)              'X - Azimuth
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
        
        dRadians(x) = dAzimuth(x) * pi / 180        'Y - Radians

        Lat(x) = -Distance(x) * Cos(dRadians(x))    'AA - Lat
    
        Dep(x) = -Distance(x) * Sin(dRadians(x))    'AB - Dep
        
        Sum_Lat = Sum_Lat + Lat(x)
        Sum_Dep = Sum_Dep + Dep(x)
                         
        txtTDistance(x) = Distance(x)
        txtTNS(x) = NS(x)
        txtTDeg(x) = Deg(x)
        txtTMin(x) = Min(x)
        txtTEW(x) = EW(x)
    Next x
    
    For x = 1 To No_of_Corners
        Corr_Lat(x) = Round((Sum_Lat / Sum_Distances) * Distance(x), 2)
        Corr_dep(x) = Round((Sum_Dep / Sum_Distances) * Distance(x), 2)
        Sum_Corr_Lat = Sum_Corr_Lat + Corr_Lat(x)
        Sum_Corr_Dep = Sum_Corr_Dep + Corr_dep(x)
                
        Adj_Lat(x) = Lat(x) - Corr_Lat(x)
    
        Adj_Dep(x) = Dep(x) - Corr_dep(x)
    
        Sum_Adj_Lat = Round(Sum_Adj_Lat + Adj_Lat(x), 2)
        Sum_Adj_Dep = Round(Sum_Adj_Dep + Adj_Dep(x), 2)
           
        If x = 1 Then
            TD_North(x) = BLLMTD_North + BLLMAdj_Lat
            TD_East(x) = BLLMTD_East + BLLMAdj_Dep
        Else
            TD_North(x) = TD_North(x - 1) + Adj_Lat(x - 1)
            TD_East(x) = TD_East(x - 1) + Adj_Dep(x - 1)
        End If
        
        If x = No_of_Corners Then
            sLine(x) = x & " - 1"
        Else
            sLine(x) = x & " - " & x + 1
        End If
    
        If x = 1 Then
            DMD(x) = change_in_lat(x)
        Else
            DMD(x) = DMD(x - 1) + change_in_lat(x - 1) + change_in_lat(x)
        End If
        
        DPA(x) = DMD(x) * change_in_dep(x)
        Sum_DPA = Sum_DPA + DPA(x)
        for_plot(x) = Coordinate_E(x) & ", " & Coordinate_N(x)
        
        txtChange_in_Lat(x) = DMD(x)
        txtChange_in_dep(x) = DPA(x)
    Next x
    
    nLec = Round(Sqr((Sum_Lat ^ 2) + (Sum_Dep ^ 2)), 15)

    nRec = Round(Sum_Distances / nLec)

    nAcc = "1 : " & Format(nRec, "##,") + "000"
    
    nDoubleArea = Abs(Sum_DPA)
    
    nArea = Abs(nDoubleArea / 2)
    
    txtDoubleArea = nDoubleArea
    txtArea = nArea
    txtSum = nRec
    txtSum2 = nLec
    txtNo_of_corners = nAcc
    txtLat = Sum_Lat
    txtDep = Sum_Dep
    txtDistance = Sum_Distances
End Sub


Private Sub Process_Click()
    BLLMComputation
    Computation
End Sub
