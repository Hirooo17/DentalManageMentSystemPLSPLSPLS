Imports System.IO
Imports MySql.Data.MySqlClient

Public Class PatientDashboard





    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Profile.Show()
        Hide()

    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If SharedData.SharedImage IsNot Nothing Then
            Using ms As New MemoryStream(SharedData.SharedImage)
                PictureBox1.Image = Image.FromStream(ms)
            End Using
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dispose()
        Form1.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub PatientDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Display the logged-in user's name
        Label1.Text = PatientLogForm.LoggedInUserName

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class