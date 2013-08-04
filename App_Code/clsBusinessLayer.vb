' Namespace for sending email
Imports System.Net.Mail
Imports Microsoft.VisualBasic

Public Class clsBusinessLayer
    Public Shared Function SendEmail(ByVal Sender As String, ByVal Recepient As String, ByVal bcc As String, ByVal cc As String, ByVal Subject As String, ByVal Body As String)
        Try

            ' Variable declared
            Dim MyMailMessage As New MailMessage()

            ' New object Sender
            MyMailMessage.From = New MailAddress(Sender)

            ' New object Recepient to String
            MyMailMessage.To.Add(New MailAddress(Recepient))

            ' If statement
            If Not bcc Is Nothing And bcc <> String.Empty Then
                ' comments
                MyMailMessage.Bcc.Add(New MailAddress(bcc))
            End If

            ' Message body
            MyMailMessage.Body = Body

            ' Specify True for HTML in body
            MyMailMessage.IsBodyHtml = True

            ' Sets priority to normal
            MyMailMessage.Priority = MailPriority.Normal

            ' Variable declared
            Dim MySmtpClient As New SmtpClient()

            ' Sets the port and host IP address
            MySmtpClient.Port = 25
            MySmtpClient.Host = "127.0.0.1"

            ' SMTP Send method
            MySmtpClient.Send(MyMailMessage)

            ' Return True for object variable
            Return True

        Catch ex As Exception

            ' Return False for exception handling
            Return False

        End Try

    End Function
End Class
