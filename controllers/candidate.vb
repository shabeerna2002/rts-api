Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Candidate
        Public Function Insert(ByVal objcandidate As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidate As New DAL.Candidate
            Return DA_candidate.Insert(objcandidate, con, MyTrans)
        End Function

        Public Function Update(ByVal objcandidate As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidate As New DAL.Candidate
            Return DA_candidate.Update(objcandidate, con, MyTrans)
        End Function

        Public Function Delete(ByVal objcandidate As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidate As New DAL.Candidate
            Return DA_candidate.Delete(objcandidate, con, MyTrans)
        End Function

    End Class
End Namespace

