<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.score = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'score
		'
		Me.score.AutoSize = True
		Me.score.Font = New System.Drawing.Font("Ravie", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.score.Location = New System.Drawing.Point(23, 37)
		Me.score.Name = "score"
		Me.score.Size = New System.Drawing.Size(187, 43)
		Me.score.TabIndex = 0
		Me.score.Text = "Score : "
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1620, 759)
		Me.Controls.Add(Me.score)
		Me.Name = "Form3"
		Me.Text = "Form3"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents score As Label
End Class
