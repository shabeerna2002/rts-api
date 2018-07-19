Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questionnaire
Public Function Insert(ByVal objquestionnaire As Models.questionnaire ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaire  as new DAL.questionnaire
Return DA_questionnaire.Insert(objquestionnaire, con, MyTrans)
End Function

Public Function Update(ByVal objquestionnaire As Models.questionnaire, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaire  as new DAL.questionnaire
Return DA_questionnaire.Update(objquestionnaire, con, MyTrans)
End Function

Public Function Delete(ByVal objquestionnaire As Models.questionnaire, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questionnaire  as new DAL.questionnaire
Return DA_questionnaire.Delete(objquestionnaire, con, MyTrans)
End Function

End Class
End Namespace

