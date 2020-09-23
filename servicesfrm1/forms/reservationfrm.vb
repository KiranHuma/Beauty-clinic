Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class reservationfrm
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
        cmd.CommandText = "insert into tbl_reservation(r_id,m_id,r_date)values('" & rid_txt.Text & "','" & mid_txt.Text & "','" & dte_txt.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub getdata()

        Dim con As New SqlConnection("Data Source=ADMINRG-FFQIQKT;Initial Catalog=mainclinicdb;Integrated Security=True")
        con.Open()
        Dim da As New SqlDataAdapter("Select r_id,m_id,r_date from tbl_reservation ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        source2.DataSource = dt
        get_ratedata.DataSource = dt
        get_ratedata.Refresh()
    End Sub
    Private Sub reservationfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbaccessconnection()
        getdata()
    End Sub

    Private Sub svemem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click
        insert()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub
End Class