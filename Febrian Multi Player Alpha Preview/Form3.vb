Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Produk ini telah diunduh atas nama : " & Environment.UserName
    End Sub
End Class