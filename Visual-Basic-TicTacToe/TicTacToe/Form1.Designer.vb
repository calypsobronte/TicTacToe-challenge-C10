<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.btn1 = New System.Windows.Forms.Button()
		Me.btn2 = New System.Windows.Forms.Button()
		Me.btn3 = New System.Windows.Forms.Button()
		Me.btn6 = New System.Windows.Forms.Button()
		Me.btn5 = New System.Windows.Forms.Button()
		Me.btn4 = New System.Windows.Forms.Button()
		Me.btn9 = New System.Windows.Forms.Button()
		Me.btn8 = New System.Windows.Forms.Button()
		Me.btn7 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.player1 = New System.Windows.Forms.Label()
		Me.player2 = New System.Windows.Forms.Label()
		Me.btnstart = New System.Windows.Forms.Button()
		Me.Labelscore = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btn1
		'
		Me.btn1.Location = New System.Drawing.Point(26, 24)
		Me.btn1.Name = "btn1"
		Me.btn1.Size = New System.Drawing.Size(106, 75)
		Me.btn1.TabIndex = 0
		Me.btn1.UseVisualStyleBackColor = True
		'
		'btn2
		'
		Me.btn2.Location = New System.Drawing.Point(138, 24)
		Me.btn2.Name = "btn2"
		Me.btn2.Size = New System.Drawing.Size(106, 75)
		Me.btn2.TabIndex = 1
		Me.btn2.UseVisualStyleBackColor = True
		'
		'btn3
		'
		Me.btn3.Location = New System.Drawing.Point(250, 24)
		Me.btn3.Name = "btn3"
		Me.btn3.Size = New System.Drawing.Size(106, 75)
		Me.btn3.TabIndex = 2
		Me.btn3.UseVisualStyleBackColor = True
		'
		'btn6
		'
		Me.btn6.Location = New System.Drawing.Point(250, 105)
		Me.btn6.Name = "btn6"
		Me.btn6.Size = New System.Drawing.Size(106, 75)
		Me.btn6.TabIndex = 5
		Me.btn6.UseVisualStyleBackColor = True
		'
		'btn5
		'
		Me.btn5.Location = New System.Drawing.Point(138, 105)
		Me.btn5.Name = "btn5"
		Me.btn5.Size = New System.Drawing.Size(106, 75)
		Me.btn5.TabIndex = 4
		Me.btn5.UseVisualStyleBackColor = True
		'
		'btn4
		'
		Me.btn4.Location = New System.Drawing.Point(26, 105)
		Me.btn4.Name = "btn4"
		Me.btn4.Size = New System.Drawing.Size(106, 75)
		Me.btn4.TabIndex = 3
		Me.btn4.UseVisualStyleBackColor = True
		'
		'btn9
		'
		Me.btn9.Location = New System.Drawing.Point(250, 186)
		Me.btn9.Name = "btn9"
		Me.btn9.Size = New System.Drawing.Size(106, 75)
		Me.btn9.TabIndex = 8
		Me.btn9.UseVisualStyleBackColor = True
		'
		'btn8
		'
		Me.btn8.Location = New System.Drawing.Point(138, 186)
		Me.btn8.Name = "btn8"
		Me.btn8.Size = New System.Drawing.Size(106, 75)
		Me.btn8.TabIndex = 7
		Me.btn8.UseVisualStyleBackColor = True
		'
		'btn7
		'
		Me.btn7.Location = New System.Drawing.Point(26, 186)
		Me.btn7.Name = "btn7"
		Me.btn7.Size = New System.Drawing.Size(106, 75)
		Me.btn7.TabIndex = 6
		Me.btn7.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(396, 40)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(13, 13)
		Me.Label1.TabIndex = 9
		Me.Label1.Text = "v"
		'
		'player1
		'
		Me.player1.AutoSize = True
		Me.player1.Location = New System.Drawing.Point(396, 40)
		Me.player1.Name = "player1"
		Me.player1.Size = New System.Drawing.Size(45, 13)
		Me.player1.TabIndex = 10
		Me.player1.Text = "Player 1"
		'
		'player2
		'
		Me.player2.AutoSize = True
		Me.player2.Location = New System.Drawing.Point(396, 66)
		Me.player2.Name = "player2"
		Me.player2.Size = New System.Drawing.Size(45, 13)
		Me.player2.TabIndex = 11
		Me.player2.Text = "Player 2"
		'
		'btnstart
		'
		Me.btnstart.Location = New System.Drawing.Point(416, 223)
		Me.btnstart.Name = "btnstart"
		Me.btnstart.Size = New System.Drawing.Size(125, 38)
		Me.btnstart.TabIndex = 12
		Me.btnstart.Text = "START"
		Me.btnstart.UseVisualStyleBackColor = True
		'
		'Labelscore
		'
		Me.Labelscore.AutoSize = True
		Me.Labelscore.Location = New System.Drawing.Point(563, 24)
		Me.Labelscore.Name = "Labelscore"
		Me.Labelscore.Size = New System.Drawing.Size(35, 13)
		Me.Labelscore.TabIndex = 13
		Me.Labelscore.Text = "Score"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Labelscore)
		Me.Controls.Add(Me.btnstart)
		Me.Controls.Add(Me.player2)
		Me.Controls.Add(Me.player1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btn9)
		Me.Controls.Add(Me.btn8)
		Me.Controls.Add(Me.btn7)
		Me.Controls.Add(Me.btn6)
		Me.Controls.Add(Me.btn5)
		Me.Controls.Add(Me.btn4)
		Me.Controls.Add(Me.btn3)
		Me.Controls.Add(Me.btn2)
		Me.Controls.Add(Me.btn1)
		Me.Name = "Form1"
		Me.Text = "TicTacToe"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btn1 As Button
	Friend WithEvents btn2 As Button
	Friend WithEvents btn3 As Button
	Friend WithEvents btn6 As Button
	Friend WithEvents btn5 As Button
	Friend WithEvents btn4 As Button
	Friend WithEvents btn9 As Button
	Friend WithEvents btn8 As Button
	Friend WithEvents btn7 As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents player1 As Label
	Friend WithEvents player2 As Label
	Friend WithEvents btnstart As Button
	Friend WithEvents Labelscore As Label
End Class
