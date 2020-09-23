Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

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
    Dim cs As String = "Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True"  'connection string to connect with sql server
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
    'insert values in sqlserver
    Private Sub insert()
            Try
                con.ConnectionString = cs
                cmd.Connection = con
                con.Open()
            cmd.CommandText = "insert into tbl_inventrry(In_ID,p_id,quantity,i_dte)values('" & inventid_txt.Text & "','" & pid_txt.Text & "','" & quantity_txt.Text & "','" & inventrydtetxt.Value & "')"
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception

                MsgBox("DataBase not connected due to the reason because " & ex.Message)

            End Try

    End Sub
    'edit function
    Private Sub edit()
        dbaccessconnection()
        If pid_txt.Text = "" Then
            MessageBox.Show("Empty Id")
            TabControl1.SelectedTab = TabPage2
        Else
            Dim command As New SqlCommand("UPDATE tbl_inventrry SET In_ID=@iid, p_id = @pid , quantity = @quantity ,i_dte = @inventrydtetxt WHERE In_ID = @iid", con)
            command.Parameters.Add("@iid", SqlDbType.Int).Value = inventid_txt.Text
            command.Parameters.Add("@pid", SqlDbType.NVarChar).Value = pid_txt.Text
            command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = quantity_txt.Text
            command.Parameters.Add("@inventrydtetxt", SqlDbType.DateTime).Value = inventrydtetxt.Text

            con.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Updated")
                Label25.Text = "Inventory details updated successfully!"
            Else
                MessageBox.Show("Data Not Updated")
            End If

            con.Close()

        End If
    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(In_ID) FROM tbl_inventrry "
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
    'Show data in data grid
    Private Sub getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select In_ID, p_id as[Product ID],quantity as [Quantity],i_dte [Inventory Date] from tbl_inventrry ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            get_stockdata.DataSource = dt
            get_stockdata.Refresh()
        Catch ex As Exception
            MessageBox.Show(" Error while retriving data", "Close application and try again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FillCombo()
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
        For i = Me.get_stockdata.SelectedRows.Count - 1 To 0 Step -1
            ObjCommand.CommandText = "delete from tbl_inventrry where In_ID='" & get_stockdata.SelectedRows(i).Cells("In_ID").Value & "'"
            ObjConnection.Open()
            ObjCommand.ExecuteNonQuery()
            ObjConnection.Close()
            Me.get_stockdata.Rows.Remove(Me.get_stockdata.SelectedRows(i))
        Next

    End Sub


    Private Sub stockfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbaccessconnection()
        source1.Filter = "[p_id] = '" & pid_txt.Text & "'"
        Me.Label23.Text = Format(Now, "dd-MMM-yyyy")
        FillCombo()
        get_stockdata.Refresh()
        txtboxid()

        getdata()

    End Sub

    Private Sub svemem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click

        If Len(Trim(pid_txt.Text)) = 0 Then
            MessageBox.Show("Please select Product ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pid_txt.Focus()
            Exit Sub
        End If
        If Len(Trim(quantity_txt.Text)) = 0 Then
            MessageBox.Show("Please enter quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            quantity_txt.Focus()
            Exit Sub
        End If
       
        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            FillCombo()
            insert()
            getdata()
            txtboxid()
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
            Me.pid_txt.Text = get_stockdata.CurrentRow.Cells(1).Value.ToString
            Me.quantity_txt.Text = get_stockdata.CurrentRow.Cells(2).Value.ToString
            Me.inventrydtetxt.Value = get_stockdata.CurrentRow.Cells(3).Value.ToString

            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndel.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            If Not get_stockdata.CurrentRow.IsNewRow Then
                'Query string
                dbaccessconnection()
                con.Open()
                cmd.CommandText = "delete from tbl_inventrry  where In_ID='" & get_stockdata.CurrentRow.Cells(0).Value & "'"
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
            source2.Filter = "[quantity] = '" & serchstock_txt.Text & "'"
            get_stockdata.Refresh()
            serchstock_txt.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error while searching,try again", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Dispose()
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DeleteSelecedRows()
    End Sub
End Class