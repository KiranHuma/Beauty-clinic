﻿

Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Data.SqlClient
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Linq
Imports Microsoft.Office.Interop


Public Class ProductsSaleExports


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
    Dim str As String
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



    Private myDS As New mainclinicdbDataSet() ' Dataset you created.
    Private Sub wordconvert()
        Dim rpt As New ProductSaleReport() 'The report you created.
        Dim myConnection As SqlConnection
        Dim MyCommand As New SqlCommand()
        Dim myDA As New SqlDataAdapter()
        Try
            myConnection = New SqlConnection(cs)
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "SELECT Transaction_ID,Member_Name,Memebr_ID,Product_Details,Product_Total_Items,ProPrice_without_Discount,ProPrice_with_Discount,Product_Remarks,Transaction_Date from tbl_productsales "
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand

            myDA.Fill(myDS, "tbl_productsales")
            rpt.SetDataSource(myDS)
            ProductSaleReportFrm.ProductSaleViewer1.ReportSource = rpt

        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cn As New SqlConnection
            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dfrom As DateTime = DateTimePicker1.Value
            Dim dto As DateTime = DateTimePicker2.Value
            cn.ConnectionString = cs
            cn.Open()
            Dim str As String = "Select Transaction_ID,Member_Name,Memebr_ID,Product_Details,Product_Total_Items,ProPrice_without_Discount,ProPrice_with_Discount,Product_Remarks,Transaction_Date from tbl_productsales  where Transaction_Date >= '" & Format(dfrom, "MM-dd-yyyy") & "' and Transaction_Date <='" & Format(dto, "MM-dd-yyyy") & "'"
            Dim da As SqlDataAdapter = New SqlDataAdapter(str, cn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        Catch ex As Exception
            MsgBox("Failed:Get Data " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DataGridView1.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve Date data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value.ToString()
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'This Code is used to Convert to word document
        Dim reportWord As New ProductSaleReport() ' Report Name 
        Dim strExportFile As String = "e:\ProductSaleReport.doc"
        reportWord.ExportOptions.ExportDestinationType = ExportDestinationType.DiskFile
        reportWord.ExportOptions.ExportFormatType = ExportFormatType.WordForWindows
        Dim objOptions As DiskFileDestinationOptions = New DiskFileDestinationOptions()
        objOptions.DiskFileName = strExportFile
        reportWord.ExportOptions.DestinationOptions = objOptions
        reportWord.SetDataSource(myDS)
        reportWord.Export()
        objOptions = Nothing
        reportWord = Nothing
        MsgBox("Please Check your E Drive.There will be a File with the Name of ProductSaleReport.Please Copy and Paste it in other folder for record otherwise it will replace when you print new one")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Cursor = Cursors.WaitCursor

            Dim rprot As New ProductSaleReport 'The report you created.
            Dim myConnection As SqlConnection
            Dim MyCommand As New SqlCommand()
            Dim myDA As New SqlDataAdapter()
            Dim myDS As New mainclinicdbDataSet 'The DataSet you created.
            myConnection = New SqlConnection(cs)
            Dim dfrom As DateTime = DateTimePicker1.Value
            Dim dto As DateTime = DateTimePicker2.Value
            MyCommand.Connection = myConnection
            MyCommand.CommandText = "select Transaction_ID,Member_Name,Memebr_ID,Product_Details,Product_Total_Items,ProPrice_without_Discount,ProPrice_with_Discount,Product_Remarks,Transaction_Date from tbl_productsales where Transaction_Date  >= '" & Format(dfrom, "MM-dd-yyyy") & "' and Transaction_Date <='" & Format(dto, "MM-dd-yyyy") & "'"
            MyCommand.CommandType = CommandType.Text
            myDA.SelectCommand = MyCommand
            myDA.Fill(myDS, "tbl_productsales")
            rprot.SetDataSource(myDS)
            ProductSaleReportFrm.ProductSaleViewer1.ReportSource = rprot
            ProductSaleReportFrm.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



   

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Dispose()
    End Sub

 
End Class