Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Target
Public Function Insert(ByVal objtarget As Models.target ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_target  as new DAL.target
Return DA_target.Insert(objtarget, con, MyTrans)
End Function

Public Function Update(ByVal objtarget As Models.target, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_target  as new DAL.target
Return DA_target.Update(objtarget, con, MyTrans)
End Function

Public Function Delete(ByVal objtarget As Models.target, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_target  as new DAL.target
Return DA_target.Delete(objtarget, con, MyTrans)
End Function

End Class
End Namespace

