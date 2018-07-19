Namespace JobStation.Models
 Public Class Candidatedocument
'-----------------Global Declaration-----------------
Dim _CandidateDocumentID as Integer = 0
Dim _CandidateID as Integer = 0
Dim _CandidateDocumentTypeID as Integer = 0
Dim _WorkFlowRequestFileID as Integer = 0
Dim _Title as String = String.Empty
Dim _Description as String = String.Empty
Dim _FileName as String = String.Empty
Dim _FileLocation as String = String.Empty
Dim _MimeType as String = String.Empty
Dim _DateUploaded as DateTime = "01-01-1900 12:00:00 AM"
Dim _DocumentNo as String = String.Empty
Dim _RefNo as String = String.Empty
Dim _ValidFrom as DateTime = "01-01-1900 12:00:00 AM"
Dim _ValidTill as DateTime = "01-01-1900 12:00:00 AM"
Dim _isAlwaysDisplay as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CandidateDocumentID() As Integer
Get
Return _CandidateDocumentID
End Get
Set(ByVal value As Integer)
_CandidateDocumentID = value
End Set
End Property

Public Property CandidateID() As Integer
Get
Return _CandidateID
End Get
Set(ByVal value As Integer)
_CandidateID = value
End Set
End Property

Public Property CandidateDocumentTypeID() As Integer
Get
Return _CandidateDocumentTypeID
End Get
Set(ByVal value As Integer)
_CandidateDocumentTypeID = value
End Set
End Property

Public Property WorkFlowRequestFileID() As Integer
Get
Return _WorkFlowRequestFileID
End Get
Set(ByVal value As Integer)
_WorkFlowRequestFileID = value
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

Public Property DocumentNo() As String
Get
Return _DocumentNo
End Get
Set(ByVal value As String)
_DocumentNo = value
End Set
End Property

Public Property RefNo() As String
Get
Return _RefNo
End Get
Set(ByVal value As String)
_RefNo = value
End Set
End Property

Public Property ValidFrom() As DateTime
Get
Return _ValidFrom
End Get
Set(ByVal value As DateTime)
_ValidFrom = value
End Set
End Property

Public Property ValidTill() As DateTime
Get
Return _ValidTill
End Get
Set(ByVal value As DateTime)
_ValidTill = value
End Set
End Property

Public Property isAlwaysDisplay() As BOOLEAN
Get
Return _isAlwaysDisplay
End Get
Set(ByVal value As BOOLEAN)
_isAlwaysDisplay = value
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

