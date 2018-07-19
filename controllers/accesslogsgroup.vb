Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Accesslogsgroup
Public Function Insert(ByVal objaccesslogsgroup As Models.accesslogsgroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroup  as new DAL.accesslogsgroup
Return DA_accesslogsgroup.Insert(objaccesslogsgroup, con, MyTrans)
End Function

Public Function Update(ByVal objaccesslogsgroup As Models.accesslogsgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroup  as new DAL.accesslogsgroup
Return DA_accesslogsgroup.Update(objaccesslogsgroup, con, MyTrans)
End Function

Public Function Delete(ByVal objaccesslogsgroup As Models.accesslogsgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroup  as new DAL.accesslogsgroup
Return DA_accesslogsgroup.Delete(objaccesslogsgroup, con, MyTrans)
End Function

End Class
End Namespace

