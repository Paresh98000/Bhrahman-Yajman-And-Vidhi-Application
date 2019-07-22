Imports System.Data.OleDb

Public Class Form1
    Public source As String = "C:\Users\Hp\OneDrive\Database\GayatryAstroComp.mdb"
    Dim provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;"
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Hp\OneDrive\Database\GayatryAstroComp.mdb")
    Dim cmd As New OleDbCommand("Select Brahman_Name,Puja_Date,Puja_Name,Yajaman_Name,y.Address,P_Time from કર્મો, બ્રાહ્મણ b,`વિધી ( વિધાન ) પુજા` p,યજમાન y Where ( Done=No and ( Brahman = b.ID ) and ( Puja = p.ID) and ( yajaman = y.ID)) Order by Puja_date", con)
    Dim da As New OleDbDataAdapter(cmd)
    Dim ds_f As New DataSet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        source = InputBox("Enter database Path with file and extentioin: ", "Select Database", source)

        con.ConnectionString = provider + "Data Source=" + source

        Lbl_Source.Text = source

        FileSystem.FileCopy(source, "C:\બ્રાહ્મણ અને યજમાન નો Database\Database Up'Date " & Now.Day & "." & Now.Month & "." & Now.Year & " Time " & Now.Hour & "-" & Now.Minute & ".mdb")

        Try

            con.Open()

            da.Fill(ds_f)

            DGV_Future.DataSource = ds_f.Tables.Item(0)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

        Lbl_Wi.Text = "તમારુ સ્વાગત છે "

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Time.Text = "સમય : " & Now.ToLongTimeString
        Lbl_Date.Text = "તારીખ : " & Now.ToLongDateString
    End Sub


    '
    ' Brahman Methods
    '


    Private Sub Btn_B_Add_Click(sender As Object, e As EventArgs) Handles Btn_B_Add.Click

        Me.Enabled = False
        Dim b = New Brahman_Form
        b.con.ConnectionString = provider + "Data Source=" + source
        b.Show()

    End Sub

    Private Sub Btn_B_Display_Click(sender As Object, e As EventArgs) Handles Btn_B_Display.Click
        Dim d As New Display_B
        Dim ds As New DataSet
        d.Lbl_Title.Text = "બ્રાહ્મણોની તમામ માહિતી નીચે મુજબ છે."
        Try

            con.Open()
            cmd.CommandText = "Select * from બ્રાહ્મણ"

            ds.Reset()
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

        d.DGV_Display_B.DataSource = ds.Tables.Item(0)
        Me.Enabled = False
        d.Show()
    End Sub

    Private Sub Btn_B_Delete_Click(sender As Object, e As EventArgs) Handles Btn_B_Delete.Click
        Dim del1 As New Brahmana_Delete
        del1.con.ConnectionString = provider + "Data Source=" + source
        del1.Show()
        Me.Enabled = False
    End Sub

    Private Sub Btn_Y_Add_Click(sender As Object, e As EventArgs) Handles Btn_Y_Add.Click
        Dim y As New Yajaman_Form
        y.Show()
        y.con.ConnectionString = provider + "Data Source=" + source
        Me.Enabled = False
    End Sub

    Private Sub Btn_Chng_Database_Click(sender As Object, e As EventArgs) Handles Btn_Chng_Database.Click
        Dim opd = New OpenFileDialog
        opd.Title = "Open Database File"
        opd.Multiselect = False
        Dim dres = New DialogResult
        dres = opd.ShowDialog()
        If dres.ToString() = "OK" Then
            source = "Data Source=" + opd.FileName
            con.ConnectionString = provider + source

            Try
                con.Open()
                MsgBox("Successful", MsgBoxStyle.Information, "Database Change")
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()
            End Try

        End If

        Lbl_Source.Text = source

    End Sub

    Private Sub Btn_Y_Display_Click(sender As Object, e As EventArgs) Handles Btn_Y_Display.Click
        Dim d As New Display_B
        Dim ds As New DataSet
        d.Lbl_Title.Text = "યજમાનો ની તમામ માહિતી નીચે મુજબ છે."
        Try

            con.Open()
            cmd.CommandText = "Select * from યજમાન"

            ds.Reset()
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

        d.DGV_Display_B.DataSource = ds.Tables.Item(0)
        Me.Enabled = False
        d.Show()
    End Sub

    Private Sub Btn_Y_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Y_Delete.Click
        Dim del1 As New Yajaman_Delete
        del1.con.ConnectionString = provider + "Data Source=" + source
        del1.Show()
        Me.Enabled = False
    End Sub

    Private Sub Btn_K_Add_Click(sender As Object, e As EventArgs) Handles Btn_K_Add.Click
        Dim del1 As New Karma_Form
        del1.con.ConnectionString = provider + "Data Source=" + source
        del1.Show()
        Me.Enabled = False
    End Sub

    Private Sub Btn_K_Display_Click(sender As Object, e As EventArgs) Handles Btn_K_Display.Click
        Dim d As New Display_B
        Dim ds As New DataSet
        d.Lbl_Title.Text = "કર્મોની ની તમામ માહિતી નીચે મુજબ છે."
        Try

            con.Open()
            cmd.CommandText = "Select k.ID,Brahman_Name,Puja_Name,Yajaman_Name,k.Address,k.Details from કર્મો k,બ્રાહ્મણ b,`વિધી ( વિધાન ) પુજા` p,યજમાન y Where (k.Brahman=b.ID and k.Yajaman=y.ID) and (k.Puja=p.ID);"

            ds.Reset()
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

        d.DGV_Display_B.DataSource = ds.Tables.Item(0)
        Me.Enabled = False
        d.Show()
    End Sub

    Private Sub Btn_Puja_Display_Click(sender As Object, e As EventArgs) Handles Btn_Puja_Display.Click, Btn_Puja_Display.Click

        Dim ds As New DataSet
        Display_B.Lbl_Title.Text = "પુજાઓ ની તમામ માહિતી નીચે મુજબ છે."
        Try

            con.Open()
            cmd.CommandText = "Select * from `વિધી ( વિધાન ) પુજા`"

            ds.Reset()
            da.SelectCommand = cmd
            da.Fill(ds)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try

        Display_B.DGV_Display_B.DataSource = ds.Tables.Item(0)
        Me.Enabled = False
        Display_B.Show()
    End Sub

    Private Sub Btn_Add_Puja_Click(sender As Object, e As EventArgs) Handles Btn_Add_Puja.Click

        Vidhi_Form.con.ConnectionString = provider + "Data Source=" + source
        Me.Enabled = False
        Vidhi_Form.Show()

    End Sub

    

    Private Sub Form1_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        cmd.CommandText = "Select Brahman_Name,Puja_Date,Puja_Name,Yajaman_Name,y.Address,P_Time from કર્મો, બ્રાહ્મણ b,`વિધી ( વિધાન ) પુજા` p,યજમાન y Where ( Done=No and ( Brahman = b.ID ) and ( Puja = p.ID) and ( yajaman = y.ID)) Order by Puja_date"
        da.SelectCommand = cmd
        Try

            con.Open()
            ds_f.Reset()
            da.Fill(ds_f)

            DGV_Future.DataSource = ds_f.Tables.Item(0)

        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btn_K_Delete_Click(sender As Object, e As EventArgs) Handles Btn_K_Delete.Click
        Me.Enabled = False
        Karma_Delete.Show()
        Karma_Delete.con.ConnectionString = provider + "Data Source=" + source
    End Sub

    Private Sub Btn_Delete_Puja_Click(sender As Object, e As EventArgs) Handles Btn_Delete_Puja.Click
        Me.Enabled = False
        Puja_Delete.Show()
        Puja_Delete.con.ConnectionString = provider + "Data Source=" + source
    End Sub

    Private Sub Lbl_Wel_Click(sender As Object, e As EventArgs) Handles Lbl_Wel.Click

    End Sub
End Class
