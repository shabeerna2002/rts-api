Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Accesslogsgroupmaster
Public Function Insert(ByVal objaccesslogsgroupmaster As Models.accesslogsgroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroupmaster  as new DAL.accesslogsgroupmaster
Return DA_accesslogsgroupmaster.Insert(objaccesslogsgroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objaccesslogsgroupmaster As Models.accesslogsgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroupmaster  as new DAL.accesslogsgroupmaster
Return DA_accesslogsgroupmaster.Update(objaccesslogsgroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objaccesslogsgroupmaster As Models.accesslogsgroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_accesslogsgroupmaster  as new DAL.accesslogsgroupmaster
Return DA_accesslogsgroupmaster.Delete(objaccesslogsgroupmaster, con, MyTrans)
End Function

End Class
End Namespace

