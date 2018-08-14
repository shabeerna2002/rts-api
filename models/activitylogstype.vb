Namespace JobStation.Models
    Public Class Activitylogstype
        '-----------------Global Declaration-----------------
        Dim _TypeID As Integer = 0
        Dim _LogType As String = String.Empty
        Dim _DisplayTemplate As String = String.Empty
        Dim _Description As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property TypeID() As Integer
            Get
                Return _TypeID
            End Get
            Set(ByVal value As Integer)
                _TypeID = value
            End Set
        End Property

        Public Property LogType() As String
            Get
                Return _LogType
            End Get
            Set(ByVal value As String)
                _LogType = value
            End Set
        End Property

        Public Property DisplayTemplate() As String
            Get
                Return _DisplayTemplate
            End Get
            Set(ByVal value As String)
                _DisplayTemplate = value
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
