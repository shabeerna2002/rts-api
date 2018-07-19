Namespace JobStation.Models
 Public Class Notificationtorequestoractionstaken
'-----------------Global Declaration-----------------
Dim _NotificationToRequestorActionID as Integer = 0
Dim _RequestActionID as Integer = 0
Dim _ApplicationHistoryID as Integer = 0
Dim _ActionTakenOn as DateTime = "01-01-1900 12:00:00 AM"
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
Public Property NotificationToRequestorActionID() As Integer
Get
Return _NotificationToRequestorActionID
End Get
Set(ByVal value As Integer)
_NotificationToRequestorActionID = value
End Set
End Property

Public Property RequestActionID() As Integer
Get
Return _RequestActionID
End Get
Set(ByVal value As Integer)
_RequestActionID = value
End Set
End Property

Public Property ApplicationHistoryID() As Integer
Get
Return _ApplicationHistoryID
End Get
Set(ByVal value As Integer)
_ApplicationHistoryID = value
End Set
End Property

Public Property ActionTakenOn() As DateTime
Get
Return _ActionTakenOn
End Get
Set(ByVal value As DateTime)
_ActionTakenOn = value
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

