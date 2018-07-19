Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Activity
Public Function Insert(ByVal objactivity As Models.activity ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activity  as new DAL.activity
Return DA_activity.Insert(objactivity, con, MyTrans)
End Function

Public Function Update(ByVal objactivity As Models.activity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activity  as new DAL.activity
Return DA_activity.Update(objactivity, con, MyTrans)
End Function

Public Function Delete(ByVal objactivity As Models.activity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_activity  as new DAL.activity
Return DA_activity.Delete(objactivity, con, MyTrans)
End Function

End Class
End Namespace

