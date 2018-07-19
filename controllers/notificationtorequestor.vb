Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationtorequestor
Public Function Insert(ByVal objnotificationtorequestor As Models.notificationtorequestor ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestor  as new DAL.notificationtorequestor
Return DA_notificationtorequestor.Insert(objnotificationtorequestor, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationtorequestor As Models.notificationtorequestor, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestor  as new DAL.notificationtorequestor
Return DA_notificationtorequestor.Update(objnotificationtorequestor, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationtorequestor As Models.notificationtorequestor, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtorequestor  as new DAL.notificationtorequestor
Return DA_notificationtorequestor.Delete(objnotificationtorequestor, con, MyTrans)
End Function

End Class
End Namespace

