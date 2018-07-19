Namespace JobStation.Models
 Public Class Questionchoiceoptions
'-----------------Global Declaration-----------------
Dim _QuestionnaireID as Integer = 0
Dim _QuestionID as Integer = 0
Dim _OptionText as String = String.Empty
Dim _isRightOption as BOOLEAN = False
Dim _DisplayOrder as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
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

Public Property OptionText() As String
Get
Return _OptionText
End Get
Set(ByVal value As String)
_OptionText = value
End Set
End Property

Public Property isRightOption() As BOOLEAN
Get
Return _isRightOption
End Get
Set(ByVal value As BOOLEAN)
_isRightOption = value
End Set
End Property

Public Property DisplayOrder() As Integer
Get
Return _DisplayOrder
End Get
Set(ByVal value As Integer)
_DisplayOrder = value
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

