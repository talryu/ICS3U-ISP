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
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.lblReverse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(98, 213)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(123, 39)
        Me.btnReverse.TabIndex = 0
        Me.btnReverse.Text = "Reverse"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'lblReverse
        '
        Me.lblReverse.AutoSize = True
        Me.lblReverse.Location = New System.Drawing.Point(95, 167)
        Me.lblReverse.Name = "lblReverse"
        Me.lblReverse.Size = New System.Drawing.Size(0, 13)
        Me.lblReverse.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 375)
        Me.Controls.Add(Me.lblReverse)
        Me.Controls.Add(Me.btnReverse)
        Me.Name = "Form1"
        Me.Text = "ISP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents lblReverse As System.Windows.Forms.Label

End Class
