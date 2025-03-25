Imports System.IO

Public Class Form5
    Public Sub SetStudentInfo(name As String, email As String, city As String, achievements As String, jobs As String, education As String, imagePath As String)

        TextBox1.Text = name
        TextBox2.Text = email
        TextBox3.Text = city

        ListBoxAchievements.Items.Clear()
        If Not String.IsNullOrEmpty(achievements) Then
            ListBoxAchievements.Items.AddRange(achievements.Split("|"c))
        End If

        ListBoxJobs.Items.Clear()
        If Not String.IsNullOrEmpty(jobs) Then
            ListBoxJobs.Items.AddRange(jobs.Split("|"c))
        End If

        ListBoxEducation.Items.Clear()
        If Not String.IsNullOrEmpty(education) Then
            ListBoxEducation.Items.AddRange(education.Split("|"c))
        End If


        Try
            If File.Exists(imagePath) Then

                Using tempImage As Image = Image.FromFile(imagePath)
                    PictureBox1.Image = New Bitmap(tempImage)
                End Using
            Else

                Dim defaultImagePath As String = Application.StartupPath & "C:\Users\user123\source\repos\StudentAlumni\StudentAlumni\STUDENT IMAGES"
                If File.Exists(defaultImagePath) Then
                    PictureBox1.Image = Image.FromFile(defaultImagePath)
                Else
                    MessageBox.Show("⚠ Student image and default image not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    PictureBox1.Image = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
