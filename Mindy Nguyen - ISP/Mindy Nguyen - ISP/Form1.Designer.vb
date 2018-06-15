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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblReverse = New System.Windows.Forms.Label()
        Me.btnCode = New System.Windows.Forms.Button()
        Me.btnDecode = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtEnter = New System.Windows.Forms.TextBox()
        Me.txtRevised = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 37)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(81, 13)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Enter Message:"
        '
        'lblReverse
        '
        Me.lblReverse.AutoSize = True
        Me.lblReverse.Location = New System.Drawing.Point(12, 77)
        Me.lblReverse.Name = "lblReverse"
        Me.lblReverse.Size = New System.Drawing.Size(102, 13)
        Me.lblReverse.TabIndex = 1
        Me.lblReverse.Text = "Reversed Message:"
        '
        'btnCode
        '
        Me.btnCode.Location = New System.Drawing.Point(279, 27)
        Me.btnCode.Name = "btnCode"
        Me.btnCode.Size = New System.Drawing.Size(75, 23)
        Me.btnCode.TabIndex = 2
        Me.btnCode.Text = "Code"
        Me.btnCode.UseVisualStyleBackColor = True
        '
        'btnDecode
        '
        Me.btnDecode.Location = New System.Drawing.Point(279, 74)
        Me.btnDecode.Name = "btnDecode"
        Me.btnDecode.Size = New System.Drawing.Size(75, 23)
        Me.btnDecode.TabIndex = 3
        Me.btnDecode.Text = "Decode"
        Me.btnDecode.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(12, 117)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 4
        '
        'txtEnter
        '
        Me.txtEnter.Location = New System.Drawing.Point(146, 30)
        Me.txtEnter.Name = "txtEnter"
        Me.txtEnter.Size = New System.Drawing.Size(100, 20)
        Me.txtEnter.TabIndex = 5
        '
        'txtRevised
        '
        Me.txtRevised.Location = New System.Drawing.Point(146, 74)
        Me.txtRevised.Name = "txtRevised"
        Me.txtRevised.Size = New System.Drawing.Size(100, 20)
        Me.txtRevised.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 576)
        Me.Controls.Add(Me.txtRevised)
        Me.Controls.Add(Me.txtEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnDecode)
        Me.Controls.Add(Me.btnCode)
        Me.Controls.Add(Me.lblReverse)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Encryption Instrument"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblReverse As System.Windows.Forms.Label
    Friend WithEvents btnCode As System.Windows.Forms.Button
    Friend WithEvents btnDecode As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtEnter As System.Windows.Forms.TextBox
    Friend WithEvents txtRevised As System.Windows.Forms.TextBox

End Class
