<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFPBrows = New System.Windows.Forms.Button()
        Me.btnOFBrows = New System.Windows.Forms.Button()
        Me.txtFP = New System.Windows.Forms.TextBox()
        Me.txtOF = New System.Windows.Forms.TextBox()
        Me.btnEnc = New System.Windows.Forms.Button()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File to Process:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Output File:"
        '
        'btnFPBrows
        '
        Me.btnFPBrows.Location = New System.Drawing.Point(475, 4)
        Me.btnFPBrows.Name = "btnFPBrows"
        Me.btnFPBrows.Size = New System.Drawing.Size(28, 23)
        Me.btnFPBrows.TabIndex = 2
        Me.btnFPBrows.Text = "..."
        Me.btnFPBrows.UseVisualStyleBackColor = True
        '
        'btnOFBrows
        '
        Me.btnOFBrows.Location = New System.Drawing.Point(475, 30)
        Me.btnOFBrows.Name = "btnOFBrows"
        Me.btnOFBrows.Size = New System.Drawing.Size(28, 23)
        Me.btnOFBrows.TabIndex = 3
        Me.btnOFBrows.Text = "..."
        Me.btnOFBrows.UseVisualStyleBackColor = True
        '
        'txtFP
        '
        Me.txtFP.Location = New System.Drawing.Point(97, 6)
        Me.txtFP.Name = "txtFP"
        Me.txtFP.Size = New System.Drawing.Size(372, 20)
        Me.txtFP.TabIndex = 4
        '
        'txtOF
        '
        Me.txtOF.Location = New System.Drawing.Point(97, 32)
        Me.txtOF.Name = "txtOF"
        Me.txtOF.Size = New System.Drawing.Size(372, 20)
        Me.txtOF.TabIndex = 5
        '
        'btnEnc
        '
        Me.btnEnc.Location = New System.Drawing.Point(181, 59)
        Me.btnEnc.Name = "btnEnc"
        Me.btnEnc.Size = New System.Drawing.Size(75, 23)
        Me.btnEnc.TabIndex = 6
        Me.btnEnc.Text = "Encrypt"
        Me.btnEnc.UseVisualStyleBackColor = True
        '
        'btnDec
        '
        Me.btnDec.Location = New System.Drawing.Point(264, 59)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(75, 23)
        Me.btnDec.TabIndex = 7
        Me.btnDec.Text = "Decrypt"
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(428, 59)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 89)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDec)
        Me.Controls.Add(Me.btnEnc)
        Me.Controls.Add(Me.txtOF)
        Me.Controls.Add(Me.txtFP)
        Me.Controls.Add(Me.btnOFBrows)
        Me.Controls.Add(Me.btnFPBrows)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Text File Encryptor / Decryptor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFPBrows As Button
    Friend WithEvents btnOFBrows As Button
    Friend WithEvents txtFP As TextBox
    Friend WithEvents txtOF As TextBox
    Friend WithEvents btnEnc As Button
    Friend WithEvents btnDec As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
End Class
