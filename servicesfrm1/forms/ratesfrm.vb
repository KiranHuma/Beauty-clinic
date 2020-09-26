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
        pay_txtboxid()
        Membr_FillCombo()
        product_FillCombo()
        service_FillCombo()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click
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
   
  
    ' for payment tab

    ' pament insert function
    Private Sub p_insert()
        dbaccessconnection()
        con.Open()
        cmd.CommandText = "insert into tbl_productsales(transactionid,mname,mbid,pname,pid,pquantity,pprice,sname,sprice,emname,tbill,discount,billafterdis,psle,pdte)values('" & transactionid_txt.Text & "','" & mname_txt.Text & "','" & mbid_txt.Text & "','" & RichTextBox1.Text & "','" & pid_txt.Text & "','" & pquantity_txt.Text & "','" & uinttotalprice_txt.Text & "','" & RichTextBox2.Text & "','" & servictotal_txt.Text & "','" & emname_txt.Text & "','" & totalbill_txt.Text & "','" & discount_txt.Text & "','" & totalbillafterdis_txt.Text & "','" & ssale_txt.Text & "','" & p_date_txt.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
   
    Private Sub pay_txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(transactionid) FROM tbl_productsales "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                transactionid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                transactionid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
   
    Private Sub p_getdata()

        Dim con As New SqlConnection(cs)
        con.Open()
        Dim da As New SqlDataAdapter("Select transactionid,mname,mbid,pname,pid,pquantity,pprice,sname,sprice,emname,tbill,discount,billafterdis,psle,pdte from tbl_productsales ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        source1.DataSource = dt
        payment_grid.DataSource = dt
        payment_grid.Refresh()
    End Sub
    'to empty textboxes
    Private Sub p_clear()
        Try


            mname_txt.Text = ""
            mbid_txt.Text = ""
            pid_txt.Text = ""
            pprice_txt.Text = ""


        Catch ex As Exception
            MsgBox("Error:Some thing is going wrong,Close application and try again")
        End Try
    End Sub
    Private Sub p_discount()
        Dim PercentageNumberResult As Double
        PercentageNumberResult = totalbill_txt.Text / 100 * discount_txt.Text
        TextBox5.Text = PercentageNumberResult
        Dim subtractdiscount As Double
        subtractdiscount = totalbill_txt.Text - TextBox5.Text
        totalbillafterdis_txt.Text = subtractdiscount
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        p_discount()
    End Sub
    Private Sub p_addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_addbtn.Click
        p_clear()
        pay_txtboxid()
        'p_autogenerated()
    End Sub

    Private Sub p_savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_savebtn.Click

        If Len(Trim(mname_txt.Text)) = 0 Then
            MessageBox.Show("Please select Member name ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            mname_txt.Focus()
            Exit Sub
        End If


        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            p_insert()
            p_getdata()
            message_txt.Text = "'" & pid_txt.Text & "' payment details saved successfully!"
            message_txt.ForeColor = System.Drawing.Color.DarkGreen

        Catch ex As Exception
            message_txt.Text = "Error while saving '" & pid_txt.Text & "' payment details"
            message_txt.ForeColor = System.Drawing.Color.Red
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            'MessageBox.Show("Data already exist, you again select Ticket Details and Try other entry", "Data Invalid, Application is closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub

    Private Sub p_editbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_editbtn.Click
        edit()
        getdata()
    End Sub

    Private Sub p_delbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p_delbtn.Click
        TabControl1.SelectedTab = TabPage4
    End Sub


    Private Sub p_pricetotal()

        Dim mul As Int64
        Dim addd As Int64
        mul = Convert.ToInt64(pquantity_txt.Text) * Convert.ToInt64(unitprce_txt.Text)
        pprice_txt.Text = Convert.ToString(mul)
        addd = Convert.ToInt64(pprice_txt.Text) + Convert.ToInt64(uinttotalprice_txt.Text)
        uinttotalprice_txt.Text = Convert.ToString(addd)

    End Sub
    Private Sub p_nameadd()


        RichTextBox1.Text &= pname_txt.Text & ","

    End Sub
    Private Sub s_pricetotal()


        Dim addd As Int64

        addd = Convert.ToInt64(sprice_txt.Text) + Convert.ToInt64(servictotal_txt.Text)
        servictotal_txt.Text = Convert.ToString(addd)

    End Sub
    Private Sub s_nameadd()


        RichTextBox2.Text &= sname_txt.Text & ","

    End Sub
    Private Sub totalbill()


        Dim addd As Int64

        addd = Convert.ToInt64(uinttotalprice_txt.Text) + Convert.ToInt64(servictotal_txt.Text)
        totalbill_txt.Text = Convert.ToString(addd)

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        p_pricetotal()
        p_nameadd()
      

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        s_pricetotal()
        s_nameadd()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        totalbill()
    End Sub


    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click
        pay_txtboxid()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        source1.Filter = "[r_id] = '" & prom_txt.Text & "'"
        FillCombo()
        get_ratesdata.Refresh()
        FillCombo()
        dbaccessconnection()
        getdata()
        txtboxid()
    End Sub

    Private Sub pquantity_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pquantity_txt.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pquantity_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pquantity_txt.TextChanged

    End Sub

   
    Private Sub Membr_FillCombo()
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
            da = New SqlDataAdapter("SELECT m_name from tbl_memberreg", myConnToAccess)
            da.Fill(ds, "tbl_memberreg")
            Dim view1 As New DataView(tables(0))
            With mname_txt
                .DataSource = ds.Tables("tbl_memberreg")
                .DisplayMember = "m_name"
                .ValueMember = "m_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub mname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mname_txt.SelectedIndexChanged
        'SELECT m_name from tbl_memberreg
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_memberreg where m_name = '" & mname_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try

            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                mbid_txt.Text = dbr.GetValue(1)
            End If
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub
    Private Sub product_FillCombo()
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
            da = New SqlDataAdapter("SELECT p_name from tbl_products", myConnToAccess)
            da.Fill(ds, "tbl_products")
            Dim view1 As New DataView(tables(0))
            With pname_txt
                .DataSource = ds.Tables("tbl_products")
                .DisplayMember = "p_name"
                .ValueMember = "p_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub pname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pname_txt.SelectedIndexChanged
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_products where p_name = '" & pname_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try

            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                pid_txt.Text = dbr.GetValue(1)
                Label24.Text = dbr.GetValue(5)
                unitprce_txt.Text = dbr.GetValue(3)
            End If
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub service_FillCombo()
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
            da = New SqlDataAdapter("SELECT s_name from tbl_services", myConnToAccess)
            da.Fill(ds, "tbl_services")
            Dim view1 As New DataView(tables(0))
            With sname_txt
                .DataSource = ds.Tables("tbl_services")
                .DisplayMember = "s_name"
                .ValueMember = "s_name"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub sname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sname_txt.SelectedIndexChanged
        Dim str As String = cs
        Dim con As SqlConnection = New SqlConnection(str)
        Dim query As String = "select * from tbl_services where s_name = '" & sname_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try

            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                sprice_txt.Text = dbr.GetValue(3)
            End If
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
'