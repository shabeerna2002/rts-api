Imports System.Data

Imports MySql.Data.MySqlClient
Imports StackExchange.Redis

Imports System.Net.Mail
Imports System.Threading
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Namespace JobStation
    ''' <summary>
    ''' Contains various Methods that interact with  Database. 
    ''' Common Methods used are ExecuteNonQuery, ExecuteScalar, GetDataTable, GetDataSet(No need to open connection to execute these commands).
    ''' You may also open connection manually. Important : All the manually OPENED connection should be manually CLOSED after the operation
    ''' </summary>
    Public Module DatabaseCommands
        Public Function AuthenticateUser(UserID As String, UserKey As String, APIKey As String, ConsumerKey As String, Token As String) As String
            Return "VALID-" & Guid.NewGuid.ToString
        End Function

        Public Function GetNewTokenTable(NewToken As String) As DataTable
            Dim dt As DataTable = New DataTable()
            dt.Columns.Add("token")
            Dim dr As DataRow
            dr = dt.NewRow()
            dr("token") = NewToken.Replace("VALID-", "")
            dt.Rows.Add(dr)
            dt.TableName = "token"
            Return dt
        End Function

        Public Async Function SendSMS(ToNumber As String, Message As String) As Task(Of Boolean)
            Dim URL As String = "https://api.smsglobal.com/http-api.php?action=sendsms&user=dlwhuq3f&password=Kxn8u3Vs&&from=SHUROOQ&to=" & ToNumber & "&text=" & Message
            Dim client As Net.Http.HttpClient = New Net.Http.HttpClient()
            Dim getStringTask As Task(Of String) = client.GetStringAsync(URL)

            Dim urlContents As String = Await getStringTask
            Return True
        End Function

        Public Sub SendEmailAsyc(EmailTo As String, EmailSubject As String, EmailBody As String, DisplayName As String, FromEmail As String)
            Dim email As New Thread(Sub() SendEmail(EmailTo, EmailSubject, EmailBody, DisplayName, FromEmail))
            email.IsBackground = True
            email.Start()
        End Sub



        Private Function SendEmail(EmailTo As String, EmailSubject As String, EmailBody As String, DisplayName As String, FromEmail As String) As String
            Try
                Dim Smtp_Server As New SmtpClient
                Dim e_mail As New MailMessage()
                Smtp_Server.UseDefaultCredentials = False

                Dim username As String = ""
                Dim password As String = ""
                Dim smtpPort As String = ""
                Dim smtpServerHost As String = ""
                Dim smtpEnableSSL As Boolean = False



                Smtp_Server.Credentials = New Net.NetworkCredential(username, password)
                Smtp_Server.Port = smtpPort
                Smtp_Server.EnableSsl = smtpEnableSSL
                Smtp_Server.Host = smtpServerHost

                e_mail = New MailMessage()
                e_mail.From = New MailAddress(FromEmail, DisplayName)
                e_mail.To.Add(EmailTo)
                e_mail.Subject = EmailSubject
                e_mail.IsBodyHtml = True
                e_mail.Body = EmailBody
                Smtp_Server.Send(e_mail)
                Return "200"
            Catch ex As Exception
                Return "503"
            End Try
        End Function




        Public Function OpenConnection(Optional ByVal ConnectionString As String = "") As MySqlConnection
            Try
                Dim ConString As String = String.Empty
                If ConnectionString.Trim.Length = 0 Then


                    ConString = "Server=localhost;Database=rts;Uid=root;Pwd=shabeer;SslMode=none;"
                Else
                    ConString = ConnectionString
                End If

                Dim Con As New MySqlConnection(ConString)
                If Not Con.State = ConnectionState.Open Then
                    Con.Open()
                End If
                Return Con
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function CloseConnection(ByRef SqlConnection As MySqlConnection) As Boolean
            If SqlConnection.State <> ConnectionState.Closed Then
                SqlConnection.Close()
            End If
            If Not SqlConnection Is Nothing Then
                SqlConnection.Dispose()
            End If

            Return True
        End Function


        Public Function OpenTransaction(ByRef DbConnection As MySqlConnection, ByVal Optional IsolationLevel As System.Data.IsolationLevel = IsolationLevel.Serializable) As MySqlTransaction
            Dim MyTrans As MySql.Data.MySqlClient.MySqlTransaction
            MyTrans = DbConnection.BeginTransaction(IsolationLevel)
            Return MyTrans
        End Function

        Public Function OpenTransaction(ByVal Optional IsolationLevel As System.Data.IsolationLevel = IsolationLevel.Serializable) As MySqlTransaction

            Dim Con As MySqlConnection = OpenConnection()
            Dim MyTrans As MySql.Data.MySqlClient.MySqlTransaction
            MyTrans = Con.BeginTransaction(IsolationLevel)

            Return MyTrans
        End Function

        Public Function CloseTransaction(ByRef MyTrans As MySqlTransaction, Optional CommitTransaction As Boolean = True, Optional CloseDBConnection As Boolean = False) As Boolean
            Try
                If Not MyTrans Is Nothing Then
                    If CommitTransaction = True Then
                        MyTrans.Commit()
                    End If
                    If CloseDBConnection = True Then
                        MyTrans.Connection.Close()
                        MyTrans.Connection.Dispose()
                    End If
                    MyTrans.Dispose()
                End If
                Return True
            Catch ex As Exception
                Return False

            End Try
        End Function


        Public Function RollBackTransaction(ByRef MyTrans As MySqlTransaction, txnKey As String, TxnID As Integer, UpdatedBy As Integer, UpdatedOn As DateTime, Optional CloseDBConnection As Boolean = False) As Boolean
            Try
                MyTrans.Rollback()

                If CloseDBConnection = True Then
                    MyTrans.Connection.Close()
                    MyTrans.Connection.Dispose()
                End If
                MyTrans.Dispose()

                UpdateRollBackMessage(txnKey, 450, "ROLLBACK", "Transaction Rollbacked", TxnID, UpdatedBy, UpdatedOn)
                Return True
            Catch ex As Exception
                Return False

            End Try
        End Function

        Function GetTransactionKey() As String
            Return Date.UtcNow.Year.ToString & Date.UtcNow.Month.ToString & Date.UtcNow.Day.ToString & Date.UtcNow.Hour.ToString & Date.UtcNow.Second.ToString & Date.UtcNow.Millisecond.ToString & "-" & Date.UtcNow.DayOfYear & "-" & Guid.NewGuid.ToString
            '  Dim TxnDetails As String = Date.UtcNow.Year.ToString & Date.UtcNow.Month.ToString & Date.UtcNow.Day.ToString & Date.UtcNow.Hour.ToString & Date.UtcNow.Second.ToString & Date.UtcNow.Millisecond.ToString & "-" & Date.UtcNow.DayOfYear & "-" & Guid.NewGuid.ToString
        End Function
        'Function UploadFile(PostedFile As Web.HttpPostedFile, FileName As String, Prefix As String) As String
        '    Dim FileExtention As String = System.IO.Path.GetExtension(PostedFile.FileName).ToString()
        '    Dim FileServerLocation As String = Configuration.ConfigurationManager.AppSettings("ImageLocation").ToString
        '    Dim FileSaveAsName As String = Prefix + "-" & Date.UtcNow.Year.ToString & Date.UtcNow.Month.ToString & Date.UtcNow.Day.ToString & Date.UtcNow.Hour.ToString & Date.UtcNow.Second.ToString & Date.UtcNow.Millisecond.ToString & "-" & Date.UtcNow.DayOfYear & "-" & Guid.NewGuid.ToString
        '    PostedFile.SaveAs(FileServerLocation & FileSaveAsName & FileExtention)
        '    Return FileSaveAsName & FileExtention
        'End Function

        Function ExecuteNonQuery(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByRef DbConnection As MySqlConnection, ByRef DbTransaction As MySqlTransaction) As Integer
            Dim SqlCon As New MySqlConnection
            Try
                DbCommand.Connection = DbConnection
                DbCommand.Transaction = DbTransaction
                DbCommand.ExecuteNonQuery()
                'DbTransaction.Commit()
                Try
                    'ExecuteNonQueryAtNodes(DBCommandType, DbCommand)
                Catch ex As Exception

                End Try

                Return 200
            Catch ex As Exception
                DbTransaction.Rollback()
                Return 503
            Finally

            End Try
        End Function



        Function GetLastInsertedID(ByRef DbConnection As MySqlConnection, ByRef DbTransaction As MySqlTransaction) As Object
            Try
                Dim DbCommand As New MySqlCommand
                DbCommand.CommandText = "select LAST_INSERT_ID()"
                DbCommand.CommandType = CommandType.Text
                DbCommand.Connection = DbConnection
                DbCommand.Transaction = DbTransaction
                '  Dim result As String = DbCommand.ExecuteScalar()
                Return DbCommand.ExecuteScalar()
                '  DbTransaction.Commit()

            Catch ex As Exception
                DbTransaction.Rollback()
                Return 0
            Finally

            End Try
        End Function

        Function ExecuteScalar(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByRef DbConnection As MySqlConnection, ByRef DbTransaction As MySqlTransaction) As Object
            Try
                DbCommand.Connection = DbConnection
                DbCommand.Transaction = DbTransaction
                '  Dim result As String = DbCommand.ExecuteScalar()
                Return DbCommand.ExecuteScalar()
                '  DbTransaction.Commit()

            Catch ex As Exception
                DbTransaction.Rollback()
                Return 0
            Finally

            End Try
        End Function

        Function GetDataset(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByRef DbConnection As MySqlConnection, ByRef DbTransaction As MySqlTransaction) As DataSet
            Try
                DbCommand.Connection = DbConnection
                DbCommand.Transaction = DbTransaction

                Dim DS As DataSet = New DataSet
                Dim DA As MySqlDataAdapter = New MySqlDataAdapter
                DA.SelectCommand = DbCommand
                DA.Fill(DS)
                Return DS




            Catch ex As Exception
                DbTransaction.Rollback()
                Return Nothing
            Finally

            End Try
        End Function

        Function GetDataset(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByRef DbConnection As MySqlConnection) As DataSet
            Try
                DbCommand.Connection = DbConnection
                Dim DS As DataSet = New DataSet
                Dim DA As MySqlDataAdapter = New MySqlDataAdapter
                DA.SelectCommand = DbCommand
                DA.Fill(DS)
                Return DS
            Catch ex As Exception

                Return Nothing
            Finally

            End Try
        End Function


        Function ExecuteNonQuery(ByVal DBCommandType As CommandType, ByVal CommandText As String, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As Integer
            Dim SqlCon As New MySqlConnection
            Dim cmd As New MySqlCommand
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If
                cmd.CommandText = CommandText
                cmd.CommandType = DBCommandType
                cmd.Connection = SqlCon

                Dim result As Integer = cmd.ExecuteNonQuery

                Return result
            Catch ex As Exception
                Return 0
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function

        Function ExecuteNonQuery(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As Integer
            Dim SqlCon As New MySqlConnection
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If

                DbCommand.CommandType = DBCommandType
                DbCommand.Connection = SqlCon

                Dim result As Integer = DbCommand.ExecuteNonQuery
                Return result
            Catch ex As Exception
                Return 0
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function

        Function ExecuteNonQuery(ByRef DbTransaction As MySqlTransaction, ByVal DBCommandType As CommandType, ByVal CommandText As String, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "")
            Dim SqlCon As New MySqlConnection
            Dim Cmd As New MySqlCommand
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                    DbTransaction = SqlCon.BeginTransaction
                Else
                    SqlCon = DbConnection
                End If
                Cmd.Connection = SqlCon
                Cmd.Transaction = DbTransaction
                Cmd.CommandText = CommandText
                Cmd.ExecuteNonQuery()
                DbTransaction.Commit()
                Return True
            Catch ex As Exception
                DbTransaction.Rollback()
                Return False
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function

        Function ExecuteNonQuery(ByRef DbTransaction As MySqlTransaction, ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "")
            Dim SqlCon As New MySqlConnection

            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                    DbTransaction = SqlCon.BeginTransaction
                Else
                    SqlCon = DbConnection
                End If
                DbCommand.Transaction = DbTransaction
                DbCommand.ExecuteNonQuery()
                DbTransaction.Commit()
                Return True
            Catch ex As Exception
                DbTransaction.Rollback()
                Return False
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function




        Function ExecuteScalar(ByVal DBCommandType As CommandType, ByVal CommandText As String, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As Object
            Dim SqlCon As New MySqlConnection
            Dim cmd As New MySqlCommand
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)

                Else
                    SqlCon = DbConnection
                End If
                cmd.CommandText = CommandText
                cmd.CommandType = DBCommandType
                cmd.Connection = SqlCon

                Return cmd.ExecuteScalar

            Catch ex As Exception
                Return 0
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function

        Function ExecuteScalar(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As Object
            Dim SqlCon As New MySqlConnection
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If

                DbCommand.CommandType = DBCommandType
                DbCommand.Connection = SqlCon

                Return DbCommand.ExecuteScalar

            Catch ex As Exception
                Return Nothing
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function


        Function GetDataTable_old(ByVal DBCommandType As CommandType, ByVal CommandText As String, ByVal isConnectionOpen As Boolean, Optional ByVal DbParameters As MySqlParameterCollection = Nothing, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As DataTable
            Dim SqlCon As New MySqlConnection
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If
                Dim cmd As New MySqlCommand(CommandText, SqlCon)
                cmd.CommandType = DBCommandType
                Using SqlCon
                    Using cmd
                        Using myReader As MySqlDataReader = cmd.ExecuteReader()
                            Dim myTable As New DataTable()
                            myTable.BeginLoadData()
                            myTable.Load(myReader)
                            myTable.EndLoadData()
                            Return myTable
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Return Nothing
            Finally
                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If
            End Try
        End Function

        Function GetDataTable_old(ByVal DBCommandType As CommandType, ByVal DbCommand As MySqlCommand, ByRef DbConnection As MySqlConnection) As DataTable
            Dim SqlCon As New MySqlConnection
            Try

                SqlCon = DbConnection
                DbCommand.CommandType = DBCommandType
                DbCommand.Connection = SqlCon

                Using SqlCon
                    Using DbCommand
                        Using myReader As MySqlDataReader = DbCommand.ExecuteReader()
                            Dim myTable As New DataTable()
                            myTable.BeginLoadData()
                            myTable.Load(myReader)
                            myTable.EndLoadData()
                            Return myTable
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                Return Nothing


            End Try
        End Function



        Function GetDataSet(ByVal DBCommandType As CommandType, ByVal CommandText As String, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As DataSet
            Dim SqlCon As New MySqlConnection
            Dim cmd As MySqlCommand = New MySqlCommand(CommandText, SqlCon)
            Dim DS As DataSet = New DataSet
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If

                Dim DA As MySqlDataAdapter = New MySqlDataAdapter
                DA.SelectCommand = cmd
                cmd.Connection = SqlCon


                DA.Fill(DS)
                Return DS

            Catch ex As Exception
                Return Nothing
            Finally

                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If

            End Try
        End Function

        Function GetDataSet(ByVal DBCommandType As CommandType, ByVal cmd As MySqlCommand, ByVal isConnectionOpen As Boolean, Optional ByRef DbConnection As MySqlConnection = Nothing, Optional ByVal ConnectionString As String = "") As DataSet
            Dim SqlCon As New MySqlConnection

            Dim DS As DataSet = New DataSet
            Try
                If Not isConnectionOpen Then
                    SqlCon = OpenConnection(ConnectionString)
                Else
                    SqlCon = DbConnection
                End If

                Dim DA As MySqlDataAdapter = New MySqlDataAdapter
                DA.SelectCommand = cmd
                cmd.Connection = SqlCon


                DA.Fill(DS)
                Return DS

            Catch ex As Exception
                Return Nothing
            Finally

                If Not isConnectionOpen Then
                    If SqlCon.State <> ConnectionState.Closed Then
                        CloseConnection(SqlCon)
                    End If
                End If

            End Try
        End Function

        Function UpdateRollBackMessage(TxnKey As String, StatusCode As String, TxnType As String, TxnDetails As String, TxnID As Integer, UpdatedBy As Integer, UpdatedOn As DateTime) As Integer
            Dim cmd As New MySqlCommand
            Dim Con As New MySqlConnection("")
            Dim Result As Integer = 0
            Try
                cmd.Parameters.Add("?TxnKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?StatusCode", MySqlDbType.Int64)
                cmd.Parameters.Add("?TxtDetails", MySqlDbType.VarChar)
                cmd.Parameters.Add("?Data", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnID", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedBy", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedOn", MySqlDbType.DateTime)

                cmd.Parameters.Item("?TxnKey").Value = TxnKey
                cmd.Parameters.Item("?TxnType").Value = TxnType
                cmd.Parameters.Item("?StatusCode").Value = StatusCode
                cmd.Parameters.Item("?TxtDetails").Value = TxnDetails
                cmd.Parameters.Item("?TxnID").Value = TxnID
                cmd.Parameters.Item("?UpdatedBy").Value = UpdatedBy
                cmd.Parameters.Item("?UpdatedOn").Value = UpdatedOn

                cmd.CommandText = "insert into responses(TxnKey,TxnType,StatusCode,TxnDetails,Data,SessionID,UpdatedBy,UpdatedOn) values (?TxnKey,?TxnType, ?StatusCode, ?TxtDetails,?Data,?TxnID,?UpdatedBy,?UpdatedOn) "
                cmd.Connection = Con
                Con.Open()
                cmd.ExecuteNonQuery()
                Result = 200

            Catch ex As Exception
                Result = 500
            Finally
                If Con.State <> ConnectionState.Closed Then
                    Con.Close()
                End If
                cmd.Dispose()
                Con.Dispose()
            End Try
            Return Result
        End Function
        Function UpdateResponses(TxnKey As String, StatusCode As String, TxnType As String, CommandType As String, CommandText As String, TxnDetails As String, Data As String, TxnID As Integer, UpdatedBy As Integer, UpdatedOn As DateTime) As Integer
            Dim cmd As New MySqlCommand
            Dim Con As New MySqlConnection("")
            Dim Result As Integer = 0
            Try
                cmd.Parameters.Add("?TxnKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?CommandType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?CommandText", MySqlDbType.VarChar)
                cmd.Parameters.Add("?StatusCode", MySqlDbType.Int64)
                cmd.Parameters.Add("?TxtDetails", MySqlDbType.VarChar)
                cmd.Parameters.Add("?Data", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnID", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedBy", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedOn", MySqlDbType.DateTime)

                cmd.Parameters.Item("?TxnKey").Value = TxnKey
                cmd.Parameters.Item("?TxnType").Value = TxnType
                cmd.Parameters.Item("?CommandType").Value = CommandType
                cmd.Parameters.Item("?CommandText").Value = CommandText
                cmd.Parameters.Item("?StatusCode").Value = StatusCode
                cmd.Parameters.Item("?TxtDetails").Value = TxnDetails
                cmd.Parameters.Item("?TxnID").Value = TxnID
                cmd.Parameters.Item("?UpdatedBy").Value = UpdatedBy
                cmd.Parameters.Item("?UpdatedOn").Value = UpdatedOn

                cmd.CommandText = "insert into responses(TxnKey,TxnType,CommandType,CommandText,StatusCode,TxnDetails,Data,SessionID,UpdatedBy,UpdatedOn) values (?TxnKey,?TxnType,?CommandType,?CommandText,?StatusCode,?TxtDetails,?Data,?TxnID,?UpdatedBy,?UpdatedOn) "
                cmd.Connection = Con
                Con.Open()
                cmd.ExecuteNonQuery()
                Result = 200

            Catch ex As Exception
                Result = 500
            Finally
                If Con.State <> ConnectionState.Closed Then
                    Con.Close()
                End If
                cmd.Dispose()
                Con.Dispose()
            End Try
            Return Result

        End Function

        Function UpdateError(TxnKey As String, StatusCode As String, TxnType As String, CommandType As String, CommandText As String, TxnDetails As String, Message As String, HelpLink As String, HResult As String, InnerException As String, Source As String, StackTrace As String, TargetSite As String, Data As String, TxnID As String, UpdatedBy As String, UpdatedOn As String) As Integer
            Dim cmd As New MySqlCommand
            Dim Con As New MySqlConnection("")
            Dim Result As Integer = 0
            Try
                cmd.Parameters.Add("?TxnKey", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?StatusCode", MySqlDbType.Int64)
                cmd.Parameters.Add("?TxnDetails", MySqlDbType.VarChar)
                cmd.Parameters.Add("?CommandType", MySqlDbType.VarChar)
                cmd.Parameters.Add("?CommandText", MySqlDbType.VarChar)
                cmd.Parameters.Add("?Message", MySqlDbType.VarChar)
                cmd.Parameters.Add("?HelpLink", MySqlDbType.VarChar)
                cmd.Parameters.Add("?HResult", MySqlDbType.VarChar)
                cmd.Parameters.Add("?InnerException", MySqlDbType.VarChar)
                cmd.Parameters.Add("?Source", MySqlDbType.VarChar)
                cmd.Parameters.Add("?StackTrace", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TargetSite", MySqlDbType.VarChar)
                cmd.Parameters.Add("?Data", MySqlDbType.VarChar)
                cmd.Parameters.Add("?TxnID", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedBy", MySqlDbType.Int64)
                cmd.Parameters.Add("?UpdatedOn", MySqlDbType.DateTime)

                cmd.Parameters.Item("?TxnKey").Value = TxnKey
                cmd.Parameters.Item("?TxnType").Value = TxnType
                cmd.Parameters.Item("?StatusCode").Value = StatusCode
                cmd.Parameters.Item("?TxnDetails").Value = TxnDetails
                cmd.Parameters.Item("?CommandType").Value = CommandType
                cmd.Parameters.Item("?CommandText").Value = CommandText
                cmd.Parameters.Item("?Message").Value = Message
                cmd.Parameters.Item("?HelpLink").Value = HelpLink
                cmd.Parameters.Item("?InnerException").Value = InnerException
                cmd.Parameters.Item("?Source").Value = Source
                cmd.Parameters.Item("?StackTrace").Value = StackTrace
                cmd.Parameters.Item("?TargetSite").Value = TargetSite
                cmd.Parameters.Item("?Data").Value = Data
                cmd.Parameters.Item("?TxnID").Value = TxnID
                cmd.Parameters.Item("?UpdatedBy").Value = UpdatedBy
                cmd.Parameters.Item("?UpdatedOn").Value = UpdatedOn

                cmd.CommandText = "insert into errors (TxnKey,TxnType,StatusCode,TxnDetails,CommandType,CommandText,Message,HelpLink,HResult,InnerException,Source,StackTrace,TargetSite,Data,SessionID,UpdatedBy,UpdatedOn) values (?TxnKey,?TxnType,?StatusCode,?TxnDetails,?CommandType,?CommandText,?Message,?HelpLink,?HResult,?InnerException,?Source,?StackTrace,?TargetSite,?Data,?TxnID,?UpdatedBy,?UpdatedOn)"
                cmd.Connection = Con
                Con.Open()
                cmd.ExecuteNonQuery()
                Result = 200

            Catch ex As Exception
                Result = 500
            Finally
                If Con.State <> ConnectionState.Closed Then
                    Con.Close()
                End If
                cmd.Dispose()
                Con.Dispose()
            End Try
            Return Result

        End Function


        Sub AddValuesToRedis(DatabseID As Integer, Key As String, Value As String)
            Dim redis As ConnectionMultiplexer = ConnectionMultiplexer.Connect("localhost,password=shabeer")
            Dim db As IDatabase = redis.GetDatabase(DatabseID)

            db.StringSetAsync(Key, Value)
            redis.CloseAsync()
        End Sub

        Function GetValuesToRedis(DatabseID As Integer, Key As String) As String
            Dim redis As ConnectionMultiplexer = ConnectionMultiplexer.Connect("localhost,password=shabeer")
            Dim db As IDatabase = redis.GetDatabase(DatabseID)

            Dim Result As String = db.StringGet(Key).ToString
            redis.CloseAsync()
            Return Result

        End Function

        Sub DeleteKeyFromRedis(DatabseID As Integer, Key As String)
            Dim redis As ConnectionMultiplexer = ConnectionMultiplexer.Connect("localhost,password=shabeer")
            Dim db As IDatabase = redis.GetDatabase(DatabseID)
            db.KeyDeleteAsync(Key)
            redis.CloseAsync()
        End Sub

        Private Sub FuntionName(ByVal Data As List(Of Object))
            Dim dt As New DataTable
            Dim CarList As New List(Of Car)
            For Each dr In dt.Rows
                Dim nCar As New Car
                nCar.CarName = dr("CarName").ToString
                nCar.Model = dr("Model").ToString
                CarList.Add(nCar)
            Next
            dt.Dispose()

        End Sub

        Public Function Encrypt(ByVal plainText As String) As String

            Dim passPhrase As String = "Shu@rock@Mac/Hamid832Shab45"
            Dim saltValue As String = "App1eM2n78R1n45d"
            Dim hashAlgorithm As String = "SHA256"

            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256

            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
            Dim symmetricKey As New RijndaelManaged()

            symmetricKey.Mode = CipherMode.CBC

            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim cipherTextBytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            cryptoStream.Close()
            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
            Return cipherText
        End Function
        Public Function Decrypt(ByVal cipherText As String) As String
            Dim passPhrase As String = "Shu@rock@Mac/Hamid832Shab45"
            Dim saltValue As String = "App1eM2n78R1n45d"
            Dim hashAlgorithm As String = "SHA256"

            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256
            ' Convert strings defining encryption key characteristics into byte
            ' arrays. Let us assume that strings only contain ASCII codes.
            ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
            ' encoding.
            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

            ' Convert our ciphertext into a byte array.
            Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

            ' First, we must create a password, from which the key will be 
            ' derived. This password will be generated from the specified 
            ' passphrase and salt value. The password will be created using
            ' the specified hash algorithm. Password creation can be done in
            ' several iterations.
            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As New RijndaelManaged()

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC

            ' Generate decryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As New MemoryStream(cipherTextBytes)

            ' Define cryptographic stream (always use Read mode for encryption).
            Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

            ' Since at this point we don't know what the size of decrypted data
            ' will be, allocate the buffer long enough to hold ciphertext;
            ' plaintext is never longer than ciphertext.
            Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

            ' Start decrypting.
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

            ' Return decrypted string.   
            Return plainText
        End Function

    End Module





    Public Class Car
        Public CarName As String
        Public Model As String
        Dim Brand As String



    End Class


End Namespace
