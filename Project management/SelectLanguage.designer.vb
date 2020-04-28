<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLanguage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.rbSelected = New System.Windows.Forms.RadioButton
Me.rbShow = New System.Windows.Forms.RadioButton
Me.lblStartup = New System.Windows.Forms.Label
Me.rbDefault = New System.Windows.Forms.RadioButton
Me.lstCultures = New System.Windows.Forms.ListBox
Me.Panel1 = New System.Windows.Forms.Panel
Me.btOK = New System.Windows.Forms.Button
Me.Panel1.SuspendLayout()
Me.SuspendLayout()
'
'rbSelected
'
Me.rbSelected.FlatStyle = System.Windows.Forms.FlatStyle.System
Me.rbSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl
Me.rbSelected.Location = New System.Drawing.Point(4, 40)
Me.rbSelected.Name = "rbSelected"
Me.rbSelected.Size = New System.Drawing.Size(209, 20)
Me.rbSelected.TabIndex = 2
Me.rbSelected.Text = "Use the selected language"
'
'rbShow
'
Me.rbShow.Checked = True
Me.rbShow.FlatStyle = System.Windows.Forms.FlatStyle.System
Me.rbShow.ImeMode = System.Windows.Forms.ImeMode.NoControl
Me.rbShow.Location = New System.Drawing.Point(4, 20)
Me.rbShow.Name = "rbShow"
Me.rbShow.Size = New System.Drawing.Size(209, 20)
Me.rbShow.TabIndex = 1
Me.rbShow.TabStop = True
Me.rbShow.Text = "Show this form again"
'
'lblStartup
'
Me.lblStartup.ImeMode = System.Windows.Forms.ImeMode.NoControl
Me.lblStartup.Location = New System.Drawing.Point(4, 3)
Me.lblStartup.Name = "lblStartup"
Me.lblStartup.Size = New System.Drawing.Size(209, 17)
Me.lblStartup.TabIndex = 0
Me.lblStartup.Text = "Next time ..."
'
'rbDefault
'
Me.rbDefault.FlatStyle = System.Windows.Forms.FlatStyle.System
Me.rbDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl
Me.rbDefault.Location = New System.Drawing.Point(4, 60)
Me.rbDefault.Name = "rbDefault"
Me.rbDefault.Size = New System.Drawing.Size(209, 20)
Me.rbDefault.TabIndex = 3
Me.rbDefault.Text = "Use the default language"
'
'lstCultures
'
Me.lstCultures.DisplayMember = "NativeName"
Me.lstCultures.FormattingEnabled = True
Me.lstCultures.IntegralHeight = False
Me.lstCultures.Location = New System.Drawing.Point(4, 4)
Me.lstCultures.Name = "lstCultures"
Me.lstCultures.Size = New System.Drawing.Size(264, 220)
Me.lstCultures.TabIndex = 7
'
'Panel1
'
Me.Panel1.BackColor = System.Drawing.SystemColors.Control
Me.Panel1.Controls.Add(Me.rbDefault)
Me.Panel1.Controls.Add(Me.rbSelected)
Me.Panel1.Controls.Add(Me.rbShow)
Me.Panel1.Controls.Add(Me.lblStartup)
Me.Panel1.Location = New System.Drawing.Point(4, 228)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(264, 84)
Me.Panel1.TabIndex = 6
'
'btOK
'
Me.btOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
Me.btOK.Location = New System.Drawing.Point(180, 316)
Me.btOK.Name = "btOK"
Me.btOK.Size = New System.Drawing.Size(90, 32)
Me.btOK.TabIndex = 5
Me.btOK.Text = "OK"
'
'SelectLanguage
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(272, 352)
Me.Controls.Add(Me.lstCultures)
Me.Controls.Add(Me.Panel1)
Me.Controls.Add(Me.btOK)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
Me.Name = "SelectLanguage"
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "SelectLanguage"
Me.Panel1.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
    Friend WithEvents rbSelected As System.Windows.Forms.RadioButton
    Friend WithEvents rbShow As System.Windows.Forms.RadioButton
    Friend WithEvents lblStartup As System.Windows.Forms.Label
    Friend WithEvents rbDefault As System.Windows.Forms.RadioButton
    Friend WithEvents lstCultures As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btOK As System.Windows.Forms.Button
End Class
