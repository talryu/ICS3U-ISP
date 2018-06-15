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
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtencrypt = New System.Windows.Forms.TextBox()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Location = New System.Drawing.Point(143, 291)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(123, 42)
        Me.btnEncrypt.TabIndex = 0
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(238, 471)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(0, 20)
        Me.lblText.TabIndex = 1
        '
        'txtencrypt
        '
        Me.txtencrypt.Location = New System.Drawing.Point(343, 157)
        Me.txtencrypt.Multiline = True
        Me.txtencrypt.Name = "txtencrypt"
        Me.txtencrypt.Size = New System.Drawing.Size(191, 99)
        Me.txtencrypt.TabIndex = 2
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(353, 291)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(116, 42)
        Me.btnDecrypt.TabIndex = 3
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(343, 388)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(126, 26)
        Me.NumericUpDown1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter the shift"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter the text: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 30)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Text:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(269, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 34)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Caesar Cipher Encryption"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 540)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.txtencrypt)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents txtencrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
