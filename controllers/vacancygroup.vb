Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancygroup
Public Function Insert(ByVal objvacancygroup As Models.vacancygroup ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroup  as new DAL.vacancygroup
Return DA_vacancygroup.Insert(objvacancygroup, con, MyTrans)
End Function

Public Function Update(ByVal objvacancygroup As Models.vacancygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroup  as new DAL.vacancygroup
Return DA_vacancygroup.Update(objvacancygroup, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancygroup As Models.vacancygroup, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroup  as new DAL.vacancygroup
Return DA_vacancygroup.Delete(objvacancygroup, con, MyTrans)
End Function

End Class
End Namespace

