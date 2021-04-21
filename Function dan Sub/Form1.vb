Public Class Form1

    Public Sub Maklumat()
        lblPapar1.Text = "Aisyah Aliesyah"
    End Sub
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Maklumat()
    End Sub

    Public Sub Info(ByVal strNamaPenuh As String)
        lblPapar2.Text = strNamaPenuh
    End Sub
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Call Info(txt1.Text)
    End Sub

    Public Function Nama()
        lblPapar3.Text = "Aisyah"
        Return lblPapar1
    End Function
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Call Nama()
    End Sub

    Public Function Papar(ByVal strNamaPenuh As String)
        lblPapar4.Text = strNamaPenuh
    End Function
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Call Papar(txt2.Text)
    End Sub

End Class
