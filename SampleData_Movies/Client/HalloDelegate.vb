
Public Delegate Sub EinfacherMethodeDelegate()
Public Delegate Sub SubMitParaDelegate(txt As String)
Public Delegate Function CalcDelegate(a As Integer, b As Integer) As Long

Public Class HalloDelegate

    Sub New()
        Dim meineSub As EinfacherMethodeDelegate = AddressOf EinfacheMethode
        Dim meinSubAsAction As Action = AddressOf EinfacheMethode
        Dim meinSubAsActionAno As Action = Sub()
                                               MessageBox.Show("bläää")
                                           End Sub

        Dim meinSubAsActionAno2 As Action = Sub() MessageBox.Show("bläää")

        Dim subMitPara As SubMitParaDelegate = AddressOf MethodeMitPara
        Dim subMitParaAsAction As Action(Of String) = AddressOf MethodeMitPara
        Dim subMitParaAsActionAno As Action(Of String) = Sub(txt) MessageBox.Show(txt)

        Dim calc As CalcDelegate = AddressOf Sum
        Dim calcAsFunc As Func(Of Integer, Integer, Long) = AddressOf Sum
        Dim calcAno As CalcDelegate = Function(x As Integer, y As Integer)
                                          Return x + y
                                      End Function

        Dim calcAno2 As CalcDelegate = Function(x, y) x + y

        Dim texte As List(Of String) = New List(Of String)()
        Dim result = texte.Where(AddressOf Filter)

        texte.Where(Function(x) x.Contains("b"))
    End Sub

    Private Function Filter(arg As String) As Boolean
        If arg.Contains("b") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function Sum(a As Integer, b As Integer) As Long
        Return a + b
    End Function

    Private Sub MethodeMitPara(txt As String)
        MessageBox.Show($"Hallo txt")
    End Sub

    Sub EinfacheMethode()
        'nix
    End Sub

End Class
