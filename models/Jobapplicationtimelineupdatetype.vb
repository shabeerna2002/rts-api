Namespace JobStation.Models
    Public Class Jobapplicationtimelineupdatetype
        '-----------------Global Declaration-----------------
        Dim _TimeLineUpdateTypeID As Integer = 0
        Dim _UpdateType As String = String.Empty
        Dim _ImageURL As String = String.Empty
        Dim _Icon As String = String.Empty
        Dim _isUseImage As Boolean = False
        Dim _DisplayTemplate As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property TimeLineUpdateTypeID() As Integer
            Get
                Return _TimeLineUpdateTypeID
            End Get
            Set(ByVal value As Integer)
                _TimeLineUpdateTypeID = value
            End Set
        End Property

        Public Property UpdateType() As String
            Get
                Return _UpdateType
            End Get
            Set(ByVal value As String)
                _UpdateType = value
            End Set
        End Property

        Public Property ImageURL() As String
            Get
                Return _ImageURL
            End Get
            Set(ByVal value As String)
                _ImageURL = value
            End Set
        End Property

        Public Property Icon() As String
            Get
                Return _Icon
            End Get
            Set(ByVal value As String)
                _Icon = value
            End Set
        End Property

        Public Property isUseImage() As Boolean
            Get
                Return _isUseImage
            End Get
            Set(ByVal value As Boolean)
                _isUseImage = value
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
