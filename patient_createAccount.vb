Imports MySql.Data.MySqlClient
Public Class patient_createAccount
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim username As String
        Dim password As String

        ' Get the username and password from the TextBox controls
        username = patient.Text
        password = pword.Text

        ' Insert the data into the database
        Try
            ' Open the connection
            openCon()

            ' Prepare the SQL command
            Dim query As String = "INSERT INTO patient_account (username, password) VALUES (@username, @password)"
            Using cmd As New MySqlCommand(query, con)
                ' Add the parameters to the SQL command
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

            ' Show a success message
            MessageBox.Show("The username and password have been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            ' Show an error message
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the connection
            closeCon()
        End Try

        Me.Close()



    End Sub
End Class