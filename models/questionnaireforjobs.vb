﻿Namespace JobStation.Models
 Public Class Questionnaireforjobs
'-----------------Global Declaration-----------------
Dim _QuestionnaireID as Integer = 0
Dim _VacancyID as Integer = 0
Dim _Title as String = String.Empty
Dim _isWeightageBasedOnMustAnswerRight as BOOLEAN = False
Dim _TotalPassMarks as Integer = 0
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property QuestionnaireID() As Integer
Get
Return _QuestionnaireID
End Get
Set(ByVal value As Integer)
_QuestionnaireID = value
End Set
End Property

Public Property VacancyID() As Integer
Get
Return _VacancyID
End Get
Set(ByVal value As Integer)
_VacancyID = value
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

Public Property isWeightageBasedOnMustAnswerRight() As BOOLEAN
Get
Return _isWeightageBasedOnMustAnswerRight
End Get
Set(ByVal value As BOOLEAN)
_isWeightageBasedOnMustAnswerRight = value
End Set
End Property

Public Property TotalPassMarks() As Integer
Get
Return _TotalPassMarks
End Get
Set(ByVal value As Integer)
_TotalPassMarks = value
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
