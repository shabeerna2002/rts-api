Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Requeststakeholder
Public Function Insert(ByVal objrequeststakeholder As Models.requeststakeholder ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requeststakeholder  as new DAL.requeststakeholder
Return DA_requeststakeholder.Insert(objrequeststakeholder, con, MyTrans)
End Function

Public Function Update(ByVal objrequeststakeholder As Models.requeststakeholder, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requeststakeholder  as new DAL.requeststakeholder
Return DA_requeststakeholder.Update(objrequeststakeholder, con, MyTrans)
End Function

Public Function Delete(ByVal objrequeststakeholder As Models.requeststakeholder, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requeststakeholder  as new DAL.requeststakeholder
Return DA_requeststakeholder.Delete(objrequeststakeholder, con, MyTrans)
End Function

End Class
End Namespace

