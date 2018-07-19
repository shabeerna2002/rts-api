Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetkeygroupmaster
Public Function Insert(ByVal objevaluationsheetkeygroupmaster As Models.evaluationsheetkeygroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroupmaster  as new DAL.evaluationsheetkeygroupmaster
Return DA_evaluationsheetkeygroupmaster.Insert(objevaluationsheetkeygroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetkeygroupmaster As Models.evaluationsheetkeygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroupmaster  as new DAL.evaluationsheetkeygroupmaster
Return DA_evaluationsheetkeygroupmaster.Update(objevaluationsheetkeygroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetkeygroupmaster As Models.evaluationsheetkeygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetkeygroupmaster  as new DAL.evaluationsheetkeygroupmaster
Return DA_evaluationsheetkeygroupmaster.Delete(objevaluationsheetkeygroupmaster, con, MyTrans)
End Function

End Class
End Namespace

