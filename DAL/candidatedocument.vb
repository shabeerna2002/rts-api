Imports MySql.Data.MySqlClient
Imports System.Data
Namespace JobStation.DAL
 Public Class Candidatedocument
Dim TRACE_ERRORS As Boolean = Cl_ErrorManagement.TRACE_ERRORS
Dim TRACE_SUCCESS As Boolean = Cl_ErrorManagement.TRACE_SUCCESS
Dim TRACE_ERRORS_DUPLICATE_LOGS As Boolean = Cl_ErrorManagement.TRACE_ERRORS_DUPLICATE_LOGS
        Public Function Insert(ByVal c As Models.Candidatedocument, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: INSERT Data into table candidatedocument performed On " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            Dim cmd As New MySqlCommand  '........You need to import MySQL.Data..........
            Try
                '----------------declaring MySQL command Parameters-----------
                cmd.Parameters.Add("?p_ExecuteType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Result", MySqlDbType.VarChar)
                cmd.Parameters.Item("?p_Result").Direction = Data.ParameterDirection.Output
                cmd.Parameters.Add("?p_CandidateDocumentID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_CandidateDocumentTypeID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_WorkFlowRequestFileID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_Title", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_Description", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FileName", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_FileLocation", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_MimeType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_DateUploaded", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_DocumentNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_RefNo", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_ValidFrom", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_ValidTill", MySqlDbType.DateTime)
                cmd.Parameters.Add("?p_isAlwaysDisplay", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_isInActive", MySqlDbType.Bit)
                cmd.Parameters.Add("?p_SessionID", MySqlDbType.Int64)
                cmd.Parameters.Add("?p_TransactionKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedBy", MySqlDbType.VarChar)
                cmd.Parameters.Add("?p_UpdatedOn", MySqlDbType.DateTime)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "INSERT"
                cmd.Parameters.Item("?p_CandidateDocumentID").Value = c.CandidateDocumentID
                cmd.Parameters.Item("?p_CandidateID").Value = c.CandidateID
                cmd.Parameters.Item("?p_CandidateDocumentTypeID").Value = c.CandidateDocumentTypeID
                cmd.Parameters.Item("?p_WorkFlowRequestFileID").Value = c.WorkFlowRequestFileID
                cmd.Parameters.Item("?p_Title").Value = c.Title
                cmd.Parameters.Item("?p_Description").Value = c.Description
                cmd.Parameters.Item("?p_FileName").Value = c.FileName
                cmd.Parameters.Item("?p_FileLocation").Value = c.FileLocation
                cmd.Parameters.Item("?p_MimeType").Value = c.MimeType
                cmd.Parameters.Item("?p_DateUploaded").Value = c.DateUploaded
                cmd.Parameters.Item("?p_DocumentNo").Value = c.DocumentNo
                cmd.Parameters.Item("?p_RefNo").Value = c.RefNo
                cmd.Parameters.Item("?p_ValidFrom").Value = c.ValidFrom
                cmd.Parameters.Item("?p_ValidTill").Value = c.ValidTill
                cmd.Parameters.Item("?p_isAlwaysDisplay").Value = c.isAlwaysDisplay
                cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
                cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
                cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
                cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
                cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Insert_candidatedocument"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( Insert DAL in candidatedocument). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "INSERT-ERROR", "Stored Procedure", "Insert_candidatedocument", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: INSERT data into candidatedocument on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            Finally
                If TRACE_SUCCESS = True And result = 200 Then
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_ERRORS_DUPLICATE_LOGS = True And result = 300 Then
                    TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. Insert failed." & vbLf & "Action: INSERT data into candidatedocument on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
                If TRACE_SUCCESS = True And result <> 200 And result <> 300 And result <> 503 Then
                    TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails
                    JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "INSERT-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)
                End If
            End Try
            Return result
        End Function



        Public Function Update (ByVal c As Models.candidatedocument, ByRef con as MySqlConnection,  ByRef MyTrans As MySqlTransaction) As String
Dim TxnKey As String = c.TransactionKey
Dim TxnDetails As String = "Action: UPDATE Data on table candidatedocument performed on " & c.UpdatedOn & " ( " &  c.UpdatedOn.Date.ToLongDateString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table." 
Dim result As Integer = 0
If c.CandidateDocumentID = 0   Then 
result = 301
               If TRACE_ERRORS = TRUE And result = 300 Then	
                   TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. UPDATE failed." & vbLf & "Action: UPDATE data on candidatedocument performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
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
cmd.Parameters.Add("?p_CandidateDocumentID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CandidateID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_CandidateDocumentTypeID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_WorkFlowRequestFileID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_Title",MySqlDbType.varchar)
cmd.Parameters.Add("?p_Description",MySqlDbType.varchar)
cmd.Parameters.Add("?p_FileName",MySqlDbType.varchar)
cmd.Parameters.Add("?p_FileLocation",MySqlDbType.varchar)
cmd.Parameters.Add("?p_MimeType",MySqlDbType.varchar)
cmd.Parameters.Add("?p_DateUploaded",MySqlDbType.datetime)
cmd.Parameters.Add("?p_DocumentNo",MySqlDbType.varchar)
cmd.Parameters.Add("?p_RefNo",MySqlDbType.varchar)
cmd.Parameters.Add("?p_ValidFrom",MySqlDbType.datetime)
cmd.Parameters.Add("?p_ValidTill",MySqlDbType.datetime)
cmd.Parameters.Add("?p_isAlwaysDisplay",MySqlDbType.bit)
cmd.Parameters.Add("?p_isInActive",MySqlDbType.bit)
cmd.Parameters.Add("?p_SessionID",MySqlDbType.Int64)
cmd.Parameters.Add("?p_TransactionKey",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedBy",MySqlDbType.varchar)
cmd.Parameters.Add("?p_UpdatedOn",MySqlDbType.datetime)
'------------------initializing values to parameters
cmd.Parameters.Item("?p_ExecuteType").Value = "UPDATE"
cmd.Parameters.Item("?p_CandidateDocumentID").Value = c.CandidateDocumentID
cmd.Parameters.Item("?p_CandidateID").Value = c.CandidateID
cmd.Parameters.Item("?p_CandidateDocumentTypeID").Value = c.CandidateDocumentTypeID
cmd.Parameters.Item("?p_WorkFlowRequestFileID").Value = c.WorkFlowRequestFileID
cmd.Parameters.Item("?p_Title").Value = c.Title
cmd.Parameters.Item("?p_Description").Value = c.Description
cmd.Parameters.Item("?p_FileName").Value = c.FileName
cmd.Parameters.Item("?p_FileLocation").Value = c.FileLocation
cmd.Parameters.Item("?p_MimeType").Value = c.MimeType
cmd.Parameters.Item("?p_DateUploaded").Value = c.DateUploaded
cmd.Parameters.Item("?p_DocumentNo").Value = c.DocumentNo
cmd.Parameters.Item("?p_RefNo").Value = c.RefNo
cmd.Parameters.Item("?p_ValidFrom").Value = c.ValidFrom
cmd.Parameters.Item("?p_ValidTill").Value = c.ValidTill
cmd.Parameters.Item("?p_isAlwaysDisplay").Value = c.isAlwaysDisplay
cmd.Parameters.Item("?p_isInActive").Value = c.isInActive
cmd.Parameters.Item("?p_SessionID").Value = c.SessionID
cmd.Parameters.Item("?p_TransactionKey").Value = c.TransactionKey
cmd.Parameters.Item("?p_UpdatedBy").Value = c.UpdatedBy
cmd.Parameters.Item("?p_UpdatedOn").Value = c.UpdatedOn
'-----------------Executing to DB-----------------
Dim commandtext As String = "Update_candidatedocument"
cmd.CommandType = Data.CommandType.StoredProcedure
cmd.CommandText = commandtext
result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
               If result = 200 Then	
                   result = cmd.Parameters.Item("?p_Result").Value	
               End If	
           Catch ex As Exception	
               result = 503	
               If TRACE_ERRORS=TRUE Then	
                   TxnDetails = "Error occured during execution Of DAL ( Update DAL in candidatedocument). Transaction returned result code " & result.ToString & ". " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "UPDATE-ERROR", "Stored Procedure", "Update_candidatedocument", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)	
                   TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: UPDATE data on candidatedocument performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-ERROR-ROLLBACK", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           Finally	
               If TRACE_SUCCESS=TRUE And result = 200 Then	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_ERRORS_DUPLICATE_LOGS =TRUE And result = 300 Then	
                   TxnDetails = "Record Already Exist. System Threw 300 Error Message !, Primary key violation or didn't pass data duplicate check. UPDATE failed." & vbLf & "Action: UPDATE data on candidatedocument performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString &  " , "  &  c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-DUPLICATE", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
               If TRACE_SUCCESS= TRUE And result <> 200 And result <> 300 And result <> 503 and result<> 301 Then	
                   TxnDetails = "UNKNOWN STATUS RETURNED. RETURNED STATUS CODE " & result & ". Check Response Codes for more Information. " & TxnDetails	
                   JobStation.DatabaseCommands.UpdateResponses(TxnKey, result, "UPDATE-UNKNOWN", cmd.CommandType.ToString, cmd.CommandText.ToString, TxnDetails, cmd.CommandText.ToString, c.SessionID, c.UpdatedBy, c.UpdatedOn)	
               End If	
           End Try	
           Return result	
End Function



        Public Function Delete(ByVal c As Models.candidatedocument, ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction) As String
            Dim TxnKey As String = c.TransactionKey
            Dim TxnDetails As String = "Action: DELETE Data from table candidatedocument performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
            Dim result As Integer = 0
            If c.CandidateDocumentID = 0 Then
                result = 301
                If TRACE_ERRORS = True And result = 300 Then
                    TxnDetails = "Primary Key not Supplied. System Threw 301 Error Message !, Primary key or keys not supplied to update record. DELETE failed." & vbLf & "Action: DELETE data from candidatedocument performed on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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
                cmd.Parameters.Add("?p_CandidateDocumentID", MySqlDbType.Int64)
                '------------------initializing values to parameters
                cmd.Parameters.Item("?p_ExecuteType").Value = "DELETE"
                cmd.Parameters.Item("?p_CandidateDocumentID").Value = c.CandidateDocumentID
                '-----------------Executing to DB-----------------
                Dim commandtext As String = "Delete_candidatedocument"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext
                result = JobStation.DatabaseCommands.ExecuteNonQuery(CommandType.StoredProcedure, cmd, con, MyTrans) ' change parameters for proper output	
                If result = 200 Then
                    result = cmd.Parameters.Item("?p_Result").Value
                End If
            Catch ex As Exception
                result = 503
                If TRACE_ERRORS = True Then
                    TxnDetails = "Error occured during execution Of DAL ( DELETE DAL in candidatedocument). Transaction returned result code " & result.ToString & ". " & TxnDetails
                    JobStation.DatabaseCommands.UpdateError(TxnKey.ToString, result.ToString, "DELETE-ERROR", "Stored Procedure", "DELETE_candidatedocument", TxnDetails, ex.Message.ToString, "", ex.HResult.ToString, "", ex.Source.ToString, ex.StackTrace.ToString, ex.TargetSite.ToString, cmd.CommandText.ToString, c.SessionID.ToString, c.UpdatedBy.ToString, c.UpdatedOn.ToString)
                    TxnDetails = "ERROR!!. Applicaton Error. System Threw 503. Transaction Rollbacked. For detailed Error report check Error table with Transactiton Key """ & TxnKey & """ ." & vbLf & "Action: DELETE data into candidatedocument on " & c.UpdatedOn & " ( " & c.UpdatedOn.Date.ToLongDateString & " , " & c.UpdatedOn.ToLongTimeString & " ). Transaction done by user with UserID " & c.UpdatedBy & ". For more details regarding user, Check Transacton ID " & c.SessionID & " in transactions table."
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





        Public Function GetCandidateDocumentsActive(ByRef con As MySqlConnection, ByRef MyTrans As MySqlTransaction, CandidateID As Integer) As DataSet

            Try
                Dim cmd As New MySqlCommand
                cmd.Parameters.Add("?p_CandidateID", MySqlDbType.Int64)
                cmd.Parameters.Item("?p_CandidateID").Value = CandidateID


                Dim commandtext As String = "GetCandidateDocumentsActive"
                cmd.CommandType = Data.CommandType.StoredProcedure
                cmd.CommandText = commandtext

                Dim ds As DataSet = JobStation.DatabaseCommands.GetDataset(cmd.CommandType, cmd, con, MyTrans)
                Dim ds1 As New DataSet("CandidateDocuments")
                Dim dtFinal As New DataTable
                Dim dtCandidateDocumentType As New DataTable

                If Not ds.Tables(0) Is Nothing Then
                    If ds.Tables.Count > 0 Then
                        dtFinal = ds.Tables(0).Copy

                        Dim dv As New DataView(ds.Tables(0).Copy)
                        dtCandidateDocumentType = dv.ToTable(True, "CandidateDocumentTypeID", "DocumentType")
                    End If


                    dtCandidateDocumentType.TableName = "TypeOfDocument"
                    dtFinal.TableName = "Document"
                    ds1.Tables.Add(dtCandidateDocumentType)
                    ds1.Tables.Add(dtFinal)


                    If dtFinal.Rows.Count > 0 And dtCandidateDocumentType.Rows.Count > 0 Then
                        Dim ParentChildRelation As DataRelation = New DataRelation("ParentChild", ds1.Tables("TypeOfDocument").Columns("CandidateDocumentTypeID"), ds1.Tables("Document").Columns("CandidateDocumentTypeID"), True)
                        ParentChildRelation.Nested = True
                        ds1.Relations.Add(ParentChildRelation)
                    End If

                    ds1.DataSetName = "CandidateDocuments"

                End If



                Return ds1






            Catch ex As Exception
                Return Nothing
            End Try

        End Function


    End Class
End Namespace

