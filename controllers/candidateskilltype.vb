Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidateskilltype
Public Function Insert(ByVal objcandidateskilltype As Models.candidateskilltype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskilltype  as new DAL.candidateskilltype
Return DA_candidateskilltype.Insert(objcandidateskilltype, con, MyTrans)
End Function

Public Function Update(ByVal objcandidateskilltype As Models.candidateskilltype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskilltype  as new DAL.candidateskilltype
Return DA_candidateskilltype.Update(objcandidateskilltype, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidateskilltype As Models.candidateskilltype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskilltype  as new DAL.candidateskilltype
Return DA_candidateskilltype.Delete(objcandidateskilltype, con, MyTrans)
End Function

End Class
End Namespace

