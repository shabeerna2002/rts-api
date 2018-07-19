Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Requestfile
Public Function Insert(ByVal objrequestfile As Models.requestfile ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestfile  as new DAL.requestfile
Return DA_requestfile.Insert(objrequestfile, con, MyTrans)
End Function

Public Function Update(ByVal objrequestfile As Models.requestfile, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestfile  as new DAL.requestfile
Return DA_requestfile.Update(objrequestfile, con, MyTrans)
End Function

Public Function Delete(ByVal objrequestfile As Models.requestfile, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestfile  as new DAL.requestfile
Return DA_requestfile.Delete(objrequestfile, con, MyTrans)
End Function

End Class
End Namespace

