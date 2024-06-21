Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class procedure



    Private Sub procedure_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadName()
        LoadProcedures()



        dateTime.Format = DateTimePickerFormat.Custom
        dateTime.CustomFormat = "dddd, dd MMMM yyyy"


    End Sub


    Private Sub loadName()
        Try
            openCon()

            Dim query As String = "SELECT fullname FROM appointment"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read
                cbNames.Items.Add(reader("fullname").ToString)

            End While

            reader.Close()
            closeCon()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub cbNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNames.SelectedIndexChanged
        patientlbl.Text = cbNames.SelectedItem.ToString

    End Sub

    Private Sub LoadProcedures()
        cmbProcedure.Items.AddRange(New String() {
            "Teeth Cleaning (Prophylaxis)",
            "Fillings",
            "Root Canal Treatment",
            "Tooth Extraction",
            "Crowns",
            "Bridges",
            "Dental Implants",
            "Orthodontic Treatment",
            "Teeth Whitening",
            "Veneers",
            "Gum Surgery",
            "Dentures",
            "Sealants",
            "Fluoride Treatments",
            "Oral Cancer Screening",
            "Periodontal Therapy"
        })
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timetx.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub dateTime_ValueChanged(sender As Object, e As EventArgs) Handles dateTime.ValueChanged
        ' Update the TextBox with the selected date and current time
        timeIn.Text = dateTime.Value.ToString("dddd, dd MMMM yyyy hh:mm:ss tt")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim result As DialogResult = MessageBox.Show("Will the patient go back?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            goBack.Show()


        Else

        End If



    End Sub

    Private Sub timeIn_TextChanged(sender As Object, e As EventArgs) Handles timeIn.TextChanged

    End Sub
End Class