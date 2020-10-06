Public Class MakerCalc

    Public Function makeOperations(operation, result, auxiliarValue)
        Select Case operation
            Case Constants.OP_PLUS
                result += auxiliarValue
            Case Constants.OP_MINUS
                result -= auxiliarValue
            Case Constants.OP_MULTIPLY
                result *= auxiliarValue
            Case Constants.OP_DIVISION
                If (auxiliarValue = Constants.ZERO_NUM) Then
                    MsgBox(Constants.MESSAGE_ERROR)
                    result = 0
                Else
                    result /= auxiliarValue
                End If
        End Select
        Return result
    End Function

End Class
