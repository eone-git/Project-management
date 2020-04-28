Imports System.IO
Imports System.Data.SqlClient

Public Class ProjectManagement

#Region "Varables"

    Dim mainLocation As String
    Dim currentCompanyNames As String
    Dim projectName As String
    Dim sqlName As String
    Dim companyName As String
    Dim exeName As String
    Dim projectNames() As String

    'Dim databaseName As String
    'Dim serverName As String
    'Dim userId As String
    'Dim password As String
    'Dim databaseSettingsPath As String
    'Dim constaring As String = ""

#End Region
#Region "CRUD"

    Sub Load()
        Try
            LoadFormOpeningData()
        Catch ex As Exception

        End Try
    End Sub

    Sub Save()
        Try

        Catch ex As Exception

        End Try
    End Sub


#End Region
#Region "Load Componenet Data"

    Sub LoadFormOpeningData()
        Try
            LoadVariableData()
            LoadCompanyNames()
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadVariableData()
        Try
            projectName = ucmbProjectName.Value & "\"
            sqlName = cmbSQLServer.ValueMember
            companyName = cmbComanyName.ValueMember
            exeName = cmbExe.ValueMember
            mainLocation = "D:\SPIL Glass Main Projects\SPIL Glass Branch For Live\SPIL Glass\SPIL_Glass\bin\Debug\"
            ucmbProjectName.Text = "Main Branch"
            ucmbProjectName.Focus()

        Catch ex As Exception

        End Try
    End Sub

    Sub LoadCompanyNames()
        Try
            Dim fileReader() As String
            Dim nameList As New List(Of String)
            Dim words As String()
            Dim isDuplicate As Boolean = False

            fileReader = LoadDataToWrite(projectName & "ComanyData.txt")
            For Each line In fileReader
                words = line.Split(New Char() {","c})
                If words(0) <> "" Then
                    For Each subLine In nameList
                        If subLine = words(0) Then
                            isDuplicate = True
                        Else
                            isDuplicate = False
                        End If
                    Next
                    If isDuplicate = False Then
                        nameList.Add(words(0))
                    End If

                End If
            Next
            cmbComanyName.DataSource = nameList

        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Validations"

    Sub ValidateBasicData()
        Dim isLocationExsits As Boolean = False
        Try
            If IsNothing(projectName) = False Then
                If projectName <> "" Then
                    isLocationExsits = True
                End If
            End If

            If isLocationExsits = False Then

            End If


        Catch ex As Exception

        End Try
    End Sub

#End Region
#Region "Extra"

    Private Sub FillConnectionData()
        Try
            'databaseName = If(IsNothing(txtDatabase.Text) = True, "", txtDatabase.Text)
            'serverName = If(IsNothing(txtServer.Text) = True, "", txtServer.Text)
            'userId = If(IsNothing(txtUserId.Text) = True, "", txtUserId.Text)
            'password = If(IsNothing(txtPassword.Text) = True, "", txtPassword.Text)
            'databaseSettingsPath = Application.StartupPath & "\DatabaseSettings.txt"
            'constaring = "Server=" & serverName & ";Database=" & databaseName & ";User Id=" & serverName & ";Password = " & password & ";"

        Catch ex As Exception

        End Try
    End Sub

    Function ValidatePath(ByRef path As String) As Boolean
        Try
            If System.IO.File.Exists(path) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Sub CustomersDetails()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Enum GetProjectName As Integer
        Main_Branch = 1
        Main = 2
        USA_Branch = 3
        Spil_Lite = 4
    End Enum

    Public Enum GetProjectCompanyNames As Integer
        Main_Branch = 1
        Main = 2
        USA_Branch = 3
        Spil_Lite = 4
    End Enum

#End Region
#Region "Functions"

    '''<summary> 
    '''Genaral file reader
    ''' </summary>
    Function LoadDataToWrite(ByRef fileLocation As String) As String()
        Dim fileReader() As String = Nothing
        Dim reComanyDetails As String = ""
        Dim hasValue As Boolean = False
        Try
            fileReader = File.ReadAllLines(fileLocation)
            Return fileReader
        Catch ex As Exception
            Return fileReader
        End Try
    End Function

    Sub CreateComanyDataFile()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Sub SetSQLparaNew(ByRef targetFile As String, Optional ByRef referenceFile As String = "")
        Try
            Dim fileLocation As String
            Dim fileReader() As String = Nothing
            Dim dataToWrite As String = ""
            Dim hasReference As Boolean = True

            'If hasReference = "" Then
            '    hasReference = False
            'End If

            fileLocation = projectName & referenceFile
            If ValidatePath(fileLocation) = True Then
                fileReader = LoadDataToWrite(fileLocation)
            Else
                fileLocation = projectName & targetFile
                If ValidatePath(fileLocation) = True Then
                    fileReader = LoadDataToWrite(fileLocation)
                End If
                fileLocation = projectName & referenceFile
                System.IO.File.WriteAllLines(fileLocation, fileReader)
            End If

            For Each line As String In Filter(fileReader, companyName)
                dataToWrite = line
            Next

            fileLocation = ucmbProjectName.Value & targetFile
            WriteDataToFile(dataToWrite, fileLocation)

        Catch ex As Exception

        End Try
    End Sub

    Sub SetSQLPara()
        Try

        Catch ex As Exception

        End Try
    End Sub

    '''<summary> 
    '''Genaral file writer
    '''</summary>
    ''' 
    Sub WriteDataToFile(ByRef dataToWrite As String, ByRef fileLocation As String)
        Try
            System.IO.File.WriteAllText(fileLocation, dataToWrite)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadProject()
        Try
            'Set SetSQLparaNew        
            SetSQLparaNew("SQLparaNew.txt", "ComanyData.txt")

            'Set SetSQLpara

            'Load Project
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(ucmbProjectName.Value & "\SPIL Glass.exe", "")

        Catch ex As Exception

        End Try
    End Sub

    Sub RunTheSPUIlGlass()
        Dim pathArray() As String
        Dim mainPathForProject As String = ucmbProjectName.Value
        Dim path As String = ""
        Dim proc As New System.Diagnostics.Process()
        Dim pathArrayCount As Integer
        Dim counter As Integer = 0
        Dim fileName() As String
        Try
            pathArray = mainPathForProject.Split(New Char() {"\"c})
            pathArrayCount = pathArray.Count

            For Each item As String In pathArray
                If counter < pathArrayCount - 5 Then
                    path = path & item & "\"
                Else
                    Exit For
                End If
                counter = counter + 1
            Next

            fileName = FindTheFileName(path)
            proc = Process.Start(fileName(0), "")
        Catch ex As Exception

        End Try
    End Sub

    Function FindTheFileName(ByRef path As String) As String()
        Dim files() As String = Nothing
        Try
            files = Directory.GetFiles(path, "*.sln", SearchOption.TopDirectoryOnly)
            Return files
        Catch ex As Exception
            Return files
        End Try
    End Function

#End Region
#Region "Componets Events"

    Private Sub ProjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load()
    End Sub

    Private Sub ProjectManagement_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btnLoadProject_Click(sender As Object, e As EventArgs) Handles btnLoadProject.Click
        companyName = cmbComanyName.Text
        RunTheSPUIlGlass()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("cmd.exe", "/k sqllocaldb STOP " & Chr(34) & "SQL SERVER 2017" & Chr(34))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("cmd.exe", "/k sqllocaldb START " & Chr(34) & "SQL SERVER 2017" & Chr(34))
    End Sub

    Private Sub ucmbProjectName_RowSelected(sender As Object, e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ucmbProjectName.RowSelected
        Try
            projectName = e.Row.Cells("path").Value & "\"
            LoadCompanyNames()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ucmbProjectName_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ucmbProjectName.InitializeLayout
        ucmbProjectName.DisplayLayout.Bands(0).ColHeadersVisible = False
        ucmbProjectName.DisplayLayout.Bands(0).Columns(0).Hidden = True
        ucmbProjectName.DisplayLayout.Bands(0).Columns(2).Hidden = True
    End Sub

    Private Sub btnRunProgram_Click(sender As Object, e As EventArgs) Handles btnRunProgram.Click
        Try
            companyName = cmbComanyName.Text
            LoadProject()
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Function GetProjectNames() As String
        Dim allProjectNames As String = ""
        Try
            For Each item As String In Directory.GetDirectories("c:\Program Files")
                If allProjectNames = "" Then
                    allProjectNames = item
                Else
                    allProjectNames = allProjectNames & "," & item
                End If
            Next
            Return allProjectNames
        Catch ex As Exception
            Return allProjectNames
        End Try
    End Function

    Sub setPrjectNamesTo()
        Try
            Dim prjectsList() As String
            prjectsList = GetProjectNames().Split(New Char() {","c})
        Catch ex As Exception

        End Try
    End Sub

    Sub ResuoreDatabse()
        Try
            Dim sql As String = "RESTORE DATABASE [Northwind] " & _
                                 "FROM DISK = N'C:SQL Server DatabasesNorthwind.bak' " & _
                                 "WITH FILE = 1," & _
                                 "Move N'Northwind' TO N'C:SQLNorthwind.mdf'," & _
                                 "Move N'Northwind_log' TO N'C:SQLNorthwind_1.ldf'," & _
                                 "NOUNLOAD, STATS = 10"

            Dim cn As SqlConnection = New SqlConnection("Data Source=rrehak;Initial Catalog=master;Integrated Security=SSPI;")
            cn.Open()
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

        End Try
    End Sub

    Sub SetSQLPath()
        Try

        Catch ex As Exception

        End Try
    End Sub




End Class
