Public Class vistaCalculadora

    Dim modeActive As String = Constants.MODE_ESTANDAR

    Dim doOperations As Boolean = False
    Dim lastButtonHas As String = Constants.UNDEFINED_OPERATION
    Dim screenValue As Double = Constants.ZERO_NUM
    Dim auxiliarValue As Double = Constants.ZERO_NUM
    Dim result As Double = Constants.ZERO_NUM
    Dim operation As String = Constants.UNDEFINED_OPERATION

    Dim calculator = New MakerCalc(Me)

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScreen.Text = Constants.DEFAULT_SCREEN_VALUE
        lblMode.Text = Constants.MODE_ESTANDAR
        Me.Size = New Size(386, 520)
    End Sub

    Private Sub changeCalcMode()
        If modeActive.Equals(Constants.MODE_ESTANDAR) Then
            Me.Size = New Size(483, 520)
            modeActive = Constants.MODE_CIENCE
            lblMode.Text = Constants.MODE_CIENCE
        Else
            Me.Size = New Size(386, 520)
            modeActive = Constants.MODE_ESTANDAR
            lblMode.Text = Constants.MODE_ESTANDAR
        End If
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
        auxiliarValue = Constants.ZERO_NUM
        printValueOnScreen(auxiliarValue)
    End Sub
    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        clearScreen()
        clearOperationScreen()
        resetValues()
        lastButtonHas = Constants.UNDEFINED_OPERATION
    End Sub
    Private Sub numberHasPressed(sender As Object, e As EventArgs) Handles btnZero.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnOne.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click
        Dim btnNumber As Button = sender
        ' primera operación y antes se pulso equals 
        If lastButtonHas.Equals(Constants.UNDEFINED_OPERATION) And operation.Equals(Constants.HAS_EQUALS) Then
            deleteLastOperationOnOperationScreen()
            printValueOnScreen(btnNumber.Text)
            resetValues()
            lastButtonHas = Constants.UNDEFINED_OPERATION
        End If

        Try
            If lastButtonHas.Equals(Constants.HAS_NUMBER) Then
                auxiliarValue = CType(CType(auxiliarValue, String) & btnNumber.Text, Double)
            ElseIf lastButtonHas.Equals(Constants.HAS_DOT) Then
                auxiliarValue += (CType(btnNumber.Text, Double) / Constants.TEN_NUM)
                printValueOnScreen(auxiliarValue)
            Else
                auxiliarValue = CType(btnNumber.Text, Double)
            End If

        Catch exception As Exception
            printValueOnScreen(Constants.MESSAGE_ERROR)
        End Try

        If lastButtonHas.Equals(Constants.HAS_NUMBER) = False And operation.Equals(Constants.HAS_OPERATION) Then
            deleteLastValueOperationScreen()
            updateOperationScreen(auxiliarValue)
        Else
            updateOperationScreen(btnNumber.Text)
        End If

        lastButtonHas = Constants.HAS_NUMBER
        printValueOnScreen(auxiliarValue)

    End Sub
    Private Sub dot_hasPressed(sender As Object, e As EventArgs) Handles btnDot.Click
        Dim dotButton As Button = sender

        If lastButtonHas.Equals(Constants.HAS_NUMBER) Then
            Dim auxiliarString = CType(auxiliarValue, String)
            auxiliarString &= dotButton.Text
            auxiliarValue = CType(auxiliarString, Double)
            printValueOnScreen(dotButton.Text)
            updateOperationScreen(dotButton.Text)

        Else
            Try
                auxiliarValue = CType(Constants.ZERO_NUM + dotButton.Text, Double)
            Catch exception As Exception
                printValueOnScreen(Constants.MESSAGE_ERROR)
            End Try
        End If

        lastButtonHas = Constants.HAS_DOT

    End Sub

    Private Sub operationPressed(sender As Object, e As EventArgs) Handles MyBase.Click, btnPlus.Click, btnPercentage.Click, btnMultiply.Click, btnMinus.Click, btnInverse.Click, btnDivision.Click, btnUpToNum.Click, btnSquared.Click, btnFactorial.Click, btnCubed.Click
        Dim buttonPressed As Button = sender

        If operation.Equals(Constants.HAS_EQUALS) Then operation = Constants.UNDEFINED_OPERATION

        If (lastButtonHas.Equals(Constants.HAS_NUMBER)) Then

            If operation.Equals(Constants.UNDEFINED_OPERATION) Then
                operation = buttonPressed.Tag
            End If

            If result <> Constants.ZERO_NUM Then
                calculator.makeOperations(operation, result, auxiliarValue)
                operation = buttonPressed.Tag
                If lastButtonHas.Equals(Constants.HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
                updateOperationScreen(operation)
                lastButtonHas = Constants.HAS_OPERATION
                auxiliarValue = Constants.ZERO_NUM
            Else
                result = auxiliarValue
                auxiliarValue = Constants.ZERO_NUM

                If lastButtonHas.Equals(Constants.HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)

                If operation.Equals(Constants.OP_INVERSE) Then
                    deleteLastValueOperationScreen()
                    updateOperationScreen(Constants.OP_INVERSE & result)
                Else
                    updateOperationScreen(operation)
                End If

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

        If operation.Equals(Constants.OP_SQUARED) Then
            equalsOperations()
        Else
            printValueOnScreen(operation)
        End If



    End Sub
    Private Sub HasDoubleTapOperation(buttonPressed)
        operation = buttonPressed.Tag
        lastButtonHas = Constants.HAS_DOUBLE_TAP_OPERATION
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        equalsOperations()
    End Sub

    Friend Sub equalsOperations()
        calculator.makeOperations(operation, result, auxiliarValue)
        printValueOnScreen(result)
        updateOperationScreen(Constants.EQUALS_SIMBOL & result & Constants.SEPARATOR_SIMBOL & result)
        operation = Constants.HAS_EQUALS
        auxiliarValue = result
        lastButtonHas = Constants.UNDEFINED_OPERATION
    End Sub
    Friend Sub setResult(resultOperation)
        Me.result = resultOperation
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

    Private Sub btnNegativeChange_Click(sender As Object, e As EventArgs) Handles btnNegativeChange.Click
        auxiliarValue *= Constants.SIGN_CHANGER_NUM
        printValueOnScreen(auxiliarValue)
        deleteLastOperationOnOperationScreen()
        updateOperationScreen(auxiliarValue)
    End Sub

    Private Sub btnChangeMode_Click(sender As Object, e As EventArgs) Handles btnChangeMode.Click
        changeCalcMode()
    End Sub

End Class
