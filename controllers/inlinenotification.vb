Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotification
Public Function Insert(ByVal objinlinenotification As Models.inlinenotification ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotification  as new DAL.inlinenotification
Return DA_inlinenotification.Insert(objinlinenotification, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotification As Models.inlinenotification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotification  as new DAL.inlinenotification
Return DA_inlinenotification.Update(objinlinenotification, con, MyTrans)
End Function

Public Function Delete(ByVal objinlinenotification As Models.inlinenotification, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotification  as new DAL.inlinenotification
Return DA_inlinenotification.Delete(objinlinenotification, con, MyTrans)
End Function

End Class
End Namespace

