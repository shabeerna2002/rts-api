Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Statetype
Public Function Insert(ByVal objstatetype As Models.statetype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_statetype  as new DAL.statetype
Return DA_statetype.Insert(objstatetype, con, MyTrans)
End Function

Public Function Update(ByVal objstatetype As Models.statetype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_statetype  as new DAL.statetype
Return DA_statetype.Update(objstatetype, con, MyTrans)
End Function

Public Function Delete(ByVal objstatetype As Models.statetype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_statetype  as new DAL.statetype
Return DA_statetype.Delete(objstatetype, con, MyTrans)
End Function

End Class
End Namespace

