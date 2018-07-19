Namespace JobStation.Models
 Public Class Jobapplication
'-----------------Global Declaration-----------------
Dim _ApplicationID as Integer = 0
Dim _CanidateID as Integer = 0
Dim _VacancyID as Integer = 0
Dim _ApplicationSourceID as Integer = 0
Dim _AppliedByUser as Integer = 0
Dim _isDisqualified as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _AppliedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ApplicationID() As Integer
Get
Return _ApplicationID
End Get
Set(ByVal value As Integer)
_ApplicationID = value
End Set
End Property

Public Property CanidateID() As Integer
Get
Return _CanidateID
End Get
Set(ByVal value As Integer)
_CanidateID = value
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

Public Property ApplicationSourceID() As Integer
Get
Return _ApplicationSourceID
End Get
Set(ByVal value As Integer)
_ApplicationSourceID = value
End Set
End Property

Public Property AppliedByUser() As Integer
Get
Return _AppliedByUser
End Get
Set(ByVal value As Integer)
_AppliedByUser = value
End Set
End Property

Public Property isDisqualified() As BOOLEAN
Get
Return _isDisqualified
End Get
Set(ByVal value As BOOLEAN)
_isDisqualified = value
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

Public Property AppliedOn() As DateTime
Get
Return _AppliedOn
End Get
Set(ByVal value As DateTime)
_AppliedOn = value
End Set
End Property

'*******************************
End Class
End Namespace

