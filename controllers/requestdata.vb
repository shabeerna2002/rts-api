Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Requestdata
Public Function Insert(ByVal objrequestdata As Models.requestdata ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestdata  as new DAL.requestdata
Return DA_requestdata.Insert(objrequestdata, con, MyTrans)
End Function

Public Function Update(ByVal objrequestdata As Models.requestdata, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestdata  as new DAL.requestdata
Return DA_requestdata.Update(objrequestdata, con, MyTrans)
End Function

Public Function Delete(ByVal objrequestdata As Models.requestdata, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_requestdata  as new DAL.requestdata
Return DA_requestdata.Delete(objrequestdata, con, MyTrans)
End Function

End Class
End Namespace

