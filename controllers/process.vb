Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Process
Public Function Insert(ByVal objprocess As Models.process ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_process  as new DAL.process
Return DA_process.Insert(objprocess, con, MyTrans)
End Function

Public Function Update(ByVal objprocess As Models.process, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_process  as new DAL.process
Return DA_process.Update(objprocess, con, MyTrans)
End Function

Public Function Delete(ByVal objprocess As Models.process, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_process  as new DAL.process
Return DA_process.Delete(objprocess, con, MyTrans)
End Function

End Class
End Namespace

