Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Vacancy
        Public Function Insert(ByVal objvacancy As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_vacancy As New DAL.Vacancy
            Return DA_vacancy.Insert(objvacancy, con, MyTrans)
        End Function

        Public Function Insert_vacancy_AddVacancy(ByVal objvacancy As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_vacancy As New DAL.Vacancy
            Return DA_vacancy.AddVacancy(objvacancy, con, MyTrans)
        End Function

        Public Function Update_vacancy_UpdateVacancy(ByVal objvacancy As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_vacancy As New DAL.Vacancy
            Return DA_vacancy.UpdateVacancy(objvacancy, con, MyTrans)
        End Function

        Public Function Update(ByVal objvacancy As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_vacancy As New DAL.Vacancy
            Return DA_vacancy.Update(objvacancy, con, MyTrans)
        End Function

        Public Function Delete(ByVal objvacancy As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_vacancy As New DAL.Vacancy
            Return DA_vacancy.Delete(objvacancy, con, MyTrans)
        End Function

        Public Function GetJobInfoSummaryJobTitles(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.GetJobInfoSummaryJobTitles(con, MyTrans)
        End Function

        Public Function GetJobInfoSummaryDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyIDList As String) As Data.DataSet
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.GetJobInfoSummaryDetails(con, MyTrans, VacancyIDList)
        End Function

        Public Function GetJobInfoSummary(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.GetJobInfoSummary(con, MyTrans)
        End Function

        Public Function GetVacancyDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.GetVacancyDetails(con, MyTrans, VacancyID)
        End Function

        Public Function GetJobListSummary(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, DepartmentID As Integer, EntityID As Integer, JobTitle As String, isClosed As Boolean) As Data.DataSet
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.GetJobListSummary(con, MyTrans, VacancyID, DepartmentID, EntityID, JobTitle, isClosed)
        End Function
        Public Function PublishJob(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, isPublish As Boolean) As String
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.PublishJob(con, MyTrans, VacancyID, isPublish)
        End Function

        Public Function CloseJob(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, isCloseJob As Boolean) As String
            Dim DA_usermaster As New DAL.Vacancy
            Return DA_usermaster.CloseJob(con, MyTrans, VacancyID, isCloseJob)
        End Function




    End Class
End Namespace

