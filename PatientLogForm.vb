Imports MySql.Data.MySqlClient

Public Class PatientLogForm


    Public Shared LoggedInUserID As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = patient.Text
        Dim password As String = pWord.Text

        ' Verify the credentials
        Dim userID As Integer = VerifyCredentials(username, password)
        If userID <> -1 Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoggedInUserID = userID ' Store the logged-in user ID
            Me.Hide()
            PatientDashboard.Show()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function VerifyCredentials(username As String, password As String) As Integer
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to check the credentials
            Dim query As String = "SELECT ID FROM patient_account WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameters to the SQL command
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute the command and get the user ID if the credentials are valid
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    Return Convert.ToInt32(result)
                Else
                    Return -1
                End If
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while verifying the credentials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        Finally
            ' Close the connection
            closeCon()
        End Try
    End Function



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Close()
        PatientDashboard.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        patient_createAccount.Show()
    End Sub
End Class