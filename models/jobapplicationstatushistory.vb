Namespace JobStation.Models
 Public Class Jobapplicationstatushistory
'-----------------Global Declaration-----------------
Dim _ApplicationHistoryID as Integer = 0
Dim _ProcessID as Integer = 0
Dim _RequestActionID as Integer = 0
Dim _ProcessName as String = String.Empty
Dim _ApplicationID as Integer = 0
Dim _TransactionDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _UserID as Integer = 0
Dim _Message as String = String.Empty
Dim _TransitionID as Integer = 0
Dim _StateTypeID as Integer = 0
Dim _StateTypeName as String = String.Empty
Dim _StateGroupID as Integer = 0
Dim _StateGroupName as String = String.Empty
Dim _CurrentStateID as Integer = 0
Dim _CurrentStateName as String = String.Empty
Dim _DisplayCurrentState as String = String.Empty
Dim _DisplayAliasCurrentState as String = String.Empty
Dim _isPartialUpdate as BOOLEAN = False
Dim _PartialUpdateDisplayName as String = String.Empty
Dim _NextStateID as Integer = 0
Dim _NextStateName as String = String.Empty
Dim _DisplayNextState as String = String.Empty
Dim _DisplayAliasNextState as String = String.Empty
Dim _ActionTypeID as Integer = 0
Dim _DisplayActionType as String = String.Empty
Dim _ActionID as Integer = 0
Dim _ActionName as String = String.Empty
Dim _ActionDisplayName as String = String.Empty
Dim _TargetGroupID as Integer = 0
Dim _TargetGroupName as String = String.Empty
Dim _TargetID as Integer = 0
Dim _TargentName as String = String.Empty
Dim _EntryTime as DateTime = "01-01-1900 12:00:00 AM"
Dim _ExitTime as DateTime = "01-01-1900 12:00:00 AM"
Dim _ETAMins as Integer = 0
Dim _ActualMins as Integer = 0
Dim _ResponsibleUserID as Integer = 0
Dim _ResponsibleUser as String = String.Empty
Dim _ResponsibleDepartmentID as Integer = 0
Dim _ResponsibleDepartment as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ApplicationHistoryID() As Integer
Get
Return _ApplicationHistoryID
End Get
Set(ByVal value As Integer)
_ApplicationHistoryID = value
End Set
End Property

Public Property ProcessID() As Integer
Get
Return _ProcessID
End Get
Set(ByVal value As Integer)
_ProcessID = value
End Set
End Property

Public Property RequestActionID() As Integer
Get
Return _RequestActionID
End Get
Set(ByVal value As Integer)
_RequestActionID = value
End Set
End Property

Public Property ProcessName() As String
Get
Return _ProcessName
End Get
Set(ByVal value As String)
_ProcessName = value
End Set
End Property

Public Property ApplicationID() As Integer
Get
Return _ApplicationID
End Get
Set(ByVal value As Integer)
_ApplicationID = value
End Set
End Property

Public Property TransactionDate() As DateTime
Get
Return _TransactionDate
End Get
Set(ByVal value As DateTime)
_TransactionDate = value
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

Public Property Message() As String
Get
Return _Message
End Get
Set(ByVal value As String)
_Message = value
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

Public Property StateTypeID() As Integer
Get
Return _StateTypeID
End Get
Set(ByVal value As Integer)
_StateTypeID = value
End Set
End Property

Public Property StateTypeName() As String
Get
Return _StateTypeName
End Get
Set(ByVal value As String)
_StateTypeName = value
End Set
End Property

Public Property StateGroupID() As Integer
Get
Return _StateGroupID
End Get
Set(ByVal value As Integer)
_StateGroupID = value
End Set
End Property

Public Property StateGroupName() As String
Get
Return _StateGroupName
End Get
Set(ByVal value As String)
_StateGroupName = value
End Set
End Property

Public Property CurrentStateID() As Integer
Get
Return _CurrentStateID
End Get
Set(ByVal value As Integer)
_CurrentStateID = value
End Set
End Property

Public Property CurrentStateName() As String
Get
Return _CurrentStateName
End Get
Set(ByVal value As String)
_CurrentStateName = value
End Set
End Property

Public Property DisplayCurrentState() As String
Get
Return _DisplayCurrentState
End Get
Set(ByVal value As String)
_DisplayCurrentState = value
End Set
End Property

Public Property DisplayAliasCurrentState() As String
Get
Return _DisplayAliasCurrentState
End Get
Set(ByVal value As String)
_DisplayAliasCurrentState = value
End Set
End Property

Public Property isPartialUpdate() As BOOLEAN
Get
Return _isPartialUpdate
End Get
Set(ByVal value As BOOLEAN)
_isPartialUpdate = value
End Set
End Property

Public Property PartialUpdateDisplayName() As String
Get
Return _PartialUpdateDisplayName
End Get
Set(ByVal value As String)
_PartialUpdateDisplayName = value
End Set
End Property

Public Property NextStateID() As Integer
Get
Return _NextStateID
End Get
Set(ByVal value As Integer)
_NextStateID = value
End Set
End Property

Public Property NextStateName() As String
Get
Return _NextStateName
End Get
Set(ByVal value As String)
_NextStateName = value
End Set
End Property

Public Property DisplayNextState() As String
Get
Return _DisplayNextState
End Get
Set(ByVal value As String)
_DisplayNextState = value
End Set
End Property

Public Property DisplayAliasNextState() As String
Get
Return _DisplayAliasNextState
End Get
Set(ByVal value As String)
_DisplayAliasNextState = value
End Set
End Property

Public Property ActionTypeID() As Integer
Get
Return _ActionTypeID
End Get
Set(ByVal value As Integer)
_ActionTypeID = value
End Set
End Property

Public Property DisplayActionType() As String
Get
Return _DisplayActionType
End Get
Set(ByVal value As String)
_DisplayActionType = value
End Set
End Property

Public Property ActionID() As Integer
Get
Return _ActionID
End Get
Set(ByVal value As Integer)
_ActionID = value
End Set
End Property

Public Property ActionName() As String
Get
Return _ActionName
End Get
Set(ByVal value As String)
_ActionName = value
End Set
End Property

Public Property ActionDisplayName() As String
Get
Return _ActionDisplayName
End Get
Set(ByVal value As String)
_ActionDisplayName = value
End Set
End Property

Public Property TargetGroupID() As Integer
Get
Return _TargetGroupID
End Get
Set(ByVal value As Integer)
_TargetGroupID = value
End Set
End Property

Public Property TargetGroupName() As String
Get
Return _TargetGroupName
End Get
Set(ByVal value As String)
_TargetGroupName = value
End Set
End Property

Public Property TargetID() As Integer
Get
Return _TargetID
End Get
Set(ByVal value As Integer)
_TargetID = value
End Set
End Property

Public Property TargentName() As String
Get
Return _TargentName
End Get
Set(ByVal value As String)
_TargentName = value
End Set
End Property

Public Property EntryTime() As DateTime
Get
Return _EntryTime
End Get
Set(ByVal value As DateTime)
_EntryTime = value
End Set
End Property

Public Property ExitTime() As DateTime
Get
Return _ExitTime
End Get
Set(ByVal value As DateTime)
_ExitTime = value
End Set
End Property

Public Property ETAMins() As Integer
Get
Return _ETAMins
End Get
Set(ByVal value As Integer)
_ETAMins = value
End Set
End Property

Public Property ActualMins() As Integer
Get
Return _ActualMins
End Get
Set(ByVal value As Integer)
_ActualMins = value
End Set
End Property

Public Property ResponsibleUserID() As Integer
Get
Return _ResponsibleUserID
End Get
Set(ByVal value As Integer)
_ResponsibleUserID = value
End Set
End Property

Public Property ResponsibleUser() As String
Get
Return _ResponsibleUser
End Get
Set(ByVal value As String)
_ResponsibleUser = value
End Set
End Property

Public Property ResponsibleDepartmentID() As Integer
Get
Return _ResponsibleDepartmentID
End Get
Set(ByVal value As Integer)
_ResponsibleDepartmentID = value
End Set
End Property

Public Property ResponsibleDepartment() As String
Get
Return _ResponsibleDepartment
End Get
Set(ByVal value As String)
_ResponsibleDepartment = value
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

