Namespace JobStation.Models
 Public Class User
'-----------------Global Declaration-----------------
Dim _UserID as Integer = 0
Dim _UserSource as String = String.Empty
Dim _UserTypeid as Integer = 0
Dim _User_Name as String = String.Empty
Dim _User_Group as String = String.Empty
Dim _User_Dept as String = String.Empty
Dim _User_Person_Name as String = String.Empty
Dim _User_Designation as String = String.Empty
Dim _Email as String = String.Empty
Dim _MobileCountryCode as String = String.Empty
Dim _Mobile as String = String.Empty
Dim _User_Inactive as BOOLEAN = False
Dim _User_Operation_Dept as String = String.Empty
Dim _is_Director as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property UserID() As Integer
Get
Return _UserID
End Get
Set(ByVal value As Integer)
_UserID = value
End Set
End Property

Public Property UserSource() As String
Get
Return _UserSource
End Get
Set(ByVal value As String)
_UserSource = value
End Set
End Property

Public Property UserTypeid() As Integer
Get
Return _UserTypeid
End Get
Set(ByVal value As Integer)
_UserTypeid = value
End Set
End Property

Public Property User_Name() As String
Get
Return _User_Name
End Get
Set(ByVal value As String)
_User_Name = value
End Set
End Property

Public Property User_Group() As String
Get
Return _User_Group
End Get
Set(ByVal value As String)
_User_Group = value
End Set
End Property

Public Property User_Dept() As String
Get
Return _User_Dept
End Get
Set(ByVal value As String)
_User_Dept = value
End Set
End Property

Public Property User_Person_Name() As String
Get
Return _User_Person_Name
End Get
Set(ByVal value As String)
_User_Person_Name = value
End Set
End Property

Public Property User_Designation() As String
Get
Return _User_Designation
End Get
Set(ByVal value As String)
_User_Designation = value
End Set
End Property

Public Property Email() As String
Get
Return _Email
End Get
Set(ByVal value As String)
_Email = value
End Set
End Property

Public Property MobileCountryCode() As String
Get
Return _MobileCountryCode
End Get
Set(ByVal value As String)
_MobileCountryCode = value
End Set
End Property

Public Property Mobile() As String
Get
Return _Mobile
End Get
Set(ByVal value As String)
_Mobile = value
End Set
End Property

Public Property User_Inactive() As BOOLEAN
Get
Return _User_Inactive
End Get
Set(ByVal value As BOOLEAN)
_User_Inactive = value
End Set
End Property

Public Property User_Operation_Dept() As String
Get
Return _User_Operation_Dept
End Get
Set(ByVal value As String)
_User_Operation_Dept = value
End Set
End Property

Public Property is_Director() As BOOLEAN
Get
Return _is_Director
End Get
Set(ByVal value As BOOLEAN)
_is_Director = value
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

