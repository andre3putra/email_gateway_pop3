Public Class AppSession

    Public Shared App As AppSession

    Public Shared Function ProgramSession() As AppSession

        If App Is Nothing Then
            App = New AppSession
        End If

        Return App
    End Function

    Public Setting As New Controllers.SettingController

End Class
