Namespace JobStation.Models
 Public Class Inlinenotification
'-----------------Global Declaration-----------------
Dim _InlineNotificationID as Integer = 0
Dim _InlineNotificationTypeID as Integer = 0
Dim _Notification as String = String.Empty
Dim _PostedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _URL as String = String.Empty
Dim _UserID as Integer = 0
Dim _isRead as BOOLEAN = False
Dim _ReadOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property InlineNotificationID() As Integer
Get
Return _InlineNotificationID
End Get
Set(ByVal value As Integer)
_InlineNotificationID = value
End Set
End Property

Public Property InlineNotificationTypeID() As Integer
Get
Return _InlineNotificationTypeID
End Get
Set(ByVal value As Integer)
_InlineNotificationTypeID = value
End Set
End Property

Public Property Notification() As String
Get
Return _Notification
End Get
Set(ByVal value As String)
_Notification = value
End Set
End Property

Public Property PostedOn() As DateTime
Get
Return _PostedOn
End Get
Set(ByVal value As DateTime)
_PostedOn = value
End Set
End Property

Public Property URL() As String
Get
Return _URL
End Get
Set(ByVal value As String)
_URL = value
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

Public Property isRead() As BOOLEAN
Get
Return _isRead
End Get
Set(ByVal value As BOOLEAN)
_isRead = value
End Set
End Property

Public Property ReadOn() As DateTime
Get
Return _ReadOn
End Get
Set(ByVal value As DateTime)
_ReadOn = value
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

