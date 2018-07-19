Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Language
Public Function Insert(ByVal objlanguage As Models.language ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_language  as new DAL.language
Return DA_language.Insert(objlanguage, con, MyTrans)
End Function

Public Function Update(ByVal objlanguage As Models.language, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_language  as new DAL.language
Return DA_language.Update(objlanguage, con, MyTrans)
End Function

Public Function Delete(ByVal objlanguage As Models.language, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_language  as new DAL.language
Return DA_language.Delete(objlanguage, con, MyTrans)
End Function

End Class
End Namespace

