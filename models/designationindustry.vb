Namespace JobStation.Models
 Public Class Designationindustry
'-----------------Global Declaration-----------------
Dim _DesignationIndustryID as Integer = 0
Dim _JobIndustryID as Integer = 0
Dim _DesignationID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property DesignationIndustryID() As Integer
Get
Return _DesignationIndustryID
End Get
Set(ByVal value As Integer)
_DesignationIndustryID = value
End Set
End Property

Public Property JobIndustryID() As Integer
Get
Return _JobIndustryID
End Get
Set(ByVal value As Integer)
_JobIndustryID = value
End Set
End Property

Public Property DesignationID() As Integer
Get
Return _DesignationID
End Get
Set(ByVal value As Integer)
_DesignationID = value
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

