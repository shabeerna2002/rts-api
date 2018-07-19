Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Joblocation
Public Function Insert(ByVal objjoblocation As Models.joblocation ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_joblocation  as new DAL.joblocation
Return DA_joblocation.Insert(objjoblocation, con, MyTrans)
End Function

Public Function Update(ByVal objjoblocation As Models.joblocation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_joblocation  as new DAL.joblocation
Return DA_joblocation.Update(objjoblocation, con, MyTrans)
End Function

Public Function Delete(ByVal objjoblocation As Models.joblocation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_joblocation  as new DAL.joblocation
Return DA_joblocation.Delete(objjoblocation, con, MyTrans)
End Function

End Class
End Namespace

