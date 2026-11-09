Public Class Form22

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Close()
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Form1.BackColor = Color.Cyan
        Form2.BackColor = Color.Cyan
        Form3.BackColor = Color.Cyan
        Form4.BackColor = Color.Cyan
        Form5.BackColor = Color.Cyan
        Form6.BackColor = Color.Cyan
        Form7.BackColor = Color.Cyan
        Form8.BackColor = Color.Cyan
        Form9.BackColor = Color.Cyan
        Form11.BackColor = Color.Cyan
        Form12.BackColor = Color.Cyan
        Form18.BackColor = Color.Cyan
        Form21.BackColor = Color.Cyan
        Me.BackColor = Color.Cyan
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        Form1.BackColor = Color.Magenta
        Form2.BackColor = Color.Magenta
        Form3.BackColor = Color.Magenta
        Form4.BackColor = Color.Magenta
        Form5.BackColor = Color.Magenta
        Form6.BackColor = Color.Magenta
        Form7.BackColor = Color.Magenta
        Form8.BackColor = Color.Magenta
        Form9.BackColor = Color.Magenta
        Form11.BackColor = Color.Magenta
        Form12.BackColor = Color.Magenta
        Form18.BackColor = Color.Magenta
        Form21.BackColor = Color.Magenta
        Me.BackColor = Color.Magenta
    End Sub
End Class