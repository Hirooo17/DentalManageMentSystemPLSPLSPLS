Imports MySql.Data.MySqlClient
Module Connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public datatbl As New DataTable


    Sub openCon()
        Try
            If con.ConnectionString = "" Then
                con.ConnectionString = "server=localhost;username=root;password=;database=dental_user"
            End If

            ' Connection open
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If
        Catch ex As Exception
            ' Handle database connection error
            MsgBox("Database connection failed: " & ex.Message, MsgBoxStyle.Critical, "Connection Error")
        End Try
    End Sub

    Sub closeCon()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Database disconnection failed: " & ex.Message, MsgBoxStyle.Critical, "Disconnection Error")
        End Try
    End Sub




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

End Module
