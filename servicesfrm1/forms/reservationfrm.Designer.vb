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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.rese_time = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.reservedon_txt = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.rese_sertxtt = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rese_sertxt = New System.Windows.Forms.RichTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.reentry_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rid_txt = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.mid_txt = New System.Windows.Forms.ComboBox()
        Me.re_gendrtxt = New System.Windows.Forms.Label()
        Me.re_serdescriptiontxt = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.re_memberloction_txt = New System.Windows.Forms.Label()
        Me.re_memberadress_txt = New System.Windows.Forms.Label()
        Me.re_memberage_txt = New System.Windows.Forms.Label()
        Me.re_membercntct_txt = New System.Windows.Forms.Label()
        Me.re_mname_txt = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.svemem = New System.Windows.Forms.Button()
        Me.dte_txt = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.get_reservationdata = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.get_reservationdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(53, 98)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1262, 615)
        Me.TabControl1.TabIndex = 263
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.rese_time)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.reservedon_txt)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.rese_sertxtt)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.rese_sertxt)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.reentry_txt)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.rid_txt)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.mid_txt)
        Me.TabPage1.Controls.Add(Me.re_gendrtxt)
        Me.TabPage1.Controls.Add(Me.re_serdescriptiontxt)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.re_memberloction_txt)
        Me.TabPage1.Controls.Add(Me.re_memberadress_txt)
        Me.TabPage1.Controls.Add(Me.re_memberage_txt)
        Me.TabPage1.Controls.Add(Me.re_membercntct_txt)
        Me.TabPage1.Controls.Add(Me.re_mname_txt)
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
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.svemem)
        Me.TabPage1.Controls.Add(Me.dte_txt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1254, 586)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reservation"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'rese_time
        '
        Me.rese_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.rese_time.Location = New System.Drawing.Point(179, 336)
        Me.rese_time.Name = "rese_time"
        Me.rese_time.ShowUpDown = True
        Me.rese_time.Size = New System.Drawing.Size(200, 22)
        Me.rese_time.TabIndex = 382
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(54, 341)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 17)
        Me.Label22.TabIndex = 381
        Me.Label22.Text = "Time"
        '
        'reservedon_txt
        '
        Me.reservedon_txt.Location = New System.Drawing.Point(179, 376)
        Me.reservedon_txt.Name = "reservedon_txt"
        Me.reservedon_txt.Size = New System.Drawing.Size(200, 22)
        Me.reservedon_txt.TabIndex = 380
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(54, 381)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 17)
        Me.Label21.TabIndex = 379
        Me.Label21.Text = "Date"
        '
        'rese_sertxtt
        '
        Me.rese_sertxtt.FormattingEnabled = True
        Me.rese_sertxtt.Items.AddRange(New Object() {"Facial Waxing", "Underarm Waxing", "Half legs Waxing", "Full legs Waxing", "Bikini Waxing", "Brazillian Waxing", "Full Body Waxing", "Eyebrow Threading", "Upper Lip", "Korean Natural Lash", "Korean Mascara Look", "Barbie Natural Look", "Barbie Volume Set", "Rusian Volume Set", "Sidney Volume Set", "Eyelash Perm with Keratin", "Manicure", "Pedicure", "Gel Polish", "Foot Spa", "Ear Candling", "Warts Removal", "Facial RF", "Facial Whitening", "Glutathione IV Push/Drip", "Mesolipo Slimming Inject", "Diamond Peel", "Lipo Cavitation and Lipo Laser", "Lipo Cavitation and Lipo Laser(Arms)", "Lipo Cavitation and Lipo Laser(Tummy)", "Lipo Cavitation and Lipo Laser(Legs)"})
        Me.rese_sertxtt.Location = New System.Drawing.Point(179, 208)
        Me.rese_sertxtt.Name = "rese_sertxtt"
        Me.rese_sertxtt.Size = New System.Drawing.Size(200, 24)
        Me.rese_sertxtt.TabIndex = 378
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 27)
        Me.Button1.TabIndex = 377
        Me.Button1.Text = "Add More"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rese_sertxt
        '
        Me.rese_sertxt.Location = New System.Drawing.Point(477, 186)
        Me.rese_sertxt.Name = "rese_sertxt"
        Me.rese_sertxt.Size = New System.Drawing.Size(164, 118)
        Me.rese_sertxt.TabIndex = 376
        Me.rese_sertxt.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.LightCoral
        Me.Label18.Location = New System.Drawing.Point(756, 320)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 17)
        Me.Label18.TabIndex = 375
        Me.Label18.Text = "Gender"
        Me.Label18.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.LightCoral
        Me.Label20.Location = New System.Drawing.Point(677, 358)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 17)
        Me.Label20.TabIndex = 374
        Me.Label20.Text = "Service Description"
        Me.Label20.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.LightCoral
        Me.Label11.Location = New System.Drawing.Point(747, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 17)
        Me.Label11.TabIndex = 372
        Me.Label11.Text = "Location"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightCoral
        Me.Label12.Location = New System.Drawing.Point(749, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 17)
        Me.Label12.TabIndex = 371
        Me.Label12.Text = "Address"
        Me.Label12.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightCoral
        Me.Label14.Location = New System.Drawing.Point(753, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 17)
        Me.Label14.TabIndex = 370
        Me.Label14.Text = "Age"
        Me.Label14.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.LightCoral
        Me.Label16.Location = New System.Drawing.Point(753, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 369
        Me.Label16.Text = "Contact"
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.LightCoral
        Me.Label17.Location = New System.Drawing.Point(753, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 368
        Me.Label17.Text = "Name"
        Me.Label17.Visible = False
        '
        'reentry_txt
        '
        Me.reentry_txt.Location = New System.Drawing.Point(179, 68)
        Me.reentry_txt.Name = "reentry_txt"
        Me.reentry_txt.ReadOnly = True
        Me.reentry_txt.Size = New System.Drawing.Size(200, 22)
        Me.reentry_txt.TabIndex = 367
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 366
        Me.Label8.Text = "Re_Entry#"
        '
        'rid_txt
        '
        Me.rid_txt.FormattingEnabled = True
        Me.rid_txt.Location = New System.Drawing.Point(179, 163)
        Me.rid_txt.Name = "rid_txt"
        Me.rid_txt.Size = New System.Drawing.Size(200, 24)
        Me.rid_txt.TabIndex = 364
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.ForeColor = System.Drawing.Color.Snow
        Me.Panel1.Location = New System.Drawing.Point(3, 564)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1248, 19)
        Me.Panel1.TabIndex = 363
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightCoral
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(256, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 269
        Me.Label4.Text = "Welcome"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(1011, -6)
        Me.Label23.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 28)
        Me.Label23.TabIndex = 302
        Me.Label23.Text = "Date"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'mid_txt
        '
        Me.mid_txt.FormattingEnabled = True
        Me.mid_txt.Location = New System.Drawing.Point(179, 258)
        Me.mid_txt.Name = "mid_txt"
        Me.mid_txt.Size = New System.Drawing.Size(200, 24)
        Me.mid_txt.TabIndex = 362
        '
        're_gendrtxt
        '
        Me.re_gendrtxt.AutoSize = True
        Me.re_gendrtxt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_gendrtxt.Location = New System.Drawing.Point(830, 320)
        Me.re_gendrtxt.Name = "re_gendrtxt"
        Me.re_gendrtxt.Size = New System.Drawing.Size(0, 17)
        Me.re_gendrtxt.TabIndex = 361
        '
        're_serdescriptiontxt
        '
        Me.re_serdescriptiontxt.AutoSize = True
        Me.re_serdescriptiontxt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_serdescriptiontxt.Location = New System.Drawing.Point(832, 358)
        Me.re_serdescriptiontxt.Name = "re_serdescriptiontxt"
        Me.re_serdescriptiontxt.Size = New System.Drawing.Size(0, 17)
        Me.re_serdescriptiontxt.TabIndex = 360
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 17)
        Me.Label13.TabIndex = 356
        Me.Label13.Text = "Service Name"
        '
        're_memberloction_txt
        '
        Me.re_memberloction_txt.AutoSize = True
        Me.re_memberloction_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_memberloction_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_memberloction_txt.Location = New System.Drawing.Point(826, 210)
        Me.re_memberloction_txt.Name = "re_memberloction_txt"
        Me.re_memberloction_txt.Size = New System.Drawing.Size(0, 17)
        Me.re_memberloction_txt.TabIndex = 354
        '
        're_memberadress_txt
        '
        Me.re_memberadress_txt.AutoSize = True
        Me.re_memberadress_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_memberadress_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_memberadress_txt.Location = New System.Drawing.Point(828, 260)
        Me.re_memberadress_txt.Name = "re_memberadress_txt"
        Me.re_memberadress_txt.Size = New System.Drawing.Size(0, 17)
        Me.re_memberadress_txt.TabIndex = 352
        '
        're_memberage_txt
        '
        Me.re_memberage_txt.AutoSize = True
        Me.re_memberage_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_memberage_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_memberage_txt.Location = New System.Drawing.Point(832, 170)
        Me.re_memberage_txt.Name = "re_memberage_txt"
        Me.re_memberage_txt.Size = New System.Drawing.Size(0, 17)
        Me.re_memberage_txt.TabIndex = 351
        '
        're_membercntct_txt
        '
        Me.re_membercntct_txt.AutoSize = True
        Me.re_membercntct_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_membercntct_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_membercntct_txt.Location = New System.Drawing.Point(832, 139)
        Me.re_membercntct_txt.Name = "re_membercntct_txt"
        Me.re_membercntct_txt.Size = New System.Drawing.Size(0, 17)
        Me.re_membercntct_txt.TabIndex = 350
        '
        're_mname_txt
        '
        Me.re_mname_txt.AutoSize = True
        Me.re_mname_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.re_mname_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.re_mname_txt.Location = New System.Drawing.Point(832, 101)
        Me.re_mname_txt.Name = "re_mname_txt"
        Me.re_mname_txt.Size = New System.Drawing.Size(0, 17)
        Me.re_mname_txt.TabIndex = 349
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.Transparent
        Me.Btnadd.BackgroundImage = CType(resources.GetObject("Btnadd.BackgroundImage"), System.Drawing.Image)
        Me.Btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnadd.ForeColor = System.Drawing.Color.White
        Me.Btnadd.Location = New System.Drawing.Point(979, 479)
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
        Me.Label19.Location = New System.Drawing.Point(953, 518)
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
        Me.Label15.Location = New System.Drawing.Point(1170, 520)
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
        Me.Label10.Location = New System.Drawing.Point(1107, 520)
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
        Me.btnupdte.Location = New System.Drawing.Point(1101, 479)
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
        Me.Btndel.Location = New System.Drawing.Point(1173, 479)
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
        Me.Label7.Location = New System.Drawing.Point(1169, 516)
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
        Me.Button2.Location = New System.Drawing.Point(1173, 479)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 33)
        Me.Button2.TabIndex = 338
        Me.Button2.UseVisualStyleBackColor = False
        '
        'resid_txt
        '
        Me.resid_txt.Location = New System.Drawing.Point(179, 120)
        Me.resid_txt.Name = "resid_txt"
        Me.resid_txt.ReadOnly = True
        Me.resid_txt.Size = New System.Drawing.Size(200, 22)
        Me.resid_txt.TabIndex = 273
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 272
        Me.Label6.Text = "Reservation ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 268
        Me.Label3.Text = "RateID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 262)
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
        Me.Label1.Location = New System.Drawing.Point(1032, 516)
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
        Me.svemem.Location = New System.Drawing.Point(1038, 479)
        Me.svemem.Margin = New System.Windows.Forms.Padding(4)
        Me.svemem.Name = "svemem"
        Me.svemem.Size = New System.Drawing.Size(36, 33)
        Me.svemem.TabIndex = 268
        Me.svemem.UseVisualStyleBackColor = False
        '
        'dte_txt
        '
        Me.dte_txt.Location = New System.Drawing.Point(179, 298)
        Me.dte_txt.Name = "dte_txt"
        Me.dte_txt.Size = New System.Drawing.Size(200, 22)
        Me.dte_txt.TabIndex = 266
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Reservation Date"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.get_reservationdata)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1254, 586)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reservation Records"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'get_reservationdata
        '
        Me.get_reservationdata.AllowUserToAddRows = False
        Me.get_reservationdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.get_reservationdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.get_reservationdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.get_reservationdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_reservationdata.BackgroundColor = System.Drawing.Color.LightCoral
        Me.get_reservationdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_reservationdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_reservationdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.get_reservationdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.get_reservationdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.get_reservationdata.EnableHeadersVisualStyles = False
        Me.get_reservationdata.GridColor = System.Drawing.Color.LightCoral
        Me.get_reservationdata.Location = New System.Drawing.Point(7, 91)
        Me.get_reservationdata.Margin = New System.Windows.Forms.Padding(4)
        Me.get_reservationdata.Name = "get_reservationdata"
        Me.get_reservationdata.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_reservationdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.get_reservationdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCoral
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.get_reservationdata.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.get_reservationdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_reservationdata.Size = New System.Drawing.Size(1243, 488)
        Me.get_reservationdata.TabIndex = 320
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.LightCoral
        Me.Button6.Location = New System.Drawing.Point(867, 42)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 31)
        Me.Button6.TabIndex = 317
        Me.Button6.Text = "&Select Rows to Remove"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightCoral
        Me.Label9.Location = New System.Drawing.Point(518, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 44)
        Me.Label9.TabIndex = 266
        Me.Label9.Text = "Reservation"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(513, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 15)
        Me.TextBox1.TabIndex = 383
        Me.TextBox1.Visible = False
        '
        'reservationfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1351, 820)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reservationfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "reservationfrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.get_reservationdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents svemem As System.Windows.Forms.Button
    Friend WithEvents dte_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
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
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents re_memberloction_txt As System.Windows.Forms.Label
    Friend WithEvents re_memberadress_txt As System.Windows.Forms.Label
    Friend WithEvents re_memberage_txt As System.Windows.Forms.Label
    Friend WithEvents re_membercntct_txt As System.Windows.Forms.Label
    Friend WithEvents re_mname_txt As System.Windows.Forms.Label
    Friend WithEvents re_gendrtxt As System.Windows.Forms.Label
    Friend WithEvents re_serdescriptiontxt As System.Windows.Forms.Label
    Friend WithEvents mid_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents rid_txt As System.Windows.Forms.ComboBox
    Friend WithEvents reentry_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rese_sertxt As System.Windows.Forms.RichTextBox
    Friend WithEvents rese_sertxtt As System.Windows.Forms.ComboBox
    Friend WithEvents get_reservationdata As System.Windows.Forms.DataGridView
    Friend WithEvents rese_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents reservedon_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
