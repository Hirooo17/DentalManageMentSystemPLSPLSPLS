Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class PatientDashboard

    Private procedure As String
    Private userId As String
    Private Sub PatientDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        showData()
        Dim name As String = PatientLogForm.LoggedInUserName
        ' Display the logged-in user's name
        Label1.Text = PatientLogForm.LoggedInUserName

        loadTreatment(name)

        ' Display the logged-in user's image
        If PatientLogForm.LoggedInUserImage IsNot Nothing Then
            Dim imageData As Byte() = PatientLogForm.LoggedInUserImage
            Using ms As New MemoryStream(imageData)
                PictureBox1.Image = Image.FromStream(ms)
            End Using
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub




    Public Sub getInfo(procedure As String, userId As String)

        Me.procedure = procedure
        Me.userId = userId

    End Sub

    Public Sub showData()
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement to retrieve data for the logged-in user
            Dim sql As String = "SELECT name, status, treatment, date FROM patient_current_status WHERE ID = @ID"

            Using cmd As New MySqlCommand(sql, con)
                ' Add parameter for ID (assuming it's the ID of the logged-in user)
                cmd.Parameters.AddWithValue("@ID", PatientLogForm.LoggedInUserID)

                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("status").ColumnName = "Status"
                    dataTable.Columns("treatment").ColumnName = "Treatment"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView (dataGridA)
                    dataGridA.DataSource = dataTable
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            closeCon()
        End Try
    End Sub

    Public Sub updateData(treatment As String, name As String)
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL UPDATE statement
            Dim sql As String = "UPDATE patient_current_status SET treatment = @treatment WHERE name = @name"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@treatment", treatment)
                cmd.Parameters.AddWithValue("@name", name)

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if the update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Treatment updated for patient: " & name, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No records updated for patient: " & name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error updating data in database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            closeCon()
        End Try
    End Sub




    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Profile.Show()
        Hide()

    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub


    Public Sub loadTreatment(name As String)




    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
        Form1.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        ' creation of profile



        createProfile.Show()

    End Sub





    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim userID As Integer = PatientLogForm.LoggedInUserID ' Get the logged-in patient's ID
        Dim userInfo As Dictionary(Of String, Object) = GetUserProfile(userID)

        If userInfo.Count > 0 Then
            Dim profileViewer As New profileViewer()
            profileViewer.ShowUserProfile(userInfo)
            profileViewer.Show()

        Else
            MsgBox("Profile not found for the user ID: " & userID, MsgBoxStyle.Information, "Profile Not Found")
        End If
    End Sub

    Public Function GetUserProfile(userID As Integer) As Dictionary(Of String, Object)
        Dim userInfo As New Dictionary(Of String, Object)

        Try
            openCon()
            Dim query As String = "SELECT * FROM patients_profile WHERE ID = @userID"
            cmd = New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@userID", userID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                userInfo("firstname") = reader("firstname").ToString()
                userInfo("middlename") = reader("middlename").ToString()
                userInfo("lastname") = reader("lastname").ToString()
                userInfo("age") = reader("age").ToString()
                userInfo("gender") = reader("gender").ToString()
                userInfo("contact") = reader("contact").ToString()
                userInfo("block") = reader("block").ToString()
                userInfo("street") = reader("street").ToString()
                userInfo("brgy") = reader("brgy").ToString()
                userInfo("city") = reader("city").ToString()
                userInfo("region") = reader("region").ToString()
                userInfo("zipcode") = reader("zipcode").ToString()
                userInfo("image") = If(reader("image") Is DBNull.Value, Nothing, CType(reader("image"), Byte()))
            End If
            reader.Close()
        Catch ex As Exception
            MsgBox("Error retrieving profile: " & ex.Message, MsgBoxStyle.Critical, "Profile Error")
        Finally
            closeCon()
        End Try

        Return userInfo
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim userID As Integer = PatientLogForm.LoggedInUserID ' Get the logged-in user's ID

        If UserProfileExists(userID) Then
            MessageBox.Show("You have already filled out your profile information.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Show the profile creation form
            Dim createProfileForm As New createProfile()
            createProfile.Show()
        End If

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        messaging.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Assume you have a patient's name in a variable
        Dim patientName As String = PatientLogForm.LoggedInUserName

        ' Create a new instance of the Appointment form with the patient's name
        Dim appointmentForm As New DentalManageMentSystem.Appointment(patientName)

        ' Show the Appointment form
        appointmentForm.Show()





    End Sub

    Private Sub dataGridA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridA.CellContentClick

    End Sub


End Class