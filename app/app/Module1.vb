Imports System.IO

Module Module1

    Public RootID As String = Nothing

    Public Const LICENSE_GET_EGKey As String = "EG-B1374632949-00374-24AA866531F5D7V7-E92354EA576EEBF6"
    Public Const LICENSE_SEND_EGKey As String = "ES-B1331025340-00136-F77D588UDAF22BVT-B8TE81C87E3B46FU"

    'Public _AttachmentListData As New List(Of String)

    Public Function CurrentUser() As String

        Dim parts() As String = Split(My.User.Name, "\")
        CurrentUser = parts(1)

        Return CurrentUser
    End Function

    Public Function IsNull(ByVal Text As String) As String
        IsNull = Nothing

        If Text = Nothing Then
            IsNull = ""
        Else
            IsNull = Text
        End If

        Return IsNull
    End Function

    Public Sub LogIt(ByVal LogID As String, ByVal LogMessage As String)

        If Not Directory.Exists(AppDomain.CurrentDomain.BaseDirectory & "\Log\" & Format(Now, "yyyyMM") & "\") Then
            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory & "\Log\" & Format(Now, "yyyyMM") & "\")
        End If

        'check the file
        Dim fs As FileStream = New FileStream(AppDomain.CurrentDomain.BaseDirectory & "\Log\" & "\" & Format(Now, "yyyyMM") & "\" & Format(Now, "dd-MM-yyyy") & ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim s As StreamWriter = New StreamWriter(fs)
        s.Close()
        fs.Close()

        'Write Error Log into errlog.txt
        Dim fs1 As FileStream = New FileStream(AppDomain.CurrentDomain.BaseDirectory & "\Log\" & "\" & Format(Now, "yyyyMM") & "\" & Format(Now, "dd-MM-yyyy") & ".txt", FileMode.Append, FileAccess.Write)
        Dim s1 As StreamWriter = New StreamWriter(fs1)

        Dim TimelogIt As String = Format(Now, "yyyy-MM-dd HH: mm:ss")

        s1.Write(TimelogIt & vbTab & CurrentUser() & vbTab & LogID & vbTab & LogMessage & vbCrLf)

        s1.Close()
        fs1.Close()

    End Sub

    Public Function CleanEmail(ByVal email As String) As String

        Dim newEmail, check As String

        newEmail = Nothing

        check = 0

        For Each a In email

            If (a = ">") Then
                check = 0
            End If

            If check = 1 Then
                newEmail = newEmail + a
            End If

            If (a = "<") Then
                check = 1
            End If

        Next

        newEmail = Replace(newEmail, " ", "")

        Return newEmail
    End Function

    Public Function GetTiketNo(ByVal words As String) As String

        Dim TiketNo, check As String

        TiketNo = Nothing

        check = 0

        For Each a In words

            If (a = "]") Then
                check = 0
            End If

            If check = 1 Then
                TiketNo = TiketNo + a
            End If

            If (a = "[") Then
                check = 1
            End If

        Next

        TiketNo = Replace(TiketNo, " ", "")

        Return TiketNo
    End Function

End Module
