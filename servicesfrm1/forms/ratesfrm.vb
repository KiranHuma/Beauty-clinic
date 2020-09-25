Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient


Public Class ratesfrm


    Private bitmap As Bitmap 'for print grid
    Dim rdr As SqlDataReader
    Dim colColors As Collection = New Collection 'for color of listbox
    Dim provider As String  'for access and sql same
    Dim dataFile As String  'for access and sql same
    Dim connString As String   'for access and sql same
    ' Dim myConnection As OleDbConnection = New OleDbConnection   'for access replace it  Dim myConnection As SqlConnection = New SqlConnection
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet            'for access and sql same
    ' Dim da As OleDbDataAdapter                'for access replace it with Dim da As SqlDataAdapter
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables  'for access and sql same
    Dim source1 As New BindingSource()                    'for access and sql same
    Dim source2 As New BindingSource()
    Dim con As New SqlClient.SqlConnection                      'for sql
    Dim cmd As New SqlClient.SqlCommand                        'for sql

    Dim dt As New DataTable
    Dim cs As String = "Data Source=GEO;Initial Catalog=mainclinicdb;Integrated Security=True"
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
        dbaccessconnection()
        con.Open()
        cmd.CommandText = "insert into tbl_rates(r_id,ra_type,ra_price,ra_promo,ra_id,ra_des)values('" & rid_txt.Text & "','" & type_txt.Text & "','" & price_txt.Text & "','" & prom_txt.Text & "','" & ratid_txt.Text & "','" & des_txt.Text & "')"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub getdata()

        Dim con As New SqlConnection(cs)
        con.Open()
        Dim da As New SqlDataAdapter("Select r_id,ra_type,ra_price,ra_promo,ra_id,ra_des from tbl_rates ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        source2.DataSource = dt
        get_ratesdata.DataSource = dt
        get_ratesdata.Refresh()
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
        For i = Me.get_ratesdata.SelectedRows.Count - 1 To 0 Step -1
            ObjCommand.CommandText = "delete from tbl_rates where r_id='" & get_ratesdata.SelectedRows(i).Cells("r_id").Value & "'"
            ObjConnection.Open()
            ObjCommand.ExecuteNonQuery()
            ObjConnection.Close()
            Me.get_ratesdata.Rows.Remove(Me.get_ratesdata.SelectedRows(i))
        Next

    End Sub
    Private Sub FillCombo()
        Try
            'Dim myConnToAccess As OleDbConnection
            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet
            ' Dim da As OleDbDataAdapter
            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection
            ' myConnToAccess = New OleDbConnection("provider=Microsoft.ACE.Oledb.12.0;Data Source=airline.accdb")
            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT r_id from tbl_reservation", myConnToAccess)
            da.Fill(ds, "tbl_reservation")
            Dim view1 As New DataView(tables(0))
            With ratid_txt
                .DataSource = ds.Tables("tbl_reservation")
                .DisplayMember = "r_id"
                .ValueMember = "r_id"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
 
    Private Sub ratesfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        source1.Filter = "[r_id] = '" & prom_txt.Text & "'"
        FillCombo()
        get_ratesdata.Refresh()
        FillCombo()
        dbaccessconnection()
        getdata()
        txtboxid()

    End Sub

    Private Sub svemem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        insert()
    End Sub
    Private Sub clear()
        Try

            type_txt.Text = ""
            price_txt.Text = ""
            des_txt.Text = ""
            prom_txt.Text = ""
            ' p_dtetxt.Value = ""


        Catch ex As Exception
            MsgBox("Error:Some thing is going wrong,Close application and try again")
        End Try
    End Sub
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(r_id) FROM tbl_rates "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                rid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                rid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Clear()
        txtboxid()
        FillCombo()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(type_txt.Text)) = 0 Then
            MessageBox.Show("Please select Rates Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            type_txt.Focus()
            Exit Sub
        End If
        If Len(Trim(price_txt.Text)) = 0 Then
            MessageBox.Show("Please enter Price", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            price_txt.Focus()
            Exit Sub
        End If

        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            insert()
            getdata()
            Label25.Text = "'" & type_txt.Text & "' rates details saved successfully!"
            Label25.ForeColor = System.Drawing.Color.DarkGreen

        Catch ex As Exception
            Label25.Text = "Error while saving '" & type_txt.Text & "' rates details"
            Label25.ForeColor = System.Drawing.Color.Red
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            'MessageBox.Show("Data already exist, you again select Ticket Details and Try other entry", "Data Invalid, Application is closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub edit()
        Try

            dbaccessconnection()
            con.Open()
            If type_txt.Text = "" Then
                MessageBox.Show("Empty type box")
                TabControl1.SelectedTab = TabPage2
            Else

                cmd.CommandText = ("UPDATE tbl_rates SET  r_id= '" & rid_txt.Text & "', ra_type= '" & type_txt.Text & "',ra_price= '" & price_txt.Text & "',ra_promo= '" & prom_txt.Text & "',ra_id= '" & ratid_txt.Text & "',ra_des= '" & des_txt.Text & "' where r_id=" & rid_txt.Text & "")

                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Updated")
                Label25.Text = "Product details updated successfully!"
                con.Close()

            End If
        Catch ex As Exception
            MessageBox.Show("Data Not Updated")
        End Try
    End Sub
    Private Sub btnupdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdte.Click
        edit()
        getdata()
    End Sub

    Private Sub Btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndel.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub get_ratesdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_ratesdata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub

    Private Sub get_ratesdata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_ratesdata.CellMouseClick
        Try
            ' "insert into tbl_rates(r_id,ra_type,ra_price,ra_promo,ra_id,ra_des)values('" & rid_txt.Text & "','" & type_txt.Text & "','" & price_txt.Text & "','" & prom_txt.Text & "','" & ratid_txt.Text & "','" & des_txt.Text & "')"
            svemem.Enabled = False
            Btndel.Enabled = True
            btnupdte.Enabled = True
            Me.rid_txt.Text = get_ratesdata.CurrentRow.Cells(0).Value.ToString
            Me.type_txt.Text = get_ratesdata.CurrentRow.Cells(1).Value.ToString
            Me.price_txt.Text = get_ratesdata.CurrentRow.Cells(2).Value.ToString
            Me.prom_txt.Text = get_ratesdata.CurrentRow.Cells(3).Value.ToString
            Me.ratid_txt.Text = get_ratesdata.CurrentRow.Cells(4).Value.ToString
            Me.des_txt.Text = get_ratesdata.CurrentRow.Cells(5).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DeleteSelecedRows()
    End Sub
End Class