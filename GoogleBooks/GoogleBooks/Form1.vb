Imports System.Net
Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim url = "https://www.googleapis.com/books/v1/volumes?q=linq"

        Using wc As New WebClient
            Dim json = wc.DownloadString(url)
            Dim br As BooksResult = JsonConvert.DeserializeObject(Of BooksResult)(json)
            DataGridView1.DataSource = br.items.Select(Function(x) x.volumeInfo).ToList()
        End Using

    End Sub
End Class
