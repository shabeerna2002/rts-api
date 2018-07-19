Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
 Public Class Questiontypes
Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
Public Function Insert (ByVal c As Models.questiontypes, ByRef con as MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: INSERT Data into table questiontypes performed On " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
Try
'----------------declaring MySQL command Parameters-----------
cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
cmd.Parameters.Add("?p_TypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_Type",MySqlDbType.varchar)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
cmd.Parameters.Item("?p_TypeID").Value = c.TypeID
cmd.Parameters.Item("?p_Type").Value = c.Type
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Insert_questiontypes"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS = TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Insert DAL in questiontypes). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_questiontypes", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into questiontypes on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS = TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS = TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into questiontypes on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS = TRUE And result <> 200 And result <> 300 And result <> 503 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



Public Function Update (ByVal c As Models.questiontypes, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: UPDATE Data on table questiontypes performed on " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.TypeID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on questiontypes performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
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
cmd.Parameters.Add("?p_TypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_Type",MySqlDbType.varchar)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
cmd.Parameters.Item("?p_TypeID").Value = c.TypeID
cmd.Parameters.Item("?p_Type").Value = c.Type
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Update_questiontypes"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS=TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Update DAL in questiontypes). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_questiontypes", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on questiontypes performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS=TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS =TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on questiontypes performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS= TRUE And result <> 200 And result <> 300 And result <> 503 and result<> 301 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



Public Function Delete (ByVal c As Models.questiontypes, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: DELETE Data from table questiontypes performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.TypeID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from questiontypes performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
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
cmd.Parameters.Add("?p_TypeID",MySqlDbType.Int64)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
cmd.Parameters.Item("?p_TypeID").Value = c.TypeID
'-----------------Executing to DB-----------------
Dim commandtext As String = "Delete_questiontypes"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS = TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in questiontypes). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_questiontypes", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into questiontypes on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
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

