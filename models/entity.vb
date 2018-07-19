Namespace JobStation.Models
 Public Class Entity
'-----------------Global Declaration-----------------
Dim _EntityID as Integer = 0
Dim _Entity as Integer = 0
Dim _Description as String = String.Empty
Dim _Address as String = String.Empty
Dim _LocationID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property EntityID() As Integer
Get
Return _EntityID
End Get
Set(ByVal value As Integer)
_EntityID = value
End Set
End Property

Public Property Entity() As Integer
Get
Return _Entity
End Get
Set(ByVal value As Integer)
_Entity = value
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

Public Property Address() As String
Get
Return _Address
End Get
Set(ByVal value As String)
_Address = value
End Set
End Property

Public Property LocationID() As Integer
Get
Return _LocationID
End Get
Set(ByVal value As Integer)
_LocationID = value
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

