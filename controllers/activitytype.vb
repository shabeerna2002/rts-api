Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activitytype
Public Function Insert(ByVal objactivitytype As Models.activitytype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytype  as new DAL.activitytype
Return DA_activitytype.Insert(objactivitytype, con, MyTrans)
End Function

Public Function Update(ByVal objactivitytype As Models.activitytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytype  as new DAL.activitytype
Return DA_activitytype.Update(objactivitytype, con, MyTrans)
End Function

Public Function Delete(ByVal objactivitytype As Models.activitytype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activitytype  as new DAL.activitytype
Return DA_activitytype.Delete(objactivitytype, con, MyTrans)
End Function

End Class
End Namespace

