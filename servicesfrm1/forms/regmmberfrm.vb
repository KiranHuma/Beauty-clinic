﻿Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class regmmberfrm
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
    'insert Function
    Private Sub insert()
        Try
            dbaccessconnection()
            con.Open()
            cmd.CommandText = "insert into tbl_memberreg(mid,M_ID,m_name,m_contactinfo,m_age,m_address,m_dte)values('" & mid_txt.Text & "','" & midtxt.Text & "','" & nametxt.Text & "','" & cntcttxt.Text & "','" & agetxt.Text & "','" & addresstxt.Text & "','" & m_dtetxt.Value & "')"
            cmd.ExecuteNonQuery()
            con.Close()
         Catch ex As Exception
            MsgBox("Data Inserted Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'edit function
    Private Sub edit()
        Try
            dbaccessconnection()
            con.Open()
            If nametxt.Text = "" Then
                MessageBox.Show("Empty Name")
                TabControl1.SelectedTab = TabPage2
            Else
                cmd.CommandText = ("UPDATE tbl_memberreg SET  mid= '" & mid_txt.Text & "', M_ID= '" & midtxt.Text & "',m_name= '" & nametxt.Text & "',m_contactinfo= '" & cntcttxt.Text & "',m_age= '" & agetxt.Text & "',m_address= '" & addresstxt.Text & "',m_dte= '" & m_dtetxt.Value & "' where mid=" & mid_txt.Text & "")
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Updated")
                welcomemsg.Text = "Members details updated successfully!"
                memberdata.Refresh()
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Data Not Updated")
            welcomemsg.ForeColor = System.Drawing.Color.Red
            Me.Dispose()
        End Try
    End Sub
    'Delete function
    Private Sub DeleteSelecedRows()
        Try
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
            For i = Me.memberdata.SelectedRows.Count - 1 To 0 Step -1
                ObjCommand.CommandText = "delete from tbl_memberreg where mid='" & memberdata.SelectedRows(i).Cells("mid").Value & "'"
                ObjConnection.Open()
                ObjCommand.ExecuteNonQuery()
                ObjConnection.Close()
                Me.memberdata.Rows.Remove(Me.memberdata.SelectedRows(i))
            Next
        Catch ex As Exception
            MessageBox.Show("Failed:Deleting Selected Values" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'auto increment the entry id
    Private Sub txtboxid()
        Try
            dbaccessconnection()
            con.Open()
            Dim num As New Integer
            cmd.CommandText = "SELECT MAX(mid) FROM tbl_memberreg "
            If (IsDBNull(cmd.ExecuteScalar)) Then
                num = 1
                mid_txt.Text = num.ToString
            Else

                num = cmd.ExecuteScalar + 1
                mid_txt.Text = num.ToString
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Failed:Autoincrement of Members Entry" & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'auto increment alphanumeric id
    Private Sub autogenerated()
        Try
            Dim curValue As Integer
            Dim result As String
            Using con As SqlConnection = New SqlConnection(cs)
                con.Open()
                Dim cmd = New SqlCommand("select Max(M_ID) from tbl_memberreg", con)
                result = cmd.ExecuteScalar().ToString()
                If String.IsNullOrEmpty(result) Then
                    result = "MEM-0000"
                End If

                result = result.Substring(3)
                Int32.TryParse(result, curValue)
                curValue = curValue + 1
                result = "MEM" + curValue.ToString("D4")
                midtxt.Text = result
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed:AutoIncrement of MemberID" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Show data of products in grid

    Private Sub getdata()
        Try
            Dim con As New SqlConnection(cs)
            con.Open()
            Dim da As New SqlDataAdapter("Select mid,M_ID,m_name,m_contactinfo,m_age,m_address,m_dte from tbl_memberreg ", con)
            Dim dt As New DataTable
            da.Fill(dt)
            source2.DataSource = dt
            memberdata.DataSource = dt
            memberdata.Refresh()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'Functions on form load
    Private Sub regmmberfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getdata()
        memberdata.Refresh()
        autogenerated()
        dbaccessconnection()
        'getdata()
        txtboxid()
        Call CenterToScreen()

    End Sub
    'Empty the textboxes
    Private Sub clear()
        Try
            nametxt.Text = ""
            cntcttxt.Text = ""
            agetxt.Text = ""
            addresstxt.Text = ""
        Catch ex As Exception
            MsgBox("Failed:Clear " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
   
    '>>>>>>>>>>>>>>>>>>>>>Buttons<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    'Save Button
    Private Sub svemem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svemem.Click
        If Len(Trim(nametxt.Text)) = 0 Then
            MessageBox.Show("Please Enter Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            nametxt.Focus()
            Exit Sub
        End If
        Try
            MessageBox.Show("Are you sure to add data", "Data Adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            insert()
            getdata()
            memberdata.Refresh()
            welcomemsg.Text = "'" & nametxt.Text & "' members details saved successfully!"
            welcomemsg.ForeColor = System.Drawing.Color.DarkGreen

        Catch ex As Exception
            welcomemsg.Text = "Error while saving '" & nametxt.Text & "' members details"
            welcomemsg.ForeColor = System.Drawing.Color.Red
            MsgBox("DataBase not connected due to the reason because " & ex.Message)
            Me.Dispose()
        End Try

    End Sub
    'edit Button
    Private Sub btnupdte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdte.Click
        edit()
        getdata()
        memberdata.Refresh()
        btnupdte.Enabled = False
    End Sub
    'Close Button
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub
    ' delete Button
    Private Sub Btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndel.Click
        TabControl1.SelectedTab = TabPage2
    End Sub
    'delete button on grid
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DeleteSelecedRows()
    End Sub
    'Add Button
    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Clear()
        txtboxid()
        autogenerated()
        memberdata.Refresh()
        svemem.Enabled = True
        btnupdte.Enabled = False
    End Sub
    'report button
    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
    'click on text of grid
    Private Sub memberdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles memberdata.CellContentClick
        TabControl1.SelectedTab = TabPage1
        svemem.Enabled = False
        Btndel.Enabled = True
        btnupdte.Enabled = True
    End Sub
    'mouseclick in grid
    Private Sub memberdata_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles memberdata.CellMouseClick
        Try
            svemem.Enabled = False
            Btndel.Enabled = True
            btnupdte.Enabled = True
            Me.mid_txt.Text = memberdata.CurrentRow.Cells(0).Value.ToString
            Me.midtxt.Text = memberdata.CurrentRow.Cells(1).Value.ToString
            Me.nametxt.Text = memberdata.CurrentRow.Cells(2).Value.ToString
            Me.cntcttxt.Text = memberdata.CurrentRow.Cells(3).Value.ToString
            Me.agetxt.Text = memberdata.CurrentRow.Cells(4).Value.ToString
            Me.addresstxt.Text = memberdata.CurrentRow.Cells(5).Value.ToString
            Me.m_dtetxt.Value = memberdata.CurrentRow.Cells(6).Value.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub agetxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles agetxt.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

   
    Private Sub Label7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        If btnupdte.Enabled = False Then
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Select the field from Grid to Edit")
        Else
            ToolTip1.IsBalloon = True
            ToolTip1.UseAnimation = True
            ToolTip1.ToolTipTitle = ""
            ToolTip1.SetToolTip(Label7, "Click to Edit")
        End If
    End Sub
    'search by date
    Private Sub member_searchdate()
        con.Close()
        Try
            ' Dim cn As New SqlConnection
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dfrom As DateTime = DateTimePicker1.Value
            Dim dto As DateTime = DateTimePicker2.Value
            myConnection.ConnectionString = cs
            myConnection.Open()
            Dim str As String = "Select * from tbl_memberreg where m_dte >= '" & Format(dfrom, "MM-dd-yyyy") & "' and m_dte <='" & Format(dto, "MM-dd-yyyy") & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(str, myConnection)
            da.Fill(dt)
            memberdata.DataSource = dt
            myConnection.Close()
            memberdata.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Date Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        member_searchdate()
        RadioButton1.Checked = False
    End Sub
    'search member name in grid
    Private Sub search_txt()
        Dim str As String
        Try
            con.Open()
            str = "Select * from tbl_memberreg where m_name like '" & TextBox3.Text & "%'"
            cmd = New SqlCommand(str, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "tbl_memberreg")
            con.Close()
            memberdata.DataSource = ds
            memberdata.DataMember = "tbl_memberreg"
            memberdata.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Failed:Member Name Search", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End Try
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        search_txt()
    End Sub

    Private Sub Button6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseHover
        ToolTip1.IsBalloon = True
        ToolTip1.UseAnimation = True
        ToolTip1.ToolTipTitle = ""
        ToolTip1.SetToolTip(Button6, "Select the one field or more from Grid to Remove")
    End Sub

  
    
    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getmembrdata.Show()
    End Sub
End Class