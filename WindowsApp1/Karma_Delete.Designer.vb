<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karma_Delete
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Radio_Not_Done = New System.Windows.Forms.RadioButton()
        Me.Radio_Done = New System.Windows.Forms.RadioButton()
        Me.Time_Karma = New System.Windows.Forms.DateTimePicker()
        Me.Date_Karma = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Done = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cmb_Brahman = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Brahman = New System.Windows.Forms.Label()
        Me.Cmb_Puja = New System.Windows.Forms.ComboBox()
        Me.Lbl_Puja = New System.Windows.Forms.Label()
        Me.Cmb_Yajaman = New System.Windows.Forms.ComboBox()
        Me.Lbl_Yajaman = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Lbl_Id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Nbr = New System.Windows.Forms.Label()
        Me.Btn_Nxt = New System.Windows.Forms.Button()
        Me.Btn_Lst = New System.Windows.Forms.Button()
        Me.Btn_Fst = New System.Windows.Forms.Button()
        Me.Btn_Pre = New System.Windows.Forms.Button()
        Me.Txt_Details = New System.Windows.Forms.TextBox()
        Me.Txt_Address = New System.Windows.Forms.TextBox()
        Me.Lbl_Details = New System.Windows.Forms.Label()
        Me.Lbl_Address = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Radio_Not_Done
        '
        Me.Radio_Not_Done.AutoSize = True
        Me.Radio_Not_Done.Location = New System.Drawing.Point(158, 495)
        Me.Radio_Not_Done.Name = "Radio_Not_Done"
        Me.Radio_Not_Done.Size = New System.Drawing.Size(70, 33)
        Me.Radio_Not_Done.TabIndex = 19
        Me.Radio_Not_Done.TabStop = True
        Me.Radio_Not_Done.Text = "બાકી"
        Me.Radio_Not_Done.UseVisualStyleBackColor = True
        '
        'Radio_Done
        '
        Me.Radio_Done.AutoSize = True
        Me.Radio_Done.Checked = True
        Me.Radio_Done.Location = New System.Drawing.Point(92, 495)
        Me.Radio_Done.Name = "Radio_Done"
        Me.Radio_Done.Size = New System.Drawing.Size(60, 33)
        Me.Radio_Done.TabIndex = 18
        Me.Radio_Done.TabStop = True
        Me.Radio_Done.Text = "પુર્ણ"
        Me.Radio_Done.UseVisualStyleBackColor = True
        '
        'Time_Karma
        '
        Me.Time_Karma.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Time_Karma.Location = New System.Drawing.Point(97, 309)
        Me.Time_Karma.Name = "Time_Karma"
        Me.Time_Karma.Size = New System.Drawing.Size(282, 35)
        Me.Time_Karma.TabIndex = 12
        '
        'Date_Karma
        '
        Me.Date_Karma.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Karma.Location = New System.Drawing.Point(97, 268)
        Me.Date_Karma.Name = "Date_Karma"
        Me.Date_Karma.Size = New System.Drawing.Size(282, 35)
        Me.Date_Karma.TabIndex = 10
        '
        'Lbl_Done
        '
        Me.Lbl_Done.AutoSize = True
        Me.Lbl_Done.Location = New System.Drawing.Point(10, 499)
        Me.Lbl_Done.Name = "Lbl_Done"
        Me.Lbl_Done.Size = New System.Drawing.Size(74, 29)
        Me.Lbl_Done.TabIndex = 17
        Me.Lbl_Done.Text = "સમપુણઁઃ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "સમયઃ"
        '
        'Cmb_Brahman
        '
        Me.Cmb_Brahman.FormattingEnabled = True
        Me.Cmb_Brahman.Location = New System.Drawing.Point(97, 224)
        Me.Cmb_Brahman.Name = "Cmb_Brahman"
        Me.Cmb_Brahman.Size = New System.Drawing.Size(282, 37)
        Me.Cmb_Brahman.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 29)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "તારીખઃ"
        '
        'Lbl_Brahman
        '
        Me.Lbl_Brahman.AutoSize = True
        Me.Lbl_Brahman.Location = New System.Drawing.Point(15, 232)
        Me.Lbl_Brahman.Name = "Lbl_Brahman"
        Me.Lbl_Brahman.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Brahman.TabIndex = 7
        Me.Lbl_Brahman.Text = "બ્રાહ્મણઃ"
        '
        'Cmb_Puja
        '
        Me.Cmb_Puja.FormattingEnabled = True
        Me.Cmb_Puja.Location = New System.Drawing.Point(97, 181)
        Me.Cmb_Puja.Name = "Cmb_Puja"
        Me.Cmb_Puja.Size = New System.Drawing.Size(282, 37)
        Me.Cmb_Puja.TabIndex = 6
        '
        'Lbl_Puja
        '
        Me.Lbl_Puja.AutoSize = True
        Me.Lbl_Puja.Location = New System.Drawing.Point(15, 184)
        Me.Lbl_Puja.Name = "Lbl_Puja"
        Me.Lbl_Puja.Size = New System.Drawing.Size(49, 29)
        Me.Lbl_Puja.TabIndex = 5
        Me.Lbl_Puja.Text = "પુજાઃ"
        '
        'Cmb_Yajaman
        '
        Me.Cmb_Yajaman.FormattingEnabled = True
        Me.Cmb_Yajaman.Location = New System.Drawing.Point(97, 138)
        Me.Cmb_Yajaman.Name = "Cmb_Yajaman"
        Me.Cmb_Yajaman.Size = New System.Drawing.Size(282, 37)
        Me.Cmb_Yajaman.TabIndex = 4
        '
        'Lbl_Yajaman
        '
        Me.Lbl_Yajaman.AutoSize = True
        Me.Lbl_Yajaman.Location = New System.Drawing.Point(15, 141)
        Me.Lbl_Yajaman.Name = "Lbl_Yajaman"
        Me.Lbl_Yajaman.Size = New System.Drawing.Size(76, 29)
        Me.Lbl_Yajaman.TabIndex = 3
        Me.Lbl_Yajaman.Text = "યજમાનઃ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "કર્મની સુચીમાં સુધાર"
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(394, 166)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(184, 47)
        Me.Btn_Save.TabIndex = 25
        Me.Btn_Save.Text = "સાચવો / Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(394, 214)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(184, 47)
        Me.Btn_Delete.TabIndex = 26
        Me.Btn_Delete.Text = "કોઢો / Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Lbl_Id
        '
        Me.Lbl_Id.AutoSize = True
        Me.Lbl_Id.Location = New System.Drawing.Point(99, 92)
        Me.Lbl_Id.Name = "Lbl_Id"
        Me.Lbl_Id.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Id.TabIndex = 2
        Me.Lbl_Id.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID: "
        '
        'Lbl_Nbr
        '
        Me.Lbl_Nbr.AutoSize = True
        Me.Lbl_Nbr.Location = New System.Drawing.Point(206, 576)
        Me.Lbl_Nbr.Name = "Lbl_Nbr"
        Me.Lbl_Nbr.Size = New System.Drawing.Size(70, 29)
        Me.Lbl_Nbr.TabIndex = 22
        Me.Lbl_Nbr.Text = "From"
        '
        'Btn_Nxt
        '
        Me.Btn_Nxt.Location = New System.Drawing.Point(400, 569)
        Me.Btn_Nxt.Name = "Btn_Nxt"
        Me.Btn_Nxt.Size = New System.Drawing.Size(42, 43)
        Me.Btn_Nxt.TabIndex = 23
        Me.Btn_Nxt.Text = ">"
        Me.Btn_Nxt.UseVisualStyleBackColor = True
        '
        'Btn_Lst
        '
        Me.Btn_Lst.Location = New System.Drawing.Point(448, 569)
        Me.Btn_Lst.Name = "Btn_Lst"
        Me.Btn_Lst.Size = New System.Drawing.Size(58, 43)
        Me.Btn_Lst.TabIndex = 24
        Me.Btn_Lst.Text = ">>"
        Me.Btn_Lst.UseVisualStyleBackColor = True
        '
        'Btn_Fst
        '
        Me.Btn_Fst.Location = New System.Drawing.Point(33, 569)
        Me.Btn_Fst.Name = "Btn_Fst"
        Me.Btn_Fst.Size = New System.Drawing.Size(58, 43)
        Me.Btn_Fst.TabIndex = 20
        Me.Btn_Fst.Text = "<<"
        Me.Btn_Fst.UseVisualStyleBackColor = True
        '
        'Btn_Pre
        '
        Me.Btn_Pre.Location = New System.Drawing.Point(97, 569)
        Me.Btn_Pre.Name = "Btn_Pre"
        Me.Btn_Pre.Size = New System.Drawing.Size(42, 43)
        Me.Btn_Pre.TabIndex = 21
        Me.Btn_Pre.Text = "<"
        Me.Btn_Pre.UseVisualStyleBackColor = True
        '
        'Txt_Details
        '
        Me.Txt_Details.Location = New System.Drawing.Point(97, 393)
        Me.Txt_Details.Multiline = True
        Me.Txt_Details.Name = "Txt_Details"
        Me.Txt_Details.Size = New System.Drawing.Size(282, 82)
        Me.Txt_Details.TabIndex = 16
        '
        'Txt_Address
        '
        Me.Txt_Address.Location = New System.Drawing.Point(97, 352)
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.Size = New System.Drawing.Size(282, 35)
        Me.Txt_Address.TabIndex = 14
        '
        'Lbl_Details
        '
        Me.Lbl_Details.AutoSize = True
        Me.Lbl_Details.Location = New System.Drawing.Point(12, 396)
        Me.Lbl_Details.Name = "Lbl_Details"
        Me.Lbl_Details.Size = New System.Drawing.Size(73, 29)
        Me.Lbl_Details.TabIndex = 15
        Me.Lbl_Details.Text = "માહિતીઃ"
        '
        'Lbl_Address
        '
        Me.Lbl_Address.AutoSize = True
        Me.Lbl_Address.Location = New System.Drawing.Point(17, 355)
        Me.Lbl_Address.Name = "Lbl_Address"
        Me.Lbl_Address.Size = New System.Drawing.Size(55, 29)
        Me.Lbl_Address.TabIndex = 13
        Me.Lbl_Address.Text = "સ્થળઃ"
        '
        'Karma_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 661)
        Me.Controls.Add(Me.Txt_Details)
        Me.Controls.Add(Me.Txt_Address)
        Me.Controls.Add(Me.Lbl_Details)
        Me.Controls.Add(Me.Lbl_Address)
        Me.Controls.Add(Me.Lbl_Id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Nbr)
        Me.Controls.Add(Me.Btn_Nxt)
        Me.Controls.Add(Me.Btn_Lst)
        Me.Controls.Add(Me.Btn_Fst)
        Me.Controls.Add(Me.Btn_Pre)
        Me.Controls.Add(Me.Radio_Not_Done)
        Me.Controls.Add(Me.Radio_Done)
        Me.Controls.Add(Me.Time_Karma)
        Me.Controls.Add(Me.Date_Karma)
        Me.Controls.Add(Me.Lbl_Done)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cmb_Brahman)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lbl_Brahman)
        Me.Controls.Add(Me.Cmb_Puja)
        Me.Controls.Add(Me.Lbl_Puja)
        Me.Controls.Add(Me.Cmb_Yajaman)
        Me.Controls.Add(Me.Lbl_Yajaman)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.Btn_Save)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Karma_Delete"
        Me.Text = "Karma_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Radio_Not_Done As RadioButton
    Friend WithEvents Radio_Done As RadioButton
    Friend WithEvents Time_Karma As DateTimePicker
    Friend WithEvents Date_Karma As DateTimePicker
    Friend WithEvents Lbl_Done As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Cmb_Brahman As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Brahman As Label
    Friend WithEvents Cmb_Puja As ComboBox
    Friend WithEvents Lbl_Puja As Label
    Friend WithEvents Cmb_Yajaman As ComboBox
    Friend WithEvents Lbl_Yajaman As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Lbl_Id As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_Nbr As Label
    Friend WithEvents Btn_Nxt As Button
    Friend WithEvents Btn_Lst As Button
    Friend WithEvents Btn_Fst As Button
    Friend WithEvents Btn_Pre As Button
    Friend WithEvents Txt_Details As TextBox
    Friend WithEvents Txt_Address As TextBox
    Friend WithEvents Lbl_Details As Label
    Friend WithEvents Lbl_Address As Label
End Class
