Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancygroupmaster
Public Function Insert(ByVal objvacancygroupmaster As Models.vacancygroupmaster ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroupmaster  as new DAL.vacancygroupmaster
Return DA_vacancygroupmaster.Insert(objvacancygroupmaster, con, MyTrans)
End Function

Public Function Update(ByVal objvacancygroupmaster As Models.vacancygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroupmaster  as new DAL.vacancygroupmaster
Return DA_vacancygroupmaster.Update(objvacancygroupmaster, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancygroupmaster As Models.vacancygroupmaster, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancygroupmaster  as new DAL.vacancygroupmaster
Return DA_vacancygroupmaster.Delete(objvacancygroupmaster, con, MyTrans)
End Function

End Class
End Namespace

