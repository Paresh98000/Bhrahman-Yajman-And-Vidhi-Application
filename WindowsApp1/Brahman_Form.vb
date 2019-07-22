Imports System.Data.OleDb
Public Class Brahman_Form
    Dim address As Boolean = False
    Public con As New OleDbConnection
    Dim cmd As New OleDbCommand

    Private Sub Txt_Detail_GotFocus(sender As Object, e As EventArgs) Handles Txt_Detail.GotFocus
        If Not address Then
            address = True
            Txt_Detail.Text = ""
        End If
    End Sub

    Private Sub Brahman_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Brahman_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        cmd.Connection = con
        Dim temp As String = "' , '"
        cmd.CommandText = "Insert into બ્રાહ્મણ (Brahman_Name,Surname,`Fathers Name`,`Phone No`,Address,Goutra,Details) values ( '" + Txt_Name.Text + temp + Txt_SurName.Text + temp + Txt_Fathers_Name.Text + temp + Txt_Contact.Text + temp + Txt_Address.Text + temp + Txt_Gautra.Text + temp + Txt_Detail.Text + "');"
        Try
            con.Open()
            MsgBox(cmd.ExecuteNonQuery & " Recorde is Inserted.", MsgBoxStyle.Information, "Insert")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

    End Sub

End Class