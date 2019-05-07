Namespace Models

    Public Class InEmailAttachment

        Public ListData As New List(Of InEmailAttachment)

        Dim _EmailID As String

        Public Property EmailID() As String
            Get
                Return _EmailID
            End Get
            Set(ByVal value As String)
                _EmailID = value
            End Set
        End Property

        Dim _Path As String

        Public Property Path() As String
            Get
                Return _Path
            End Get
            Set(ByVal value As String)
                _Path = value
            End Set
        End Property

    End Class

End Namespace


