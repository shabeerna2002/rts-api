Namespace JobStation.Models
 Public Class Evaluationsheet
'-----------------Global Declaration-----------------
Dim _EvaluationSheetID as Integer = 0
Dim _EvaluationSheetTemplateID as Integer = 0
Dim _ApplicantID as Integer = 0
Dim _FeedbackTypeID as Integer = 0
Dim _Feedback as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property EvaluationSheetID() As Integer
Get
Return _EvaluationSheetID
End Get
Set(ByVal value As Integer)
_EvaluationSheetID = value
End Set
End Property

Public Property EvaluationSheetTemplateID() As Integer
Get
Return _EvaluationSheetTemplateID
End Get
Set(ByVal value As Integer)
_EvaluationSheetTemplateID = value
End Set
End Property

Public Property ApplicantID() As Integer
Get
Return _ApplicantID
End Get
Set(ByVal value As Integer)
_ApplicantID = value
End Set
End Property

Public Property FeedbackTypeID() As Integer
Get
Return _FeedbackTypeID
End Get
Set(ByVal value As Integer)
_FeedbackTypeID = value
End Set
End Property

Public Property Feedback() As String
Get
Return _Feedback
End Get
Set(ByVal value As String)
_Feedback = value
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

