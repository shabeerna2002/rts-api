Namespace JobStation.Models
 Public Class Candidate
'-----------------Global Declaration-----------------
Dim _CandidateID as Integer = 0
Dim _cvTitle as String = String.Empty
Dim _Objective as String = String.Empty
Dim _RefNo as String = String.Empty
Dim _ExternalRefNo as String = String.Empty
Dim _NameFirst as String = String.Empty
Dim _NameMiddle as String = String.Empty
Dim _NameLast as String = String.Empty
Dim _cvFIle as String = String.Empty
Dim _cvMimeType as String = String.Empty
Dim _cvContent as String = String.Empty
Dim _DateOfBirth as DateTime = "01-01-1900 12:00:00 AM"
Dim _Gender as String = String.Empty
Dim _ReligionID as Integer = 0
Dim _CasteID as Integer = 0
Dim _MaritialStatus as String = String.Empty
Dim _NoOfDependant as Integer = 0
Dim _Nationality as Integer = 0
Dim _CountryOfResidence as Integer = 0
Dim _CityID as Integer = 0
Dim _VisaStatusID as Integer = 0
Dim _NoticePeriod as String = String.Empty
Dim _Email as String = String.Empty
Dim _uPassword as String = String.Empty
Dim _MobileCountryCode as String = String.Empty
Dim _MobileNo as String = String.Empty
Dim _Address as String = String.Empty
Dim _PoBox as String = String.Empty
Dim _FaxCountryCode as String = String.Empty
Dim _FaxNo as String = String.Empty
Dim _isRelativeAtCompany as BOOLEAN = False
Dim _RelativeDetails as String = String.Empty
Dim _WhyShurooq as String = String.Empty
Dim _WorkExperienceTotal as Integer = 0
Dim _WorkExperienceUAE as Integer = 0
Dim _WorkExperienceNonUAE as Integer = 0
Dim _isHired as BOOLEAN = False
Dim _isInActive as BOOLEAN = False
Dim _SessionID as Integer = 0
Dim _TransactionKey as String = String.Empty
Dim _UpdatedBy as String = String.Empty
Dim _UpdatedOn as DateTime = "01-01-1900 12:00:00 AM"
'-----------------------------------------


'*****************Properties****************
Public Property CandidateID() As Integer
Get
Return _CandidateID
End Get
Set(ByVal value As Integer)
_CandidateID = value
End Set
End Property

Public Property cvTitle() As String
Get
Return _cvTitle
End Get
Set(ByVal value As String)
_cvTitle = value
End Set
End Property

Public Property Objective() As String
Get
Return _Objective
End Get
Set(ByVal value As String)
_Objective = value
End Set
End Property

Public Property RefNo() As String
Get
Return _RefNo
End Get
Set(ByVal value As String)
_RefNo = value
End Set
End Property

Public Property ExternalRefNo() As String
Get
Return _ExternalRefNo
End Get
Set(ByVal value As String)
_ExternalRefNo = value
End Set
End Property

Public Property NameFirst() As String
Get
Return _NameFirst
End Get
Set(ByVal value As String)
_NameFirst = value
End Set
End Property

Public Property NameMiddle() As String
Get
Return _NameMiddle
End Get
Set(ByVal value As String)
_NameMiddle = value
End Set
End Property

Public Property NameLast() As String
Get
Return _NameLast
End Get
Set(ByVal value As String)
_NameLast = value
End Set
End Property

Public Property cvFIle() As String
Get
Return _cvFIle
End Get
Set(ByVal value As String)
_cvFIle = value
End Set
End Property

Public Property cvMimeType() As String
Get
Return _cvMimeType
End Get
Set(ByVal value As String)
_cvMimeType = value
End Set
End Property

Public Property cvContent() As String
Get
Return _cvContent
End Get
Set(ByVal value As String)
_cvContent = value
End Set
End Property

Public Property DateOfBirth() As DateTime
Get
Return _DateOfBirth
End Get
Set(ByVal value As DateTime)
_DateOfBirth = value
End Set
End Property

Public Property Gender() As String
Get
Return _Gender
End Get
Set(ByVal value As String)
_Gender = value
End Set
End Property

Public Property ReligionID() As Integer
Get
Return _ReligionID
End Get
Set(ByVal value As Integer)
_ReligionID = value
End Set
End Property

Public Property CasteID() As Integer
Get
Return _CasteID
End Get
Set(ByVal value As Integer)
_CasteID = value
End Set
End Property

Public Property MaritialStatus() As String
Get
Return _MaritialStatus
End Get
Set(ByVal value As String)
_MaritialStatus = value
End Set
End Property

Public Property NoOfDependant() As Integer
Get
Return _NoOfDependant
End Get
Set(ByVal value As Integer)
_NoOfDependant = value
End Set
End Property

Public Property Nationality() As Integer
Get
Return _Nationality
End Get
Set(ByVal value As Integer)
_Nationality = value
End Set
End Property

Public Property CountryOfResidence() As Integer
Get
Return _CountryOfResidence
End Get
Set(ByVal value As Integer)
_CountryOfResidence = value
End Set
End Property

Public Property CityID() As Integer
Get
Return _CityID
End Get
Set(ByVal value As Integer)
_CityID = value
End Set
End Property

Public Property VisaStatusID() As Integer
Get
Return _VisaStatusID
End Get
Set(ByVal value As Integer)
_VisaStatusID = value
End Set
End Property

Public Property NoticePeriod() As String
Get
Return _NoticePeriod
End Get
Set(ByVal value As String)
_NoticePeriod = value
End Set
End Property

Public Property Email() As String
Get
Return _Email
End Get
Set(ByVal value As String)
_Email = value
End Set
End Property

Public Property uPassword() As String
Get
Return _uPassword
End Get
Set(ByVal value As String)
_uPassword = value
End Set
End Property

Public Property MobileCountryCode() As String
Get
Return _MobileCountryCode
End Get
Set(ByVal value As String)
_MobileCountryCode = value
End Set
End Property

Public Property MobileNo() As String
Get
Return _MobileNo
End Get
Set(ByVal value As String)
_MobileNo = value
End Set
End Property

Public Property Address() As String
Get
Return _Address
End Get
Set(ByVal value As String)
_Address = value
End Set
End Property

Public Property PoBox() As String
Get
Return _PoBox
End Get
Set(ByVal value As String)
_PoBox = value
End Set
End Property

Public Property FaxCountryCode() As String
Get
Return _FaxCountryCode
End Get
Set(ByVal value As String)
_FaxCountryCode = value
End Set
End Property

Public Property FaxNo() As String
Get
Return _FaxNo
End Get
Set(ByVal value As String)
_FaxNo = value
End Set
End Property

Public Property isRelativeAtCompany() As BOOLEAN
Get
Return _isRelativeAtCompany
End Get
Set(ByVal value As BOOLEAN)
_isRelativeAtCompany = value
End Set
End Property

Public Property RelativeDetails() As String
Get
Return _RelativeDetails
End Get
Set(ByVal value As String)
_RelativeDetails = value
End Set
End Property

Public Property WhyShurooq() As String
Get
Return _WhyShurooq
End Get
Set(ByVal value As String)
_WhyShurooq = value
End Set
End Property

Public Property WorkExperienceTotal() As Integer
Get
Return _WorkExperienceTotal
End Get
Set(ByVal value As Integer)
_WorkExperienceTotal = value
End Set
End Property

Public Property WorkExperienceUAE() As Integer
Get
Return _WorkExperienceUAE
End Get
Set(ByVal value As Integer)
_WorkExperienceUAE = value
End Set
End Property

Public Property WorkExperienceNonUAE() As Integer
Get
Return _WorkExperienceNonUAE
End Get
Set(ByVal value As Integer)
_WorkExperienceNonUAE = value
End Set
End Property

Public Property isHired() As BOOLEAN
Get
Return _isHired
End Get
Set(ByVal value As BOOLEAN)
_isHired = value
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

