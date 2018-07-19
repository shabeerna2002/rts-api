Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatesfavouritehistory
Public Function Insert(ByVal objcandidatesfavouritehistory As Models.candidatesfavouritehistory ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavouritehistory  as new DAL.candidatesfavouritehistory
Return DA_candidatesfavouritehistory.Insert(objcandidatesfavouritehistory, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatesfavouritehistory As Models.candidatesfavouritehistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavouritehistory  as new DAL.candidatesfavouritehistory
Return DA_candidatesfavouritehistory.Update(objcandidatesfavouritehistory, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatesfavouritehistory As Models.candidatesfavouritehistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesfavouritehistory  as new DAL.candidatesfavouritehistory
Return DA_candidatesfavouritehistory.Delete(objcandidatesfavouritehistory, con, MyTrans)
End Function

End Class
End Namespace

