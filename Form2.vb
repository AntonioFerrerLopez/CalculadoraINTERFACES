Public Class FormHelp

    Private Sub FormHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHelpBox.Text =
            "Si desea cambiar entre los dos tipos de calculadora posibles puede seleccionar MODO -> CAMBIAR MODO"
        txtHelpBox.AppendText(
            "Para realizar el cáculo de porcentajes, seleccione el ")

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class