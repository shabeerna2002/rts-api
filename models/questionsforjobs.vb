﻿Namespace JobStation.Models
 Public Class Questionsforjobs
'-----------------Global Declaration-----------------
Dim _QuestionnaireID as Integer = 0
Dim _QuestionID as Integer = 0
Dim _VacancyID as Integer = 0
Dim _QuestionTypeID as Integer = 0
Dim _QuestionType as String = String.Empty
Dim _Question as String = String.Empty
Dim _DisplayOrder as Integer = 0
Dim _isMustAnswerRight as BOOLEAN = False
Dim _Marks as Integer = 0
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

Public Property QuestionID() As Integer
Get
Return _QuestionID
End Get
Set(ByVal value As Integer)
_QuestionID = value
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

Public Property QuestionTypeID() As Integer
Get
Return _QuestionTypeID
End Get
Set(ByVal value As Integer)
_QuestionTypeID = value
End Set
End Property

Public Property QuestionType() As String
Get
Return _QuestionType
End Get
Set(ByVal value As String)
_QuestionType = value
End Set
End Property

Public Property Question() As String
Get
Return _Question
End Get
Set(ByVal value As String)
_Question = value
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

Public Property isMustAnswerRight() As BOOLEAN
Get
Return _isMustAnswerRight
End Get
Set(ByVal value As BOOLEAN)
_isMustAnswerRight = value
End Set
End Property

Public Property Marks() As Integer
Get
Return _Marks
End Get
Set(ByVal value As Integer)
_Marks = value
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

