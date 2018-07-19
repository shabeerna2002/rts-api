Namespace JobStation.Models
 Public Class Workexperience
'-----------------Global Declaration-----------------
Dim _WorkExperienceID as Integer = 0
Dim _WorkExperiencePlaceID as Integer = 0
Dim _CandidateID as Integer = 0
Dim _YearsofExperience as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property WorkExperienceID() As Integer
Get
Return _WorkExperienceID
End Get
Set(ByVal value As Integer)
_WorkExperienceID = value
End Set
End Property

Public Property WorkExperiencePlaceID() As Integer
Get
Return _WorkExperiencePlaceID
End Get
Set(ByVal value As Integer)
_WorkExperiencePlaceID = value
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

Public Property YearsofExperience() As Integer
Get
Return _YearsofExperience
End Get
Set(ByVal value As Integer)
_YearsofExperience = value
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

