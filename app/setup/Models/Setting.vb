Namespace Models

    Public Class Setting

        Public ListData As New List(Of Setting)

        Dim _ServerAddress As String

        Public Property ServerAddress() As String
            Get
                Return _ServerAddress
            End Get
            Set(ByVal value As String)
                _ServerAddress = value
            End Set
        End Property

        Dim _ServerDatabase As String

        Public Property ServerDatabase() As String
            Get
                Return _ServerDatabase
            End Get
            Set(ByVal value As String)
                _ServerDatabase = value
            End Set
        End Property

        Dim _ServerUserLogin As String

        Public Property ServerUserLogin() As String
            Get
                Return _ServerUserLogin
            End Get
            Set(ByVal value As String)
                _ServerUserLogin = value
            End Set
        End Property

        Dim _ServerPassword As String

        Public Property ServerPassword() As String
            Get
                Return _ServerPassword
            End Get
            Set(ByVal value As String)
                _ServerPassword = value
            End Set
        End Property

        Dim _IncomingAccountName As String

        Public Property IncomingAccountName() As String
            Get
                Return _IncomingAccountName
            End Get
            Set(ByVal value As String)
                _IncomingAccountName = value
            End Set
        End Property

        Dim _IncomingPassword As String

        Public Property IncomingPassword() As String
            Get
                Return _IncomingPassword
            End Get
            Set(ByVal value As String)
                _IncomingPassword = value
            End Set
        End Property

        Dim _IncomingServer As String

        Public Property IncomingServer() As String
            Get
                Return _IncomingServer
            End Get
            Set(ByVal value As String)
                _IncomingServer = value
            End Set
        End Property

        Dim _IncomingPort As Integer

        Public Property IncomingPort() As Integer
            Get
                Return _IncomingPort
            End Get
            Set(ByVal value As Integer)
                _IncomingPort = value
            End Set
        End Property

        Dim _EncryptedConnection As Boolean

        Public Property EncryptedConnection() As Boolean
            Get
                Return _EncryptedConnection
            End Get
            Set(ByVal value As Boolean)
                _EncryptedConnection = value
            End Set
        End Property

        Dim _OutgoingAccountName As String

        Public Property OutgoingAccountName() As String
            Get
                Return _OutgoingAccountName
            End Get
            Set(ByVal value As String)
                _OutgoingAccountName = value
            End Set
        End Property

        Dim _OutgoingPassword As String

        Public Property OutgoingPassword() As String
            Get
                Return _OutgoingPassword
            End Get
            Set(ByVal value As String)
                _OutgoingPassword = value
            End Set
        End Property

        Dim _OutgoingServer As String

        Public Property OutgoingServer() As String
            Get
                Return _OutgoingServer
            End Get
            Set(ByVal value As String)
                _OutgoingServer = value
            End Set
        End Property

        Dim _OutgoingPort As Integer

        Public Property OutgoingPort() As Integer
            Get
                Return _OutgoingPort
            End Get
            Set(ByVal value As Integer)
                _OutgoingPort = value
            End Set
        End Property

        Dim _LeaveEmailOnServer As Boolean

        Public Property LeaveEmailOnServer() As Boolean
            Get
                Return _LeaveEmailOnServer
            End Get
            Set(ByVal value As Boolean)
                _LeaveEmailOnServer = value
            End Set
        End Property

        Dim _IncomingBackUp As String

        Public Property IncomingBackUp() As String
            Get
                Return _IncomingBackUp
            End Get
            Set(ByVal value As String)
                _IncomingBackUp = value
            End Set
        End Property

        Dim _OutgoingBackUp As String

        Public Property OutgoingBackUp() As String
            Get
                Return _OutgoingBackUp
            End Get
            Set(ByVal value As String)
                _OutgoingBackUp = value
            End Set
        End Property

    End Class

End Namespace
