Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Department
Public Function Insert(ByVal objdepartment As Models.department ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department  as new DAL.department
Return DA_department.Insert(objdepartment, con, MyTrans)
End Function

Public Function Update(ByVal objdepartment As Models.department, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department  as new DAL.department
Return DA_department.Update(objdepartment, con, MyTrans)
End Function

Public Function Delete(ByVal objdepartment As Models.department, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department  as new DAL.department
Return DA_department.Delete(objdepartment, con, MyTrans)
End Function

End Class
End Namespace

