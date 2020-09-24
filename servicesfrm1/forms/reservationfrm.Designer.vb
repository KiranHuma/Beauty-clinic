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
        Me.get_ratedata = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
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
        Me.TabControl1.Size = New System.Drawing.Size(848, 519)
        Me.TabControl1.TabIndex = 263
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
        Me.TabPage1.Size = New System.Drawing.Size(840, 490)
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
        Me.Label25.Location = New System.Drawing.Point(38, 446)
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
        Me.Btnadd.Location = New System.Drawing.Point(470, 409)
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
        Me.Label19.Location = New System.Drawing.Point(444, 455)
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
        Me.Label15.Location = New System.Drawing.Point(665, 461)
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
        Me.Label10.Location = New System.Drawing.Point(602, 461)
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
        Me.btnupdte.Location = New System.Drawing.Point(596, 420)
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
        Me.Btndel.Location = New System.Drawing.Point(668, 420)
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
        Me.Label7.Location = New System.Drawing.Point(664, 457)
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
        Me.Button2.Location = New System.Drawing.Point(668, 420)
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
        Me.mid_txt.Location = New System.Drawing.Point(347, 264)
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
        Me.Label5.Location = New System.Drawing.Point(222, 264)
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
        Me.Label1.Location = New System.Drawing.Point(527, 457)
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
        Me.svemem.Location = New System.Drawing.Point(533, 420)
        Me.svemem.Margin = New System.Windows.Forms.Padding(4)
        Me.svemem.Name = "svemem"
        Me.svemem.Size = New System.Drawing.Size(36, 33)
        Me.svemem.TabIndex = 268
        Me.svemem.UseVisualStyleBackColor = False
        '
        'dte_txt
        '
        Me.dte_txt.Location = New System.Drawing.Point(347, 308)
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
        Me.Label2.Location = New System.Drawing.Point(222, 313)
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
        'get_ratedata
        '
        Me.get_ratedata.AllowUserToAddRows = False
        Me.get_ratedata.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratedata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.get_ratedata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.get_ratedata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_ratedata.BackgroundColor = System.Drawing.Color.Indigo
        Me.get_ratedata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_ratedata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratedata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.get_ratedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.get_ratedata.DefaultCellStyle = DataGridViewCellStyle3
        Me.get_ratedata.EnableHeadersVisualStyles = False
        Me.get_ratedata.GridColor = System.Drawing.Color.Indigo
        Me.get_ratedata.Location = New System.Drawing.Point(17, 62)
        Me.get_ratedata.Margin = New System.Windows.Forms.Padding(4)
        Me.get_ratedata.Name = "get_ratedata"
        Me.get_ratedata.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_ratedata.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.get_ratedata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.get_ratedata.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.get_ratedata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_ratedata.Size = New System.Drawing.Size(805, 410)
        Me.get_ratedata.TabIndex = 151
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
        'reservationfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 543)
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
End Class
