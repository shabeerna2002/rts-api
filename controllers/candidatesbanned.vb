Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatesbanned
Public Function Insert(ByVal objcandidatesbanned As Models.candidatesbanned ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbanned  as new DAL.candidatesbanned
Return DA_candidatesbanned.Insert(objcandidatesbanned, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatesbanned As Models.candidatesbanned, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbanned  as new DAL.candidatesbanned
Return DA_candidatesbanned.Update(objcandidatesbanned, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatesbanned As Models.candidatesbanned, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbanned  as new DAL.candidatesbanned
Return DA_candidatesbanned.Delete(objcandidatesbanned, con, MyTrans)
End Function

End Class
End Namespace

