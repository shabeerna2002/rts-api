Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionsforjobs
Public Function Insert(ByVal objquestionsforjobs As Models.questionsforjobs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionsforjobs  as new DAL.questionsforjobs
Return DA_questionsforjobs.Insert(objquestionsforjobs, con, MyTrans)
End Function

Public Function Update(ByVal objquestionsforjobs As Models.questionsforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionsforjobs  as new DAL.questionsforjobs
Return DA_questionsforjobs.Update(objquestionsforjobs, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionsforjobs As Models.questionsforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionsforjobs  as new DAL.questionsforjobs
Return DA_questionsforjobs.Delete(objquestionsforjobs, con, MyTrans)
End Function

End Class
End Namespace

