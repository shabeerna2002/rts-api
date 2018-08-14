Namespace JobStation.Models
 Public Class Modalcontent
'-----------------Global Declaration-----------------
Dim _ModalContentD as Integer = 0
Dim _ModalID as Integer = 0
Dim _mKey as String = String.Empty
Dim _mValue as String = String.Empty
Dim _Remarks as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ModalContentD() As Integer
Get
Return _ModalContentD
End Get
Set(ByVal value As Integer)
_ModalContentD = value
End Set
End Property

Public Property ModalID() As Integer
Get
Return _ModalID
End Get
Set(ByVal value As Integer)
_ModalID = value
End Set
End Property

Public Property mKey() As String
Get
Return _mKey
End Get
Set(ByVal value As String)
_mKey = value
End Set
End Property

Public Property mValue() As String
Get
Return _mValue
End Get
Set(ByVal value As String)
_mValue = value
End Set
End Property

Public Property Remarks() As String
Get
Return _Remarks
End Get
Set(ByVal value As String)
_Remarks = value
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

