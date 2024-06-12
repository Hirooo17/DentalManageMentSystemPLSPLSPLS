Imports MySql.Data.MySqlClient

Public Class PatientLogForm

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
        If VerifyCredentials(username, password) Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            PatientDashboard.Show()

        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function VerifyCredentials(username As String, password As String) As Boolean
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to check the credentials
            Dim query As String = "SELECT COUNT(*) FROM patient_account WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameters to the SQL command
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute the command and get the count of matching records
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' If the count is 1, the credentials are valid
                Return count = 1
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while verifying the credentials: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
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