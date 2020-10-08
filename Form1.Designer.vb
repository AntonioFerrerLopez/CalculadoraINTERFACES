<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnNegativeChange = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnRoot = New System.Windows.Forms.Button()
        Me.btnRisedSquare = New System.Windows.Forms.Button()
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnPercentage = New System.Windows.Forms.Button()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.lblScreen = New System.Windows.Forms.Label()
        Me.lblOperationScreen = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDot, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnZero, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNegativeChange, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPlus, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnThree, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTwo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOne, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMinus, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSix, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFour, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMultiply, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnNine, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEight, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSeven, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDivision, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRoot, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRisedSquare, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInverse, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnC, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCE, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPercentage, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBackSpace, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEquals, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFive, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 97)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 378)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnDot
        '
        Me.btnDot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDot.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDot.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDot.Location = New System.Drawing.Point(187, 315)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(91, 62)
        Me.btnDot.TabIndex = 22
        Me.btnDot.Text = ","
        Me.btnDot.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZero.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZero.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnZero.Location = New System.Drawing.Point(94, 315)
        Me.btnZero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(91, 62)
        Me.btnZero.TabIndex = 21
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnNegativeChange
        '
        Me.btnNegativeChange.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNegativeChange.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnNegativeChange.Enabled = False
        Me.btnNegativeChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNegativeChange.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegativeChange.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNegativeChange.Location = New System.Drawing.Point(1, 315)
        Me.btnNegativeChange.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNegativeChange.Name = "btnNegativeChange"
        Me.btnNegativeChange.Size = New System.Drawing.Size(91, 62)
        Me.btnNegativeChange.TabIndex = 20
        Me.btnNegativeChange.Text = "⁺/₋"
        Me.btnNegativeChange.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPlus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlus.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPlus.Location = New System.Drawing.Point(280, 252)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(91, 61)
        Me.btnPlus.TabIndex = 19
        Me.btnPlus.Tag = "+"
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnThree.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnThree.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnThree.Location = New System.Drawing.Point(187, 252)
        Me.btnThree.Margin = New System.Windows.Forms.Padding(1)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(91, 61)
        Me.btnThree.TabIndex = 18
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTwo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTwo.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTwo.Location = New System.Drawing.Point(94, 252)
        Me.btnTwo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(91, 61)
        Me.btnTwo.TabIndex = 17
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOne.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOne.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnOne.Location = New System.Drawing.Point(1, 252)
        Me.btnOne.Margin = New System.Windows.Forms.Padding(1)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(91, 61)
        Me.btnOne.TabIndex = 16
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinus.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMinus.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMinus.Location = New System.Drawing.Point(280, 189)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(91, 61)
        Me.btnMinus.TabIndex = 15
        Me.btnMinus.Tag = "-"
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSix.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSix.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSix.Location = New System.Drawing.Point(187, 189)
        Me.btnSix.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(91, 61)
        Me.btnSix.TabIndex = 14
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFour.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFour.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFour.Location = New System.Drawing.Point(1, 189)
        Me.btnFour.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(91, 61)
        Me.btnFour.TabIndex = 12
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMultiply.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMultiply.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMultiply.Location = New System.Drawing.Point(280, 126)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(1)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(91, 61)
        Me.btnMultiply.TabIndex = 11
        Me.btnMultiply.Tag = "*"
        Me.btnMultiply.Text = "X"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNine.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNine.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNine.Location = New System.Drawing.Point(187, 126)
        Me.btnNine.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(91, 61)
        Me.btnNine.TabIndex = 10
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEight.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEight.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEight.Location = New System.Drawing.Point(94, 126)
        Me.btnEight.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(91, 61)
        Me.btnEight.TabIndex = 9
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeven.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSeven.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSeven.Location = New System.Drawing.Point(1, 126)
        Me.btnSeven.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(91, 61)
        Me.btnSeven.TabIndex = 8
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnDivision
        '
        Me.btnDivision.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDivision.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDivision.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnDivision.Location = New System.Drawing.Point(280, 65)
        Me.btnDivision.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(91, 59)
        Me.btnDivision.TabIndex = 7
        Me.btnDivision.Tag = "/"
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = False
        '
        'btnRoot
        '
        Me.btnRoot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRoot.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRoot.Enabled = False
        Me.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRoot.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoot.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRoot.Location = New System.Drawing.Point(187, 65)
        Me.btnRoot.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRoot.Name = "btnRoot"
        Me.btnRoot.Size = New System.Drawing.Size(91, 59)
        Me.btnRoot.TabIndex = 6
        Me.btnRoot.Tag = "root"
        Me.btnRoot.Text = "√ₓ"
        Me.btnRoot.UseVisualStyleBackColor = False
        '
        'btnRisedSquare
        '
        Me.btnRisedSquare.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRisedSquare.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnRisedSquare.Enabled = False
        Me.btnRisedSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRisedSquare.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRisedSquare.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRisedSquare.Location = New System.Drawing.Point(94, 65)
        Me.btnRisedSquare.Margin = New System.Windows.Forms.Padding(1)
        Me.btnRisedSquare.Name = "btnRisedSquare"
        Me.btnRisedSquare.Size = New System.Drawing.Size(91, 59)
        Me.btnRisedSquare.TabIndex = 5
        Me.btnRisedSquare.Tag = "square"
        Me.btnRisedSquare.Text = "X²"
        Me.btnRisedSquare.UseVisualStyleBackColor = False
        '
        'btnInverse
        '
        Me.btnInverse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInverse.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnInverse.Enabled = False
        Me.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInverse.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInverse.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInverse.Location = New System.Drawing.Point(1, 65)
        Me.btnInverse.Margin = New System.Windows.Forms.Padding(1)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(91, 59)
        Me.btnInverse.TabIndex = 4
        Me.btnInverse.Tag = "inverse"
        Me.btnInverse.Text = "¹/ₓ"
        Me.btnInverse.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnC.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnC.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnC.Location = New System.Drawing.Point(187, 1)
        Me.btnC.Margin = New System.Windows.Forms.Padding(1)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(91, 62)
        Me.btnC.TabIndex = 2
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnCE
        '
        Me.btnCE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCE.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCE.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCE.Location = New System.Drawing.Point(94, 1)
        Me.btnCE.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(91, 62)
        Me.btnCE.TabIndex = 1
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = False
        '
        'btnPercentage
        '
        Me.btnPercentage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPercentage.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnPercentage.Enabled = False
        Me.btnPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPercentage.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPercentage.Location = New System.Drawing.Point(1, 1)
        Me.btnPercentage.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPercentage.Name = "btnPercentage"
        Me.btnPercentage.Size = New System.Drawing.Size(91, 62)
        Me.btnPercentage.TabIndex = 0
        Me.btnPercentage.Tag = "percentage"
        Me.btnPercentage.Text = "%"
        Me.btnPercentage.UseVisualStyleBackColor = False
        '
        'btnBackSpace
        '
        Me.btnBackSpace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackSpace.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackSpace.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackSpace.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBackSpace.Location = New System.Drawing.Point(280, 1)
        Me.btnBackSpace.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(91, 62)
        Me.btnBackSpace.TabIndex = 2
        Me.btnBackSpace.Text = "↩"
        Me.btnBackSpace.UseVisualStyleBackColor = False
        '
        'btnEquals
        '
        Me.btnEquals.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEquals.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEquals.Font = New System.Drawing.Font("Dank Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquals.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEquals.Location = New System.Drawing.Point(280, 315)
        Me.btnEquals.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(91, 62)
        Me.btnEquals.TabIndex = 23
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFive.Font = New System.Drawing.Font("Dank Mono", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnFive.Location = New System.Drawing.Point(94, 189)
        Me.btnFive.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(91, 61)
        Me.btnFive.TabIndex = 13
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'lblScreen
        '
        Me.lblScreen.BackColor = System.Drawing.Color.Silver
        Me.lblScreen.Font = New System.Drawing.Font("Dank Mono", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScreen.Location = New System.Drawing.Point(3, 37)
        Me.lblScreen.Name = "lblScreen"
        Me.lblScreen.Size = New System.Drawing.Size(372, 54)
        Me.lblScreen.TabIndex = 2
        Me.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperationScreen
        '
        Me.lblOperationScreen.BackColor = System.Drawing.Color.Silver
        Me.lblOperationScreen.Font = New System.Drawing.Font("Dank Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperationScreen.Location = New System.Drawing.Point(3, 2)
        Me.lblOperationScreen.Name = "lblOperationScreen"
        Me.lblOperationScreen.Size = New System.Drawing.Size(372, 28)
        Me.lblOperationScreen.TabIndex = 3
        Me.lblOperationScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Calculadora
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(378, 476)
        Me.Controls.Add(Me.lblOperationScreen)
        Me.Controls.Add(Me.lblScreen)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents btnNegativeChange As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnRoot As Button
    Friend WithEvents btnRisedSquare As Button
    Friend WithEvents btnInverse As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnPercentage As Button
    Friend WithEvents lblScreen As Label
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents lblOperationScreen As Label
End Class
