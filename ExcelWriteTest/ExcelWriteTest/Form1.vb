Imports System.IO
Imports OfficeOpenXml

Public Class Form1
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim folderBrowserDialog As New FolderBrowserDialog()
        folderBrowserDialog.SelectedPath = "C:\"

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFolderPath As String = folderBrowserDialog.SelectedPath

            Dim fileName As String = "MyExcelFile.xlsx"
            Dim savePath As String = Path.Combine(selectedFolderPath, fileName)

            Try
                Dim fileInfo = New FileInfo(savePath)
                Using excelPackage As ExcelPackage = New ExcelPackage(fileInfo)
                    Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("Suppliers")
                    worksheet.Cells.LoadFromCollection(Of IssuingDet)(TryCast(dgvIssuing.DataSource, List(Of IssuingDet)), True)
                    excelPackage.Save()
                    MessageBox.Show("Saved")
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        'Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
        '    Try
        '        ' Set the default file name
        '        sfd.FileName = "MyExcelFile.xlsx"

        '        If sfd.ShowDialog() = DialogResult.OK Then
        '            Dim fileInfo = New FileInfo(sfd.FileName)
        '            Using excelPackage As ExcelPackage = New ExcelPackage(fileInfo)
        '                Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("Suppliers")
        '                worksheet.Cells.LoadFromCollection(Of IssuingDet)(TryCast(dgvIssuing.DataSource, List(Of IssuingDet)), True)
        '                excelPackage.Save()
        '                MessageBox.Show("Saved")
        '            End Using
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using db As LogixFMEntities = New LogixFMEntities()
            dgvIssuing.DataSource = (From IH In db.IssuingDets
                                     Where IH.numIssID = 118
                                     Select IH).ToList()
        End Using
    End Sub
End Class
