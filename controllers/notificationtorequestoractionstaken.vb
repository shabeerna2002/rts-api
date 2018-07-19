Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationtorequestoractionstaken
Public Function Insert(ByVal objnotificationtorequestoractionstaken As Models.notificationtorequestoractionstaken ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestoractionstaken  as new DAL.notificationtorequestoractionstaken
Return DA_notificationtorequestoractionstaken.Insert(objnotificationtorequestoractionstaken, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationtorequestoractionstaken As Models.notificationtorequestoractionstaken, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestoractionstaken  as new DAL.notificationtorequestoractionstaken
Return DA_notificationtorequestoractionstaken.Update(objnotificationtorequestoractionstaken, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationtorequestoractionstaken As Models.notificationtorequestoractionstaken, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestoractionstaken  as new DAL.notificationtorequestoractionstaken
Return DA_notificationtorequestoractionstaken.Delete(objnotificationtorequestoractionstaken, con, MyTrans)
End Function

End Class
End Namespace

