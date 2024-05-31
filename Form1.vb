Imports System.Runtime.InteropServices.JavaScript.JSType
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            openCon()
            '  MsgBox("database Connected")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private reservationInstance As Reservation
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)


        ' Instantiate the Patient form if it doesn't exist or is disposed


        ' Hide the current form
        Hide()
        Reservation.Show()



    End Sub
    '' patient

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)

        Dim patientFormInstance = Patient.GetInstance

        ' Show the Patient form
        patientFormInstance.Show()

        ' Hide the current form (Menu form)
        Hide()





    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Hide()
        Dashboard.Show()

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click


        If doctor.Text = "" Then

            MsgBox("PLS ENTER PLS FILL IN THE THE USER", MsgBoxStyle.Exclamation, "ERROR")

        ElseIf passWord.Text = "" Then
            MsgBox("PLS ENTER PLS FILL IN THE THE PASSWORD", MsgBoxStyle.Exclamation, "ERROR")

        ElseIf passWord.Text = "" And doctor.Text = "" Then
            MsgBox("PLS ENTER PLS FILL IN ALL THE TEXT FIELDS", MsgBoxStyle.Exclamation, "ERROR")
        Else
            Hide()
            Dashboard.Show()
        End If








    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        PatientLogForm.Show()

    End Sub
End Class
