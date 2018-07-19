Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Inlinenotificationgroupmaster
Public Function Insert(ByVal objinlinenotificationgroupmaster As Models.inlinenotificationgroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroupmaster  as new DAL.inlinenotificationgroupmaster
Return DA_inlinenotificationgroupmaster.Insert(objinlinenotificationgroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objinlinenotificationgroupmaster As Models.inlinenotificationgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroupmaster  as new DAL.inlinenotificationgroupmaster
Return DA_inlinenotificationgroupmaster.Update(objinlinenotificationgroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objinlinenotificationgroupmaster As Models.inlinenotificationgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_inlinenotificationgroupmaster  as new DAL.inlinenotificationgroupmaster
Return DA_inlinenotificationgroupmaster.Delete(objinlinenotificationgroupmaster, con, MyTrans)
End Function

End Class
End Namespace

