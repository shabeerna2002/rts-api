Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatehiredetails
Public Function Insert(ByVal objcandidatehiredetails As Models.candidatehiredetails ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatehiredetails  as new DAL.candidatehiredetails
Return DA_candidatehiredetails.Insert(objcandidatehiredetails, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatehiredetails As Models.candidatehiredetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatehiredetails  as new DAL.candidatehiredetails
Return DA_candidatehiredetails.Update(objcandidatehiredetails, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatehiredetails As Models.candidatehiredetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatehiredetails  as new DAL.candidatehiredetails
Return DA_candidatehiredetails.Delete(objcandidatehiredetails, con, MyTrans)
End Function

End Class
End Namespace

