Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class firstrun
    Dim s1 As New Stopwatch
    Private Sub firstrun_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\config.ini") Then
            Try
                Dim iniman As New IniFile
                iniman.Load(My.Application.Info.DirectoryPath & "\config.ini")
                If iniman.GetKeyValue("General Settings", "First Run") = "True" Then
                    login.Show()
                    Me.Close()
                Else
                    Try
                        s1.Start()
                        downloader.DownloadFileAsync(New Uri("http://mirror.internode.on.net/pub/test/1meg.test"), My.Application.Info.DirectoryPath & "\data.test")
a:
                        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\data.test") Then
                            wait(1000)
                            GoTo a
                        End If
                    Catch ex1 As System.Net.WebException
                        MsgBox("We could not connect to Internet Resources. Please connect to the internet and try again.", MsgBoxStyle.Exclamation, "Error")
                        Application.Exit()
                    Catch ex As Exception
                        MsgBox("Some undefined error occured. We could not recover the program. A log file has been generated.", MsgBoxStyle.Critical, "Critical Error")
                        LogGen.WriteToErrorLog(ex, "Critical First Run Error")
                        Application.Exit()
                    End Try
                End If
            Catch ex2 As Exception
                LogGen.WriteToErrorLog(ex2, "Critical First Run Error 2")
                MsgBox("Application ended prematurely. A log file has been generated.", MsgBoxStyle.Critical, "Critical Error")
                Application.Exit()
            End Try
        End If
        Me.ResumeLayout()
    End Sub
    Public WithEvents downloader As New WebClient


    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub downloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles downloader.DownloadFileCompleted

        s1.Stop()
        Dim downloadspeed As Long = Val(Math.Round((1000000 / (s1.ElapsedMilliseconds / 1000)) / 1024, 2))
        Dim iniman As New IniFile
        iniman.SetKeyValue("General Settings", "First Run", "True")
        iniman.SetKeyValue("Client Information", "Download Speed (in KBps)", downloadspeed)
        iniman.Save(My.Application.Info.DirectoryPath & "\config.ini")
        Try
            Kill(My.Application.Info.DirectoryPath & "\data.test")
        Catch ex As Exception

        End Try
        login.Show()
        Me.Close()
    End Sub

    Private Sub downloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles downloader.DownloadProgressChanged
        FlatProgressBar1.Value = Math.Round(e.ProgressPercentage)
    End Sub
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
    Dim Trycount As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If FlatProgressBar1.Value = 0 Then
            Dim iniman As New IniFile
            iniman.SetKeyValue("General Settings", "First Run", "True")
            iniman.SetKeyValue("Client Information", "Download Speed (in KBps)", "N/A")
            iniman.Save(My.Application.Info.DirectoryPath & "\config.ini")
            Try
                Kill(My.Application.Info.DirectoryPath & "\data.test")
            Catch ex As Exception

            End Try
            login.Show()
            Me.Close()
        End If
    End Sub
End Class

'SIZE
'539, 189 
'SIZE