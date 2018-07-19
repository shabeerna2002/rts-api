Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Employeerequeststatus
Public Function Insert(ByVal objemployeerequeststatus As Models.employeerequeststatus ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequeststatus  as new DAL.employeerequeststatus
Return DA_employeerequeststatus.Insert(objemployeerequeststatus, con, MyTrans)
End Function

Public Function Update(ByVal objemployeerequeststatus As Models.employeerequeststatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequeststatus  as new DAL.employeerequeststatus
Return DA_employeerequeststatus.Update(objemployeerequeststatus, con, MyTrans)
End Function

Public Function Delete(ByVal objemployeerequeststatus As Models.employeerequeststatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequeststatus  as new DAL.employeerequeststatus
Return DA_employeerequeststatus.Delete(objemployeerequeststatus, con, MyTrans)
End Function

End Class
End Namespace

