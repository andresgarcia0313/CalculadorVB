Public Class Program
    Public Shared Sub Main()
        Dim calculator As New Calculator()
        Dim view As New ConsoleView()
        Dim controller As New CalculatorController(calculator, view)
        controller.Execute()
        Console.ReadKey()
    End Sub
End Class
