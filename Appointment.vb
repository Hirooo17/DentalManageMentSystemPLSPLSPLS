Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports MySql.Data.MySqlClient

Public Class Appointment

    Private patientName As String

    Public Sub New(name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.patientName = name

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click



        ' Get the selected date
        ' Dim appointmentDate As DateTime = datePicker.Value

        ' Save the appointment to the database
        SaveAppointment(patientName)

        ' Close the form
        Me.Close()

    End Sub

    Private Sub SaveAppointment(name As String)

        Dim sql = "INSERT INTO appointment (fullname, date) VALUES (@name, @date)"

        ' Implement database insertion logic here
        Using con As New MySqlConnection("server=localhost;username=root;password=;database=dental_user"),
              cmd As New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@date", datepicker.Value)
            con.Open()
            cmd.ExecuteNonQuery()

        End Using

        ' Refresh the Appointment Viewer Form
        Dim appointmentViewerForm As AppointmentViewerForm = appointmentViewerForm.GetInstance()

    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nametext.Text = patientName
    End Sub
End Class