Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class State
Public Function Insert(ByVal objstate As Models.state ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_state  as new DAL.state
Return DA_state.Insert(objstate, con, MyTrans)
End Function

Public Function Update(ByVal objstate As Models.state, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_state  as new DAL.state
Return DA_state.Update(objstate, con, MyTrans)
End Function

Public Function Delete(ByVal objstate As Models.state, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_state  as new DAL.state
Return DA_state.Delete(objstate, con, MyTrans)
End Function

End Class
End Namespace

