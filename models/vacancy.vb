Namespace JobStation.Models
 Public Class Vacancy
'-----------------Global Declaration-----------------
Dim _VacancyID as Integer = 0
Dim _OpenPositions as Integer = 0
Dim _DesignationID as Integer = 0
Dim _Title as String = String.Empty
Dim _JobDescription as String = String.Empty
Dim _JobSkill as String = String.Empty
Dim _JobDuty as String = String.Empty
Dim _EducationInfo as String = String.Empty
Dim _NationalityInfo as String = String.Empty
Dim _ClosingDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _OpeningDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _StatusID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
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

Public Property StatusID() As Integer
Get
Return _StatusID
End Get
Set(ByVal value As Integer)
_StatusID = value
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

