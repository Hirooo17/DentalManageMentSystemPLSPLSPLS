Imports System.Net
Imports System.Net.Mail

Public Class messaging
    Dim username As String = "retuermahero17@gmail.com"
    Dim password As String = "shyhpilhmdtaiqfz"

    Private Sub sendVerificationCode()
        Dim user As String = usert.Text
        Try
            Dim fromAddress As New MailAddress("noreply@afrilen.com", user)
            Dim toAddress As New MailAddress("retuermahero17@gmail.com")
            Dim subject As String = "Email from " & user
            Dim body As String = message2.Text
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(username, password)
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = subject
            message.Body = body

            smtp.Send(message)

        Catch ex As Exception
            MsgBox("Failed to send the verification email: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sendVerificationCode()
        MsgBox("Email has been sent")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class