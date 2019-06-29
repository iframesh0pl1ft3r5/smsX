<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(539, 70)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(249, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 0
        Me.MaterialSingleLineTextField1.Text = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Twillio API 2"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(539, 99)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(249, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 1
        Me.MaterialSingleLineTextField2.Text = " "
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Name = "Form2"
        Me.Text = "chatX Beta"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
