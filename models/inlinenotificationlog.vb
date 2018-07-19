Namespace JobStation.Models
 Public Class Inlinenotificationlog
'-----------------Global Declaration-----------------
Dim _NotificationLogID as Long = 0
Dim _InlineNotificationID as Integer = 0
Dim _AccessedOn as DateTime = "01-01-1900 12:00:00 AM"
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
Public Property NotificationLogID() As Long
Get
Return _NotificationLogID
End Get
Set(ByVal value As Long)
_NotificationLogID = value
End Set
End Property

Public Property InlineNotificationID() As Integer
Get
Return _InlineNotificationID
End Get
Set(ByVal value As Integer)
_InlineNotificationID = value
End Set
End Property

Public Property AccessedOn() As DateTime
Get
Return _AccessedOn
End Get
Set(ByVal value As DateTime)
_AccessedOn = value
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

