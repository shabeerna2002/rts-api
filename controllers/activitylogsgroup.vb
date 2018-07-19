Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitylogsgroup
Public Function Insert(ByVal objactivitylogsgroup As Models.activitylogsgroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroup  as new DAL.activitylogsgroup
Return DA_activitylogsgroup.Insert(objactivitylogsgroup, con, MyTrans)
End Function

Public Function Update(ByVal objactivitylogsgroup As Models.activitylogsgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroup  as new DAL.activitylogsgroup
Return DA_activitylogsgroup.Update(objactivitylogsgroup, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitylogsgroup As Models.activitylogsgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroup  as new DAL.activitylogsgroup
Return DA_activitylogsgroup.Delete(objactivitylogsgroup, con, MyTrans)
End Function

End Class
End Namespace

