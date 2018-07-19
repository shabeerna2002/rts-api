Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Requestaction
Public Function Insert(ByVal objrequestaction As Models.requestaction ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestaction  as new DAL.requestaction
Return DA_requestaction.Insert(objrequestaction, con, MyTrans)
End Function

Public Function Update(ByVal objrequestaction As Models.requestaction, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestaction  as new DAL.requestaction
Return DA_requestaction.Update(objrequestaction, con, MyTrans)
End Function

Public Function Delete(ByVal objrequestaction As Models.requestaction, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestaction  as new DAL.requestaction
Return DA_requestaction.Delete(objrequestaction, con, MyTrans)
End Function

End Class
End Namespace

