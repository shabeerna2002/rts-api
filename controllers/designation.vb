Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Designation
Public Function Insert(ByVal objdesignation As Models.designation ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designation  as new DAL.designation
Return DA_designation.Insert(objdesignation, con, MyTrans)
End Function

Public Function Update(ByVal objdesignation As Models.designation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designation  as new DAL.designation
Return DA_designation.Update(objdesignation, con, MyTrans)
End Function

Public Function Delete(ByVal objdesignation As Models.designation, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_designation  as new DAL.designation
Return DA_designation.Delete(objdesignation, con, MyTrans)
End Function

End Class
End Namespace

