Imports System.IO
Imports DocumentFormat.OpenXml.Bibliography
Imports MySql.Data.MySqlClient
Imports Mysqlx.Session

Public Class createProfile
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        If fname.Text = "" Or mi.Text = "" Or lname.Text = "" Or age.Text = "" Or gender.Text = "" Or contact.Text = "" Or block.Text = "" Or street.Text = "" Or brgy.Text = "" Or city.Text = "" Or region.Text = "" Or zip.Text = "" Then
            MsgBox("You must first fill all the important information before using this")
        Else
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

            If openFileDialog.ShowDialog = DialogResult.OK Then
                picbox.Image = Image.FromFile(openFileDialog.FileName)
                Dim img = picbox.Image
                Dim ms As New MemoryStream
                img.Save(ms, img.RawFormat)
                Dim imgBytes = ms.ToArray

                insertDatabase(imgBytes)
                SharedData.SharedImage = imgBytes
            End If
        End If




    End Sub




    Private Sub insertDatabase(image As Byte())
        openCon()

        Dim query As String = "INSERT INTO patients_profile (image, firstname, middlename, lastname, age, gender, contact, block, street, brgy, city, region, zipcode) VALUES (@image, @firstname, @middlename, @lastname, @age, @gender, @contact, @block, @street, @brgy, @city, @region, @zipcode)"
        Using cmd As New MySqlCommand(query, con)
            cmd.Parameters.AddWithValue("@image", image)
            cmd.Parameters.AddWithValue("@firstname", fname.Text)
            cmd.Parameters.AddWithValue("@middlename", mi.Text)
            cmd.Parameters.AddWithValue("@lastname", lname.Text)
            cmd.Parameters.AddWithValue("@age", age.Text)
            cmd.Parameters.AddWithValue("@gender", gender.Text)
            cmd.Parameters.AddWithValue("@contact", contact.Text)
            cmd.Parameters.AddWithValue("@block", block.Text)
            cmd.Parameters.AddWithValue("@street", street.Text)
            cmd.Parameters.AddWithValue("@brgy", brgy.Text)
            cmd.Parameters.AddWithValue("@city", city.Text)
            cmd.Parameters.AddWithValue("@region", region.Text)
            cmd.Parameters.AddWithValue("@zipcode", zip.Text)

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Image saved successfully!", MsgBoxStyle.Information, "Success")
            Catch ex As MySqlException
                Dim errorMessage As String = "Failed to save image: " & ex.Message & vbCrLf &
                                         "Query: " & query & vbCrLf &
                                         "Parameters: " & vbCrLf &
                                         "@image: " & image.Length & " bytes" & vbCrLf &
                                         "@firstname: " & fname.Text & vbCrLf &
                                         "@middlename: " & mi.Text & vbCrLf &
                                         "@lastname: " & lname.Text & vbCrLf &
                                         "@age: " & age.Text & vbCrLf &
                                         "@gender: " & gender.Text & vbCrLf &
                                         "@contact: " & contact.Text & vbCrLf &
                                         "@block: " & block.Text & vbCrLf &
                                         "@street: " & street.Text & vbCrLf &
                                         "@brgy: " & brgy.Text & vbCrLf &
                                         "@city: " & city.Text & vbCrLf &
                                         "@region: " & region.Text & vbCrLf &
                                         "@zipcode: " & zip.Text
                MsgBox(errorMessage, MsgBoxStyle.Critical, "Error")
            End Try
        End Using

        closeCon()
    End Sub


End Class