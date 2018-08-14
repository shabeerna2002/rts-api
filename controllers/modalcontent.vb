Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Modalcontent
Public Function Insert(ByVal objmodalcontent As Models.modalcontent ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modalcontent  as new DAL.modalcontent
Return DA_modalcontent.Insert(objmodalcontent, con, MyTrans)
End Function

Public Function Update(ByVal objmodalcontent As Models.modalcontent, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modalcontent  as new DAL.modalcontent
Return DA_modalcontent.Update(objmodalcontent, con, MyTrans)
End Function

Public Function Delete(ByVal objmodalcontent As Models.modalcontent, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modalcontent  as new DAL.modalcontent
Return DA_modalcontent.Delete(objmodalcontent, con, MyTrans)
End Function

End Class
End Namespace

