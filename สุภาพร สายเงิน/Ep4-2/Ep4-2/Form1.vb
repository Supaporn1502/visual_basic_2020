Public Class Form1
    Dim UserName As String
    Dim Password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserName As String
        UserName = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาใส่รหัสผ่าน")
        If UserName = "ออม" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-16\Desktop\สุภาพร\All_Images\All_Images/ChaiYo.jpg")
        ElseIf UserName = "สุภาพร" And Password = "11111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-16\Desktop/6.Jpg")
        ElseIf UserName = "หมูขนุน" And Password = "22222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-16\Desktop/7.jpg")
        ElseIf UserName = "เต่า" And Password = "33333" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-16\Desktop/8.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
