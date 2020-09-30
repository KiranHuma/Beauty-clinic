<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservationfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reservationfrm))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnupdte = New System.Windows.Forms.Button()
        Me.Btndel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.resid_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rid_txt = New System.Windows.Forms.TextBox()
        Me.mid_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.svemem = New System.Windows.Forms.Button()
        Me.dte_txt = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.get_ratedata = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.get_ratedata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1063, 627)
        Me.TabControl1.TabIndex = 263
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Btnadd)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnupdte)
        Me.TabPage1.Controls.Add(Me.Btndel)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.resid_txt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.rid_txt)
        Me.TabPage1.Controls.Add(Me.mid_txt)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.svemem)
        Me.TabPage1.Controls.Add(Me.dte_txt)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1055, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Rate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.LightCoral
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(74, 532)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 17)
        Me.Label25.TabIndex = 348
        Me.Label25.Text = "Welcome"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.Transparent
        Me.Btnadd.BackgroundImage = CType(resources.GetObject("Btnadd.BackgroundImage"), System.Drawing.Image)
        Me.Btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnadd.ForeColor = System.Drawing.Color.White
        Me.Btnadd.Location = New System.Drawing.Point(792, 466)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(45, 35)
        Me.Btnadd.TabIndex = 346
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightCoral
        Me.Label19.Location = New System.Drawing.Point(766, 505)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 347
        Me.Label19.Text = "Add New"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightCoral
        Me.Label15.Location = New System.Drawing.Point(977, 509)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 345
        Me.Label15.Text = "Delete"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightCoral
        Me.Label10.Location = New System.Drawing.Point(914, 509)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 344
        Me.Label10.Text = "Edit"
        '
        'btnupdte
        '
        Me.btnupdte.BackColor = System.Drawing.Color.White
        Me.btnupdte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdte.ForeColor = System.Drawing.Color.White
        Me.btnupdte.Image = CType(resources.GetObject("btnupdte.Image"), System.Drawing.Image)
        Me.btnupdte.Location = New System.Drawing.Point(908, 468)
        Me.btnupdte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdte.Name = "btnupdte"
        Me.btnupdte.Size = New System.Drawing.Size(42, 34)
        Me.btnupdte.TabIndex = 342
        Me.btnupdte.UseVisualStyleBackColor = False
        '
        'Btndel
        '
        Me.Btndel.BackColor = System.Drawing.Color.White
        Me.Btndel.BackgroundImage = CType(resources.GetObject("Btndel.BackgroundImage"), System.Drawing.Image)
        Me.Btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndel.ForeColor = System.Drawing.Color.White
        Me.Btndel.Location = New System.Drawing.Point(980, 468)
        Me.Btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btndel.Name = "Btndel"
        Me.Btndel.Size = New System.Drawing.Size(52, 34)
        Me.Btndel.TabIndex = 343
        Me.Btndel.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(976, 505)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 339
        Me.Label7.Text = "Save"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(980, 468)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 33)
        Me.Button2.TabIndex = 338
        Me.Button2.UseVisualStyleBackColor = False
        '
        'resid_txt
        '
        Me.resid_txt.Location = New System.Drawing.Point(347, 169)
        Me.resid_txt.Name = "resid_txt"
        Me.resid_txt.Size = New System.Drawing.Size(200, 22)
        Me.resid_txt.TabIndex = 273
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 272
        Me.Label6.Text = "Reservation ID"
        '
        'rid_txt
        '
        Me.rid_txt.Location = New System.Drawing.Point(347, 212)
        Me.rid_txt.Name = "rid_txt"
        Me.rid_txt.Size = New System.Drawing.Size(200, 22)
        Me.rid_txt.TabIndex = 269
        '
        'mid_txt
        '
        Me.mid_txt.Location = New System.Drawing.Point(347, 311)
        Me.mid_txt.Name = "mid_txt"
        Me.mid_txt.Size = New System.Drawing.Size(200, 22)
        Me.mid_txt.TabIndex = 271
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "RateID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 270
        Me.Label5.Text = "MemberID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(839, 505)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Save"
        '
        'svemem
        '
        Me.svemem.BackColor = System.Drawing.SystemColors.Control
        Me.svemem.BackgroundImage = CType(resources.GetObject("svemem.BackgroundImage"), System.Drawing.Image)
        Me.svemem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svemem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svemem.ForeColor = System.Drawing.SystemColors.Control
        Me.svemem.Location = New System.Drawing.Point(845, 468)
        Me.svemem.Margin = New System.Windows.Forms.Padding(4)
        Me.svemem.Name = "svemem"
        Me.svemem.Size = New System.Drawing.Size(36, 33)
        Me.svemem.TabIndex = 268
        Me.svemem.UseVisualStyleBackColor = False
        '
        'dte_txt
        '
        Me.dte_txt.Location = New System.Drawing.Point(347, 361)
        Me.dte_txt.Name = "dte_txt"
        Me.dte_txt.Size = New System.Drawing.Size(200, 22)
        Me.dte_txt.TabIndex = 266
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(292, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 44)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Reservation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.get_ratedata)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(840, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rate Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.LightCoral
        Me.Button6.Location = New System.Drawing.Point(587, 23)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 31)
        Me.Button6.TabIndex = 317
        Me.Button6.Text = "&Select Rows to Remove"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'get_ratedata
        '
        Me.get_ratedata.AllowUserToAddRows = False
        Me.get_ratedata.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratedata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.get_ratedata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.get_ratedata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_ratedata.BackgroundColor = System.Drawing.Color.Indigo
        Me.get_ratedata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_ratedata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratedata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.get_ratedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.get_ratedata.DefaultCellStyle = DataGridViewCellStyle8
        Me.get_ratedata.EnableHeadersVisualStyles = False
        Me.get_ratedata.GridColor = System.Drawing.Color.Indigo
        Me.get_ratedata.Location = New System.Drawing.Point(17, 62)
        Me.get_ratedata.Margin = New System.Windows.Forms.Padding(4)
        Me.get_ratedata.Name = "get_ratedata"
        Me.get_ratedata.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratedata.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.get_ratedata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratedata.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.get_ratedata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_ratedata.Size = New System.Drawing.Size(805, 410)
        Me.get_ratedata.TabIndex = 151
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightCoral
        Me.Label11.Location = New System.Drawing.Point(867, 286)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 17)
        Me.Label11.TabIndex = 355
        Me.Label11.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.LightCoral
        Me.Label8.Location = New System.Drawing.Point(855, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 354
        Me.Label8.Text = "Location"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightCoral
        Me.Label9.Location = New System.Drawing.Point(855, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 17)
        Me.Label9.TabIndex = 353
        Me.Label9.Text = "MemberId"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightCoral
        Me.Label12.Location = New System.Drawing.Point(857, 314)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 352
        Me.Label12.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightCoral
        Me.Label14.Location = New System.Drawing.Point(867, 207)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 17)
        Me.Label14.TabIndex = 351
        Me.Label14.Text = "Age"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightCoral
        Me.Label16.Location = New System.Drawing.Point(855, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 350
        Me.Label16.Text = "Contact"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightCoral
        Me.Label17.Location = New System.Drawing.Point(855, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 349
        Me.Label17.Text = "Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(222, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 356
        Me.Label13.Text = "Service Name"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(347, 257)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 357
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(669, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 17)
        Me.Label28.TabIndex = 361
        Me.Label28.Text = "Gender"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(650, 234)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(130, 17)
        Me.Label27.TabIndex = 360
        Me.Label27.Text = "Service Description"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(668, 181)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(38, 17)
        Me.Label26.TabIndex = 359
        Me.Label26.Text = "Date"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(668, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 17)
        Me.Label18.TabIndex = 358
        Me.Label18.Text = "Service Price"
        '
        'reservationfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 651)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "reservationfrm"
        Me.Text = "reservationfrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.get_ratedata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents svemem As System.Windows.Forms.Button
    Friend WithEvents dte_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents get_ratedata As System.Windows.Forms.DataGridView
    Friend WithEvents rid_txt As System.Windows.Forms.TextBox
    Friend WithEvents mid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents resid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnupdte As System.Windows.Forms.Button
    Friend WithEvents Btndel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
