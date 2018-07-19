Namespace JobStation.Models
 Public Class Onboardingsheet
'-----------------Global Declaration-----------------
Dim _OnboardingSheetID as Integer = 0
Dim _OnboardingSheetTemplateID as Integer = 0
Dim _ApplicationID as Integer = 0
Dim _SheetTypeID as Integer = 0
Dim _Notes as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property OnboardingSheetID() As Integer
Get
Return _OnboardingSheetID
End Get
Set(ByVal value As Integer)
_OnboardingSheetID = value
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

Public Property ApplicationID() As Integer
Get
Return _ApplicationID
End Get
Set(ByVal value As Integer)
_ApplicationID = value
End Set
End Property

Public Property SheetTypeID() As Integer
Get
Return _SheetTypeID
End Get
Set(ByVal value As Integer)
_SheetTypeID = value
End Set
End Property

Public Property Notes() As String
Get
Return _Notes
End Get
Set(ByVal value As String)
_Notes = value
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

