Imports System.Net
Imports Heijden.DNS
Imports System.Net.NetworkInformation

Public Class DNSRespo

    Public Shared Function ResolveDNSTime(ByVal WebsiteName As String,
                                          ByVal DNSIP As String)
        Try
            Dim resol As New Resolver
            resol.DnsServer = DNSIP
            Dim s1 As New Stopwatch
            s1.Start()
            Dim IPShit As IPHostEntry = resol.GetHostEntry(WebsiteName)
            s1.Stop()
            Return s1.ElapsedMilliseconds
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed during DNS Query")
            Return False
        End Try
    End Function
    Public Shared Sub SetupTheIP()
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < 3000
            Application.DoEvents()
        Loop
        sw.Stop()
        Try
            GetPrimaryNic()
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed in Internal IP Det")
        End Try
        Try
            GetExternalIP()
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed in External IP Det")
        End Try
    End Sub
    Private Shared Sub GetExternalIP()
        Using shitman As New WebClient

            Form1.Label6.Text = "External IP : " & shitman.DownloadString("https://api.ipify.org/")

        End Using

    End Sub
    Private Sub wait(ByVal interval As Integer)
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Private Shared Sub GetPrimaryNic()
        ' DESCRIPTION: this function  will provide networking details for primary network card

        Dim PrimaryNic As New Collection

        For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces

            ' Find network cards with gateway information (this may show more than one network card depending on computer)
            For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties.GatewayAddresses

                ' if gateway address is NOT 0.0.0.0 and the network card status is UP then we've found the main network card
                If gatewayAddr.Address.ToString <> "0.0.0.0" And networkCard.OperationalStatus.ToString() = "Up" Then
                    If networkCard.GetIPProperties.DnsSuffix <> "" Then
                        PrimaryNic.Add("Interface GUID: " & networkCard.Id)
                        PrimaryNic.Add("Name:".PadRight(15) & networkCard.Name)
                        PrimaryNic.Add("Description:".PadRight(15) & networkCard.Description)
                        PrimaryNic.Add("Status:".PadRight(15) & networkCard.OperationalStatus.ToString)
                        PrimaryNic.Add("Status:".PadRight(15) & (networkCard.Speed / 1000000).ToString("#,000") & " Mbps")
                        PrimaryNic.Add("MAC Address:".PadRight(15) & networkCard.GetPhysicalAddress.ToString)

                        ' Get IP Address(es) and subnet(s) information
                        Dim IpAddressAndSubnet As UnicastIPAddressInformation

                        For Each IpAddressAndSubnet In networkCard.GetIPProperties.UnicastAddresses
                            Dim ipaddress As String = IpAddressAndSubnet.Address.ToString
                            Dim striman As String() = ipaddress.Split(".")
                            For Each Item As String In striman
                                If Item.Length = 3 Then
                                Else
                                    GoTo a
                                End If
                                Form1.Label5.Text = "Internal IP : " & IpAddressAndSubnet.Address.ToString
                                PrimaryNic.Add("IP Address:".PadRight(15) & IpAddressAndSubnet.Address.ToString)
                                PrimaryNic.Add("Subnet:".PadRight(15) & IpAddressAndSubnet.IPv4Mask.ToString)

                            Next
a:

                        Next

                        ' Get IP gateway information
                        PrimaryNic.Add("Gateway:".PadRight(15) & gatewayAddr.Address.ToString)


                        ' Get IP DNS information
                        Dim DnsAddress As IPAddress

                        For Each DnsAddress In networkCard.GetIPProperties.DnsAddresses

                            PrimaryNic.Add("DNS entry:".PadRight(15) & DnsAddress.ToString)
                        Next

                        ' Other IP information
                        Dim IPProp As IPInterfaceProperties = networkCard.GetIPProperties

                        If Not IPProp Is Nothing Then
                            PrimaryNic.Add("DNS Enabled:".PadRight(15) & IPProp.IsDnsEnabled.ToString)
                            PrimaryNic.Add("Dynamic DNS:".PadRight(15) & IPProp.IsDynamicDnsEnabled.ToString)
                        End If

                        Dim IPv4 As IPv4InterfaceProperties = networkCard.GetIPProperties.GetIPv4Properties

                        If Not IPv4 Is Nothing Then
                            PrimaryNic.Add("DHCP Enabled:".PadRight(15) & IPv4.IsDhcpEnabled.ToString)
                            PrimaryNic.Add("MTU Setting:".PadRight(15) & IPv4.Mtu.ToString)
                            PrimaryNic.Add("Uses WINS:".PadRight(15) & IPv4.UsesWins.ToString)
                        End If
                    End If
                End If
            Next
        Next


    End Sub

    Public Shared Function GetStringBetween(ByVal InputText As String,
                                 ByVal starttext As String,
                                 ByVal endtext As String)

        Dim startPos As Integer
        Dim endPos As Integer
        Dim lenStart As Integer
        startPos = InputText.IndexOf(starttext, StringComparison.CurrentCultureIgnoreCase)
        If startPos >= 0 Then
            lenStart = startPos + starttext.Length
            endPos = InputText.IndexOf(endtext, lenStart, StringComparison.CurrentCultureIgnoreCase)
            If endPos >= 0 Then
                Return InputText.Substring(lenStart, endPos - lenStart)
            End If
        End If
        Return "Something went wrong"
    End Function

    Public Shared Function GetDownloadSpeed()

        Dim webclinetman As New WebClient
        Dim timestop As New Stopwatch
        timestop.Start()
        webclinetman.DownloadFile("http://mirror.internode.on.net/pub/test/1meg.test", My.Application.Info.DirectoryPath & "\data.test")
        timestop.Stop()
        Kill(My.Application.Info.DirectoryPath & "\data.test")
            Return Math.Round((1000000 / (timestop.ElapsedMilliseconds / 1000)) / 1024, 4)

    End Function
End Class
