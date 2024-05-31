Imports MySql.Data.MySqlClient

Public Class Patient_history
    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint
        Dim hero As String
        hero = "hi"
    End Sub



    Private Sub updateGrid()


        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, date FROM patient_history"

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
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable



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
    Private form1Instance As Dashboard
    Private Sub Guna2ImageButton5_Click(sender As Object, e As EventArgs)
        form1Instance = New Dashboard


        ' Hide the current form (Me)
        Hide()

        ' Show Form1
        form1Instance.Show()
    End Sub

    Private Sub Patient_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, date FROM patient_history"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("ID").ColumnName = "No."
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable



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

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            ' Open the database connection
            openCon()

            ' Construct SQL SELECT statement
            Dim sql As String = "SELECT ID, name, address, date FROM patient_history"

            ' Set up command
            Using cmd As New MySqlCommand(sql, con)
                ' Execute the command and get a data reader
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Create a DataTable to hold the data
                    Dim dataTable As New DataTable()

                    ' Load the data from the data reader into the DataTable
                    dataTable.Load(reader)

                    ' Rename the columns
                    dataTable.Columns("ID").ColumnName = "No."
                    dataTable.Columns("name").ColumnName = "Name"
                    dataTable.Columns("address").ColumnName = "Address"
                    dataTable.Columns("date").ColumnName = "Date"

                    ' Set the DataTable as the DataSource for the DataGridView
                    dataGrid.DataSource = dataTable



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
End Class