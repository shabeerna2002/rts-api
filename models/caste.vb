Namespace JobStation.Models
 Public Class Caste
'-----------------Global Declaration-----------------
Dim _CasteID as Integer = 0
Dim _ReligionID as Integer = 0
Dim _Caste as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CasteID() As Integer
Get
Return _CasteID
End Get
Set(ByVal value As Integer)
_CasteID = value
End Set
End Property

Public Property ReligionID() As Integer
Get
Return _ReligionID
End Get
Set(ByVal value As Integer)
_ReligionID = value
End Set
End Property

Public Property Caste() As String
Get
Return _Caste
End Get
Set(ByVal value As String)
_Caste = value
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

