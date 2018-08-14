Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
    Public Class Request
        Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
        Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
        Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
        Public Function Insert(ByVal c As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table request performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DateRequested", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_RequesterUserID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CurrentStateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isCurrentStatePartialUpdated", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_RequestID").Value = c.RequestID
                cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
                cmd.Parameters.Item("?p_DateRequested").Value = c.DateRequested
                cmd.Parameters.Item("?p_RequesterUserID").Value = c.RequesterUserID
                cmd.Parameters.Item("?p_CurrentStateID").Value = c.CurrentStateID
                cmd.Parameters.Item("?p_isCurrentStatePartialUpdated").Value = c.isCurrentStatePartialUpdated
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_request"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in request). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_request", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into request on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into request on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Update(ByVal c As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: UPDATE Data on table request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.RequestID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-KEY NOT SUPPLIED", " ", " ", TxnDetails, " ", c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                Return result
            End If
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DateRequested", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_RequesterUserID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CurrentStateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isCurrentStatePartialUpdated", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
                cmd.Parameters.Item("?p_RequestID").Value = c.RequestID
                cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
                cmd.Parameters.Item("?p_DateRequested").Value = c.DateRequested
                cmd.Parameters.Item("?p_RequesterUserID").Value = c.RequesterUserID
                cmd.Parameters.Item("?p_CurrentStateID").Value = c.CurrentStateID
                cmd.Parameters.Item("?p_isCurrentStatePartialUpdated").Value = c.isCurrentStatePartialUpdated
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Update_request"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Update DAL in request). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_request", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 And result <> 301 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Delete(ByVal c As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: DELETE Data from table request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.RequestID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from request performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-KEY NOT SUPPLIED", " ", " ", TxnDetails, " ", c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                Return result
            End If
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
                cmd.Parameters.Item("?p_RequestID").Value = c.RequestID
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Delete_request"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in request). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_request", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into request on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 And result <> 301 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function


        Function ShortListCandidate(ByVal c As Models.Request, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction)



            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table request performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DateRequested", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_RequesterUserID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CurrentStateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isCurrentStatePartialUpdated", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_RequestID").Value = c.RequestID
                cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
                cmd.Parameters.Item("?p_DateRequested").Value = c.DateRequested
                cmd.Parameters.Item("?p_RequesterUserID").Value = c.RequesterUserID
                cmd.Parameters.Item("?p_CurrentStateID").Value = c.CurrentStateID
                cmd.Parameters.Item("?p_isCurrentStatePartialUpdated").Value = c.isCurrentStatePartialUpdated
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_request"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	


                'Get Last Inserted ID
                Dim RequestID As Integer = JobStation.DatabaseCommands.GetLastInsertedID(con, MyTrans).ToString

                ' When a Request enters a State, we get all outgoing Transitions from that state. 
                'For Each Action In those Transitions, we add an entry In RequestAction, With Each entry having IsActive = 1 And IsCompleted = 0.
                Dim NextTransitions As DataTable = GetCurrentStateTransitions(con, MyTrans, c.CurrentStateID).Tables(0)

                Dim RequestAction As New JobStation.DAL.Requestaction
                Dim RModel As New JobStation.Models.Requestaction
                For Each dr In NextTransitions.Rows
                    RModel.TransitionID = dr("TransitionID")
                    RModel.ActionID = dr("actionID")
                    RModel.RequestID = RequestID
                    RModel.CreatedBy = c.UpdatedBy
                    RModel.UpdatedOn = Date.Now
                    RequestAction.Insert(RModel, con, MyTrans)
                Next

                '*****Update Request History
                '                Update RTS.requesthistory Set exitdate=current_timestamp where requestHistoryID=(Select RequestHistoryID FROM rts.requesthistory where requestID=New.RequestID order by RequestHistoryID desc limit 0, 1);

                'Insert into rts.requesthistory(RequestID, TransactionByUserID, CurrentStateID, isCurrentStatePartialUpdated,



            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in request). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_request", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into request on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into request on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result


        End Function

        Public Function GetCurrentStateTransitions(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CurrentStateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_currentstateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_currentstateID").Value = CurrentStateID


                Dim commandtext As String = "GetCurrentStateTransitions"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)


                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function TranistState(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestID As Integer, StateID As Integer, TransactionByUserID As Integer) As String

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_RequestID").Value = RequestID
                cmd.Parameters.Add("?p_NewStateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_NewStateID").Value = StateID
                cmd.Parameters.Add("?p_TransactionByUserID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_TransactionByUserID").Value = TransactionByUserID


                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output

                Dim commandtext As String = "TransitState"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim Result As String = JobStation.DatabaseCommands.ExecuteNonQuery(cmd.CommandType, cmd, con, MyTrans)
                Result = cmd.Parameters.Item("?p_Result").Value


            Catch ex As Exception
                Return "500"
            End Try

        End Function



        Public Function Update_request_currentstate(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestID As Integer, StateID As Integer, isCurrentStatePartialUpdate As Boolean, TransactionByUserID As Integer) As String

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_RequestID").Value = RequestID
                cmd.Parameters.Add("?p_CurrentStateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CurrentStateID").Value = StateID
                cmd.Parameters.Add("?p_isCurrentStatePartialUpdated", MySqlDbType.Bit)
                cmd.Parameters.Item("?p_isCurrentStatePartialUpdated").Value = isCurrentStatePartialUpdate
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_UpdatedBy").Value = TransactionByUserID
                Dim commandtext As String = "Update_request_currentstate"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim Result As String = JobStation.DatabaseCommands.ExecuteNonQuery(cmd.CommandType, cmd, con, MyTrans)
                Result = cmd.Parameters.Item("?p_Result").Value
                Return "200"

            Catch ex As Exception
                Return "500"
            End Try

        End Function

        Public Function UpdateTransitAction(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestID As Integer, ActionID As Integer, TransitionID As Integer) As String

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_RequestID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_RequestID").Value = RequestID
                cmd.Parameters.Add("?p_actionid", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_actionid").Value = ActionID
                cmd.Parameters.Add("?p_transitionID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_transitionID").Value = TransitionID
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output

                Dim commandtext As String = "UpdateTransitAction"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim Result As String = JobStation.DatabaseCommands.ExecuteNonQuery(cmd.CommandType, cmd, con, MyTrans)
                Result = cmd.Parameters.Item("?p_Result").Value
                Return Result

            Catch ex As Exception
                Return "500"
            End Try

        End Function


        Public Function GetJobRequesterIDbyApplicationID(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As Integer

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_ApplicationID").Value = ApplicationID


                Dim commandtext As String = "GetJobRequesterIDbyApplicationID"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.ExecuteScalar(cmd.CommandType, cmd, con, MyTrans)

            Catch ex As Exception
                Return -1
            End Try

        End Function




    End Class
End Namespace
