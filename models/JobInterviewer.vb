Namespace JobStation.Models
    Public Class JobInterviewer
        '-----------------Global Declaration-----------------
        Dim _InterviewerID As Integer = 0
        Dim _VacancyID As Integer = 0
        Dim _InterviewerUserID As Integer = 0
        Dim _isMandatory As Boolean = False
        Dim _isEvaluator As Boolean = False
        Dim _Description As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property InterviewerID() As Integer
            Get
                Return _InterviewerID
            End Get
            Set(ByVal value As Integer)
                _InterviewerID = value
            End Set
        End Property

        Public Property VacancyID() As Integer
            Get
                Return _VacancyID
            End Get
            Set(ByVal value As Integer)
                _VacancyID = value
            End Set
        End Property

        Public Property InterviewerUserID() As Integer
            Get
                Return _InterviewerUserID
            End Get
            Set(ByVal value As Integer)
                _InterviewerUserID = value
            End Set
        End Property

        Public Property isMandatory() As Boolean
            Get
                Return _isMandatory
            End Get
            Set(ByVal value As Boolean)
                _isMandatory = value
            End Set
        End Property

        Public Property isEvaluator() As Boolean
            Get
                Return _isEvaluator
            End Get
            Set(ByVal value As Boolean)
                _isEvaluator = value
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
