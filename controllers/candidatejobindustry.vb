Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Candidatejobindustry
        Public Function Insert(ByVal objcandidatejobindustry As Models.Candidatejobindustry, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidatejobindustry As New DAL.Candidatejobindustry
            Return DA_candidatejobindustry.Insert(objcandidatejobindustry, con, MyTrans)
        End Function

        Public Function Update(ByVal objcandidatejobindustry As Models.Candidatejobindustry, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidatejobindustry As New DAL.Candidatejobindustry
            Return DA_candidatejobindustry.Update(objcandidatejobindustry, con, MyTrans)
        End Function

        Public Function Delete(ByVal objcandidatejobindustry As Models.Candidatejobindustry, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidatejobindustry As New DAL.Candidatejobindustry
            Return DA_candidatejobindustry.Delete(objcandidatejobindustry, con, MyTrans)
        End Function

    End Class
End Namespace
