Imports MySql.Data.MySqlClient
Module Connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public datatbl As New DataTable


    Sub openCon()
        Try
            If con.ConnectionString = "" Then
                con.ConnectionString = "server=localhost;username=root;password=;database=dental_user"
            End If

            ' Connection open
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If
        Catch ex As Exception
            ' Handle database connection error
            MsgBox("Database connection failed: " & ex.Message, MsgBoxStyle.Critical, "Connection Error")
        End Try
    End Sub

    Sub closeCon()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        Catch ex As Exception
            MsgBox("Database disconnection failed: " & ex.Message, MsgBoxStyle.Critical, "Disconnection Error")
        End Try
    End Sub

End Module
