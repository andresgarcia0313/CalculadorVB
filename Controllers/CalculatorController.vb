Public Class CalculatorController
    Private ReadOnly _calculator As Calculator
    Private ReadOnly _view As ConsoleView
    Public Sub New(calculator As Calculator, view As ConsoleView)
        _calculator = calculator
        _view = view
    End Sub
    Public Sub Execute()
        Dim num1 As Integer = _view.ReadNumber("Ingrese primer valor: ")
        Dim num2 As Integer = _view.ReadNumber("Ingrese segundo valor: ")
        Dim sum As Integer = _calculator.Add(num1, num2)
        Dim product As Integer = _calculator.Multiply(num1, num2)
        _view.DisplayResults(sum, product)
    End Sub
End Class
