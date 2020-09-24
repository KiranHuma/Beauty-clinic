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
        cmd.CommandText = "insert into tbl_reservation(ra_id,r_id,m_id,r_date)values('" & resid_txt.Text & "','" & rid_txt.Text & "','" & mid_txt.Text & "','" & dte_txt.Value & "')"
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub


    Private Sub getdata()

        Dim con As New SqlConnection(cs)
        con.Open()
        Dim da As New SqlDataAdapter("Select ra_id,r_id,m_id,r_date from tbl_reservation ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        source2.DataSource = dt
        get_ratedata.DataSource = dt
        get_ratedata.Refresh()
    End Sub
    Private Sub reservationfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbaccessconnection()
        getdata()
        txtboxid()
    End Sub

    Private Sub svemem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click
        insert()
    End Sub

    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(ra_id) FROM tbl_reservation"
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                resid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                resid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    
    Private Sub clear()
        Try

            rid_txt.Text = ""
            mid_txt.Text = ""
            

        Catch ex As Exception
            MsgBox("Error:Some thing is going wrong,Close application and try again")
        End Try
    End Sub
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Clear()
        txtboxid()

    End Sub
    Private Sub edit()
        Try

            dbaccessconnection()
            con.Open()
            If resid_txt.Text = "" Then
                MessageBox.Show("Empty type box")
                TabControl1.SelectedTab = TabPage2
            Else
                'insert into tbl_reservation(ra_id,r_id,m_id,r_date)values('" & resid_txt.Text & "','" & rid_txt.Text & "','" & mid_txt.Text & "','" & dte_txt.Value & "')"
                cmd.CommandText = ("UPDATE tbl_reservation SET  ra_id= '" & resid_txt.Text & "', r_id= '" & rid_txt.Text & "',m_id= '" & mid_txt.Text & "',r_date= '" & dte_txt.Value & "' where ra_id=" & resid_txt.Text & "")

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

    Private Sub get_ratedata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles get_ratedata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub

    Private Sub get_ratedata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles get_ratedata.CellMouseClick
        Try
          
            Btndel.Enabled = True
            btnupdte.Enabled = True
            Me.resid_txt.Text = get_ratedata.CurrentRow.Cells(0).Value.ToString
            Me.rid_txt.Text = get_ratedata.CurrentRow.Cells(1).Value.ToString
            Me.mid_txt.Text = get_ratedata.CurrentRow.Cells(2).Value.ToString
            Me.dte_txt.Value = get_ratedata.CurrentRow.Cells(3).Value.ToString
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        For i = Me.get_ratedata.SelectedRows.Count - 1 To 0 Step -1
            ObjCommand.CommandText = "delete from tbl_reservation where ra_id='" & get_ratedata.SelectedRows(i).Cells("ra_id").Value & "'"
            ObjConnection.Open()
            ObjCommand.ExecuteNonQuery()
            ObjConnection.Close()
            Me.get_ratedata.Rows.Remove(Me.get_ratedata.SelectedRows(i))
        Next

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DeleteSelecedRows()
    End Sub
End Class