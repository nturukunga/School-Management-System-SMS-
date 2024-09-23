Imports System.Data.Odbc
Public Class Dashboard
    Public Property HighlightOnButtonPosition As Object

    Private Sub ShowPanel(panelToShow As Panel)
        ' Hide all panels first
        PanelTeachers.Visible = False
        PanelStudents.Visible = False
        PanelPayments.Visible = False
        PanelDebts.Visible = False
        PanelAttendance.Visible = False
        PanelParents.Visible = False
        PanelGrading.Visible = False

        ' Show the selected panel
        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub TeachersBtn_Click(sender As Object, e As EventArgs) Handles TeachersBtn.Click
        ShowPanel(PanelTeachers)
    End Sub

    Private Sub StudentsBtn_Click(sender As Object, e As EventArgs) Handles StudentsBtn.Click
        ShowPanel(PanelStudents)
    End Sub

    Private Sub DebtsBtn_Click(sender As Object, e As EventArgs) Handles DebtsBtn.Click
        ShowPanel(PanelDebts)
    End Sub

    Private Sub AttendanceBtn_Click(sender As Object, e As EventArgs) Handles AttendanceBtn.Click
        ShowPanel(PanelAttendance)
    End Sub

    Private Sub PaymentsBtn_Click(sender As Object, e As EventArgs) Handles PaymentsBtn.Click
        ShowPanel(PanelPayments)
    End Sub

    Private Sub GradingBtn_Click(sender As Object, e As EventArgs) Handles GradingBtn.Click
        ShowPanel(PanelGrading)
    End Sub

    Private Sub ParentsBtn_Click(sender As Object, e As EventArgs) Handles ParentsBtn.Click
        ShowPanel(PanelParents)
    End Sub

    Private Sub ClassesBtn_Click(sender As Object, e As EventArgs) Handles ClassesBtn.Click
        ShowPanel(PanelClasses)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show the Main panel as default
        ShowPanel(PanelMain) ' Change this to the panel you want as default
    End Sub

End Class