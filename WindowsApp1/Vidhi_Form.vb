Imports System.Data.OleDb
Public Class Vidhi_Form
    Dim cmd As New OleDbCommand
    Public con As New OleDbConnection
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        If con.ConnectionString IsNot "" Then
            cmd.CommandText = "Insert Into `વિધી ( વિધાન ) પુજા` (Puja_Name,Details) values ('" + Txt_Name.Text + "', '" + Txt_Details.Text + "');"
            cmd.Connection = con
            Try
                con.Open()
                MsgBox(cmd.ExecuteNonQuery & " Recorde Inserted.")
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Vidhi_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Vidhi_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub
End Class