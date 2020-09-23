Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class inventryfrm
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
    Dim cs As String = "Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True"
    Private Sub dbaccessconnection()

        Try
            con.ConnectionString = "Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True"
            cmd.Connection = con

        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub insert()
        dbaccessconnection()
        con.Open()
        cmd.CommandText = "insert into tbl_inventrry(p_id,quantity,i_dte)values('" & pid_txt.Text & "','" & quantity_txt.Text & "','" & inventrydtetxt.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub getdata()

        Dim con As New SqlConnection("Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True")
        con.Open()
        Dim da As New SqlDataAdapter("Select p_id,quantity,i_dte from tbl_inventrry ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        source2.DataSource = dt
        get_stockdata.DataSource = dt
        get_stockdata.Refresh()
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
            myConnToAccess = New SqlConnection("Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True")
            myConnToAccess.Open()
            ds = New DataSet
            tables = ds.Tables
            da = New SqlDataAdapter("SELECT p_id from tbl_products", myConnToAccess)
            da.Fill(ds, "tbl_products")
            Dim view1 As New DataView(tables(0))
            With pid_txt
                .DataSource = ds.Tables("tbl_products")
                .DisplayMember = "p_id"
                .ValueMember = "p_id"
                .SelectedIndex = -1
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.ListItems
            End With
        Catch ex As Exception
            MessageBox.Show("At least one entry", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub






    Private Sub stockfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        source1.Filter = "[pid] = '" & quantity_txt.Text & "'"
        Me.Label23.Text = Format(Now, "dd-MMM-yyyy")
        get_stockdata.Refresh()
        FillCombo()
        dbaccessconnection()
        ' getdata()

    End Sub

    Private Sub svemem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click
        insert()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub
End Class