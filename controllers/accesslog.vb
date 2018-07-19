Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Accesslog
Public Function Insert(ByVal objaccesslog As Models.accesslog ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslog  as new DAL.accesslog
Return DA_accesslog.Insert(objaccesslog, con, MyTrans)
End Function

Public Function Update(ByVal objaccesslog As Models.accesslog, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslog  as new DAL.accesslog
Return DA_accesslog.Update(objaccesslog, con, MyTrans)
End Function

Public Function Delete(ByVal objaccesslog As Models.accesslog, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslog  as new DAL.accesslog
Return DA_accesslog.Delete(objaccesslog, con, MyTrans)
End Function

End Class
End Namespace

