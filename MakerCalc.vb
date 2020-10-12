Public Class MakerCalc
    Dim calcForm As vistaCalculadora
    Public Sub New(calcForm)
        Me.calcForm = calcForm
    End Sub

    Public Sub makeOperations(operation, result, auxiliarValue)
        Select Case operation
            Case Constants.OP_PLUS
                result += auxiliarValue
            Case Constants.OP_MINUS
                result -= auxiliarValue
            Case Constants.OP_MULTIPLY
                result *= auxiliarValue
            Case Constants.OP_DIVISION
                If (auxiliarValue = Constants.ZERO_NUM) Then
                    MsgBox("ERROR , división entre 0")
                    result = 0
                Else
                    result /= auxiliarValue
                End If
            Case Constants.OP_PERCENTAGE
                result = (result * auxiliarValue) / Constants.PERCENTAGE_HUNDRED_NUM
            Case Constants.OP_INVERSE
                result = Constants.ONE_NUM / result
            Case Constants.OP_SQUARED
                result = Math.Pow(result, Constants.TWO_NUM)
            Case Constants.OP_CUBED
                result = Math.Pow(result, Constants.THREE_NUM)
            Case Constants.OP_ELEVATED_TO
                result = Math.Pow(result, auxiliarValue)
            Case Constants.OP_FACTORIAL
                result = makeFactorial(result)
        End Select
        calcForm.setResult(result)
    End Sub
    Private Function makeFactorial(value)
        Dim factorial As Double = 1
        For index = Constants.ONE_NUM To value
            factorial *= index
        Next index
        Return factorial
    End Function

End Class
