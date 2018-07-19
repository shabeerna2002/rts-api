Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplicationstatushistory
Public Function Insert(ByVal objjobapplicationstatushistory As Models.jobapplicationstatushistory ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationstatushistory  as new DAL.jobapplicationstatushistory
Return DA_jobapplicationstatushistory.Insert(objjobapplicationstatushistory, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplicationstatushistory As Models.jobapplicationstatushistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationstatushistory  as new DAL.jobapplicationstatushistory
Return DA_jobapplicationstatushistory.Update(objjobapplicationstatushistory, con, MyTrans)
End Function

Public Function Delete(ByVal objjobapplicationstatushistory As Models.jobapplicationstatushistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplicationstatushistory  as new DAL.jobapplicationstatushistory
Return DA_jobapplicationstatushistory.Delete(objjobapplicationstatushistory, con, MyTrans)
End Function

End Class
End Namespace

