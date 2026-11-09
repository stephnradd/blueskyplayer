Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Dim mouseOffset As Point

    Private Sub MainForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub MainForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Close()
    End Sub
End Class