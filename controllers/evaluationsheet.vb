Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheet
Public Function Insert(ByVal objevaluationsheet As Models.evaluationsheet ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheet  as new DAL.evaluationsheet
Return DA_evaluationsheet.Insert(objevaluationsheet, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheet As Models.evaluationsheet, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheet  as new DAL.evaluationsheet
Return DA_evaluationsheet.Update(objevaluationsheet, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheet As Models.evaluationsheet, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheet  as new DAL.evaluationsheet
Return DA_evaluationsheet.Delete(objevaluationsheet, con, MyTrans)
End Function

End Class
End Namespace

