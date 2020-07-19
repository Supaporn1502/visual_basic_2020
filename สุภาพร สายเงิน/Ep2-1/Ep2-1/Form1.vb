Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FristName As String
        FristName = "Supaporn"
        Label1.Text = FristName
        FristName = "Saingoen"
        Label2.Text = FristName
        FristName = "Aom"
        Label3.Text = FristName

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        Label1.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim prompt, FullName As String
        prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(prompt)
        MsgBox(FullName,, "ชื่อและนามสกุลของคุณ")
    End Sub
End Class
