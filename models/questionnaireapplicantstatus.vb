Namespace JobStation.Models
 Public Class Questionnaireapplicantstatus
'-----------------Global Declaration-----------------
Dim _CandidateID as Integer = 0
Dim _VacancyID as Integer = 0
Dim _isPass as BOOLEAN = False
Dim _TotalPassMarks as Integer = 0
Dim _MarksSecured as Integer = 0
Dim _isWeightageBasedOnMustAnswerRight as BOOLEAN = False
Dim _isAllWeightageBasedOnAnswersRigthAnswered as BOOLEAN = False
Dim _Remarks as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CandidateID() As Integer
Get
Return _CandidateID
End Get
Set(ByVal value As Integer)
_CandidateID = value
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

Public Property isPass() As BOOLEAN
Get
Return _isPass
End Get
Set(ByVal value As BOOLEAN)
_isPass = value
End Set
End Property

Public Property TotalPassMarks() As Integer
Get
Return _TotalPassMarks
End Get
Set(ByVal value As Integer)
_TotalPassMarks = value
End Set
End Property

Public Property MarksSecured() As Integer
Get
Return _MarksSecured
End Get
Set(ByVal value As Integer)
_MarksSecured = value
End Set
End Property

Public Property isWeightageBasedOnMustAnswerRight() As BOOLEAN
Get
Return _isWeightageBasedOnMustAnswerRight
End Get
Set(ByVal value As BOOLEAN)
_isWeightageBasedOnMustAnswerRight = value
End Set
End Property

Public Property isAllWeightageBasedOnAnswersRigthAnswered() As BOOLEAN
Get
Return _isAllWeightageBasedOnAnswersRigthAnswered
End Get
Set(ByVal value As BOOLEAN)
_isAllWeightageBasedOnAnswersRigthAnswered = value
End Set
End Property

Public Property Remarks() As String
Get
Return _Remarks
End Get
Set(ByVal value As String)
_Remarks = value
End Set
End Property

Public Property isInActive() As BOOLEAN
Get
Return _isInActive
End Get
Set(ByVal value As BOOLEAN)
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

