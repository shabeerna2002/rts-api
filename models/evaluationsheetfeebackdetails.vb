Namespace JobStation.Models
 Public Class Evaluationsheetfeebackdetails
'-----------------Global Declaration-----------------
Dim _EvaluationSheetFeebackID as Integer = 0
Dim _EvaluationSheetID as Integer = 0
Dim _EvaluationSheetKeyID as Integer = 0
Dim _Value as String = String.Empty
Dim _Remarks as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property EvaluationSheetFeebackID() As Integer
Get
Return _EvaluationSheetFeebackID
End Get
Set(ByVal value As Integer)
_EvaluationSheetFeebackID = value
End Set
End Property

Public Property EvaluationSheetID() As Integer
Get
Return _EvaluationSheetID
End Get
Set(ByVal value As Integer)
_EvaluationSheetID = value
End Set
End Property

Public Property EvaluationSheetKeyID() As Integer
Get
Return _EvaluationSheetKeyID
End Get
Set(ByVal value As Integer)
_EvaluationSheetKeyID = value
End Set
End Property

Public Property Value() As String
Get
Return _Value
End Get
Set(ByVal value As String)
_Value = value
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

