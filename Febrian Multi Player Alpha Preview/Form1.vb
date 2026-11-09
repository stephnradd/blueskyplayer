Public Class Form1

    Dim mouseOffset As Point

    Private Sub MainForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MainForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WindowState = 1
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If WindowState = 0 Then
            WindowState = 2
            PictureBox2.Image = My.Resources.smn

        Else
            WindowState = 0
            PictureBox2.Image = My.Resources.bigss

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanduanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form9.ShowDialog()
    End Sub
End Class
