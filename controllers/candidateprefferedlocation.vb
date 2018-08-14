Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Candidateprefferedlocation
        Public Function Insert(ByVal objcandidateprefferedlocation As Models.Candidateprefferedlocation, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidateprefferedlocation As New DAL.candidateprefferedlocation
            Return DA_candidateprefferedlocation.Insert(objcandidateprefferedlocation, con, MyTrans)
        End Function

        Public Function Update(ByVal objcandidateprefferedlocation As Models.Candidateprefferedlocation, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidateprefferedlocation As New DAL.candidateprefferedlocation
            Return DA_candidateprefferedlocation.Update(objcandidateprefferedlocation, con, MyTrans)
        End Function

        Public Function Delete(ByVal objcandidateprefferedlocation As Models.Candidateprefferedlocation, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidateprefferedlocation As New DAL.candidateprefferedlocation
            Return DA_candidateprefferedlocation.Delete(objcandidateprefferedlocation, con, MyTrans)
        End Function

    End Class
End Namespace
