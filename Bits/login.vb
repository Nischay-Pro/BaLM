Imports System.Threading
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Net.NetworkInformation

Public Class login
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        CheckForIllegalCrossThreadCalls = False
        If FlatTextBox1.Text <> "" And FlatTextBox2.Text <> "" And FlatTextBox1.Text <> "admintest" Then
            FlatCheckBox1.Enabled = False
            FlatTextBox1.ReadOnly = True
            FlatTextBox2.ReadOnly = True
            FlatButton1.Enabled = False
            FlatButton1.Text = "Please wait.."
            FlatProgressBar1.Visible = True
            FlatProgressBar1.Value = 0
            Dim newman As New Thread(AddressOf CheckShit)
            newman.SetApartmentState(ApartmentState.STA)
            newman.Start()
        ElseIf FlatTextBox1.Text = "admintest" And FlatTextBox2.Text = "admintest" Then
            Thread.CurrentThread.SetApartmentState(ApartmentState.STA)
            Form1.loggedin = "Nischay Pro"
            Form1.Show()

            Form1.Label2.Text = "Logged in As : Admin Test"
            Dim loadfi As New IniFile
            loadfi.Load(My.Application.Info.DirectoryPath & "\config.ini")
            If FlatCheckBox1.Checked = True Then
                loadfi.SetKeyValue("General Settings", "Save Credentials", "True")
                loadfi.SetKeyValue("Login Credentials", "Username ID", FlatTextBox1.Text)
                Try
                    Dim passen As String = Encrypt(FlatTextBox2.Text, FlatTextBox1.Text)
                    loadfi.SetKeyValue("Login Credentials", "Password", passen)
                    loadfi.SetKeyValue("Login Credentials", "Encrypted", "True")
                Catch ex As Exception
                    LogGen.WriteToErrorLog(ex, "Credential Encryption Failure")
                    loadfi.SetKeyValue("Login Credentials", "Password", FlatTextBox2.Text)
                    loadfi.SetKeyValue("Login Credentials", "Encrypted", "False")
                End Try

            Else
                loadfi.SetKeyValue("General Settings", "Auto Login", "False")
                loadfi.RemoveSection("Login Credentials")
            End If
            loadfi.Save(My.Application.Info.DirectoryPath & "\config.ini")
            Form1.Timer1.Start()
            Me.Close()
        Else
            MsgBox("Please enter your credentials.", MsgBoxStyle.Information, "Credentials Missing")
        End If
    End Sub
    Private Sub ResetTextControl()
        If FlatButton1.InvokeRequired And FlatProgressBar1.InvokeRequired Then
            FlatButton1.Invoke(New Action(AddressOf ResetTextControl), "Login")
            FlatProgressBar1.Invoke(New Action(AddressOf ResetTextControl), "Login")
        Else

        End If
    End Sub
    Private Sub CheckShit()
        CheckForIllegalCrossThreadCalls = False
        Try
            Dim pingman As New Ping
            Dim response As IPStatus = pingman.Send("172.16.0.30").Status
            If response = IPStatus.Success Then
            ElseIf response = IPStatus.TimedOut Then
                MsgBox("You are not connected to BITS Hyderabad Network.", MsgBoxStyle.Exclamation, "Error")
                FlatButton1.Text = "Login"
                FlatButton1.Enabled = True
                FlatProgressBar1.Visible = False
                GoTo dead
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Ping Check Crash. Bypassed.")
        End Try
        browser.WebBrowser1.Navigate("http://172.16.0.30:8090/httpclient.html")
abc:
        If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            Try
                browser.WebBrowser1.Document.GetElementById("username").SetAttribute("value", FlatTextBox1.Text)
                browser.WebBrowser1.Document.GetElementById("password").SetAttribute("value", FlatTextBox2.Text)
                browser.WebBrowser1.Document.GetElementById("btnSubmit").InvokeMember("click")
                wait(4000)
            Catch ex As Exception
                Me.Show()
                Me.ShowInTaskbar = True
                MsgBox("Unable to login. Either internet is down or Gateway portal is offline. " & ex.Message, MsgBoxStyle.Exclamation, "Error")
                FlatButton1.Text = "Login"
                FlatButton1.Enabled = True
                GoTo dead
            End Try


Csdfj:
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
                If browser.WebBrowser1.Document.Body.InnerText.Contains("The system could not log you on. Make sure your password is correct") Then
                    Me.Show()
                    Me.ShowInTaskbar = True
                    MsgBox("The username / password you entered was incorrect.", MsgBoxStyle.Exclamation, "Error")
                    FlatButton1.Text = "Login"
                    FlatButton1.Enabled = True
                    FlatProgressBar1.Visible = False
                Else
                    If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Uninitialized Then
                        FlatProgressBar1.Value = 60
                    End If
                    If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Loading Then
                        FlatProgressBar1.Value = 65
                    End If
                    If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Loaded Then
                        FlatProgressBar1.Value = 80
                    End If
                    If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Interactive Then
                        FlatProgressBar1.Value = 90
                    End If
                    Dim loadfi As New IniFile
                    loadfi.Load(My.Application.Info.DirectoryPath & "\config.ini")
                    If FlatCheckBox1.Checked = True Then
                        loadfi.SetKeyValue("General Settings", "Save Credentials", "True")
                        loadfi.SetKeyValue("Login Credentials", "Username ID", FlatTextBox1.Text)
                        Try
                            Dim passen As String = Encrypt(FlatTextBox2.Text, FlatTextBox1.Text)
                            loadfi.SetKeyValue("Login Credentials", "Password", passen)
                            loadfi.SetKeyValue("Login Credentials", "Encrypted", "True")
                        Catch ex As Exception
                            LogGen.WriteToErrorLog(ex, "Credential Encryption Failure")
                            loadfi.SetKeyValue("Login Credentials", "Password", FlatTextBox2.Text)
                            loadfi.SetKeyValue("Login Credentials", "Encrypted", "False")
                        End Try
                    Else
                        loadfi.RemoveSection("Login Credentials")
                        loadfi.SetKeyValue("General Settings", "Save Credentials", "False")
                        loadfi.SetKeyValue("General Settings", "Auto Login", "False")
                    End If
                    loadfi.Save(My.Application.Info.DirectoryPath & "\config.ini")
                    Form1.loggedin = FlatTextBox1.Text
                    Form1.Label2.Text = "Logged In As : " & FlatTextBox1.Text
                    Form1.Timer1.Start()
                    Form1.Show()
                    browser.Hide()
                    Me.Close()
                End If
            Else
                wait(500)
                GoTo Csdfj
            End If
        Else
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Uninitialized Then
                FlatProgressBar1.Value = 10
            End If
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Loading Then
                FlatProgressBar1.Value = 25
            End If
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Loaded Then
                FlatProgressBar1.Value = 40
            End If
            If browser.WebBrowser1.ReadyState = WebBrowserReadyState.Interactive Then
                FlatProgressBar1.Value = 50
            End If
            wait(500)
            GoTo abc
        End If
dead:
        FlatCheckBox1.Enabled = True
        FlatTextBox1.ReadOnly = False
        FlatTextBox2.ReadOnly = False
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub

    Private Sub FlatCheckBox1_CheckedChanged(sender As Object) Handles FlatCheckBox1.CheckedChanged
        If FlatCheckBox1.Checked = True Then

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SuspendLayout()

        Try
            Dim iniman As New IniFile
            iniman.Load(My.Application.Info.DirectoryPath & "\config.ini")
            If iniman.GetKeyValue("General Settings", "Save Credentials") = "True" Then
                FlatCheckBox1.Checked = True
                FlatTextBox1.Text = iniman.GetKeyValue("Login Credentials", "Username ID")
                If iniman.GetKeyValue("Login Credentials", "Encrypted") = "True" Then
                    FlatTextBox2.Text = Decrypt(iniman.GetKeyValue("Login Credentials", "Password"), FlatTextBox1.Text)
                Else
                    FlatTextBox2.Text = iniman.GetKeyValue("Login Credentials", "Password")
                End If
            End If
            If iniman.GetKeyValue("General Settings", "Save Credentials") = "True" And iniman.GetKeyValue("General Settings", "Auto Login") = "True" Then
                FlatCheckBox1.Checked = True
                FlatTextBox1.Text = iniman.GetKeyValue("Login Credentials", "Username ID")
                If iniman.GetKeyValue("Login Credentials", "Encrypted") = "True" Then
                    FlatTextBox2.Text = Decrypt(iniman.GetKeyValue("Login Credentials", "Password"), FlatTextBox1.Text)
                Else
                    FlatTextBox2.Text = iniman.GetKeyValue("Login Credentials", "Password")
                End If
                If FlatTextBox1.Text = "admintest" And FlatTextBox2.Text = "admintest" Then
                    CheckForIllegalCrossThreadCalls = False
                    Form1.loggedin = "Nischay Pro"
                    Form1.Show()
                    Form1.Label2.Text = "Logged in as : Admin Test"
                    Form1.Timer1.Start()
                    Me.Close()
                    GoTo endg
                End If

                AutoLogin()
            Else
                iniman.SetKeyValue("General Settings", "Auto Login", "False")
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failure to load Credentials")
        End Try
endg:
        Me.ResumeLayout()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Application.OpenForms.Count > 1 Then
            Me.Close()
        End If
    End Sub


    Private Sub FlatTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles FlatTextBox1.KeyDown
        If e.KeyCode = Keys.Tab Then
            FlatTextBox2.Focus()
        End If
    End Sub

    Private Sub FlatTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles FlatTextBox2.KeyDown
        If e.KeyCode = Keys.Tab Then
            FlatButton1.Focus()
        End If
    End Sub
End Class