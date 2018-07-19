Namespace JobStation.Models
 Public Class Activitylog
'-----------------Global Declaration-----------------
Dim _ActivityLogID as Long = 0
Dim _TypeID as Integer = 0
Dim _UserID as Integer = 0
Dim _Message as String = String.Empty
Dim _ActivityOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _IPAddress as String = String.Empty
Dim _UserAgent as String = String.Empty
Dim _UserHost as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ActivityLogID() As Long
Get
Return _ActivityLogID
End Get
Set(ByVal value As Long)
_ActivityLogID = value
End Set
End Property

Public Property TypeID() As Integer
Get
Return _TypeID
End Get
Set(ByVal value As Integer)
_TypeID = value
End Set
End Property

Public Property UserID() As Integer
Get
Return _UserID
End Get
Set(ByVal value As Integer)
_UserID = value
End Set
End Property

Public Property Message() As String
Get
Return _Message
End Get
Set(ByVal value As String)
_Message = value
End Set
End Property

Public Property ActivityOn() As DateTime
Get
Return _ActivityOn
End Get
Set(ByVal value As DateTime)
_ActivityOn = value
End Set
End Property

Public Property IPAddress() As String
Get
Return _IPAddress
End Get
Set(ByVal value As String)
_IPAddress = value
End Set
End Property

Public Property UserAgent() As String
Get
Return _UserAgent
End Get
Set(ByVal value As String)
_UserAgent = value
End Set
End Property

Public Property UserHost() As String
Get
Return _UserHost
End Get
Set(ByVal value As String)
_UserHost = value
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

