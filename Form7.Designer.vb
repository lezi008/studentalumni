<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Label1 = New Label()
        ListBox1 = New ListBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 21)
        Label1.TabIndex = 0
        Label1.Text = "ABM(2024-2025)"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"BOYS ", "01185 - LEAL, KERVIN P.", "00653 - MACARAYA, CARL JASPER V.", "01043 - MARQUEZ, LORDLY IAN L.", "01505 - MENDEZ, RAPHAEL C.", "01099 - MONTOYA, PRINCE ISAIAH I.", "00655 - MORALES, JOHN CARLO D. L.", "00609 - NAGAHASHI, KENJI V.", "01084 - OCAMPO, JERICHO P.", "00204 - PACARIEM, JOSHUA PHILIPPE L.", "00509 - PANES, JUSTIN JETHRO P.", "00679 - PEPITO, ERWIN JHON C.", "00075 - PINGA, DANIEL KING R.", "01119 - PLANAS, JOHNCARLO T.", "01078 - PRINCIPIO, JOHN ANDREI O.", "", "GIRLS", "01182 - JORGE, ALESSANDRA GIULIA S.", "00677 - KAGEYAMA, AYA B.", "00242 - LAGONOY, MYRA JANE P.", "01115 - LAGUNA, NASHLY S.", "01098 - LAJADA, SHAKIRA KHATE R.", "01433 - LAZO, CLOYDANE GILLIANE C.", "01416 - LIBAWAN, ERICKA R.", "00550 - LONGASA, CRISTINE LHACE R.", "01212 - LORENZO, LEANNE RAYNE P.", "01444 - LORICA, NICOLE AIEN L.", "01228 - MADDAY, JIEANAH MARIE M.", "01577 - MAGISTRADO, RUTH H.", "01095 - MALICDEM, JULIE ANN A.", "01116 - NERI, HAZEL S.", "01121 - NEVADO, NICOLE M.", "01054 - OBASAN, SAMANTHA CORINE B.", "01013 - OBRAR, RICA-MAE C.", "01010 - ORTIZ, MECAELLA S.", "00498 - PACALLAGAN, MA NICOLE B.", "01248 - PADULLA, TRISHA ANNE NICOLE R.", "01134 - PADURA, JERSEY NICOLE C.", "01202 - PAGASPAS, RHIZA MAE T.", "01059 - POSEO, MARY ANGEL D."})
        ListBox1.Location = New Point(12, 106)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(612, 154)
        ListBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 2
        Label2.Text = "ABM-BENTHAM"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(728, 393)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Name = "Form7"
        Text = "Form7"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
End Class
