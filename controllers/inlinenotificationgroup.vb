Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotificationgroup
Public Function Insert(ByVal objinlinenotificationgroup As Models.inlinenotificationgroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroup  as new DAL.inlinenotificationgroup
Return DA_inlinenotificationgroup.Insert(objinlinenotificationgroup, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotificationgroup As Models.inlinenotificationgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroup  as new DAL.inlinenotificationgroup
Return DA_inlinenotificationgroup.Update(objinlinenotificationgroup, con, MyTrans)
End Function

Public Function Delete(ByVal objinlinenotificationgroup As Models.inlinenotificationgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroup  as new DAL.inlinenotificationgroup
Return DA_inlinenotificationgroup.Delete(objinlinenotificationgroup, con, MyTrans)
End Function

End Class
End Namespace

