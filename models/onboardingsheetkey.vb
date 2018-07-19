Namespace JobStation.Models
 Public Class Onboardingsheetkey
'-----------------Global Declaration-----------------
Dim _OnboardingSheetKeyID as Integer = 0
Dim _OnboardingSheetTemplateID as Integer = 0
Dim _KeyTypeID as Integer = 0
Dim _OnboardingKey as String = String.Empty
Dim _DisplayOrder as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property OnboardingSheetKeyID() As Integer
Get
Return _OnboardingSheetKeyID
End Get
Set(ByVal value As Integer)
_OnboardingSheetKeyID = value
End Set
End Property

Public Property OnboardingSheetTemplateID() As Integer
Get
Return _OnboardingSheetTemplateID
End Get
Set(ByVal value As Integer)
_OnboardingSheetTemplateID = value
End Set
End Property

Public Property KeyTypeID() As Integer
Get
Return _KeyTypeID
End Get
Set(ByVal value As Integer)
_KeyTypeID = value
End Set
End Property

Public Property OnboardingKey() As String
Get
Return _OnboardingKey
End Get
Set(ByVal value As String)
_OnboardingKey = value
End Set
End Property

Public Property DisplayOrder() As Integer
Get
Return _DisplayOrder
End Get
Set(ByVal value As Integer)
_DisplayOrder = value
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

