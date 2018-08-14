Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class JobInterviewer
        Public Function Insert(ByVal objjobinterviewer As Models.JobInterviewer, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobinterviewer As New DAL.jobinterviewer
            Return DA_jobinterviewer.Insert(objjobinterviewer, con, MyTrans)
        End Function

        Public Function Update(ByVal objjobinterviewer As Models.JobInterviewer, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobinterviewer As New DAL.jobinterviewer
            Return DA_jobinterviewer.Update(objjobinterviewer, con, MyTrans)
        End Function

        Public Function Delete(ByVal objjobinterviewer As Models.JobInterviewer, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobinterviewer As New DAL.jobinterviewer
            Return DA_jobinterviewer.Delete(objjobinterviewer, con, MyTrans)
        End Function

    End Class
End Namespace
