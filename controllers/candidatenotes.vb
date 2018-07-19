Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatenotes
Public Function Insert(ByVal objcandidatenotes As Models.candidatenotes ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatenotes  as new DAL.candidatenotes
Return DA_candidatenotes.Insert(objcandidatenotes, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatenotes As Models.candidatenotes, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatenotes  as new DAL.candidatenotes
Return DA_candidatenotes.Update(objcandidatenotes, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatenotes As Models.candidatenotes, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatenotes  as new DAL.candidatenotes
Return DA_candidatenotes.Delete(objcandidatenotes, con, MyTrans)
End Function

End Class
End Namespace

