<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ListBoxAchievements = New ListBox()
        ListBoxJobs = New ListBox()
        ListBoxEducation = New ListBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(25, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(288, 185)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(386, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 21)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(389, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 2
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(389, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 21)
        Label3.TabIndex = 3
        Label3.Text = "City:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(109, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 21)
        Label4.TabIndex = 4
        Label4.Text = "Achievements:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(177, 327)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 21)
        Label5.TabIndex = 5
        Label5.Text = "Job:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(131, 427)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 21)
        Label6.TabIndex = 6
        Label6.Text = "Education:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(492, 23)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 23)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(492, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(492, 150)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(287, 23)
        TextBox3.TabIndex = 9
        ' 
        ' ListBoxAchievements
        ' 
        ListBoxAchievements.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxAchievements.FormattingEnabled = True
        ListBoxAchievements.ItemHeight = 15
        ListBoxAchievements.Location = New Point(266, 227)
        ListBoxAchievements.Name = "ListBoxAchievements"
        ListBoxAchievements.Size = New Size(487, 94)
        ListBoxAchievements.TabIndex = 10
        ' 
        ' ListBoxJobs
        ' 
        ListBoxJobs.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxJobs.FormattingEnabled = True
        ListBoxJobs.ItemHeight = 15
        ListBoxJobs.Location = New Point(266, 327)
        ListBoxJobs.Name = "ListBoxJobs"
        ListBoxJobs.Size = New Size(487, 94)
        ListBoxJobs.TabIndex = 11
        ' 
        ' ListBoxEducation
        ' 
        ListBoxEducation.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ListBoxEducation.FormattingEnabled = True
        ListBoxEducation.ItemHeight = 15
        ListBoxEducation.Location = New Point(266, 427)
        ListBoxEducation.Name = "ListBoxEducation"
        ListBoxEducation.Size = New Size(487, 94)
        ListBoxEducation.TabIndex = 12
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(811, 548)
        Controls.Add(ListBoxEducation)
        Controls.Add(ListBoxJobs)
        Controls.Add(ListBoxAchievements)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ListBoxAchievements As ListBox
    Friend WithEvents ListBoxJobs As ListBox
    Friend WithEvents ListBoxEducation As ListBox
    Public WithEvents PictureBox1 As PictureBox
End Class
