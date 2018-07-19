Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatesbannedhistory
Public Function Insert(ByVal objcandidatesbannedhistory As Models.candidatesbannedhistory ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbannedhistory  as new DAL.candidatesbannedhistory
Return DA_candidatesbannedhistory.Insert(objcandidatesbannedhistory, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatesbannedhistory As Models.candidatesbannedhistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbannedhistory  as new DAL.candidatesbannedhistory
Return DA_candidatesbannedhistory.Update(objcandidatesbannedhistory, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatesbannedhistory As Models.candidatesbannedhistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatesbannedhistory  as new DAL.candidatesbannedhistory
Return DA_candidatesbannedhistory.Delete(objcandidatesbannedhistory, con, MyTrans)
End Function

End Class
End Namespace

