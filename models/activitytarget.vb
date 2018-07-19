Namespace JobStation.Models
 Public Class Activitytarget
'-----------------Global Declaration-----------------
Dim _ActivityTargetID as Integer = 0
Dim _ActivityID as Integer = 0
Dim _TargetID as Integer = 0
Dim _GroupID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ActivityTargetID() As Integer
Get
Return _ActivityTargetID
End Get
Set(ByVal value As Integer)
_ActivityTargetID = value
End Set
End Property

Public Property ActivityID() As Integer
Get
Return _ActivityID
End Get
Set(ByVal value As Integer)
_ActivityID = value
End Set
End Property

Public Property TargetID() As Integer
Get
Return _TargetID
End Get
Set(ByVal value As Integer)
_TargetID = value
End Set
End Property

Public Property GroupID() As Integer
Get
Return _GroupID
End Get
Set(ByVal value As Integer)
_GroupID = value
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

