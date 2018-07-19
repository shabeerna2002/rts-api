Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Workhistory
Public Function Insert(ByVal objworkhistory As Models.workhistory ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workhistory  as new DAL.workhistory
Return DA_workhistory.Insert(objworkhistory, con, MyTrans)
End Function

Public Function Update(ByVal objworkhistory As Models.workhistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workhistory  as new DAL.workhistory
Return DA_workhistory.Update(objworkhistory, con, MyTrans)
End Function

Public Function Delete(ByVal objworkhistory As Models.workhistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workhistory  as new DAL.workhistory
Return DA_workhistory.Delete(objworkhistory, con, MyTrans)
End Function

End Class
End Namespace

