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

        Public Function GetCandidateBasicInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandiateID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateBasicInfo(con, MyTrans, CandiateID)
        End Function

        Public Function GetCandidateActivityLogs(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandiateID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateActivityLogs(con, MyTrans, CandiateID)
        End Function


        Public Function GetCandidateTimeLine(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateTimeLine(con, MyTrans, ApplicationID)
        End Function

        Public Function GetCandidateDocuments(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandiateID As Integer) As Data.DataSet
            'JobStation.DatabaseCommands.SendSMS("971553324114", "Sending Async Messages current time is " & Date.Now.ToLongTimeString)
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateDocuments(con, MyTrans, CandiateID)
        End Function



        Public Function GetActiveJobApplications(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandiateID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetActiveJobApplications(con, MyTrans, CandiateID)
        End Function



        Public Function GetCandidateApplicationStatus(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateApplicationStatus(con, MyTrans, ApplicationID)
        End Function



        Public Function GetPastJobApplications(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandiateID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetPastJobApplications(con, MyTrans, CandiateID)
        End Function



        Public Function GetCandidateList(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestInfo As Models.CandidateRequestInfo) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateList(con, MyTrans, RequestInfo)
            ' Return DA_usermaster.GetCandidateList(con, MyTrans, PageID, Count)
        End Function

        Public Function GetCandidateDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, RequestingUserID As Integer) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateDetails(con, MyTrans, CandidateID, RequestingUserID)
            ' Return DA_usermaster.GetCandidateList(con, MyTrans, PageID, Count)
        End Function

        Public Function GetCandidateAddFormDropDownContents(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Data.DataSet
            Dim DA_usermaster As New DAL.Candidate
            Return DA_usermaster.GetCandidateAddFormDropDownContents(con, MyTrans)
            ' Return DA_usermaster.GetCandidateList(con, MyTrans, PageID, Count)
        End Function





    End Class
End Namespace

