Public Class Calculadora
    Const DEFAULT_SCREEN_VALUE = "0,0"
    Const EMPTY_VALUE = ""
    Const SPACER = " "

    Const MESSAGE_ERROR As String = "ERROR"
    Const EQUALS_SIMBOL As String = "="
    Const SEPARATOR_SIMBOL As String = "; "
    Const UNDEFINED_OPERATION = "UNDEF"
    Const MAX_LENGHT_OPERATION_SCREEN As Integer = 32

    Const HAS_OPERATION As String = "OPERATION"
    Const HAS_DOUBLE_TAP_OPERATION As String = "DOUBLE_TAP_OPERATION"
    Const HAS_NUMBER As String = "NUMBER"
    Const HAS_EQUALS As String = "EQUALS"

    Const DOT_STRING As String = "."
    Const OP_PLUS As String = "+"
    Const OP_MINUS As String = "-"
    Const OP_MULTIPLY As String = "*"
    Const OP_DIVISION As String = "/"
    Const OP_ROOT As String = "root"
    Const OP_SQUARE As String = "square"
    Const OP_INVERSE As String = "inverse"
    Const OP_PERCENTAGE As String = "percentage"

    Const NINE_NUM As Integer = 9
    Const EIGHT_NUM As Integer = 8
    Const SEVEN_NUM As Integer = 7
    Const SIX_NUM As Integer = 6
    Const FIVE_NUM As Integer = 5
    Const FOUR_NUM As Integer = 4
    Const THREE_NUM As Integer = 3
    Const TWO_NUM As Integer = 2
    Const ONE_NUM As Integer = 1
    Const ZERO_NUM As Integer = 0

    Dim doOperations As Boolean = False
    Dim lastButtonHas As String = UNDEFINED_OPERATION
    Dim screenValue As Double = ZERO_NUM
    Dim auxiliarValue As Double = ZERO_NUM
    Dim result As Double = ZERO_NUM
    Dim operation As String = UNDEFINED_OPERATION


    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScreen.Text = DEFAULT_SCREEN_VALUE
    End Sub

    Private Sub addToScreen(valueToUpdate)
        If (screenHasDefaultValue()) Then clearScreen()
        Dim oldValueOnScreen As String = lblScreen.Text
        lblScreen.Text = oldValueOnScreen + valueToUpdate
    End Sub

    Private Function screenHasDefaultValue()
        Dim hasDefaultValue As Boolean = False
        Dim actualScreenValue As String = lblScreen.Text
        If (actualScreenValue.Equals(DEFAULT_SCREEN_VALUE)) Then
            hasDefaultValue = True
        End If
        Return hasDefaultValue
    End Function

    Private Sub clearScreen()
        lblScreen.Text = EMPTY_VALUE
    End Sub
    Private Sub clearOperationScreen()
        lblOperationScreen.Text = EMPTY_VALUE
    End Sub
    Private Sub resetValues()
        result = 0
        auxiliarValue = 0
        operation = UNDEFINED_OPERATION
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        addToScreen(DOT_STRING)
    End Sub

    Private Sub btnBackSpace_Click(sender As Object, e As EventArgs) Handles btnBackSpace.Click
        If auxiliarValue.ToString.Length = 1 Then
            auxiliarValue = ZERO_NUM
        Else
            auxiliarValue = removeLastValueOfDouble(auxiliarValue)
        End If
        If result.ToString.Length = 1 Then
            result = ZERO_NUM
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
        lastButtonHas = UNDEFINED_OPERATION
    End Sub
    Private Sub numberHasPressed(sender As Object, e As EventArgs) Handles btnZero.Click, btnTwo.Click, btnThree.Click, btnSix.Click, btnSeven.Click, btnOne.Click, btnNine.Click, btnFour.Click, btnFive.Click, btnEight.Click
        Dim btnNumber As Button = sender
        If lastButtonHas.Equals(UNDEFINED_OPERATION) And operation.Equals(HAS_EQUALS) Then
            deleteLastOperationOnOperationScreen()
            printValueOnScreen(btnNumber.Text)
            resetValues()
            lastButtonHas = UNDEFINED_OPERATION
        End If
        Try
            If lastButtonHas.Equals(HAS_NUMBER) Then
                auxiliarValue = CType(CType(auxiliarValue, String) & btnNumber.Text, Double)
            Else
                auxiliarValue = CType(btnNumber.Text, Double)
            End If
        Catch ex As Exception
            printValueOnScreen(MESSAGE_ERROR)
        End Try
        lastButtonHas = HAS_NUMBER
        printValueOnScreen(auxiliarValue)
        If lastButtonHas.Equals(HAS_NUMBER) = False And operation.Equals(HAS_OPERATION) Then
            deleteLastValueOperationScreen()
            updateOperationScreen(auxiliarValue)
        Else
            updateOperationScreen(btnNumber.Text)
        End If
    End Sub

    Private Sub operationPressed(sender As Object, e As EventArgs) Handles MyBase.Click, btnRoot.Click, btnRisedSquare.Click, btnPlus.Click, btnPercentage.Click, btnMultiply.Click, btnMinus.Click, btnInverse.Click, btnDivision.Click
        Dim buttonPressed As Button = sender
        If operation.Equals(HAS_EQUALS) Then operation = UNDEFINED_OPERATION
        If (lastButtonHas.Equals(HAS_NUMBER)) Then
            If operation.Equals(UNDEFINED_OPERATION) Then
                operation = buttonPressed.Tag
            End If
            If result <> ZERO_NUM Then
                makeOperations()
                operation = buttonPressed.Tag
                If lastButtonHas.Equals(HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
                updateOperationScreen(operation)
                lastButtonHas = HAS_OPERATION
                auxiliarValue = ZERO_NUM
            Else
                result = auxiliarValue
                auxiliarValue = ZERO_NUM
                If lastButtonHas.Equals(HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
                updateOperationScreen(operation)
            End If
        ElseIf (operation.Equals(UNDEFINED_OPERATION)) Then
            operation = buttonPressed.Tag
            printValueOnScreen(operation)
            updateOperationScreen(operation)
        Else
            If operation.Equals(HAS_EQUALS) Then
                operation = buttonPressed.Tag
            Else
                makeOperations()
                printValueOnScreen(result)
                operation = buttonPressed.Tag
            End If

        If lastButtonHas.Equals(HAS_OPERATION) Then HasDoubleTapOperation(buttonPressed)
                updateOperationScreen(operation)
            End If
            lastButtonHas = HAS_OPERATION

        printValueOnScreen(operation)


    End Sub
    Private Sub HasDoubleTapOperation(buttonPressed)
        operation = buttonPressed.Tag
        lastButtonHas = HAS_DOUBLE_TAP_OPERATION
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        makeOperations()
        printValueOnScreen(result)
        updateOperationScreen(EQUALS_SIMBOL & result & SEPARATOR_SIMBOL & result)
        operation = HAS_EQUALS
        auxiliarValue = result
        lastButtonHas = UNDEFINED_OPERATION
    End Sub
    Private Sub makeOperations()
        Select Case operation
            Case OP_PLUS
                result += auxiliarValue
            Case OP_MINUS
                result -= auxiliarValue
            Case OP_MULTIPLY
                result *= auxiliarValue
            Case OP_DIVISION
                If (auxiliarValue = ZERO_NUM) Then
                    printValueOnScreen(MESSAGE_ERROR)
                Else
                    result /= auxiliarValue
                End If
        End Select
    End Sub
    Private Sub updateOperationScreen(newValue)

        If lblOperationScreen.Text.Length >= 32 Then
            lblOperationScreen.Text = SEPARATOR_SIMBOL & result & SPACER
        End If
        If lastButtonHas.Equals(HAS_DOUBLE_TAP_OPERATION) Then
            deleteLastValueOperationScreen()
        End If
        lblOperationScreen.Text &= newValue

    End Sub

    Private Sub deleteLastValueOperationScreen()
        If lblOperationScreen.Text.EndsWith(SEPARATOR_SIMBOL) = False Then
            If lblOperationScreen.Text.Length > 1 Then
                lblOperationScreen.Text = lblOperationScreen.Text.Remove(lblOperationScreen.Text.Length - 1)
            Else
                lblOperationScreen.Text = EMPTY_VALUE
            End If
        End If
    End Sub

    Private Sub deleteLastOperationOnOperationScreen()
        Dim valueCharsToRemove() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " "}
        lblOperationScreen.Text = lblOperationScreen.Text.TrimEnd(valueCharsToRemove)
    End Sub

    Private Sub printValueOnScreen(valueToPrint)
        lblScreen.Text = CStr(valueToPrint)
    End Sub
    Private Sub deleteLastValueMainScreen()
        If lblScreen.Text.Length > 1 Then
            lblScreen.Text = lblScreen.Text.Remove(lblScreen.Text.Length - 1)
        Else
            lblScreen.Text = ZERO_NUM
        End If
    End Sub

End Class
