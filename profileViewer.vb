Imports System.IO


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

    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        Me.Dispose()
    End Sub
End Class