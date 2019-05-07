
Namespace Models

    Public Class InEmail

        Public Attachment As New List(Of InEmailAttachment)

        Public ListData As New List(Of InEmail)

        Dim _EmailID As String

        Public Property EmailID() As String
            Get
                Return _EmailID
            End Get
            Set(ByVal value As String)
                _EmailID = value
            End Set
        End Property

        Dim _EmailFrom As String

        Public Property EmailFrom() As String
            Get
                Return _EmailFrom
            End Get
            Set(ByVal value As String)
                _EmailFrom = value
            End Set
        End Property

        Dim _EmailTo As String

        Public Property EmailTo() As String
            Get
                Return _EmailTo
            End Get
            Set(ByVal value As String)
                _EmailTo = value
            End Set
        End Property

        Dim _EmailCc As String

        Public Property EmailCc() As String
            Get
                Return _EmailCc
            End Get
            Set(ByVal value As String)
                _EmailCc = value
            End Set
        End Property

        Dim _EmailBcc As String

        Public Property EmailBcc() As String
            Get
                Return _EmailBcc
            End Get
            Set(ByVal value As String)
                _EmailBcc = value
            End Set
        End Property

        Dim _EmailSubject As String

        Public Property EmailSubject() As String
            Get
                Return _EmailSubject
            End Get
            Set(ByVal value As String)
                _EmailSubject = value
            End Set
        End Property

        Dim _EmailBodyText As String

        Public Property EmailBodyText() As String
            Get
                Return _EmailBodyText
            End Get
            Set(ByVal value As String)
                _EmailBodyText = value
            End Set
        End Property

        Dim _EmailBodyHtml As String

        Public Property EmailBodyHtml() As String
            Get
                Return _EmailBodyHtml
            End Get
            Set(ByVal value As String)
                _EmailBodyHtml = value
            End Set
        End Property

        Dim _EmailSentDate As DateTime

        Public Property EmailSentDate() As DateTime
            Get
                Return _EmailSentDate
            End Get
            Set(ByVal value As DateTime)
                _EmailSentDate = value
            End Set
        End Property

        Dim _EmailSize As String

        Public Property EmailSize() As String
            Get
                Return _EmailSize
            End Get
            Set(ByVal value As String)
                _EmailSize = value
            End Set
        End Property

        Dim _TicketNo As String

        Public Property TicketNo() As String
            Get
                Return _TicketNo
            End Get
            Set(ByVal value As String)
                _TicketNo = value
            End Set
        End Property

    End Class

End Namespace


