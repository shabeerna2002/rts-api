Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancy
Public Function Insert(ByVal objvacancy As Models.vacancy ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancy  as new DAL.vacancy
Return DA_vacancy.Insert(objvacancy, con, MyTrans)
End Function

Public Function Update(ByVal objvacancy As Models.vacancy, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancy  as new DAL.vacancy
Return DA_vacancy.Update(objvacancy, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancy As Models.vacancy, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancy  as new DAL.vacancy
Return DA_vacancy.Delete(objvacancy, con, MyTrans)
End Function

End Class
End Namespace

