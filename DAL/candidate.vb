Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
    Public Class Candidate
        Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
        Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
        Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
        Public Function Insert(ByVal c As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table candidate performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_cvTitle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Objective", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_RefNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ExternalRefNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameFirst", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameMiddle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameLast", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvFIle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvMimeType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvContent", MySqlDbType.Text)
                cmd.Parameters.Add("?p_DateOfBirth", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_Gender", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ReligionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CasteID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_MaritialStatus", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NoOfDependant", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Nationality", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CountryOfResidence", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CityID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_VisaStatusID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_NoticePeriod", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Email", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_uPassword", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_MobileCountryCode", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_MobileNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Address", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_PoBox", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FaxCountryCode", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FaxNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_isRelativeAtCompany", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_RelativeDetails", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_WhyShurooq", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_WorkExperienceTotal", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_WorkExperienceUAE", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_WorkExperienceNonUAE", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isHired", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_CandidateID").Value = c.CandidateID
                cmd.Parameters.Item("?p_cvTitle").Value = c.cvTitle
                cmd.Parameters.Item("?p_Objective").Value = c.Objective
                cmd.Parameters.Item("?p_RefNo").Value = c.RefNo
                cmd.Parameters.Item("?p_ExternalRefNo").Value = c.ExternalRefNo
                cmd.Parameters.Item("?p_NameFirst").Value = c.NameFirst
                cmd.Parameters.Item("?p_NameMiddle").Value = c.NameMiddle
                cmd.Parameters.Item("?p_NameLast").Value = c.NameLast
                cmd.Parameters.Item("?p_cvFIle").Value = c.cvFIle
                cmd.Parameters.Item("?p_cvMimeType").Value = c.cvMimeType
                cmd.Parameters.Item("?p_cvContent").Value = c.cvContent
                cmd.Parameters.Item("?p_DateOfBirth").Value = c.DateOfBirth
                cmd.Parameters.Item("?p_Gender").Value = c.Gender
                cmd.Parameters.Item("?p_ReligionID").Value = c.ReligionID
                cmd.Parameters.Item("?p_CasteID").Value = c.CasteID
                cmd.Parameters.Item("?p_MaritialStatus").Value = c.MaritialStatus
                cmd.Parameters.Item("?p_NoOfDependant").Value = c.NoOfDependant
                cmd.Parameters.Item("?p_Nationality").Value = c.Nationality
                cmd.Parameters.Item("?p_CountryOfResidence").Value = c.CountryOfResidence
                cmd.Parameters.Item("?p_CityID").Value = c.CityID
                cmd.Parameters.Item("?p_VisaStatusID").Value = c.VisaStatusID
                cmd.Parameters.Item("?p_NoticePeriod").Value = c.NoticePeriod
                cmd.Parameters.Item("?p_Email").Value = c.Email
                cmd.Parameters.Item("?p_uPassword").Value = c.uPassword
                cmd.Parameters.Item("?p_MobileCountryCode").Value = c.MobileCountryCode
                cmd.Parameters.Item("?p_MobileNo").Value = c.MobileNo
                cmd.Parameters.Item("?p_Address").Value = c.Address
                cmd.Parameters.Item("?p_PoBox").Value = c.PoBox
                cmd.Parameters.Item("?p_FaxCountryCode").Value = c.FaxCountryCode
                cmd.Parameters.Item("?p_FaxNo").Value = c.FaxNo
                cmd.Parameters.Item("?p_isRelativeAtCompany").Value = c.isRelativeAtCompany
                cmd.Parameters.Item("?p_RelativeDetails").Value = c.RelativeDetails
                cmd.Parameters.Item("?p_WhyShurooq").Value = c.WhyShurooq
                cmd.Parameters.Item("?p_WorkExperienceTotal").Value = c.WorkExperienceTotal
                cmd.Parameters.Item("?p_WorkExperienceUAE").Value = c.WorkExperienceUAE
                cmd.Parameters.Item("?p_WorkExperienceNonUAE").Value = c.WorkExperienceNonUAE
                cmd.Parameters.Item("?p_isHired").Value = c.isHired
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_candidate"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in candidate). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_candidate", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into candidate on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into candidate on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Update(ByVal c As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: UPDATE Data on table candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.CandidateID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_cvTitle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Objective", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_RefNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ExternalRefNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameFirst", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameMiddle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NameLast", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvFIle", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvMimeType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_cvContent", MySqlDbType.Text)
                cmd.Parameters.Add("?p_DateOfBirth", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_Gender", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ReligionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CasteID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_MaritialStatus", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_NoOfDependant", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Nationality", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CountryOfResidence", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CityID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_VisaStatusID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_NoticePeriod", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Email", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_uPassword", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_MobileCountryCode", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_MobileNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Address", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_PoBox", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FaxCountryCode", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FaxNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_isRelativeAtCompany", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_RelativeDetails", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_WhyShurooq", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_WorkExperienceTotal", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_WorkExperienceUAE", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_WorkExperienceNonUAE", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_isHired", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
                cmd.Parameters.Item("?p_CandidateID").Value = c.CandidateID
                cmd.Parameters.Item("?p_cvTitle").Value = c.cvTitle
                cmd.Parameters.Item("?p_Objective").Value = c.Objective
                cmd.Parameters.Item("?p_RefNo").Value = c.RefNo
                cmd.Parameters.Item("?p_ExternalRefNo").Value = c.ExternalRefNo
                cmd.Parameters.Item("?p_NameFirst").Value = c.NameFirst
                cmd.Parameters.Item("?p_NameMiddle").Value = c.NameMiddle
                cmd.Parameters.Item("?p_NameLast").Value = c.NameLast
                cmd.Parameters.Item("?p_cvFIle").Value = c.cvFIle
                cmd.Parameters.Item("?p_cvMimeType").Value = c.cvMimeType
                cmd.Parameters.Item("?p_cvContent").Value = c.cvContent
                cmd.Parameters.Item("?p_DateOfBirth").Value = c.DateOfBirth
                cmd.Parameters.Item("?p_Gender").Value = c.Gender
                cmd.Parameters.Item("?p_ReligionID").Value = c.ReligionID
                cmd.Parameters.Item("?p_CasteID").Value = c.CasteID
                cmd.Parameters.Item("?p_MaritialStatus").Value = c.MaritialStatus
                cmd.Parameters.Item("?p_NoOfDependant").Value = c.NoOfDependant
                cmd.Parameters.Item("?p_Nationality").Value = c.Nationality
                cmd.Parameters.Item("?p_CountryOfResidence").Value = c.CountryOfResidence
                cmd.Parameters.Item("?p_CityID").Value = c.CityID
                cmd.Parameters.Item("?p_VisaStatusID").Value = c.VisaStatusID
                cmd.Parameters.Item("?p_NoticePeriod").Value = c.NoticePeriod
                cmd.Parameters.Item("?p_Email").Value = c.Email
                cmd.Parameters.Item("?p_uPassword").Value = c.uPassword
                cmd.Parameters.Item("?p_MobileCountryCode").Value = c.MobileCountryCode
                cmd.Parameters.Item("?p_MobileNo").Value = c.MobileNo
                cmd.Parameters.Item("?p_Address").Value = c.Address
                cmd.Parameters.Item("?p_PoBox").Value = c.PoBox
                cmd.Parameters.Item("?p_FaxCountryCode").Value = c.FaxCountryCode
                cmd.Parameters.Item("?p_FaxNo").Value = c.FaxNo
                cmd.Parameters.Item("?p_isRelativeAtCompany").Value = c.isRelativeAtCompany
                cmd.Parameters.Item("?p_RelativeDetails").Value = c.RelativeDetails
                cmd.Parameters.Item("?p_WhyShurooq").Value = c.WhyShurooq
                cmd.Parameters.Item("?p_WorkExperienceTotal").Value = c.WorkExperienceTotal
                cmd.Parameters.Item("?p_WorkExperienceUAE").Value = c.WorkExperienceUAE
                cmd.Parameters.Item("?p_WorkExperienceNonUAE").Value = c.WorkExperienceNonUAE
                cmd.Parameters.Item("?p_isHired").Value = c.isHired
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Update_candidate"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Update DAL in candidate). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_candidate", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 And result <> 301 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Delete(ByVal c As Models.Candidate, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: DELETE Data from table candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.CandidateID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from candidate performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
                cmd.Parameters.Item("?p_CandidateID").Value = c.CandidateID
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Delete_candidate"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in candidate). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_candidate", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into candidate on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
    End Class
End Namespace

