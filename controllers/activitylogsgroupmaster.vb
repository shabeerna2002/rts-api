Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitylogsgroupmaster
Public Function Insert(ByVal objactivitylogsgroupmaster As Models.activitylogsgroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroupmaster  as new DAL.activitylogsgroupmaster
Return DA_activitylogsgroupmaster.Insert(objactivitylogsgroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objactivitylogsgroupmaster As Models.activitylogsgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroupmaster  as new DAL.activitylogsgroupmaster
Return DA_activitylogsgroupmaster.Update(objactivitylogsgroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitylogsgroupmaster As Models.activitylogsgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitylogsgroupmaster  as new DAL.activitylogsgroupmaster
Return DA_activitylogsgroupmaster.Delete(objactivitylogsgroupmaster, con, MyTrans)
End Function

End Class
End Namespace

