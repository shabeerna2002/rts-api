Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationtorequestordeliverylogs
Public Function Insert(ByVal objnotificationtorequestordeliverylogs As Models.notificationtorequestordeliverylogs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestordeliverylogs  as new DAL.notificationtorequestordeliverylogs
Return DA_notificationtorequestordeliverylogs.Insert(objnotificationtorequestordeliverylogs, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationtorequestordeliverylogs As Models.notificationtorequestordeliverylogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestordeliverylogs  as new DAL.notificationtorequestordeliverylogs
Return DA_notificationtorequestordeliverylogs.Update(objnotificationtorequestordeliverylogs, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationtorequestordeliverylogs As Models.notificationtorequestordeliverylogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestordeliverylogs  as new DAL.notificationtorequestordeliverylogs
Return DA_notificationtorequestordeliverylogs.Delete(objnotificationtorequestordeliverylogs, con, MyTrans)
End Function

End Class
End Namespace

