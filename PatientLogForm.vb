Imports MySql.Data.MySqlClient

Public Class PatientLogForm


    Public Shared LoggedInUserID As Integer
    Public Shared LoggedInUserImage As Byte()
    Public Shared LoggedInUserName As String

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
            LoggedInUserImage = GetUserImage(userID) ' Store the logged-in user image
            LoggedInUserName = GetUserName(userID) ' Store the logged-in user name

            insertUsername()


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

    Private Function GetUserImage(userID As Integer) As Byte()
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to retrieve the user image
            Dim query As String = "SELECT image FROM patients_profile WHERE ID = @userID"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameter to the SQL command
                cmd.Parameters.AddWithValue("@userID", userID)

                ' Execute the command and get the user image
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return CType(result, Byte())
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while retrieving the user image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            ' Close the connection
            closeCon()
        End Try
    End Function

    Private Function GetUserName(userID As Integer) As String
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to retrieve the user's full name
            Dim query As String = "SELECT CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname FROM patients_profile WHERE ID = @userID"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameter to the SQL command
                cmd.Parameters.AddWithValue("@userID", userID)

                ' Execute the command and get the user's full name
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return result.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while retrieving the user name: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        Finally
            ' Close the connection
            closeCon()
        End Try
    End Function

    Public Sub insertUsername()
        ' Assuming this is your variable or control holding the name to insert
        Dim name As String = LoggedInUserName

        ' Check if the name already exists in the patient_current_status table
        If Not IsNameAlreadyExists(name) Then
            ' Name does not exist, proceed with insertion
            Dim sql As String = "INSERT INTO patient_current_status (name, ID) VALUES (@name, @ID)"

            Try
                ' Open the database connection
                openCon()

                ' Set up command
                Using cmd As New MySqlCommand(sql, con)
                    ' Add parameters for the name and ID
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@ID", LoggedInUserID) ' Assuming LoggedInUserID is the ID of the current user

                    ' Execute the command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the insertion was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Name inserted successfully!")
                    Else
                        MessageBox.Show("Failed to insert name.")
                    End If
                End Using

            Catch ex As Exception
                MessageBox.Show($"An error occurred: {ex.Message}")
            Finally
                ' Close the database connection
                closeCon()
            End Try
        Else
            ' Name already exists, show message or proceed as needed
            MessageBox.Show("Name already exists in the database. Proceeding with existing name.")
            ' Proceed with whatever action is needed when the name exists
        End If

    End Sub

    Private Function IsNameAlreadyExists(name As String) As Boolean
        Try
            ' Open the database connection
            openCon()

            ' Prepare SQL SELECT statement to check if the name exists
            Dim query As String = "SELECT COUNT(*) FROM patient_current_status WHERE name = @name"

            Using cmd As New MySqlCommand(query, con)
                ' Add parameter for the name
                cmd.Parameters.AddWithValue("@name", name)

                ' Execute the command and get the count of rows
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' If result is greater than 0, name exists; otherwise, it does not
                Return result > 0
            End Using

        Catch ex As Exception
            MessageBox.Show($"An error occurred while checking name existence: {ex.Message}")
            Return False ' Return false in case of error
        Finally
            ' Close the database connection
            closeCon()
        End Try
    End Function


    Public Function UserProfileExists(userID As Integer) As Boolean
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command to check if the user profile exists
            Dim query As String = "SELECT COUNT(*) FROM patients_profile WHERE ID = @userID"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameter to the SQL command
                cmd.Parameters.AddWithValue("@userID", userID)

                ' Execute the command and get the count of matching records
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' If the count is 1 or more, the profile exists
                Return count > 0
            End Using
        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred while checking the profile existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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