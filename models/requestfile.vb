Namespace JobStation.Models
 Public Class Requestfile
'-----------------Global Declaration-----------------
Dim _RequestFileID as Integer = 0
Dim _RequestID as Integer = 0
Dim _UserID as Integer = 0
Dim _TransitionID as Integer = 0
Dim _DateUploaded as DateTime = "01-01-1900 12:00:00 AM"
Dim _FileName as String = String.Empty
Dim _FileURL as String = String.Empty
Dim _MIMEType as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property RequestFileID() As Integer
Get
Return _RequestFileID
End Get
Set(ByVal value As Integer)
_RequestFileID = value
End Set
End Property

Public Property RequestID() As Integer
Get
Return _RequestID
End Get
Set(ByVal value As Integer)
_RequestID = value
End Set
End Property

Public Property UserID() As Integer
Get
Return _UserID
End Get
Set(ByVal value As Integer)
_UserID = value
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

Public Property DateUploaded() As DateTime
Get
Return _DateUploaded
End Get
Set(ByVal value As DateTime)
_DateUploaded = value
End Set
End Property

Public Property FileName() As String
Get
Return _FileName
End Get
Set(ByVal value As String)
_FileName = value
End Set
End Property

Public Property FileURL() As String
Get
Return _FileURL
End Get
Set(ByVal value As String)
_FileURL = value
End Set
End Property

Public Property MIMEType() As String
Get
Return _MIMEType
End Get
Set(ByVal value As String)
_MIMEType = value
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

