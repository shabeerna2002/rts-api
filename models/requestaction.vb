Namespace JobStation.Models
 Public Class Requestaction
'-----------------Global Declaration-----------------
Dim _RequestActionID as Integer = 0
Dim _RequestID as Integer = 0
Dim _ActionID as Integer = 0
Dim _ActionByUserID as Integer = 0
Dim _TransitionID as Integer = 0
Dim _isActive as BOOLEAN = False
Dim _isComplete as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _CreatedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _CreatedBy as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property RequestActionID() As Integer
Get
Return _RequestActionID
End Get
Set(ByVal value As Integer)
_RequestActionID = value
End Set
End Property

Public Property RequestID() As Integer
Get
Return _RequestID
End Get
Set(ByVal value As Integer)
_RequestID = value
End Set
End Property

Public Property ActionID() As Integer
Get
Return _ActionID
End Get
Set(ByVal value As Integer)
_ActionID = value
End Set
End Property

Public Property ActionByUserID() As Integer
Get
Return _ActionByUserID
End Get
Set(ByVal value As Integer)
_ActionByUserID = value
End Set
End Property

Public Property TransitionID() As Integer
Get
Return _TransitionID
End Get
Set(ByVal value As Integer)
_TransitionID = value
End Set
End Property

Public Property isActive() As BOOLEAN
Get
Return _isActive
End Get
Set(ByVal value As BOOLEAN)
_isActive = value
End Set
End Property

Public Property isComplete() As BOOLEAN
Get
Return _isComplete
End Get
Set(ByVal value As BOOLEAN)
_isComplete = value
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

Public Property CreatedOn() As DateTime
Get
Return _CreatedOn
End Get
Set(ByVal value As DateTime)
_CreatedOn = value
End Set
End Property

Public Property CreatedBy() As String
Get
Return _CreatedBy
End Get
Set(ByVal value As String)
_CreatedBy = value
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

