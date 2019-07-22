Imports System.Data.OleDb
Public Class Karma_Delete
    Public con As New OleDbConnection("")
    Dim cmd As New OleDbCommand
    Dim dr, datareader As OleDbDataReader
    Dim IDS As New ArrayList()
    Dim index As Integer
    Dim IDS_Y As New ArrayList
    Dim IDS_B As New ArrayList
    Dim IDS_P As New ArrayList
    Dim yajaman As New OleDbCommand
    Dim brahman As New OleDbCommand
    Dim puja As New OleDbCommand

    Private Sub Karma_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmd.Connection = con
        yajaman.Connection = con
        brahman.Connection = con
        puja.Connection = con
        cmd.CommandText = "Select * from યજમાન;"
        Try
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



        Try

            con.Open()
            cmd.CommandText = "Select * from કર્મો;"
            dr = cmd.ExecuteReader

            IDS.Clear()

            While (dr.Read)
                IDS.Add(Val(dr.GetValue(0)))
            End While

            dr.Close()

            index = 0



            cmd.CommandText = "Select * from કર્મો Where ID=" & IDS.Item(0) & ";"
            dr = cmd.ExecuteReader()

            With dr
                If (.Read()) Then

                    Lbl_Id.Text = .GetValue(0)
                    If Not .IsDBNull(1) Then
                        yajaman.CommandText = "Select Yajaman_Name,Surname,`Fathers Name` from યજમાન where ID=" & .GetValue(1) & ";"
                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Yajaman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                    End If
                    If Not .IsDBNull(2) Then
                        puja.CommandText = "Select Puja_Name from `વિધી ( વિધાન ) પુજા` where ID=" & .GetValue(2) & ";"
                        Cmb_Puja.Text = puja.ExecuteScalar
                    End If
                    If Not .IsDBNull(3) Then
                        yajaman.CommandText = "Select Brahman_Name,Surname,`Fathers Name` from બ્રાહ્મણ where ID=" & .GetValue(3) & ";"
                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Brahman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                    End If

                    If Not .IsDBNull(4) Then
                        Date_Karma.Value = .GetValue(4)
                    End If

                    If Not .IsDBNull(5) Then
                        Dim d As Date = Date.Parse(.GetValue(5))
                        'Dim min As Date = Time_Karma.MinDate
                        'min = min.AddHours(d.Hour)
                        'min = min.AddMinutes(d.Minute)
                        Time_Karma.Value = d
                    End If

                    If .GetValue(6) = True Or .GetValue(6) = Boolean.TrueString Then
                        Radio_Done.Checked = True
                    Else
                        Radio_Not_Done.Checked = True
                    End If

                    If Not .IsDBNull(7) Then
                        Txt_Address.Text = .GetValue(7)
                    End If

                    If Not .IsDBNull(8) Then
                        Txt_Details.Text = .GetValue(8)
                    End If


                    .Close()

                End If

            End With



            Lbl_Nbr.Text = (index + 1) & " of " & IDS.Count

        Catch ex1 As System.InvalidCastException
            MsgBox(ex1.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally


            con.Close()

        End Try


    End Sub

    Private Sub Karma_Delete_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim s_temp() As String = Cmb_Yajaman.Text.Trim.Split(" ")

        yajaman.CommandText = "Select ID from યજમાન Where (Yajaman_Name='" + s_temp(0) + "' and Surname='" + s_temp(1) + "') and `Fathers Name`='" + s_temp(2) + "' ;"

        s_temp = Cmb_Brahman.Text.Trim.Split(" ")

        brahman.CommandText = "Select ID from બ્રાહ્મણ Where (Brahman_Name='" + s_temp(0) + "' and Surname='" + s_temp(1) + "') and (`Fathers Name`='" + s_temp(2) + "') ;"

        puja.CommandText = "Select ID from `વિધી ( વિધાન ) પુજા` Where Puja_Name='" + Cmb_Puja.Text.Trim + "';"
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim b As Boolean
        If Radio_Done.Checked = True Then
            b = True
        Else
            b = False
        End If

        cmd.CommandText = "Update કર્મો Set Yajaman=" & yajaman.ExecuteScalar & ", Brahman=" & brahman.ExecuteScalar & ", Puja=" & puja.ExecuteScalar & " , Puja_Date= '" & Date_Karma.Value.ToShortDateString & "' , P_Time= '" & Time_Karma.Value.ToShortTimeString & "' , Done=" & b & ", Address='" + Txt_Address.Text.Trim + "', Details='" + Txt_Details.Text.Trim() + "' Where ID=" & IDS.Item(index) & ";"
        'MsgBox(cmd.CommandText)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            MsgBox(cmd.ExecuteNonQuery())

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try

        Btn_Fst.PerformClick()

    End Sub

    Private Sub Btn_Fst_Click(sender As Object, e As EventArgs) Handles Btn_Fst.Click
        If Btn_Fst.Enabled = True Then

            index = 0

            Try
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Open()

                If Not IsNothing(dr) Then
                    If Not (dr.IsClosed) Then
                        dr.Close()
                    End If
                End If

                cmd.CommandText = "Select * from કર્મો Where ID=" & IDS.Item(index) & ";"
                dr = cmd.ExecuteReader()

                With dr

                    If (.Read()) Then

                        Dim string1(.FieldCount) As String
                        For i As Integer = 0 To .FieldCount - 1
                            If Not .IsDBNull(i) Then
                                string1(i) = .GetValue(i)
                            Else
                                string1(i) = ""
                            End If
                        Next

                        Lbl_Id.Text = string1(0)

                        'If Not .IsDBNull(1) Then
                        yajaman.CommandText = "Select Yajaman_Name,Surname,`Fathers Name` from યજમાન where ID=" & string1(1) & ";"

                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If

                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Yajaman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                        'End If
                        'If Not .IsDBNull(2) Then
                        puja.CommandText = "Select Puja_Name from `વિધી ( વિધાન ) પુજા` where ID=" & string1(2) & ";"
                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If
                        Cmb_Puja.Text = puja.ExecuteScalar
                        'End If
                        'If Not .IsDBNull(3) Then
                        yajaman.CommandText = "Select Brahman_Name,Surname,`Fathers Name` from બ્રાહ્મણ where ID=" & string1(3) & ";"
                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If
                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Brahman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                        'End If

                        'If Not .IsDBNull(4) Then
                        Date_Karma.Value = string1(4)
                        'End If

                        'If Not .IsDBNull(5) Then
                        Dim d As Date = string1(5)
                        Dim min As Date = Time_Karma.MinDate
                        min = min.AddHours(d.Hour)
                        min = min.AddMinutes(d.Minute)
                        Time_Karma.Value = min


                        'End If

                        If string1(6) = "Yes" Or string1(6) = "True" Then
                            Radio_Done.Checked = True
                        Else
                            Radio_Not_Done.Checked = True
                        End If

                        Txt_Address.Text = string1(7)
                        Txt_Details.Text = string1(8)



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
        If index > 0 Then
            index -= 1

            If (Btn_Pre.Enabled) Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                    con.Open()

                    If Not IsNothing(dr) Then
                        If Not (dr.IsClosed) Then
                            dr.Close()
                        End If
                    End If

                    cmd.CommandText = "Select * from કર્મો Where ID=" & IDS.Item(index) & ";"
                    dr = cmd.ExecuteReader()
                    'MsgBox(IDS.Item(index))
                    With dr

                        If (.Read()) Then

                            Dim string1(.FieldCount) As String
                            For i As Integer = 0 To .FieldCount - 1
                                If Not .IsDBNull(i) Then
                                    string1(i) = .GetValue(i)
                                Else
                                    string1(i) = ""
                                End If
                            Next

                            Lbl_Id.Text = string1(0)

                            'If Not .IsDBNull(1) Then
                            yajaman.CommandText = "Select Yajaman_Name,Surname,`Fathers Name` from યજમાન where ID=" & string1(1) & ";"

                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If

                            datareader = yajaman.ExecuteReader
                            datareader.Read()
                            Cmb_Yajaman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                            datareader.Close()
                            'End If
                            'If Not .IsDBNull(2) Then
                            puja.CommandText = "Select Puja_Name from `વિધી ( વિધાન ) પુજા` where ID=" & string1(2) & ";"
                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If
                            Cmb_Puja.Text = puja.ExecuteScalar
                            'End If
                            'If Not .IsDBNull(3) Then
                            yajaman.CommandText = "Select Brahman_Name,Surname,`Fathers Name` from બ્રાહ્મણ where ID=" & string1(3) & ";"
                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If
                            datareader = yajaman.ExecuteReader
                            datareader.Read()
                            Cmb_Brahman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                            datareader.Close()
                            'End If

                            'If Not .IsDBNull(4) Then
                            Date_Karma.Value = string1(4)
                            'End If

                            'If Not .IsDBNull(5) Then
                            Dim d As Date = string1(5)
                            Dim min As Date = Time_Karma.MinDate
                            min = min.AddHours(d.Hour)
                            min = min.AddMinutes(d.Minute)
                            Time_Karma.Value = min


                            'End If

                            If string1(6) = "Yes" Or string1(6) = "True" Then
                                Radio_Done.Checked = True
                            Else
                                Radio_Not_Done.Checked = True
                            End If

                            Txt_Address.Text = string1(7)
                            Txt_Details.Text = string1(8)



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

    Private Sub Btn_Lst_Click(sender As Object, e As EventArgs) Handles Btn_Lst.Click
        index = IDS.Count - 1

        If (Btn_Lst.Enabled) Then
            Try

                If con.State = ConnectionState.Open Then
                    con.Close()
                End If

                con.Open()

                If Not IsNothing(dr) Then
                    If Not (dr.IsClosed) Then
                        dr.Close()
                    End If
                End If

                cmd.CommandText = "Select * from કર્મો Where ID=" & IDS.Item(index) & ";"
                dr = cmd.ExecuteReader()

                With dr

                    If (.Read()) Then

                        Dim string1(.FieldCount) As String

                        For i As Integer = 0 To .FieldCount - 1
                            If Not .IsDBNull(i) Then
                                string1(i) = .GetValue(i)
                            Else
                                string1(i) = ""
                            End If
                        Next

                        Lbl_Id.Text = string1(0)

                        'If Not .IsDBNull(1) Then
                        yajaman.CommandText = "Select Yajaman_Name,Surname,`Fathers Name` from યજમાન where ID=" & string1(1) & ";"

                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If

                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Yajaman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                        'End If
                        'If Not .IsDBNull(2) Then
                        puja.CommandText = "Select Puja_Name from `વિધી ( વિધાન ) પુજા` where ID=" & string1(2) & ";"
                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If
                        Cmb_Puja.Text = puja.ExecuteScalar
                        'End If
                        'If Not .IsDBNull(3) Then
                        yajaman.CommandText = "Select Brahman_Name,Surname,`Fathers Name` from બ્રાહ્મણ where ID=" & string1(3) & ";"
                        If con.State = ConnectionState.Closed Then
                            con.Open()

                        End If
                        datareader = yajaman.ExecuteReader
                        datareader.Read()
                        Cmb_Brahman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                        datareader.Close()
                        'End If

                        'If Not .IsDBNull(4) Then
                        Date_Karma.Value = string1(4)
                        'End If

                        'If Not .IsDBNull(5) Then
                        Dim d As Date = string1(5)
                        Dim min As Date = Time_Karma.MinDate
                        min = min.AddHours(d.Hour)
                        min = min.AddMinutes(d.Minute)
                        Time_Karma.Value = min


                        'End If

                        If string1(6) = "Yes" Or string1(6) = "True" Then
                            Radio_Done.Checked = True
                        Else
                            Radio_Not_Done.Checked = True
                        End If


                        Txt_Address.Text = string1(7)
                        Txt_Details.Text = string1(8)

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

    Private Sub Btn_Nxt_Click(sender As Object, e As EventArgs) Handles Btn_Nxt.Click
        If index < IDS.Count Then
            index += 1

            If Btn_Nxt.Enabled = True Then
                Try
                    If con.State = ConnectionState.Open Then
                        con.Close()
                    End If

                    con.Open()

                    If Not IsNothing(dr) Then
                        If Not (dr.IsClosed) Then
                            dr.Close()
                        End If
                    End If

                    cmd.CommandText = "Select * from કર્મો Where ID=" & IDS.Item(index) & ";"
                    dr = cmd.ExecuteReader()
                    'MsgBox(IDS.Item(index))
                    With dr

                        If (.Read()) Then

                            Dim string1(.FieldCount) As String
                            For i As Integer = 0 To .FieldCount - 1
                                If Not .IsDBNull(i) Then
                                    string1(i) = .GetValue(i)
                                Else
                                    string1(i) = ""
                                End If
                            Next

                            Lbl_Id.Text = string1(0)

                            'If Not .IsDBNull(1) Then
                            yajaman.CommandText = "Select Yajaman_Name,Surname,`Fathers Name` from યજમાન where ID=" & string1(1) & ";"

                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If

                            datareader = yajaman.ExecuteReader
                            datareader.Read()
                            Cmb_Yajaman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                            datareader.Close()
                            'End If
                            'If Not .IsDBNull(2) Then
                            puja.CommandText = "Select Puja_Name from `વિધી ( વિધાન ) પુજા` where ID=" & string1(2) & ";"
                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If
                            Cmb_Puja.Text = puja.ExecuteScalar
                            'End If
                            'If Not .IsDBNull(3) Then
                            yajaman.CommandText = "Select Brahman_Name,Surname,`Fathers Name` from બ્રાહ્મણ where ID=" & string1(3) & ";"
                            If con.State = ConnectionState.Closed Then
                                con.Open()

                            End If
                            datareader = yajaman.ExecuteReader
                            datareader.Read()
                            Cmb_Brahman.Text = datareader.GetValue(0) + " " + datareader.GetValue(1) + " " + datareader.GetValue(2)
                            datareader.Close()
                            'End If

                            'If Not .IsDBNull(4) Then
                            Date_Karma.Value = string1(4)
                            'End If

                            'If Not .IsDBNull(5) Then
                            Dim d As Date = string1(5)
                            Dim min As Date = Time_Karma.MinDate
                            min = min.AddHours(d.Hour)
                            min = min.AddMinutes(d.Minute)
                            Time_Karma.Value = min


                            'End If

                            If string1(6) = "Yes" Or string1(6) = "True" Then
                                Radio_Done.Checked = True
                            Else
                                Radio_Not_Done.Checked = True
                            End If


                            Txt_Address.Text = string1(7)
                            Txt_Details.Text = string1(8)


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

        'MsgBox("Index: " & index)

    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        cmd.CommandText = "Delete From કર્મો Where ID=" & IDS.Item(index) & ";"

        Try

            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            MsgBox(" " & cmd.ExecuteNonQuery() & " Records are affected.")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
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
        cmd.CommandText = "Select * from કર્મો;"
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

        Lbl_Id.Text = IDS.Item(index)

    End Sub
End Class