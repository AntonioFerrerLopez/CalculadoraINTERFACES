Public Class FormHelp

    Private Sub FormHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHelpBox.Text =
           "Seleccione una de las opciones del menú superior"

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RadioBasicOperations_CheckedChanged(sender As Object, e As EventArgs) Handles RadioBasicOperations.CheckedChanged
        txtHelpBox.Text =
         "Puede realizar las operaciones básicas en cualquiera de los modos de calculadora disponibles." & vbCrLf & vbCrLf
        txtHelpBox.AppendText("1-Seleccione el primer número a operar" & vbCrLf)
        txtHelpBox.AppendText("2- Pulse sobre la operación a realizar" & vbCrLf)
        txtHelpBox.AppendText("3- Introduzca el segundo operador" & vbCrLf & vbCrLf)
        txtHelpBox.AppendText("Tiene la opción de concatenar las operaciones, en tal caso , observará los resultados parciales " & vbCrLf & vbCrLf)
        txtHelpBox.AppendText("Si pulsa sobre IGUAL , podrá observar el resultado final de la operación " & vbCrLf)
    End Sub

    Private Sub Radiopercentaje_CheckedChanged(sender As Object, e As EventArgs) Handles Radiopercentaje.CheckedChanged
        txtHelpBox.Text =
            "1- Introduzca el valor total " & vbCrLf &
            "2- Pulse sobre el botón de porcentaje % " & vbCrLf &
            "3- Introduzca el porcentaje a calcular " & vbCrLf & vbCrLf &
            "Ejemplo : Para obtener el 15 por ciento de 80 la secuencia seria 8 0 % 1 5 "

    End Sub

    Private Sub RadioInverse_CheckedChanged(sender As Object, e As EventArgs) Handles RadioInverse.CheckedChanged
        txtHelpBox.Text =
            "1- Introduzca el valor  " & vbCrLf &
            "2- Pulse sobre el botón de inversa 1/n" & vbCrLf &
            "3- Pulse sobre Igual =  " & vbCrLf & vbCrLf &
            "Ejemplo : Para obtener la inversa de 100 la secuencia seria 1 0 0 1/n = "
    End Sub

    Private Sub RadioChangeSign_CheckedChanged(sender As Object, e As EventArgs) Handles RadioChangeSign.CheckedChanged
        txtHelpBox.Text =
           "Tras introducir un valor , puede cambiar su signo pulsando sobre el boton +/- de la parte inferior izquierda"
    End Sub

    Private Sub RadioChangeMode_CheckedChanged(sender As Object, e As EventArgs) Handles RadioChangeMode.CheckedChanged
        txtHelpBox.Text =
           "Pude cambiar de modo la calculadora , para ello : " & vbCrLf & vbCrLf &
           "1- Del menú superior, seleccione la opción MODO " & vbCrLf &
           "2- Del desplegable pulse sobre CAMBIAR MODO " & vbCrLf & vbCrLf &
           "Ahora pordá observár como ha cambiado el modo de la calculadora, mostrandose el modo en el que se encuentra en la parte superior izquierda " & vbCrLf &
           "Para volver al modo anterior, realize de nuevo el proceso. " & vbCrLf
    End Sub

    Private Sub RadioSquared_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSquared.CheckedChanged
        txtHelpBox.Text =
          "Puede elevar al cuadrado un número, para ello : " & vbCrLf &
          "1-Cambie a MODO CIENTÍFICA " & vbCrLf & vbCrLf &
          "2- Introduzca el valor a elevar al cuadrado " & vbCrLf &
          "3- pulse sobre el botón x2 " & vbCrLf & vbCrLf &
          "Podrá observar el resultado inmediatamente " & vbCrLf
    End Sub

    Private Sub RadioCubed_CheckedChanged(sender As Object, e As EventArgs) Handles RadioCubed.CheckedChanged
        txtHelpBox.Text =
          "Pude elevar al cubo un número, para ello: " & vbCrLf &
          "1-Cambie a MODO CIENTÍFICA " & vbCrLf & vbCrLf &
          "2- Introduzca el valor a elevar al cubo " & vbCrLf &
          "3- pulse sobre el botón x3 " & vbCrLf & vbCrLf &
          "Podrá observar el resultado inmediatamente " & vbCrLf
    End Sub

    Private Sub RadioElevatedTo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioElevatedTo.CheckedChanged
        txtHelpBox.Text =
          "Pude elevar un número a una potencia determinada" & vbCrLf & vbCrLf &
          "1-Cambie a MODO CIENTÍFICA " & vbCrLf &
          "2- Introduzca el valor a elevar " & vbCrLf &
          "3- Pulse sobre el boton xN " & vbCrLf &
          "4- Introduzca la potencia a la que desea elevar el número " & vbCrLf &
          "5- Pulse sobre Igual =  " & vbCrLf & vbCrLf &
          "Ejemplo: para obtener  4 elevado a 2 : " & vbCrLf &
          " 4  xN  2  = " & vbCrLf
    End Sub

    Private Sub RadioFactorial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioFactorial.CheckedChanged
        txtHelpBox.Text =
            "Pude calcular el factorial de un número determinado, para ello: " & vbCrLf & vbCrLf &
            "1-Cambie a MODO CIENTÍFICA " & vbCrLf & vbCrLf &
            "2- Introduzca el valor a calcular su factorial " & vbCrLf &
            "3- pulse sobre el botón n! " & vbCrLf & vbCrLf &
            "Podrá observar el resultado inmediatamente " & vbCrLf
    End Sub
End Class