﻿Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports System.IO

Public Class inventryfrm
    Private bitmap As Bitmap
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim source2 As New BindingSource()
    Dim con As New SqlClient.SqlConnection
    Dim cmd As New SqlClient.SqlCommand
    Dim dt As New DataTable
    Dim cs As String = "Data Source=GEO;Initial Catalog=mainclinicdb;Integrated Security=True"  'connection string to connect with sql server
    'db connection 
    Private Sub dbaccessconnection()
        Try
            con.ConnectionString = cs
            cmd.Connection = con

        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Insert Value in DB
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "insert into tbl_inventrry(Entryno,I_Id,Pro_id,Product_name,Recent_Purchase_Quantity,Totalquantity,Stock_Status,Stockin_date)values('" & inventid_txt.Text & "','" & in_id_txt.Text & "','" & pid_txt.Text & "','" & inname_txt.Text & "','" & quantity_txt.Text & "','" & inquatity_txt.Text & "','" & stock_txt.Text & "','" & inpudte_txt.Value & "')"
            cmd.ExecuteNonQuery()

            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            welcomemsg.Text = "'" & pid_txt.Text & "' details saved successfully!"
                con.Close()
        Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'edit function
    Private Sub edit()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = ("UPDATE tbl_inventrry SET  Entryno= '" & inventid_txt.Text & "', I_Id= '" & in_id_txt.Text & "',Pro_id= '" & pid_txt.Text & "',Product_name= '" & inname_txt.Text & "',Recent_Purchase_Quantity= '" & quantity_txt.Text & "',Totalquantity= '" & inquatity_txt.Text & "',Stock_Status= '" & stock_txt.Text & "',Stockin_date= '" & inpudte_txt.Value & "' where Entryno=" & inventid_txt.Text & "")
                cmd.ExecuteNonQuery()
            welcomemsg.Text = "'" & pid_txt.Text & "' details update successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen
            get_indata.Refresh()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    'Delete function
    Private Sub DeleteSelecedRows()
        Try
            Dim ObjConnection As New SqlConnection()
            Dim i As Integer
            Dim mResult
            mResult = MsgBox("Want you really delete the selected records?", _
            vbYesNo + vbQuestion, "Removal confirmation")
            If mResult = vbNo Then
                Exit Sub
            End If
            ObjConnection.ConnectionString = cs
            Dim ObjCommand As New SqlCommand()
            ObjCommand.Connection = ObjConnection
            For i = Me.get_indata.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from tbl_inventrry where Entryno='" & get_indata.SelectedRows(i).Cells("Entryno").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.get_indata.Rows.Remove(Me.get_indata.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'auto increment the entry id
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(Entryno) FROM tbl_inventrry "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                inventid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                inventid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Inventory Entry" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
   
    'auto increment alphanumeric id
    Private Sub autogenerated()
        Try
            Dim curValue As Integer
            Dim result As String
            Using con As SqlConnection = New SqlConnection(cs)
                con.Open()
                Dim cmd = New SqlCommand("select Max(I_Id) from tbl_inventrry", con)
                result = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(result) Then
                    result = "IN-0000"
                End If

                result = result.Substring(3)
                Int32.TryParse(result, curValue)
                curValue = curValue + 1
                result = "IN" + curValue.ToString("D4")
                in_id_txt.Text = result
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed:AutoIncrement of InventoryID" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data of products and inventory in grid(tab2),getting data from two tables by join
    Private Sub getdata()

        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select tbl_inventrry.Entryno,tbl_inventrry.I_Id ,tbl_products.P_id,tbl_products.p_name,tbl_inventrry.Recent_Purchase_Quantity,tbl_inventrry.Sale_Quantity,tbl_inventrry.Totalquantity,tbl_inventrry.Stock_Status,tbl_inventrry.Stockin_date,tbl_inventrry.Stock_outdate,tbl_products.p_description from tbl_products INNER  join tbl_inventrry on tbl_products.P_id=tbl_inventrry.Pro_id ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_stockdata.DataSource = dt
            get_stockdata.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data in inventory record tab
    Private Sub in_getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("SELECT * From tbl_inventrry ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_indata.DataSource = dt
            get_indata.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving the Data of Inventory" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'fill the combo of products id
    Private Sub FillCombo()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT p_name FROM tbl_products"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "tbl_products")
            With Me.inname_txt
                .DataSource = ds.Tables("tbl_products")
                .DisplayMember = "p_name"
                .ValueMember = "p_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With


        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving and Populating ProductID " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'Functions on form load
    Private Sub stockfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbaccessconnection()
        FillCombo()
        get_stockdata.Refresh()
        txtboxid()
        Call CenterToScreen()
        autogenerated()
        getdata()
        in_getdata()

    End Sub
    'Empty the textboxes
    Private Sub clear()
        Try
            pid_txt.Text = ""
            stock_txt.Text = ""
            inprice_txt.Text = ""
            intxt_des.Text = ""
            Label18.Text = ""
            inventrydtetxt.Text = ""
            Label17.Text = ""
            inname_txt.Text = ""
            quantity_txt.Text = "0"
            inquatity_txt.Text = "0"
        Catch ex As Exception
            MsgBox("Failed:Clear " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    '>>>>>>>>>>>>>>>>>>>>>Buttons<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


    'Save Button
    Private Sub svemem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click

        If Len(Trim(pid_txt.Text)) = 0 Then
            MessageBox.Show("Please select Product ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pid_txt.Focus()
            Exit Sub
        End If
        If Len(Trim(quantity_txt.Text)) = 0 Then
            MessageBox.Show("Please enter quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            stock_txt.Focus()
            Exit Sub
        End If

        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            insert()
            getdata()
            in_getdata()
            welcomemsg.Text = "'" & pid_txt.Text & "' details saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen

        Catch ex As Exception
            welcomemsg.Text = "Error while Saving '" & pid_txt.Text & "' Inventory details"
            welcomemsg.ForeColor = System.Drawing.Color.Red
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'edit Button
    Private Sub btnupdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdte.Click
        edit()
        btnupdte.Enabled = False
        getdata()
        in_getdata()
    End Sub
    'Close Button
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub
    ' delete Button
    Private Sub Btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndel.Click
        TabControl1.SelectedTab = TabPage3
    End Sub
    'Add Button
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        clear()
        txtboxid()
        autogenerated()
        svemem.Enabled = True
        btnupdte.Enabled = False
        Label22.Text = ""
    End Sub
    'it is used to call the data in other box by writing in specific field data in one textbox.
    Private Sub pid_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_products where P_id = '" & pid_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                inname_txt.Text = dbr.GetValue(2)
                inprice_txt.Text = dbr.GetValue(3)
                intxt_des.Text = dbr.GetValue(5)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed:ProductID from Products ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Dispose()
        End Try

    End Sub






    Private Sub get_productdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub
    'Delete selected values from grid by single click in grid tab
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        DeleteSelecedRows()
    End Sub
    'Show popup by Mouse hover in grid tab
    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button1, "Select the one field or more from Grid to Remove")
    End Sub

   
    'by clicking on ingrid content of inventory tab grid
    Private Sub get_indata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_indata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        Label22.Text = "Dont't forget to Update inventory if you edit the purchased quantity"
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub
    'by mouse click they it will populate the textboxes from grid
    Private Sub get_indata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_indata.CellMouseClick

        Try
            Me.inventid_txt.Text = get_indata.CurrentRow.Cells(0).Value.ToString
            Me.in_id_txt.Text = get_indata.CurrentRow.Cells(1).Value.ToString
            Me.pid_txt.Text = get_indata.CurrentRow.Cells(2).Value.ToString
            Me.inname_txt.Text = get_indata.CurrentRow.Cells(3).Value.ToString
            Me.quantity_txt.Text = get_indata.CurrentRow.Cells(4).Value.ToString
            Me.inquatity_txt.Text = get_indata.CurrentRow.Cells(5).Value.ToString
            Me.stock_txt.Text = get_indata.CurrentRow.Cells(6).Value.ToString
            Me.inpudte_txt.Text = get_indata.CurrentRow.Cells(7).Value.ToString
            Me.Label17.Text = get_indata.CurrentRow.Cells(8).Value.ToString
            Me.inventrydtetxt.Text = get_indata.CurrentRow.Cells(9).Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'by clicking on getproduct and invtory grid content of tab inventory data
    Private Sub get_stockdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_stockdata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub
    'by mouse click they it will populate the textboxes from grid of inventory data tab
    Private Sub get_stockdata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_stockdata.CellMouseClick
        Try
            svemem.Enabled = False
            Btndel.Enabled = True
            btnupdte.Enabled = True
            Me.inventid_txt.Text = get_stockdata.CurrentRow.Cells(0).Value.ToString
            Me.in_id_txt.Text = get_stockdata.CurrentRow.Cells(1).Value.ToString
            Me.pid_txt.Text = get_stockdata.CurrentRow.Cells(2).Value.ToString
            Me.inname_txt.Text = get_stockdata.CurrentRow.Cells(3).Value.ToString
            Me.Label17.Text = get_stockdata.CurrentRow.Cells(5).Value.ToString
            Me.inquatity_txt.Text = get_stockdata.CurrentRow.Cells(6).Value.ToString
            Me.stock_txt.Text = get_stockdata.CurrentRow.Cells(7).Value.ToString
            Me.inpudte_txt.Value = get_stockdata.CurrentRow.Cells(8).Value.ToString
            Me.quantity_txt.Text = get_stockdata.CurrentRow.Cells(4).Value.ToString
            Me.inventrydtetxt.Text = get_stockdata.CurrentRow.Cells(9).Value.ToString
            Me.intxt_des.Text = get_stockdata.CurrentRow.Cells(10).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:TextBox not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'add purched quantity to already stock quantity
    Private Sub stockin()
        Try
            Dim addd As Int64
            addd = Convert.ToInt64(quantity_txt.Text) + Convert.ToInt64(inquatity_txt.Text)
            inquatity_txt.Text = Convert.ToString(addd)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Adding Quantity ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub quantity_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles quantity_txt.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub quantity_txt_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles quantity_txt.Validated
        stockin()
        
    End Sub
    'populate by textboxes
    Private Sub inname_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim strsql As String = "select Product_name,Totalquantity,Recent_Purchase_Quantity from tbl_inventrry where Product_name like('" + inname_txt.Text + "%')"
            Dim strcon As String = cs
            Dim odapre As New SqlDataAdapter(strsql, strcon)
            Dim datTable As New DataTable
            Dim incount As Integer
            odapre.Fill(datTable)
            For incount = 0 To datTable.Rows.Count - 1
                inquatity_txt.Text = datTable.Rows(incount)("Totalquantity").ToString
                Label18.Text = datTable.Rows(incount)("Recent_Purchase_Quantity").ToString
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:ProductName Populating", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'search by radio button for stock in
    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * From tbl_inventrry where Stock_Status ='StockIN'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_indata.DataSource = dt
            get_indata.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:StockIn", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'search by radio button for stock out
    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select * From tbl_inventrry where Stock_Status ='StockOut'", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_indata.DataSource = dt
            get_indata.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:StockOut", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    'search product name in grid
    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select * from tbl_inventrry where Product_name like '" & TextBox3.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tbl_inventrry")
            con.Close()
            get_indata.DataSource = ds
            get_indata.DataMember = "tbl_inventrry"
            get_indata.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Product Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        search_txt()
    End Sub
    'search by date
    Private Sub payment_productsearchdate()
        con.Close()
        Try
            ' Dim cn As New SqlConnection
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dfrom As DateTime = DateTimePicker1.Value
            Dim dto As DateTime = DateTimePicker2.Value
            myConnection.ConnectionString = cs
            myConnection.Open()
            Dim str As String = "Select * from tbl_inventrry where Stockin_date >= '" & Format(dfrom, "MM-dd-yyyy") & "' and Stockin_date <='" & Format(dto, "MM-dd-yyyy") & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(str, myConnection)
            da.Fill(dt)
            get_indata.DataSource = dt
            myConnection.Close()
            get_indata.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Date Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        payment_productsearchdate()
        RadioButton1.Checked = False
    End Sub
    'tooltip message on mouse hover on edit btn
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If btnupdte.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Select the field from Grid to Edit")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Click to Edit")
        End If
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        If btnupdte.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Select the field from Grid to Edit")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Click to Edit")
        End If
    End Sub

    Private Sub inquatity_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles inquatity_txt.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub inquatity_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inquatity_txt.TextChanged
        Try
            If inquatity_txt.Text > 0 Then
                stock_txt.Text = "StockIn"
            Else
                stock_txt.Text = "StockOut"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Stock Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub inname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inname_txt.SelectedIndexChanged

        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_products where p_name = '" & inname_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try
            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                pid_txt.Text = dbr.GetValue(1)
                inprice_txt.Text = dbr.GetValue(3)
                intxt_des.Text = dbr.GetValue(5)
            End If
        Catch ex As Exception
            MessageBox.Show("Failed:ProductID from Products ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Dispose()
        End Try
    End Sub

    
    Private Sub welcomemsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles welcomemsg.Click

    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub
End Class