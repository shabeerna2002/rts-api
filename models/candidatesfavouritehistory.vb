Namespace JobStation.Models
 Public Class Candidatesfavouritehistory
'-----------------Global Declaration-----------------
Dim _CandidateID as Integer = 0
Dim _FavouritedByUserID as Integer = 0
Dim _FavouritedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _FavouritedTill as DateTime = "01-01-1900 12:00:00 AM"
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CandidateID() As Integer
Get
Return _CandidateID
End Get
Set(ByVal value As Integer)
_CandidateID = value
End Set
End Property

Public Property FavouritedByUserID() As Integer
Get
Return _FavouritedByUserID
End Get
Set(ByVal value As Integer)
_FavouritedByUserID = value
End Set
End Property

Public Property FavouritedOn() As DateTime
Get
Return _FavouritedOn
End Get
Set(ByVal value As DateTime)
_FavouritedOn = value
End Set
End Property

Public Property FavouritedTill() As DateTime
Get
Return _FavouritedTill
End Get
Set(ByVal value As DateTime)
_FavouritedTill = value
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

