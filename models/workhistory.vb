Namespace JobStation.Models
 Public Class Workhistory
'-----------------Global Declaration-----------------
Dim _WorkHistoryID as Integer = 0
Dim _CandidateID as Integer = 0
Dim _Designation as String = String.Empty
Dim _Employer as String = String.Empty
Dim _ReportingTo as String = String.Empty
Dim _FromDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _ToDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _isLatestJob as BOOLEAN = False
Dim _GrossMonthlySalary as Integer = 0
Dim _ReasonForLeaving as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property WorkHistoryID() As Integer
Get
Return _WorkHistoryID
End Get
Set(ByVal value As Integer)
_WorkHistoryID = value
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

Public Property Designation() As String
Get
Return _Designation
End Get
Set(ByVal value As String)
_Designation = value
End Set
End Property

Public Property Employer() As String
Get
Return _Employer
End Get
Set(ByVal value As String)
_Employer = value
End Set
End Property

Public Property ReportingTo() As String
Get
Return _ReportingTo
End Get
Set(ByVal value As String)
_ReportingTo = value
End Set
End Property

Public Property FromDate() As DateTime
Get
Return _FromDate
End Get
Set(ByVal value As DateTime)
_FromDate = value
End Set
End Property

Public Property ToDate() As DateTime
Get
Return _ToDate
End Get
Set(ByVal value As DateTime)
_ToDate = value
End Set
End Property

Public Property isLatestJob() As BOOLEAN
Get
Return _isLatestJob
End Get
Set(ByVal value As BOOLEAN)
_isLatestJob = value
End Set
End Property

Public Property GrossMonthlySalary() As Integer
Get
Return _GrossMonthlySalary
End Get
Set(ByVal value As Integer)
_GrossMonthlySalary = value
End Set
End Property

Public Property ReasonForLeaving() As String
Get
Return _ReasonForLeaving
End Get
Set(ByVal value As String)
_ReasonForLeaving = value
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

