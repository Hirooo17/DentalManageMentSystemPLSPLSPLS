Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class patient_createAccount

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub


    Dim random As New Random()
    Dim VerificationCode As String = random.Next(100000, 999999).ToString()

    Dim username As String = "retuermahero17@gmail.com"
    Dim password As String = "pgpvvtgq dympvmzs"

    Private Sub sendVerificationCode()
        Try
            Dim fromAddress As New MailAddress("noreply@afrilen.com", "Dental Clinic ni bossing")
            Dim toAddress As New MailAddress(patient.Text)
            Dim subject As String = "Verify your email address and password"
            Dim body As String = String.Format("Please use the following code to verify your email address for our app: {0}", VerificationCode)
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

    Private Sub OpenVerificationForm()
        Dim verificationForm As New verification()
        verificationForm.VerificationCode = VerificationCode
        verificationForm.Username = patient.Text
        verificationForm.Password = pword.Text
        verificationForm.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim username As String
        Dim password As String

        ' Get the username and password from the TextBox controls
        username = patient.Text
        password = pword.Text

        ' Check if the email is a Gmail account
        If Not IsGmailAccount(username) Then
            MessageBox.Show("Please use a Gmail account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the username already exists in the database
        If UsernameExists(username) Then
            MessageBox.Show("Username already exists. Please enter another unique username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Send the verification code
        sendVerificationCode()
        MessageBox.Show("A verification code has been sent to your email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Open the verification form
        Me.Hide()
        OpenVerificationForm()
    End Sub

    Private Function IsGmailAccount(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@gmail\.com$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Function UsernameExists(username As String) As Boolean
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to check if the username exists
            Dim query As String = "SELECT COUNT(*) FROM patient_account WHERE username = @username"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameter to the SQL command
                cmd.Parameters.AddWithValue("@username", username)

                ' Execute the command and get the count of records with the given username
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' If the count is greater than 0, the username exists
                Return count > 0
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while checking the username: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Close the connection
            closeCon()
        End Try
    End Function
End Class
