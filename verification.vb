Imports MySql.Data.MySqlClient

Public Class verification



    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub


    Private _verificationCode As String
    Private _username As String
    Private _password As String

    Public Property VerificationCode As String
        Get
            Return _verificationCode
        End Get
        Set(value As String)
            _verificationCode = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Private Sub checkVerificationCode()
        Dim enterCode As String = verify.Text
        If enterCode.Equals(VerificationCode, StringComparison.OrdinalIgnoreCase) Then
            MsgBox("Email verification succeeded!")

            ' Insert the data into the database
            Try
                ' Open the connection
                openCon()

                ' Prepare the SQL command
                Dim query As String = "INSERT INTO patient_account (username, password) VALUES (@username, @password)"
                Using cmd As New MySqlCommand(query, con)
                    ' Add the parameters to the SQL command
                    cmd.Parameters.AddWithValue("@username", Username)
                    cmd.Parameters.AddWithValue("@password", Password)

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using

                ' Show a success message
                MessageBox.Show("The username and password have been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Show an error message
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close the connection
                closeCon()
            End Try

            Me.Hide()
            PatientLogForm.Show()
        Else
            MsgBox("Email verification failed! Please try again!")
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        checkVerificationCode()
    End Sub

    Private Sub verification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
