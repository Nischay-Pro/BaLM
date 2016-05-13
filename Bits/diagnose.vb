Imports System.Net.NetworkInformation

Public Class diagnose
    Dim diagnosedone As Boolean = False
    Private Sub diagnose_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.UnAggressiveDisplay()
        Me.Activate()
        Me.BringToFront()
        CheckForIllegalCrossThreadCalls = False
        wait(2000)
        Dim threadman As New Threading.Thread(AddressOf StartDia)
        threadman.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If diagnosedone = False Then
            If MessageBox.Show("Are you sure you want to stop diagnosis", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Close()
                Form1.AggressiveDisplay()
            End If
        Else
            Me.Close()
            Form1.AggressiveDisplay()
        End If
    End Sub
    Dim stage As Integer = 1
    Private Sub StartDia()
        Label1.Text = "Stage " & stage & " : Checking Active Network Interface Cards"
        Try
            If GetPrimaryNic2() = True Then
                stage += 1
            Else
                Label1.Text = "Diagnosis Complete. You are not connected to any active internet connection."
                diagnosedone = True
                GoTo exitdiag
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Unable to load Network Interface Card.")
            Label1.Text = "Stage " & stage & " : Unable to read Network Interface Card. Error Report Generated"
            diagnosedone = True
            GoTo exitdiag
        End Try
        Label1.Text = "Stage " & stage & " : Checking Internet Connectivity"
        Try
            Dim pingman As New Ping
            Dim response As IPStatus = pingman.Send("172.16.0.30").Status
            If response = IPStatus.Success Then
                stage += 1
            ElseIf response = IPStatus.TimedOut Then
                Label1.Text = "Diagnosis Complete. The computer is not connected to BITS Hyderabad Network."
                diagnosedone = True
                GoTo exitdiag
            Else
                Label1.Text = "Diagnosis Complete. Internet Gateway Portal is offline."
                diagnosedone = True
                GoTo exitdiag
            End If
        Catch ex2 As Exception
            LogGen.WriteToErrorLog(ex2, "Unable to perform ping action.")
            Label1.Text = "Stage " & stage & " : Unable to send static ping packets."
            diagnosedone = True
            GoTo exitdiag
        End Try
        Label1.Text = "Stage " & stage & " : Checking for internet access"
        Try
            If CheckForInternetConnection() = True Then
                Label1.Text = "Diagnosis Complete : You are connected to the internet."
                diagnosedone = True
                GoTo exitdiag
            Else
                stage += 1
            End If
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Unable to check for internet access")
            Label1.Text = "Stage " & stage & " : Unable to check for internet access."
            diagnosedone = True
            GoTo exitdiag
        End Try
        Label1.Text = "Stage " & stage & " : Renewing login"
        Try
            login.Show()
            wait(2000)
        Catch ex As Exception

        End Try
        Label1.Text = "Stage " & stage & " : Running IP Renewal"
        wait(1000)
        If DiagRep.RenewConnection() = False Then
            Label1.Text = "Stage " & stage & " : Failed - Error Report Generated"
            diagnosedone = True
            wait(2000)
        Else

        End If
exitdiag:
    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub


    'For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
    'For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties.GatewayAddresses
    '
    'If gatewayAddr.Address.ToString <> "0.0.0.0" And networkCard.OperationalStatus.ToString() = "Up" Then
    'If networkCard.GetIPProperties.DnsSuffix <> "" Then
    'End If
    'End If
    'Next
    'Next
    'End Sub
End Class