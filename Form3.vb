Imports System.IO

Public Class Form3
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Dim LRN As String = TextBox1.Text.Trim()
        Dim filePath As String = "C:\Users\user123\source\repos\StudentAlumni\StudentAlumni\users.txt"
        Dim imageFolderPath As String = Application.StartupPath & "C:\Users\user123\source\repos\StudentAlumni\StudentAlumni\STUDENT IMAGES" ' Image directory


        If String.IsNullOrWhiteSpace(LRN) Then
            MessageBox.Show("Please enter a valid Student Number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not File.Exists(filePath) Then
            MessageBox.Show("Database file users.txt not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim lines As String() = File.ReadAllLines(filePath)
        Dim found As Boolean = False

        For Each line As String In lines
            Dim data As String() = line.Split(","c)


            If data.Length >= 8 Then
                Dim recordLRN As String = data(0).Trim()


                If recordLRN = LRN Then
                    Dim name As String = data(1).Trim()
                    Dim email As String = data(2).Trim()
                    Dim city As String = data(3).Trim()
                    Dim achievements As String = data(4).Trim()
                    Dim jobs As String = data(5).Trim()
                    Dim education As String = data(6).Trim()
                    Dim imageFileName As String = data(7).Trim()


                    Dim imagePath As String = Path.Combine(imageFolderPath, imageFileName)


                    If Not File.Exists(imagePath) Then
                        MessageBox.Show("⚠ Student image not found: " & imagePath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        imagePath = imageFolderPath & "default.jpg"
                    End If


                    Dim form5 As New Form5()
                    form5.SetStudentInfo(name, email, city, achievements, jobs, education, imagePath)
                    form5.Show()
                    found = True
                    Exit For
                End If
            End If
        Next


        If Not found Then
            MessageBox.Show("❌ Student with LRN " & LRN & " not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
