Namespace JobStation.Models
 Public Class Activitylogdocument
'-----------------Global Declaration-----------------
Dim _ActivityLogDocumentID as Integer = 0
Dim _ActivityLogID as Long = 0
Dim _Title as String = String.Empty
Dim _Description as String = String.Empty
Dim _FileName as String = String.Empty
Dim _FileLocation as String = String.Empty
Dim _MimeType as String = String.Empty
Dim _DateUploaded as DateTime = "01-01-1900 12:00:00 AM"
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ActivityLogDocumentID() As Integer
Get
Return _ActivityLogDocumentID
End Get
Set(ByVal value As Integer)
_ActivityLogDocumentID = value
End Set
End Property

Public Property ActivityLogID() As Long
Get
Return _ActivityLogID
End Get
Set(ByVal value As Long)
_ActivityLogID = value
End Set
End Property

Public Property Title() As String
Get
Return _Title
End Get
Set(ByVal value As String)
_Title = value
End Set
End Property

Public Property Description() As String
Get
Return _Description
End Get
Set(ByVal value As String)
_Description = value
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

Public Property FileLocation() As String
Get
Return _FileLocation
End Get
Set(ByVal value As String)
_FileLocation = value
End Set
End Property

Public Property MimeType() As String
Get
Return _MimeType
End Get
Set(ByVal value As String)
_MimeType = value
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

