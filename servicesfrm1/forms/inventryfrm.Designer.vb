<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventryfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventryfrm))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inventrydtetxt = New System.Windows.Forms.DateTimePicker()
        Me.pid_txt = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.svemem = New System.Windows.Forms.Button()
        Me.quantity_txt = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.get_stockdata = New System.Windows.Forms.DataGridView()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.get_stockdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(108, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(621, 505)
        Me.TabControl1.TabIndex = 300
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.inventrydtetxt)
        Me.TabPage1.Controls.Add(Me.pid_txt)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.svemem)
        Me.TabPage1.Controls.Add(Me.quantity_txt)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ShapeContainer1)
        Me.TabPage1.ForeColor = System.Drawing.Color.LightCoral
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(613, 473)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add Rates"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightCoral
        Me.Panel1.ForeColor = System.Drawing.Color.Snow
        Me.Panel1.Location = New System.Drawing.Point(-4, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 19)
        Me.Panel1.TabIndex = 310
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 309
        Me.Label3.Text = "Date"
        '
        'inventrydtetxt
        '
        Me.inventrydtetxt.CalendarForeColor = System.Drawing.Color.LightCoral
        Me.inventrydtetxt.CalendarTitleBackColor = System.Drawing.Color.Salmon
        Me.inventrydtetxt.CalendarTitleForeColor = System.Drawing.Color.LightCoral
        Me.inventrydtetxt.CalendarTrailingForeColor = System.Drawing.Color.MistyRose
        Me.inventrydtetxt.Location = New System.Drawing.Point(219, 264)
        Me.inventrydtetxt.Name = "inventrydtetxt"
        Me.inventrydtetxt.Size = New System.Drawing.Size(216, 22)
        Me.inventrydtetxt.TabIndex = 308
        '
        'pid_txt
        '
        Me.pid_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.pid_txt.FormattingEnabled = True
        Me.pid_txt.Location = New System.Drawing.Point(216, 147)
        Me.pid_txt.Name = "pid_txt"
        Me.pid_txt.Size = New System.Drawing.Size(212, 24)
        Me.pid_txt.TabIndex = 307
        Me.pid_txt.Text = "Select Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "Save"
        '
        'svemem
        '
        Me.svemem.BackColor = System.Drawing.SystemColors.Control
        Me.svemem.BackgroundImage = CType(resources.GetObject("svemem.BackgroundImage"), System.Drawing.Image)
        Me.svemem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.svemem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.svemem.ForeColor = System.Drawing.SystemColors.Control
        Me.svemem.Location = New System.Drawing.Point(398, 331)
        Me.svemem.Margin = New System.Windows.Forms.Padding(4)
        Me.svemem.Name = "svemem"
        Me.svemem.Size = New System.Drawing.Size(36, 33)
        Me.svemem.TabIndex = 305
        Me.svemem.UseVisualStyleBackColor = False
        '
        'quantity_txt
        '
        Me.quantity_txt.ForeColor = System.Drawing.Color.LightCoral
        Me.quantity_txt.FormattingEnabled = True
        Me.quantity_txt.Items.AddRange(New Object() {"In Stock", "Stock Out"})
        Me.quantity_txt.Location = New System.Drawing.Point(218, 207)
        Me.quantity_txt.Name = "quantity_txt"
        Me.quantity_txt.Size = New System.Drawing.Size(216, 24)
        Me.quantity_txt.TabIndex = 304
        Me.quantity_txt.Text = "Select Value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCoral
        Me.Label6.Location = New System.Drawing.Point(231, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 44)
        Me.Label6.TabIndex = 302
        Me.Label6.Text = "Inventory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 301
        Me.Label4.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 300
        Me.Label1.Text = "Product ID"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(607, 467)
        Me.ShapeContainer1.TabIndex = 311
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Location = New System.Drawing.Point(463, 33)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(68, 59)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.LightCoral
        Me.RectangleShape3.BorderColor = System.Drawing.Color.LightCoral
        Me.RectangleShape3.Location = New System.Drawing.Point(215, 260)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(217, 23)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.LightCoral
        Me.RectangleShape2.BorderColor = System.Drawing.Color.LightCoral
        Me.RectangleShape2.Location = New System.Drawing.Point(213, 202)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(220, 26)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightCoral
        Me.RectangleShape1.BorderColor = System.Drawing.Color.LightCoral
        Me.RectangleShape1.Location = New System.Drawing.Point(212, 142)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(212, 26)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.get_stockdata)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(613, 473)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Rates Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'get_stockdata
        '
        Me.get_stockdata.AllowUserToAddRows = False
        Me.get_stockdata.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.get_stockdata.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.get_stockdata.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.get_stockdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.get_stockdata.BackgroundColor = System.Drawing.Color.Indigo
        Me.get_stockdata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.get_stockdata.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_stockdata.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.get_stockdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.get_stockdata.DefaultCellStyle = DataGridViewCellStyle18
        Me.get_stockdata.EnableHeadersVisualStyles = False
        Me.get_stockdata.GridColor = System.Drawing.Color.Indigo
        Me.get_stockdata.Location = New System.Drawing.Point(25, 56)
        Me.get_stockdata.Margin = New System.Windows.Forms.Padding(4)
        Me.get_stockdata.Name = "get_stockdata"
        Me.get_stockdata.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.get_stockdata.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.get_stockdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Indigo
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.get_stockdata.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.get_stockdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.get_stockdata.Size = New System.Drawing.Size(563, 395)
        Me.get_stockdata.TabIndex = 152
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.BackColor = System.Drawing.Color.LightCoral
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.ForeColor = System.Drawing.Color.LightCoral
        Me.Button12.Location = New System.Drawing.Point(800, 13)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(31, 30)
        Me.Button12.TabIndex = 301
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label23.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(578, 15)
        Me.Label23.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 28)
        Me.Label23.TabIndex = 302
        Me.Label23.Text = "Date"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'inventryfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(844, 585)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventryfrm"
        Me.Text = "stockfrm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.get_stockdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents svemem As System.Windows.Forms.Button
    Friend WithEvents quantity_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents get_stockdata As System.Windows.Forms.DataGridView
    Friend WithEvents pid_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inventrydtetxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label23 As System.Windows.Forms.Label
End Class
