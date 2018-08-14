Namespace JobStation.Models
    Public Class Employeerequest
        '-----------------Global Declaration-----------------
        Dim _EmployeeRequestID As Integer = 0
        Dim _RefNo As String = String.Empty
        Dim _ExternalRefNo As String = String.Empty
        Dim _RequestedByUserID As Integer = 0
        Dim _RequestedOn As DateTime = "01-01-1900 12:00:00 AM"
        Dim _RequestingDepartment As Integer = 0
        Dim _PositionName As String = String.Empty
        Dim _PositionTypeID As Integer = 0
        Dim _NoOfEmployeeRequired As Integer = 0
        Dim _VacantSince As DateTime = "01-01-1900 12:00:00 AM"
        Dim _TargetJoiningDate As DateTime = "01-01-1900 12:00:00 AM"
        Dim _PrefferedAgeRange As String = String.Empty
        Dim _BudgetStatus As String = String.Empty
        Dim _Justification As String = String.Empty
        Dim _RecommendedRecruitmentSource As String = String.Empty
        Dim _Status As String = String.Empty
        Dim _isInActive As Boolean = False
        Dim _SessionID As Integer = 0
        Dim _TransactionKey As String = String.Empty
        Dim _UpdatedBy As String = String.Empty
        Dim _UpdatedOn As DateTime = "01-01-1900 12:00:00 AM"
        '-----------------------------------------


        '*****************Properties****************
        Public Property EmployeeRequestID() As Integer
            Get
                Return _EmployeeRequestID
            End Get
            Set(ByVal value As Integer)
                _EmployeeRequestID = value
            End Set
        End Property

        Public Property RefNo() As String
            Get
                Return _RefNo
            End Get
            Set(ByVal value As String)
                _RefNo = value
            End Set
        End Property

        Public Property ExternalRefNo() As String
            Get
                Return _ExternalRefNo
            End Get
            Set(ByVal value As String)
                _ExternalRefNo = value
            End Set
        End Property

        Public Property RequestedByUserID() As Integer
            Get
                Return _RequestedByUserID
            End Get
            Set(ByVal value As Integer)
                _RequestedByUserID = value
            End Set
        End Property

        Public Property RequestedOn() As DateTime
            Get
                Return _RequestedOn
            End Get
            Set(ByVal value As DateTime)
                _RequestedOn = value
            End Set
        End Property

        Public Property RequestingDepartment() As Integer
            Get
                Return _RequestingDepartment
            End Get
            Set(ByVal value As Integer)
                _RequestingDepartment = value
            End Set
        End Property

        Public Property PositionName() As String
            Get
                Return _PositionName
            End Get
            Set(ByVal value As String)
                _PositionName = value
            End Set
        End Property

        Public Property PositionTypeID() As Integer
            Get
                Return _PositionTypeID
            End Get
            Set(ByVal value As Integer)
                _PositionTypeID = value
            End Set
        End Property

        Public Property NoOfEmployeeRequired() As Integer
            Get
                Return _NoOfEmployeeRequired
            End Get
            Set(ByVal value As Integer)
                _NoOfEmployeeRequired = value
            End Set
        End Property

        Public Property VacantSince() As DateTime
            Get
                Return _VacantSince
            End Get
            Set(ByVal value As DateTime)
                _VacantSince = value
            End Set
        End Property

        Public Property TargetJoiningDate() As DateTime
            Get
                Return _TargetJoiningDate
            End Get
            Set(ByVal value As DateTime)
                _TargetJoiningDate = value
            End Set
        End Property

        Public Property PrefferedAgeRange() As String
            Get
                Return _PrefferedAgeRange
            End Get
            Set(ByVal value As String)
                _PrefferedAgeRange = value
            End Set
        End Property

        Public Property BudgetStatus() As String
            Get
                Return _BudgetStatus
            End Get
            Set(ByVal value As String)
                _BudgetStatus = value
            End Set
        End Property

        Public Property Justification() As String
            Get
                Return _Justification
            End Get
            Set(ByVal value As String)
                _Justification = value
            End Set
        End Property

        Public Property RecommendedRecruitmentSource() As String
            Get
                Return _RecommendedRecruitmentSource
            End Get
            Set(ByVal value As String)
                _RecommendedRecruitmentSource = value
            End Set
        End Property

        Public Property Status() As String
            Get
                Return _Status
            End Get
            Set(ByVal value As String)
                _Status = value
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
