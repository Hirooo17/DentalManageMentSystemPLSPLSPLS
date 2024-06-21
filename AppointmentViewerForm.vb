Imports MySql.Data.MySqlClient

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
    End Sub


    Public Sub RefreshDataGrid()
        Try
            ' Open the database connection
            openCon()
            ' MessageBox.Show("Database connection opened successfully.")

            ' Construct SQL SELECT statement with DATE_FORMAT
            Dim sql As String = "SELECT fullname, DATE_FORMAT(date, '%Y-%m-%d %H:%i:%s') AS formatted_date FROM appointment"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Check if reader has rows
                    If reader.HasRows Then
                        ' Create a DataTable to hold the data
                        Dim dataTable As New DataTable()

                        ' Load the data from the data reader into the DataTable
                        dataTable.Load(reader)
                        '  MessageBox.Show("Data loaded into DataTable successfully. Row count: " & dataTable.Rows.Count)

                        ' Rename the columns
                        dataTable.Columns("fullname").ColumnName = "Name"
                        dataTable.Columns("formatted_date").ColumnName = "Date"

                        ' Set the DataTable as the DataSource for the DataGridView
                        dataGridA.DataSource = dataTable
                        MessageBox.Show("DataTable set as DataSource for DataGridView.")
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
End Class