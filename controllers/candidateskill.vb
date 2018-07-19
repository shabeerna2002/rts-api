Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidateskill
Public Function Insert(ByVal objcandidateskill As Models.candidateskill ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskill  as new DAL.candidateskill
Return DA_candidateskill.Insert(objcandidateskill, con, MyTrans)
End Function

Public Function Update(ByVal objcandidateskill As Models.candidateskill, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskill  as new DAL.candidateskill
Return DA_candidateskill.Update(objcandidateskill, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidateskill As Models.candidateskill, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidateskill  as new DAL.candidateskill
Return DA_candidateskill.Delete(objcandidateskill, con, MyTrans)
End Function

End Class
End Namespace

