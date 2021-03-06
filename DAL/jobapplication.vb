﻿Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
 Public Class Jobapplication
Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
Public Function Insert (ByVal c As Models.jobapplication, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: INSERT Data into table jobapplication performed On " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
Try
'----------------declaring MySQL command Parameters-----------
cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
cmd.Parameters.Add("?p_ApplicationID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CanidateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_VacancyID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ApplicationSourceID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_AppliedByUser",MySqlDbType.Int64)
cmd.Parameters.Add("?p_isDisqualified",MySqlDbType.bit)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
cmd.Parameters.Add("?p_AppliedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
cmd.Parameters.Item("?p_CanidateID").Value = c.CanidateID
cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
cmd.Parameters.Item("?p_ApplicationSourceID").Value = c.ApplicationSourceID
cmd.Parameters.Item("?p_AppliedByUser").Value = c.AppliedByUser
cmd.Parameters.Item("?p_isDisqualified").Value = c.isDisqualified
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
cmd.Parameters.Item("?p_AppliedOn").Value = c.AppliedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Insert_jobapplication"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	

                result = cmd.Parameters.Item("?p_Result").Value

            Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS = TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Insert DAL in jobapplication). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_jobapplication", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into jobapplication on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS = TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS = TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into jobapplication on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS = TRUE And result <> 200 And result <> 300 And result <> 503 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



Public Function Update (ByVal c As Models.jobapplication, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: UPDATE Data on table jobapplication performed on " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.ApplicationID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on jobapplication performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
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
cmd.Parameters.Add("?p_ApplicationID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CanidateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_VacancyID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_ApplicationSourceID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_AppliedByUser",MySqlDbType.Int64)
cmd.Parameters.Add("?p_isDisqualified",MySqlDbType.bit)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
cmd.Parameters.Add("?p_AppliedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
cmd.Parameters.Item("?p_CanidateID").Value = c.CanidateID
cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
cmd.Parameters.Item("?p_ApplicationSourceID").Value = c.ApplicationSourceID
cmd.Parameters.Item("?p_AppliedByUser").Value = c.AppliedByUser
cmd.Parameters.Item("?p_isDisqualified").Value = c.isDisqualified
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
cmd.Parameters.Item("?p_AppliedOn").Value = c.AppliedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Update_jobapplication"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS=TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Update DAL in jobapplication). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_jobapplication", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on jobapplication performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS=TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS =TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on jobapplication performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS= TRUE And result <> 200 And result <> 300 And result <> 503 and result<> 301 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



        Public Function Delete(ByVal c As Models.jobapplication, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: DELETE Data from table jobapplication performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.ApplicationID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from jobapplication performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
                cmd.Parameters.Item("?p_ApplicationID").Value = c.ApplicationID
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Delete_jobapplication"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in jobapplication). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_jobapplication", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into jobapplication on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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





        Public Function GetJobApplicationID(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, VacancyID As Integer) As Integer

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID
                cmd.Parameters.Add("?p_vacancyid", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_vacancyid").Value = VacancyID


                Dim commandtext As String = "GetJobApplicationID"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.ExecuteScalar(cmd.CommandType, cmd, con, MyTrans)

            Catch ex As Exception
                Return Nothing
            End Try

        End Function




    End Class
End Namespace

