Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class User
Public Function Insert(ByVal objuser As Models.user ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_user  as new DAL.user
Return DA_user.Insert(objuser, con, MyTrans)
End Function

Public Function Update(ByVal objuser As Models.user, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_user  as new DAL.user
Return DA_user.Update(objuser, con, MyTrans)
End Function

Public Function Delete(ByVal objuser As Models.user, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_user  as new DAL.user
Return DA_user.Delete(objuser, con, MyTrans)
End Function

End Class
End Namespace

