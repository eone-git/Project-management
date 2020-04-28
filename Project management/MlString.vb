Imports System.Resources
Imports System.Reflection
Imports System.Globalization
Imports System.ComponentModel

Module MLString

  Private RootNamespace As String = "Project_management" 'MLHIDE
  Private ResMgr        as ResourceManager

  Sub New()
    If RootNamespace.Length > 0 Then
      ResMgr = New ResourceManager ( RootNamespace & ".MultiLang", [Assembly].GetExecutingAssembly )   'MLHIDE
    Else
      ResMgr = New ResourceManager ( "MultiLang", [Assembly].GetExecutingAssembly )                    'MLHIDE
    End If
  End Sub

  Public Sub ml_UseCulture ( Byval ci as CultureInfo )
    System.Threading.Thread.CurrentThread.CurrentUICulture = ci 
  End Sub  

  Public Function ml_string(ByVal StringID As Integer, Optional ByVal Text As String = "") As String   'MLHIDE
    return ml_resource ( StringID )
  End Function

  Public Function ml_resource(ByVal StringID As Integer) As String'MLHIDE
    return ResMgr.GetString ( "_" & StringID.ToString() )                                              'MLHIDE
  End Function

  Public SupportedCultures() As String = { "en-US", "pt", "si" } 'MLHIDE
End Module
