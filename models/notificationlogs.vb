Namespace JobStation.Models
 Public Class Notificationlogs
'-----------------Global Declaration-----------------
Dim _NotificationSentID as Integer = 0
Dim _NotificationID as Integer = 0
Dim _NotificationSent as String = String.Empty
Dim _FromAddress as String = String.Empty
Dim _DisplayName as String = String.Empty
Dim _NotificationSentTo as String = String.Empty
Dim _SentOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _ActivityID as Integer = 0
Dim _StateID as Integer = 0
Dim _TransitionID as Integer = 0
Dim _TargetID as Integer = 0
Dim _isStateActivity as BOOLEAN = False
Dim _isTransitionActivity as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property NotificationSentID() As Integer
Get
Return _NotificationSentID
End Get
Set(ByVal value As Integer)
_NotificationSentID = value
End Set
End Property

Public Property NotificationID() As Integer
Get
Return _NotificationID
End Get
Set(ByVal value As Integer)
_NotificationID = value
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

Public Property ActivityID() As Integer
Get
Return _ActivityID
End Get
Set(ByVal value As Integer)
_ActivityID = value
End Set
End Property

Public Property StateID() As Integer
Get
Return _StateID
End Get
Set(ByVal value As Integer)
_StateID = value
End Set
End Property

Public Property TransitionID() As Integer
Get
Return _TransitionID
End Get
Set(ByVal value As Integer)
_TransitionID = value
End Set
End Property

Public Property TargetID() As Integer
Get
Return _TargetID
End Get
Set(ByVal value As Integer)
_TargetID = value
End Set
End Property

Public Property isStateActivity() As BOOLEAN
Get
Return _isStateActivity
End Get
Set(ByVal value As BOOLEAN)
_isStateActivity = value
End Set
End Property

Public Property isTransitionActivity() As BOOLEAN
Get
Return _isTransitionActivity
End Get
Set(ByVal value As BOOLEAN)
_isTransitionActivity = value
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

