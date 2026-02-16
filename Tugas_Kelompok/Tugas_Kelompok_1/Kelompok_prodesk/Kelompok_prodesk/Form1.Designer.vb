<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Pcbmenu = New System.Windows.Forms.PictureBox()
		Me.Btnplay = New System.Windows.Forms.Button()
		CType(Me.Pcbmenu, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Pcbmenu
		'
		Me.Pcbmenu.Image = Global.Kelompok_prodesk.My.Resources.Resources.Marbel_Dunia_Hewan
		Me.Pcbmenu.Location = New System.Drawing.Point(-16, -2)
		Me.Pcbmenu.Name = "Pcbmenu"
		Me.Pcbmenu.Size = New System.Drawing.Size(1640, 632)
		Me.Pcbmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Pcbmenu.TabIndex = 0
		Me.Pcbmenu.TabStop = False
		'
		'Btnplay
		'
		Me.Btnplay.BackColor = System.Drawing.Color.Aquamarine
		Me.Btnplay.Font = New System.Drawing.Font("Ravie", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Btnplay.Location = New System.Drawing.Point(588, 334)
		Me.Btnplay.Name = "Btnplay"
		Me.Btnplay.Size = New System.Drawing.Size(467, 103)
		Me.Btnplay.TabIndex = 2
		Me.Btnplay.Text = "PLAY"
		Me.Btnplay.UseVisualStyleBackColor = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1623, 630)
		Me.Controls.Add(Me.Btnplay)
		Me.Controls.Add(Me.Pcbmenu)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.Pcbmenu, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Pcbmenu As PictureBox
	Friend WithEvents Btnplay As Button
End Class
