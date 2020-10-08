Public Class Calculadora

    Dim doOperations As Boolean = False
    Dim lastButtonHas As String = Constants.UNDEFINED_OPERATION
    Dim screenValue As Double = Constants.ZERO_NUM
    Dim auxiliarValue As Double = Constants.ZERO_NUM
    Dim result As Double = Constants.ZERO_NUM
    Dim operation As String = Constants.UNDEFINED_OPERATION

    Dim calculator = New MakerCalc()


    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScreen.Text = Constants.DEFAULT_SCREEN_VALUE
    End Sub



    Private Function screenHasDefaultValue()
        Dim hasDefaultValue As Boolean = False
        Dim actualScreenValue As String = lblScreen.Text
        If (actualScreenValue.Equals(Constants.DEFAULT_SCREEN_VALUE)) Then
            hasDefaultValue = True
        End If
        Return hasDefaultValue
    End Function

    Private Sub clearScreen()
        lblScreen.Text = Constants.EMPTY_VALUE
    End Sub
    Private Sub clearOperationScreen()
        lblOperationScreen.Text = Constants.EMPTY_VALUE
    End Sub
    Private Sub resetValues()
        result = 0
        auxiliarValue = 0
        operation = Constants.UNDEFINED_OPERATION
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        addToScreen(Constants.DOT_STRING)
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click

        If auxiliarValue.ToString.Length = 1 Then
            auxiliarValue = Constants.ZERO_NUM
        ElseIf operation.Equals(Constants.HAS_EQUALS) Then
            clearScreen()
            resetValues()
            deleteLastOperationOnOperationScreen()
        Else

            auxiliarValue = removeLastValueOfDouble(auxiliarValue)
        End If

        If lastButtonHas.Equals(Constants.HAS_OPERATION) Then
            operation = Constants.UNDEFINED_OPERATION
            lastButtonHas = Constants.HAS_DELETEONE
            deleteLastOperationOnOperationScreen()

        ElseIf result.ToString.Length = 1 Then
            result = Constants.ZERO_NUM
        Else
            result = removeLastValueOfDouble(result)
        End If
        deleteLastValueMainScreen()
        deleteLastValueOperationScreen()
    End Sub
    Private Function removeLastValueOfDouble(valueToRemove)
        Return CType(valueToRemove.ToString.Remove(valueToRemove.ToString.Length - 1), Double)
    End Function


    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        clearScreen()
        clearOperationScreen()
        resetValues()
        lastButtonHas = Constants.UNDEFINED_OPERATION
    End Sub
    Private Sub numberHasPressed(sender As Object, e As EventArgs) Handles btnZero.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnOne.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click
        Dim btnNumber As Button = sender
        If lastButtonHas.Equals(Constants.UNDEFINED_OPERATION) And operation.Equals(Constants.HAS_EQUALS) Then
            deleteLastOperationOnOperationScreen()
            printValueOnScreen(btnNumber.Text)
            resetValues()
            lastButtonHas = Constants.UNDEFINED_OPERATION
        End If
        Try
            If lastButtonHas.Equals(Constants.HAS_NUMBER) Then
                auxiliarValue = CType(CType(auxiliarValue, String) & btnNumber.Text, Double)
            Else
                auxiliarValue = CType(btnNumber.Text, Double)
            End If
        Catch ex As Exception
            printValueOnScreen(Constants.MESSAGE_ERROR)
        End Try
        lastButtonHas = Constants.HAS_NUMBER
        printValueOnScreen(auxiliarValue)
        If lastButtonHas.Equals(Constants.HAS_NUMBER) = False And operation.Equals(Constants.HAS_OPERATION) Then
            deleteLastValueOperationScreen()
            updateOperationScreen(auxiliarValue)
        Else
            updateOperationScreen(btnNumber.Text)
        End If
    End Sub

    Private Sub operationPressed(sender As Object, e As EventArgs) Handles MyBase.Click, btnRoot.Click, btnRisedSquare.Click, btnPlus.Click, btnPercentage.Click, btnMultiply.Click, btnMinus.Click, btnInverse.Click, btnDivision.Click
        Dim buttonPressed As Button = sender

        If operation.Equals(Constants.HAS_EQUALS) Then operation = Constants.UNDEFINED_OPERATION

        If (lastButtonHas.Equals(Constants.HAS_NUMBER)) Then

            If operation.Equals(Constants.UNDEFINED_OPERATION) Then
                operation = buttonPressed.Tag
            End If

            If result <> Constants.ZERO_NUM Then
                result = calculator.makeOperations(operation, result, auxiliarValue)
                operation = buttonPressed.Tag
                If lastButtonHas.Equals(Constants.HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
                updateOperationScreen(operation)
                lastButtonHas = Constants.HAS_OPERATION
                auxiliarValue = Constants.ZERO_NUM
            Else
                result = auxiliarValue
                auxiliarValue = Constants.ZERO_NUM
                If lastButtonHas.Equals(Constants.HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)

                updateOperationScreen(operation)
            End If


        ElseIf (operation.Equals(Constants.UNDEFINED_OPERATION)) Then
            operation = buttonPressed.Tag
            printValueOnScreen(operation)
            updateOperationScreen(operation)
        Else
            If operation.Equals(Constants.HAS_EQUALS) Then
                operation = buttonPressed.Tag
            Else
                result = calculator.makeOperations(operation, result, auxiliarValue)
                printValueOnScreen(result)
                operation = buttonPressed.Tag
            End If

            If lastButtonHas.Equals(Constants.HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
            updateOperationScreen(operation)
            End If
        lastButtonHas = Constants.HAS_OPERATION

        printValueOnScreen(operation)


    End Sub
    Private Sub HasDoubleTapOperation(buttonPressed)
        operation = buttonPressed.Tag
        lastButtonHas = Constants.HAS_DOUBLE_TAP_OPERATION
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        result = calculator.makeOperations(operation, result, auxiliarValue)
        printValueOnScreen(result)
        updateOperationScreen(Constants.EQUALS_SIMBOL & result & Constants.SEPARATOR_SIMBOL & result)
        operation = Constants.HAS_EQUALS
        auxiliarValue = result
        lastButtonHas = Constants.UNDEFINED_OPERATION
    End Sub

    Private Sub updateOperationScreen(newValue)
        If lblOperationScreen.Text.Length >= 32 Then
            lblOperationScreen.Text = Constants.SEPARATOR_SIMBOL & result & Constants.SPACER
        End If
        If lastButtonHas.Equals(Constants.HAS_DOUBLE_TAP_OPERATION) Then
            deleteLastValueOperationScreen()
        End If
        lblOperationScreen.Text &= newValue
    End Sub

    Private Sub deleteLastValueOperationScreen()
        If lblOperationScreen.Text.EndsWith(Constants.SEPARATOR_SIMBOL) = False Then
            If lblOperationScreen.Text.Length > 1 Then
                lblOperationScreen.Text = lblOperationScreen.Text.Remove(lblOperationScreen.Text.Length - 1)
            Else
                lblOperationScreen.Text = Constants.EMPTY_VALUE
            End If
        End If
    End Sub

    Private Sub deleteLastOperationOnOperationScreen()
        Dim valueCharsToRemove() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        lblOperationScreen.Text = lblOperationScreen.Text.TrimEnd(valueCharsToRemove)
    End Sub



    Private Sub printValueOnScreen(valueToPrint)
        lblScreen.Text = CStr(valueToPrint)
    End Sub

    Private Sub addToScreen(valueToUpdate)
        If (screenHasDefaultValue()) Then clearScreen()
        Dim oldValueOnScreen As String = lblScreen.Text
        lblScreen.Text = oldValueOnScreen + valueToUpdate
    End Sub
    Private Sub deleteLastValueMainScreen()
        If lblScreen.Text.Length > 1 Then
            lblScreen.Text = lblScreen.Text.Remove(lblScreen.Text.Length - 1)
        Else
            lblScreen.Text = Constants.ZERO_NUM
        End If
    End Sub

End Class
