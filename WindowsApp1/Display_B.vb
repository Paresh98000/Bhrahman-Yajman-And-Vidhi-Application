Public Class Display_B

    Private Sub Display_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Display_B_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Display_B_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim s As New Drawing.Size
        s.Height = Me.Size.Height - 200
        s.Width = Me.Size.Width - 50
        DGV_Display_B.Size = s
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs)
    End Sub
End Class