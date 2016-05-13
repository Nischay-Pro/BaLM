Imports System.IO
Imports Bits.LogGen
Public Class settings
    Dim INI As New IniFile
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub FlatCheckBox3_CheckedChanged(sender As Object) Handles FlatCheckBox3.CheckedChanged
        If FlatCheckBox3.Checked = True Then
            SaveSettings("Advanced Settings", "Auto Diagnostics", "True")
        Else
            SaveSettings("Advanced Settings", "Auto Diagnostics", "False")
        End If
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FlatLabel7_Click(sender As Object, e As EventArgs) Handles FlatLabel7.Click

    End Sub

    Private Sub FlatCheckBox2_CheckedChanged(sender As Object) Handles FlatCheckBox2.CheckedChanged
        If FlatCheckBox2.Checked = True Then
            SaveSettings("General Settings", "Auto Login", "True")
        Else
            SaveSettings("General Settings", "Auto Login", "False")
        End If
    End Sub
    Private Function SaveSettings(ByVal Section As String, ByVal Key As String, ByVal Value As String)
        Try
            Try
                INI.Load(My.Application.Info.DirectoryPath & "\config.ini")
            Catch ex As Exception
                WriteToErrorLog(ex, "Configuration File Missing")
            End Try
            INI.AddSection(Section)
            INI.SetKeyValue(Section, Key, Value)
            INI.Save(My.Application.Info.DirectoryPath & "\config.ini")
            Return True
        Catch ex2 As Exception
            WriteToErrorLog(ex2, "Configuration File Failed")
            MsgBox(ex2.Message)
            Me.Close()
            Return False
        End Try
    End Function

    Private Sub FlatCheckBox4_CheckedChanged(sender As Object) Handles FlatCheckBox4.CheckedChanged
        If FlatCheckBox4.Checked = True Then
            SaveSettings("Advanced Settings", "Auto Change Network", "True")
        Else
            SaveSettings("Advanced Settings", "Auto Change Network", "False")
        End If
    End Sub

    Private Sub FlatCheckBox5_CheckedChanged(sender As Object) Handles FlatCheckBox5.CheckedChanged
        If FlatCheckBox5.Checked = True Then
            SaveSettings("Advanced Settings", "Switch DNS", "True")
        Else
            SaveSettings("Advanced Settings", "Switch DNS", "False")
        End If
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.UnAggressiveDisplay()
        Try
            INI.Load(My.Application.Info.DirectoryPath & "\config.ini")
            If INI.GetKeyValue("General Settings", "Auto Login") = "True" Then
                FlatCheckBox2.Checked = True
            End If
            If INI.GetKeyValue("Advanced Settings", "Auto Diagnostics") = "True" Then
                FlatCheckBox3.Checked = True
            End If
            If INI.GetKeyValue("Advanced Settings", "Auto Change Network") = "True" Then
                FlatCheckBox4.Checked = True
            End If
            If INI.GetKeyValue("Advanced Settings", "Switch DNS") = "True" Then
                FlatCheckBox5.Checked = True
            End If
            If INI.GetKeyValue("General Settings", "Silent") = "True" Then
                FlatCheckBox6.Checked = True
            End If
            If INI.GetKeyValue("General Settings", "Suppress Notifications") = "True" Then
                FlatCheckBox7.Checked = True
            End If
            If INI.GetKeyValue("General Settings", "Save Credentials") = "True" Then
                FlatCheckBox2.Enabled = True
            End If
            If INI.GetKeyValue("General Settings", "Run on Start") = "True" Then
                FlatCheckBox1.Checked = True
            End If
        Catch ex As Exception
            WriteToErrorLog(ex, "Configuration Reading Error")
        End Try
        Try
            FlatLabel11.Text = "Your Using : " & My.Application.Info.Version.ToString()
        Catch ex As Exception
            WriteToErrorLog(ex, "Assembly Version Failed")
        End Try
        Dim threadshit As New Threading.Thread(AddressOf GetChannelShit)
        threadshit.Start()

    End Sub
    Private Sub GetChannelShit()

        FlatLabel13.Text = "Your current channel is : " '& 'GetChannel(Form1.loggedin).Result
        'MsgBox(FlatLabel13.Text)
    End Sub
    Private Sub FlatCheckBox6_CheckedChanged(sender As Object) Handles FlatCheckBox6.CheckedChanged
        If FlatCheckBox6.Checked = True Then
            Try
                If INI.GetKeyValue("General Settings", "Auto Login") = "True" And INI.GetKeyValue("General Settings", "Save Credentials") = "True" Then
                    SaveSettings("General Settings", "Silent", "True")
                Else
                    MsgBox("We could not enable silent mode since one for more settings are disabled.", MsgBoxStyle.Information, "Information")
                    FlatCheckBox6.Checked = False
                End If
            Catch ex As Exception
                LogGen.WriteToErrorLog(ex, "Silent Setting Crash")
            End Try
        Else
            SaveSettings("General Settings", "Silent", "False")
        End If
    End Sub

    Private Sub FlatCheckBox7_CheckedChanged(sender As Object) Handles FlatCheckBox7.CheckedChanged
        If FlatCheckBox7.Checked = True Then
            SaveSettings("General Settings", "Suppress Notifications", "True")
        Else
            SaveSettings("General Settings", "Suppress Notifications", "False")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.AggressiveDisplay()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://www.facebook.com/nischay.pro")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub FlatCheckBox1_CheckedChanged(sender As Object) Handles FlatCheckBox1.CheckedChanged
        If FlatCheckBox1.Checked = True Then
            SaveSettings("General Settings", "Run on Start", "True")
            RegKeyAdd()
            FlatCheckBox6.Enabled = True

        Else
            SaveSettings("General Settings", "Run on Start", "False")
            RegKeyDelete()
            SaveSettings("General Settings", "Silent", "False")
            FlatCheckBox6.Checked = False
            FlatCheckBox6.Enabled = False
        End If
    End Sub

    Private Sub RegKeyAdd()
        Try
            Dim processman As New Process
            Dim pathman As String = Path.GetPathRoot(Environment.SystemDirectory)
            processman.StartInfo = New ProcessStartInfo()
            processman.StartInfo.FileName = "cmd"
            processman.StartInfo.RedirectStandardInput = True
            processman.StartInfo.RedirectStandardOutput = True
            processman.StartInfo.RedirectStandardError = True
            processman.StartInfo.CreateNoWindow = True
            processman.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            processman.StartInfo.UseShellExecute = False
            processman.Start()
            Dim writecommand As StreamWriter = processman.StandardInput
            Dim appname As String = Application.ProductName
            Dim apploc As String = Application.ExecutablePath
            writecommand.WriteLine("reg add HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" & " /V """ & appname & """" & " /t REG_SZ /F /D """ & apploc & " -hidden" & """")
            writecommand.Close()
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed during Startup Set.")
            MsgBox("Something Occured. Oops!", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
        End Try
    End Sub
    Private Sub RegKeyDelete()
        Try
            Dim processman As New Process
            Dim pathman As String = Path.GetPathRoot(Environment.SystemDirectory)
            processman.StartInfo = New ProcessStartInfo()
            processman.StartInfo.FileName = "cmd"
            processman.StartInfo.RedirectStandardInput = True
            processman.StartInfo.RedirectStandardOutput = True
            processman.StartInfo.RedirectStandardError = True
            processman.StartInfo.CreateNoWindow = True
            processman.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            processman.StartInfo.UseShellExecute = False
            processman.Start()
            Dim writecommand As StreamWriter = processman.StandardInput
            Dim appname As String = Application.ProductName
            Dim apploc As String = Application.ExecutablePath
            writecommand.WriteLine("reg delete HKCU\SOFTWARE\Microsoft\Windows\CurrentVersion\Run" & " /V """ & appname & """" & " /F")
            writecommand.Close()
            processman.WaitForExit()
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed during Startup Set.")
            MsgBox("Something Occured. Oops!", MsgBoxStyle.Exclamation, "Error")
            Me.Close()
        End Try
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If MsgBox("Are you sure you want to delete the log files?", MsgBoxStyle.OkCancel, "Warning") = MsgBoxResult.Ok Then
            Try
                My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\log", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\log")
                MsgBox("Log files deleted successfully.", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                LogGen.WriteToErrorLog(ex, "Failed during deleting log files.")
                MsgBox("Something happened. Could not delete logs.", MsgBoxStyle.Exclamation, "Failed")
            End Try
        End If
    End Sub

    Private Sub FlatButton2_Click_1(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Try
            Process.Start(My.Application.Info.DirectoryPath & "\log")
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed in loading log directory")
            MsgBox("Could not load log directory. Did you delete it?", MsgBoxStyle.Exclamation, "Crash")
        End Try
    End Sub
End Class