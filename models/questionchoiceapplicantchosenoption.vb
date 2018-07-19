Namespace JobStation.Models
 Public Class Questionchoiceapplicantchosenoption
'-----------------Global Declaration-----------------
Dim _ChosenID as Integer = 0
Dim _ApplicationID as Integer = 0
Dim _QuestionnaireID as Integer = 0
Dim _QuestionID as Integer = 0
Dim _ChosenOptionID as Integer = 0
Dim _isChosenRightOption as BOOLEAN = False
Dim _MarksAwarded as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ChosenID() As Integer
Get
Return _ChosenID
End Get
Set(ByVal value As Integer)
_ChosenID = value
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

Public Property QuestionnaireID() As Integer
Get
Return _QuestionnaireID
End Get
Set(ByVal value As Integer)
_QuestionnaireID = value
End Set
End Property

Public Property QuestionID() As Integer
Get
Return _QuestionID
End Get
Set(ByVal value As Integer)
_QuestionID = value
End Set
End Property

Public Property ChosenOptionID() As Integer
Get
Return _ChosenOptionID
End Get
Set(ByVal value As Integer)
_ChosenOptionID = value
End Set
End Property

Public Property isChosenRightOption() As BOOLEAN
Get
Return _isChosenRightOption
End Get
Set(ByVal value As BOOLEAN)
_isChosenRightOption = value
End Set
End Property

Public Property MarksAwarded() As Integer
Get
Return _MarksAwarded
End Get
Set(ByVal value As Integer)
_MarksAwarded = value
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

