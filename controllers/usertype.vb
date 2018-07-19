Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Usertype
Public Function Insert(ByVal objusertype As Models.usertype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_usertype  as new DAL.usertype
Return DA_usertype.Insert(objusertype, con, MyTrans)
End Function

Public Function Update(ByVal objusertype As Models.usertype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_usertype  as new DAL.usertype
Return DA_usertype.Update(objusertype, con, MyTrans)
End Function

Public Function Delete(ByVal objusertype As Models.usertype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_usertype  as new DAL.usertype
Return DA_usertype.Delete(objusertype, con, MyTrans)
End Function

End Class
End Namespace

