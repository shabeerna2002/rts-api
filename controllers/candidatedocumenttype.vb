Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatedocumenttype
Public Function Insert(ByVal objcandidatedocumenttype As Models.candidatedocumenttype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatedocumenttype  as new DAL.candidatedocumenttype
Return DA_candidatedocumenttype.Insert(objcandidatedocumenttype, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatedocumenttype As Models.candidatedocumenttype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatedocumenttype  as new DAL.candidatedocumenttype
Return DA_candidatedocumenttype.Update(objcandidatedocumenttype, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatedocumenttype As Models.candidatedocumenttype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatedocumenttype  as new DAL.candidatedocumenttype
Return DA_candidatedocumenttype.Delete(objcandidatedocumenttype, con, MyTrans)
End Function

End Class
End Namespace

