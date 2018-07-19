Namespace JobStation.Models
 Public Class Stategroupmaster
'-----------------Global Declaration-----------------
Dim _StateGroupID as Integer = 0
Dim _GroupName as String = String.Empty
Dim _Description as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property StateGroupID() As Integer
Get
Return _StateGroupID
End Get
Set(ByVal value As Integer)
_StateGroupID = value
End Set
End Property

Public Property GroupName() As String
Get
Return _GroupName
End Get
Set(ByVal value As String)
_GroupName = value
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

