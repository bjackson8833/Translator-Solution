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
        Me.cbL = New System.Windows.Forms.ComboBox()
        Me.gboxL = New System.Windows.Forms.GroupBox()
        Me.radB = New System.Windows.Forms.RadioButton()
        Me.radS = New System.Windows.Forms.RadioButton()
        Me.radF = New System.Windows.Forms.RadioButton()
        Me.radM = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.cbLD = New System.Windows.Forms.Label()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gboxL.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbL
        '
        Me.cbL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbL.FormattingEnabled = True
        Me.cbL.Items.AddRange(New Object() {"French", "Italian", "Spanish"})
        Me.cbL.Location = New System.Drawing.Point(160, 68)
        Me.cbL.Name = "cbL"
        Me.cbL.Size = New System.Drawing.Size(121, 24)
        Me.cbL.TabIndex = 0
        '
        'gboxL
        '
        Me.gboxL.Controls.Add(Me.radB)
        Me.gboxL.Controls.Add(Me.radS)
        Me.gboxL.Controls.Add(Me.radF)
        Me.gboxL.Controls.Add(Me.radM)
        Me.gboxL.Location = New System.Drawing.Point(22, 49)
        Me.gboxL.Name = "gboxL"
        Me.gboxL.Size = New System.Drawing.Size(132, 186)
        Me.gboxL.TabIndex = 1
        Me.gboxL.TabStop = False
        Me.gboxL.Text = "English"
        '
        'radB
        '
        Me.radB.AutoSize = True
        Me.radB.Location = New System.Drawing.Point(6, 156)
        Me.radB.Name = "radB"
        Me.radB.Size = New System.Drawing.Size(71, 20)
        Me.radB.TabIndex = 5
        Me.radB.TabStop = True
        Me.radB.Text = "&Brother"
        Me.radB.UseVisualStyleBackColor = True
        '
        'radS
        '
        Me.radS.AutoSize = True
        Me.radS.Location = New System.Drawing.Point(6, 119)
        Me.radS.Name = "radS"
        Me.radS.Size = New System.Drawing.Size(62, 20)
        Me.radS.TabIndex = 4
        Me.radS.TabStop = True
        Me.radS.Text = "&Sister"
        Me.radS.UseVisualStyleBackColor = True
        '
        'radF
        '
        Me.radF.AutoSize = True
        Me.radF.Location = New System.Drawing.Point(6, 82)
        Me.radF.Name = "radF"
        Me.radF.Size = New System.Drawing.Size(66, 20)
        Me.radF.TabIndex = 3
        Me.radF.TabStop = True
        Me.radF.Text = "&Father"
        Me.radF.UseVisualStyleBackColor = True
        '
        'radM
        '
        Me.radM.AutoSize = True
        Me.radM.Location = New System.Drawing.Point(6, 41)
        Me.radM.Name = "radM"
        Me.radM.Size = New System.Drawing.Size(69, 20)
        Me.radM.TabIndex = 2
        Me.radM.TabStop = True
        Me.radM.Text = "&Mother"
        Me.radM.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAnswer.Location = New System.Drawing.Point(160, 105)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(140, 130)
        Me.lblAnswer.TabIndex = 2
        '
        'cbLD
        '
        Me.cbLD.AutoSize = True
        Me.cbLD.Location = New System.Drawing.Point(157, 49)
        Me.cbLD.Name = "cbLD"
        Me.cbLD.Size = New System.Drawing.Size(87, 16)
        Me.cbLD.TabIndex = 5
        Me.cbLD.Text = "T&ranslate To:"
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(314, 100)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(86, 51)
        Me.btnTrans.TabIndex = 3
        Me.btnTrans.Text = "&Translate"
        Me.btnTrans.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(314, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 51)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 329)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cbLD)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.gboxL)
        Me.Controls.Add(Me.cbL)
        Me.Name = "frmMain"
        Me.Text = "Translator"
        Me.gboxL.ResumeLayout(False)
        Me.gboxL.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbL As ComboBox
    Friend WithEvents gboxL As GroupBox
    Friend WithEvents radB As RadioButton
    Friend WithEvents radS As RadioButton
    Friend WithEvents radF As RadioButton
    Friend WithEvents radM As RadioButton
    Friend WithEvents lblAnswer As Label
    Friend WithEvents cbLD As Label
    Friend WithEvents btnTrans As Button
    Friend WithEvents btnExit As Button
End Class
