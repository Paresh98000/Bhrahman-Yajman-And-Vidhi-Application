Imports System.Data.OleDb
Public Class Karma_Form
    Public con As New OleDbConnection
    Dim cmd As New OleDbCommand("Select * from કર્મો;", con)
    Dim datareader As OleDbDataReader
    Dim IDS_Y As New ArrayList
    Dim IDS_B As New ArrayList
    Dim IDS_P As New ArrayList

    Private Sub Karma_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            cmd.CommandText = "Select * from યજમાન;"
            con.Open()
            datareader = cmd.ExecuteReader
            While (datareader.Read)
                IDS_Y.Add(datareader.GetValue(0))
                Cmb_Yajaman.Items.Add(datareader.GetValue(1) + " " + datareader.GetValue(2) + " " + datareader.GetValue(3))
            End While

            datareader.Close()

            cmd.CommandText = "Select * from બ્રાહ્મણ;"
            datareader = cmd.ExecuteReader

            While (datareader.Read)
                IDS_B.Add(datareader.GetValue(0))
                Cmb_Brahman.Items.Add(datareader.GetValue(1) + " " + datareader.GetValue(2) + " " + datareader.GetValue(3))
            End While

            datareader.Close()

            cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા`;"
            datareader = cmd.ExecuteReader

            While (datareader.Read)
                IDS_P.Add(datareader.GetValue(0))
                Cmb_Puja.Items.Add(datareader.GetValue(1))
            End While

            datareader.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Karma_Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True

    End Sub

    Private Sub Date_Karma_ValueChanged(sender As Object, e As EventArgs) Handles Date_Karma.ValueChanged
        If Date_Karma.Value < Now.Date Then
            Radio_Done.Checked = True
        Else
            Radio_Not_Done.Checked = True
        End If
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim yajaman As New OleDbCommand
        Dim brahman As New OleDbCommand
        Dim puja As New OleDbCommand


        Dim don As String
        If Radio_Done.Checked = True Then
            don = "Yes"
        Else
            don = "No"
        End If

        yajaman.Connection = con
        brahman.Connection = con
        puja.Connection = con
        Dim names() As String = Cmb_Yajaman.SelectedItem.ToString.Split(" ")
        yajaman.CommandText = "Select ID from યજમાન Where Yajaman_Name='" + names(0) + "' and Surname='" + names(1) + "' and `Fathers Name`='" + names(2) + "' ;"
        names = Cmb_Brahman.SelectedItem.ToString.Split(" ")
        brahman.CommandText = "Select ID from બ્રાહ્મણ Where Brahman_Name='" + names(0) + "' and Surname='" + names(1) + "' and `Fathers Name`='" + names(2) + "' ;"
        names(0) = Cmb_Puja.SelectedItem
        puja.CommandText = "Select ID from `વિધી ( વિધાન ) પુજા` Where Puja_Name = '" + names(0) + "' ;"


        Try
            con.Open()

            cmd.CommandText = "Insert Into કર્મો (Yajaman, Puja, Brahman,Puja_Date,P_Time,Done,Address,Details) values (" & yajaman.ExecuteScalar & "," & puja.ExecuteScalar & "," & brahman.ExecuteScalar & ",'" + Date_Karma.Value.ToShortDateString + "','" + Time_Karma.Value.ToShortTimeString + "'," + don + ", '" + Txt_Address.Text.Trim + "', '" + Txt_Details.Text.Trim + "') ;"


            If Not datareader.IsClosed Then
                datareader.Close()
            End If
            MsgBox(cmd.ExecuteNonQuery & " Recorde is Inserted.", MsgBoxStyle.Information, "Insert")



        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Lbl_Address_Click(sender As Object, e As EventArgs) Handles Lbl_Address.Click, Lbl_Details.Click

    End Sub
End Class