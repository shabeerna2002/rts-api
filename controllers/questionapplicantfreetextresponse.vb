Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionapplicantfreetextresponse
Public Function Insert(ByVal objquestionapplicantfreetextresponse As Models.questionapplicantfreetextresponse ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionapplicantfreetextresponse  as new DAL.questionapplicantfreetextresponse
Return DA_questionapplicantfreetextresponse.Insert(objquestionapplicantfreetextresponse, con, MyTrans)
End Function

Public Function Update(ByVal objquestionapplicantfreetextresponse As Models.questionapplicantfreetextresponse, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionapplicantfreetextresponse  as new DAL.questionapplicantfreetextresponse
Return DA_questionapplicantfreetextresponse.Update(objquestionapplicantfreetextresponse, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionapplicantfreetextresponse As Models.questionapplicantfreetextresponse, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionapplicantfreetextresponse  as new DAL.questionapplicantfreetextresponse
Return DA_questionapplicantfreetextresponse.Delete(objquestionapplicantfreetextresponse, con, MyTrans)
End Function

End Class
End Namespace

