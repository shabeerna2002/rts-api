Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Questiontypes
Public Function Insert(ByVal objquestiontypes As Models.questiontypes ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questiontypes  as new DAL.questiontypes
Return DA_questiontypes.Insert(objquestiontypes, con, MyTrans)
End Function

Public Function Update(ByVal objquestiontypes As Models.questiontypes, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questiontypes  as new DAL.questiontypes
Return DA_questiontypes.Update(objquestiontypes, con, MyTrans)
End Function

Public Function Delete(ByVal objquestiontypes As Models.questiontypes, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_questiontypes  as new DAL.questiontypes
Return DA_questiontypes.Delete(objquestiontypes, con, MyTrans)
End Function

End Class
End Namespace

