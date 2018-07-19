Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplicationtimelinedocuments
Public Function Insert(ByVal objjobapplicationtimelinedocuments As Models.jobapplicationtimelinedocuments ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimelinedocuments  as new DAL.jobapplicationtimelinedocuments
Return DA_jobapplicationtimelinedocuments.Insert(objjobapplicationtimelinedocuments, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplicationtimelinedocuments As Models.jobapplicationtimelinedocuments, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimelinedocuments  as new DAL.jobapplicationtimelinedocuments
Return DA_jobapplicationtimelinedocuments.Update(objjobapplicationtimelinedocuments, con, MyTrans)
End Function

Public Function Delete(ByVal objjobapplicationtimelinedocuments As Models.jobapplicationtimelinedocuments, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimelinedocuments  as new DAL.jobapplicationtimelinedocuments
Return DA_jobapplicationtimelinedocuments.Delete(objjobapplicationtimelinedocuments, con, MyTrans)
End Function

End Class
End Namespace

