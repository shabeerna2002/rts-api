Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitylogstype
Public Function Insert(ByVal objactivitylogstype As Models.activitylogstype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogstype  as new DAL.activitylogstype
Return DA_activitylogstype.Insert(objactivitylogstype, con, MyTrans)
End Function

Public Function Update(ByVal objactivitylogstype As Models.activitylogstype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogstype  as new DAL.activitylogstype
Return DA_activitylogstype.Update(objactivitylogstype, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitylogstype As Models.activitylogstype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogstype  as new DAL.activitylogstype
Return DA_activitylogstype.Delete(objactivitylogstype, con, MyTrans)
End Function

End Class
End Namespace

