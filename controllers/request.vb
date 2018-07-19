Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Request
Public Function Insert(ByVal objrequest As Models.request ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_request  as new DAL.request
Return DA_request.Insert(objrequest, con, MyTrans)
End Function

Public Function Update(ByVal objrequest As Models.request, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_request  as new DAL.request
Return DA_request.Update(objrequest, con, MyTrans)
End Function

Public Function Delete(ByVal objrequest As Models.request, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_request  as new DAL.request
Return DA_request.Delete(objrequest, con, MyTrans)
End Function

End Class
End Namespace

