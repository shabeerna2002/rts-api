Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Disqualifiedjobapplication
Public Function Insert(ByVal objdisqualifiedjobapplication As Models.disqualifiedjobapplication ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_disqualifiedjobapplication  as new DAL.disqualifiedjobapplication
Return DA_disqualifiedjobapplication.Insert(objdisqualifiedjobapplication, con, MyTrans)
End Function

Public Function Update(ByVal objdisqualifiedjobapplication As Models.disqualifiedjobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_disqualifiedjobapplication  as new DAL.disqualifiedjobapplication
Return DA_disqualifiedjobapplication.Update(objdisqualifiedjobapplication, con, MyTrans)
End Function

Public Function Delete(ByVal objdisqualifiedjobapplication As Models.disqualifiedjobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_disqualifiedjobapplication  as new DAL.disqualifiedjobapplication
Return DA_disqualifiedjobapplication.Delete(objdisqualifiedjobapplication, con, MyTrans)
End Function

End Class
End Namespace

