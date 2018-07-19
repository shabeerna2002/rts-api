﻿Namespace JobStation.Models
 Public Class Stateactivity
'-----------------Global Declaration-----------------
Dim _StateID as Integer = 0
Dim _ActivityID as Integer = 0
Dim _NotificationID as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property StateID() As Integer
Get
Return _StateID
End Get
Set(ByVal value As Integer)
_StateID = value
End Set
End Property

Public Property ActivityID() As Integer
Get
Return _ActivityID
End Get
Set(ByVal value As Integer)
_ActivityID = value
End Set
End Property

Public Property NotificationID() As Integer
Get
Return _NotificationID
End Get
Set(ByVal value As Integer)
_NotificationID = value
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
