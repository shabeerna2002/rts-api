Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Employeerequest
Public Function Insert(ByVal objemployeerequest As Models.employeerequest ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequest  as new DAL.employeerequest
Return DA_employeerequest.Insert(objemployeerequest, con, MyTrans)
End Function

Public Function Update(ByVal objemployeerequest As Models.employeerequest, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequest  as new DAL.employeerequest
Return DA_employeerequest.Update(objemployeerequest, con, MyTrans)
End Function

Public Function Delete(ByVal objemployeerequest As Models.employeerequest, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequest  as new DAL.employeerequest
Return DA_employeerequest.Delete(objemployeerequest, con, MyTrans)
End Function

End Class
End Namespace

