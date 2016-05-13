Imports System.ComponentModel

Public Class browser
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub WebBrowser1_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
    End Sub
End Class