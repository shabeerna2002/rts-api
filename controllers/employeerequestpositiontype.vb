Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Employeerequestpositiontype
Public Function Insert(ByVal objemployeerequestpositiontype As Models.employeerequestpositiontype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestpositiontype  as new DAL.employeerequestpositiontype
Return DA_employeerequestpositiontype.Insert(objemployeerequestpositiontype, con, MyTrans)
End Function

Public Function Update(ByVal objemployeerequestpositiontype As Models.employeerequestpositiontype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestpositiontype  as new DAL.employeerequestpositiontype
Return DA_employeerequestpositiontype.Update(objemployeerequestpositiontype, con, MyTrans)
End Function

Public Function Delete(ByVal objemployeerequestpositiontype As Models.employeerequestpositiontype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_employeerequestpositiontype  as new DAL.employeerequestpositiontype
Return DA_employeerequestpositiontype.Delete(objemployeerequestpositiontype, con, MyTrans)
End Function

End Class
End Namespace

