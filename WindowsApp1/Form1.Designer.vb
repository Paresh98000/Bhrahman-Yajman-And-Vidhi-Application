<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Lbl_Time = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Wi = New System.Windows.Forms.Label()
        Me.Lbl_Wel = New System.Windows.Forms.Label()
        Me.Grp_Brahman = New System.Windows.Forms.GroupBox()
        Me.Btn_B_Delete = New System.Windows.Forms.Button()
        Me.Btn_B_Display = New System.Windows.Forms.Button()
        Me.Btn_B_Add = New System.Windows.Forms.Button()
        Me.Grp_Yajaman = New System.Windows.Forms.GroupBox()
        Me.Btn_Y_Delete = New System.Windows.Forms.Button()
        Me.Btn_Y_Display = New System.Windows.Forms.Button()
        Me.Btn_Y_Add = New System.Windows.Forms.Button()
        Me.Grp_Karm = New System.Windows.Forms.GroupBox()
        Me.Btn_K_Delete = New System.Windows.Forms.Button()
        Me.Btn_K_Add = New System.Windows.Forms.Button()
        Me.Btn_K_Display = New System.Windows.Forms.Button()
        Me.Lbl_Future = New System.Windows.Forms.Label()
        Me.DoneDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PujaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrahmanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PujaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YajamanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Future = New System.Windows.Forms.DataGridView()
        Me.Btn_Chng_Database = New System.Windows.Forms.Button()
        Me.Btn_Puja_Display = New System.Windows.Forms.Button()
        Me.Btn_Add_Puja = New System.Windows.Forms.Button()
        Me.Lbl_Date = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Delete_Puja = New System.Windows.Forms.Button()
        Me.Lbl_Source = New System.Windows.Forms.Label()
        Me.Grp_Brahman.SuspendLayout()
        Me.Grp_Yajaman.SuspendLayout()
        Me.Grp_Karm.SuspendLayout()
        CType(Me.DGV_Future, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Time
        '
        Me.Lbl_Time.AutoSize = True
        Me.Lbl_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Time.Location = New System.Drawing.Point(718, 118)
        Me.Lbl_Time.Name = "Lbl_Time"
        Me.Lbl_Time.Size = New System.Drawing.Size(89, 39)
        Me.Lbl_Time.TabIndex = 3
        Me.Lbl_Time.Text = "સમય :"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Lbl_Wi
        '
        Me.Lbl_Wi.AutoSize = True
        Me.Lbl_Wi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Wi.Location = New System.Drawing.Point(108, 56)
        Me.Lbl_Wi.Name = "Lbl_Wi"
        Me.Lbl_Wi.Size = New System.Drawing.Size(120, 20)
        Me.Lbl_Wi.TabIndex = 0
        Me.Lbl_Wi.Text = "તમારુ સ્વાગત છે \n માં"
        '
        'Lbl_Wel
        '
        Me.Lbl_Wel.AutoSize = True
        Me.Lbl_Wel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Wel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Lbl_Wel.Location = New System.Drawing.Point(243, 20)
        Me.Lbl_Wel.Name = "Lbl_Wel"
        Me.Lbl_Wel.Size = New System.Drawing.Size(603, 76)
        Me.Lbl_Wel.TabIndex = 1
        Me.Lbl_Wel.Text = "ગાયત્રી સંસ્થા, ભાવનગર"
        '
        'Grp_Brahman
        '
        Me.Grp_Brahman.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Grp_Brahman.Controls.Add(Me.Btn_B_Delete)
        Me.Grp_Brahman.Controls.Add(Me.Btn_B_Display)
        Me.Grp_Brahman.Controls.Add(Me.Btn_B_Add)
        Me.Grp_Brahman.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Brahman.ForeColor = System.Drawing.Color.SlateBlue
        Me.Grp_Brahman.Location = New System.Drawing.Point(19, 452)
        Me.Grp_Brahman.Name = "Grp_Brahman"
        Me.Grp_Brahman.Size = New System.Drawing.Size(200, 211)
        Me.Grp_Brahman.TabIndex = 8
        Me.Grp_Brahman.TabStop = False
        Me.Grp_Brahman.Text = "શ્રી. બ્રાહ્મણ"
        '
        'Btn_B_Delete
        '
        Me.Btn_B_Delete.Location = New System.Drawing.Point(52, 155)
        Me.Btn_B_Delete.Name = "Btn_B_Delete"
        Me.Btn_B_Delete.Size = New System.Drawing.Size(142, 41)
        Me.Btn_B_Delete.TabIndex = 2
        Me.Btn_B_Delete.Text = "Delete કરો"
        Me.Btn_B_Delete.UseVisualStyleBackColor = True
        '
        'Btn_B_Display
        '
        Me.Btn_B_Display.Location = New System.Drawing.Point(52, 108)
        Me.Btn_B_Display.Name = "Btn_B_Display"
        Me.Btn_B_Display.Size = New System.Drawing.Size(142, 41)
        Me.Btn_B_Display.TabIndex = 1
        Me.Btn_B_Display.Text = "નિહાડો"
        Me.Btn_B_Display.UseVisualStyleBackColor = True
        '
        'Btn_B_Add
        '
        Me.Btn_B_Add.Location = New System.Drawing.Point(52, 61)
        Me.Btn_B_Add.Name = "Btn_B_Add"
        Me.Btn_B_Add.Size = New System.Drawing.Size(142, 41)
        Me.Btn_B_Add.TabIndex = 0
        Me.Btn_B_Add.Text = "નવુ ઉમેરો"
        Me.Btn_B_Add.UseVisualStyleBackColor = True
        '
        'Grp_Yajaman
        '
        Me.Grp_Yajaman.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Grp_Yajaman.Controls.Add(Me.Btn_Y_Delete)
        Me.Grp_Yajaman.Controls.Add(Me.Btn_Y_Display)
        Me.Grp_Yajaman.Controls.Add(Me.Btn_Y_Add)
        Me.Grp_Yajaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Yajaman.ForeColor = System.Drawing.Color.Teal
        Me.Grp_Yajaman.Location = New System.Drawing.Point(259, 452)
        Me.Grp_Yajaman.Name = "Grp_Yajaman"
        Me.Grp_Yajaman.Size = New System.Drawing.Size(200, 211)
        Me.Grp_Yajaman.TabIndex = 9
        Me.Grp_Yajaman.TabStop = False
        Me.Grp_Yajaman.Text = "શ્રી. યજમાન"
        '
        'Btn_Y_Delete
        '
        Me.Btn_Y_Delete.Location = New System.Drawing.Point(46, 158)
        Me.Btn_Y_Delete.Name = "Btn_Y_Delete"
        Me.Btn_Y_Delete.Size = New System.Drawing.Size(148, 41)
        Me.Btn_Y_Delete.TabIndex = 2
        Me.Btn_Y_Delete.Text = "Delete કરો"
        Me.Btn_Y_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Y_Display
        '
        Me.Btn_Y_Display.Location = New System.Drawing.Point(46, 111)
        Me.Btn_Y_Display.Name = "Btn_Y_Display"
        Me.Btn_Y_Display.Size = New System.Drawing.Size(148, 41)
        Me.Btn_Y_Display.TabIndex = 1
        Me.Btn_Y_Display.Text = "નિહાડો"
        Me.Btn_Y_Display.UseVisualStyleBackColor = True
        '
        'Btn_Y_Add
        '
        Me.Btn_Y_Add.Location = New System.Drawing.Point(46, 64)
        Me.Btn_Y_Add.Name = "Btn_Y_Add"
        Me.Btn_Y_Add.Size = New System.Drawing.Size(148, 41)
        Me.Btn_Y_Add.TabIndex = 0
        Me.Btn_Y_Add.Text = "નવુ ઉમેરો"
        Me.Btn_Y_Add.UseVisualStyleBackColor = True
        '
        'Grp_Karm
        '
        Me.Grp_Karm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Grp_Karm.Controls.Add(Me.Btn_K_Delete)
        Me.Grp_Karm.Controls.Add(Me.Btn_K_Add)
        Me.Grp_Karm.Controls.Add(Me.Btn_K_Display)
        Me.Grp_Karm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Karm.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Grp_Karm.Location = New System.Drawing.Point(487, 452)
        Me.Grp_Karm.Name = "Grp_Karm"
        Me.Grp_Karm.Size = New System.Drawing.Size(200, 211)
        Me.Grp_Karm.TabIndex = 10
        Me.Grp_Karm.TabStop = False
        Me.Grp_Karm.Text = "કર્મ કાંડ"
        '
        'Btn_K_Delete
        '
        Me.Btn_K_Delete.Location = New System.Drawing.Point(48, 158)
        Me.Btn_K_Delete.Name = "Btn_K_Delete"
        Me.Btn_K_Delete.Size = New System.Drawing.Size(146, 41)
        Me.Btn_K_Delete.TabIndex = 2
        Me.Btn_K_Delete.Text = "Delete કરો"
        Me.Btn_K_Delete.UseVisualStyleBackColor = True
        '
        'Btn_K_Add
        '
        Me.Btn_K_Add.Location = New System.Drawing.Point(48, 64)
        Me.Btn_K_Add.Name = "Btn_K_Add"
        Me.Btn_K_Add.Size = New System.Drawing.Size(146, 41)
        Me.Btn_K_Add.TabIndex = 0
        Me.Btn_K_Add.Text = "નવુ ઉમેરો"
        Me.Btn_K_Add.UseVisualStyleBackColor = True
        '
        'Btn_K_Display
        '
        Me.Btn_K_Display.Location = New System.Drawing.Point(48, 111)
        Me.Btn_K_Display.Name = "Btn_K_Display"
        Me.Btn_K_Display.Size = New System.Drawing.Size(146, 41)
        Me.Btn_K_Display.TabIndex = 1
        Me.Btn_K_Display.Text = "નિહાડો"
        Me.Btn_K_Display.UseVisualStyleBackColor = True
        '
        'Lbl_Future
        '
        Me.Lbl_Future.AutoSize = True
        Me.Lbl_Future.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Future.Location = New System.Drawing.Point(33, 159)
        Me.Lbl_Future.Name = "Lbl_Future"
        Me.Lbl_Future.Size = New System.Drawing.Size(276, 29)
        Me.Lbl_Future.TabIndex = 4
        Me.Lbl_Future.Text = "ભવીષ્યના આવનારા યજમાન પ્રસંગો"
        '
        'DoneDataGridViewCheckBoxColumn
        '
        Me.DoneDataGridViewCheckBoxColumn.Name = "DoneDataGridViewCheckBoxColumn"
        '
        'PTimeDataGridViewTextBoxColumn
        '
        Me.PTimeDataGridViewTextBoxColumn.Name = "PTimeDataGridViewTextBoxColumn"
        '
        'PujaDateDataGridViewTextBoxColumn
        '
        Me.PujaDateDataGridViewTextBoxColumn.Name = "PujaDateDataGridViewTextBoxColumn"
        '
        'BrahmanDataGridViewTextBoxColumn
        '
        Me.BrahmanDataGridViewTextBoxColumn.Name = "BrahmanDataGridViewTextBoxColumn"
        '
        'PujaDataGridViewTextBoxColumn
        '
        Me.PujaDataGridViewTextBoxColumn.Name = "PujaDataGridViewTextBoxColumn"
        '
        'YajamanDataGridViewTextBoxColumn
        '
        Me.YajamanDataGridViewTextBoxColumn.Name = "YajamanDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DGV_Future
        '
        Me.DGV_Future.AllowUserToAddRows = False
        Me.DGV_Future.AllowUserToDeleteRows = False
        Me.DGV_Future.AllowUserToOrderColumns = True
        Me.DGV_Future.AllowUserToResizeColumns = False
        Me.DGV_Future.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Future.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Future.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Future.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV_Future.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Future.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DGV_Future.Location = New System.Drawing.Point(28, 191)
        Me.DGV_Future.Name = "DGV_Future"
        Me.DGV_Future.ReadOnly = True
        Me.DGV_Future.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Future.RowTemplate.Height = 50
        Me.DGV_Future.Size = New System.Drawing.Size(1038, 187)
        Me.DGV_Future.TabIndex = 5
        '
        'Btn_Chng_Database
        '
        Me.Btn_Chng_Database.BackColor = System.Drawing.Color.Firebrick
        Me.Btn_Chng_Database.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Chng_Database.ForeColor = System.Drawing.Color.White
        Me.Btn_Chng_Database.Location = New System.Drawing.Point(348, 384)
        Me.Btn_Chng_Database.Name = "Btn_Chng_Database"
        Me.Btn_Chng_Database.Size = New System.Drawing.Size(224, 40)
        Me.Btn_Chng_Database.TabIndex = 6
        Me.Btn_Chng_Database.Text = "Change Database"
        Me.Btn_Chng_Database.UseVisualStyleBackColor = False
        '
        'Btn_Puja_Display
        '
        Me.Btn_Puja_Display.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Puja_Display.Location = New System.Drawing.Point(59, 110)
        Me.Btn_Puja_Display.Name = "Btn_Puja_Display"
        Me.Btn_Puja_Display.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Puja_Display.TabIndex = 1
        Me.Btn_Puja_Display.Text = "નિહાડો"
        Me.Btn_Puja_Display.UseVisualStyleBackColor = True
        '
        'Btn_Add_Puja
        '
        Me.Btn_Add_Puja.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Puja.Location = New System.Drawing.Point(59, 64)
        Me.Btn_Add_Puja.Name = "Btn_Add_Puja"
        Me.Btn_Add_Puja.Size = New System.Drawing.Size(135, 40)
        Me.Btn_Add_Puja.TabIndex = 0
        Me.Btn_Add_Puja.Text = "નવુ ઉમેરો"
        Me.Btn_Add_Puja.UseVisualStyleBackColor = True
        '
        'Lbl_Date
        '
        Me.Lbl_Date.AutoSize = True
        Me.Lbl_Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Date.Location = New System.Drawing.Point(33, 103)
        Me.Lbl_Date.Name = "Lbl_Date"
        Me.Lbl_Date.Size = New System.Drawing.Size(68, 29)
        Me.Lbl_Date.TabIndex = 2
        Me.Lbl_Date.Text = "તારીખઃ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.Btn_Delete_Puja)
        Me.GroupBox1.Controls.Add(Me.Btn_Puja_Display)
        Me.GroupBox1.Controls.Add(Me.Btn_Add_Puja)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Tomato
        Me.GroupBox1.Location = New System.Drawing.Point(706, 452)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 211)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "પુજા"
        '
        'Btn_Delete_Puja
        '
        Me.Btn_Delete_Puja.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete_Puja.Location = New System.Drawing.Point(59, 155)
        Me.Btn_Delete_Puja.Name = "Btn_Delete_Puja"
        Me.Btn_Delete_Puja.Size = New System.Drawing.Size(135, 39)
        Me.Btn_Delete_Puja.TabIndex = 2
        Me.Btn_Delete_Puja.Text = "Delete કરો"
        Me.Btn_Delete_Puja.UseVisualStyleBackColor = True
        '
        'Lbl_Source
        '
        Me.Lbl_Source.AutoSize = True
        Me.Lbl_Source.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Lbl_Source.Location = New System.Drawing.Point(578, 390)
        Me.Lbl_Source.Name = "Lbl_Source"
        Me.Lbl_Source.Size = New System.Drawing.Size(136, 29)
        Me.Lbl_Source.TabIndex = 7
        Me.Lbl_Source.Text = "Lbl_Source"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1078, 687)
        Me.Controls.Add(Me.Lbl_Source)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Chng_Database)
        Me.Controls.Add(Me.DGV_Future)
        Me.Controls.Add(Me.Lbl_Future)
        Me.Controls.Add(Me.Grp_Karm)
        Me.Controls.Add(Me.Grp_Yajaman)
        Me.Controls.Add(Me.Grp_Brahman)
        Me.Controls.Add(Me.Lbl_Wel)
        Me.Controls.Add(Me.Lbl_Wi)
        Me.Controls.Add(Me.Lbl_Date)
        Me.Controls.Add(Me.Lbl_Time)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Gayatry Astrocomp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grp_Brahman.ResumeLayout(False)
        Me.Grp_Yajaman.ResumeLayout(False)
        Me.Grp_Karm.ResumeLayout(False)
        CType(Me.DGV_Future, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Time As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Lbl_Wi As Label
    Friend WithEvents Lbl_Wel As Label
    Friend WithEvents Grp_Brahman As GroupBox
    Friend WithEvents Btn_B_Add As Button
    Friend WithEvents Grp_Yajaman As GroupBox
    Friend WithEvents Grp_Karm As GroupBox
    Friend WithEvents Btn_B_Delete As Button
    Friend WithEvents Btn_B_Display As Button
    Friend WithEvents Btn_Y_Delete As Button
    Friend WithEvents Btn_Y_Display As Button
    Friend WithEvents Btn_Y_Add As Button
    Friend WithEvents Btn_K_Delete As Button
    Friend WithEvents Btn_K_Add As Button
    Friend WithEvents Btn_K_Display As Button
    Friend WithEvents Lbl_Future As Label
    Friend WithEvents DoneDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PujaDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrahmanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PujaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YajamanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Future As DataGridView
    Friend WithEvents Btn_Chng_Database As Button
    Friend WithEvents Btn_Puja_Display As Button
    Friend WithEvents Btn_Add_Puja As Button
    Friend WithEvents Lbl_Date As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Delete_Puja As Button
    Friend WithEvents Lbl_Source As Label
End Class
