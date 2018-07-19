Namespace JobStation.Models
 Public Class Transition
'-----------------Global Declaration-----------------
Dim _TransitionID as Integer = 0
Dim _ProcessID as Integer = 0
Dim _CurrentStateID as Integer = 0
Dim _NextStateID as Integer = 0
Dim _ETAMins as Integer = 0
Dim _isDisplayAlias as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property TransitionID() As Integer
Get
Return _TransitionID
End Get
Set(ByVal value As Integer)
_TransitionID = value
End Set
End Property

Public Property ProcessID() As Integer
Get
Return _ProcessID
End Get
Set(ByVal value As Integer)
_ProcessID = value
End Set
End Property

Public Property CurrentStateID() As Integer
Get
Return _CurrentStateID
End Get
Set(ByVal value As Integer)
_CurrentStateID = value
End Set
End Property

Public Property NextStateID() As Integer
Get
Return _NextStateID
End Get
Set(ByVal value As Integer)
_NextStateID = value
End Set
End Property

Public Property ETAMins() As Integer
Get
Return _ETAMins
End Get
Set(ByVal value As Integer)
_ETAMins = value
End Set
End Property

Public Property isDisplayAlias() As BOOLEAN
Get
Return _isDisplayAlias
End Get
Set(ByVal value As BOOLEAN)
_isDisplayAlias = value
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

