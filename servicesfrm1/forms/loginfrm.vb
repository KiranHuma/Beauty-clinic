Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Public Class loginfrm
    Dim rdr As SqlDataReader
    Dim colColors As Collection = New Collection
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As SqlConnection = New SqlConnection
    Dim ds As DataSet = New DataSet
    Dim da As SqlDataAdapter
    Dim tables As DataTableCollection = ds.Tables
 
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
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub


    Private Sub loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length <= 0 Then
            MessageBox.Show("Please enter Username!")
        ElseIf TextBox2.Text.Length <= 0 Then
            MessageBox.Show("Please enter Password!")
        End If
        If TextBox1.Text = "beautyclinic " Or TextBox2.Text = "clinic123" Then
            Beep()
            Beep()
            MainFrom1.ShowDialog()         
            Me.Hide()
            '  Else
            '     Label6.Visible = True
            '    Label6.Text = " Not succsessfully login "
            '    If Label6.Text = " Not succsessfully login " Then
            'dbaccessconnection()
            '  con.Open()
            '  cmd.CommandText = ("SELECT * FROM auth where login = '" & TextBox1.Text & "' And password = '" & TextBox2.Text & "'")
            '  cmd.ExecuteNonQuery()
            '  Label6.Visible = True
            '  Label6.Text = "Succsessfully login "
            '  MainFrom1.ShowDialog()
            '  con.Close()
        Else
            Label6.Visible = True
            Label6.Text = " Not succsessfully login "
        End If
        ' End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        changepaswordFrm.Show()
    End Sub
End Class