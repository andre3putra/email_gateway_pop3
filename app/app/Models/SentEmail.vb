
Namespace Models

    Public Class SentEmail

        Public ListData As New List(Of SentEmail)

        Dim _EmailID As String

        Public Property EmailID() As String
            Get
                Return _EmailID
            End Get
            Set(ByVal value As String)
                _EmailID = value
            End Set
        End Property

    End Class

End Namespace


