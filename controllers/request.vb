Imports MySql.Data.MySqlClient
Namespace JobStation.Controller
    Public Class Request
        Public Function Insert(ByVal objrequest As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_request As New DAL.Request
            Return DA_request.Insert(objrequest, con, MyTrans)
        End Function

        Public Function Update(ByVal objrequest As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_request As New DAL.Request
            Return DA_request.Update(objrequest, con, MyTrans)
        End Function

        Public Function Delete(ByVal objrequest As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim DA_request As New DAL.Request
            Return DA_request.Delete(objrequest, con, MyTrans)
        End Function

        Private Function Update_request_currentstate(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestID As Integer, StateID As Integer, isCurrentStatePartialUpdate As Boolean, TransactionUserID As Integer) As String
            Dim DA_request As New DAL.Request
            Return DA_request.Update_request_currentstate(con, MyTrans, RequestID, StateID, isCurrentStatePartialUpdate, TransactionUserID)
        End Function



        Function TransitionAction(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ActionTypeID As Integer, ActionID As Integer, ApplicationID As Integer, RequesterUserID As Integer, DesiredStateID As Integer, RequestID As Integer, TransactionUserID As Integer, TransitionID As Integer) As String
            'Check if ActionTypeID=175, 175 represents candidate evaluation
            'if candidate evaluation (175), we need to check if all the interviewer has completed evaluation before proceding to the next transition
            Dim isUpdatable As Boolean = True
            If ActionTypeID = 175 Then
                If checkIfEvaluationCompletedByAllInterviewers(con, MyTrans, ApplicationID) = False Then
                    isUpdatable = False
                End If
            End If


            If isUpdatable = True Then
                'If UpdateAction(con, MyTrans, RequestID, ActionID, TransitionID) = "200" Then
                TransitState(con, MyTrans, ActionTypeID, ApplicationID, DesiredStateID, RequestID, TransactionUserID)
                ' End If
            End If

            Return "200"
        End Function




        Function GetRequestGroupWiseDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, StateGroupID As Integer, CurrentLoggedInUserID As Integer, VacancyID As Integer, GroupResultBy As String) As Data.DataSet
            Dim DA_request As New DAL.Request
            Return DA_request.GetRequestGroupWiseDetails(con, MyTrans, StateGroupID, CurrentLoggedInUserID, VacancyID, GroupResultBy)
        End Function

        Private Function checkIfEvaluationCompletedByAllInterviewers(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Boolean
            Dim DC As New JobStation.Controller.Interview
            Dim Result As Integer = DC.GetNoOfPendingCandidateEvaluationsByInterviewrs(con, MyTrans, ApplicationID)
            Dim isCompleted As Boolean = False
            If Result = 0 Then
                Return True
            Else
                Return False
            End If
        End Function



        Private Function TransitState(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ActionTypeID As Integer, ApplicationID As Integer, StateID As Integer, RequestID As Integer, TransactionUserID As Integer) As String
            Dim isCurrentStatePartialUpdate As Boolean = False



            If RequestID = 0 Then
                Dim RequestModel As New JobStation.Models.Request
                RequestModel.ApplicationID = ApplicationID
                RequestModel.DateRequested = Date.Now
                RequestModel.CurrentStateID = StateID
                RequestModel.UpdatedBy = TransactionUserID
                RequestModel.UpdatedOn = Date.Now
                RequestModel.RequesterUserID = GetJobRequesterIDbyApplicationID(con, MyTrans, ApplicationID)
                Insert(RequestModel, con, MyTrans)
                'Get Last Inserted ID
                RequestID = JobStation.DatabaseCommands.GetLastInsertedID(con, MyTrans).ToString
            Else 'Existing Request, Update table
                Update_request_currentstate(con, MyTrans, RequestID, StateID, isCurrentStatePartialUpdate, TransactionUserID)
            End If
            Dim rDAL As New JobStation.DAL.Request
            rDAL.TranistState(con, MyTrans, RequestID, StateID, TransactionUserID)
            Return "200"

        End Function


        Private Function GetJobRequesterIDbyApplicationID(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Integer
            Dim rDAL As New RTS.JobStation.DAL.Request
            Return rDAL.GetJobRequesterIDbyApplicationID(con, MyTrans, ApplicationID)


        End Function




        Private Function UpdateAction(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestID As Integer, ActionID As Integer, TransitionID As Integer)
            Dim rDAL As New RTS.JobStation.DAL.Request
            Return rDAL.UpdateTransitAction(con, MyTrans, RequestID, ActionID, TransitionID)

        End Function


    End Class
End Namespace

