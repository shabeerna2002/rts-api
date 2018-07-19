Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Action
Public Function Insert(ByVal objaction As Models.action ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_action  as new DAL.action
Return DA_action.Insert(objaction, con, MyTrans)
End Function

Public Function Update(ByVal objaction As Models.action, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_action  as new DAL.action
Return DA_action.Update(objaction, con, MyTrans)
End Function

Public Function Delete(ByVal objaction As Models.action, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_action  as new DAL.action
Return DA_action.Delete(objaction, con, MyTrans)
End Function

End Class
End Namespace

