Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Interview
        Public Function Insert(ByVal objinterview As Models.Interview, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_interview As New DAL.Interview
            Return DA_interview.Insert(objinterview, con, MyTrans)
        End Function

        Public Function Update(ByVal objinterview As Models.Interview, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_interview As New DAL.Interview
            Return DA_interview.Update(objinterview, con, MyTrans)
        End Function

        Public Function Delete(ByVal objinterview As Models.Interview, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_interview As New DAL.Interview
            Return DA_interview.Delete(objinterview, con, MyTrans)
        End Function

        Public Function GetNoOfPendingCandidateEvaluationsByInterviewrs(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Integer
            Dim DA_usermaster As New DAL.Interview
            Return DA_usermaster.GetNoOfPendingCandidateEvaluationsByInterviewrs(con, MyTrans, ApplicationID)
        End Function


    End Class
End Namespace

