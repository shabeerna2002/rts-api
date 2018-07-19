Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationlogsdeliverylogs
Public Function Insert(ByVal objnotificationlogsdeliverylogs As Models.notificationlogsdeliverylogs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogsdeliverylogs  as new DAL.notificationlogsdeliverylogs
Return DA_notificationlogsdeliverylogs.Insert(objnotificationlogsdeliverylogs, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationlogsdeliverylogs As Models.notificationlogsdeliverylogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogsdeliverylogs  as new DAL.notificationlogsdeliverylogs
Return DA_notificationlogsdeliverylogs.Update(objnotificationlogsdeliverylogs, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationlogsdeliverylogs As Models.notificationlogsdeliverylogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogsdeliverylogs  as new DAL.notificationlogsdeliverylogs
Return DA_notificationlogsdeliverylogs.Delete(objnotificationlogsdeliverylogs, con, MyTrans)
End Function

End Class
End Namespace

