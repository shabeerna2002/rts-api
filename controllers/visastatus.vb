Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Visastatus
Public Function Insert(ByVal objvisastatus As Models.visastatus ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_visastatus  as new DAL.visastatus
Return DA_visastatus.Insert(objvisastatus, con, MyTrans)
End Function

Public Function Update(ByVal objvisastatus As Models.visastatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_visastatus  as new DAL.visastatus
Return DA_visastatus.Update(objvisastatus, con, MyTrans)
End Function

Public Function Delete(ByVal objvisastatus As Models.visastatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_visastatus  as new DAL.visastatus
Return DA_visastatus.Delete(objvisastatus, con, MyTrans)
End Function

End Class
End Namespace

