Imports System.Data.OleDb
Public Class Puja_Delete
    Public con As New OleDbConnection
    Dim cmd As New OleDbCommand("Select * From `વિધી ( વિધાન ) પુજા`", con)
    Dim datareader As OleDbDataReader
    Dim IDS As New ArrayList
    Dim index As Integer
    Private Sub Puja_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            datareader = cmd.ExecuteReader

            IDS.Clear()


            While datareader.Read

                IDS.Add(datareader.GetValue(0))
            End While

            datareader.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Btn_Fst.PerformClick()

    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        cmd.CommandText = "Update `વિધી ( વિધાન ) પુજા` Set Puja_Name='" + Txt_Name.Text.Trim + "', Details='" + Txt_Details.Text.Trim + "' Where ID=" & IDS.Item(index) & ";"

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            MsgBox(cmd.ExecuteNonQuery & " Rows Afected.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Btn_Fst.PerformClick()
        Lbl_Id.Text = "1"

    End Sub

    Private Sub Lbl_Id_TextChanged(sender As Object, e As EventArgs) Handles Lbl_Id.TextChanged
        If (con.ConnectionString = "") Then
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Form1.source
        End If
        cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા`;"
        cmd.Connection = con

        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
            End If
            If Not IsNothing(datareader) Then
                If (Not datareader.IsClosed()) Then
                    datareader.Close()
                End If
            End If


            datareader = cmd.ExecuteReader()

            If (datareader.HasRows) Then
                IDS.Clear()
            End If

            IDS.Clear()

            While (datareader.Read)

                IDS.Add(datareader.GetValue(0))

            End While


            datareader.Close()

        Catch ex As System.InvalidOperationException
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try



        If (IDS.Item(0) = Val(Lbl_Id.Text.Trim)) Then

            Btn_Fst.Enabled = False
            Btn_Pre.Enabled = False

        Else

            Btn_Fst.Enabled = True
            Btn_Pre.Enabled = True

        End If


        If IDS.Item(IDS.Count - 1) = Val(Lbl_Id.Text.Trim) Then

            Btn_Lst.Enabled = False
            Btn_Nxt.Enabled = False

        Else

            Btn_Lst.Enabled = True
            Btn_Nxt.Enabled = True

        End If
    End Sub

    Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click
        cmd.CommandText = "Delete From `વિધી ( વિધાન ) પુજા` Where ID=" & IDS.Item(index)

        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            MsgBox(cmd.ExecuteNonQuery & " Rows Affected.")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
            datareader.Close()
        End Try

        Btn_Fst.PerformClick()
        Lbl_Id.Text = "1"


        index = 0

    End Sub

    Private Sub Btn_Fst_Click(sender As Object, e As EventArgs) Handles Btn_Fst.Click
        If Btn_Fst.Enabled() Then
            index = 0
            cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા` Where ID=" & IDS.Item(index) & " ;"

            Try

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                datareader = cmd.ExecuteReader

                Dim temp(datareader.FieldCount) As String

                If datareader.Read Then

                    For i As Integer = 0 To datareader.FieldCount - 1
                        If Not datareader.IsDBNull(i) Then
                            temp(i) = datareader.GetValue(i)
                        Else
                            temp(i) = ""
                        End If

                    Next


                End If

                Lbl_Id.Text = temp(0)
                Txt_Name.Text = temp(1)
                Txt_Details.Text = temp(2)

                datareader.Close()


            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try


            Lbl_Nbr.Text = (index + 1) & " Of " & IDS.Count

        End If
    End Sub

    Private Sub Btn_Pre_Click(sender As Object, e As EventArgs) Handles Btn_Pre.Click
        If Btn_Pre.Enabled() Then
            If index > -1 Then
                index -= 1
                cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા` Where ID=" & IDS.Item(index) & " ;"

                Try

                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    datareader = cmd.ExecuteReader

                    Dim temp(datareader.FieldCount) As String

                    If datareader.Read Then

                        For i As Integer = 0 To datareader.FieldCount - 1
                            If Not datareader.IsDBNull(i) Then
                                temp(i) = datareader.GetValue(i)
                            Else
                                temp(i) = ""
                            End If

                        Next


                    End If

                    Lbl_Id.Text = temp(0)
                    Txt_Name.Text = temp(1)
                    Txt_Details.Text = temp(2)

                    datareader.Close()


                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                End Try


                Lbl_Nbr.Text = (index + 1) & " Of " & IDS.Count

            End If
        End If
    End Sub

    Private Sub Btn_Nxt_Click(sender As Object, e As EventArgs) Handles Btn_Nxt.Click
        If Btn_Nxt.Enabled() Then
            If index < IDS.Count Then

                index += 1

                cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા` Where ID=" & IDS.Item(index) & " ;"

                Try

                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If

                    datareader = cmd.ExecuteReader

                    Dim temp(datareader.FieldCount) As String

                    If datareader.Read Then

                        For i As Integer = 0 To datareader.FieldCount - 1
                            If Not datareader.IsDBNull(i) Then
                                temp(i) = datareader.GetValue(i)
                            Else
                                temp(i) = ""
                            End If

                        Next


                    End If

                    Lbl_Id.Text = temp(0)
                    Txt_Name.Text = temp(1)
                    Txt_Details.Text = temp(2)


                    datareader.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                End Try



                Lbl_Nbr.Text = (index + 1) & " Of " & IDS.Count


            End If
        End If
    End Sub

    Private Sub Btn_Lst_Click(sender As Object, e As EventArgs) Handles Btn_Lst.Click
        If Btn_Lst.Enabled() Then
            index = IDS.Count - 1
            cmd.CommandText = "Select * From `વિધી ( વિધાન ) પુજા` Where ID=" & IDS.Item(index) & " ;"

            Try

                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                datareader = cmd.ExecuteReader

                Dim temp(datareader.FieldCount) As String

                If datareader.Read Then

                    For i As Integer = 0 To datareader.FieldCount - 1
                        If Not datareader.IsDBNull(i) Then
                            temp(i) = datareader.GetValue(i)
                        Else
                            temp(i) = ""
                        End If

                    Next


                End If

                Lbl_Id.Text = temp(0)
                Txt_Name.Text = temp(1)
                Txt_Details.Text = temp(2)

                datareader.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

            Lbl_Nbr.Text = (index + 1) & " Of " & IDS.Count

        End If
    End Sub

    Private Sub Puja_Delete_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub
End Class