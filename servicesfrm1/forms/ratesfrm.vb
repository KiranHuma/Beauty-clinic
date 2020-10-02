﻿Imports System.Data
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
 


  
   
   
 
    Private Sub ratesfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pay_txtboxid()
        Membr_FillCombo()
        product_FillCombo()
        ' service_FillCombo()
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
   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        total_discount()
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

            Dim myConnToAccess As SqlConnection
            Dim ds As DataSet

            Dim da As SqlDataAdapter
            Dim tables As DataTableCollection

            myConnToAccess = New SqlConnection(cs)
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT Product_name from tbl_inventrry", myConnToAccess)
            da.Fill(ds, "tbl_inventrry")
            Dim view1 As New DataView(tables(0))
            With pname_txt
                .DataSource = ds.Tables("tbl_inventrry")
                .DisplayMember = "Product_name"
                .ValueMember = "Product_name"
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
        Dim query As String = "select * from tbl_inventrry where Product_name = '" & pname_txt.Text & "' "
        Dim cmd As SqlCommand = New SqlCommand(query, con)
        Dim dbr As SqlDataReader
        Try

            con.Open()
            dbr = cmd.ExecuteReader()
            If dbr.Read() Then

                pid_txt.Text = dbr.GetValue(2)
                Label24.Text = dbr.GetValue(4)
                unitprce_txt.Text = dbr.GetValue(8)

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

    Private Sub subtruct_stock()



        Dim subb As Int64

        subb = Convert.ToInt64(Label24.Text) - Convert.ToInt64(pquantity_txt.Text)
        Label24.Text = Convert.ToString(subb)


    End Sub
    Private Sub proupdate_stockout_in()
        Try

            dbaccessconnection()
            con.Open()

           
            cmd.CommandText = ("UPDATE tbl_products SET p_totalquantity= '" & Label24.Text & "' where P_id='" & pid_txt.Text & "'")
            cmd.ExecuteNonQuery()

            message_txt.Text = "Product details updated successfully!"
            con.Close()


        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub
    Private Sub quantitystockout_in()
        Try

            dbaccessconnection()
            con.Open()
            

            cmd.CommandText = ("UPDATE tbl_inventrry SET Totalquantity= '" & Label24.Text & "',Stock_outdate= '" & p_date_txt.Value & "' where Pro_id='" & pid_txt.Text & "'")

            cmd.ExecuteNonQuery()

            message_txt.Text = "Product details updated successfully!"
                con.Close()

            proupdate_stockout_in()
        Catch ex As Exception
            MessageBox.Show("Data Not Updated" & ex.Message)
        End Try
    End Sub
  
 
    Private Sub update_inbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        p_discount()
        ' quantitystockout_in()

        ' p_discount()
    End Sub


    Private Sub p_billafter_distxt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles p_billafter_distxt.Click
        pro_pricetotal()
    End Sub

    'discount function
    Private Sub total_discount()
        Dim PercentageNumberResult As Double
        PercentageNumberResult = totalbill_txt.Text / 100 * discount_txt.Text
        TextBox5.Text = PercentageNumberResult
        Dim subtractdiscount As Double
        subtractdiscount = totalbill_txt.Text - TextBox5.Text
        totalbillafterdis_txt.Text = subtractdiscount
    End Sub
   
    Private Sub p_discount()
        Dim PercentageNumberResult As Double
        PercentageNumberResult = uinttotalprice_txt.Text / 100 * p_discnt_txt.Text
        TextBox5.Text = PercentageNumberResult
        Dim subtractdiscount As Double
        subtractdiscount = uinttotalprice_txt.Text - TextBox5.Text
        p_billafter_distxt.Text = subtractdiscount

    End Sub
    Private Sub pro_pricetotal()
        Dim addd As Double
        addd = Double.Parse(p_billafter_distxt.Text) + Double.Parse(totalitemsbill.Text)
        totalitemsbill.Text = (addd)
    End Sub
   
    Private Sub p_pricetotal()

        Dim mul As Int64
        Dim addd As Int64
        mul = Convert.ToInt64(pquantity_txt.Text) * Convert.ToInt64(unitprce_txt.Text)
        pprice_txt.Text = Convert.ToString(mul)
        addd = Convert.ToInt64(pprice_txt.Text) + Convert.ToInt64(uinttotalprice_txt.Text)
        uinttotalprice_txt.Text = Convert.ToString(addd)

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
    Private Sub p_nameadd()
        RichTextBox1.Text &= "Name" & ":" & pname_txt.Text & "," & "Price" & ":" + unitprce_txt.Text & "," & "Discount" & ":" + pr_single_dis.Text & "," & "Bill" & ":" + single_dis_txt.Text & vbNewLine
    End Sub
    'single item total
    Private Sub prosingle_pricetotal()
        Dim addd As Double
        addd = Double.Parse(single_dis_txt.Text) + Double.Parse(pro_single_totalbill.Text)
        pro_single_totalbill.Text = (addd)
    End Sub
    Private Sub prosingle_discount()
        Dim PercentageNumberResult As Double
        PercentageNumberResult = pprice_txt.Text / 100 * pr_single_dis.Text
        TextBox5.Text = PercentageNumberResult
        Dim subtractdiscount As Double
        subtractdiscount = pprice_txt.Text - TextBox5.Text
        single_dis_txt.Text = subtractdiscount
    End Sub
    Private Sub check_stockstatus()
        If Label24.Text < 0 Then
            Button1.Enabled = False
            Label14.Text = "NO Stock avaliable"
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
           
           
            If Label24.Text <= 0 Then
                Button1.Enabled = False
                Label14.Text = "NO Stock avaliable"
            Else
                If pquantity_txt.Text = "" Then
                    MsgBox("Enter quantity ")
                Else
                    subtruct_stock()
                    p_pricetotal()
                    prosingle_discount()
                    prosingle_pricetotal()
                    quantitystockout_in()
                    p_nameadd()
                End If
            End If
        Catch ex As Exception
            ' Label25.Text = "Error while saving '" & type_txt.Text & "' rates details"
            'Label25.ForeColor = System.Drawing.Color.Red
            MsgBox("Error " & ex.Message)
            'MessageBox.Show("Data already exist, you again select Ticket Details and Try other entry", "Data Invalid, Application is closing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        p_pricetotal()
        p_discount()
        'quantitystockout_in()
        prosingle_discount()
        'p_nameadd()
        pro_pricetotal()
    End Sub

    Private Sub single_dis_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles single_dis_txt.TextChanged

    End Sub
End Class
'