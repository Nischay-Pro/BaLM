Imports System.Net.NetworkInformation

Module StartupHandler

    Sub Main()
        Threading.Thread.CurrentThread.SetApartmentState(Threading.ApartmentState.STA)
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\config.ini") Then
            Try
                Dim iniman As New IniFile
                iniman.Load(My.Application.Info.DirectoryPath & "\config.ini")
                If iniman.GetKeyValue("General Settings", "First Run") = "True" Then
                    If My.Application.CommandLineArgs.Contains("-hidden") Then
                        Form1.Visible = False
                    End If
                    LoginCheck()
                Else
                    firstrun.Show()
                End If
            Catch ex As Exception
            End Try
        Else
            firstrun.Show()
        End If
        Application.Run()
    End Sub
    Dim username, password As String
    Dim FlatCheckbox1 As New CheckBox
    Sub LoginCheck()
        Try
            Dim iniman As New IniFile
            iniman.Load(My.Application.Info.DirectoryPath & "\config.ini")

            If iniman.GetKeyValue("General Settings", "Save Credentials") = "True" Then
                FlatCheckbox1.Checked = True
                username = iniman.GetKeyValue("Login Credentials", "Username ID")
                If iniman.GetKeyValue("Login Credentials", "Encrypted") = "True" Then
                    Try
                        password = Decrypt(iniman.GetKeyValue("Login Credentials", "Password"), username)
                    Catch ex As Exception
                        MsgBox("The credentials you entered were invalid. Did you tamper with the Configuration File?", MsgBoxStyle.Exclamation, "Error")
                        login.Show()
                        GoTo endg
                    End Try
                Else
                    password = iniman.GetKeyValue("Login Credentials", "Password")
                End If
            End If
            If iniman.GetKeyValue("General Settings", "Save Credentials") = "True" And iniman.GetKeyValue("General Settings", "Auto Login") = "True" Then

                username = iniman.GetKeyValue("Login Credentials", "Username ID")
                If iniman.GetKeyValue("Login Credentials", "Encrypted") = "True" Then
                    password = Decrypt(iniman.GetKeyValue("Login Credentials", "Password"), username)
                Else
                    password = iniman.GetKeyValue("Login Credentials", "Password")
                End If
                If username = "admintest" And password = "admintest" Then

                    Form1.loggedin = "Nischay Pro"
                    Form1.Show()
                    Form1.Label2.Text = "Logged in as : Admin Test"
                    Form1.Timer1.Start()
                    GoTo endg
                End If

                AutoLogin()
            Else
                iniman.SetKeyValue("General Settings", "Auto Login", "False")
            End If
            login.Show()
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failure to load Credentials")
        End Try
endg:
    End Sub
    Sub AutoLogin()
        Try
            Dim pingman As New Ping
            Dim response As IPStatus = pingman.Send("172.16.0.30").Status
            If response = IPStatus.Success Then
            ElseIf response = IPStatus.TimedOut Then
                MsgBox("You are not connected to BITS Hyderabad Network.", MsgBoxStyle.Exclamation, "Error")

                GoTo dead
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Ping Check Crash. Bypassed.")
        End Try
        browser.WebBrowser1.Navigate("http://172.16.0.30:8090/httpclient.html")
abc:
        If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            Try
                browser.WebBrowser1.Document.GetElementById("username").SetAttribute("value", username)
                browser.WebBrowser1.Document.GetElementById("password").SetAttribute("value", password)
                browser.WebBrowser1.Document.GetElementById("btnSubmit").InvokeMember("click")
                wait(4000)
            Catch ex As Exception
                MsgBox("Unable to login. Either internet is down or Gateway portal is offline." & ex.Message, MsgBoxStyle.Exclamation, "Error")
                Application.Exit()
            End Try


Csdfj:
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
                If browser.WebBrowser1.Document.Body.InnerText.Contains("The system could not log you on. Make sure your password is correct") Then
                    MsgBox("The username / password you entered was incorrect.", MsgBoxStyle.Exclamation, "Error")
                    login.Show()
                Else
                    Dim loadfi As New IniFile
                    loadfi.Load(My.Application.Info.DirectoryPath & "\config.ini")
                    If FlatCheckbox1.Checked = True Then
                        loadfi.SetKeyValue("General Settings", "Save Credentials", "True")

                        loadfi.SetKeyValue("Login Credentials", "Username ID", username)
                        Try
                            Dim passen As String = Encrypt(password, username)
                            loadfi.SetKeyValue("Login Credentials", "Password", passen)
                            loadfi.SetKeyValue("Login Credentials", "Encrypted", "True")
                        Catch ex As Exception
                            LogGen.WriteToErrorLog(ex, "Credential Encryption Failure")
                            loadfi.SetKeyValue("Login Credentials", "Password", password)
                            loadfi.SetKeyValue("Login Credentials", "Encrypted", "False")
                        End Try
                    Else
                        loadfi.RemoveSection("Login Credentials")
                        loadfi.SetKeyValue("General Settings", "Save Credentials", "False")
                        loadfi.SetKeyValue("General Settings", "Auto Login", "False")
                    End If
                    loadfi.Save(My.Application.Info.DirectoryPath & "\config.ini")
                    Form1.loggedin = username
                    Form1.Label2.Text = "Logged In As : " & username
                    Form1.Timer1.Start()
                    Form1.Show()
                End If
            Else
                wait(500)
                GoTo Csdfj
            End If
        Else

            wait(500)
            GoTo abc
        End If
dead:
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
End Module
