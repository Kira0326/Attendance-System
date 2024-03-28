Imports MySql.Data.MySqlClient
Module LoginModule

        Public Function AuthenticateUser(ByVal username As String, ByVal password As String) As Boolean
            Dim isAuthenticated As Boolean = False

            ' Your database connection code to verify username and password '
            Try
                Using connection As MySqlConnection = strconnection()
                    connection.Open()
                    Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@username", username)
                        cmd.Parameters.AddWithValue("@password", password)
                        Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                        isAuthenticated = count > 0
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Return isAuthenticated
        End Function


    End Module
