Imports System.Net.Mail
Imports System.Threading
Public Class SendEmail
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

End Class
