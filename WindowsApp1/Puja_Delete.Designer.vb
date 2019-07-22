<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puja_Delete
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
        Me.Txt_Details = New System.Windows.Forms.TextBox()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Lbl_Details = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Del = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Lbl_Nbr = New System.Windows.Forms.Label()
        Me.Btn_Nxt = New System.Windows.Forms.Button()
        Me.Btn_Lst = New System.Windows.Forms.Button()
        Me.Btn_Fst = New System.Windows.Forms.Button()
        Me.Btn_Pre = New System.Windows.Forms.Button()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.Lbl_Id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txt_Details
        '
        Me.Txt_Details.Location = New System.Drawing.Point(134, 212)
        Me.Txt_Details.Multiline = True
        Me.Txt_Details.Name = "Txt_Details"
        Me.Txt_Details.Size = New System.Drawing.Size(352, 131)
        Me.Txt_Details.TabIndex = 6
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(134, 157)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(352, 35)
        Me.Txt_Name.TabIndex = 4
        '
        'Lbl_Details
        '
        Me.Lbl_Details.AutoSize = True
        Me.Lbl_Details.Location = New System.Drawing.Point(10, 215)
        Me.Lbl_Details.Name = "Lbl_Details"
        Me.Lbl_Details.Size = New System.Drawing.Size(115, 29)
        Me.Lbl_Details.TabIndex = 5
        Me.Lbl_Details.Text = "અન્ય માહિતીઃ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "પુજાઓ માં  સુધાર"
        '
        'Btn_Del
        '
        Me.Btn_Del.Location = New System.Drawing.Point(271, 456)
        Me.Btn_Del.Name = "Btn_Del"
        Me.Btn_Del.Size = New System.Drawing.Size(215, 51)
        Me.Btn_Del.TabIndex = 13
        Me.Btn_Del.Text = "કાઢો / Delete "
        Me.Btn_Del.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(40, 456)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(215, 51)
        Me.Btn_Save.TabIndex = 12
        Me.Btn_Save.Text = "સાચવો / Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Lbl_Nbr
        '
        Me.Lbl_Nbr.AutoSize = True
        Me.Lbl_Nbr.Location = New System.Drawing.Point(202, 367)
        Me.Lbl_Nbr.Name = "Lbl_Nbr"
        Me.Lbl_Nbr.Size = New System.Drawing.Size(70, 29)
        Me.Lbl_Nbr.TabIndex = 9
        Me.Lbl_Nbr.Text = "From"
        '
        'Btn_Nxt
        '
        Me.Btn_Nxt.Location = New System.Drawing.Point(396, 360)
        Me.Btn_Nxt.Name = "Btn_Nxt"
        Me.Btn_Nxt.Size = New System.Drawing.Size(42, 43)
        Me.Btn_Nxt.TabIndex = 10
        Me.Btn_Nxt.Text = ">"
        Me.Btn_Nxt.UseVisualStyleBackColor = True
        '
        'Btn_Lst
        '
        Me.Btn_Lst.Location = New System.Drawing.Point(444, 360)
        Me.Btn_Lst.Name = "Btn_Lst"
        Me.Btn_Lst.Size = New System.Drawing.Size(58, 43)
        Me.Btn_Lst.TabIndex = 11
        Me.Btn_Lst.Text = ">>"
        Me.Btn_Lst.UseVisualStyleBackColor = True
        '
        'Btn_Fst
        '
        Me.Btn_Fst.Location = New System.Drawing.Point(29, 360)
        Me.Btn_Fst.Name = "Btn_Fst"
        Me.Btn_Fst.Size = New System.Drawing.Size(58, 43)
        Me.Btn_Fst.TabIndex = 7
        Me.Btn_Fst.Text = "<<"
        Me.Btn_Fst.UseVisualStyleBackColor = True
        '
        'Btn_Pre
        '
        Me.Btn_Pre.Location = New System.Drawing.Point(93, 360)
        Me.Btn_Pre.Name = "Btn_Pre"
        Me.Btn_Pre.Size = New System.Drawing.Size(42, 43)
        Me.Btn_Pre.TabIndex = 8
        Me.Btn_Pre.Text = "<"
        Me.Btn_Pre.UseVisualStyleBackColor = True
        '
        'Lbl_Name
        '
        Me.Lbl_Name.AutoSize = True
        Me.Lbl_Name.Location = New System.Drawing.Point(75, 163)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.Size = New System.Drawing.Size(50, 29)
        Me.Lbl_Name.TabIndex = 3
        Me.Lbl_Name.Text = "નામઃ"
        '
        'Lbl_Id
        '
        Me.Lbl_Id.AutoSize = True
        Me.Lbl_Id.Location = New System.Drawing.Point(152, 117)
        Me.Lbl_Id.Name = "Lbl_Id"
        Me.Lbl_Id.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Id.TabIndex = 2
        Me.Lbl_Id.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID: "
        '
        'Puja_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 523)
        Me.Controls.Add(Me.Lbl_Id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Lbl_Name)
        Me.Controls.Add(Me.Btn_Del)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.Lbl_Nbr)
        Me.Controls.Add(Me.Btn_Nxt)
        Me.Controls.Add(Me.Btn_Lst)
        Me.Controls.Add(Me.Btn_Fst)
        Me.Controls.Add(Me.Btn_Pre)
        Me.Controls.Add(Me.Txt_Details)
        Me.Controls.Add(Me.Txt_Name)
        Me.Controls.Add(Me.Lbl_Details)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Puja_Delete"
        Me.Text = "Puja_Delete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Details As TextBox
    Friend WithEvents Txt_Name As TextBox
    Friend WithEvents Lbl_Details As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Del As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Lbl_Nbr As Label
    Friend WithEvents Btn_Nxt As Button
    Friend WithEvents Btn_Lst As Button
    Friend WithEvents Btn_Fst As Button
    Friend WithEvents Btn_Pre As Button
    Friend WithEvents Lbl_Name As Label
    Friend WithEvents Lbl_Id As Label
    Friend WithEvents Label3 As Label
End Class
