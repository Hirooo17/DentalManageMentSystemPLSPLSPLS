Imports MySql.Data.MySqlClient

Public Class Reservation

    ' Singleton instance of the Patient form



    Private Sub WelcomeLbl_Click(sender As Object, e As EventArgs) Handles WelcomeLbl.Click

    End Sub
    Private form1Instance As Dashboard
    Private patientins As Patient

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs)

        form1Instance = New Dashboard


        ' Hide the current form (Me)
        Hide()

        ' Show Form1
        form1Instance.Show()

    End Sub

    Private Sub Guna2GradientCircleButton2_Click(sender As Object, e As EventArgs)
        Dim date1 = datap.Value


    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles male.CheckedChanged
        If male.Checked Then

        End If
    End Sub
    Private patientFormInstance As Patient
    Private Sub continuebtn_Click(sender As Object, e As EventArgs) Handles continuebtn.Click

        ' Get instance of the Patient form
        Dim patientFormInstance = Patient.GetInstance

        ' Construct SQL INSERT statement
        Dim sql = "INSERT INTO patients (name, address, contact, gender, age, emergContact,dentalH, date) VALUES (@name, @address, @contact, @gender, @age, @emergContact, @dentalH, @date)"

        ' Set up command with parameters
        Using con As New MySqlConnection("server=localhost;username=root;password=;database=dental_user"),
              cmd As New MySqlCommand(sql, con)
            ' Add parameters
            cmd.Parameters.AddWithValue("@name", nameTxt.Text)
            cmd.Parameters.AddWithValue("@address", addressTxt.Text)
            cmd.Parameters.AddWithValue("@contact", contactTxt.Text)
            cmd.Parameters.AddWithValue("@emergContact", emergencyContTxt.Text)
            cmd.Parameters.AddWithValue("@dentalH", dentalHtxt.Text)

            ' Add other parameters similarly

            ' Set gender parameter based on radio button selection
            Dim gender = ""
            If male.Checked Then
                gender = "Male"
            ElseIf female.Checked Then
                gender = "Female"
            End If
            cmd.Parameters.AddWithValue("@gender", gender)

            ' Set age parameter
            cmd.Parameters.AddWithValue("@age", age.Text)

            ' Set date parameter
            cmd.Parameters.AddWithValue("@date", datap.Value)

            ' Execute the command
            con.Open
            cmd.ExecuteNonQuery
        End Using

        ' Show message to user
        MessageBox.Show("Reservation has been added")
        patientFormInstance.refreshDataGrid
        ' Show the Patient form
        nameTxt.Text = ""
        addressTxt.Text = ""
        contactTxt.Text = ""
        emergencyContTxt.Text = ""
        dentalHtxt.Text = ""

        ' Hide the current form (Reservation form)








        ' REFRESH DATA GRID





    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 100
            age.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim res2 As New Reservation2
        ' this code is for reservation
        Dim name = nameTxt.Text
        res2.named.Text = name

        Dim adress = addressTxt.Text
        res2.addresed.Text = adress

        Dim contacts = contactTxt.Text
        res2.contacted.Text = contacts

        Dim emerg = emergencyContTxt.Text
        res2.emergencyed.Text = emerg

        Me.Dispose()
        res2.Show()

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        form1Instance = New Dashboard


        ' Hide the current form (Me)
        Me.Hide()

        ' Show Form1
        form1Instance.Show()
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class