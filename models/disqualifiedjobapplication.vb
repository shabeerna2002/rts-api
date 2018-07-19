﻿Namespace JobStation.Models
 Public Class Disqualifiedjobapplication
'-----------------Global Declaration-----------------
Dim _ApplicationID as Integer = 0
Dim _DisqualificationDate as DateTime = "01-01-1900 12:00:00 AM"
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
Dim _AppliedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property ApplicationID() As Integer
Get
Return _ApplicationID
End Get
Set(ByVal value As Integer)
_ApplicationID = value
End Set
End Property

Public Property DisqualificationDate() As DateTime
Get
Return _DisqualificationDate
End Get
Set(ByVal value As DateTime)
_DisqualificationDate = value
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

Public Property AppliedOn() As DateTime
Get
Return _AppliedOn
End Get
Set(ByVal value As DateTime)
_AppliedOn = value
End Set
End Property

'*******************************
End Class
End Namespace

