Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionchoiceoptions
Public Function Insert(ByVal objquestionchoiceoptions As Models.questionchoiceoptions ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptions  as new DAL.questionchoiceoptions
Return DA_questionchoiceoptions.Insert(objquestionchoiceoptions, con, MyTrans)
End Function

Public Function Update(ByVal objquestionchoiceoptions As Models.questionchoiceoptions, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptions  as new DAL.questionchoiceoptions
Return DA_questionchoiceoptions.Update(objquestionchoiceoptions, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionchoiceoptions As Models.questionchoiceoptions, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceoptions  as new DAL.questionchoiceoptions
Return DA_questionchoiceoptions.Delete(objquestionchoiceoptions, con, MyTrans)
End Function

End Class
End Namespace

