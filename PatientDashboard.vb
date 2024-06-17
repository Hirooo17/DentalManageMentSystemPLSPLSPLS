Imports System.IO

Public Class PatientDashboard



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Profile.Show()
        Hide()

    End Sub

    Private Sub PatientDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If SharedData.SharedImage IsNot Nothing Then
            Using ms As New MemoryStream(SharedData.SharedImage)
                PictureBox1.Image = Image.FromStream(ms)
            End Using
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Dispose()
        Form1.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click




        createProfile.Show()

    End Sub
End Class