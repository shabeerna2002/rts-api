Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionnaireforjobs
Public Function Insert(ByVal objquestionnaireforjobs As Models.questionnaireforjobs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireforjobs  as new DAL.questionnaireforjobs
Return DA_questionnaireforjobs.Insert(objquestionnaireforjobs, con, MyTrans)
End Function

Public Function Update(ByVal objquestionnaireforjobs As Models.questionnaireforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireforjobs  as new DAL.questionnaireforjobs
Return DA_questionnaireforjobs.Update(objquestionnaireforjobs, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionnaireforjobs As Models.questionnaireforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireforjobs  as new DAL.questionnaireforjobs
Return DA_questionnaireforjobs.Delete(objquestionnaireforjobs, con, MyTrans)
End Function

End Class
End Namespace

