Imports System.IO
Imports System.Drawing
Imports System.Drawing.Printing

Public Class profileViewer
    Public Sub ShowUserProfile(userInfo As Dictionary(Of String, Object))

        fname.Text = userInfo("firstname").ToString()
        mi.Text = userInfo("middlename").ToString()
        lname.Text = userInfo("lastname").ToString()
        age.Text = userInfo("age").ToString()
        gender.Text = userInfo("gender").ToString()
        contact.Text = userInfo("contact").ToString()
        block.Text = userInfo("block").ToString()
        street.Text = userInfo("street").ToString()
        brgy.Text = userInfo("brgy").ToString()
        city.Text = userInfo("city").ToString()
        region.Text = userInfo("region").ToString()
        zip.Text = userInfo("zipcode").ToString()

        ' Display the image if it exists
        If userInfo("image") IsNot Nothing Then
            Dim imageData As Byte() = CType(userInfo("image"), Byte())
            Using ms As New MemoryStream(imageData)
                picbox.Image = Image.FromStream(ms)
            End Using
        Else
            picbox.Image = Nothing
        End If
    End Sub

    Private Sub profileViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize PrintDocument settings here if needed
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Dispose()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub

    Private Sub printDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            ' Define the font and brush for printing
            Dim fontTitle As New Font("Arial", 18, FontStyle.Bold)
            Dim fontRegular As New Font("Arial", 12)
            Dim brush As New SolidBrush(Color.Black)

            ' Define margins
            Dim leftMargin As Integer = e.MarginBounds.Left
            Dim topMargin As Integer = e.MarginBounds.Top
            Dim lineHeight As Integer = fontRegular.GetHeight(e.Graphics)

            ' Debugging: Check for valid parameters
            If String.IsNullOrEmpty(fname.Text) OrElse
               String.IsNullOrEmpty(mi.Text) OrElse
               String.IsNullOrEmpty(lname.Text) OrElse
               String.IsNullOrEmpty(age.Text) OrElse
               String.IsNullOrEmpty(gender.Text) OrElse
               String.IsNullOrEmpty(contact.Text) OrElse
               String.IsNullOrEmpty(block.Text) OrElse
               String.IsNullOrEmpty(street.Text) OrElse
               String.IsNullOrEmpty(brgy.Text) OrElse
               String.IsNullOrEmpty(city.Text) OrElse
               String.IsNullOrEmpty(region.Text) OrElse
               String.IsNullOrEmpty(zip.Text) Then
                MessageBox.Show("One or more text fields are empty or invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Print the title
            e.Graphics.DrawString("Patient Profile Information", fontTitle, brush, leftMargin, topMargin)
            topMargin += lineHeight * 2

            ' Print the patient information
            e.Graphics.DrawString("Full Name: " & fname.Text & " " & mi.Text & " " & lname.Text, fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight
            e.Graphics.DrawString("Age: " & age.Text, fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight
            e.Graphics.DrawString("Gender: " & gender.Text, fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight
            e.Graphics.DrawString("Contact Information: " & contact.Text, fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight
            e.Graphics.DrawString("Address: " & block.Text & ", " & street.Text & ", " & brgy.Text & ", " & city.Text & ", " & region.Text & ", " & zip.Text, fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight * 2

            ' Print the doctor's signature
            topMargin += lineHeight * 3
            e.Graphics.DrawString("_____________________________", fontRegular, brush, leftMargin, topMargin)
            topMargin += lineHeight
            e.Graphics.DrawString("Doctor's Signature", fontRegular, brush, leftMargin, topMargin)
        Catch ex As Exception
            MessageBox.Show("Error during printing: " & ex.Message)
        End Try
    End Sub
End Class
