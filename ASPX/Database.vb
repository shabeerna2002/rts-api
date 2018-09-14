Imports System.Data

Imports System.Net.Mail
Imports System.Threading
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Imports MySql.Data.MySqlClient


''' <summary>
''' Contains various Methods that interact with  Database. 
''' Common Methods used are ExecuteNonQuery, ExecuteScalar, GetDataTable, GetDataSet(No need to open connection to execute these commands).
''' You may also open connection manually. Important : All the manually OPENED connection should be manually CLOSED after the operation
''' </summary>






Public Class Car
        Public CarName As String
        Public Model As String
        Dim Brand As String



    End Class



