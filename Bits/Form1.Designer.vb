<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New Bits.FormSkin()
        Me.FlatTabControl1 = New Bits.FlatTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FlatButton2 = New Bits.FlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FlatButton1 = New Bits.FlatButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.FlatCheckBox7 = New Bits.FlatCheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FlatButton5 = New Bits.FlatButton()
        Me.FlatButton4 = New Bits.FlatButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FlatComboBox1 = New Bits.FlatComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlatButton3 = New Bits.FlatButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatMini1 = New Bits.FlatMini()
        Me.FlatClose1 = New Bits.FlatClose()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FlatContextMenuStrip1 = New Bits.FlatContextMenuStrip()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunDiagnosisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchDNSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeNetworkIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSkin1.SuspendLayout()
        Me.FlatTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlatContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatTabControl1)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Margin = New System.Windows.Forms.Padding(2)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(524, 451)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "BITS | Login Manager"
        '
        'FlatTabControl1
        '
        Me.FlatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.FlatTabControl1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatTabControl1.Controls.Add(Me.TabPage1)
        Me.FlatTabControl1.Controls.Add(Me.TabPage3)
        Me.FlatTabControl1.Controls.Add(Me.TabPage2)
        Me.FlatTabControl1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatTabControl1.ItemSize = New System.Drawing.Size(120, 40)
        Me.FlatTabControl1.Location = New System.Drawing.Point(9, 54)
        Me.FlatTabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatTabControl1.Name = "FlatTabControl1"
        Me.FlatTabControl1.SelectedIndex = 0
        Me.FlatTabControl1.Size = New System.Drawing.Size(506, 388)
        Me.FlatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.FlatTabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.FlatButton2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.FlatButton1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(498, 340)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Status"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(-1, 167)
        Me.FlatButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(248, 70)
        Me.FlatButton2.TabIndex = 12
        Me.FlatButton2.Text = "Log Out"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(263, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Response Time : Calculating" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(263, 52)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Network Stability : Collecting Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "We'll tell you about your internet soon."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 282)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "External IP : This too is coming."
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 254)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Internal IP : On the way"
        Me.Label5.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(249, 167)
        Me.FlatButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(250, 70)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Diagnose and Repair"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 88)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Connection Status : Calculating" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time Logged In :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Logged In :"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label24)
        Me.TabPage3.Controls.Add(Me.FlatCheckBox7)
        Me.TabPage3.Controls.Add(Me.Label23)
        Me.TabPage3.Controls.Add(Me.FlatButton5)
        Me.TabPage3.Controls.Add(Me.FlatButton4)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.Label21)
        Me.TabPage3.Location = New System.Drawing.Point(4, 44)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Size = New System.Drawing.Size(498, 340)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Optimization"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(18, 254)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(299, 39)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "If you to a lot of Internet Gaming then select this option." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please note : This" &
    " does not mean LAN Gaming."
        '
        'FlatCheckBox7
        '
        Me.FlatCheckBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FlatCheckBox7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatCheckBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatCheckBox7.Checked = False
        Me.FlatCheckBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatCheckBox7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatCheckBox7.Location = New System.Drawing.Point(21, 234)
        Me.FlatCheckBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatCheckBox7.Name = "FlatCheckBox7"
        Me.FlatCheckBox7.Options = Bits.FlatCheckBox._Options.Style1
        Me.FlatCheckBox7.Size = New System.Drawing.Size(228, 22)
        Me.FlatCheckBox7.TabIndex = 9
        Me.FlatCheckBox7.Text = "Optimize for Internet Gaming"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(18, 156)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(438, 52)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Note : You need to Optimize only once. You may revert optimization if you feel no" &
    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "improvement." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A system restart is also recommended to update the new change" &
    "s to your computer."
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(189, 110)
        Me.FlatButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(156, 26)
        Me.FlatButton5.TabIndex = 7
        Me.FlatButton5.Text = "Revert Optimization"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(21, 110)
        Me.FlatButton4.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(156, 26)
        Me.FlatButton4.TabIndex = 6
        Me.FlatButton4.Text = "Run Optimization"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(17, 15)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 20)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Advanced Optimization" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(18, 46)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(470, 39)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Perform certain optimization tweaks to your Network Adapter, Router and Hub to im" &
    "prove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "network status. A backup of all the settings and functions changed / adde" &
    "d will be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "generated and saved."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.FlatComboBox1)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(498, 340)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Internet Around Bits"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Location = New System.Drawing.Point(4, 180)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 134)
        Me.Panel2.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(206, 81)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(118, 19)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Last Update : N/A"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(320, 109)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(178, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Report Refresh Rate : 15 minutes."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(13, 81)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 19)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Avg. Stability : N/A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(206, 53)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 19)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Avg. Response Time : N/A"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(13, 53)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(112, 19)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Avg. Speed : N/A"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(129, 9)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 21)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Internet at ?"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(17, 148)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(219, 19)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Compare my Internet Speed with :"
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
        Me.FlatComboBox1.Location = New System.Drawing.Point(226, 147)
        Me.FlatComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatComboBox1.Name = "FlatComboBox1"
        Me.FlatComboBox1.Size = New System.Drawing.Size(270, 24)
        Me.FlatComboBox1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlatButton3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 134)
        Me.Panel1.TabIndex = 7
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(398, 93)
        Me.FlatButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(80, 26)
        Me.FlatButton3.TabIndex = 10
        Me.FlatButton3.Text = "Calculate"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(13, 81)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 19)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "My Stability : N/A"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(206, 81)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 19)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "My Response Time : N/A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 53)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 19)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "My Speed : N/A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(196, 8)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 21)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "My Internet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(417, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Settings"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(484, 10)
        Me.FlatMini1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(502, 10)
        Me.FlatClose1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.FlatContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "BITS Manager"
        Me.NotifyIcon1.Visible = True
        '
        'FlatContextMenuStrip1
        '
        Me.FlatContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatContextMenuStrip1.ForeColor = System.Drawing.Color.White
        Me.FlatContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FlatContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ToolStripSeparator1, Me.RunDiagnosisToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AdvancedToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.FlatContextMenuStrip1.Name = "FlatContextMenuStrip1"
        Me.FlatContextMenuStrip1.ShowImageMargin = False
        Me.FlatContextMenuStrip1.Size = New System.Drawing.Size(125, 126)
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        '
        'RunDiagnosisToolStripMenuItem
        '
        Me.RunDiagnosisToolStripMenuItem.Name = "RunDiagnosisToolStripMenuItem"
        Me.RunDiagnosisToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.RunDiagnosisToolStripMenuItem.Text = "Run Diagnosis"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AdvancedToolStripMenuItem
        '
        Me.AdvancedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchDNSToolStripMenuItem, Me.ChangeNetworkIDToolStripMenuItem})
        Me.AdvancedToolStripMenuItem.Name = "AdvancedToolStripMenuItem"
        Me.AdvancedToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AdvancedToolStripMenuItem.Text = "Advanced"
        '
        'SwitchDNSToolStripMenuItem
        '
        Me.SwitchDNSToolStripMenuItem.Name = "SwitchDNSToolStripMenuItem"
        Me.SwitchDNSToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SwitchDNSToolStripMenuItem.Text = "Switch DNS"
        '
        'ChangeNetworkIDToolStripMenuItem
        '
        Me.ChangeNetworkIDToolStripMenuItem.Name = "ChangeNetworkIDToolStripMenuItem"
        Me.ChangeNetworkIDToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ChangeNetworkIDToolStripMenuItem.Text = "Change Network ID"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(121, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 451)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BITS | Login Manager"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.FlatTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlatContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents Label1 As Label
    Friend WithEvents FlatTabControl1 As FlatTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatContextMenuStrip1 As FlatContextMenuStrip
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunDiagnosisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdvancedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwitchDNSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeNetworkIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FlatComboBox1 As FlatComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents Label24 As Label
    Friend WithEvents FlatCheckBox7 As FlatCheckBox
End Class
