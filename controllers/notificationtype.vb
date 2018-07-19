Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationtype
Public Function Insert(ByVal objnotificationtype As Models.notificationtype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtype  as new DAL.notificationtype
Return DA_notificationtype.Insert(objnotificationtype, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationtype As Models.notificationtype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtype  as new DAL.notificationtype
Return DA_notificationtype.Update(objnotificationtype, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationtype As Models.notificationtype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtype  as new DAL.notificationtype
Return DA_notificationtype.Delete(objnotificationtype, con, MyTrans)
End Function

End Class
End Namespace

