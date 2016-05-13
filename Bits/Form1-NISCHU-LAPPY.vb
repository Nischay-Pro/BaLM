Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Parse
Public Class Form1
    Public loggedin As String
    Dim timeshit As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000
        timeshit = timeshit + 1
        Dim time As TimeSpan = TimeSpan.FromSeconds(timeshit)
        Label3.Text = "Time Logged In : " & time.ToString
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        diagnose.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()

        ShowNotification("Sucessfully logged in as " & loggedin, ToolTipIcon.Info)
        CheckForIllegalCrossThreadCalls = False
        Try
            Dim iniman As New IniFile
            iniman.Load(My.Application.Info.DirectoryPath & "\config.ini")
            If My.Application.CommandLineArgs.Contains("-hidden") And iniman.GetKeyValue("General Settings", "Run on Start") = "True" And iniman.GetKeyValue("General Settings", "Silent") = "True" Then
                Me.WindowState = FormWindowState.Minimized
                Me.Visible = False
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Ninja Mode Failed")
        End Try
        Dim shita As New Thread(AddressOf Cods)
        shita.Start()
        Dim ipread As New Thread(AddressOf DNSRespo.SetupTheIP)
        ipread.Start()

        Try
            'ParseClient.Initialize("l3UWqIXW4EFSYo2L8GaUqErT6iyUeH4pnNW3Pv6e", "RHkJCF9Rez3cCBO8utyjUE5kGHbsyRi1WQPir3aE")

            '           Dim abc As New ParseObject("Internet_Status")
            '          Dim query As ParseQuery(Of ParseObject) = ParseObject.GetQuery("Internet_Status")
            '         Dim gameScore As ParseObject = Await query.GetAsync("w9HP5Og1Vq")
            'MsgBox(gameScore.Get(Of String)("bavan"))
            DNSRespo.SetupTheIP()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.ResumeLayout()
    End Sub
    Public Sub Shit()





    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        settings.Show()
    End Sub

    Dim pingshit, moreshit As New ListBox
    Dim pingper As Integer = -1
    Private Sub Cods()
a:
        If pingshit.Items.Count < 11 Then
            Dim i As Integer = 0
            For Each item As String In pingshit.Items
                If item = "Success" Then
                    i += 1
                End If
            Next
            Try
                pingper = Math.Round(((i / pingshit.Items.Count) * 100), 0)
                moreshit.Items.Add(pingper)
            Catch ex As Exception
                pingper = -1
            End Try
            If moreshit.Items.Count < 101 And moreshit.Items.Count > 11 Then
                Dim totalval As Integer = 0
                For Each Item As String In moreshit.Items
                    totalval = totalval + Val(Item)
                Next
                totalval = Math.Round(totalval / moreshit.Items.Count, 2)
                Label8.Text = "Network Stability : " & totalval & "%"
            ElseIf moreshit.Items.Count >= 101 Then
                moreshit.Items.Clear()
            End If
            Try
                Label4.Text = "Connection Status : " & Math.Round(((i / pingshit.Items.Count) * 100), 2) & "%"
            Catch ex As Exception
                LogGen.WriteToErrorLog(ex, "Crash in Connection Status. Mostly during log out.")
            End Try
            i = 0
        Else
            pingshit.Items.Clear()
        End If
        If pingper = 0 Then
            Label7.Text = "Either server is down or your logged out or you disconnected " & vbNewLine & "the internet cable."
        End If
        If pingper > 0 And pingper < 25 Then
            Label7.Text = "Internet is in total chaos. Internet Gateway could be down?" & vbNewLine
        End If
        If pingper >= 25 And pingper < 50 Then
            Label7.Text = "Total Internet Degrading. None of your apps will work " & vbNewLine & "properly. Mostly server sided problem."
        End If
        If pingper >= 50 And pingper < 64 Then
            Label7.Text = "Severe Internet Degrading. Several apps will not work " & vbNewLine & "properly. We will try to repair your internet."
        End If
        If pingper >= 64 And pingper < 89 Then
            Label7.Text = "Degraded Internet Issues. Internet is not stable." & vbNewLine & "We will stablize your internet. Don't worry :P"
        End If
        If pingper >= 89 And pingper < 100 Then
            Label7.Text = "Some minor internet issues. Most apps will run without any " & vbNewLine & "problems."
        End If
        If pingper = 100 Then
            Label7.Text = "Everything is good. We'll keep checking for any problems."
        End If
        Try
            Dim ping As New Net.NetworkInformation.Ping
            Dim responseshit As String = ping.Send("8.8.8.8").Status.ToString
            Dim roundtriptime As String = ping.Send("8.8.4.4").RoundtripTime
            Label9.Text = "Response Time : " & roundtriptime & " ms"
            pingshit.Items.Add(responseshit)
            Thread.Sleep(4000)
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Ping Crash")
        End Try
        GoTo a
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Function GetSpeed()
        Dim myNA() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces

        Return FormatFileSize(myNA(0).Speed)
    End Function
    Public Shared Function FormatFileSize(ByVal Size As Long) As String
        Try
            Dim KB As Integer = 1024
            Dim MB As Integer = KB * KB
            Dim GB As Integer = MB * 1024
            ' Return size of file in kilobytes.
            If Size < KB Then
                Return (Size.ToString("D") & " bytes")
            Else
                Select Case Size / KB
                    Case Is < 100
                        Return (Size / KB).ToString("N") & "KB"
                    Case Is < 1000000
                        Return (Size / MB).ToString("N") & "MB"
                    Case Is < 10000000
                        Return (Size / MB / KB).ToString("N") & "GB"
                    Case Is < 10000000
                        Return (Size / GB / MB / KB).ToString("N") & "TB"
                    Case Else
                        Return Size.ToString & "bytes"

                End Select
            End If
        Catch ex As Exception
            Return Size.ToString
        End Try
    End Function

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Focus()
        Me.Show()
        Me.ShowInTaskbar = True
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        If MessageBox.Show("Are you sure you want to log out", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub RunDiagnosisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunDiagnosisToolStripMenuItem.Click
        diagnose.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        settings.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        settings.Show()
        settings.FlatTabControl1.SelectedIndex = 2
    End Sub

    Private Sub SwitchDNSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchDNSToolStripMenuItem.Click
        CalibrateDNS
    End Sub

    Private Sub ChangeNetworkIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeNetworkIDToolStripMenuItem.Click

    End Sub

    Private Sub FlatComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FlatComboBox1.SelectedIndexChanged
        Label18.Text = Label18.Text.Remove(11, Label18.Text.Length - 1)
        Label18.Text = Label18.Text & " " & FlatComboBox1.SelectedText
    End Sub

    Private Sub FlatMini1_Click(sender As Object, e As EventArgs) Handles FlatMini1.Click
        ShowNotification("Minimized to notification bar. Double Tap to open it again.", ToolTipIcon.Info)
        Me.Hide()
        Me.ShowInTaskbar = False
    End Sub
End Class
