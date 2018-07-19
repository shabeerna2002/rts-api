Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotificationlog
Public Function Insert(ByVal objinlinenotificationlog As Models.inlinenotificationlog ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationlog  as new DAL.inlinenotificationlog
Return DA_inlinenotificationlog.Insert(objinlinenotificationlog, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotificationlog As Models.inlinenotificationlog, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationlog  as new DAL.inlinenotificationlog
Return DA_inlinenotificationlog.Update(objinlinenotificationlog, con, MyTrans)
End Function

Public Function Delete(ByVal objinlinenotificationlog As Models.inlinenotificationlog, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationlog  as new DAL.inlinenotificationlog
Return DA_inlinenotificationlog.Delete(objinlinenotificationlog, con, MyTrans)
End Function

End Class
End Namespace

