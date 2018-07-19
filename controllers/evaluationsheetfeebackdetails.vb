Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetfeebackdetails
Public Function Insert(ByVal objevaluationsheetfeebackdetails As Models.evaluationsheetfeebackdetails ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeebackdetails  as new DAL.evaluationsheetfeebackdetails
Return DA_evaluationsheetfeebackdetails.Insert(objevaluationsheetfeebackdetails, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetfeebackdetails As Models.evaluationsheetfeebackdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeebackdetails  as new DAL.evaluationsheetfeebackdetails
Return DA_evaluationsheetfeebackdetails.Update(objevaluationsheetfeebackdetails, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetfeebackdetails As Models.evaluationsheetfeebackdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeebackdetails  as new DAL.evaluationsheetfeebackdetails
Return DA_evaluationsheetfeebackdetails.Delete(objevaluationsheetfeebackdetails, con, MyTrans)
End Function

End Class
End Namespace

