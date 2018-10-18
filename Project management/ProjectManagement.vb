Imports System.IO

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
            projectName = ucmbProjectName.Value
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

            fileReader = LoadDataToWrite(mainLocation & "ComanyData.txt")
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
            If IsNothing(mainLocation) = False Then
                If mainLocation <> "" Then
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
    End Enum

    Public Enum GetProjectCompanyNames As Integer
        Main_Branch = 1
        Main = 2
        USA_Branch = 3
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
            If ValidatePath(fileLocation) = True Then
                fileReader = File.ReadAllLines(fileLocation)
            End If

            Return fileReader
        Catch ex As Exception
            Return fileReader
        End Try
    End Function

    Sub SetSQLparaNew()
        Try
            Dim fileLocation As String
            Dim fileReader() As String
            Dim dataToWrite As String = ""

            fileLocation = mainLocation & "ComanyData.txt"
            fileReader = LoadDataToWrite(fileLocation)

            For Each line As String In Filter(fileReader, companyName)
                dataToWrite = line
            Next

            fileLocation = ucmbProjectName.Value & "SQLparaNew.txt"
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
            SetSQLparaNew()

            'Set SetSQLpara

            'Load Project
            Dim proc As New System.Diagnostics.Process()
            proc = Process.Start(ucmbProjectName.Value & "SPIL Glass.exe", "")

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

#End Region

    Private Sub ucmbProjectName_RowSelected(sender As Object, e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ucmbProjectName.RowSelected
        Try
            projectName = ucmbProjectName.Value
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
End Class
