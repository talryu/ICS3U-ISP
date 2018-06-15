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
        Me.btnCode = New System.Windows.Forms.Button()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.txtRevised = New System.Windows.Forms.TextBox()
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.lblRevise = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCode
        '
        Me.btnCode.Location = New System.Drawing.Point(70, 80)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(75, 23)
        Me.btnCode.TabIndex = 0
        Me.btnCode.Text = "Code"
        Me.btnCode.UseVisualStyleBackColor = True
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(183, 80)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 1
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(183, 143)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(100, 20)
        Me.txtEnter.TabIndex = 2
        '
        'txtRevised
        '
        Me.txtRevised.Location = New System.Drawing.Point(183, 187)
        Me.txtRevised.Name = "txtRevised"
        Me.txtRevised.Size = New System.Drawing.Size(100, 20)
        Me.txtRevised.TabIndex = 3
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(67, 146)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(66, 13)
        Me.lblEnter.TabIndex = 4
        Me.lblEnter.Text = "Enter Name:"
        '
        'lblRevise
        '
        Me.lblRevise.AutoSize = True
        Me.lblRevise.Location = New System.Drawing.Point(67, 190)
        Me.lblRevise.Name = "lblRevise"
        Me.lblRevise.Size = New System.Drawing.Size(77, 13)
        Me.lblRevise.TabIndex = 5
        Me.lblRevise.Text = "Revised Name"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(209, 288)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 483)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblRevise)
        Me.Controls.Add(Me.lblEnter)
        Me.Controls.Add(Me.txtRevised)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.btnCode)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCode As System.Windows.Forms.Button
    Friend WithEvents btnDecode As System.Windows.Forms.Button
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents txtRevised As System.Windows.Forms.TextBox
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblRevise As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
