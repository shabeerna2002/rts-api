Namespace JobStation.Models
    Public Class Request
        '-----------------Global Declaration-----------------
        Dim _RequestID As Integer = 0
        Dim _ApplicationID As Integer = 0
        Dim _DateRequested As DateTime = "01-01-1900 12:00:00 AM"
        Dim _RequesterUserID As Integer = 0
        Dim _CurrentStateID As Integer = 0
        Dim _isCurrentStatePartialUpdated As Boolean = False
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property RequestID() As Integer
            Get
                Return _RequestID
            End Get
            Set(ByVal value As Integer)
                _RequestID = value
            End Set
        End Property

        Public Property ApplicationID() As Integer
            Get
                Return _ApplicationID
            End Get
            Set(ByVal value As Integer)
                _ApplicationID = value
            End Set
        End Property

        Public Property DateRequested() As DateTime
            Get
                Return _DateRequested
            End Get
            Set(ByVal value As DateTime)
                _DateRequested = value
            End Set
        End Property

        Public Property RequesterUserID() As Integer
            Get
                Return _RequesterUserID
            End Get
            Set(ByVal value As Integer)
                _RequesterUserID = value
            End Set
        End Property

        Public Property CurrentStateID() As Integer
            Get
                Return _CurrentStateID
            End Get
            Set(ByVal value As Integer)
                _CurrentStateID = value
            End Set
        End Property

        Public Property isCurrentStatePartialUpdated() As Boolean
            Get
                Return _isCurrentStatePartialUpdated
            End Get
            Set(ByVal value As Boolean)
                _isCurrentStatePartialUpdated = value
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
