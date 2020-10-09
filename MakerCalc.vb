﻿Public Class MakerCalc

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
                    MsgBox("ERROR , división entre 0")
                    result = 0
                Else
                    result /= auxiliarValue
                End If
            Case Constants.OP_PERCENTAGE
                result = (result * auxiliarValue) / Constants.PERCENTAGE_HUNDRED_NUM
            Case Constants.OP_INVERSE
                result = Constants.ONE_NUM / result

        End Select
        Return result
    End Function

End Class
