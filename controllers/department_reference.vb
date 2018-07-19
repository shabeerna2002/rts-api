Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Department_reference
Public Function Insert(ByVal objdepartment_reference As Models.department_reference ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_reference  as new DAL.department_reference
Return DA_department_reference.Insert(objdepartment_reference, con, MyTrans)
End Function

Public Function Update(ByVal objdepartment_reference As Models.department_reference, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_reference  as new DAL.department_reference
Return DA_department_reference.Update(objdepartment_reference, con, MyTrans)
End Function

Public Function Delete(ByVal objdepartment_reference As Models.department_reference, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_department_reference  as new DAL.department_reference
Return DA_department_reference.Delete(objdepartment_reference, con, MyTrans)
End Function

End Class
End Namespace

