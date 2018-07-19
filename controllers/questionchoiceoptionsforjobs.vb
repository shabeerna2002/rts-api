Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionchoiceoptionsforjobs
Public Function Insert(ByVal objquestionchoiceoptionsforjobs As Models.questionchoiceoptionsforjobs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptionsforjobs  as new DAL.questionchoiceoptionsforjobs
Return DA_questionchoiceoptionsforjobs.Insert(objquestionchoiceoptionsforjobs, con, MyTrans)
End Function

Public Function Update(ByVal objquestionchoiceoptionsforjobs As Models.questionchoiceoptionsforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptionsforjobs  as new DAL.questionchoiceoptionsforjobs
Return DA_questionchoiceoptionsforjobs.Update(objquestionchoiceoptionsforjobs, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionchoiceoptionsforjobs As Models.questionchoiceoptionsforjobs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptionsforjobs  as new DAL.questionchoiceoptionsforjobs
Return DA_questionchoiceoptionsforjobs.Delete(objquestionchoiceoptionsforjobs, con, MyTrans)
End Function

End Class
End Namespace

