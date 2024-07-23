Public Class ConsoleView
    Public Function ReadNumber(prompt As String) As Integer
        Console.Write(prompt)
        Return Convert.ToInt32(Console.ReadLine())
    End Function
    Public Sub DisplayResults(sum As Integer, product As Integer)
        Console.WriteLine("La suma de los dos valores es: " & sum)
        Console.WriteLine("El producto de los dos valores es: " & product)
    End Sub
End Class
