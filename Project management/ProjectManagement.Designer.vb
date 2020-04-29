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
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectName")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Path")
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Path")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("SqlServerName")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Path")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SqlServerName")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Path")
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.cmbComanyName = New System.Windows.Forms.ComboBox()
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
        Me.UltraDataSource2 = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.cmbSQLServer = New Infragistics.Win.UltraWinGrid.UltraCombo()
        CType(Me.UltraDataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ucmbProjectName,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UltraDataSource2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cmbSQLServer,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cmbComanyName
        '
        Me.cmbComanyName.FormattingEnabled = true
        resources.ApplyResources(Me.cmbComanyName, "cmbComanyName")
        Me.cmbComanyName.Name = "cmbComanyName"
        '
        'lblCompanyName
        '
        resources.ApplyResources(Me.lblCompanyName, "lblCompanyName")
        Me.lblCompanyName.Name = "lblCompanyName"
        '
        'cmbExe
        '
        Me.cmbExe.FormattingEnabled = true
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
        Me.btnLoadProject.UseVisualStyleBackColor = true
        '
        'UltraDataSource1
        '
        Me.UltraDataSource1.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3})
        Me.UltraDataSource1.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("1",Object), CType("ProjectName",Object), CType("Main Branch",Object), CType("Path",Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Branch For Live\SPIL Glass\SPIL_Glass\bin\"& _ 
                            "Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("2",Object), CType("ProjectName",Object), CType("Main",Object), CType("Path",Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Live\SPIL Glass\SPIL_Glass\bin\Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("3",Object), CType("ProjectName",Object), CType("USA Branch",Object), CType("Path",Object), CType("D:\SPIL Glass Main Projects\New folder (3)\SPIL Glass\SPIL_Glass\bin\Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("4",Object), CType("ProjectName",Object), CType("Chevron",Object), CType("Path",Object), CType("D:\SPIL Glass Main Projects\SPIL Glass Chevron Active\Evolution_Custom\Evolution_"& _ 
                            "Custom\bin\Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("5",Object), CType("ProjectName",Object), CType("GIT SPIL Glass Lite",Object), CType("Path",Object), CType("O:\SPIL\Source\Repos\SPIL Lite\SPIL Glass\SPIL_Glass\bin\Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("6",Object), CType("ProjectName",Object), CType("GIT SPIL Glass",Object), CType("Path",Object), CType("O:\SPIL\Source\Repos\SPIL Glass\SPIL Glass\SPIL_Glass\bin\Debug\",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("7",Object), CType("ProjectName",Object), CType("GIT SPIL Glass Inventory",Object), CType("Path",Object), CType("O:\SPIL\Source\Repos\SPIL Glass Inventory Module\DLL\",Object)})})
        '
        'ucmbProjectName
        '
        Me.ucmbProjectName.DataSource = Me.UltraDataSource1
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        resources.ApplyResources(Appearance25.FontData, "Appearance25.FontData")
        resources.ApplyResources(Appearance25, "Appearance25")
        Appearance25.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Appearance = Appearance25
        Me.ucmbProjectName.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.Header.VisiblePosition = 2
        UltraGridColumn1.Width = 86
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn2.Width = 94
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn3.Width = 77
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        Me.ucmbProjectName.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucmbProjectName.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucmbProjectName.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance26.FontData, "Appearance26.FontData")
        resources.ApplyResources(Appearance26, "Appearance26")
        Appearance26.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance27.FontData, "Appearance27.FontData")
        resources.ApplyResources(Appearance27, "Appearance27")
        Appearance27.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.ucmbProjectName.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance28.FontData, "Appearance28.FontData")
        resources.ApplyResources(Appearance28, "Appearance28")
        Appearance28.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.ucmbProjectName.DisplayLayout.MaxColScrollRegions = 1
        Me.ucmbProjectName.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Appearance29.FontData, "Appearance29.FontData")
        resources.ApplyResources(Appearance29, "Appearance29")
        Appearance29.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        resources.ApplyResources(Appearance30.FontData, "Appearance30.FontData")
        resources.ApplyResources(Appearance30, "Appearance30")
        Appearance30.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucmbProjectName.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance31.FontData, "Appearance31.FontData")
        resources.ApplyResources(Appearance31, "Appearance31")
        Appearance31.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        resources.ApplyResources(Appearance32.FontData, "Appearance32.FontData")
        resources.ApplyResources(Appearance32, "Appearance32")
        Appearance32.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.CellAppearance = Appearance32
        Me.ucmbProjectName.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucmbProjectName.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance33.FontData, "Appearance33.FontData")
        resources.ApplyResources(Appearance33, "Appearance33")
        Appearance33.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        resources.ApplyResources(Appearance34, "Appearance34")
        resources.ApplyResources(Appearance34.FontData, "Appearance34.FontData")
        Appearance34.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.ucmbProjectName.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucmbProjectName.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        resources.ApplyResources(Appearance35.FontData, "Appearance35.FontData")
        resources.ApplyResources(Appearance35, "Appearance35")
        Appearance35.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.RowAppearance = Appearance35
        Me.ucmbProjectName.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Appearance36.FontData, "Appearance36.FontData")
        resources.ApplyResources(Appearance36, "Appearance36")
        Appearance36.ForceApplyResources = "FontData|"
        Me.ucmbProjectName.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
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
        Me.cmbProjectName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UltraDataSource1, "Band 0.Path", true))
        Me.cmbProjectName.FormattingEnabled = true
        resources.ApplyResources(Me.cmbProjectName, "cmbProjectName")
        Me.cmbProjectName.Name = "cmbProjectName"
        '
        'btnRunProgram
        '
        Me.btnRunProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.btnRunProgram, "btnRunProgram")
        Me.btnRunProgram.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnRunProgram.Name = "btnRunProgram"
        Me.btnRunProgram.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'UltraDataSource2
        '
        Me.UltraDataSource2.Band.Columns.AddRange(New Object() {UltraDataColumn4, UltraDataColumn5, UltraDataColumn6})
        Me.UltraDataSource2.Rows.AddRange(New Object() {New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("1",Object), CType("SqlServerName",Object), CType("SQL 2014",Object), CType("Path",Object), CType("SPIL-PC13\MSSQLSERVER2014",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("2",Object), CType("SqlServerName",Object), CType("Local DB SQL 2017",Object), CType("Path",Object), CType("(localdb)\SQL SERVER 2017",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("3",Object), CType("SqlServerName",Object), CType("Local DB SQL 2019",Object), CType("Path",Object), CType("(localdb)\sql_2019",Object)}), New Infragistics.Win.UltraWinDataSource.UltraDataRow(New Object() {CType("ID",Object), CType("4",Object), CType("SqlServerName",Object), CType("SQL 2019",Object), CType("Path",Object), CType("SPIL-PC13\MS_SQL_2019",Object)})})
        '
        'cmbSQLServer
        '
        Me.cmbSQLServer.DataSource = Me.UltraDataSource2
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        resources.ApplyResources(Appearance1.FontData, "Appearance1.FontData")
        resources.ApplyResources(Appearance1, "Appearance1")
        Appearance1.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Appearance = Appearance1
        Me.cmbSQLServer.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn4.Width = 97
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridColumn5.Width = 98
        UltraGridColumn6.Header.VisiblePosition = 2
        UltraGridColumn6.Width = 62
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5, UltraGridColumn6})
        Me.cmbSQLServer.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.cmbSQLServer.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.cmbSQLServer.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance2.FontData, "Appearance2.FontData")
        resources.ApplyResources(Appearance2, "Appearance2")
        Appearance2.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance3.FontData, "Appearance3.FontData")
        resources.ApplyResources(Appearance3, "Appearance3")
        Appearance3.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.cmbSQLServer.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        resources.ApplyResources(Appearance4.FontData, "Appearance4.FontData")
        resources.ApplyResources(Appearance4, "Appearance4")
        Appearance4.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.cmbSQLServer.DisplayLayout.MaxColScrollRegions = 1
        Me.cmbSQLServer.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        resources.ApplyResources(Appearance5.FontData, "Appearance5.FontData")
        resources.ApplyResources(Appearance5, "Appearance5")
        Appearance5.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        resources.ApplyResources(Appearance6.FontData, "Appearance6.FontData")
        resources.ApplyResources(Appearance6, "Appearance6")
        Appearance6.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.cmbSQLServer.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.cmbSQLServer.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance7.FontData, "Appearance7.FontData")
        resources.ApplyResources(Appearance7, "Appearance7")
        Appearance7.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        resources.ApplyResources(Appearance8.FontData, "Appearance8.FontData")
        resources.ApplyResources(Appearance8, "Appearance8")
        Appearance8.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.CellAppearance = Appearance8
        Me.cmbSQLServer.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.cmbSQLServer.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Appearance9.FontData, "Appearance9.FontData")
        resources.ApplyResources(Appearance9, "Appearance9")
        Appearance9.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        resources.ApplyResources(Appearance10, "Appearance10")
        resources.ApplyResources(Appearance10.FontData, "Appearance10.FontData")
        Appearance10.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.cmbSQLServer.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.cmbSQLServer.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        resources.ApplyResources(Appearance11.FontData, "Appearance11.FontData")
        resources.ApplyResources(Appearance11, "Appearance11")
        Appearance11.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.RowAppearance = Appearance11
        Me.cmbSQLServer.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Appearance12.FontData, "Appearance12.FontData")
        resources.ApplyResources(Appearance12, "Appearance12")
        Appearance12.ForceApplyResources = "FontData|"
        Me.cmbSQLServer.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.cmbSQLServer.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.cmbSQLServer.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.cmbSQLServer.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.cmbSQLServer.DisplayMember = "SqlServerName"
        resources.ApplyResources(Me.cmbSQLServer, "cmbSQLServer")
        Me.cmbSQLServer.Name = "cmbSQLServer"
        Me.cmbSQLServer.ValueMember = "Path"
        '
        'ProjectManagement
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.cmbSQLServer)
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
        Me.Controls.Add(Me.cmbComanyName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "ProjectManagement"
        CType(Me.UltraDataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ucmbProjectName,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UltraDataSource2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cmbSQLServer,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cmbComanyName As System.Windows.Forms.ComboBox
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
    Friend WithEvents UltraDataSource2 As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents cmbSQLServer As Infragistics.Win.UltraWinGrid.UltraCombo
End Class
