Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class changepaswordFrm
    Private bitmap As Bitmap 'for print grid
    Dim rdr As SqlDataReader
    Dim colColors As Collection = New Collection
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
    Dim cs As String = "Data Source=GEO;Initial Catalog=mainclinicdb;Integrated Security=True"
    'Database Connection
    Private Sub dbaccessconnection()

        Try
            con.ConnectionString = cs
            cmd.Connection = con
        Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        dbaccessconnection()
        con.Open()

        Try
            If TextBox1.Text = "clinic123" Then
                cmd.CommandText = "Update auth SET adminuser = '1',password = '" & TextBox2.Text & "' where adminuser = '1'"
                cmd.ExecuteNonQuery()
                con.Close()
                Label3.Visible = True
                Label3.Text = "Password Change"
            Else
                Label3.Visible = True
                Label3.Text = "Password Not Match"
                Me.Dispose()
            End If
            Catch ex As Exception
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Label3.Text = "Password Not Match"
        End Try



    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub

    Private Sub changepaswordFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class