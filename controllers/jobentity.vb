Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobentity
Public Function Insert(ByVal objjobentity As Models.jobentity ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobentity  as new DAL.jobentity
Return DA_jobentity.Insert(objjobentity, con, MyTrans)
End Function

Public Function Update(ByVal objjobentity As Models.jobentity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobentity  as new DAL.jobentity
Return DA_jobentity.Update(objjobentity, con, MyTrans)
End Function

Public Function Delete(ByVal objjobentity As Models.jobentity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobentity  as new DAL.jobentity
Return DA_jobentity.Delete(objjobentity, con, MyTrans)
End Function

End Class
End Namespace

