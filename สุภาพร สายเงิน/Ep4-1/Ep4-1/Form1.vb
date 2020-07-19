Public Class Form1
    Dim Point, Grade As String

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Point = TextBox1.Text
        If Point >= 80 Then
            Grade = "A"
        ElseIf Point >= 70 Then
            Grade = "B"
        ElseIf Point >= 60 Then
            Grade = "C"
        Else
            Grade = "F"
        End If
        Label2.Text = Grade
    End Sub
End Class
