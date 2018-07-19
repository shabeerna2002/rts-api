Namespace JobStation.Models
 Public Class Department_external
'-----------------Global Declaration-----------------
Dim _ExternalDepartmentID as Integer = 0
Dim _ExternalSystemCode as String = String.Empty
Dim _Dept_No as String = String.Empty
Dim _Dept_Name as String = String.Empty
Dim _Dept_Head as String = String.Empty
Dim _Division_Head as String = String.Empty
Dim _Email_Address as String = String.Empty
Dim _Supervisor_Name as String = String.Empty
Dim _Dept_Name_Display as String = String.Empty
Dim _Sub_Dep as BOOLEAN = False
Dim _Reporting_Head as String = String.Empty
Dim _AttendanceInCharge as String = String.Empty
Dim _Parent_Dept as String = String.Empty
Dim _Company as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ExternalDepartmentID() As Integer
Get
Return _ExternalDepartmentID
End Get
Set(ByVal value As Integer)
_ExternalDepartmentID = value
End Set
End Property

Public Property ExternalSystemCode() As String
Get
Return _ExternalSystemCode
End Get
Set(ByVal value As String)
_ExternalSystemCode = value
End Set
End Property

Public Property Dept_No() As String
Get
Return _Dept_No
End Get
Set(ByVal value As String)
_Dept_No = value
End Set
End Property

Public Property Dept_Name() As String
Get
Return _Dept_Name
End Get
Set(ByVal value As String)
_Dept_Name = value
End Set
End Property

Public Property Dept_Head() As String
Get
Return _Dept_Head
End Get
Set(ByVal value As String)
_Dept_Head = value
End Set
End Property

Public Property Division_Head() As String
Get
Return _Division_Head
End Get
Set(ByVal value As String)
_Division_Head = value
End Set
End Property

Public Property Email_Address() As String
Get
Return _Email_Address
End Get
Set(ByVal value As String)
_Email_Address = value
End Set
End Property

Public Property Supervisor_Name() As String
Get
Return _Supervisor_Name
End Get
Set(ByVal value As String)
_Supervisor_Name = value
End Set
End Property

Public Property Dept_Name_Display() As String
Get
Return _Dept_Name_Display
End Get
Set(ByVal value As String)
_Dept_Name_Display = value
End Set
End Property

Public Property Sub_Dep() As BOOLEAN
Get
Return _Sub_Dep
End Get
Set(ByVal value As BOOLEAN)
_Sub_Dep = value
End Set
End Property

Public Property Reporting_Head() As String
Get
Return _Reporting_Head
End Get
Set(ByVal value As String)
_Reporting_Head = value
End Set
End Property

Public Property AttendanceInCharge() As String
Get
Return _AttendanceInCharge
End Get
Set(ByVal value As String)
_AttendanceInCharge = value
End Set
End Property

Public Property Parent_Dept() As String
Get
Return _Parent_Dept
End Get
Set(ByVal value As String)
_Parent_Dept = value
End Set
End Property

Public Property Company() As String
Get
Return _Company
End Get
Set(ByVal value As String)
_Company = value
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

