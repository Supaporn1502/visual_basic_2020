Public Class Form1
    Dim Price, Num, tel, jai, Sudit As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Price = TextBox1.Text
        Num = TextBox2.Text
        tel = Price * Num
        Label4.Text = tel

        jai = TextBox3.Text
        Sudit = jai - tel
        Label7.Text = Sudit
    End Sub
End Class
