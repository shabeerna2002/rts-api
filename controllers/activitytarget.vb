Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitytarget
Public Function Insert(ByVal objactivitytarget As Models.activitytarget ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytarget  as new DAL.activitytarget
Return DA_activitytarget.Insert(objactivitytarget, con, MyTrans)
End Function

Public Function Update(ByVal objactivitytarget As Models.activitytarget, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytarget  as new DAL.activitytarget
Return DA_activitytarget.Update(objactivitytarget, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitytarget As Models.activitytarget, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytarget  as new DAL.activitytarget
Return DA_activitytarget.Delete(objactivitytarget, con, MyTrans)
End Function

End Class
End Namespace

