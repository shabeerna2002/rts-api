Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplicationsource
Public Function Insert(ByVal objjobapplicationsource As Models.jobapplicationsource ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationsource  as new DAL.jobapplicationsource
Return DA_jobapplicationsource.Insert(objjobapplicationsource, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplicationsource As Models.jobapplicationsource, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationsource  as new DAL.jobapplicationsource
Return DA_jobapplicationsource.Update(objjobapplicationsource, con, MyTrans)
End Function

Public Function Delete(ByVal objjobapplicationsource As Models.jobapplicationsource, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationsource  as new DAL.jobapplicationsource
Return DA_jobapplicationsource.Delete(objjobapplicationsource, con, MyTrans)
End Function

End Class
End Namespace

