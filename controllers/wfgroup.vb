Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Wfgroup
Public Function Insert(ByVal objwfgroup As Models.wfgroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_wfgroup  as new DAL.wfgroup
Return DA_wfgroup.Insert(objwfgroup, con, MyTrans)
End Function

Public Function Update(ByVal objwfgroup As Models.wfgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_wfgroup  as new DAL.wfgroup
Return DA_wfgroup.Update(objwfgroup, con, MyTrans)
End Function

Public Function Delete(ByVal objwfgroup As Models.wfgroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_wfgroup  as new DAL.wfgroup
Return DA_wfgroup.Delete(objwfgroup, con, MyTrans)
End Function

End Class
End Namespace

