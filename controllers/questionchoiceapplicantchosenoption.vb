Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionchoiceapplicantchosenoption
Public Function Insert(ByVal objquestionchoiceapplicantchosenoption As Models.questionchoiceapplicantchosenoption ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceapplicantchosenoption  as new DAL.questionchoiceapplicantchosenoption
Return DA_questionchoiceapplicantchosenoption.Insert(objquestionchoiceapplicantchosenoption, con, MyTrans)
End Function

Public Function Update(ByVal objquestionchoiceapplicantchosenoption As Models.questionchoiceapplicantchosenoption, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceapplicantchosenoption  as new DAL.questionchoiceapplicantchosenoption
Return DA_questionchoiceapplicantchosenoption.Update(objquestionchoiceapplicantchosenoption, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionchoiceapplicantchosenoption As Models.questionchoiceapplicantchosenoption, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionchoiceapplicantchosenoption  as new DAL.questionchoiceapplicantchosenoption
Return DA_questionchoiceapplicantchosenoption.Delete(objquestionchoiceapplicantchosenoption, con, MyTrans)
End Function

End Class
End Namespace

