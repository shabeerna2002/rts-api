Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Jobapplication
Public Function Insert(ByVal objjobapplication As Models.jobapplication ,ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplication  as new DAL.jobapplication
Return DA_jobapplication.Insert(objjobapplication, con, MyTrans)
End Function

Public Function Update(ByVal objjobapplication As Models.jobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_jobapplication  as new DAL.jobapplication
Return DA_jobapplication.Update(objjobapplication, con, MyTrans)
End Function

        Public Function Delete(ByVal objjobapplication As Models.jobapplication, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_jobapplication As New DAL.jobapplication
            Return DA_jobapplication.Delete(objjobapplication, con, MyTrans)
        End Function



        Public Function GetJobApplicationID(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, VacancyID As Integer) As Integer
            Dim DA_jobapplication As New DAL.Jobapplication
            Return DA_jobapplication.GetJobApplicationID(con, MyTrans, CandidateID, VacancyID)
        End Function

    End Class
End Namespace

