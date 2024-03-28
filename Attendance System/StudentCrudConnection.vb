Imports MySql.Data.MySqlClient
Imports System.IO
Module StudentCrudConnection
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server = localhost;user id = root;password=;database=studentcrud")
    End Function
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub Create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN SAVED IN THE DATABASE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    'Method for retrieving data in the database'

    Public Sub Reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable()
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    'Method for updating records'

    Public Sub Updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO UPDATE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    'Method for deleting record'

    Public Sub Delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO DELETE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN DELETED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub UploadQRImage(ByVal studentID As String, ByVal imagePath As String)
        Try
            Dim imageBytes As Byte() = File.ReadAllBytes(imagePath)
            strcon.Open()
            Dim sql As String = "UPDATE student SET QRImage = @QRImage WHERE studentID = @StudentID"
            cmd.CommandText = sql
            cmd.Connection = strcon
            cmd.Parameters.AddWithValue("@QRImage", imageBytes)
            cmd.Parameters.AddWithValue("@StudentID", studentID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("QR Image uploaded successfully.")
        Catch ex As Exception
            MessageBox.Show("Error uploading QR Image: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

End Module
