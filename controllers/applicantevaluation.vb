Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Applicantevaluation
Public Function Insert(ByVal objapplicantevaluation As Models.applicantevaluation ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_applicantevaluation  as new DAL.applicantevaluation
Return DA_applicantevaluation.Insert(objapplicantevaluation, con, MyTrans)
End Function

Public Function Update(ByVal objapplicantevaluation As Models.applicantevaluation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_applicantevaluation  as new DAL.applicantevaluation
Return DA_applicantevaluation.Update(objapplicantevaluation, con, MyTrans)
End Function

Public Function Delete(ByVal objapplicantevaluation As Models.applicantevaluation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_applicantevaluation  as new DAL.applicantevaluation
Return DA_applicantevaluation.Delete(objapplicantevaluation, con, MyTrans)
End Function

End Class
End Namespace

