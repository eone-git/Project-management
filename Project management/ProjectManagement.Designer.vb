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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectManagement))
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectName")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Path")
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Path")
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.UltraDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucmbProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbComanyName
        '
        Me.cmbComanyName.FormattingEnabled = True
        resources.ApplyResources(Me.cmbComanyName, "cmbComanyName")
        Me.cmbComanyName.Name = "cmbComanyName"
        '
        'cmbSQLServer
        '
        Me.cmbSQLServer.FormattingEnabled = True
        resources.ApplyResources(Me.cmbSQLServer, "cmbSQLServer")
        Me.cmbSQLServer.Name = "cmbSQLServer"
        '
        'lblCompanyName
        '
        resources.ApplyResources(Me.lblCompanyName, "lblCompanyName")
        Me.lblCompanyName.Name = "lblCompanyName"
        '
        'cmbExe
        '
        Me.cmbExe.FormattingEnabled = True
        resources.ApplyResources(Me.cmbExe, "cmbExe")
        Me.cmbExe.Name = "cmbExe"
        '
        'lblExe
        '
        resources.ApplyResources(Me.lblExe, "lblExe")
        Me.lblExe.Name = "lblExe"
        '
        'lblProjectName
        '
        resources.ApplyResources(Me.lblProjectName, "lblProjectName")
        Me.lblProjectName.Name = "lblProjectName"
        '
        'lblSQLServer
        '
        resources.ApplyResources(Me.lblSQLServer, "lblSQLServer")
        Me.lblSQLServer.Name = "lblSQLServer"
        '
        'btnLoadProject
        '
        Me.btnLoadProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.btnLoadProject, "btnLoadProject")
        Me.btnLoadProject.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnLoadProject.Name = "btnLoadProject"
        Me.btnLoadProject.UseVisualStyleBackColor = True
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("1", Object), CType("ProjectName", Object), CType("Main Branch", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Branch For Live\SPIL Glass\SPIL_Glass\bin\" & _
                            "Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("2", Object), CType("ProjectName", Object), CType("Main", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Live\SPIL Glass\SPIL_Glass\bin\Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("3", Object), CType("ProjectName", Object), CType("USA Branch", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\New folder (3)\SPIL Glass\SPIL_Glass\bin\Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("4", Object), CType("ProjectName", Object), CType("Chevron", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Chevron Active\Evolution_Custom\Evolution_" & _
                            "Custom\bin\Debug\", Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ProjectID", Object), CType("5", Object), CType("ProjectName", Object), CType("Lite", Object), CType("Path", Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Lite\SPIL Glass\SPIL Glass\SPIL_Glass\bin\" & _
                            "Debug", Object)})})
        '
        'ucmbProjectName
        '
        Me.ucmbProjectName.DataSource = Me.UltraDataSource1
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        resources.ApplyResources(Appearance13.FontData, "Appearance13.FontData")
        resources.ApplyResources(Appearance13, "Appearance13")
        Appearance13.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Appearance = Appearance13
        Me.ucmbProjectName.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn1.Width = 64
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Width = 69
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 58
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ucmbProjectName.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucmbProjectName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucmbProjectName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance14.FontData, "Appearance14.FontData")
        resources.ApplyResources(Appearance14, "Appearance14")
        Appearance14.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance15.FontData, "Appearance15.FontData")
        resources.ApplyResources(Appearance15, "Appearance15")
        Appearance15.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance16.FontData, "Appearance16.FontData")
        resources.ApplyResources(Appearance16, "Appearance16")
        Appearance16.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucmbProjectName.DisplayLayout.MaxColScrollRegions = 1
        Me.ucmbProjectName.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Appearance17.FontData, "Appearance17.FontData")
        resources.ApplyResources(Appearance17, "Appearance17")
        Appearance17.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        resources.ApplyResources(Appearance18.FontData, "Appearance18.FontData")
        resources.ApplyResources(Appearance18, "Appearance18")
        Appearance18.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance19.FontData, "Appearance19.FontData")
        resources.ApplyResources(Appearance19, "Appearance19")
        Appearance19.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        resources.ApplyResources(Appearance20.FontData, "Appearance20.FontData")
        resources.ApplyResources(Appearance20, "Appearance20")
        Appearance20.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucmbProjectName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucmbProjectName.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance21.FontData, "Appearance21.FontData")
        resources.ApplyResources(Appearance21, "Appearance21")
        Appearance21.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        resources.ApplyResources(Appearance22, "Appearance22")
        resources.ApplyResources(Appearance22.FontData, "Appearance22.FontData")
        Appearance22.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucmbProjectName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucmbProjectName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        resources.ApplyResources(Appearance23.FontData, "Appearance23.FontData")
        resources.ApplyResources(Appearance23, "Appearance23")
        Appearance23.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucmbProjectName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Appearance24.FontData, "Appearance24.FontData")
        resources.ApplyResources(Appearance24, "Appearance24")
        Appearance24.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucmbProjectName.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucmbProjectName.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucmbProjectName.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucmbProjectName.DisplayMember = "ProjectName"
        resources.ApplyResources(Me.ucmbProjectName, "ucmbProjectName")
        Me.ucmbProjectName.Name = "ucmbProjectName"
        Me.ucmbProjectName.ValueMember = "Path"
        '
        'cmbProjectName
        '
        Me.cmbProjectName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UltraDataSource1, "Band 0.Path", True))
        Me.cmbProjectName.FormattingEnabled = True
        resources.ApplyResources(Me.cmbProjectName, "cmbProjectName")
        Me.cmbProjectName.Name = "cmbProjectName"
        '
        'btnRunProgram
        '
        Me.btnRunProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.btnRunProgram, "btnRunProgram")
        Me.btnRunProgram.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnRunProgram.Name = "btnRunProgram"
        Me.btnRunProgram.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProjectManagement
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.ucmbProjectName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
