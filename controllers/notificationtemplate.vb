Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Notificationtemplate
Public Function Insert(ByVal objnotificationtemplate As Models.notificationtemplate ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtemplate  as new DAL.notificationtemplate
Return DA_notificationtemplate.Insert(objnotificationtemplate, con, MyTrans)
End Function

Public Function Update(ByVal objnotificationtemplate As Models.notificationtemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtemplate  as new DAL.notificationtemplate
Return DA_notificationtemplate.Update(objnotificationtemplate, con, MyTrans)
End Function

Public Function Delete(ByVal objnotificationtemplate As Models.notificationtemplate, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_notificationtemplate  as new DAL.notificationtemplate
Return DA_notificationtemplate.Delete(objnotificationtemplate, con, MyTrans)
End Function

End Class
End Namespace

