﻿Namespace JobStation.Models
 Public Class Onboardingsheetkeygroupmaster
'-----------------Global Declaration-----------------
Dim _KeyGroupID as Integer = 0
Dim _ParentGroupID as Integer = 0
Dim _KeyGroup as String = String.Empty
Dim _DisplayOrder as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property KeyGroupID() As Integer
Get
Return _KeyGroupID
End Get
Set(ByVal value As Integer)
_KeyGroupID = value
End Set
End Property

Public Property ParentGroupID() As Integer
Get
Return _ParentGroupID
End Get
Set(ByVal value As Integer)
_ParentGroupID = value
End Set
End Property

Public Property KeyGroup() As String
Get
Return _KeyGroup
End Get
Set(ByVal value As String)
_KeyGroup = value
End Set
End Property

Public Property DisplayOrder() As Integer
Get
Return _DisplayOrder
End Get
Set(ByVal value As Integer)
_DisplayOrder = value
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

