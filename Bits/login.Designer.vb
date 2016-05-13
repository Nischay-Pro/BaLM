<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New Bits.FormSkin()
        Me.FlatGroupBox1 = New Bits.FlatGroupBox()
        Me.FlatProgressBar1 = New Bits.FlatProgressBar()
        Me.FlatCheckBox1 = New Bits.FlatCheckBox()
        Me.FlatButton1 = New Bits.FlatButton()
        Me.FlatTextBox2 = New Bits.FlatTextBox()
        Me.FlatTextBox1 = New Bits.FlatTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlatClose1 = New Bits.FlatClose()
        Me.FormSkin1.SuspendLayout()
        Me.FlatGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(376, 401)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "BITS | Login"
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.FlatProgressBar1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatCheckBox1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatButton1)
        Me.FlatGroupBox1.Controls.Add(Me.FlatTextBox2)
        Me.FlatGroupBox1.Controls.Add(Me.FlatTextBox1)
        Me.FlatGroupBox1.Controls.Add(Me.Label1)
        Me.FlatGroupBox1.Controls.Add(Me.Label2)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(12, 65)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(352, 324)
        Me.FlatGroupBox1.TabIndex = 1
        Me.FlatGroupBox1.Text = "Enter your credentials"
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.FlatProgressBar1.Location = New System.Drawing.Point(0, 282)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatProgressBar1.Size = New System.Drawing.Size(352, 42)
        Me.FlatProgressBar1.TabIndex = 10
        Me.FlatProgressBar1.Text = "FlatProgressBar1"
        Me.FlatProgressBar1.Value = 0
        Me.FlatProgressBar1.Visible = False
        '
        'FlatCheckBox1
        '
        Me.FlatCheckBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatCheckBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatCheckBox1.Checked = False
        Me.FlatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatCheckBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatCheckBox1.Location = New System.Drawing.Point(34, 254)
        Me.FlatCheckBox1.Name = "FlatCheckBox1"
        Me.FlatCheckBox1.Options = Bits.FlatCheckBox._Options.Style1
        Me.FlatCheckBox1.Size = New System.Drawing.Size(160, 22)
        Me.FlatCheckBox1.TabIndex = 9
        Me.FlatCheckBox1.Text = "Save Credentials"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(200, 244)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(137, 32)
        Me.FlatButton1.TabIndex = 8
        Me.FlatButton1.Text = "Login"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatTextBox2
        '
        Me.FlatTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox2.Location = New System.Drawing.Point(34, 189)
        Me.FlatTextBox2.MaxLength = 32767
        Me.FlatTextBox2.Multiline = False
        Me.FlatTextBox2.Name = "FlatTextBox2"
        Me.FlatTextBox2.ReadOnly = False
        Me.FlatTextBox2.Size = New System.Drawing.Size(303, 34)
        Me.FlatTextBox2.TabIndex = 7
        Me.FlatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox2.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox2.UseSystemPasswordChar = True
        '
        'FlatTextBox1
        '
        Me.FlatTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatTextBox1.Location = New System.Drawing.Point(34, 104)
        Me.FlatTextBox1.MaxLength = 32767
        Me.FlatTextBox1.Multiline = False
        Me.FlatTextBox1.Name = "FlatTextBox1"
        Me.FlatTextBox1.ReadOnly = False
        Me.FlatTextBox1.Size = New System.Drawing.Size(303, 34)
        Me.FlatTextBox1.TabIndex = 6
        Me.FlatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.FlatTextBox1.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FlatTextBox1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username :"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(346, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 401)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BITS | Login"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatTextBox2 As FlatTextBox
    Friend WithEvents FlatTextBox1 As FlatTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FlatCheckBox1 As FlatCheckBox
    Friend WithEvents FlatProgressBar1 As FlatProgressBar
    Friend WithEvents Timer1 As Timer
End Class
