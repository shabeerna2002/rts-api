Namespace JobStation.Models
 Public Class State
'-----------------Global Declaration-----------------
Dim _StateID as Integer = 0
Dim _StateTypeID as Integer = 0
Dim _ProcessID as Integer = 0
Dim _StateName as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _DisplayAlias as String = String.Empty
Dim _Description as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property StateID() As Integer
Get
Return _StateID
End Get
Set(ByVal value As Integer)
_StateID = value
End Set
End Property

Public Property StateTypeID() As Integer
Get
Return _StateTypeID
End Get
Set(ByVal value As Integer)
_StateTypeID = value
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

Public Property StateName() As String
Get
Return _StateName
End Get
Set(ByVal value As String)
_StateName = value
End Set
End Property

Public Property DisplayName() As String
Get
Return _DisplayName
End Get
Set(ByVal value As String)
_DisplayName = value
End Set
End Property

Public Property DisplayAlias() As String
Get
Return _DisplayAlias
End Get
Set(ByVal value As String)
_DisplayAlias = value
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

