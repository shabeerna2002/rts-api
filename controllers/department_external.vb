Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Department_external
Public Function Insert(ByVal objdepartment_external As Models.department_external ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_external  as new DAL.department_external
Return DA_department_external.Insert(objdepartment_external, con, MyTrans)
End Function

Public Function Update(ByVal objdepartment_external As Models.department_external, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_external  as new DAL.department_external
Return DA_department_external.Update(objdepartment_external, con, MyTrans)
End Function

Public Function Delete(ByVal objdepartment_external As Models.department_external, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_external  as new DAL.department_external
Return DA_department_external.Delete(objdepartment_external, con, MyTrans)
End Function

End Class
End Namespace

