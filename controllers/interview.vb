Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Interview
Public Function Insert(ByVal objinterview As Models.interview ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_interview  as new DAL.interview
Return DA_interview.Insert(objinterview, con, MyTrans)
End Function

Public Function Update(ByVal objinterview As Models.interview, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_interview  as new DAL.interview
Return DA_interview.Update(objinterview, con, MyTrans)
End Function

Public Function Delete(ByVal objinterview As Models.interview, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_interview  as new DAL.interview
Return DA_interview.Delete(objinterview, con, MyTrans)
End Function

End Class
End Namespace

