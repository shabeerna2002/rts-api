Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionnaireapplicantstatus
Public Function Insert(ByVal objquestionnaireapplicantstatus As Models.questionnaireapplicantstatus ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireapplicantstatus  as new DAL.questionnaireapplicantstatus
Return DA_questionnaireapplicantstatus.Insert(objquestionnaireapplicantstatus, con, MyTrans)
End Function

Public Function Update(ByVal objquestionnaireapplicantstatus As Models.questionnaireapplicantstatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireapplicantstatus  as new DAL.questionnaireapplicantstatus
Return DA_questionnaireapplicantstatus.Update(objquestionnaireapplicantstatus, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionnaireapplicantstatus As Models.questionnaireapplicantstatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaireapplicantstatus  as new DAL.questionnaireapplicantstatus
Return DA_questionnaireapplicantstatus.Delete(objquestionnaireapplicantstatus, con, MyTrans)
End Function

End Class
End Namespace

