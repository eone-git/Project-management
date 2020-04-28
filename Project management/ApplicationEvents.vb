Namespace My
  
  Partial Friend Class MyApplication

    Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
      'Show the language select dialog
      Dim frmLang As New SelectLanguage
      frmLang.LoadSettingsAndShow
      frmLang.Dispose
      frmLang = Nothing
    End Sub

  End Class
  
End Namespace
