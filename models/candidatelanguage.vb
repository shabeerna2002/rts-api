Namespace JobStation.Models
 Public Class Candidatelanguage
'-----------------Global Declaration-----------------
Dim _CandidateLanguageID as Integer = 0
Dim _CandidateID as Integer = 0
Dim _LanguageID as Integer = 0
Dim _proficiency as Integer = 0
Dim _CompletionYear as DateTime = "01-01-1900 12:00:00 AM"
Dim _ExamResult as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CandidateLanguageID() As Integer
Get
Return _CandidateLanguageID
End Get
Set(ByVal value As Integer)
_CandidateLanguageID = value
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

Public Property LanguageID() As Integer
Get
Return _LanguageID
End Get
Set(ByVal value As Integer)
_LanguageID = value
End Set
End Property

Public Property proficiency() As Integer
Get
Return _proficiency
End Get
Set(ByVal value As Integer)
_proficiency = value
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

