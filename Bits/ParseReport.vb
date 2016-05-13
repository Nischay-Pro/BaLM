Imports System.Xml
Imports System.IO
Imports System.Linq
Imports Parse
Public Module ParseReport
    Public Function GetLocation(ByVal GatewayIP As String)

    End Function

    Public Enum CampusLocation
        Ram_F1
        Ram_F2
        Ram_F3
        Ram_F4
        Krishna_G
        Krishna_F1
        Krishna_F2
        Krishna_F3
        Gandhi_F1
        Gandhi_F2
        Gandhi_F3
        Gandhi_F4
        Budh_F1
        Budh_F2
        Budh_F3
        Budh_f4
        Vyas_F1
        Vyas_F2
        Vyas_F3
        Vyas_F4
        Meera_G
        Meera_F1
        Meera_F2
        Meera_F3
        Malaviya_F1_G
        Malaviya_F2_G
        Malaviya_F3_G
        Malaviya_F4_G
        Malaviya_F5_G
        Malaviya_F1_B
        Malaviya_F2_B
        Malaviya_F3_B
        Malaviya_F4_B
        Malaviya_F5_B
    End Enum
    Public Function GetStats(ByVal Location As CampusLocation)
        'Try
        Select Case Location
                Case CampusLocation.Budh_F1
                    Return GetObjectID("budh", 1)
                Case CampusLocation.Budh_F2
                    Return GetObjectID("budh", 2)
                Case CampusLocation.Budh_F3
                    Return GetObjectID("budh", 3)
                Case CampusLocation.Budh_f4
                    Return GetObjectID("budh", 4)
                Case CampusLocation.Vyas_F1
                    Return GetObjectID("vyas", 1)
                Case CampusLocation.Vyas_F2
                    Return GetObjectID("vyas", 2)
                Case CampusLocation.Vyas_F3
                    Return GetObjectID("vyas", 3)
                Case CampusLocation.Vyas_F4
                    Return GetObjectID("vyas", 4)
                Case CampusLocation.Gandhi_F1
                    Return GetObjectID("gandhi", 1)
                Case CampusLocation.Gandhi_F2
                    Return GetObjectID("gandhi", 2)
                Case CampusLocation.Gandhi_F3
                    Return GetObjectID("gandhi", 3)
                Case CampusLocation.Gandhi_F4
                    Return GetObjectID("gandhi", 4)
                Case CampusLocation.Krishna_G
                    Return GetObjectID("krishna", 1)
                Case CampusLocation.Krishna_F1
                    Return GetObjectID("krishna", 2)
                Case CampusLocation.Krishna_F2
                    Return GetObjectID("krishna", 3)
                Case CampusLocation.Krishna_F3
                    Return GetObjectID("krishna", 4)
                Case CampusLocation.Ram_F1
                    Return GetObjectID("ram", 1)
                Case CampusLocation.Ram_F2
                    Return GetObjectID("ram", 2)
                Case CampusLocation.Ram_F3
                    Return GetObjectID("ram", 3)
                Case CampusLocation.Ram_F4
                    Return GetObjectID("ram", 4)
                Case CampusLocation.Malaviya_F1_B
                    Return GetObjectID("malaviya_boys", 1)
                Case CampusLocation.Malaviya_F2_B
                    Return GetObjectID("malaviya_boys", 2)
                Case CampusLocation.Malaviya_F3_B
                    Return GetObjectID("malaviya_boys", 3)
                Case CampusLocation.Malaviya_F4_B
                    Return GetObjectID("malaviya_boys", 4)
                Case CampusLocation.Malaviya_F5_B
                    Return GetObjectID("malaviya_boys", 5)
                Case CampusLocation.Malaviya_F1_G
                    Return GetObjectID("malaviya_girls", 1)
                Case CampusLocation.Malaviya_F2_G
                    Return GetObjectID("malaviya_girls", 2)
                Case CampusLocation.Malaviya_F3_G
                    Return GetObjectID("malaviya_girls", 3)
                Case CampusLocation.Malaviya_F4_G
                    Return GetObjectID("malaviya_girls", 4)
                Case CampusLocation.Malaviya_F5_G
                    Return GetObjectID("malaviya_girls", 5)
                Case CampusLocation.Meera_G
                    Return GetObjectID("meera", 1)
                Case CampusLocation.Meera_F1
                    Return GetObjectID("meera", 2)
                Case CampusLocation.Meera_F2
                    Return GetObjectID("meera", 3)
                Case CampusLocation.Meera_F3
                    Return GetObjectID("meera", 4)
            End Select
            'Catch ex As Exception
        '   LogGen.WriteToErrorLog(ex, "Failed during campus load")
        '  Return False
        'End Try
    End Function
    Public Function GetObjectID(ByVal bavan As String, ByVal floor As String)
        Dim reader = XDocument.Load(My.Application.Info.DirectoryPath & "\reportdata.xml")

        'Try
        For Each bavanshit In reader.<config>.<results>
            If bavanshit.<bavan>.Value = bavan And bavanshit.<floor>.Value = floor Then
                Dim objShit As String = bavanshit.<objectId>.Value
                Return GetEntireRowData(objShit)
            End If
        Next
        'Catch ex As Exception
        'Return False
        'LogGen.WriteToErrorLog(ex, "Failed In Object ID")
        'End Try
    End Function
    Private Async Function GetEntireRowData(ByVal ObjectID As String) As Task(Of String)
        ParseClient.Initialize("l3UWqIXW4EFSYo2L8GaUqErT6iyUeH4pnNW3Pv6e", "RHkJCF9Rez3cCBO8utyjUE5kGHbsyRi1WQPir3aE")
        Dim abc As New ParseObject("Internet_Status")
        Dim query As ParseQuery(Of ParseObject) = ParseObject.GetQuery("Internet_Status")
        Dim gameScore As ParseObject = Await query.GetAsync(ObjectID)
        Dim getspeed As String = gameScore.Get(Of String)("internetspeed")
        Dim getDate As String = gameScore.Get(Of String)("updatelast")
        Dim getStability As String = gameScore.Get(Of String)("stability")
        Dim getresponsetime As String = gameScore.Get(Of String)("responsetime")
        Dim conact As String = getspeed & ":" & getDate & ":" & getStability & ":" & getresponsetime

        Return Nothing
    End Function

    '  Public Async Function GetChannel(ByVal objectid As String) As Task(Of String)
    ' ParseClient.Initialize("l3UWqIXW4EFSYo2L8GaUqErT6iyUeH4pnNW3Pv6e", "RHkJCF9Rez3cCBO8utyjUE5kGHbsyRi1WQPir3aE")
    'Dim abc As New ParseObject("Dev_Users")
    'Dim query = From gameScore In ParseObject.GetQuery("Dev_Users") Where gameScore.[Get](Of String)("playerName") = "Dan Stemkoski"gameScore
    'Dim results As IEnumerable(Of ParseObject) = Await query.FindAsync()

    'Return getspeed
    'End Function

    Public Async Function UpdateWithNewData(ByVal bavan As String, ByVal floor As String, ByVal internetspeed As String(), ByVal updatelast As String(), ByVal stability As String(), ByVal responsetime As String()) As Task(Of Boolean)
        ParseClient.Initialize("l3UWqIXW4EFSYo2L8GaUqErT6iyUeH4pnNW3Pv6e", "RHkJCF9Rez3cCBO8utyjUE5kGHbsyRi1WQPir3aE")
        Dim gameScore = New ParseObject("Internet_Status") From {
    {"bavan", bavan},
    {"floor", floor},
    {"internetspeed", internetspeed(0)},
    {"updatelast", updatelast(0)},
    {"responsetime", responsetime(0)}
}
        Await gameScore.SaveAsync()

        gameScore("internetspeed") = internetspeed(1)
        gameScore("updatelast") = updatelast(1)
        gameScore("responsetime") = responsetime(1)
        Await gameScore.SaveAsync()
    End Function
End Module
