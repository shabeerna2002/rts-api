Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetkey
Public Function Insert(ByVal objevaluationsheetkey As Models.evaluationsheetkey ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkey  as new DAL.evaluationsheetkey
Return DA_evaluationsheetkey.Insert(objevaluationsheetkey, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetkey As Models.evaluationsheetkey, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkey  as new DAL.evaluationsheetkey
Return DA_evaluationsheetkey.Update(objevaluationsheetkey, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetkey As Models.evaluationsheetkey, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkey  as new DAL.evaluationsheetkey
Return DA_evaluationsheetkey.Delete(objevaluationsheetkey, con, MyTrans)
End Function

End Class
End Namespace

