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
                cmd.Parameters.Add("?p_RelevantExperience", MySqlDbType.Int64)

                cmd.Parameters.Add("?p_isHired", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_PostedOn", MySqlDbType.DateTime)
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
                cmd.Parameters.Item("?p_RelevantExperience").Value = c.RelevantExperience

                cmd.Parameters.Item("?p_isHired").Value = c.isHired
                cmd.Parameters.Item("?p_PostedOn").Value = c.PostedOn
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
                cmd.Parameters.Add("?p_PostedOn", MySqlDbType.DateTime)
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
                cmd.Parameters.Item("?p_PostedOn").Value = c.PostedOn
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

        Public Function GetCandidateListFiltered(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, RequestInfo As Models.CandidateRequestInfo) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_StartIndex", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_StartIndex").Value = 0
                cmd.Parameters.Add("?p_Count", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_Count").Value = RequestInfo.Count
                cmd.Parameters.Add("?p_CandiateIDList", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandiateIDList").Value = RequestInfo.Keywords

                Dim commandtext As String = "GetCandidateListFiltered"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetCandidateBasicInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID

                Dim commandtext As String = "GetCandidateBasicInfo"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function



        Public Function GetCandidateBannedFavouritedInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, RequestingUserID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID

                cmd.Parameters.Add("?p_userID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_userID").Value = RequestingUserID

                Dim commandtext As String = "GetCandidateBannedFavouritedInfo"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateEducationInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID

                Dim commandtext As String = "GetCandidateEducationInfo"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function
        Public Function GetWorkHistoryInfo(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID

                Dim commandtext As String = "GetWorkHistoryInfo"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetCandidateActivityLogs(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet
            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID



                Dim commandtext As String = "GetCandidateActivityLog"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtActivityLog As DataTable = New DataTable("ActivityLog")


                If ds.Tables.Count > 0 Then
                    dtActivityLog = ds.Tables(0)
                    dtActivityLog.TableName = "ActivityLog"

                    'Format Display message based on the Template
                    For Each dr As DataRow In dtActivityLog.Rows
                        dr("Message") = dr("DisplayTemplate").ToString.Replace("{{message}}", dr("message").ToString).Replace("{{activitybyuser}}", dr("ActivityByUserFullName").ToString).Replace("{{activityonuser}}", dr("ActivityOnUserFullName").ToString)

                    Next

                    dtActivityLog.Columns.Remove("DisplayTemplate")
                    dtActivityLog.Columns.Remove("isInActive")
                End If


                'Get Activity Log  Documents

                Dim dtActivityLogDocuments As DataTable = New DataTable
                dtActivityLogDocuments.TableName = "ActivityDocuments"
                dtActivityLogDocuments = GetCandidateActivityLogDocuments(con, MyTrans, CandidateID).Tables(0)
                If Not dtActivityLogDocuments Is Nothing Then
                    If dtActivityLogDocuments.Rows.Count > 0 Then
                        dtActivityLogDocuments.TableName = "ActivityDocuments"
                    End If
                End If

                ds.Tables.Add(dtActivityLogDocuments.Copy)


                If ds.Tables(0).Rows.Count > 0 And ds.Tables(1).Rows.Count > 0 Then
                    Dim ParentChildRelation As DataRelation = New DataRelation("ParentChild", ds.Tables("ActivityLog").Columns("ActivityLogID"), ds.Tables("ActivityDocuments").Columns("ActivityLogID"), True)
                    ParentChildRelation.Nested = True
                    ds.Relations.Add(ParentChildRelation)
                End If

                ds.DataSetName = "CandidateActivityLog"
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try
        End Function


        Public Function GetCandidateActivityLogDocuments(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetCandidateActivityLogDocuments"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtTimeline As DataTable = New DataTable("ActivityDocuments")

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function




        Public Function GetCandidateTimeLine(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand

                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_ApplicationID").Value = ApplicationID

                Dim commandtext As String = "GetCandidateTimeLine"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtTimeline As DataTable = New DataTable("Timeline")


                If ds.Tables.Count > 0 Then
                    dtTimeline = ds.Tables(0)
                    dtTimeline.TableName = "Timeline"

                    'Format Display message based on the Template
                    For Each dr As DataRow In dtTimeline.Rows
                        dr("Message") = dr("DisplayTemplate").ToString.Replace("{{message}}", dr("message").ToString).Replace("{{candidate}}", dr("CandidateFullName").ToString).Replace("{{TransactionUser}}", dr("TransactionUserPersonName").ToString)

                    Next

                    dtTimeline.Columns.Remove("DisplayTemplate")
                    dtTimeline.Columns.Remove("isInActive")
                End If


                'Get Candidate Timeline Documents

                Dim dtTimelineDocuments As DataTable = New DataTable
                dtTimelineDocuments.TableName = "TimelineDocuments"
                dtTimelineDocuments = GetCandidateTimeLineDocuments(con, MyTrans, ApplicationID).Tables(0)
                If Not dtTimelineDocuments Is Nothing Then
                    If dtTimelineDocuments.Rows.Count > 0 Then
                        dtTimelineDocuments.TableName = "TimelineDocuments"
                    End If
                End If

                ds.Tables.Add(dtTimelineDocuments.Copy)


                If ds.Tables(0).Rows.Count > 0 And ds.Tables(1).Rows.Count > 0 Then
                    Dim ParentChildRelation As DataRelation = New DataRelation("ParentChild", ds.Tables("Timeline").Columns("TimelineID"), ds.Tables("TimelineDocuments").Columns("TimelineID"), True)
                    ParentChildRelation.Nested = True
                    ds.Relations.Add(ParentChildRelation)
                End If

                ds.DataSetName = "ApplicationTimeline"
                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetCandidateTimeLineDocuments(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand


                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_ApplicationID").Value = ApplicationID

                Dim commandtext As String = "GetCandidateTimeLineDocuments"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                'Dim dtTimeline As DataTable = New DataTable("TimelineDocuments")

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateDocuments(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetCandidateDocuments"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                ds.DataSetName = "CandidateDocuments"
                Dim ds1 As New DataSet("CandidateDocuments")
                If Not ds Is Nothing Then


                    Dim dView As DataView = New DataView(ds.Tables(0))
                            Dim DocTypeDt As DataTable = dView.ToTable(True, "CandidateDocumentTypeID", "DocumentType")
                            DocTypeDt.TableName = "DocType"
                            ds.Tables(0).TableName = "DocDetails"

                            ds1.Tables.Add(DocTypeDt.Copy)
                    ds1.Tables.Add(ds.Tables(0).Copy)

                    Dim ParentChildRelation As DataRelation = New DataRelation("ParentChild", ds1.Tables("DocType").Columns("CandidateDocumentTypeID"), ds1.Tables("DocDetails").Columns("CandidateDocumentTypeID"), True)
                    ParentChildRelation.Nested = True
                    ds1.Relations.Add(ParentChildRelation)
                    ds1.DataSetName = "CandidateDocuments"


                End If
                Return ds1
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateList(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction,RequestInfo As Models.CandidateRequestInfo) As DataSet
            Dim CandidateList As DataSet = New DataSet

            Try
                Dim cmd As New MySqlCommand
                Dim StartIndex As Integer = RequestInfo.PageID
                Dim Count As Integer = RequestInfo.Count
                If StartIndex = 1 Then
                    StartIndex = 0
                Else
                    StartIndex = ((StartIndex - 1) * Count)
                End If


                cmd.Parameters.Add("?p_StartIndex", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_StartIndex").Value = StartIndex
                cmd.Parameters.Add("?p_Count", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_Count").Value = Count

                Dim commandtext As String = ""



                Dim dtCandidateList As DataTable = New DataTable("Candidates")
                Dim CandidateFavouriteList As DataTable = New DataTable
                Dim CandiateBannedList As DataTable = New DataTable

                Dim TotalCandidatesCount As Integer = 0


                If RequestInfo.FilterType.ToString.ToLower = "none" Then  'No filters has been applied, get all latest canddiates.
                    commandtext = "GetCandidateList"
                    cmd.CommandType = Data.CommandType.StoredProcedure
                    cmd.CommandText = commandtext

                ElseIf RequestInfo.FilterType.ToString.ToLower = "filtered" Then ' There are filters applied
                    'cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                    cmd.Parameters.Add("?p_VacancyID", MySqlDbType.Int64)
                    cmd.Parameters.Add("?p_Keywords", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_JobIndustryIDList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_MinExperience", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_MaxExperience", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_AgeList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_CandidateStatusIDList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_GenderList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_NationalityIDList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_EducationList", MySqlDbType.VarChar)
                    cmd.Parameters.Add("?p_LanguageSkillsList", MySqlDbType.VarChar)



                    'If RequestInfo.CandidateID > 0 Then
                    '    cmd.Parameters.Item("?p_CandidateID").Value = RequestInfo.CandidateID
                    'Else
                    '    cmd.Parameters.Item("?p_CandidateID").Value = 0
                    'End If


                    If RequestInfo.VacanyID > 0 Then
                        cmd.Parameters.Item("?p_VacancyID").Value = RequestInfo.VacanyID
                    Else
                        cmd.Parameters.Item("?p_VacancyID").Value = 0
                    End If

                    If RequestInfo.Keywords.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_Keywords").Value = RequestInfo.Keywords
                    Else
                        cmd.Parameters.Item("?p_Keywords").Value = ""
                    End If

                    If RequestInfo.JobIndustryIDList.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_JobIndustryIDList").Value = RequestInfo.JobIndustryIDList
                    Else
                        cmd.Parameters.Item("?p_JobIndustryIDList").Value = ""
                    End If

                    If RequestInfo.TotalExperience.ToString.Trim.Length > 2 Then
                        Dim MinExp As String = RequestInfo.TotalExperience.Substring(0, RequestInfo.TotalExperience.IndexOf("-"))
                        Dim MaxExp As String = RequestInfo.TotalExperience.Remove(0, RequestInfo.TotalExperience.IndexOf("-") + 1)
                        cmd.Parameters.Item("?p_MinExperience").Value = MinExp
                        cmd.Parameters.Item("?p_MaxExperience").Value = MaxExp

                    Else
                        cmd.Parameters.Item("?p_MinExperience").Value = ""
                        cmd.Parameters.Item("?p_MaxExperience").Value = ""
                    End If

                    If RequestInfo.TotalExperience.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_AgeList").Value = RequestInfo.AgeList
                    Else
                        cmd.Parameters.Item("?p_AgeList").Value = ""
                    End If

                    If RequestInfo.TotalExperience.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_CandidateStatusIDList").Value = RequestInfo.CandidateStatusIDList
                    Else
                        cmd.Parameters.Item("?p_CandidateStatusIDList").Value = ""
                    End If




                    If RequestInfo.TotalExperience.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_GenderList").Value = RequestInfo.GenderList
                    Else
                        cmd.Parameters.Item("?p_GenderList").Value = ""
                    End If

                    If RequestInfo.NationalityIDList.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_NationalityIDList").Value = RequestInfo.NationalityIDList
                    Else
                        cmd.Parameters.Item("?p_NationalityIDList").Value = ""
                    End If

                    If RequestInfo.EducationList.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_EducationList").Value = RequestInfo.EducationList
                    Else
                        cmd.Parameters.Item("?p_EducationList").Value = ""
                    End If

                    If RequestInfo.LanguageSkillsList.ToString.Trim.Length > 0 Then
                        cmd.Parameters.Item("?p_LanguageSkillsList").Value = RequestInfo.LanguageSkillsList
                    Else
                        cmd.Parameters.Item("?p_LanguageSkillsList").Value = ""
                    End If

                    commandtext = "GetCandidateListFiltered"
                    cmd.CommandType = Data.CommandType.StoredProcedure
                    cmd.CommandText = commandtext




                End If

                dtCandidateList = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)  ' change parameters for proper output	









                If RequestInfo.FilterType.ToString.ToLower = "none" Then
                    'Get Total Candidates in the database
                    TotalCandidatesCount = GetTotalActiveCandidatesCount(con, MyTrans)
                ElseIf RequestInfo.FilterType.ToString.ToLower = "filtered" Then
                    cmd.CommandText = "GetCandidateListFilteredCount"
                    TotalCandidatesCount = GetTotalFilteredCandidatesCount(con, MyTrans, cmd)

                End If



                CandidateFavouriteList = GetCandidateFavouriteList(con, MyTrans, RequestInfo.UserID).Tables(0)
                CandiateBannedList = GetCandidateBannedList(con, MyTrans, RequestInfo.UserID).Tables(0)

                dtCandidateList.Columns.Add("isFavourite", GetType(Boolean))
                dtCandidateList.Columns.Add("isBanned", GetType(Boolean))
                dtCandidateList.Columns.Add("ProfilePic", GetType(String))

                Dim CurrentCandidateID As Integer = 0
                Dim dr As Data.DataRow
                Dim cf As Data.DataRow
                Dim cb As Data.DataRow

                Dim dtCandidateListTemp As DataTable = dtCandidateList.Clone
                For Each dr In dtCandidateList.Rows

                    If dr("Gender").ToString.ToLower = "male" Then
                        dr("ProfilePic") = "male.png"
                    ElseIf dr("Gender").ToString.ToLower = "female" Then
                        dr("ProfilePic") = "female.png"
                    Else
                        dr("ProfilePic") = "gender.png"
                    End If

                    CurrentCandidateID = dr("CandidateID")


                    'Find if CurrentCandiate is Favourited by the USER
                    dr("isFavourite") = False
                    For Each cf In CandidateFavouriteList.Rows
                        If cf("CandidateID") = CurrentCandidateID Then
                            dr("isFavourite") = True
                            Exit For
                        End If




                    Next

                    'Find if CurrentCandiate is Banned by the USER
                    dr("isBanned") = False
                    For Each cb In CandiateBannedList.Rows
                        If cb("CandidateID") = CurrentCandidateID Then
                            dr("isBanned") = True
                            Exit For
                        End If
                    Next



                    'check if Request is only for FavouriteCandidates / Banned Candiates

                    If RequestInfo.showFavourites = True And dr("isFavourite") = True And RequestInfo.FilterType.ToString.ToLower = "filtered" Then
                        dtCandidateListTemp.ImportRow(dr)
                    ElseIf RequestInfo.showBanned = True And dr("isBanned") = True And RequestInfo.FilterType.ToString.ToLower = "filtered" Then
                        dtCandidateListTemp.ImportRow(dr)
                    ElseIf RequestInfo.showFavourites = False And RequestInfo.showBanned = False And RequestInfo.FilterType.ToString.ToLower = "filtered" Then
                        dtCandidateListTemp.ImportRow(dr)
                    ElseIf RequestInfo.FilterType.ToString.ToLower = "none" Then
                        dtCandidateListTemp.ImportRow(dr)
                    End If

                Next

                dtCandidateList = dtCandidateListTemp
                dtCandidateListTemp.Dispose()


                dtCandidateList.TableName = "Candidates"



                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        CurrentCandidateID = dtCandidateList.Rows(0)("CandidateID")
                    End If
                End If

                'Get Candidate Detailed Information About the First Candidate in the list
                'Basic Info -- This is incomplete.... ****************NEED TO CHECK ****************
                Dim CandidateInfo As DataTable = New DataTable("CandidateBasicInfo")
                Dim ShortlistableJobs As New DataTable("ShortlistableJobs")
                Dim EducationInfo As DataTable = New DataTable("AcademicProfile")
                Dim EmploymentInfo As DataTable = New DataTable("EmploymentProfile")
                Dim CandidatePrefferedLocation As DataTable = New DataTable("CandidatePrefferedLocation")
                Dim CandidateJobIndustry As DataTable = New DataTable("CandidateJobIndustry")
                Dim GeneralInfo As DataTable = New DataTable("GeneralInfo")

                CandidateInfo.TableName = "CandidateBasicInfo"







                Dim isCurrentCandidateShortListable = False
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then

                        CandidateInfo = GetCandidateBasicInfo(con, MyTrans, CurrentCandidateID).Tables(0)
                        CandidateInfo.TableName = "CandidateBasicInfo"
                        CandidateInfo.Columns.Add("isFavourite", GetType(Boolean))
                        CandidateInfo.Columns.Add("isBanned", GetType(Boolean))
                        CandidateInfo.Columns.Add("isShortListable", GetType(Boolean))



                        CandidateInfo.Rows(0)("isFavourite") = dtCandidateList.Rows(0)("isFavourite")
                        CandidateInfo.Rows(0)("isBanned") = dtCandidateList.Rows(0)("isBanned")

                        isCurrentCandidateShortListable = checkIFCandidateShortListable(con, MyTrans, CurrentCandidateID)
                        CandidateInfo.Rows(0)("isShortListable") = isCurrentCandidateShortListable


                    End If
                End If

                '************
                'Load candiate Languages
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        Dim CandidateLanguagesKnown As DataTable = New DataTable
                        CandidateLanguagesKnown = GetCandidateLanguagesKnown(con, MyTrans, CurrentCandidateID).Tables(0)
                        Dim LanguagesKnown As String = ""
                        For Each dr In CandidateLanguagesKnown.Rows
                            LanguagesKnown = LanguagesKnown & dr("Language").ToString & ","
                        Next
                        If LanguagesKnown.IndexOf(",") >= 0 Then
                            LanguagesKnown = LanguagesKnown.Remove(LanguagesKnown.LastIndexOf(","), 1)
                        End If

                        If LanguagesKnown.Trim.Length = 0 Then
                            LanguagesKnown = "-"
                        End If
                        CandidateInfo.Columns.Add("LanguagesKnown", GetType(String))
                        CandidateInfo.Rows(0)("LanguagesKnown") = LanguagesKnown
                        '*******************
                    End If
                End If




                'Load ShortListable Jobs

                If isCurrentCandidateShortListable = True Then
                    ShortlistableJobs = GetShortListableJobs(con, MyTrans, CurrentCandidateID).Tables(0)
                    ShortlistableJobs.TableName = "ShortlistableJobs"

                End If

                'Load Candidate Education History
                EducationInfo.TableName = "AcademicProfile"
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        EducationInfo = GetCandidateEducationInfo(con, MyTrans, CurrentCandidateID).Tables(0)
                        EducationInfo.TableName = "AcademicProfile"

                    End If
                End If

                'Load Candidate Education History
                EmploymentInfo.TableName = "EmploymentProfile"
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        EmploymentInfo = GetWorkHistoryInfo(con, MyTrans, CurrentCandidateID).Tables(0)
                        EmploymentInfo.Columns.Add("JobFrom", GetType(String))
                        EmploymentInfo.Columns.Add("JobTo", GetType(String))

                        'Format Year
                        'For Each dr In EmploymentInfo.Rows
                        '    If dr("FromDate").ToString.Trim.Length > 0 Then
                        '        dr("FromDate") = CDate("FromDate").ToString("MMM, yyyy")
                        '    End If
                        '    If dr("ToDate").ToString.Trim.Length > 0 Then
                        '        dr("ToDate") = CDate("ToDate").ToString("MMM, yyyy")
                        '    End If

                        'Next

                        'EmploymentInfo.Columns.Remove("FromDate")
                        'EmploymentInfo.Columns.Remove("ToDate")

                        EmploymentInfo.TableName = "EmploymentProfile"

                    End If
                End If



                'Load Candidate PrefferedLocation
                CandidatePrefferedLocation.TableName = "CandidatePrefferedLocation"
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        CandidatePrefferedLocation = GetCandidatePrefferedLocation(con, MyTrans, CurrentCandidateID).Tables(0)
                        CandidatePrefferedLocation.TableName = "CandidatePrefferedLocation"

                    End If
                End If


                'Load Candidate Job Industry

                Candidatejobindustry.TableName = "CandidateJobIndustry"
                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        CandidateJobIndustry = GetCandidatePrefferedLocation(con, MyTrans, CurrentCandidateID).Tables(0)
                        CandidateJobIndustry.TableName = "CandidateJobIndustry"

                    End If
                End If





                'Add General Info Table

                GeneralInfo.TableName = "GeneralInfo"
                GeneralInfo.Columns.Add("TotalCandidates", GetType(String))
                GeneralInfo.Columns.Add("TotalInCurrentResult", GetType(String))
                GeneralInfo.Columns.Add("CurrentPage", GetType(String))
                GeneralInfo.Columns.Add("isFilterApplied", GetType(Boolean))
                Dim GIdr As DataRow
                GIdr = GeneralInfo.NewRow

                GIdr("TotalCandidates") = TotalCandidatesCount



                If Not dtCandidateList Is Nothing Then
                    If dtCandidateList.Rows.Count > 0 Then
                        GIdr("TotalInCurrentResult") = dtCandidateList.Rows.Count
                    End If
                End If
                GIdr("CurrentPage") = RequestInfo.PageID
                If RequestInfo.FilterType.ToString.ToLower = "filtered" Then
                    GIdr("isFilterApplied") = True
                Else
                    GIdr("isFilterApplied") = False
                End If

                GeneralInfo.Rows.Add(GIdr)
                GeneralInfo.TableName = "GeneralInfo"



                CandidateList.Tables.Add(dtCandidateList.Copy)
                CandidateList.Tables.Add(CandidateInfo.Copy)
                CandidateList.Tables.Add(ShortlistableJobs.Copy)
                CandidateList.Tables.Add(EducationInfo.Copy)
                CandidateList.Tables.Add(EmploymentInfo.Copy)
                CandidateList.Tables.Add(CandidatePrefferedLocation.Copy)
                CandidateList.Tables.Add(CandidateJobIndustry.Copy)
                CandidateList.Tables.Add(GeneralInfo)



                Dim ResultInfo As DataTable = New DataTable("ResultInfo")
                ResultInfo.Columns.Add("Candidates", GetType(Integer))
                ResultInfo.Columns.Add("CandidateBasicInfo", GetType(Integer))
                ResultInfo.Columns.Add("ShortlistableJobs", GetType(Integer))
                ResultInfo.Columns.Add("AcademicProfile", GetType(Integer))
                ResultInfo.Columns.Add("EmploymentProfile", GetType(Integer))
                ResultInfo.Columns.Add("CandidatePrefferedLocation", GetType(Integer))
                ResultInfo.Columns.Add("CandidateJobIndustry", GetType(Integer))
                ResultInfo.Columns.Add("GeneralInfo", GetType(Integer))

                Dim rDr As DataRow
                rDr = ResultInfo.NewRow()
                rDr("Candidates") = CandidateInfo.Rows.Count
                rDr("CandidateBasicInfo") = CandidateInfo.Rows.Count
                rDr("ShortlistableJobs") = ShortlistableJobs.Rows.Count
                rDr("AcademicProfile") = EducationInfo.Rows.Count
                rDr("EmploymentProfile") = EmploymentInfo.Rows.Count
                rDr("CandidatePrefferedLocation") = CandidatePrefferedLocation.Rows.Count
                rDr("CandidateJobIndustry") = CandidateJobIndustry.Rows.Count
                rDr("GeneralInfo") = GeneralInfo.Rows.Count




                ResultInfo.Rows.Add(rDr)
                CandidateList.Tables.Add(ResultInfo)
                ResultInfo.Dispose()

                EmploymentInfo.Dispose()
                CandidateInfo.Dispose()
                EducationInfo.Dispose()

                ShortlistableJobs.Dispose()
                CandidatePrefferedLocation.Dispose()
                CandidateJobIndustry.Dispose()



                CandidateFavouriteList.Dispose()
                CandiateBannedList.Dispose()
                dtCandidateList.Dispose()

                Return CandidateList
            Catch ex As Exception
                Return Nothing

            Finally
                CandidateList.Dispose()

            End Try

        End Function





        Public Function GetCandidateDetails(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer, RequestingUserID As Integer)

            Dim CandidateList As DataSet = New DataSet("CandidateDetails")
            Try

                Dim CandidateInfo As DataTable = New DataTable
                CandidateInfo.TableName = "CandidateBasicInfo"
                Dim isCurrentCandidateShortListable = False


                CandidateInfo = GetCandidateBasicInfo(con, MyTrans, CandidateID).Tables(0)
                CandidateInfo.TableName = "CandidateBasicInfo"
                CandidateInfo.Columns.Add("isFavourite", GetType(Boolean))
                CandidateInfo.Columns.Add("isBanned", GetType(Boolean))
                CandidateInfo.Columns.Add("isShortListable", GetType(Boolean))
                CandidateInfo.Rows(0)("isFavourite") = False
                CandidateInfo.Rows(0)("isBanned") = False



                'Load candiate Languages
                Dim CandidateLanguagesKnown As DataTable = New DataTable
                CandidateLanguagesKnown = GetCandidateLanguagesKnown(con, MyTrans, CandidateID).Tables(0)

                Dim LanguagesKnown As String = ""

                For Each dr In CandidateLanguagesKnown.Rows
                    LanguagesKnown = LanguagesKnown & dr("Language").ToString & ","
                Next

                If LanguagesKnown.IndexOf(",") >= 0 Then
                    LanguagesKnown = LanguagesKnown.Remove(LanguagesKnown.LastIndexOf(","), 1)
                End If

                If LanguagesKnown.Trim.Length = 0 Then
                    LanguagesKnown = "-"
                End If

                CandidateInfo.Columns.Add("LanguagesKnown", GetType(String))
                CandidateInfo.Rows(0)("LanguagesKnown") = LanguagesKnown




                Dim CandidateBannedFavouritedInfo As DataSet = GetCandidateBannedFavouritedInfo(con, MyTrans, CandidateID, RequestingUserID)
                        If Not CandidateBannedFavouritedInfo Is Nothing Then
                    If CandidateBannedFavouritedInfo.Tables.Count > 0 Then
                        For Each dr In CandidateBannedFavouritedInfo.Tables(0).Rows
                            If dr("cStatus") = "banned" Then
                                CandidateInfo.Rows(0)("isBanned") = True
                            ElseIf dr("cStatus") = "favourite" Then
                                CandidateInfo.Rows(0)("isFavourite") = True
                            End If
                        Next
                    End If
                End If


                        isCurrentCandidateShortListable = checkIFCandidateShortListable(con, MyTrans, CandidateID)
                        CandidateInfo.Rows(0)("isShortListable") = isCurrentCandidateShortListable

                        CandidateList.Tables.Add(CandidateInfo.Copy)


                'Load ShortListable Jobs
                Dim ShortlistableJobs As New DataTable("ShortlistableJobs")

                If isCurrentCandidateShortListable = True Then
                    ShortlistableJobs = GetShortListableJobs(con, MyTrans, CandidateID).Tables(0)
                    ShortlistableJobs.TableName = "ShortlistableJobs"
                    CandidateList.Tables.Add(ShortlistableJobs.Copy)
                End If

                'Load Candidate Education History
                Dim EducationInfo As DataTable = New DataTable
                EducationInfo.TableName = "AcademicProfile"

                EducationInfo = GetCandidateEducationInfo(con, MyTrans, CandidateID).Tables(0)
                EducationInfo.TableName = "AcademicProfile"
                CandidateList.Tables.Add(EducationInfo.Copy)

                'Load Candidate Education History
                Dim EmploymentInfo As DataTable = New DataTable
                EmploymentInfo.TableName = "EmploymentProfile"


                EmploymentInfo = GetWorkHistoryInfo(con, MyTrans, CandidateID).Tables(0)
                        EmploymentInfo.Columns.Add("JobFrom", GetType(String))
                        EmploymentInfo.Columns.Add("JobTo", GetType(String))

                        'Format Year
                        'For Each dr In EmploymentInfo.Rows
                        '    If dr("FromDate").ToString.Trim.Length > 0 Then
                        '        dr("FromDate") = CDate("FromDate").ToString("MMM, yyyy")
                        '    End If
                        '    If dr("ToDate").ToString.Trim.Length > 0 Then
                        '        dr("ToDate") = CDate("ToDate").ToString("MMM, yyyy")
                        '    End If

                        'Next

                        'EmploymentInfo.Columns.Remove("FromDate")
                        'EmploymentInfo.Columns.Remove("ToDate")

                        EmploymentInfo.TableName = "EmploymentProfile"
                        CandidateList.Tables.Add(EmploymentInfo.Copy)



                'Load Candidate PrefferedLocation
                Dim CandidatePrefferedLocation As DataTable = New DataTable
                CandidatePrefferedLocation.TableName = "CandidatePrefferedLocation"
                CandidatePrefferedLocation = GetCandidatePrefferedLocation(con, MyTrans, CandidateID).Tables(0)
                CandidatePrefferedLocation.TableName = "CandidatePrefferedLocation"
                        CandidateList.Tables.Add(CandidatePrefferedLocation.Copy)



                'Load Candidate Job Industry
                Dim CandidateJobIndustry As DataTable = New DataTable
                CandidateJobIndustry.TableName = "CandidateJobIndustry"

                CandidateJobIndustry = GetCandidatePrefferedLocation(con, MyTrans, CandidateID).Tables(0)
                        CandidateJobIndustry.TableName = "CandidateJobIndustry"
                CandidateList.Tables.Add(CandidateJobIndustry.Copy)






                EmploymentInfo.Dispose()
                CandidateInfo.Dispose()
                EducationInfo.Dispose()

                ShortlistableJobs.Dispose()
                CandidatePrefferedLocation.Dispose()
                CandidateJobIndustry.Dispose()


                Return CandidateList
            Catch ex As Exception
                Return Nothing

            End Try




        End Function


        Function GetTotalActiveCandidatesCount(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As Integer
            Try
                Dim cmd As New MySqlCommand
                Dim commandtext As String = "GetCandidateListCount"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                Return JobStation.DatabaseCommands.ExecuteScalar(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return -1
            End Try
        End Function

        Function GetTotalFilteredCandidatesCount(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, cmd As MySqlCommand) As Integer
            Try

                Return JobStation.DatabaseCommands.ExecuteScalar(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return -1
            End Try
        End Function
        Public Function GetCandidateFavouriteList(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, UserID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_userID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_userID").Value = UserID

                Dim commandtext As String = "GetCandidateFavouriteList"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateBannedList(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, UserID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_userID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_userID").Value = UserID

                Dim commandtext As String = "GetCandidateBannedList"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Return JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans) ' change parameters for proper output	
            Catch ex As Exception
                Return Nothing
            End Try

        End Function




        Public Function GetShortListableJobs(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetShortListableJobs"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)


                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function




        Public Function GetActiveJobApplications(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetActiveJobApplications"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetPastJobApplications(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetPastJobApplications"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)


                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateAddFormDropDownContents(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As DataSet

            Try
                Dim cmd As New MySqlCommand

                Dim dtGetVacancyListActive As New DataTable
                Dim dtGetLocationActive As New DataTable
                Dim dtGetJobIndustryActive As New DataTable
                Dim dtGetCountryNationalityActive As New DataTable
                Dim dtGetReligionActive As New DataTable
                Dim dtGetCasteActive As New DataTable
                Dim dtGetLanguageActive As New DataTable

                Dim dtGenderList As New DataTable("Genders")
                Dim dtMaritialStatus As New DataTable("MaritialStatus")
                Dim dtVisaStatus As New DataTable
                Dim dtNoticePeriod As New DataTable("NoticePeriod")
                Dim dtEducationQualification As New DataTable


                dtGenderList.Columns.Add("Gender", GetType(String))
                Dim dr As DataRow
                dr = dtGenderList.NewRow
                dr("Gender") = "Male"
                dtGenderList.Rows.Add(dr)
                dr = dtGenderList.NewRow
                dr("Gender") = "Female"
                dtGenderList.Rows.Add(dr)

                dtMaritialStatus.Columns.Add("StatusID", GetType(String))
                dtMaritialStatus.Columns.Add("Status", GetType(String))
                dr = dtMaritialStatus.NewRow
                dr("StatusID") = "Single"
                dr("Status") = "Single"
                dtMaritialStatus.Rows.Add(dr)
                dr = dtMaritialStatus.NewRow
                dr("StatusID") = "Married"
                dr("Status") = "Married"
                dtMaritialStatus.Rows.Add(dr)

                dtNoticePeriod.Columns.Add("periodID", GetType(String))
                dtNoticePeriod.Columns.Add("period", GetType(String))
                dr = dtNoticePeriod.NewRow
                dr("periodID") = "1"
                dr("period") = "1 month"
                dtNoticePeriod.Rows.Add(dr)
                dr = dtNoticePeriod.NewRow
                dr("periodID") = "2"
                dr("period") = "2 months"
                dtNoticePeriod.Rows.Add(dr)
                dr = dtNoticePeriod.NewRow
                dr("periodID") = "3"
                dr("period") = "3 months"
                dtNoticePeriod.Rows.Add(dr)
                dr = dtNoticePeriod.NewRow
                dr("periodID") = "6"
                dr("period") = "6 months"
                dtNoticePeriod.Rows.Add(dr)


                Dim commandtext As String = "GetVacancyListActive"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                dtGetVacancyListActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)



                cmd.CommandText = "GetVisaStatusActive"
                dtVisaStatus = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                cmd.CommandText = "GetEducationQualificationActive"
                dtEducationQualification = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)


                cmd.CommandText = "GetLocationActive"
                dtGetLocationActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                cmd.CommandText = "GetJobIndustryActive"
                dtGetJobIndustryActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                cmd.CommandText = "GetCountryNationalityActive"
                dtGetCountryNationalityActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                cmd.CommandText = "GetReligionActive"
                dtGetReligionActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)


                cmd.CommandText = "GetCasteActive"
                dtGetCasteActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)

                cmd.CommandText = "GetLanguageActive"
                dtGetLanguageActive = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans).Tables(0)


                dtGetVacancyListActive.TableName = "VacancyList"
                dtGetLocationActive.TableName = "Location"
                dtGetJobIndustryActive.TableName = "JobIndustry"
                dtGetCountryNationalityActive.TableName = "CountryNationalityList"
                dtGetReligionActive.TableName = "Religion"
                dtGetCasteActive.TableName = "Caste"
                dtGetLanguageActive.TableName = "Language"
                dtVisaStatus.TableName = "VisaStatus"
                dtEducationQualification.TableName = "EducationQualification"


                Dim ds As New DataSet
                ds.DataSetName = "DisplayComponents"
                ds.Tables.Add(dtGetVacancyListActive.Copy)
                ds.Tables.Add(dtGetLocationActive.Copy)
                ds.Tables.Add(dtGetJobIndustryActive.Copy)
                ds.Tables.Add(dtGetReligionActive.Copy)
                ds.Tables.Add(dtGetCasteActive.Copy)
                ds.Tables.Add(dtGetLanguageActive.Copy)
                ds.Tables.Add(dtGetCountryNationalityActive.Copy)
                ds.Tables.Add(dtGenderList)
                ds.Tables.Add(dtMaritialStatus)
                ds.Tables.Add(dtVisaStatus.Copy)
                ds.Tables.Add(dtNoticePeriod)
                ds.Tables.Add(dtEducationQualification.Copy)





                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetCandidateApplicationStatus(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, ApplicationID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_ApplicationID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_ApplicationID").Value = ApplicationID


                Dim commandtext As String = "GetCandidateApplicationStatus"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)


                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function checkIFCandidateShortListable(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As Boolean

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "checkIFCandidateShortListable"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim Result As Integer = JobStation.DatabaseCommands.ExecuteScalar(cmd.CommandType, cmd, con, MyTrans)

                If Result = 0 Then
                    Return True
                Else
                    Return False
                End If


            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidateJobIndustry(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetShortListableJobs"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtTimeline As DataTable = New DataTable("CandidateJobIndustry")

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function


        Public Function GetCandidatePrefferedLocation(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetCandidatePrefferedLocation"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtTimeline As DataTable = New DataTable("CandidatePrefferedLocation")

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function

        Public Function GetCandidateLanguagesKnown(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetCandidateLanguagesKnown"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim dtTimeline As DataTable = New DataTable("GetCandidateLanguagesKnown")

                Return ds
            Catch ex As Exception
                Return Nothing
            End Try

        End Function





    End Class



End Namespace

