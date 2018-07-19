Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Stateactivity
Public Function Insert(ByVal objstateactivity As Models.stateactivity ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stateactivity  as new DAL.stateactivity
Return DA_stateactivity.Insert(objstateactivity, con, MyTrans)
End Function

Public Function Update(ByVal objstateactivity As Models.stateactivity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stateactivity  as new DAL.stateactivity
Return DA_stateactivity.Update(objstateactivity, con, MyTrans)
End Function

Public Function Delete(ByVal objstateactivity As Models.stateactivity, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stateactivity  as new DAL.stateactivity
Return DA_stateactivity.Delete(objstateactivity, con, MyTrans)
End Function

End Class
End Namespace

