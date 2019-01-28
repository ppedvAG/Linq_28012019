Imports SampleData_Movies
Imports SampleData_Movies.Model

Public Class Form1
    Dim mm As New MovieManager()


    Private Sub ButtonAlleAnzeigen_Click(sender As Object, e As EventArgs) Handles ButtonAll.Click
        DataGridView1.DataSource = mm.Movies
    End Sub

    Private Sub ButtonSort_Click(sender As Object, e As EventArgs) Handles ButtonSort.Click

        'linq queries
        Dim query = From m In mm.Movies
                    Order By m.PublishedDate.Month Descending, m.Director.Name, m.Revenue
                    Select m

        DataGridView1.DataSource = query.ToList()

        'DataGridView1.DataSource = (From i In mm.Movies Order By i.PublishedDate Descending).ToList

    End Sub
    Private Sub ButtonSortLamb_Click(sender As Object, e As EventArgs) Handles ButtonSortLamb.Click
        'C# DataGridView1.DataSource = mm.Movies.OrderBy(m => m.PublishedDate.Month).ToList()

        DataGridView1.DataSource = mm.Movies _
                                     .OrderByDescending(Function(m) m.PublishedDate.Month) _
                                     .ThenBy(Function(m) m.Director.Name) _
                                     .ThenBy(Function(m) m.Revenue) _
                                     .ToList()

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        If TypeOf e.Value Is Decimal Then
            e.CellStyle.Format = "c"
        End If

        Dim p = TryCast(e.Value, Person)
        If Not p Is Nothing Then
            e.Value = p.Name
        End If

        Dim ar = TryCast(e.Value, IEnumerable(Of ActorRole))
        If Not ar Is Nothing Then
            e.Value = String.Join(", ", ar.Select(Function(x) $"{x.Person.Name} ({x.RoleName})"))
        End If

    End Sub

    Private Sub ButtonWhere_Click(sender As Object, e As EventArgs) Handles ButtonWhere.Click

        Dim query = From m In mm.Movies
                    Where m.PublishedDate.Year < 1999 Or m.PublishedDate.Year > 2015
                    Order By m.Revenue
                    Select m

        DataGridView1.DataSource = query.ToList()


        DataGridView1.DataSource = mm.Movies.Where(Function(m) m.PublishedDate.Year < 1999 Or m.PublishedDate.Year > 2015) _
                                            .OrderBy(Function(m) m.Revenue) _
                                            .ToList()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim alles = New List(Of Object)

        For Each m In mm.Movies
            alles.Add(m)
        Next
        For Each c In FlowLayoutPanel1.Controls
            alles.Add(c)
        Next

        DataGridView1.DataSource = alles.OfType(Of Button).ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DataGridView1.DataSource = mm.Movies.Where(Function(m) m.Director.Movies.Count >= 2).ToList()


    End Sub

    Private Sub ButtonMosteRev_Click(sender As Object, e As EventArgs) Handles ButtonMosteRev.Click

        Dim result = mm.Movies.Where(Function(m) m.PublishedDate.Year < 1999 Or m.PublishedDate.Year > 2015).Sum(Function(x) x.Revenue)
        'Dim result = mm.Movies.Count(Function(m) m.PublishedDate.Year < 1999 Or m.PublishedDate.Year > 2015)

        MessageBox.Show($"Summe: {result:c}")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = mm.Movies.FirstOrDefault(Function(x) x.Title.ToLower().Contains("phantom"))
        If Not result Is Nothing Then
            MessageBox.Show(result.Title)
        End If
    End Sub
End Class
