
Public Class internettype
    Dim selected As Integer = 0
    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, PictureBox1.MouseEnter, Label2.MouseEnter
        If selected = 0 Then
            Panel1.BackColor = Color.FromArgb(70, 91, 94)
            PictureBox1.BackColor = Color.FromArgb(70, 91, 94)
        End If
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave, PictureBox1.MouseEnter, Label2.MouseLeave
        If selected = 0 Then
            Panel1.BackColor = Color.Transparent
            PictureBox1.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter, PictureBox2.MouseEnter, Label4.MouseEnter
        If selected = 0 Then
            Panel2.BackColor = Color.FromArgb(70, 91, 94)
            PictureBox2.BackColor = Color.FromArgb(70, 91, 94)
        End If
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave, PictureBox2.MouseLeave, Label4.MouseLeave
        If selected = 0 Then
            Panel2.BackColor = Color.Transparent
            PictureBox2.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, PictureBox1.Click, Label2.Click
        Panel1.BackColor = Color.FromArgb(70, 91, 94)
        PictureBox1.BackColor = Color.FromArgb(70, 91, 94)
        Panel2.BackColor = Color.Transparent
        PictureBox2.BackColor = Color.Transparent
        selected = 1
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click, PictureBox2.Click, Label4.Click
        Panel2.BackColor = Color.FromArgb(70, 91, 94)
        PictureBox2.BackColor = Color.FromArgb(70, 91, 94)
        Panel1.BackColor = Color.Transparent
        PictureBox1.BackColor = Color.Transparent
        selected = 2
    End Sub

    Private Sub internettype_Load(sender As Object, e As EventArgs) Handles Me.Load
        FlatComboBox1.SelectedIndex = 0
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If selected = 0 Then
            MsgBox("Please select your connection type before proceeding.", MsgBoxStyle.Exclamation, "Error")
        Else
            RegisterConnection(selected, FlatComboBox1.Text)
            Form1.networkaccess = True
            Form1.Show()
            DNSRespo.SetupTheIP()
            Me.Close()
        End If
    End Sub
End Class