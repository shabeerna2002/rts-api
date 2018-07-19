Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Evaluationsheetfeedbacktype
Public Function Insert(ByVal objevaluationsheetfeedbacktype As Models.evaluationsheetfeedbacktype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeedbacktype  as new DAL.evaluationsheetfeedbacktype
Return DA_evaluationsheetfeedbacktype.Insert(objevaluationsheetfeedbacktype, con, MyTrans)
End Function

Public Function Update(ByVal objevaluationsheetfeedbacktype As Models.evaluationsheetfeedbacktype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeedbacktype  as new DAL.evaluationsheetfeedbacktype
Return DA_evaluationsheetfeedbacktype.Update(objevaluationsheetfeedbacktype, con, MyTrans)
End Function

Public Function Delete(ByVal objevaluationsheetfeedbacktype As Models.evaluationsheetfeedbacktype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_evaluationsheetfeedbacktype  as new DAL.evaluationsheetfeedbacktype
Return DA_evaluationsheetfeedbacktype.Delete(objevaluationsheetfeedbacktype, con, MyTrans)
End Function

End Class
End Namespace

