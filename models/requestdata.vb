﻿Namespace JobStation.Models
 Public Class Requestdata
'-----------------Global Declaration-----------------
Dim _RequestDataID as Integer = 0
Dim _RequestID as Integer = 0
Dim _Name as String = String.Empty
Dim _Value as String = String.Empty
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property RequestDataID() As Integer
Get
Return _RequestDataID
End Get
Set(ByVal value As Integer)
_RequestDataID = value
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

Public Property Name() As String
Get
Return _Name
End Get
Set(ByVal value As String)
_Name = value
End Set
End Property

Public Property Value() As String
Get
Return _Value
End Get
Set(ByVal value As String)
_Value = value
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
