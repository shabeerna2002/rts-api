Namespace JobStation.Models
 Public Class Location
'-----------------Global Declaration-----------------
Dim _LocationID as Integer = 0
Dim _Location as String = String.Empty
Dim _CityID as Integer = 0
Dim _CountryID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property LocationID() As Integer
Get
Return _LocationID
End Get
Set(ByVal value As Integer)
_LocationID = value
End Set
End Property

Public Property Location() As String
Get
Return _Location
End Get
Set(ByVal value As String)
_Location = value
End Set
End Property

Public Property CityID() As Integer
Get
Return _CityID
End Get
Set(ByVal value As Integer)
_CityID = value
End Set
End Property

Public Property CountryID() As Integer
Get
Return _CountryID
End Get
Set(ByVal value As Integer)
_CountryID = value
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

