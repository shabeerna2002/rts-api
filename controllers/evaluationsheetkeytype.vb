Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetkeytype
Public Function Insert(ByVal objevaluationsheetkeytype As Models.evaluationsheetkeytype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeytype  as new DAL.evaluationsheetkeytype
Return DA_evaluationsheetkeytype.Insert(objevaluationsheetkeytype, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetkeytype As Models.evaluationsheetkeytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeytype  as new DAL.evaluationsheetkeytype
Return DA_evaluationsheetkeytype.Update(objevaluationsheetkeytype, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetkeytype As Models.evaluationsheetkeytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeytype  as new DAL.evaluationsheetkeytype
Return DA_evaluationsheetkeytype.Delete(objevaluationsheetkeytype, con, MyTrans)
End Function

End Class
End Namespace

