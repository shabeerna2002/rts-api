Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobindustry
Public Function Insert(ByVal objjobindustry As Models.jobindustry ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobindustry  as new DAL.jobindustry
Return DA_jobindustry.Insert(objjobindustry, con, MyTrans)
End Function

Public Function Update(ByVal objjobindustry As Models.jobindustry, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobindustry  as new DAL.jobindustry
Return DA_jobindustry.Update(objjobindustry, con, MyTrans)
End Function

Public Function Delete(ByVal objjobindustry As Models.jobindustry, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobindustry  as new DAL.jobindustry
Return DA_jobindustry.Delete(objjobindustry, con, MyTrans)
End Function

End Class
End Namespace

