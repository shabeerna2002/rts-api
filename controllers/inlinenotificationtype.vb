Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotificationtype
Public Function Insert(ByVal objinlinenotificationtype As Models.inlinenotificationtype ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationtype  as new DAL.inlinenotificationtype
Return DA_inlinenotificationtype.Insert(objinlinenotificationtype, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotificationtype As Models.inlinenotificationtype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationtype  as new DAL.inlinenotificationtype
Return DA_inlinenotificationtype.Update(objinlinenotificationtype, con, MyTrans)
End Function

Public Function Delete(ByVal objinlinenotificationtype As Models.inlinenotificationtype, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationtype  as new DAL.inlinenotificationtype
Return DA_inlinenotificationtype.Delete(objinlinenotificationtype, con, MyTrans)
End Function

End Class
End Namespace

