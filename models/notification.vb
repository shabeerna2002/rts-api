Namespace JobStation.Models
 Public Class Notification
'-----------------Global Declaration-----------------
Dim _NotificationID as Integer = 0
Dim _NotificationTemplateID as Integer = 0
Dim _NotificationName as String = String.Empty
Dim _NotificationTypeID as Integer = 0
Dim _FromAddress as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _Notification as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property NotificationID() As Integer
Get
Return _NotificationID
End Get
Set(ByVal value As Integer)
_NotificationID = value
End Set
End Property

Public Property NotificationTemplateID() As Integer
Get
Return _NotificationTemplateID
End Get
Set(ByVal value As Integer)
_NotificationTemplateID = value
End Set
End Property

Public Property NotificationName() As String
Get
Return _NotificationName
End Get
Set(ByVal value As String)
_NotificationName = value
End Set
End Property

Public Property NotificationTypeID() As Integer
Get
Return _NotificationTypeID
End Get
Set(ByVal value As Integer)
_NotificationTypeID = value
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

Public Property Notification() As String
Get
Return _Notification
End Get
Set(ByVal value As String)
_Notification = value
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

