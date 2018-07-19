Namespace JobStation.Models
 Public Class Interview
'-----------------Global Declaration-----------------
Dim _InterviewID as Integer = 0
Dim _ApplicationID as Integer = 0
Dim _InterviewerUserID as Integer = 0
Dim _isMandatory as BOOLEAN = False
Dim _isEvaluator as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _Description as String = String.Empty
'-----------------------------------------


'*****************Properties****************
Public Property InterviewID() As Integer
Get
Return _InterviewID
End Get
Set(ByVal value As Integer)
_InterviewID = value
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

Public Property InterviewerUserID() As Integer
Get
Return _InterviewerUserID
End Get
Set(ByVal value As Integer)
_InterviewerUserID = value
End Set
End Property

Public Property isMandatory() As BOOLEAN
Get
Return _isMandatory
End Get
Set(ByVal value As BOOLEAN)
_isMandatory = value
End Set
End Property

Public Property isEvaluator() As BOOLEAN
Get
Return _isEvaluator
End Get
Set(ByVal value As BOOLEAN)
_isEvaluator = value
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

Public Property Description() As String
Get
Return _Description
End Get
Set(ByVal value As String)
_Description = value
End Set
End Property

'*******************************
End Class
End Namespace

