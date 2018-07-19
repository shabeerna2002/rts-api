Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplication
Public Function Insert(ByVal objjobapplication As Models.jobapplication ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplication  as new DAL.jobapplication
Return DA_jobapplication.Insert(objjobapplication, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplication As Models.jobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplication  as new DAL.jobapplication
Return DA_jobapplication.Update(objjobapplication, con, MyTrans)
End Function

Public Function Delete(ByVal objjobapplication As Models.jobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplication  as new DAL.jobapplication
Return DA_jobapplication.Delete(objjobapplication, con, MyTrans)
End Function

End Class
End Namespace

