Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationlogs
Public Function Insert(ByVal objnotificationlogs As Models.notificationlogs ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogs  as new DAL.notificationlogs
Return DA_notificationlogs.Insert(objnotificationlogs, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationlogs As Models.notificationlogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogs  as new DAL.notificationlogs
Return DA_notificationlogs.Update(objnotificationlogs, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationlogs As Models.notificationlogs, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationlogs  as new DAL.notificationlogs
Return DA_notificationlogs.Delete(objnotificationlogs, con, MyTrans)
End Function

End Class
End Namespace

