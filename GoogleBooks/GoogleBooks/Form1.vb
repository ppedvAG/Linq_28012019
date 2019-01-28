Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports OfficeOpenXml

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim url = "https://www.googleapis.com/books/v1/volumes?q=linq"

        Using wc As New WebClient
            wc.Encoding = Encoding.UTF8
            Dim json = wc.DownloadString(url)

            Dim br As BooksResult = JsonConvert.DeserializeObject(Of BooksResult)(json)
            DataGridView1.DataSource = br.items.Select(Function(x) x.volumeInfo).ToList()
        End Using

    End Sub

    Private Sub ButtonExcel_Click(sender As Object, e As EventArgs) Handles ButtonExcel.Click

        Dim fi = New FileInfo("buch.xlsx")

        Dim pack = New ExcelPackage(fi)
        Dim ws = pack.Workbook.Worksheets.FirstOrDefault()
        If ws Is Nothing Then
            ws = pack.Workbook.Worksheets.Add("Books")
        End If

        ws.Cells(1, 1).Value = "Meine Lieblingsbücher ❤"

        Dim row = 2
        For Each vi In TryCast(DataGridView1.DataSource, IEnumerable(Of Volumeinfo))
            ws.Cells(row, 1).Value = vi.title
            ws.Cells(row, 2).Value = vi.subtitle
            ws.Cells(row, 3).Value = vi.description
            ws.Cells(row, 4).Value = vi.publishedDate
            ws.Cells(row, 5).Value = vi.pageCount
            If vi.pageCount > 500 Then
                ws.Cells(row, 5).Style.Fill.PatternType = Style.ExcelFillStyle.Solid
                ws.Cells(row, 5).Style.Fill.BackgroundColor.SetColor(Color.PeachPuff)
            End If
            row += 1
        Next

        pack.Save()

        Process.Start("buch.xlsx")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fi = New FileInfo("buch.xlsx")


        Dim pack = New ExcelPackage(fi)
        Dim ws = pack.Workbook.Worksheets.FirstOrDefault()

        Dim seiten = ws.Cells().Where(Function(x) x.Style.Fill.BackgroundColor.Rgb IsNot Nothing) _
                             .Sum(Function(x) CType(x.Value, Integer))

        MessageBox.Show($"Bunte Seiten Summe: {seiten}")

        ws.Cells().Where(Function(x) x.Style.Fill.BackgroundColor.Rgb IsNot Nothing) _
                  .ToList().ForEach(Function(x) MessageBox.Show(x.Value.ToString()))



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim tokill = New List(Of Integer)
        tokill.Add(3)
        tokill.Add(4)
        tokill.Add(5)
        tokill.Add(6)


        Dim liste = New List(Of Integer)
        For index = 1 To 10
            liste.Add(index)
        Next



        'For Each i In liste.ToList()
        '    If i > 3 AndAlso i < 8 Then
        '        liste.Remove(i)
        '    End If
        'Next

        Dim clean = liste.Except(tokill).Union(tokill)


        tokill.ForEach(Function(x) liste.Remove(x))

    End Sub
End Class
