Imports System.Data.OleDb
Public Class Yajaman_Form
    Dim address As Boolean = False
    Public con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Hp\OneDrive\Database\GayatryAstroComp.mdb")
    Dim cmd As New OleDbCommand("Select * from યજમાન", con)
    Private Sub Yajaman_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Detail_GotFocus(sender As Object, e As EventArgs) Handles Txt_Detail.GotFocus
        If Not address Then
            address = True
            Txt_Detail.Text = ""
        End If
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        Dim temp As String = "' , '"
        cmd.CommandText = "Insert into યજમાન (Yajaman_Name,Surname,`Fathers Name`,`Contac No`,`Phone No`,`Email Id`,Address,Other_Details) values ( '" + Txt_Name.Text + temp + Txt_SurName.Text + temp + Txt_Fathers_Name.Text + temp + Txt_Contact.Text + temp + Txt_Phone.Text + temp + Txt_Mail.Text + temp + Txt_Address.Text + temp + Txt_Detail.Text + "');"

        Try
            con.Open()
            MsgBox(cmd.ExecuteNonQuery & " Recorde is Inserted.", MsgBoxStyle.Information, "Insert")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Yajaman_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click



    End Sub

    Private Sub Txt_Address_TextChanged(sender As Object, e As EventArgs) Handles Txt_Address.TextChanged

    End Sub
End Class