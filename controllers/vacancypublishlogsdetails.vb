Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancypublishlogsdetails
Public Function Insert(ByVal objvacancypublishlogsdetails As Models.vacancypublishlogsdetails ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogsdetails  as new DAL.vacancypublishlogsdetails
Return DA_vacancypublishlogsdetails.Insert(objvacancypublishlogsdetails, con, MyTrans)
End Function

Public Function Update(ByVal objvacancypublishlogsdetails As Models.vacancypublishlogsdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogsdetails  as new DAL.vacancypublishlogsdetails
Return DA_vacancypublishlogsdetails.Update(objvacancypublishlogsdetails, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancypublishlogsdetails As Models.vacancypublishlogsdetails, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogsdetails  as new DAL.vacancypublishlogsdetails
Return DA_vacancypublishlogsdetails.Delete(objvacancypublishlogsdetails, con, MyTrans)
End Function

End Class
End Namespace

