<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ratesfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ratesfrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnupdte = New System.Windows.Forms.Button()
        Me.Btndel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rid_txt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.svemem = New System.Windows.Forms.Button()
        Me.prom_txt = New System.Windows.Forms.ComboBox()
        Me.des_txt = New System.Windows.Forms.RichTextBox()
        Me.ratid_txt = New System.Windows.Forms.ComboBox()
        Me.price_txt = New System.Windows.Forms.TextBox()
        Me.type_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.get_ratesdata = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.get_ratesdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(790, 502)
        Me.TabControl1.TabIndex = 274
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.Btnadd)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnupdte)
        Me.TabPage1.Controls.Add(Me.Btndel)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.rid_txt)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.svemem)
        Me.TabPage1.Controls.Add(Me.prom_txt)
        Me.TabPage1.Controls.Add(Me.des_txt)
        Me.TabPage1.Controls.Add(Me.ratid_txt)
        Me.TabPage1.Controls.Add(Me.price_txt)
        Me.TabPage1.Controls.Add(Me.type_txt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(782, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Rates"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.LightCoral
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(69, 444)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 17)
        Me.Label25.TabIndex = 338
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
        Me.Btnadd.Location = New System.Drawing.Point(475, 398)
        Me.Btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(45, 35)
        Me.Btnadd.TabIndex = 336
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightCoral
        Me.Label19.Location = New System.Drawing.Point(449, 444)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 337
        Me.Label19.Text = "Add New"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightCoral
        Me.Label15.Location = New System.Drawing.Point(673, 451)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 335
        Me.Label15.Text = "Delete"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightCoral
        Me.Label10.Location = New System.Drawing.Point(610, 451)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 17)
        Me.Label10.TabIndex = 334
        Me.Label10.Text = "Edit"
        '
        'btnupdte
        '
        Me.btnupdte.BackColor = System.Drawing.Color.White
        Me.btnupdte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnupdte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdte.ForeColor = System.Drawing.Color.White
        Me.btnupdte.Image = CType(resources.GetObject("btnupdte.Image"), System.Drawing.Image)
        Me.btnupdte.Location = New System.Drawing.Point(604, 410)
        Me.btnupdte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdte.Name = "btnupdte"
        Me.btnupdte.Size = New System.Drawing.Size(42, 34)
        Me.btnupdte.TabIndex = 332
        Me.btnupdte.UseVisualStyleBackColor = False
        '
        'Btndel
        '
        Me.Btndel.BackColor = System.Drawing.Color.White
        Me.Btndel.BackgroundImage = CType(resources.GetObject("Btndel.BackgroundImage"), System.Drawing.Image)
        Me.Btndel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btndel.ForeColor = System.Drawing.Color.White
        Me.Btndel.Location = New System.Drawing.Point(676, 410)
        Me.Btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.Btndel.Name = "Btndel"
        Me.Btndel.Size = New System.Drawing.Size(52, 34)
        Me.Btndel.TabIndex = 333
        Me.Btndel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightCoral
        Me.Label9.Location = New System.Drawing.Point(537, 448)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 17)
        Me.Label9.TabIndex = 331
        Me.Label9.Text = "Save"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(541, 411)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 330
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 288
        Me.Label8.Text = "Rate ID"
        '
        'rid_txt
        '
        Me.rid_txt.Location = New System.Drawing.Point(281, 67)
        Me.rid_txt.Name = "rid_txt"
        Me.rid_txt.Size = New System.Drawing.Size(216, 22)
        Me.rid_txt.TabIndex = 287
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(672, 447)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 20)
        Me.Label7.TabIndex = 286
        Me.Label7.Text = "Save"
        '
        'svemem
        '
        Me.svemem.BackColor = System.Drawing.SystemColors.Control
        Me.svemem.BackgroundImage = CType(resources.GetObject("svemem.BackgroundImage"), System.Drawing.Image)
        Me.svemem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svemem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svemem.ForeColor = System.Drawing.SystemColors.Control
        Me.svemem.Location = New System.Drawing.Point(676, 410)
        Me.svemem.Margin = New System.Windows.Forms.Padding(4)
        Me.svemem.Name = "svemem"
        Me.svemem.Size = New System.Drawing.Size(36, 33)
        Me.svemem.TabIndex = 285
        Me.svemem.UseVisualStyleBackColor = False
        '
        'prom_txt
        '
        Me.prom_txt.FormattingEnabled = True
        Me.prom_txt.Items.AddRange(New Object() {"Regular", "Promo"})
        Me.prom_txt.Location = New System.Drawing.Point(281, 173)
        Me.prom_txt.Name = "prom_txt"
        Me.prom_txt.Size = New System.Drawing.Size(216, 24)
        Me.prom_txt.TabIndex = 284
        '
        'des_txt
        '
        Me.des_txt.Location = New System.Drawing.Point(281, 248)
        Me.des_txt.Name = "des_txt"
        Me.des_txt.Size = New System.Drawing.Size(216, 126)
        Me.des_txt.TabIndex = 283
        Me.des_txt.Text = ""
        '
        'ratid_txt
        '
        Me.ratid_txt.FormattingEnabled = True
        Me.ratid_txt.Location = New System.Drawing.Point(281, 210)
        Me.ratid_txt.Name = "ratid_txt"
        Me.ratid_txt.Size = New System.Drawing.Size(216, 24)
        Me.ratid_txt.TabIndex = 282
        '
        'price_txt
        '
        Me.price_txt.Location = New System.Drawing.Point(281, 132)
        Me.price_txt.Name = "price_txt"
        Me.price_txt.Size = New System.Drawing.Size(216, 22)
        Me.price_txt.TabIndex = 281
        '
        'type_txt
        '
        Me.type_txt.Location = New System.Drawing.Point(281, 95)
        Me.type_txt.Name = "type_txt"
        Me.type_txt.Size = New System.Drawing.Size(216, 22)
        Me.type_txt.TabIndex = 280
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(348, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 44)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Rates"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 278
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Reservation ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 276
        Me.Label3.Text = "Promo Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 17)
        Me.Label1.TabIndex = 274
        Me.Label1.Text = "Type"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.get_ratesdata)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(782, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rates Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'get_ratesdata
        '
        Me.get_ratesdata.AllowUserToAddRows = False
        Me.get_ratesdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratesdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.get_ratesdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.get_ratesdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_ratesdata.BackgroundColor = System.Drawing.Color.Indigo
        Me.get_ratesdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_ratesdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratesdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.get_ratesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.get_ratesdata.DefaultCellStyle = DataGridViewCellStyle3
        Me.get_ratesdata.EnableHeadersVisualStyles = False
        Me.get_ratesdata.GridColor = System.Drawing.Color.Indigo
        Me.get_ratesdata.Location = New System.Drawing.Point(25, 56)
        Me.get_ratesdata.Margin = New System.Windows.Forms.Padding(4)
        Me.get_ratesdata.Name = "get_ratesdata"
        Me.get_ratesdata.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratesdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.get_ratesdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratesdata.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.get_ratesdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_ratesdata.Size = New System.Drawing.Size(732, 395)
        Me.get_ratesdata.TabIndex = 152
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.LightCoral
        Me.Button6.Location = New System.Drawing.Point(567, 7)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 31)
        Me.Button6.TabIndex = 317
        Me.Button6.Text = "&Select Rows to Remove"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ratesfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 554)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ratesfrm"
        Me.Text = "ratesfrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.get_ratesdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents svemem As System.Windows.Forms.Button
    Friend WithEvents prom_txt As System.Windows.Forms.ComboBox
    Friend WithEvents des_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents ratid_txt As System.Windows.Forms.ComboBox
    Friend WithEvents price_txt As System.Windows.Forms.TextBox
    Friend WithEvents type_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents get_ratesdata As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnupdte As System.Windows.Forms.Button
    Friend WithEvents Btndel As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
