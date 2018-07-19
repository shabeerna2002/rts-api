Namespace JobStation.Models
 Public Class Action
'-----------------Global Declaration-----------------
Dim _ActionID as Integer = 0
Dim _ActionTypeID as Integer = 0
Dim _ProcessID as Integer = 0
Dim _ActionName as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _DisplayAlias as String = String.Empty
Dim _DisplayIcon as String = String.Empty
Dim _DisplayImage as String = String.Empty
Dim _Tooltip as String = String.Empty
Dim _Description as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ActionID() As Integer
Get
Return _ActionID
End Get
Set(ByVal value As Integer)
_ActionID = value
End Set
End Property

Public Property ActionTypeID() As Integer
Get
Return _ActionTypeID
End Get
Set(ByVal value As Integer)
_ActionTypeID = value
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

Public Property ActionName() As String
Get
Return _ActionName
End Get
Set(ByVal value As String)
_ActionName = value
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

Public Property DisplayIcon() As String
Get
Return _DisplayIcon
End Get
Set(ByVal value As String)
_DisplayIcon = value
End Set
End Property

Public Property DisplayImage() As String
Get
Return _DisplayImage
End Get
Set(ByVal value As String)
_DisplayImage = value
End Set
End Property

Public Property Tooltip() As String
Get
Return _Tooltip
End Get
Set(ByVal value As String)
_Tooltip = value
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

