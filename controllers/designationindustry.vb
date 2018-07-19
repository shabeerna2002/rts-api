Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Designationindustry
Public Function Insert(ByVal objdesignationindustry As Models.designationindustry ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designationindustry  as new DAL.designationindustry
Return DA_designationindustry.Insert(objdesignationindustry, con, MyTrans)
End Function

Public Function Update(ByVal objdesignationindustry As Models.designationindustry, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designationindustry  as new DAL.designationindustry
Return DA_designationindustry.Update(objdesignationindustry, con, MyTrans)
End Function

Public Function Delete(ByVal objdesignationindustry As Models.designationindustry, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designationindustry  as new DAL.designationindustry
Return DA_designationindustry.Delete(objdesignationindustry, con, MyTrans)
End Function

End Class
End Namespace

