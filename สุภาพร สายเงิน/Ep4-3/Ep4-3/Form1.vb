Public Class Form1
    Dim Price, Num, Total As String
    Dim steam As Byte

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text
        Total = Price * Num
        Label5.Text = Total
        steam = Total / 50
        Label6.Text = steam
    End Sub
End Class
