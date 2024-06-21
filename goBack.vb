Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class goBack
    Private Sub goBack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadComboBoxNames()
        loadTextBox()
    End Sub


    Private Sub loadComboBoxNames()
        Try
            openCon()

            Dim query As String = "SELECT username FROM patient_account"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read
                cbNames.Items.Add(reader("username").ToString)

            End While

            reader.Close()
            closeCon()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try



    End Sub


    Private Sub loadTextBox()



    End Sub

    Private Sub cbNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNames.SelectedIndexChanged
        emailtxt.Text = cbNames.SelectedItem.ToString
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        sendEmail()
    End Sub


    Dim username As String = "retuermahero17@gmail.com"
    Dim password As String = "iunfxtvwzluwouaa"
    Private Sub sendEmail()

        Dim email As String = emailtxt.Text
        Dim datep As String = dateTime.Value.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")

        Try
            Dim fromAddress As New MailAddress("noreply@afrilen.com", "Dental Clinic ni bossing")
            Dim toAddress As New MailAddress(emailtxt.Text)
            Dim subject As String = "Verify your email address and password"
            Dim body As String = String.Format("Please come back on this date: {0}", datep)
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

        MsgBox("Email has been sent!")
        Close()

    End Sub
End Class