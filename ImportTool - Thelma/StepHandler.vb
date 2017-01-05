Imports ComponentFactory.Krypton.Toolkit

Public Class StepHandler

    Dim StepPanel As New List(Of KryptonPanel)

    Sub New(ByVal ParamArray stepPanels() As KryptonPanel)
        Dim panel As KryptonPanel

        For Each panel In stepPanels
            StepPanel.Add(panel)
            panel.Hide()
        Next

    End Sub

    Public Sub Show(ByVal panelToShow As KryptonPanel)
        Dim panel As KryptonPanel

        For Each panel In StepPanel
            If panel.Equals(panelToShow) Then
                panel.Show()
                panel.Refresh()
            Else
                panel.Hide()
            End If
        Next

    End Sub




End Class
