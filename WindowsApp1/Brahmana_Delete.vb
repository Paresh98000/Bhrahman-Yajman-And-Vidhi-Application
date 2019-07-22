Imports System.Data.OleDb
Public Class Brahmana_Delete
    Public con As New OleDbConnection("")
    Dim cmd As New OleDbCommand
    Dim dr As OleDbDataReader
    Dim IDS As New ArrayList()
    Dim index As Integer
    Private Sub Brahmana_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = con
        Txt_Detail.Text = ""



        Try

            con.Open()
            cmd.CommandText = "Select * from બ્રાહ્મણ;"
            dr = cmd.ExecuteReader

            IDS.Clear()

            While (dr.Read)
                IDS.Add(Val(dr.GetValue(0)))
            End While

            dr.Close()

            index = 0

            cmd.CommandText = "Select * from બ્રાહ્મણ Where ID=1;"
            dr = cmd.ExecuteReader()

            With dr
                If (.Read()) Then


                    Lbl_Id.Text = .GetValue(0)
                    Txt_Name.Text = .GetValue(1)
                    Txt_SurName.Text = .GetValue(2)
                    Txt_Fathers_Name.Text = .GetValue(3)
                    Txt_Contact.Text = .GetValue(4)
                    Txt_Gautra.Text = .GetValue(6)
                    If (Not .IsDBNull(5)) Then
                        Txt_Address.Text = .GetValue(5)
                    End If
                    If (Not .IsDBNull(7)) Then
                        Txt_Detail.Text = .GetValue(7)
                    End If
                End If
                .Close()
            End With

            cmd.CommandText = "Select Count(*) From બ્રાહ્મણ;"

            Lbl_Nbr.Text = (index + 1) & " of " & cmd.ExecuteScalar

        Catch ex1 As System.InvalidCastException
            MsgBox(ex1.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally


            con.Close()

        End Try



    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click

        cmd.CommandText = "Update બ્રાહ્મણ Set Brahman_Name='" + Txt_Name.Text + "' , Surname='" + Txt_SurName.Text + "', `Fathers Name`='" + Txt_Fathers_Name.Text + "', `Phone No`='" + Txt_Contact.Text + "', Address='" + Txt_Address.Text + "', Goutra='" + Txt_Gautra.Text + "', Details='" + Txt_Detail.Text + "' Where ID=" & IDS.Item(index) & ";"
        Try
            con.Open()

            MsgBox(cmd.ExecuteNonQuery())

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Btn_Fst.PerformClick()

    End Sub

    Private Sub Brahmana_Delete_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Btn_Del_Click(sender As Object, e As EventArgs) Handles Btn_Del.Click

        cmd.CommandText = "Delete From બ્રાહ્મણ Where ID=" + Lbl_Id.Text.Trim() + ";"

        Try
            con.Open()
            MsgBox(cmd.ExecuteNonQuery & " Recorde is Deleted.", MsgBoxStyle.Information, "Delete")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Btn_Lst.PerformClick()

    End Sub

    Private Sub Btn_Fst_Click(sender As Object, e As EventArgs) Handles Btn_Fst.Click


        Txt_Detail.Text = ""
        cmd.CommandText = "Select * from બ્રાહ્મણ Where ID=" & IDS.Item(0) & ";"
        index = 0
        If (Btn_Fst.Enabled) Then
            Try
                con.Open()
                If Not IsNothing(dr) Then
                    If Not (dr.IsClosed) Then
                        dr.Close()
                    End If
                End If


                dr = cmd.ExecuteReader

                With dr
                    If (.Read()) Then

                        Dim s As String = ""
                        For i As Integer = 0 To dr.FieldCount - 1
                            If Not dr.IsDBNull(i) Then
                                s += "|" & .GetValue(i)
                            Else
                                s += "|" & "  "
                            End If

                        Next

                        Dim s1() = s.Split("|")

                        Lbl_Id.Text = s1(1)

                        Txt_Name.Text = s1(2)
                        Txt_SurName.Text = s1(3)
                        Txt_Fathers_Name.Text = s1(4)
                        Txt_Contact.Text = s1(5)
                        Txt_Gautra.Text = s1(7)
                        Txt_Address.Text = s1(6)
                        Txt_Detail.Text = s1(8)


                    End If
                    .Close()
                End With

                Lbl_Nbr.Text = (index + 1) & " of " & IDS.Count


            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If

    End Sub

    Private Sub Btn_Lst_Click(sender As Object, e As EventArgs) Handles Btn_Lst.Click
        index = IDS.Count - 1
        Txt_Detail.Text = ""
        cmd.CommandText = "Select * from બ્રાહ્મણ Where ID=" & IDS.Item(IDS.Count - 1) & ";"

        If (Btn_Lst.Enabled) Then
            Try
                con.Open()
                If Not IsNothing(dr) Then
                    If Not (dr.IsClosed) Then
                        dr.Close()
                    End If
                End If


                dr = cmd.ExecuteReader

                With dr
                    If (.Read()) Then

                        Dim s As String = ""
                        For i As Integer = 0 To dr.FieldCount - 1
                            If Not dr.IsDBNull(i) Then
                                s += "|" & .GetValue(i)
                            Else
                                s += "|" & "  "
                            End If

                        Next

                        Dim s1() = s.Split("|")

                        Lbl_Id.Text = s1(1)

                        Txt_Name.Text = s1(2)
                        Txt_SurName.Text = s1(3)
                        Txt_Fathers_Name.Text = s1(4)
                        Txt_Contact.Text = s1(5)
                        Txt_Gautra.Text = s1(7)
                        Txt_Address.Text = s1(6)
                        Txt_Detail.Text = s1(8)


                    End If
                    .Close()
                End With

                Lbl_Nbr.Text = (index + 1) & " of " & IDS.Count


            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try
        End If


    End Sub

    Private Sub Btn_Pre_Click(sender As Object, e As EventArgs) Handles Btn_Pre.Click
        If index > -1 Then
            index -= 1

            cmd.CommandText = "Select * from બ્રાહ્મણ Where ID=" & IDS.Item(index) & ";"

            If (Btn_Pre.Enabled) Then
                Try
                    con.Open()
                    If Not IsNothing(dr) Then
                        If Not (dr.IsClosed) Then
                            dr.Close()
                        End If
                    End If


                    dr = cmd.ExecuteReader

                    With dr
                        If (.Read()) Then

                            Dim s As String = ""
                            For i As Integer = 0 To dr.FieldCount - 1
                                If Not dr.IsDBNull(i) Then
                                    s += "|" & .GetValue(i)
                                Else
                                    s += "|" & "  "
                                End If

                            Next
                            Dim s1() = s.Split("|")

                            Lbl_Id.Text = s1(1)

                            Txt_Name.Text = s1(2)
                            Txt_SurName.Text = s1(3)
                            Txt_Fathers_Name.Text = s1(4)
                            Txt_Contact.Text = s1(5)
                            Txt_Gautra.Text = s1(7)
                            Txt_Address.Text = s1(6)
                            Txt_Detail.Text = s1(8)


                        End If
                        .Close()
                    End With

                    Lbl_Nbr.Text = (index + 1) & " of " & IDS.Count


                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                End Try
            End If

        End If



    End Sub

    Private Sub Lbl_Id_TextChanged(sender As Object, e As EventArgs) Handles Lbl_Id.TextChanged
        If (con.ConnectionString = "") Then
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Form1.source
        End If
        cmd.CommandText = "Select * from બ્રાહ્મણ;"
        cmd.Connection = con

        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
            End If
            If Not IsNothing(dr) Then
                If (Not dr.IsClosed()) Then
                    dr.Close()
                End If
            End If


            dr = cmd.ExecuteReader()

            If (dr.HasRows) Then
                IDS.Clear()
            End If

            While (dr.Read)

                IDS.Add(dr.GetValue(0))

            End While


            dr.Close()

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

    Private Sub Btn_Nxt_Click(sender As Object, e As EventArgs) Handles Btn_Nxt.Click
        If index < IDS.Count Then
            index += 1
            cmd.CommandText = "Select * from બ્રાહ્મણ Where ID=" & IDS.Item(index) & ";"

            If (Btn_Nxt.Enabled) Then
                Try
                    con.Open()
                    If Not IsNothing(dr) Then
                        If Not (dr.IsClosed) Then
                            dr.Close()
                        End If
                    End If


                    dr = cmd.ExecuteReader

                    With dr
                        If (.Read()) Then

                            Dim s As String = ""
                            For i As Integer = 0 To dr.FieldCount - 1
                                If Not dr.IsDBNull(i) Then
                                    s += "|" & .GetValue(i)
                                Else
                                    s += "|" & "  "
                                End If

                            Next

                            Dim s1() = s.Split("|")

                            Lbl_Id.Text = s1(1)

                            Txt_Name.Text = s1(2)
                            Txt_SurName.Text = s1(3)
                            Txt_Fathers_Name.Text = s1(4)
                            Txt_Contact.Text = s1(5)
                            Txt_Gautra.Text = s1(7)
                            Txt_Address.Text = s1(6)
                            Txt_Detail.Text = s1(8)


                        End If
                        .Close()
                    End With

                    Lbl_Nbr.Text = (index + 1) & " of " & IDS.Count


                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    con.Close()
                End Try
            End If
        End If


    End Sub
End Class