Imports ExcelDataReader
Imports System.IO

Public Class Form1
    Dim tables As DataTableCollection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = ofd.FileName
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = True}})
                        tables = result.Tables
                        cmbSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cmbSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub cmbSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSheet.SelectedValueChanged
        Dim dt As DataTable = tables(cmbSheet.SelectedItem.ToString())
        DataGridView1.DataSource = dt
        If dt IsNot Nothing Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Data Saved", MsgBoxStyle.Information)
        Call Clean()
    End Sub

    Sub Clean()
        txtFileName.Clear()
        btnSave.Enabled = False
    End Sub

End Class
