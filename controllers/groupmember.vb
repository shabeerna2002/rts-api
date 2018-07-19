Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Groupmember
Public Function Insert(ByVal objgroupmember As Models.groupmember ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_groupmember  as new DAL.groupmember
Return DA_groupmember.Insert(objgroupmember, con, MyTrans)
End Function

Public Function Update(ByVal objgroupmember As Models.groupmember, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_groupmember  as new DAL.groupmember
Return DA_groupmember.Update(objgroupmember, con, MyTrans)
End Function

Public Function Delete(ByVal objgroupmember As Models.groupmember, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_groupmember  as new DAL.groupmember
Return DA_groupmember.Delete(objgroupmember, con, MyTrans)
End Function

End Class
End Namespace

