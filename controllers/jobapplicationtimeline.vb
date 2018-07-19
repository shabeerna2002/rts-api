Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplicationtimeline
Public Function Insert(ByVal objjobapplicationtimeline As Models.jobapplicationtimeline ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimeline  as new DAL.jobapplicationtimeline
Return DA_jobapplicationtimeline.Insert(objjobapplicationtimeline, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplicationtimeline As Models.jobapplicationtimeline, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimeline  as new DAL.jobapplicationtimeline
Return DA_jobapplicationtimeline.Update(objjobapplicationtimeline, con, MyTrans)
End Function

Public Function Delete(ByVal objjobapplicationtimeline As Models.jobapplicationtimeline, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationtimeline  as new DAL.jobapplicationtimeline
Return DA_jobapplicationtimeline.Delete(objjobapplicationtimeline, con, MyTrans)
End Function

End Class
End Namespace

