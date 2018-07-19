Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Stategroupmaster
Public Function Insert(ByVal objstategroupmaster As Models.stategroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroupmaster  as new DAL.stategroupmaster
Return DA_stategroupmaster.Insert(objstategroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objstategroupmaster As Models.stategroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroupmaster  as new DAL.stategroupmaster
Return DA_stategroupmaster.Update(objstategroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objstategroupmaster As Models.stategroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_stategroupmaster  as new DAL.stategroupmaster
Return DA_stategroupmaster.Delete(objstategroupmaster, con, MyTrans)
End Function

End Class
End Namespace

