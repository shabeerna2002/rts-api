Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Actiontarget
Public Function Insert(ByVal objactiontarget As Models.actiontarget ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontarget  as new DAL.actiontarget
Return DA_actiontarget.Insert(objactiontarget, con, MyTrans)
End Function

Public Function Update(ByVal objactiontarget As Models.actiontarget, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontarget  as new DAL.actiontarget
Return DA_actiontarget.Update(objactiontarget, con, MyTrans)
End Function

Public Function Delete(ByVal objactiontarget As Models.actiontarget, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_actiontarget  as new DAL.actiontarget
Return DA_actiontarget.Delete(objactiontarget, con, MyTrans)
End Function

End Class
End Namespace

