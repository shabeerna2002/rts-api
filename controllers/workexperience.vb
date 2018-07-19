Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Workexperience
Public Function Insert(ByVal objworkexperience As Models.workexperience ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperience  as new DAL.workexperience
Return DA_workexperience.Insert(objworkexperience, con, MyTrans)
End Function

Public Function Update(ByVal objworkexperience As Models.workexperience, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperience  as new DAL.workexperience
Return DA_workexperience.Update(objworkexperience, con, MyTrans)
End Function

Public Function Delete(ByVal objworkexperience As Models.workexperience, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperience  as new DAL.workexperience
Return DA_workexperience.Delete(objworkexperience, con, MyTrans)
End Function

End Class
End Namespace

