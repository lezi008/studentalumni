Imports System.IO

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String = txtUsername.Text.Trim()
        Dim Password As String = txtPassword.Text.Trim()
        Dim isAuthenticated As Boolean = False


        Dim filePath As String = Path.Combine(Application.StartupPath, "C:\Users\user123\source\repos\StudentAlumni\StudentAlumni\users.txt")


        If File.Exists(filePath) Then
            Dim lines() As String = File.ReadAllLines(filePath)


            For Each line In lines
                Dim credentials() As String = line.Split(","c)
                If credentials.Length = 2 Then
                    Dim fileUsername As String = credentials(0).Trim()
                    Dim filePassword As String = credentials(1).Trim()

                    If fileUsername = Username AndAlso filePassword = Password Then
                        isAuthenticated = True
                        Exit For
                    End If
                End If
            Next
        Else
            MessageBox.Show("User file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        If isAuthenticated Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
