Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notification
Public Function Insert(ByVal objnotification As Models.notification ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notification  as new DAL.notification
Return DA_notification.Insert(objnotification, con, MyTrans)
End Function

Public Function Update(ByVal objnotification As Models.notification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notification  as new DAL.notification
Return DA_notification.Update(objnotification, con, MyTrans)
End Function

Public Function Delete(ByVal objnotification As Models.notification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notification  as new DAL.notification
Return DA_notification.Delete(objnotification, con, MyTrans)
End Function

End Class
End Namespace

