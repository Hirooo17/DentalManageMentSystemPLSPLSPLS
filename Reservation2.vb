Public Class Reservation2
    Private form1Instance As Form1
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        ' patient form
        If form1Instance Is Nothing OrElse form1Instance.IsDisposed Then
            form1Instance = New Form1()
        End If

        ' Hide the current form (Me)
        Me.Hide()

        ' Show Form1
        form1Instance.Show()

    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click

    End Sub
End Class