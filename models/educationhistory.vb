Namespace JobStation.Models
    Public Class Educationhistory
        '-----------------Global Declaration-----------------
        Dim _EducationHistoryID As Integer = 0
        Dim _CandidateID As Integer = 0
        Dim _EducationQualificationID As Integer = 0
        Dim _Institute As String = String.Empty
        Dim _CompletionYear As DateTime = "01-01-1900 12:00:00 AM"
        Dim _ExamResult As String = String.Empty
        Dim _CountryID As Integer = 0
        Dim _Description As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property EducationHistoryID() As Integer
            Get
                Return _EducationHistoryID
            End Get
            Set(ByVal value As Integer)
                _EducationHistoryID = value
            End Set
        End Property

        Public Property CandidateID() As Integer
            Get
                Return _CandidateID
            End Get
            Set(ByVal value As Integer)
                _CandidateID = value
            End Set
        End Property

        Public Property EducationQualificationID() As Integer
            Get
                Return _EducationQualificationID
            End Get
            Set(ByVal value As Integer)
                _EducationQualificationID = value
            End Set
        End Property

        Public Property Institute() As String
            Get
                Return _Institute
            End Get
            Set(ByVal value As String)
                _Institute = value
            End Set
        End Property

        Public Property CompletionYear() As DateTime
            Get
                Return _CompletionYear
            End Get
            Set(ByVal value As DateTime)
                _CompletionYear = value
            End Set
        End Property

        Public Property ExamResult() As String
            Get
                Return _ExamResult
            End Get
            Set(ByVal value As String)
                _ExamResult = value
            End Set
        End Property

        Public Property CountryID() As Integer
            Get
                Return _CountryID
            End Get
            Set(ByVal value As Integer)
                _CountryID = value
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
