Namespace JobStation.Models
 Public Class Religion
'-----------------Global Declaration-----------------
Dim _ReligionID as Integer = 0
Dim _Religion as String = String.Empty
        Dim _isInActive As UInt16 = 0
        Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ReligionID() As Integer
Get
Return _ReligionID
End Get
Set(ByVal value As Integer)
_ReligionID = value
End Set
End Property

Public Property Religion() As String
Get
Return _Religion
End Get
Set(ByVal value As String)
_Religion = value
End Set
End Property

        Public Property isInActive() As UInt64
            Get
                Return _isInActive
            End Get
            Set(ByVal value As UInt64)
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

