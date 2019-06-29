<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Fromtextbox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Totextbox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Messagebox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SendButton = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.AboutButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.WebButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MaterialSingleLineTextField1.BackColor = System.Drawing.SystemColors.Window
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "API Key"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(557, 415)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(231, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 0
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 71)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(164, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Send a message today!"
        '
        'Fromtextbox
        '
        Me.Fromtextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Fromtextbox.Depth = 0
        Me.Fromtextbox.Hint = "From:"
        Me.Fromtextbox.Location = New System.Drawing.Point(20, 120)
        Me.Fromtextbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Fromtextbox.Name = "Fromtextbox"
        Me.Fromtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Fromtextbox.SelectedText = ""
        Me.Fromtextbox.SelectionLength = 0
        Me.Fromtextbox.SelectionStart = 0
        Me.Fromtextbox.Size = New System.Drawing.Size(322, 23)
        Me.Fromtextbox.TabIndex = 2
        Me.Fromtextbox.UseSystemPasswordChar = False
        '
        'Totextbox
        '
        Me.Totextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Totextbox.Depth = 0
        Me.Totextbox.Hint = "To:"
        Me.Totextbox.Location = New System.Drawing.Point(20, 149)
        Me.Totextbox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Totextbox.Name = "Totextbox"
        Me.Totextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Totextbox.SelectedText = ""
        Me.Totextbox.SelectionLength = 0
        Me.Totextbox.SelectionStart = 0
        Me.Totextbox.Size = New System.Drawing.Size(322, 23)
        Me.Totextbox.TabIndex = 3
        Me.Totextbox.UseSystemPasswordChar = False
        '
        'Messagebox
        '
        Me.Messagebox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Messagebox.Depth = 0
        Me.Messagebox.Hint = "Message"
        Me.Messagebox.Location = New System.Drawing.Point(20, 178)
        Me.Messagebox.MouseState = MaterialSkin.MouseState.HOVER
        Me.Messagebox.Name = "Messagebox"
        Me.Messagebox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Messagebox.SelectedText = ""
        Me.Messagebox.SelectionLength = 0
        Me.Messagebox.SelectionStart = 0
        Me.Messagebox.Size = New System.Drawing.Size(322, 23)
        Me.Messagebox.TabIndex = 4
        Me.Messagebox.UseSystemPasswordChar = False
        '
        'SendButton
        '
        Me.SendButton.Depth = 0
        Me.SendButton.Location = New System.Drawing.Point(20, 209)
        Me.SendButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Primary = True
        Me.SendButton.Size = New System.Drawing.Size(322, 34)
        Me.SendButton.TabIndex = 5
        Me.SendButton.Text = "Send"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'AboutButton
        '
        Me.AboutButton.AutoSize = True
        Me.AboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AboutButton.Depth = 0
        Me.AboutButton.Location = New System.Drawing.Point(13, 402)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.AboutButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Primary = False
        Me.AboutButton.Size = New System.Drawing.Size(57, 36)
        Me.AboutButton.TabIndex = 6
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'WebButton
        '
        Me.WebButton.AutoSize = True
        Me.WebButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.WebButton.Depth = 0
        Me.WebButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.WebButton.Location = New System.Drawing.Point(78, 402)
        Me.WebButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.WebButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.WebButton.Name = "WebButton"
        Me.WebButton.Primary = False
        Me.WebButton.Size = New System.Drawing.Size(111, 36)
        Me.WebButton.TabIndex = 7
        Me.WebButton.Text = "Visit our site!"
        Me.WebButton.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(197, 402)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(94, 36)
        Me.MaterialFlatButton1.TabIndex = 9
        Me.MaterialFlatButton1.Text = "Phone Call"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(531, 71)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(257, 19)
        Me.MaterialLabel2.TabIndex = 10
        Me.MaterialLabel2.Text = "Supports: ClockworkSMS and Twillio"
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Checked = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(625, 90)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(122, 30)
        Me.MaterialRadioButton1.TabIndex = 11
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "ClockworkSMS"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(625, 120)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(69, 30)
        Me.MaterialRadioButton2.TabIndex = 12
        Me.MaterialRadioButton2.Text = "Twillio"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.MaterialSingleLineTextField2.BackColor = System.Drawing.SystemColors.Window
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Auth Token"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(557, 386)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(231, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 13
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        Me.MaterialSingleLineTextField2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.MaterialRadioButton2)
        Me.Controls.Add(Me.MaterialRadioButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.WebButton)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.Messagebox)
        Me.Controls.Add(Me.Totextbox)
        Me.Controls.Add(Me.Fromtextbox)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "ChatX for Windows "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Fromtextbox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Totextbox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Messagebox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents SendButton As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents AboutButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents WebButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Public WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
