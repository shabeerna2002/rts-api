Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatesfavourite
Public Function Insert(ByVal objcandidatesfavourite As Models.candidatesfavourite ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavourite  as new DAL.candidatesfavourite
Return DA_candidatesfavourite.Insert(objcandidatesfavourite, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatesfavourite As Models.candidatesfavourite, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavourite  as new DAL.candidatesfavourite
Return DA_candidatesfavourite.Update(objcandidatesfavourite, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatesfavourite As Models.candidatesfavourite, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavourite  as new DAL.candidatesfavourite
Return DA_candidatesfavourite.Delete(objcandidatesfavourite, con, MyTrans)
End Function

End Class
End Namespace

