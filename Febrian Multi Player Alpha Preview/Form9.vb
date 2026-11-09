Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedTab = TabPage4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub

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
End Class