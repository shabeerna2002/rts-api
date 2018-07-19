Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Vacancypublishlogssummary
Public Function Insert(ByVal objvacancypublishlogssummary As Models.vacancypublishlogssummary ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogssummary  as new DAL.vacancypublishlogssummary
Return DA_vacancypublishlogssummary.Insert(objvacancypublishlogssummary, con, MyTrans)
End Function

Public Function Update(ByVal objvacancypublishlogssummary As Models.vacancypublishlogssummary, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogssummary  as new DAL.vacancypublishlogssummary
Return DA_vacancypublishlogssummary.Update(objvacancypublishlogssummary, con, MyTrans)
End Function

Public Function Delete(ByVal objvacancypublishlogssummary As Models.vacancypublishlogssummary, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_vacancypublishlogssummary  as new DAL.vacancypublishlogssummary
Return DA_vacancypublishlogssummary.Delete(objvacancypublishlogssummary, con, MyTrans)
End Function

End Class
End Namespace

