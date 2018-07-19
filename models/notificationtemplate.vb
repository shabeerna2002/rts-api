Namespace JobStation.Models
 Public Class Notificationtemplate
'-----------------Global Declaration-----------------
Dim _NotificationTemplateID as Integer = 0
Dim _TemplateName as String = String.Empty
Dim _FromAddress as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _Content as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property NotificationTemplateID() As Integer
Get
Return _NotificationTemplateID
End Get
Set(ByVal value As Integer)
_NotificationTemplateID = value
End Set
End Property

Public Property TemplateName() As String
Get
Return _TemplateName
End Get
Set(ByVal value As String)
_TemplateName = value
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

Public Property Content() As String
Get
Return _Content
End Get
Set(ByVal value As String)
_Content = value
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

