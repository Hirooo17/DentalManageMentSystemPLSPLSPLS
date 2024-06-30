Imports DocumentFormat.OpenXml.Office2010.Excel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class AppointmentViewerForm




    Private Shared instance As AppointmentViewerForm

    Public Shared Function GetInstance() As AppointmentViewerForm
        If instance Is Nothing OrElse instance.IsDisposed Then
            instance = New AppointmentViewerForm()
        End If
        Return instance
    End Function
    Private Sub AppointmentViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGrid()
        loadName()
    End Sub


    Public Sub RefreshDataGrid()
        Try

            openCon()



            Dim sql As String = "SELECT ID, fullname, status, DATE_FORMAT(date, '%Y-%m-%d %H:%i:%s') AS formatted_date FROM appointment"


            Using cmd As New MySqlCommand(sql, con)

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then

                        Dim dataTable As New DataTable()


                        dataTable.Load(reader)

                        dataTable.Columns("ID").ColumnName = "Number"
                        dataTable.Columns("fullname").ColumnName = "Name"
                        dataTable.Columns("formatted_date").ColumnName = "Date"
                        dataTable.Columns("status").ColumnName = "Status"


                        dataGridA.DataSource = dataTable

                    Else
                        MessageBox.Show("No data found.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error loading data from database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' Close the database connection
            con.Close()
            'MessageBox.Show("Database connection closed.")
        End Try
    End Sub


    Private Sub loadName()
        Try
            openCon()

            Dim query As String = "SELECT fullname FROM appointment"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read
                cBId.Items.Add(reader("fullname").ToString)

            End While

            reader.Close()
            closeCon()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


    End Sub





    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RefreshDataGrid()
        MsgBox("Status Updated!")
    End Sub



    Private Sub updateGrid(fullname As String, status As String)

        Try
            ' Open the connection
            openCon()

            ' Create the SQL Update command
            Dim query As String = "UPDATE appointment SET status = @status WHERE fullname = @fullname"
            Dim command As New MySqlCommand(query, con)

            command.Parameters.AddWithValue("@fullname", fullname)
            command.Parameters.AddWithValue("@status", status)
            command.ExecuteNonQuery()

            MessageBox.Show("Appointment status updated successfully")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            closeCon()
        End Try


    End Sub

    Private Sub cBId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBId.SelectedIndexChanged
        patientTxt.Text = cBId.SelectedItem.ToString

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            ' Check if both ComboBoxes have selections
            If cBId.SelectedItem IsNot Nothing AndAlso cbStatus.SelectedItem IsNot Nothing Then
                ' Convert selected item to appropriate types
                Dim fullname As String = cBId.SelectedItem.ToString
                Dim status As String = cbStatus.SelectedItem.ToString()

                ' Update the grid with the selected ID and status
                updateGrid(fullname, status)

                ' Display selected patient ID in patientTxt if needed

            Else
                MessageBox.Show("Please select both fullname and status.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try


        RefreshDataGrid()
    End Sub
End Class