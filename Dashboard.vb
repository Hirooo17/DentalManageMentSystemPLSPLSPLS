Imports Guna.Charts.WinForms
Imports System
Imports System.Drawing
Imports System.Windows.Forms


Public Class Dashboard
    Private form1Instance As Form1

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        form1Instance = New Form1


        ' Hide the current form (Me)
        Me.Close()


        ' Show Form1
        form1Instance.Show()
    End Sub


    Private patientForm As New Patient


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)
        Dim patientFormInstance = Patient.GetInstance

        ' Show the Patient form
        '  patientFormInstance.Show()

        ' Hide the current form (Menu form)
        '  Me.Hide()

        switchPanel(patientFormInstance)
        patientForm.refreshDataGrid

    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs)
        switchPanel(Reservation)
    End Sub

    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs)
        form1Instance = New Form1


        Hide()



        form1Instance.Show()


    End Sub

    Private Sub dashPanel_Paint(sender As Object, e As PaintEventArgs) Handles dashPanel.Paint

    End Sub

    Private Sub Guna2ImageButton4_Click(sender As Object, e As EventArgs)
        switchPanel(Patient_history)

    End Sub

    Sub switchPanel(ByVal panel As Form)

        switchypanel.Controls.Clear()
        panel.TopLevel = False
        switchypanel.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub reserv_Click(sender As Object, e As EventArgs) Handles reserv.Click
        switchPanel(Reservation)
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim patientFormInstance = Patient.GetInstance

        ' Show the Patient form
        '  patientFormInstance.Show()

        ' Hide the current form (Menu form)
        '  Me.Hide()

        switchPanel(patientFormInstance)

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        switchPanel(Patient_history)


    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        switchPanel(Profile)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        form1Instance = New Form1


        Me.Hide()



        form1Instance.Show()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged


    End Sub
    Dim appointmentViewerForm As AppointmentViewerForm = AppointmentViewerForm.GetInstance()
    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        switchPanel(AppointmentViewerForm)
        appointmentViewerForm.RefreshDataGrid()
    End Sub
End Class