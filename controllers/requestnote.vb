Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Requestnote
Public Function Insert(ByVal objrequestnote As Models.requestnote ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestnote  as new DAL.requestnote
Return DA_requestnote.Insert(objrequestnote, con, MyTrans)
End Function

Public Function Update(ByVal objrequestnote As Models.requestnote, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestnote  as new DAL.requestnote
Return DA_requestnote.Update(objrequestnote, con, MyTrans)
End Function

Public Function Delete(ByVal objrequestnote As Models.requestnote, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestnote  as new DAL.requestnote
Return DA_requestnote.Delete(objrequestnote, con, MyTrans)
End Function

End Class
End Namespace

