Public Class Form1

    Public Sub Maklumat()
        lblPapar1.Text = "Aisyah Aliesyah"
    End Sub

    Public Sub Info()
        Dim strNamaPenuh As String
        strNamaPenuh = txt1.Text
        lblPapar2.Text = strNamaPenuh
    End Sub

    Public Function Nama()
        lblPapar3.Text = "Aisyah"
        Return lblPapar1
    End Function

    Public Function Papar()
        Dim strNamaPenuh As String
        strNamaPenuh = txt2.Text
        lblPapar4.Text = strNamaPenuh
        Return lblPapar4
    End Function

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Maklumat()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Call Info()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Call Nama()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Call Papar()
    End Sub


End Class
