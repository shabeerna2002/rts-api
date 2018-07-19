Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobdepartment
Public Function Insert(ByVal objjobdepartment As Models.jobdepartment ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobdepartment  as new DAL.jobdepartment
Return DA_jobdepartment.Insert(objjobdepartment, con, MyTrans)
End Function

Public Function Update(ByVal objjobdepartment As Models.jobdepartment, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobdepartment  as new DAL.jobdepartment
Return DA_jobdepartment.Update(objjobdepartment, con, MyTrans)
End Function

Public Function Delete(ByVal objjobdepartment As Models.jobdepartment, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobdepartment  as new DAL.jobdepartment
Return DA_jobdepartment.Delete(objjobdepartment, con, MyTrans)
End Function

End Class
End Namespace

