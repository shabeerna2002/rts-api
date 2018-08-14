Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Jobapplicationtimelineupdatetype
        Public Function Insert(ByVal objjobapplicationtimelineupdatetype As Models.Jobapplicationtimelineupdatetype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobapplicationtimelineupdatetype As New DAL.Jobapplicationtimelineupdatetype
            Return DA_jobapplicationtimelineupdatetype.Insert(objjobapplicationtimelineupdatetype, con, MyTrans)
        End Function

        Public Function Update(ByVal objjobapplicationtimelineupdatetype As Models.Jobapplicationtimelineupdatetype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobapplicationtimelineupdatetype As New DAL.Jobapplicationtimelineupdatetype
            Return DA_jobapplicationtimelineupdatetype.Update(objjobapplicationtimelineupdatetype, con, MyTrans)
        End Function

        Public Function Delete(ByVal objjobapplicationtimelineupdatetype As Models.Jobapplicationtimelineupdatetype, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobapplicationtimelineupdatetype As New DAL.Jobapplicationtimelineupdatetype
            Return DA_jobapplicationtimelineupdatetype.Delete(objjobapplicationtimelineupdatetype, con, MyTrans)
        End Function

    End Class
End Namespace
