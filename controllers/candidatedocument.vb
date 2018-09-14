Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
 Public Class Candidatedocument
        Public Function Insert(ByVal objcandidatedocument As Models.Candidatedocument, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidatedocument As New DAL.Candidatedocument
            Return DA_candidatedocument.Insert(objcandidatedocument, con, MyTrans)
        End Function

        Public Function Update(ByVal objcandidatedocument As Models.candidatedocument, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim DA_candidatedocument  as new DAL.candidatedocument
Return DA_candidatedocument.Update(objcandidatedocument, con, MyTrans)
End Function

        Public Function Delete(ByVal objcandidatedocument As Models.candidatedocument, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_candidatedocument As New DAL.candidatedocument
            Return DA_candidatedocument.Delete(objcandidatedocument, con, MyTrans)
        End Function

        Public Function GetCandidateDocumentsActive(CandidateID As Integer, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim DA_candidatedocument As New DAL.Candidatedocument
            Return DA_candidatedocument.GetCandidateDocumentsActive(con, MyTrans, CandidateID)
        End Function



    End Class
End Namespace

