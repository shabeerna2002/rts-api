Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Modal
Public Function Insert(ByVal objmodal As Models.modal ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modal  as new DAL.modal
Return DA_modal.Insert(objmodal, con, MyTrans)
End Function

Public Function Update(ByVal objmodal As Models.modal, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modal  as new DAL.modal
Return DA_modal.Update(objmodal, con, MyTrans)
End Function

Public Function Delete(ByVal objmodal As Models.modal, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_modal  as new DAL.modal
Return DA_modal.Delete(objmodal, con, MyTrans)
End Function

End Class
End Namespace

