Namespace JobStation.Models
 Public Class Notificationtorequestor
'-----------------Global Declaration-----------------
Dim _NotificationToRequestorID as Integer = 0
Dim _AccessKey as String = String.Empty
Dim _AccessKeyValidTill as DateTime = "01-01-1900 12:00:00 AM"
Dim _NotificationSent as String = String.Empty
Dim _FromAddress as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _NotificationSentTo as String = String.Empty
Dim _SentOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property NotificationToRequestorID() As Integer
Get
Return _NotificationToRequestorID
End Get
Set(ByVal value As Integer)
_NotificationToRequestorID = value
End Set
End Property

Public Property AccessKey() As String
Get
Return _AccessKey
End Get
Set(ByVal value As String)
_AccessKey = value
End Set
End Property

Public Property AccessKeyValidTill() As DateTime
Get
Return _AccessKeyValidTill
End Get
Set(ByVal value As DateTime)
_AccessKeyValidTill = value
End Set
End Property

Public Property NotificationSent() As String
Get
Return _NotificationSent
End Get
Set(ByVal value As String)
_NotificationSent = value
End Set
End Property

Public Property FromAddress() As String
Get
Return _FromAddress
End Get
Set(ByVal value As String)
_FromAddress = value
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

Public Property NotificationSentTo() As String
Get
Return _NotificationSentTo
End Get
Set(ByVal value As String)
_NotificationSentTo = value
End Set
End Property

Public Property SentOn() As DateTime
Get
Return _SentOn
End Get
Set(ByVal value As DateTime)
_SentOn = value
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

