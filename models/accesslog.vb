Namespace JobStation.Models
    Public Class Accesslog
        '-----------------Global Declaration-----------------
        Dim _AccessLogID As Integer = 0
        Dim _PageID As Integer = 0
        Dim _UserID As Integer = 0
        Dim _Action As String = String.Empty
        Dim _Description As String = String.Empty
        Dim _ActivityOn As DateTime = "01-01-1900 12:00:00 AM"
        Dim _IPAddress As String = String.Empty
        Dim _UserAgent As String = String.Empty
        Dim _UserHost As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property AccessLogID() As Integer
            Get
                Return _AccessLogID
            End Get
            Set(ByVal value As Integer)
                _AccessLogID = value
            End Set
        End Property

        Public Property PageID() As Integer
            Get
                Return _PageID
            End Get
            Set(ByVal value As Integer)
                _PageID = value
            End Set
        End Property

        Public Property UserID() As Integer
            Get
                Return _UserID
            End Get
            Set(ByVal value As Integer)
                _UserID = value
            End Set
        End Property

        Public Property Action() As String
            Get
                Return _Action
            End Get
            Set(ByVal value As String)
                _Action = value
            End Set
        End Property

        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)
                _Description = value
            End Set
        End Property

        Public Property ActivityOn() As DateTime
            Get
                Return _ActivityOn
            End Get
            Set(ByVal value As DateTime)
                _ActivityOn = value
            End Set
        End Property

        Public Property IPAddress() As String
            Get
                Return _IPAddress
            End Get
            Set(ByVal value As String)
                _IPAddress = value
            End Set
        End Property

        Public Property UserAgent() As String
            Get
                Return _UserAgent
            End Get
            Set(ByVal value As String)
                _UserAgent = value
            End Set
        End Property

        Public Property UserHost() As String
            Get
                Return _UserHost
            End Get
            Set(ByVal value As String)
                _UserHost = value
            End Set
        End Property

        Public Property isInActive() As Boolean
            Get
                Return _isInActive
            End Get
            Set(ByVal value As Boolean)
                _isInActive = value
            End Set
        End Property

        Public Property SessionID() As Integer
            Get
                Return _SessionID
            End Get
            Set(ByVal value As Integer)
                _SessionID = value
            End Set
        End Property

        Public Property TransactionKey() As String
            Get
                Return _TransactionKey
            End Get
            Set(ByVal value As String)
                _TransactionKey = value
            End Set
        End Property

        Public Property UpdatedBy() As String
            Get
                Return _UpdatedBy
            End Get
            Set(ByVal value As String)
                _UpdatedBy = value
            End Set
        End Property

        Public Property UpdatedOn() As DateTime
            Get
                Return _UpdatedOn
            End Get
            Set(ByVal value As DateTime)
                _UpdatedOn = value
            End Set
        End Property

        '*******************************
    End Class
End Namespace

