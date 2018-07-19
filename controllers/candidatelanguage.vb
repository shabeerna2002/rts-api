Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatelanguage
Public Function Insert(ByVal objcandidatelanguage As Models.candidatelanguage ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatelanguage  as new DAL.candidatelanguage
Return DA_candidatelanguage.Insert(objcandidatelanguage, con, MyTrans)
End Function

Public Function Update(ByVal objcandidatelanguage As Models.candidatelanguage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatelanguage  as new DAL.candidatelanguage
Return DA_candidatelanguage.Update(objcandidatelanguage, con, MyTrans)
End Function

Public Function Delete(ByVal objcandidatelanguage As Models.candidatelanguage, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatelanguage  as new DAL.candidatelanguage
Return DA_candidatelanguage.Delete(objcandidatelanguage, con, MyTrans)
End Function

End Class
End Namespace

