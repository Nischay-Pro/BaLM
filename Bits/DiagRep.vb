Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Management
Imports System.Xml

Module DiagRep

    Public Function RenewConnection()
        Try
            Dim processman As New Process
            Dim pathman As String = Path.GetPathRoot(Environment.SystemDirectory)
            processman.StartInfo = New ProcessStartInfo()
            processman.StartInfo.FileName = "cmd"
            processman.StartInfo.RedirectStandardInput = True
            processman.StartInfo.RedirectStandardOutput = True
            processman.StartInfo.CreateNoWindow = True
            processman.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            processman.StartInfo.UseShellExecute = False
            processman.Start()
            Dim writecommand As StreamWriter = processman.StandardInput
            writecommand.WriteLine("ipconfig /renew")
            writecommand.Close()
            processman.WaitForExit()
            Return True
        Catch ex As Exception
            LogGen.WriteToErrorLog(ex, "Failed during IP Renew.")
            Return False
        End Try
    End Function
    Public Function CheckInternet()

    End Function
    Public Function GetPrimaryNic2()
        ' DESCRIPTION: this function  will provide networking details for primary network card
        Dim shit As String = Nothing
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
                        shit = networkCard.Description
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
                            If DnsAddress.ToString.Length <= 15 Then
                                shit = shit & "!" & DnsAddress.ToString
                            End If
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
        If PrimaryNic.Count = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function GetPrimaryNic()
        ' DESCRIPTION: this function  will provide networking details for primary network card
        Dim shit As String = Nothing
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
                        shit = networkCard.Description
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
                            If DnsAddress.ToString.Length <= 15 Then
                                shit = shit & "!" & DnsAddress.ToString
                            End If
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
        Return Shit

    End Function
    Public Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Public Function ReLogin()

    End Function

    Public Sub SetNameservers(nicDescription As String, dnsServers As String())
        Using networkConfigMng = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Using networkConfigs = networkConfigMng.GetInstances()
                For Each managementObject In networkConfigs.Cast(Of ManagementObject)().Where(Function(mo) CBool(mo("IPEnabled")) AndAlso DirectCast(mo("Description"), String) = nicDescription)
                    Using newDNS = managementObject.GetMethodParameters("SetDNSServerSearchOrder")
                        newDNS("DNSServerSearchOrder") = dnsServers
                        managementObject.InvokeMethod("SetDNSServerSearchOrder", newDNS, Nothing)
                    End Using
                Next
            End Using
        End Using
    End Sub
    Public Sub CalibrateDNS()
        Dim NICName As String = GetPrimaryNic()
        Dim ActualShit As String() = NICName.Split("!")
        Dim i As Integer = 0
        Dim DNSShit As New ListBox
        For Each shit As String In ActualShit
            If i = 0 Then
                NICName = shit
                i += 1
            Else
                i += 1
                DNSShit.Items.Add(shit)
            End If
        Next
        Dim finalDNSSHit As New ListBox
        For Each Item As String In DNSShit.Items
            i = 0
            Dim avgtime As Integer = 0
            Do Until i = 5
                avgtime = avgtime + DNSRespo.ResolveDNSTime("http://www.goole.com", Item)
                i += 1
            Loop
            finalDNSSHit.Items.Add(Item & "!" & Math.Round(avgtime / 5))
        Next
        Dim finalcrapnetshit As New ListBox
        PopulateDNS()
        For Each Item As String In crapnetshit.Items
            i = 0
            Dim avgtime As Integer = 0
            Do Until i = 5
                avgtime = avgtime + DNSRespo.ResolveDNSTime("http://www.goole.com", Item)
                i += 1
            Loop
            finalcrapnetshit.Items.Add(Item & "!" & Math.Round(avgtime / 5))
        Next
        ' Start Comparing
        Dim finalcomhit As New ListBox
        For Each Item As String In finalDNSSHit.Items
            Dim hdshit As String() = Item.Split("!")
            For Each Item2 As String In finalcrapnetshit.Items
                Dim crapshit As String() = Item2.Split("!")
                If Val(hdshit(1)) < Val(crapshit(1)) Then
                Else
                    finalcomhit.Items.Add(crapshit(0))
                End If
            Next

        Next
        Dim comp(3) As String
        i = 0
        For Each Shit As String In finalcomhit.Items
            MsgBox(Shit)
            comp(i) = Shit
            i += 1
        Next
        SetNameservers(NICName, comp)
        For Each Item As String In comp
            Form1.ShowNotification("Your default DNS Server was slower than Public DNS Servers. Hence " & Item & " was added to replace it.", ToolTipIcon.Info)
        Next
    End Sub
    Dim crapnetshit As New ListBox
    Private Sub PopulateDNS()
        crapnetshit.Items.Clear()
        crapnetshit.Items.Add("8.8.8.8")
        crapnetshit.Items.Add("8.8.4.4")
        crapnetshit.Items.Add("4.2.2.1")
        crapnetshit.Items.Add("4.2.2.2")
    End Sub

    Public Sub RegisterConnection(ByVal selection As Integer, ByVal shit As String)
        Dim writersettings As New XmlWriterSettings
        writersettings.Indent = True
        Dim shitwriter As New StreamWriter(My.Application.Info.DirectoryPath & "\connections.xml", True)

        Dim xmlshit As XmlWriter = XmlWriter.Create(shitwriter, writersettings)
        xmlshit.WriteStartElement("connection")
        xmlshit.WriteStartElement("settings")
        Dim PrimaryNic As New Collection
        Dim internetshit As Integer = 0

        If selection = 1 Then
            xmlshit.WriteElementString("Type_of_Connection", "LAN Direct Connection")
        Else
            xmlshit.WriteElementString("Type_of_Connection", "WLAN Wi-Fi Connection")
        End If
        xmlshit.WriteElementString("Bavan_Access_From", shit)
        For Each networkCard As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces
            For Each gatewayAddr As GatewayIPAddressInformation In networkCard.GetIPProperties.GatewayAddresses

                If internetshit = 0 Then

                    If gatewayAddr.Address.ToString <> "0.0.0.0" And networkCard.OperationalStatus.ToString() = "Up" Then

                        If networkCard.GetIPProperties.DnsSuffix <> "" Then
                            internetshit += 1
                            xmlshit.WriteElementString("Network_Card_ID", networkCard.Id)
                            xmlshit.WriteElementString("Network_Card_Name", networkCard.Name)
                            xmlshit.WriteElementString("Network_Card_Description", networkCard.Description)
                            xmlshit.WriteElementString("Network_Card_Speed", (networkCard.Speed / 1000000).ToString("#,000") & " Mbps")
                            xmlshit.WriteElementString("Network_Card_Physical_Address", networkCard.GetPhysicalAddress.ToString)

                            Dim IpAddressAndSubnet As UnicastIPAddressInformation

                            For Each IpAddressAndSubnet In networkCard.GetIPProperties.UnicastAddresses
                                Dim ipaddress As String = IpAddressAndSubnet.Address.ToString
                                Dim striman As String() = ipaddress.Split(".")
                                Dim ik As Integer = 1
                                For Each Item As String In striman
                                    If Item.Length = 3 Then
                                    Else
                                        GoTo a
                                    End If
                                    xmlshit.WriteElementString("Internal_IP-" & ik & "", IpAddressAndSubnet.Address.ToString)
                                    xmlshit.WriteElementString("Subnet_Mask_-" & ik & "", IpAddressAndSubnet.IPv4Mask.ToString)
                                    ik += 1
                                Next
a:

                            Next
                            xmlshit.WriteElementString("Gateway_IP", gatewayAddr.Address.ToString)
                            Dim DnsAddress As IPAddress
                            Dim i As Integer = 1
                            For Each DnsAddress In networkCard.GetIPProperties.DnsAddresses

                                xmlshit.WriteElementString("DNS_Address-" & i & "", DnsAddress.ToString)
                                i += 1
                            Next
                            Dim IPProp As IPInterfaceProperties = networkCard.GetIPProperties

                            If Not IPProp Is Nothing Then
                                xmlshit.WriteElementString("DNS_Enabled", IPProp.IsDnsEnabled.ToString)
                                xmlshit.WriteElementString("Dynamic_DNS", IPProp.IsDynamicDnsEnabled.ToString)
                            End If

                            Dim IPv4 As IPv4InterfaceProperties = networkCard.GetIPProperties.GetIPv4Properties

                            If Not IPv4 Is Nothing Then
                                xmlshit.WriteElementString("DHCP_Enabled", IPv4.IsDhcpEnabled.ToString)
                                xmlshit.WriteElementString("MTU_Settings", IPv4.Mtu.ToString)
                                xmlshit.WriteElementString("WINS", IPv4.UsesWins.ToString)
                            End If
                        End If
                    End If
                End If
            Next
        Next

        xmlshit.WriteEndElement()
        xmlshit.WriteEndElement()
        xmlshit.Close()
        shitwriter.Flush()
        shitwriter.Close()
    End Sub
End Module
