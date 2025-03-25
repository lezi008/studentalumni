<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnSeeBatch = New Button()
        btnSearchStudent = New Button()
        SuspendLayout()
        ' 
        ' btnSeeBatch
        ' 
        btnSeeBatch.BackColor = Color.Gold
        btnSeeBatch.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSeeBatch.Location = New Point(229, 78)
        btnSeeBatch.Name = "btnSeeBatch"
        btnSeeBatch.Size = New Size(257, 99)
        btnSeeBatch.TabIndex = 0
        btnSeeBatch.Text = "See Batch"
        btnSeeBatch.UseVisualStyleBackColor = False
        ' 
        ' btnSearchStudent
        ' 
        btnSearchStudent.BackColor = Color.LightGreen
        btnSearchStudent.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchStudent.Location = New Point(229, 206)
        btnSearchStudent.Name = "btnSearchStudent"
        btnSearchStudent.Size = New Size(257, 99)
        btnSearchStudent.TabIndex = 1
        btnSearchStudent.Text = "Search Student"
        btnSearchStudent.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(721, 392)
        Controls.Add(btnSearchStudent)
        Controls.Add(btnSeeBatch)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSeeBatch As Button
    Friend WithEvents btnSearchStudent As Button
End Class
