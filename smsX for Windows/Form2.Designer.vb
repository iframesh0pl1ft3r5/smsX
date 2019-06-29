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
        Me.WebButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.AboutButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.accsid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.authtoken = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.tonumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.fromnumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.countw = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.SuspendLayout()
        '
        'WebButton
        '
        Me.WebButton.AutoSize = True
        Me.WebButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.WebButton.Depth = 0
        Me.WebButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WebButton.Location = New System.Drawing.Point(78, 401)
        Me.WebButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.WebButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.WebButton.Name = "WebButton"
        Me.WebButton.Primary = False
        Me.WebButton.Size = New System.Drawing.Size(111, 36)
        Me.WebButton.TabIndex = 22
        Me.WebButton.Text = "Visit our site!"
        Me.WebButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.AutoSize = True
        Me.AboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AboutButton.Depth = 0
        Me.AboutButton.Location = New System.Drawing.Point(13, 401)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AboutButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Primary = False
        Me.AboutButton.Size = New System.Drawing.Size(57, 36)
        Me.AboutButton.TabIndex = 21
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'accsid
        '
        Me.accsid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.accsid.BackColor = System.Drawing.SystemColors.Window
        Me.accsid.Depth = 0
        Me.accsid.Hint = "Account SID"
        Me.accsid.Location = New System.Drawing.Point(557, 414)
        Me.accsid.MouseState = MaterialSkin.MouseState.HOVER
        Me.accsid.Name = "accsid"
        Me.accsid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.accsid.SelectedText = ""
        Me.accsid.SelectionLength = 0
        Me.accsid.SelectionStart = 0
        Me.accsid.Size = New System.Drawing.Size(231, 23)
        Me.accsid.TabIndex = 15
        Me.accsid.UseSystemPasswordChar = False
        '
        'authtoken
        '
        Me.authtoken.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.authtoken.BackColor = System.Drawing.SystemColors.Window
        Me.authtoken.Depth = 0
        Me.authtoken.Hint = "Auth Token"
        Me.authtoken.Location = New System.Drawing.Point(557, 385)
        Me.authtoken.MouseState = MaterialSkin.MouseState.HOVER
        Me.authtoken.Name = "authtoken"
        Me.authtoken.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.authtoken.SelectedText = ""
        Me.authtoken.SelectionLength = 0
        Me.authtoken.SelectionStart = 0
        Me.authtoken.Size = New System.Drawing.Size(231, 23)
        Me.authtoken.TabIndex = 27
        Me.authtoken.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(494, 112)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(91, 23)
        Me.MaterialRaisedButton1.TabIndex = 28
        Me.MaterialRaisedButton1.Text = "Call"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'tonumber
        '
        Me.tonumber.BackColor = System.Drawing.Color.White
        Me.tonumber.Depth = 0
        Me.tonumber.Hint = "To Number"
        Me.tonumber.Location = New System.Drawing.Point(236, 112)
        Me.tonumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.tonumber.Name = "tonumber"
        Me.tonumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tonumber.SelectedText = ""
        Me.tonumber.SelectionLength = 0
        Me.tonumber.SelectionStart = 0
        Me.tonumber.Size = New System.Drawing.Size(237, 23)
        Me.tonumber.TabIndex = 29
        Me.tonumber.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.SystemColors.Window
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(182, 171)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(477, 19)
        Me.MaterialLabel3.TabIndex = 30
        Me.MaterialLabel3.Text = "Note: While calling from Twilio, an extension code is required. eg: +44"
        Me.MaterialLabel3.Visible = False
        '
        'fromnumber
        '
        Me.fromnumber.BackColor = System.Drawing.Color.White
        Me.fromnumber.Depth = 0
        Me.fromnumber.Hint = "From Number"
        Me.fromnumber.Location = New System.Drawing.Point(236, 83)
        Me.fromnumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.fromnumber.Name = "fromnumber"
        Me.fromnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fromnumber.SelectedText = ""
        Me.fromnumber.SelectionLength = 0
        Me.fromnumber.SelectionStart = 0
        Me.fromnumber.Size = New System.Drawing.Size(237, 23)
        Me.fromnumber.TabIndex = 34
        Me.fromnumber.UseSystemPasswordChar = False
        '
        'countw
        '
        Me.countw.AutoSize = True
        Me.countw.Depth = 0
        Me.countw.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.countw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.countw.Location = New System.Drawing.Point(110, 87)
        Me.countw.MouseState = MaterialSkin.MouseState.HOVER
        Me.countw.Name = "countw"
        Me.countw.Size = New System.Drawing.Size(0, 19)
        Me.countw.TabIndex = 35
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Link to mp3 file to be played"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(236, 141)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(237, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 36
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(236, 200)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(245, 30)
        Me.MaterialCheckBox1.TabIndex = 37
        Me.MaterialCheckBox1.Text = "Use rickroll instead of custom mp3"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialCheckBox1)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.countw)
        Me.Controls.Add(Me.fromnumber)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.tonumber)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.authtoken)
        Me.Controls.Add(Me.WebButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.accsid)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form2"
        Me.Text = "chatX Beta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents AboutButton As MaterialSkin.Controls.MaterialFlatButton
    Public WithEvents accsid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents authtoken As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents tonumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents fromnumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents countw As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
End Class
