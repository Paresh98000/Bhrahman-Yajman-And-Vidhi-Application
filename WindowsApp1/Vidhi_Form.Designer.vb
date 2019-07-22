<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vidhi_Form
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
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Details = New System.Windows.Forms.Label()
        Me.Txt_Name = New System.Windows.Forms.TextBox()
        Me.Txt_Details = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(133, 380)
        Me.Btn_Save.Margin = New System.Windows.Forms.Padding(7)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(163, 51)
        Me.Btn_Save.TabIndex = 5
        Me.Btn_Save.Text = "Save / સાચવો"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "પુજા ઉમેરો"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "નામઃ"
        '
        'Lbl_Details
        '
        Me.Lbl_Details.AutoSize = True
        Me.Lbl_Details.Location = New System.Drawing.Point(41, 216)
        Me.Lbl_Details.Name = "Lbl_Details"
        Me.Lbl_Details.Size = New System.Drawing.Size(115, 29)
        Me.Lbl_Details.TabIndex = 3
        Me.Lbl_Details.Text = "અન્ય માહિતીઃ"
        '
        'Txt_Name
        '
        Me.Txt_Name.Location = New System.Drawing.Point(165, 158)
        Me.Txt_Name.Name = "Txt_Name"
        Me.Txt_Name.Size = New System.Drawing.Size(352, 35)
        Me.Txt_Name.TabIndex = 2
        '
        'Txt_Details
        '
        Me.Txt_Details.Location = New System.Drawing.Point(165, 213)
        Me.Txt_Details.Multiline = True
        Me.Txt_Details.Name = "Txt_Details"
        Me.Txt_Details.Size = New System.Drawing.Size(352, 131)
        Me.Txt_Details.TabIndex = 4
        '
        'Vidhi_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 467)
        Me.Controls.Add(Me.Txt_Details)
        Me.Controls.Add(Me.Txt_Name)
        Me.Controls.Add(Me.Lbl_Details)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Save)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Vidhi_Form"
        Me.Text = "Vidhi_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Details As Label
    Friend WithEvents Txt_Name As TextBox
    Friend WithEvents Txt_Details As TextBox
End Class
