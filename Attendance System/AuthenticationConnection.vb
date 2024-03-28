Imports MySql.Data.MySqlClient

Module AuthenticationConnection

    Public Function AuthenticateUser(ByVal username As String, ByVal password As String) As Boolean
        Dim isAuthenticated As Boolean = False

        ' Your database connection code '
        Dim connectionString As String = "server=localhost;user id=root;database=userauthentication"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password_hash = @password"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    isAuthenticated = count > 0
                End Using
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return isAuthenticated
    End Function
    Public Function RegisterUser(ByVal username As String, ByVal password As String, ByVal qrImageBytes As Byte()) As Boolean
        Dim isRegistered As Boolean = False


        Dim connectionString As String = "server=localhost;user id=root;database=userauthentication"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO users (username, password_hash, qr_image) VALUES (@username, @password, @qrImage)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@qrImage", qrImageBytes)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    isRegistered = result > 0
                End Using
            Catch ex As MySqlException
                MessageBox.Show("MySQL Error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return isRegistered
    End Function

End Module
