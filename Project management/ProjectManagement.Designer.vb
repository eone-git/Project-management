<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectManagement
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
        Me.components = New System.ComponentModel.Container()
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectName")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Path")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Path")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cmbComanyName = New System.Windows.Forms.ComboBox()
        Me.cmbSQLServer = New System.Windows.Forms.ComboBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.cmbExe = New System.Windows.Forms.ComboBox()
        Me.lblExe = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblSQLServer = New System.Windows.Forms.Label()
        Me.btnLoadProject = New System.Windows.Forms.Button()
        Me.UltraDataSource1 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.ucmbProjectName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmbProjectName = New System.Windows.Forms.ComboBox()
        Me.btnRunProgram = New System.Windows.Forms.Button()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucmbProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbComanyName
        '
        Me.cmbComanyName.FormattingEnabled = True
        Me.cmbComanyName.Location = New System.Drawing.Point(15, 137)
        Me.cmbComanyName.Name = "cmbComanyName"
        Me.cmbComanyName.Size = New System.Drawing.Size(207, 21)
        Me.cmbComanyName.TabIndex = 0
        '
        'cmbSQLServer
        '
        Me.cmbSQLServer.FormattingEnabled = True
        Me.cmbSQLServer.Location = New System.Drawing.Point(15, 80)
        Me.cmbSQLServer.Name = "cmbSQLServer"
        Me.cmbSQLServer.Size = New System.Drawing.Size(207, 21)
        Me.cmbSQLServer.TabIndex = 0
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(12, 118)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 1
        Me.lblCompanyName.Text = "Company Name"
        '
        'cmbExe
        '
        Me.cmbExe.FormattingEnabled = True
        Me.cmbExe.Location = New System.Drawing.Point(15, 188)
        Me.cmbExe.Name = "cmbExe"
        Me.cmbExe.Size = New System.Drawing.Size(207, 21)
        Me.cmbExe.TabIndex = 0
        '
        'lblExe
        '
        Me.lblExe.AutoSize = True
        Me.lblExe.Location = New System.Drawing.Point(12, 172)
        Me.lblExe.Name = "lblExe"
        Me.lblExe.Size = New System.Drawing.Size(56, 13)
        Me.lblExe.TabIndex = 1
        Me.lblExe.Text = "Exe Name"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(12, 9)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(71, 13)
        Me.lblProjectName.TabIndex = 1
        Me.lblProjectName.Text = "Project Name"
        '
        'lblSQLServer
        '
        Me.lblSQLServer.AutoSize = True
        Me.lblSQLServer.Location = New System.Drawing.Point(12, 64)
        Me.lblSQLServer.Name = "lblSQLServer"
        Me.lblSQLServer.Size = New System.Drawing.Size(62, 13)
        Me.lblSQLServer.TabIndex = 1
        Me.lblSQLServer.Text = "SQL Server"
        '
        'btnLoadProject
        '
        Me.btnLoadProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnLoadProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadProject.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnLoadProject.Location = New System.Drawing.Point(15, 227)
        Me.btnLoadProject.Name = "btnLoadProject"
        Me.btnLoadProject.Size = New System.Drawing.Size(104, 23)
        Me.btnLoadProject.TabIndex = 2
        Me.btnLoadProject.Text = "Load Project"
        Me.btnLoadProject.UseVisualStyleBackColor = True
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("1", Object), CType("ProjectName", Object), CType("Main Branch", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Branch For Live\SPIL Glass\SPIL_Glass\bin\" & _
                            "Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("2", Object), CType("ProjectName", Object), CType("Main", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Live\SPIL Glass\SPIL_Glass\bin\Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("3", Object), CType("ProjectName", Object), CType("USA Branch", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\New folder (3)\SPIL Glass\SPIL_Glass\bin\Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("4", Object), CType("ProjectName", Object), CType("Chevron", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Chevron Active\Evolution_Custom\Evolution_" & _
                            "Custom\bin\Debug\", Object)})})
        '
        'ucmbProjectName
        '
        Me.ucmbProjectName.DataSource = Me.UltraDataSource1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucmbProjectName.DisplayLayout.Appearance = Appearance13
        Me.ucmbProjectName.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Width = 64
        UltraGridColumn5.Header.VisiblePosition = 0
        UltraGridColumn5.Width = 65
        UltraGridColumn6.Header.VisiblePosition = 1
        UltraGridColumn6.Width = 62
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.ucmbProjectName.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucmbProjectName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucmbProjectName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucmbProjectName.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucmbProjectName.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucmbProjectName.DisplayLayout.MaxColScrollRegions = 1
        Me.ucmbProjectName.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucmbProjectName.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucmbProjectName.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucmbProjectName.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucmbProjectName.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucmbProjectName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucmbProjectName.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucmbProjectName.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucmbProjectName.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucmbProjectName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucmbProjectName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucmbProjectName.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucmbProjectName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucmbProjectName.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucmbProjectName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucmbProjectName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucmbProjectName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucmbProjectName.DisplayMember = "ProjectName"
        Me.ucmbProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucmbProjectName.Location = New System.Drawing.Point(12, 25)
        Me.ucmbProjectName.Name = "ucmbProjectName"
        Me.ucmbProjectName.Size = New System.Drawing.Size(210, 22)
        Me.ucmbProjectName.TabIndex = 3
        Me.ucmbProjectName.Text = "UltraCombo1"
        Me.ucmbProjectName.ValueMember = "Path"
        '
        'cmbProjectName
        '
        Me.cmbProjectName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UltraDataSource1, "Band 0.Path", True))
        Me.cmbProjectName.FormattingEnabled = True
        Me.cmbProjectName.Location = New System.Drawing.Point(15, 25)
        Me.cmbProjectName.Name = "cmbProjectName"
        Me.cmbProjectName.Size = New System.Drawing.Size(207, 21)
        Me.cmbProjectName.TabIndex = 0
        Me.cmbProjectName.Visible = False
        '
        'btnRunProgram
        '
        Me.btnRunProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRunProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRunProgram.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunProgram.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnRunProgram.Location = New System.Drawing.Point(117, 227)
        Me.btnRunProgram.Name = "btnRunProgram"
        Me.btnRunProgram.Size = New System.Drawing.Size(105, 23)
        Me.btnRunProgram.TabIndex = 2
        Me.btnRunProgram.Text = "Run Program"
        Me.btnRunProgram.UseVisualStyleBackColor = True
        '
        'ProjectManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(239, 262)
        Me.Controls.Add(Me.ucmbProjectName)
        Me.Controls.Add(Me.btnRunProgram)
        Me.Controls.Add(Me.btnLoadProject)
        Me.Controls.Add(Me.lblSQLServer)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.lblExe)
        Me.Controls.Add(Me.cmbExe)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.cmbProjectName)
        Me.Controls.Add(Me.cmbSQLServer)
        Me.Controls.Add(Me.cmbComanyName)
        Me.Name = "ProjectManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project Management"
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucmbProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbComanyName As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSQLServer As System.Windows.Forms.ComboBox
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents cmbExe As System.Windows.Forms.ComboBox
    Friend WithEvents lblExe As System.Windows.Forms.Label
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents lblSQLServer As System.Windows.Forms.Label
    Friend WithEvents btnLoadProject As System.Windows.Forms.Button
    Friend WithEvents UltraDataSource1 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents ucmbProjectName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmbProjectName As System.Windows.Forms.ComboBox
    Friend WithEvents btnRunProgram As System.Windows.Forms.Button

End Class
