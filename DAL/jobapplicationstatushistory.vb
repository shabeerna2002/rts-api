Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
 Public Class Jobapplicationstatushistory
Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
Public Function Insert (ByVal c As Models.jobapplicationstatushistory, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: INSERT Data into table jobapplicationstatushistory performed On " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
Try
'----------------declaring MySQL command Parameters-----------
cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
cmd.Parameters.Add("?p_ApplicationHistoryID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ProcessID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_RequestActionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ProcessName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ApplicationID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionDate",MySqlDbType.datetime)
cmd.Parameters.Add("?p_UserID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_Message",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TransitionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateTypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateTypeName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_StateGroupID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateGroupName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_CurrentStateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CurrentStateName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayCurrentState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayAliasCurrentState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_NextStateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_NextStateName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayNextState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayAliasNextState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionTypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_DisplayActionType",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ActionName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionDisplayName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TargetGroupID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TargetGroupName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TargetID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TargentName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_EntryTime",MySqlDbType.datetime)
cmd.Parameters.Add("?p_ExitTime",MySqlDbType.datetime)
cmd.Parameters.Add("?p_ETAMins",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ActualMins",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleUserID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleUser",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ResponsibleDepartmentID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleDepartment",MySqlDbType.varchar)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
cmd.Parameters.Item("?p_ApplicationHistoryID").Value = c.ApplicationHistoryID
cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
cmd.Parameters.Item("?p_RequestActionID").Value = c.RequestActionID
cmd.Parameters.Item("?p_ProcessName").Value = c.ProcessName
cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
cmd.Parameters.Item("?p_TransactionDate").Value = c.TransactionDate
cmd.Parameters.Item("?p_UserID").Value = c.UserID
cmd.Parameters.Item("?p_Message").Value = c.Message
cmd.Parameters.Item("?p_TransitionID").Value = c.TransitionID
cmd.Parameters.Item("?p_StateTypeID").Value = c.StateTypeID
cmd.Parameters.Item("?p_StateTypeName").Value = c.StateTypeName
cmd.Parameters.Item("?p_StateGroupID").Value = c.StateGroupID
cmd.Parameters.Item("?p_StateGroupName").Value = c.StateGroupName
cmd.Parameters.Item("?p_CurrentStateID").Value = c.CurrentStateID
cmd.Parameters.Item("?p_CurrentStateName").Value = c.CurrentStateName
cmd.Parameters.Item("?p_DisplayCurrentState").Value = c.DisplayCurrentState
cmd.Parameters.Item("?p_DisplayAliasCurrentState").Value = c.DisplayAliasCurrentState
cmd.Parameters.Item("?p_NextStateID").Value = c.NextStateID
cmd.Parameters.Item("?p_NextStateName").Value = c.NextStateName
cmd.Parameters.Item("?p_DisplayNextState").Value = c.DisplayNextState
cmd.Parameters.Item("?p_DisplayAliasNextState").Value = c.DisplayAliasNextState
cmd.Parameters.Item("?p_ActionTypeID").Value = c.ActionTypeID
cmd.Parameters.Item("?p_DisplayActionType").Value = c.DisplayActionType
cmd.Parameters.Item("?p_ActionID").Value = c.ActionID
cmd.Parameters.Item("?p_ActionName").Value = c.ActionName
cmd.Parameters.Item("?p_ActionDisplayName").Value = c.ActionDisplayName
cmd.Parameters.Item("?p_TargetGroupID").Value = c.TargetGroupID
cmd.Parameters.Item("?p_TargetGroupName").Value = c.TargetGroupName
cmd.Parameters.Item("?p_TargetID").Value = c.TargetID
cmd.Parameters.Item("?p_TargentName").Value = c.TargentName
cmd.Parameters.Item("?p_EntryTime").Value = c.EntryTime
cmd.Parameters.Item("?p_ExitTime").Value = c.ExitTime
cmd.Parameters.Item("?p_ETAMins").Value = c.ETAMins
cmd.Parameters.Item("?p_ActualMins").Value = c.ActualMins
cmd.Parameters.Item("?p_ResponsibleUserID").Value = c.ResponsibleUserID
cmd.Parameters.Item("?p_ResponsibleUser").Value = c.ResponsibleUser
cmd.Parameters.Item("?p_ResponsibleDepartmentID").Value = c.ResponsibleDepartmentID
cmd.Parameters.Item("?p_ResponsibleDepartment").Value = c.ResponsibleDepartment
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Insert_jobapplicationstatushistory"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS = TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Insert DAL in jobapplicationstatushistory). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_jobapplicationstatushistory", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into jobapplicationstatushistory on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS = TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS = TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into jobapplicationstatushistory on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS = TRUE And result <> 200 And result <> 300 And result <> 503 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



Public Function Update (ByVal c As Models.jobapplicationstatushistory, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: UPDATE Data on table jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.ApplicationHistoryID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-KEY NOT SUPPLIED", " ", " ", TxnDetails," ", c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
Return result
End If
Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
Try
'----------------declaring MySQL command Parameters-----------
cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
cmd.Parameters.Add("?p_ApplicationHistoryID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ProcessID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_RequestActionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ProcessName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ApplicationID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionDate",MySqlDbType.datetime)
cmd.Parameters.Add("?p_UserID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_Message",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TransitionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateTypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateTypeName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_StateGroupID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_StateGroupName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_CurrentStateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CurrentStateName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayCurrentState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayAliasCurrentState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_NextStateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_NextStateName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayNextState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DisplayAliasNextState",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionTypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_DisplayActionType",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ActionName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ActionDisplayName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TargetGroupID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TargetGroupName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_TargetID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TargentName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_EntryTime",MySqlDbType.datetime)
cmd.Parameters.Add("?p_ExitTime",MySqlDbType.datetime)
cmd.Parameters.Add("?p_ETAMins",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ActualMins",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleUserID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleUser",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ResponsibleDepartmentID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ResponsibleDepartment",MySqlDbType.varchar)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
cmd.Parameters.Item("?p_ApplicationHistoryID").Value = c.ApplicationHistoryID
cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
cmd.Parameters.Item("?p_RequestActionID").Value = c.RequestActionID
cmd.Parameters.Item("?p_ProcessName").Value = c.ProcessName
cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
cmd.Parameters.Item("?p_TransactionDate").Value = c.TransactionDate
cmd.Parameters.Item("?p_UserID").Value = c.UserID
cmd.Parameters.Item("?p_Message").Value = c.Message
cmd.Parameters.Item("?p_TransitionID").Value = c.TransitionID
cmd.Parameters.Item("?p_StateTypeID").Value = c.StateTypeID
cmd.Parameters.Item("?p_StateTypeName").Value = c.StateTypeName
cmd.Parameters.Item("?p_StateGroupID").Value = c.StateGroupID
cmd.Parameters.Item("?p_StateGroupName").Value = c.StateGroupName
cmd.Parameters.Item("?p_CurrentStateID").Value = c.CurrentStateID
cmd.Parameters.Item("?p_CurrentStateName").Value = c.CurrentStateName
cmd.Parameters.Item("?p_DisplayCurrentState").Value = c.DisplayCurrentState
cmd.Parameters.Item("?p_DisplayAliasCurrentState").Value = c.DisplayAliasCurrentState
cmd.Parameters.Item("?p_NextStateID").Value = c.NextStateID
cmd.Parameters.Item("?p_NextStateName").Value = c.NextStateName
cmd.Parameters.Item("?p_DisplayNextState").Value = c.DisplayNextState
cmd.Parameters.Item("?p_DisplayAliasNextState").Value = c.DisplayAliasNextState
cmd.Parameters.Item("?p_ActionTypeID").Value = c.ActionTypeID
cmd.Parameters.Item("?p_DisplayActionType").Value = c.DisplayActionType
cmd.Parameters.Item("?p_ActionID").Value = c.ActionID
cmd.Parameters.Item("?p_ActionName").Value = c.ActionName
cmd.Parameters.Item("?p_ActionDisplayName").Value = c.ActionDisplayName
cmd.Parameters.Item("?p_TargetGroupID").Value = c.TargetGroupID
cmd.Parameters.Item("?p_TargetGroupName").Value = c.TargetGroupName
cmd.Parameters.Item("?p_TargetID").Value = c.TargetID
cmd.Parameters.Item("?p_TargentName").Value = c.TargentName
cmd.Parameters.Item("?p_EntryTime").Value = c.EntryTime
cmd.Parameters.Item("?p_ExitTime").Value = c.ExitTime
cmd.Parameters.Item("?p_ETAMins").Value = c.ETAMins
cmd.Parameters.Item("?p_ActualMins").Value = c.ActualMins
cmd.Parameters.Item("?p_ResponsibleUserID").Value = c.ResponsibleUserID
cmd.Parameters.Item("?p_ResponsibleUser").Value = c.ResponsibleUser
cmd.Parameters.Item("?p_ResponsibleDepartmentID").Value = c.ResponsibleDepartmentID
cmd.Parameters.Item("?p_ResponsibleDepartment").Value = c.ResponsibleDepartment
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Update_jobapplicationstatushistory"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS=TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Update DAL in jobapplicationstatushistory). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_jobapplicationstatushistory", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS=TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS =TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS= TRUE And result <> 200 And result <> 300 And result <> 503 and result<> 301 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



Public Function Delete (ByVal c As Models.jobapplicationstatushistory, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: DELETE Data from table jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.ApplicationHistoryID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from jobapplicationstatushistory performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-KEY NOT SUPPLIED", " ", " ", TxnDetails," ", c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
Return result
End If
Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
Try
'----------------declaring MySQL command Parameters-----------
cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
cmd.Parameters.Add("?p_ApplicationHistoryID",MySqlDbType.Int64)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
cmd.Parameters.Item("?p_ApplicationHistoryID").Value = c.ApplicationHistoryID
'-----------------Executing to DB-----------------
Dim commandtext As String = "Delete_jobapplicationstatushistory"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS = TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in jobapplicationstatushistory). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_jobapplicationstatushistory", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into jobapplicationstatushistory on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS= TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS = TRUE And result <> 200 And result <> 300 And result <> 503 and result<> 301 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "DELETE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function
End Class
End Namespace

