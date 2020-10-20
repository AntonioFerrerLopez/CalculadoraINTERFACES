<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHelp
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHelpBox = New System.Windows.Forms.TextBox()
        Me.RadioBasicOperations = New System.Windows.Forms.RadioButton()
        Me.Radiopercentaje = New System.Windows.Forms.RadioButton()
        Me.RadioCubed = New System.Windows.Forms.RadioButton()
        Me.RadioInverse = New System.Windows.Forms.RadioButton()
        Me.RadioElevatedTo = New System.Windows.Forms.RadioButton()
        Me.RadioChangeSign = New System.Windows.Forms.RadioButton()
        Me.RadioFactorial = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioChangeMode = New System.Windows.Forms.RadioButton()
        Me.RadioSquared = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(186, 571)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(101, 35)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "CERRAR "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AYUDA"
        '
        'txtHelpBox
        '
        Me.txtHelpBox.Enabled = False
        Me.txtHelpBox.Font = New System.Drawing.Font("Dank Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHelpBox.Location = New System.Drawing.Point(15, 290)
        Me.txtHelpBox.Multiline = True
        Me.txtHelpBox.Name = "txtHelpBox"
        Me.txtHelpBox.Size = New System.Drawing.Size(449, 275)
        Me.txtHelpBox.TabIndex = 3
        '
        'RadioBasicOperations
        '
        Me.RadioBasicOperations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioBasicOperations.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioBasicOperations.AutoSize = True
        Me.RadioBasicOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioBasicOperations.Location = New System.Drawing.Point(3, 3)
        Me.RadioBasicOperations.Name = "RadioBasicOperations"
        Me.RadioBasicOperations.Size = New System.Drawing.Size(218, 25)
        Me.RadioBasicOperations.TabIndex = 0
        Me.RadioBasicOperations.TabStop = True
        Me.RadioBasicOperations.Text = "Operaciones básicas"
        Me.RadioBasicOperations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioBasicOperations.UseVisualStyleBackColor = True
        '
        'Radiopercentaje
        '
        Me.Radiopercentaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radiopercentaje.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radiopercentaje.AutoSize = True
        Me.Radiopercentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radiopercentaje.Location = New System.Drawing.Point(3, 34)
        Me.Radiopercentaje.Name = "Radiopercentaje"
        Me.Radiopercentaje.Size = New System.Drawing.Size(218, 25)
        Me.Radiopercentaje.TabIndex = 2
        Me.Radiopercentaje.TabStop = True
        Me.Radiopercentaje.Text = "Calcular porcentajes"
        Me.Radiopercentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radiopercentaje.UseVisualStyleBackColor = True
        '
        'RadioCubed
        '
        Me.RadioCubed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioCubed.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioCubed.AutoSize = True
        Me.RadioCubed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCubed.Location = New System.Drawing.Point(227, 34)
        Me.RadioCubed.Name = "RadioCubed"
        Me.RadioCubed.Size = New System.Drawing.Size(219, 25)
        Me.RadioCubed.TabIndex = 3
        Me.RadioCubed.TabStop = True
        Me.RadioCubed.Text = "Elevar al cubo"
        Me.RadioCubed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCubed.UseVisualStyleBackColor = True
        '
        'RadioInverse
        '
        Me.RadioInverse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioInverse.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioInverse.AutoSize = True
        Me.RadioInverse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioInverse.Location = New System.Drawing.Point(3, 65)
        Me.RadioInverse.Name = "RadioInverse"
        Me.RadioInverse.Size = New System.Drawing.Size(218, 25)
        Me.RadioInverse.TabIndex = 4
        Me.RadioInverse.TabStop = True
        Me.RadioInverse.Text = "Calcular la inversa"
        Me.RadioInverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioInverse.UseVisualStyleBackColor = True
        '
        'RadioElevatedTo
        '
        Me.RadioElevatedTo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioElevatedTo.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioElevatedTo.AutoSize = True
        Me.RadioElevatedTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioElevatedTo.Location = New System.Drawing.Point(227, 65)
        Me.RadioElevatedTo.Name = "RadioElevatedTo"
        Me.RadioElevatedTo.Size = New System.Drawing.Size(219, 25)
        Me.RadioElevatedTo.TabIndex = 5
        Me.RadioElevatedTo.TabStop = True
        Me.RadioElevatedTo.Text = "Elevar a N "
        Me.RadioElevatedTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioElevatedTo.UseVisualStyleBackColor = True
        '
        'RadioChangeSign
        '
        Me.RadioChangeSign.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioChangeSign.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioChangeSign.AutoSize = True
        Me.RadioChangeSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioChangeSign.Location = New System.Drawing.Point(3, 96)
        Me.RadioChangeSign.Name = "RadioChangeSign"
        Me.RadioChangeSign.Size = New System.Drawing.Size(218, 25)
        Me.RadioChangeSign.TabIndex = 6
        Me.RadioChangeSign.TabStop = True
        Me.RadioChangeSign.Text = "Cambiar el signo "
        Me.RadioChangeSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioChangeSign.UseVisualStyleBackColor = True
        '
        'RadioFactorial
        '
        Me.RadioFactorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioFactorial.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioFactorial.AutoSize = True
        Me.RadioFactorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioFactorial.Location = New System.Drawing.Point(227, 96)
        Me.RadioFactorial.Name = "RadioFactorial"
        Me.RadioFactorial.Size = New System.Drawing.Size(219, 25)
        Me.RadioFactorial.TabIndex = 7
        Me.RadioFactorial.TabStop = True
        Me.RadioFactorial.Text = "Factorial de número"
        Me.RadioFactorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioFactorial.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadioChangeMode, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioChangeSign, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioElevatedTo, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioInverse, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioCubed, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Radiopercentaje, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioFactorial, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioBasicOperations, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadioSquared, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 94)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(449, 190)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'RadioChangeMode
        '
        Me.RadioChangeMode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadioChangeMode.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioChangeMode.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.RadioChangeMode, 2)
        Me.RadioChangeMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioChangeMode.Location = New System.Drawing.Point(139, 140)
        Me.RadioChangeMode.Name = "RadioChangeMode"
        Me.RadioChangeMode.Size = New System.Drawing.Size(171, 34)
        Me.RadioChangeMode.TabIndex = 8
        Me.RadioChangeMode.TabStop = True
        Me.RadioChangeMode.Text = "Cambio de modo "
        Me.RadioChangeMode.UseVisualStyleBackColor = True
        '
        'RadioSquared
        '
        Me.RadioSquared.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioSquared.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioSquared.AutoSize = True
        Me.RadioSquared.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSquared.Location = New System.Drawing.Point(227, 3)
        Me.RadioSquared.Name = "RadioSquared"
        Me.RadioSquared.Size = New System.Drawing.Size(219, 25)
        Me.RadioSquared.TabIndex = 9
        Me.RadioSquared.TabStop = True
        Me.RadioSquared.Text = "Elevar al cuadrado"
        Me.RadioSquared.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioSquared.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dank Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modo básico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dank Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Modo científica"
        '
        'FormHelp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(476, 610)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txtHelpBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Dank Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormHelp"
        Me.Text = "AYUDA"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHelpBox As TextBox
    Friend WithEvents RadioBasicOperations As RadioButton
    Friend WithEvents Radiopercentaje As RadioButton
    Friend WithEvents RadioCubed As RadioButton
    Friend WithEvents RadioInverse As RadioButton
    Friend WithEvents RadioElevatedTo As RadioButton
    Friend WithEvents RadioChangeSign As RadioButton
    Friend WithEvents RadioFactorial As RadioButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RadioChangeMode As RadioButton
    Friend WithEvents RadioSquared As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
