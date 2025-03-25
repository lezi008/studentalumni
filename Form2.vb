Public Class Form2
    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()
    End Sub

    Private Sub btnSeeBatch_Click(sender As Object, e As EventArgs) Handles btnSeeBatch.Click
        Dim form4 As New Form4()
        form4.Show()
    End Sub


    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        Dim form3 As New Form3()
        form3.Show()
    End Sub
End Class
