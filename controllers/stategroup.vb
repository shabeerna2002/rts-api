Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Stategroup
Public Function Insert(ByVal objstategroup As Models.stategroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroup  as new DAL.stategroup
Return DA_stategroup.Insert(objstategroup, con, MyTrans)
End Function

Public Function Update(ByVal objstategroup As Models.stategroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroup  as new DAL.stategroup
Return DA_stategroup.Update(objstategroup, con, MyTrans)
End Function

Public Function Delete(ByVal objstategroup As Models.stategroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroup  as new DAL.stategroup
Return DA_stategroup.Delete(objstategroup, con, MyTrans)
End Function

End Class
End Namespace

