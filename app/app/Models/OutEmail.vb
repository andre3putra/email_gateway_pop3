Namespace Models

    Public Class OutEmail

        Public ListData As New List(Of OutEmail)

        Dim _ID As String
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property

        Dim _EFROM As String
        Public Property EFROM() As String
            Get
                Return _EFROM
            End Get
            Set(ByVal value As String)
                _EFROM = value
            End Set
        End Property

        Dim _ETO As String
        Public Property ETO() As String
            Get
                Return _ETO
            End Get
            Set(ByVal value As String)
                _ETO = value
            End Set
        End Property

        Dim _ECC As String
        Public Property ECC() As String
            Get
                Return _ECC
            End Get
            Set(ByVal value As String)
                _ECC = value
            End Set
        End Property

        Dim _EBCC As String
        Public Property EBCC() As String
            Get
                Return _EBCC
            End Get
            Set(ByVal value As String)
                _EBCC = value
            End Set
        End Property

        Dim _ESUBJECT As String
        Public Property ESUBJECT() As String
            Get
                Return _ESUBJECT
            End Get
            Set(ByVal value As String)
                _ESUBJECT = value
            End Set
        End Property

        Dim _EBODYTEXT As String
        Public Property EBODYTEXT() As String
            Get
                Return _EBODYTEXT
            End Get
            Set(ByVal value As String)
                _EBODYTEXT = value
            End Set
        End Property

        Dim _EBODYHTML As String
        Public Property EBODYHTML() As String
            Get
                Return _EBODYHTML
            End Get
            Set(ByVal value As String)
                _EBODYHTML = value
            End Set
        End Property

        Dim _EATTACHMENT As String
        Public Property EATTACHMENT() As String
            Get
                Return _EATTACHMENT
            End Get
            Set(ByVal value As String)
                _EATTACHMENT = value
            End Set
        End Property

    End Class

End Namespace

