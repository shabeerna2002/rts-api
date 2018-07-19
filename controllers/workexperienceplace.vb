Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Workexperienceplace
Public Function Insert(ByVal objworkexperienceplace As Models.workexperienceplace ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperienceplace  as new DAL.workexperienceplace
Return DA_workexperienceplace.Insert(objworkexperienceplace, con, MyTrans)
End Function

Public Function Update(ByVal objworkexperienceplace As Models.workexperienceplace, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperienceplace  as new DAL.workexperienceplace
Return DA_workexperienceplace.Update(objworkexperienceplace, con, MyTrans)
End Function

Public Function Delete(ByVal objworkexperienceplace As Models.workexperienceplace, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_workexperienceplace  as new DAL.workexperienceplace
Return DA_workexperienceplace.Delete(objworkexperienceplace, con, MyTrans)
End Function

End Class
End Namespace

