Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetkeygroup
Public Function Insert(ByVal objevaluationsheetkeygroup As Models.evaluationsheetkeygroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroup  as new DAL.evaluationsheetkeygroup
Return DA_evaluationsheetkeygroup.Insert(objevaluationsheetkeygroup, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetkeygroup As Models.evaluationsheetkeygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroup  as new DAL.evaluationsheetkeygroup
Return DA_evaluationsheetkeygroup.Update(objevaluationsheetkeygroup, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetkeygroup As Models.evaluationsheetkeygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroup  as new DAL.evaluationsheetkeygroup
Return DA_evaluationsheetkeygroup.Delete(objevaluationsheetkeygroup, con, MyTrans)
End Function

End Class
End Namespace

