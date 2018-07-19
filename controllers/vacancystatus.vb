Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancystatus
Public Function Insert(ByVal objvacancystatus As Models.vacancystatus ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancystatus  as new DAL.vacancystatus
Return DA_vacancystatus.Insert(objvacancystatus, con, MyTrans)
End Function

Public Function Update(ByVal objvacancystatus As Models.vacancystatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancystatus  as new DAL.vacancystatus
Return DA_vacancystatus.Update(objvacancystatus, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancystatus As Models.vacancystatus, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancystatus  as new DAL.vacancystatus
Return DA_vacancystatus.Delete(objvacancystatus, con, MyTrans)
End Function

End Class
End Namespace

