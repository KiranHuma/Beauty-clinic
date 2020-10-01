Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports System.IO

Public Class inventryfrm
    Private bitmap As Bitmap 'for print of grid
    Dim rdr As SqlDataReader
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet            'for dataset
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()                   'for binding source
    Dim source2 As New BindingSource()
    Dim con As New SqlClient.SqlConnection                      'for sql
    Dim cmd As New SqlClient.SqlCommand                        'for sql
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
   
    Private Sub insert()
        Try
            con.ConnectionString = cs
            cmd.Connection = con
            con.Open()
           

            cmd.CommandText = "insert into tbl_inventrry(Entryno,I_Id,Pro_id,Product_name,Totalquantity,Stock_Status,Stockin_date,In_price)values('" & inventid_txt.Text & "','" & in_id_txt.Text & "','" & pid_txt.Text & "','" & inname_txt.Text & "','" & inquatity_txt.Text & "','" & stock_txt.Text & "','" & inpudte_txt.Text & "','" & inprice_txt.Text & "')"
            cmd.ExecuteNonQuery()
                con.Close()
        Catch ex As Exception

            MsgBox("DataBase not connected due to the reason because " & ex.Message)

        End Try

    End Sub
    'edit function
    Private Sub edit()
      

        Try

            dbaccessconnection()

            con.Open()
            cmd.CommandText = ("UPDATE tbl_inventrry SET  Entryno= '" & inventid_txt.Text & "', I_Id= '" & in_id_txt.Text & "',Pro_id= '" & pid_txt.Text & "',Product_name= '" & inname_txt.Text & "',Totalquantity= '" & inquatity_txt.Text & "',Stock_Status= '" & stock_txt.Text & "',Stockin_date= '" & inpudte_txt.Text & "',Stockin_date= '" & inprice_txt.Text & "' where Entryno=" & inventid_txt.Text & "")
                cmd.ExecuteNonQuery()
            ' MessageBox.Show("Data Updated")
                Label25.Text = "Inventory details updated successfully!"
                get_indata.Refresh()
                con.Close()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated")
        End Try
    End Sub

    'Show data in data grid
    Private Sub getdata()
        '"Select tbl_inventrry.In_ID ,tbl_products.p_name from tbl_products full join tbl_inventrry on tbl_products.pro_id=tbl_inventrry.In_ID ", con)
        'SELECT * FROM tbl_inventrry full join tbl_products on tbl_inventrry.In_ID= tbl_products.pro_id
        'SELECT *  FROM tbl_products UNION  SELECT * FROM tbl_inventrry 
        'SELECT * From tbl_products where p_totalquantity!= 0
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select tbl_inventrry.Entryno,tbl_inventrry.I_Id ,tbl_products.P_id,tbl_products.p_name,tbl_products.p_price,tbl_products.padd_quantity,tbl_products.p_dte,tbl_inventrry.Totalquantity,tbl_inventrry.Stock_Status,tbl_inventrry.Stockin_date,tbl_inventrry.Stock_outdate,tbl_products.p_description from tbl_products INNER  join tbl_inventrry on tbl_products.P_id=tbl_inventrry.Pro_id ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_stockdata.DataSource = dt
            get_stockdata.Refresh()
        Catch ex As Exception
            MessageBox.Show(" Error while retriving data" & ex.Message)
        End Try
    End Sub
    Private Sub in_getdata()
        '"Select tbl_inventrry.In_ID ,tbl_products.p_name from tbl_products full join tbl_inventrry on tbl_products.pro_id=tbl_inventrry.In_ID ", con)
        'SELECT * FROM tbl_inventrry full join tbl_products on tbl_inventrry.In_ID= tbl_products.pro_id
        'SELECT *  FROM tbl_products UNION  SELECT * FROM tbl_inventrry 
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
            MessageBox.Show(" Error while retriving data" & ex.Message)
        End Try
    End Sub

    Private Sub FillCombo()
        Try
            Dim conn As New System.Data.SqlClient.SqlConnection(cs)
            Dim strSQL As String = "SELECT P_id FROM tbl_products"
            Dim da As New System.Data.SqlClient.SqlDataAdapter(strSQL, conn)
            Dim ds As New DataSet
            da.Fill(ds, "tbl_products")
            With Me.pid_txt
                .DataSource = ds.Tables("tbl_products")
                .DisplayMember = "P_id"
                .ValueMember = "P_id"
                .SelectedIndex = 0
            End With
            checkstock()

        Catch ex As Exception
            MessageBox.Show(" Error while retriving data" & ex.Message)
        End Try
        
    End Sub

   

    Private Sub stockfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbaccessconnection()
        source1.Filter = "[P_id] = '" & pid_txt.Text & "'"
        Me.Label23.Text = Format(Now, "dd-MMM-yyyy")
        FillCombo()
        get_stockdata.Refresh()
        txtboxid()

        autogenerated()
        getdata()
        in_getdata()

    End Sub
    Private Sub checkstock()
        If Not quantity_txt.Text = 0 Then
            stock_txt.Text = "StockIN"
        ElseIf quantity_txt.Text = 0 Then
            stock_txt.Text = "StockOut"
        End If
    End Sub
   
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
            MsgBox("Error" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub autogenerated()

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
    End Sub
    Private Sub svemem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click

        If Len(Trim(pid_txt.Text)) = 0 Then
            MessageBox.Show("Please select Product ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pid_txt.Focus()
            Exit Sub
        End If
        If Len(Trim(stock_txt.Text)) = 0 Then
            MessageBox.Show("Please enter quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            stock_txt.Focus()
            Exit Sub
        End If

        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            'TextBox1.Text = pid_txt.Text
            ' FillCombo()

            insert()
            getdata()
            in_getdata()
            Label25.Text = "'" & pid_txt.Text & "' inventry details saved successfully!"
            Label25.ForeColor = System.Drawing.Color.DarkGreen

        Catch ex As Exception
            Label25.Text = "Error while saving '" & pid_txt.Text & "' inventry details"
            Label25.ForeColor = System.Drawing.Color.Red
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            'MessageBox.Show("Data already exist, you again select Ticket Details and Try other entry", "Data Invalid, Application is closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try


    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub

    Private Sub btnupdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdte.Click
        edit()
        getdata()
        in_getdata()

    End Sub

 


    Private Sub Btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndel.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If Not get_stockdata.CurrentRow.IsNewRow Then
                'Query string
                dbaccessconnection()
                con.Open()
                cmd.CommandText = "delete from tbl_inventrry  where Entryno='" & get_stockdata.CurrentRow.Cells(0).Value & "'"
                cmd.ExecuteNonQuery()
                get_stockdata.Rows.Remove(get_stockdata.CurrentRow)
                MessageBox.Show("Record Deleted")
                Label25.Text = "Inventory details deleted successfully!"
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Try
            source2.Filter = "[Stock_Status] = '" & serchstock_txt.Text & "'"
            get_stockdata.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error while searching,try again" & ex.Message)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DeleteSelecedRows()
    End Sub
    Private Sub clear()
        Try
            pid_txt.Text = ""
            stock_txt.Text = ""
            ' inventrydtetxt.Text = ""

            '  photo.Image = Nothing

        Catch ex As Exception
            MsgBox("Error:Some thing is going wrong,Close application and try again")
        End Try
    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        clear()
        txtboxid()
        autogenerated()
        svemem.Enabled = True
    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub pid_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pid_txt.SelectedIndexChanged

        'SELECT m_name from tbl_memberreg
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_products where P_id = '" & pid_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try

            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                quantity_txt.Text = dbr.GetValue(5)
                'pid_txt.Text = dbr.GetValue(7)
                inpudte_txt.Text = dbr.GetValue(7)
                inname_txt.Text = dbr.GetValue(2)
                inprice_txt.Text = dbr.GetValue(3)
                inquatity_txt.Text = dbr.GetValue(6)
                intxt_des.Text = dbr.GetValue(8)

            End If
            checkstock()
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

   

   
    Private Sub get_productdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub

    


    Private Sub DeleteSelecedRows()
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

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DeleteSelecedRows()
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click
        in_getdata()
    End Sub

    Private Sub get_stockdata_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    End Sub

    Private Sub get_indata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_indata.CellContentClick
        TabControl1.SelectedTab = TabPage1

        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub

    Private Sub get_indata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_indata.CellMouseClick

        Try
            Me.inventid_txt.Text = get_indata.CurrentRow.Cells(0).Value.ToString
            Me.in_id_txt.Text = get_indata.CurrentRow.Cells(1).Value.ToString
            Me.pid_txt.Text = get_indata.CurrentRow.Cells(2).Value.ToString
            Me.inname_txt.Text = get_indata.CurrentRow.Cells(3).Value.ToString
            Me.inquatity_txt.Text = get_indata.CurrentRow.Cells(4).Value.ToString
            Me.stock_txt.Text = get_indata.CurrentRow.Cells(5).Value.ToString
            ' Me.stock_txt.Text = get_indata.CurrentRow.Cells(6).Value.ToString
            Me.inpudte_txt.Text = get_indata.CurrentRow.Cells(6).Value.ToString
            ' Me.inpudte_txt.Text = get_indata.CurrentRow.Cells(6).Value.ToString
            ' Me.inquatity_txt.Text = get_indata.CurrentRow.Cells(7).Value.ToString
            'Me.stock_txt.Text = get_indata.CurrentRow.Cells(8).Value.ToString

            ' Me.intxt_des.Text = get_indata.CurrentRow.Cells(10).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    
    Private Sub get_stockdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_stockdata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub

 

    Private Sub get_stockdata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_stockdata.CellMouseClick
        Try

            svemem.Enabled = False
            Btndel.Enabled = True
            btnupdte.Enabled = True

            Me.inventid_txt.Text = get_stockdata.CurrentRow.Cells(0).Value.ToString
            Me.in_id_txt.Text = get_stockdata.CurrentRow.Cells(1).Value.ToString
            Me.pid_txt.Text = get_stockdata.CurrentRow.Cells(2).Value.ToString
            Me.inname_txt.Text = get_stockdata.CurrentRow.Cells(3).Value.ToString
            Me.inquatity_txt.Text = get_stockdata.CurrentRow.Cells(7).Value.ToString
            Me.stock_txt.Text = get_stockdata.CurrentRow.Cells(8).Value.ToString
            Me.inventrydtetxt.Value = get_stockdata.CurrentRow.Cells(9).Value.ToString
            Me.quantity_txt.Text = get_stockdata.CurrentRow.Cells(5).Value.ToString
            Me.inprice_txt.Text = get_stockdata.CurrentRow.Cells(4).Value.ToString
            Me.intxt_des.Text = get_stockdata.CurrentRow.Cells(10).Value.ToString
            Me.inpudte_txt.Text = get_stockdata.CurrentRow.Cells(6).Value.ToString


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
End Class