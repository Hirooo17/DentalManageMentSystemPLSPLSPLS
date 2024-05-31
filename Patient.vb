Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet
Imports MySql.Data.MySqlClient

Public Class Patient
    Private Shared instance As Patient

    ' Get instance of the Patient form
    Public Shared Function GetInstance() As Patient
        If instance Is Nothing OrElse instance.IsDisposed Then
            instance = New Patient()
        End If
        Return instance
    End Function

    ' Constructor
    Public Sub New()

        InitializeComponent()


    End Sub


    Private form1Instance As Dashboard
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        form1Instance = New Dashboard


        ' Hide the current form (Me)
        Hide()

        ' Show Form1
        form1Instance.Show()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Using sfd As New SaveFileDialog
            sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    Using workbook As New XLWorkbook
                        Dim worksheet = workbook.Worksheets.Add("Sheet1")

                        ' Add column headers
                        worksheet.Cell(1, 1).Value = "Name"
                        worksheet.Cell(1, 2).Value = "Address"
                        worksheet.Cell(1, 3).Value = "Age"
                        worksheet.Cell(1, 4).Value = "Gender"
                        worksheet.Cell(1, 5).Value = "Contact Information"
                        worksheet.Cell(1, 6).Value = "Emergency Contact"
                        worksheet.Cell(1, 7).Value = "Dental History"
                        worksheet.Cell(1, 8).Value = "Date of Reservation"

                        ' Retrieve data from the SQL database
                        Dim connectionString As String = "server=localhost;username=root;password=;database=dental_user"
                        Dim sqlQuery As String = "SELECT name, address, age, gender, contact, emergContact, dentalH, date FROM patients"

                        Using connection As New MySqlConnection(connectionString)
                            Using command As New MySqlCommand(sqlQuery, connection)
                                connection.Open()
                                Dim reader As MySqlDataReader = command.ExecuteReader()
                                Dim row As Integer = 2 ' Start from row 2 after headers

                                ' Populate Excel worksheet with data from the database
                                While reader.Read()
                                    worksheet.Cell(row, 1).Value = reader("name").ToString()
                                    worksheet.Cell(row, 2).Value = reader("address").ToString()
                                    worksheet.Cell(row, 3).Value = reader("age").ToString()
                                    worksheet.Cell(row, 4).Value = reader("gender").ToString()
                                    worksheet.Cell(row, 5).Value = reader("contact").ToString()
                                    worksheet.Cell(row, 6).Value = reader("emergContact").ToString()
                                    worksheet.Cell(row, 7).Value = reader("dentalH").ToString()
                                    worksheet.Cell(row, 8).Value = reader("date").ToString()
                                    row += 1
                                End While

                                reader.Close()
                            End Using
                        End Using

                        ' Save the workbook to the selected file path
                        workbook.SaveAs(sfd.FileName)

                        MessageBox.Show("Excel file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error saving Excel file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using

    End Sub



    ' Method to get the number of patients
    Public Function GetNumberOfPatients() As Integer
        Return dataGrid.Rows.Count
    End Function

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, contact, gender, age, emergContact, dentalH, date FROM patients"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)


                    ' Rename the columns
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("contact").ColumnName = "Contact"
                    dataTable.Columns("gender").ColumnName = "Gender"
                    dataTable.Columns("age").ColumnName = "Age"
                    dataTable.Columns("emergContact").ColumnName = "Emergency Contact"
                    dataTable.Columns("dentalH").ColumnName = "Dental History"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable

                    ' Update the label with the number of patients

                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            con.Close()
        End Try


    End Sub


    Public Sub UpdateNumberOfPatientsLabel()
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement to count the number of rows
            Dim sql As String = "SELECT COUNT(*) FROM patients"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get the number of rows
                Dim rowCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Update the label with the number of patients
                numOfPatientsLbl.Text = rowCount.ToString()
            End Using
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error updating number of patients: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub

    Private Sub Patient_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, contact, gender, age, emergContact, dentalH, date FROM patients"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("contact").ColumnName = "Contact"
                    dataTable.Columns("gender").ColumnName = "Gender"
                    dataTable.Columns("age").ColumnName = "Age"
                    dataTable.Columns("emergContact").ColumnName = "Emergency Contact"
                    dataTable.Columns("dentalH").ColumnName = "Dental History"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable

                    ' Update the label with the number of patients
                    UpdateNumberOfPatientsLabel()

                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            con.Close()
        End Try

    End Sub

    Private Sub Guna2Button3_Click_1(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, contact, gender, age, emergContact, dentalH, date FROM patients"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("contact").ColumnName = "Contact"
                    dataTable.Columns("gender").ColumnName = "Gender"
                    dataTable.Columns("age").ColumnName = "Age"
                    dataTable.Columns("emergContact").ColumnName = "Emergency Contact"
                    dataTable.Columns("dentalH").ColumnName = "Dental History"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable

                    UpdateNumberOfPatientsLabel()

                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub

    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        Try
            If dataGrid.DataSource IsNot Nothing AndAlso Not String.IsNullOrEmpty(searchTxt.Text) Then
                Dim dataTable As DataTable = TryCast(dataGrid.DataSource, DataTable)
                If dataTable IsNot Nothing Then
                    ' Filter only by the "Name" column
                    Dim filterExpression As String = String.Format("Name LIKE '%{0}%'", searchTxt.Text)
                    dataTable.DefaultView.RowFilter = filterExpression
                End If
            ElseIf dataGrid.DataSource IsNot Nothing Then
                ' Clear the filter when the search box is empty
                CType(dataGrid.DataSource, DataTable).DefaultView.RowFilter = ""
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while filtering data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub refreshDataGrid()
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, contact, gender, age, emergContact, dentalH, date FROM patients"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("contact").ColumnName = "Contact"
                    dataTable.Columns("gender").ColumnName = "Gender"
                    dataTable.Columns("age").ColumnName = "Age"
                    dataTable.Columns("emergContact").ColumnName = "Emergency Contact"
                    dataTable.Columns("dentalH").ColumnName = "Dental History"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable

                    UpdateNumberOfPatientsLabel()

                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub




    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs)
        form1Instance = New Dashboard


        ' Hide the current form (Me)
        Hide()

        ' Show Form1
        form1Instance.Show()
    End Sub



    Private Sub dataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGrid.CellClick
        ' Check if a cell in the row headers was clicked
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow = dataGrid.Rows(e.RowIndex)

            ' Prompt the user to confirm if the reservation or treatment is done
            Dim result = MessageBox.Show("Is the reservation cancelled for this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Get the patient ID from the underlying DataTable bound to the DataGridView
                Dim rowView As DataRowView = CType(selectedRow.DataBoundItem, DataRowView)
                Dim patientID As Integer = Convert.ToInt32(rowView("ID"))


                ' Delete the selected row from the "patients" table
                DeleteRowFromPatientsTable(patientID)

                ' Move the row to the "patient_history" table
                MoveRowToPatientHistory(patientID, rowView("name").ToString(), rowView("address").ToString(), Convert.ToDateTime(rowView("date")))

                ' Remove the row from the DataGridView
                dataGrid.Rows.Remove(selectedRow)

                MessageBox.Show("Patient data moved to history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            ElseIf result = DialogResult.No Then
                Dim patientName As String = selectedRow.Cells("Name").Value.ToString()
                MsgBox("Proceed to Appointment booking.")
                Dim appointmentForm As New Appointment(patientName)
                appointmentForm.ShowDialog()


            End If
        End If
    End Sub

    Private Sub MoveRowToPatientHistory(patientID As Integer, name As String, address As String, date1 As Date)
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL INSERT INTO statement
            Dim sql As String = "INSERT INTO patient_history (name, address, date) VALUES (@name, @address, @date)"

            ' Set up command with parameters
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@date", date1)

                ' Execute the command to insert data into patient_history table
                cmd.ExecuteNonQuery()

                ' Now delete the row from patients table
                ' Construct SQL DELETE statement
                sql = "DELETE FROM patients WHERE ID = @patientID"

                ' Update command with parameters
                cmd.CommandText = sql
                cmd.Parameters.Clear() ' Clear previous parameters
                cmd.Parameters.AddWithValue("@patientID", patientID)

                ' Execute the command to delete the row from patients table
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error moving patient data to history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub

    Private Sub DeleteRowFromPatientsTable(patientID As Integer)
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL DELETE statement
            Dim sql As String = "DELETE FROM patients WHERE ID = @patientID"

            ' Set up command with parameters
            Using cmd As New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@patientID", patientID)
                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error deleting patient data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            con.Close()
        End Try
    End Sub

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint

    End Sub
End Class