Imports System.IO


Public Class LogGen
    Public Shared INI As New IniFile
    Public Shared Sub WriteToErrorLog(ByVal ex As Exception, ByVal title As String)
        Try
            Dim msg As String = ex.Message
            Dim stkTrace As String = ex.StackTrace
            If Not System.IO.Directory.Exists(Application.StartupPath &
            "\log\") Then
                System.IO.Directory.CreateDirectory(Application.StartupPath &
                "\log\")
            End If
            Dim fs As FileStream = New FileStream(Application.StartupPath &
            "\log\errlog.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim s As StreamWriter = New StreamWriter(fs)
            s.Close()
            fs.Close()
            Dim fs1 As FileStream = New FileStream(Application.StartupPath &
            "\log\errlog.txt", FileMode.Append, FileAccess.Write)
            Dim s1 As StreamWriter = New StreamWriter(fs1)
            s1.Write("Title: " & title & vbCrLf)
            s1.Write("Message: " & msg & vbCrLf)
            s1.Write("StackTrace: " & stkTrace & vbCrLf)
            s1.Write("Date/Time: " & DateTime.Now.ToString() & vbCrLf)
            s1.Write("================================================" & vbCrLf)
            s1.Close()
            fs1.Close()
        Catch ex2 As Exception
        End Try
    End Sub
    Public Shared Function SaveSettings(ByVal Section As String, ByVal Key As String, ByVal Value As String)
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
            Return False
        End Try
    End Function

End Class
