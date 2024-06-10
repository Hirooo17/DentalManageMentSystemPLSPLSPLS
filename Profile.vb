
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Profile


    Private Sub Guna2Chip1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Create a new OpenFileDialog instance
        Dim openFileDialog As New OpenFileDialog

        ' Set the file filter for image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        ' Show the OpenFileDialog and check if the user selected a file
        If openFileDialog.ShowDialog = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            picbox.Image = Image.FromFile(openFileDialog.FileName)

            ' Convert the image to a byte array
            Dim img = picbox.Image
            Dim ms As New MemoryStream
            img.Save(ms, img.RawFormat)
            Dim imgBytes = ms.ToArray

            ' Save the image byte array to the MySQL database
            SaveImageToDatabase(openFileDialog.FileName, imgBytes)


            ' Save the image to the shared variable
            SharedData.SharedImage = imgBytes
        End If
    End Sub

    Private Sub SaveImageToDatabase(fileName As String, imageBytes As Byte())
        ' Open the database connection
        openCon()

        ' SQL query to insert the image
        Dim query As String = "INSERT INTO images (filename, UploadDate, ImageData) VALUES (@FileName, @UploadDate, @ImageData)"

        Using cmd As New MySqlCommand(query, con)
            ' Add the parameters
            cmd.Parameters.AddWithValue("@FileName", Path.GetFileName(fileName))
            cmd.Parameters.AddWithValue("@UploadDate", DateTime.Now)
            cmd.Parameters.AddWithValue("@ImageData", imageBytes)

            ' Execute the query
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Image saved successfully!", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox("Failed to save image: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using

        ' Close the database connection
        closeCon()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
        PatientDashboard.Show()
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class