Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
    Public Class Vacancy
        Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
        Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
        Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
        Public Function Insert(ByVal c As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table vacancy performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ProcessID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_OpenPositions", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DesignationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Title", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_JobDescription", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobSkill", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobDuty", MySqlDbType.Text)
                cmd.Parameters.Add("?p_EducationInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NationalityInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ClosingDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_OpeningDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_isPublished", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isClosed", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_StatusID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
                cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
                cmd.Parameters.Item("?p_OpenPositions").Value = c.OpenPositions
                cmd.Parameters.Item("?p_DesignationID").Value = c.DesignationID
                cmd.Parameters.Item("?p_Title").Value = c.Title
                cmd.Parameters.Item("?p_JobDescription").Value = c.JobDescription
                cmd.Parameters.Item("?p_JobSkill").Value = c.JobSkill
                cmd.Parameters.Item("?p_JobDuty").Value = c.JobDuty
                cmd.Parameters.Item("?p_EducationInfo").Value = c.EducationInfo
                cmd.Parameters.Item("?p_NationalityInfo").Value = c.NationalityInfo
                cmd.Parameters.Item("?p_ClosingDate").Value = c.ClosingDate
                cmd.Parameters.Item("?p_OpeningDate").Value = c.OpeningDate
                cmd.Parameters.Item("?p_isPublished").Value = c.isPublished
                cmd.Parameters.Item("?p_isClosed").Value = c.isClosed
                cmd.Parameters.Item("?p_StatusID").Value = c.StatusID
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_vacancy"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in vacancy). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_vacancy", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function

        Public Function AddVacancy(ByVal c As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table vacancy performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ProcessID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_OpenPositions", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DesignationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Title", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_JobDescription", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobSkill", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobDuty", MySqlDbType.Text)
                cmd.Parameters.Add("?p_EducationInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NationalityInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_OpeningDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
                cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
                cmd.Parameters.Item("?p_OpenPositions").Value = c.OpenPositions
                cmd.Parameters.Item("?p_DesignationID").Value = c.DesignationID
                cmd.Parameters.Item("?p_Title").Value = c.Title
                cmd.Parameters.Item("?p_JobDescription").Value = c.JobDescription
                cmd.Parameters.Item("?p_JobSkill").Value = c.JobSkill
                cmd.Parameters.Item("?p_JobDuty").Value = c.JobDuty
                cmd.Parameters.Item("?p_EducationInfo").Value = c.EducationInfo
                cmd.Parameters.Item("?p_NationalityInfo").Value = c.NationalityInfo
                cmd.Parameters.Item("?p_OpeningDate").Value = c.OpeningDate
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_vacancy_AddVacancy"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in vacancy). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_vacancy", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function

        Public Function UpdateVacancy(ByVal c As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table vacancy performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ProcessID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_OpenPositions", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DesignationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Title", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_JobDescription", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobSkill", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobDuty", MySqlDbType.Text)
                cmd.Parameters.Add("?p_EducationInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NationalityInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_OpeningDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
                cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
                cmd.Parameters.Item("?p_OpenPositions").Value = c.OpenPositions
                cmd.Parameters.Item("?p_DesignationID").Value = c.DesignationID
                cmd.Parameters.Item("?p_Title").Value = c.Title
                cmd.Parameters.Item("?p_JobDescription").Value = c.JobDescription
                cmd.Parameters.Item("?p_JobSkill").Value = c.JobSkill
                cmd.Parameters.Item("?p_JobDuty").Value = c.JobDuty
                cmd.Parameters.Item("?p_EducationInfo").Value = c.EducationInfo
                cmd.Parameters.Item("?p_NationalityInfo").Value = c.NationalityInfo
                cmd.Parameters.Item("?p_OpeningDate").Value = c.OpeningDate
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Update_vacancy_UpdateVacancy"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in vacancy). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_vacancy", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function

        Public Function Update(ByVal c As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: UPDATE Data on table vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.VacancyID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_ProcessID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_OpenPositions", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_DesignationID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Title", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_JobDescription", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobSkill", MySqlDbType.Text)
                cmd.Parameters.Add("?p_JobDuty", MySqlDbType.Text)
                cmd.Parameters.Add("?p_EducationInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NationalityInfo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ClosingDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_OpeningDate", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_isPublished", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isClosed", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_StatusID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
                cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
                cmd.Parameters.Item("?p_ProcessID").Value = c.ProcessID
                cmd.Parameters.Item("?p_OpenPositions").Value = c.OpenPositions
                cmd.Parameters.Item("?p_DesignationID").Value = c.DesignationID
                cmd.Parameters.Item("?p_Title").Value = c.Title
                cmd.Parameters.Item("?p_JobDescription").Value = c.JobDescription
                cmd.Parameters.Item("?p_JobSkill").Value = c.JobSkill
                cmd.Parameters.Item("?p_JobDuty").Value = c.JobDuty
                cmd.Parameters.Item("?p_EducationInfo").Value = c.EducationInfo
                cmd.Parameters.Item("?p_NationalityInfo").Value = c.NationalityInfo
                cmd.Parameters.Item("?p_ClosingDate").Value = c.ClosingDate
                cmd.Parameters.Item("?p_OpeningDate").Value = c.OpeningDate
                cmd.Parameters.Item("?p_isPublished").Value = c.isPublished
                cmd.Parameters.Item("?p_isClosed").Value = c.isClosed
                cmd.Parameters.Item("?p_StatusID").Value = c.StatusID
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Update_vacancy"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Update DAL in vacancy). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_vacancy", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 And result <> 301 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Delete(ByVal c As Models.Vacancy, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: DELETE Data from table vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.VacancyID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from vacancy performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
                cmd.Parameters.Item("?p_VacancyID").Value = c.VacancyID
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Delete_vacancy"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in vacancy). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_vacancy", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into vacancy on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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



        Public Function GetJobInfoSummary(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction)
            Dim JobInfoSummary As New DataSet("JobList")
            Dim TitlesDT As DataTable = GetJobInfoSummaryJobTitles(con, MyTrans).Tables(0)
            TitlesDT.TableName = "JobInfo"
            Dim JobDetailsDT As New DataTable("JobDetails")
            If Not TitlesDT Is Nothing Then
                If TitlesDT.Rows.Count > 0 Then
                    Dim VacancyIDList As String = ""
                    For Each dr In TitlesDT.Rows
                        VacancyIDList += dr("vacancyID").ToString & ","
                    Next

                    If VacancyIDList.Length > 0 Then
                        VacancyIDList = VacancyIDList.Remove(VacancyIDList.LastIndexOf(","), 1)
                    End If

                    JobDetailsDT = GetJobInfoSummaryDetails(con, MyTrans, VacancyIDList).Tables(0)
                    JobDetailsDT.TableName = "JobDetails"
                End If
            End If

            JobInfoSummary.Tables.Add(TitlesDT.Copy)
            JobInfoSummary.Tables.Add(JobDetailsDT.Copy)
            JobInfoSummary.DataSetName = "JobList"

            If JobInfoSummary.Tables(0).Rows.Count > 1 And JobInfoSummary.Tables(1).Rows.Count > 1 Then
                Dim ParentChildRelation As DataRelation = New DataRelation("ParentChild", JobInfoSummary.Tables("JobInfo").Columns("vacancyID"), JobInfoSummary.Tables("JobDetails").Columns("vacancyID"), True)
                ParentChildRelation.Nested = True
                JobInfoSummary.Relations.Add(ParentChildRelation)
            End If
            Return JobInfoSummary

        End Function

        Public Function GetJobInfoSummaryJobTitles(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As DataSet

            Try
                Dim cmd As New MySqlCommand
                Dim commandtext As String = "GetJobInfoSummaryJobTitles"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function



        Public Function GetJobListSummary(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, DepartmentID As Integer, EntityID As Integer, JobTitle As String, isClosed As Boolean) As DataSet

            Try

                Dim VacancSummaryList As DataTable = New DataTable
                Dim dtVacacnyIDList As DataTable = New DataTable
                Dim VacancyListInfo As DataTable = New DataTable
                VacancSummaryList.TableName = "JobInfo"
                VacancyListInfo.TableName = "JobApplicationsInfo"

                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_VacancyID").Value = VacancyID
                cmd.Parameters.Add("?p_EntityID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_EntityID").Value = EntityID
                cmd.Parameters.Add("?p_DepartmentID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_DepartmentID").Value = DepartmentID
                cmd.Parameters.Add("?p_jobtitle", MySqlDbType.String)
                cmd.Parameters.Item("?p_jobtitle").Value = JobTitle
                cmd.Parameters.Add("?p_isClosed", MySqlDbType.Bit)
                cmd.Parameters.Item("?p_isClosed").Value = isClosed
                Dim commandtext As String = "GetVacancySummaryList"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                VacancSummaryList = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                Dim vsView As DataView = New DataView(VacancSummaryList)
                dtVacacnyIDList = vsView.ToTable(True, "vacancyid")
                Dim VacancyIDList As String = ""
                For Each dr In dtVacacnyIDList.Rows
                    VacancyIDList &= dr("vacancyID").ToString & ","
                Next

                If VacancyIDList.IndexOf(",") >= 0 Then
                    VacancyIDList = VacancyIDList.Remove(VacancyIDList.LastIndexOf(","))
                End If

                cmd.Parameters.Clear()
                cmd.Parameters.Add("?p_VacancyIDList", MySqlDbType.String)
                cmd.Parameters.Item("?p_VacancyIDList").Value = VacancyIDList

                commandtext = "GetVacancySummaryGroupInfo"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                VacancyListInfo = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)



                VacancSummaryList.TableName = "JobInfo"
                VacancyListInfo.TableName = "JobApplicationsInfo"
                Dim ds As New DataSet("JobSummaryInfo")
                ds.Tables.Add(VacancSummaryList.Copy)
                ds.Tables.Add(VacancyListInfo.Copy)
                If Not ds Is Nothing Then
                    If ds.Tables.Count > 1 Then
                        Dim parentChildRelation As DataRelation = New DataRelation("ParentChild", ds.Tables("JobInfo").Columns("VacancyID"), ds.Tables("JobApplicationsInfo").Columns("VacancyID"), True)
                        parentChildRelation.Nested = True
                        ds.Relations.Add(parentChildRelation)
                    End If
                End If


                Dim ResultInfo As DataTable = New DataTable("ResultInfo")
                ResultInfo.Columns.Add("JobInfo", GetType(Integer))
                ResultInfo.Columns.Add("JobApplicationsInfo", GetType(Integer))


                Dim rDr As DataRow
                rDr = ResultInfo.NewRow()
                rDr("JobInfo") = VacancSummaryList.Rows.Count
                rDr("JobApplicationsInfo") = VacancyListInfo.Rows.Count
                ResultInfo.Rows.Add(rDr)
                ds.Tables.Add(ResultInfo)
                ResultInfo.Dispose()


                VacancSummaryList.Dispose()
                dtVacacnyIDList.Dispose()
                VacancyListInfo.Dispose()


                Return ds





            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetJobInfoSummaryDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyIDList As String) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyIDList", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_VacancyIDList").Value = VacancyIDList

                Dim commandtext As String = "GetJobInfoSummary"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetVacancyDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_VacancyID").Value = VacancyID

                Dim commandtext As String = "GetVacancyDetails"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function PublishJob(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, isPublish As Boolean) As String

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_VacancyID").Value = VacancyID
                cmd.Parameters.Add("?p_isPublished", MySqlDbType.Bit)


                cmd.Parameters.Item("?p_isPublished").Value = isPublish



                Dim commandtext As String = "PublishJob"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                JobStation.ExecuteNonQuery(cmd.CommandType, cmd, con, MyTrans)
                Return "200"
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function CloseJob(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, VacancyID As Integer, isClosed As Boolean) As String

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_VacancyID").Value = VacancyID
                cmd.Parameters.Add("?p_isClosed", MySqlDbType.Bit)
                cmd.Parameters.Item("?p_isClosed").Value = isClosed



                Dim commandtext As String = "CloseJob"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                JobStation.ExecuteNonQuery(cmd.CommandType, cmd, con, MyTrans)
                Return "200"
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function ApplyJob(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, VacancyID As Integer, ApplicationSourceID As Integer, AppliedByUSerID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_VacancyID", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_VacancyID").Value = VacancyID

                Dim commandtext As String = "GetVacancyDetails"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function




    End Class
End Namespace
