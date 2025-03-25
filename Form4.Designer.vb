<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        ComboBoxYearBatch = New ComboBox()
        ButtonABM = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ButtonTVLICT = New Button()
        Button6 = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBoxYearBatch
        ' 
        ComboBoxYearBatch.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxYearBatch.FormattingEnabled = True
        ComboBoxYearBatch.Items.AddRange(New Object() {"2021-2022", "2022-2023", "2023-2024", "2024-2025"})
        ComboBoxYearBatch.Location = New Point(37, 67)
        ComboBoxYearBatch.Name = "ComboBoxYearBatch"
        ComboBoxYearBatch.Size = New Size(208, 23)
        ComboBoxYearBatch.TabIndex = 0
        ComboBoxYearBatch.Text = "YEAR BATCH"
        ' 
        ' ButtonABM
        ' 
        ButtonABM.BackColor = Color.Brown
        ButtonABM.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonABM.Location = New Point(307, 67)
        ButtonABM.Name = "ButtonABM"
        ButtonABM.Size = New Size(141, 64)
        ButtonABM.TabIndex = 1
        ButtonABM.Text = "ABM"
        ButtonABM.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SlateBlue
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(468, 67)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 64)
        Button2.TabIndex = 2
        Button2.Text = "HUMSS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.MenuHighlight
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(627, 67)
        Button3.Name = "Button3"
        Button3.Size = New Size(141, 64)
        Button3.TabIndex = 3
        Button3.Text = "STEM"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Gold
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(307, 152)
        Button4.Name = "Button4"
        Button4.Size = New Size(141, 64)
        Button4.TabIndex = 4
        Button4.Text = "TVL-COOKERY"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ButtonTVLICT
        ' 
        ButtonTVLICT.BackColor = Color.Gold
        ButtonTVLICT.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonTVLICT.Location = New Point(468, 152)
        ButtonTVLICT.Name = "ButtonTVLICT"
        ButtonTVLICT.Size = New Size(141, 64)
        ButtonTVLICT.TabIndex = 5
        ButtonTVLICT.Text = "TVL-ICT"
        ButtonTVLICT.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Gold
        Button6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(627, 152)
        Button6.Name = "Button6"
        Button6.Size = New Size(141, 64)
        Button6.TabIndex = 6
        Button6.Text = "TVL-TOURISM"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(639, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(142, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(479, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 21)
        Label1.TabIndex = 8
        Label1.Text = "Please Select"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(793, 321)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Button6)
        Controls.Add(ButtonTVLICT)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ButtonABM)
        Controls.Add(ComboBoxYearBatch)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxYearBatch As ComboBox
    Friend WithEvents ButtonABM As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonTVLICT As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
