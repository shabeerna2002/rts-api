Namespace JobStation.Models
    Public Class Vacancy
        '-----------------Global Declaration-----------------
        Dim _VacancyID As Integer = 0
        Dim _ProcessID As Integer = 0
        Dim _OpenPositions As Integer = 0
        Dim _DesignationID As Integer = 0
        Dim _Title As String = String.Empty
        Dim _JobDescription As String = String.Empty
        Dim _JobSkill As String = String.Empty
        Dim _JobDuty As String = String.Empty
        Dim _EducationInfo As String = String.Empty
        Dim _NationalityInfo As String = String.Empty
        Dim _ClosingDate As DateTime = "01-01-1900 12:00:00 AM"
        Dim _OpeningDate As DateTime = "01-01-1900 12:00:00 AM"
        Dim _isPublished As Boolean = False
        Dim _isClosed As Boolean = False
        Dim _StatusID As Integer = 0
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property VacancyID() As Integer
            Get
                Return _VacancyID
            End Get
            Set(ByVal value As Integer)
                _VacancyID = value
            End Set
        End Property

        Public Property ProcessID() As Integer
            Get
                Return _ProcessID
            End Get
            Set(ByVal value As Integer)
                _ProcessID = value
            End Set
        End Property

        Public Property OpenPositions() As Integer
            Get
                Return _OpenPositions
            End Get
            Set(ByVal value As Integer)
                _OpenPositions = value
            End Set
        End Property

        Public Property DesignationID() As Integer
            Get
                Return _DesignationID
            End Get
            Set(ByVal value As Integer)
                _DesignationID = value
            End Set
        End Property

        Public Property Title() As String
            Get
                Return _Title
            End Get
            Set(ByVal value As String)
                _Title = value
            End Set
        End Property

        Public Property JobDescription() As String
            Get
                Return _JobDescription
            End Get
            Set(ByVal value As String)
                _JobDescription = value
            End Set
        End Property

        Public Property JobSkill() As String
            Get
                Return _JobSkill
            End Get
            Set(ByVal value As String)
                _JobSkill = value
            End Set
        End Property

        Public Property JobDuty() As String
            Get
                Return _JobDuty
            End Get
            Set(ByVal value As String)
                _JobDuty = value
            End Set
        End Property

        Public Property EducationInfo() As String
            Get
                Return _EducationInfo
            End Get
            Set(ByVal value As String)
                _EducationInfo = value
            End Set
        End Property

        Public Property NationalityInfo() As String
            Get
                Return _NationalityInfo
            End Get
            Set(ByVal value As String)
                _NationalityInfo = value
            End Set
        End Property

        Public Property ClosingDate() As DateTime
            Get
                Return _ClosingDate
            End Get
            Set(ByVal value As DateTime)
                _ClosingDate = value
            End Set
        End Property

        Public Property OpeningDate() As DateTime
            Get
                Return _OpeningDate
            End Get
            Set(ByVal value As DateTime)
                _OpeningDate = value
            End Set
        End Property

        Public Property isPublished() As Boolean
            Get
                Return _isPublished
            End Get
            Set(ByVal value As Boolean)
                _isPublished = value
            End Set
        End Property

        Public Property isClosed() As Boolean
            Get
                Return _isClosed
            End Get
            Set(ByVal value As Boolean)
                _isClosed = value
            End Set
        End Property

        Public Property StatusID() As Integer
            Get
                Return _StatusID
            End Get
            Set(ByVal value As Integer)
                _StatusID = value
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
