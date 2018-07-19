Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questions
Public Function Insert(ByVal objquestions As Models.questions ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questions  as new DAL.questions
Return DA_questions.Insert(objquestions, con, MyTrans)
End Function

Public Function Update(ByVal objquestions As Models.questions, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questions  as new DAL.questions
Return DA_questions.Update(objquestions, con, MyTrans)
End Function

Public Function Delete(ByVal objquestions As Models.questions, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questions  as new DAL.questions
Return DA_questions.Delete(objquestions, con, MyTrans)
End Function

End Class
End Namespace

