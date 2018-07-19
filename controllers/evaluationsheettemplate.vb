Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheettemplate
Public Function Insert(ByVal objevaluationsheettemplate As Models.evaluationsheettemplate ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheettemplate  as new DAL.evaluationsheettemplate
Return DA_evaluationsheettemplate.Insert(objevaluationsheettemplate, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheettemplate As Models.evaluationsheettemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheettemplate  as new DAL.evaluationsheettemplate
Return DA_evaluationsheettemplate.Update(objevaluationsheettemplate, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheettemplate As Models.evaluationsheettemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheettemplate  as new DAL.evaluationsheettemplate
Return DA_evaluationsheettemplate.Delete(objevaluationsheettemplate, con, MyTrans)
End Function

End Class
End Namespace

