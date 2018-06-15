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
        Me.BtnEn = New System.Windows.Forms.Button()
        Me.btnDe = New System.Windows.Forms.Button()
        Me.lblOr = New System.Windows.Forms.Label()
        Me.LblCy = New System.Windows.Forms.Label()
        Me.TxtIn = New System.Windows.Forms.TextBox()
        Me.txtIn2 = New System.Windows.Forms.TextBox()
        Me.Lblanswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEn
        '
        Me.BtnEn.Location = New System.Drawing.Point(83, 70)
        Me.BtnEn.Name = "BtnEn"
        Me.BtnEn.Size = New System.Drawing.Size(75, 23)
        Me.BtnEn.TabIndex = 0
        Me.BtnEn.Text = "Encode"
        Me.BtnEn.UseVisualStyleBackColor = True
        '
        'btnDe
        '
        Me.btnDe.Location = New System.Drawing.Point(189, 70)
        Me.btnDe.Name = "btnDe"
        Me.btnDe.Size = New System.Drawing.Size(75, 23)
        Me.btnDe.TabIndex = 1
        Me.btnDe.Text = "Decode"
        Me.btnDe.UseVisualStyleBackColor = True
        '
        'lblOr
        '
        Me.lblOr.AutoSize = True
        Me.lblOr.Location = New System.Drawing.Point(70, 130)
        Me.lblOr.Name = "lblOr"
        Me.lblOr.Size = New System.Drawing.Size(76, 13)
        Me.lblOr.TabIndex = 2
        Me.lblOr.Text = "Original string: "
        '
        'LblCy
        '
        Me.LblCy.AutoSize = True
        Me.LblCy.Location = New System.Drawing.Point(70, 163)
        Me.LblCy.Name = "LblCy"
        Me.LblCy.Size = New System.Drawing.Size(86, 13)
        Me.LblCy.TabIndex = 3
        Me.LblCy.Text = "Cyphered string: "
        '
        'TxtIn
        '
        Me.TxtIn.Location = New System.Drawing.Point(164, 127)
        Me.TxtIn.Name = "TxtIn"
        Me.TxtIn.Size = New System.Drawing.Size(100, 20)
        Me.TxtIn.TabIndex = 4
        '
        'txtIn2
        '
        Me.txtIn2.Location = New System.Drawing.Point(164, 160)
        Me.txtIn2.Name = "txtIn2"
        Me.txtIn2.Size = New System.Drawing.Size(100, 20)
        Me.txtIn2.TabIndex = 5
        '
        'Lblanswer
        '
        Me.Lblanswer.AutoSize = True
        Me.Lblanswer.Location = New System.Drawing.Point(133, 220)
        Me.Lblanswer.Name = "Lblanswer"
        Me.Lblanswer.Size = New System.Drawing.Size(0, 13)
        Me.Lblanswer.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 405)
        Me.Controls.Add(Me.Lblanswer)
        Me.Controls.Add(Me.txtIn2)
        Me.Controls.Add(Me.TxtIn)
        Me.Controls.Add(Me.LblCy)
        Me.Controls.Add(Me.lblOr)
        Me.Controls.Add(Me.btnDe)
        Me.Controls.Add(Me.BtnEn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEn As System.Windows.Forms.Button
    Friend WithEvents btnDe As System.Windows.Forms.Button
    Friend WithEvents lblOr As System.Windows.Forms.Label
    Friend WithEvents LblCy As System.Windows.Forms.Label
    Friend WithEvents TxtIn As System.Windows.Forms.TextBox
    Friend WithEvents txtIn2 As System.Windows.Forms.TextBox
    Friend WithEvents Lblanswer As System.Windows.Forms.Label

End Class
