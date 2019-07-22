<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Display_B
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGV_Display_B = New System.Windows.Forms.DataGridView()
        Me.Lbl_Title = New System.Windows.Forms.Label()
        CType(Me.DGV_Display_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_Display_B
        '
        Me.DGV_Display_B.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Display_B.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Display_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Display_B.Location = New System.Drawing.Point(16, 103)
        Me.DGV_Display_B.Margin = New System.Windows.Forms.Padding(7)
        Me.DGV_Display_B.Name = "DGV_Display_B"
        Me.DGV_Display_B.ReadOnly = True
        Me.DGV_Display_B.RowHeadersWidth = 50
        Me.DGV_Display_B.Size = New System.Drawing.Size(1258, 489)
        Me.DGV_Display_B.TabIndex = 0
        '
        'Lbl_Title
        '
        Me.Lbl_Title.AutoSize = True
        Me.Lbl_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Title.ForeColor = System.Drawing.Color.Navy
        Me.Lbl_Title.Location = New System.Drawing.Point(219, 27)
        Me.Lbl_Title.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Lbl_Title.Name = "Lbl_Title"
        Me.Lbl_Title.Size = New System.Drawing.Size(588, 46)
        Me.Lbl_Title.TabIndex = 1
        Me.Lbl_Title.Text = "બ્રાહ્મણોની તમામ માહિતી નીચે મુજબ છે."
        '
        'Display_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 608)
        Me.Controls.Add(Me.Lbl_Title)
        Me.Controls.Add(Me.DGV_Display_B)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "Display_B"
        Me.Text = "Display_Brahmana"
        CType(Me.DGV_Display_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Display_B As DataGridView
    Friend WithEvents Lbl_Title As Label
End Class
