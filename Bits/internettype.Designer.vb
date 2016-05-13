<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class internettype
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(internettype))
        Me.FormSkin1 = New Bits.FormSkin()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlatComboBox1 = New Bits.FlatComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FlatButton1 = New Bits.FlatButton()
        Me.FlatClose1 = New Bits.FlatClose()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FormSkin1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.Label5)
        Me.FormSkin1.Controls.Add(Me.Panel3)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.Panel2)
        Me.FormSkin1.Controls.Add(Me.Panel1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(681, 625)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "BITS | Internet Diagnostics Toolkit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(599, 38)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "We detected a new internet connection. Please tell us how you are connecting to t" &
    "he internet so " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that we can re-configure the program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.FlatComboBox1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 509)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(657, 92)
        Me.Panel3.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 19)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "So where are you connecting BITS Network from :"
        '
        'FlatComboBox1
        '
        Me.FlatComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FlatComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.FlatComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatComboBox1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatComboBox1.ForeColor = System.Drawing.Color.White
        Me.FlatComboBox1.FormattingEnabled = True
        Me.FlatComboBox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatComboBox1.ItemHeight = 18
        Me.FlatComboBox1.Items.AddRange(New Object() {"Ram Bavan Floor 1", "Ram Bavan Floor 2", "Ram Bavan Floor 3", "Ram Bavan Floor 4", "Krishna Bavan Floor 1", "Krishna Bavan Floor 2", "Krishna Bavan Floor 3", "Krishna Bavan Floor 4", "Gandhi Bavan Floor 1", "Gandhi Bavan Floor 2", "Gandhi Bavan Floor 3", "Gandhi Bavan Floor 4", "Vyas Bavan Floor 1", "Vyas Bavan Floor 2", "Vyas Bavan Floor 3", "Vyas Bavan Floor 4", "Budh Bavan Floor 1", "Budh Bavan Floor 2", "Budh Bavan Floor 3", "Budh Bavan Floor 4", "Meera Ground", "Meera Floor 1", "Meera Floor 2", "Meera Floor 3", "Malaviya Boys Floor 1", "Malaviya Boys Floor 2", "Malaviya Boys Floor 3", "Malaviya Boys Floor 4", "Malaviya Boys Floor 5", "Malaviya Girls Floor 1", "Malaviya Girls Floor 2", "Malaviya Girls Floor 3", "Malaviya Girls Floor 4", "Malaviya Girls Floor 5", "Library"})
        Me.FlatComboBox1.Location = New System.Drawing.Point(362, 9)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(281, 24)
        Me.FlatComboBox1.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.FlatButton1)
        Me.Panel4.Location = New System.Drawing.Point(430, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(226, 48)
        Me.Panel4.TabIndex = 2
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(224, 46)
        Me.FlatButton1.TabIndex = 0
        Me.FlatButton1.Text = "Continue"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(651, 12)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 2
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(344, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 387)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 133)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Wi-Fi Connection"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Bits.My.Resources.Resources._1450888331_vector_66_16
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(97, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 387)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 38)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Your computer is directly connected to BITS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hyderabad Network via a LAN cable." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Direct Ethernet Connection" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Bits.My.Resources.Resources._1450888327_vector_66_09
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(86, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'internettype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 625)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "internettype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BITS | Internet Diagnostics"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FlatComboBox1 As FlatComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
