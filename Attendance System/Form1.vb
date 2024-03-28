Imports System.IO

Public Class Form1

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            ' Convert PictureBoxQR image to byte array '
            Dim qrImageData As Byte() = ImageToByteArray(PictureBoxQR.Image)

            ' Insert student record with QR image data '
            Create("INSERT INTO student(studentID, firstName, lastName, studentAge, stdntDepartment, qrImage) VALUES (@studentID, @firstName, @lastName, @studentAge, @stdntDepartment, @qrImageData)", qrImageData)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            ' Convert PictureBoxQR image to byte array '
            Dim qrImageData As Byte() = ImageToByteArray(PictureBoxQR.Image)

            ' Update student record with QR image data '
            Updates("UPDATE student SET firstName = @firstName, lastName = @lastName, studentAge = @studentAge, stdntDepartment = @stdntDepartment, qrImage = @qrImageData WHERE studentID = @studentID", qrImageData)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' Method to convert Image to byte array '
    Private Function ImageToByteArray(ByVal image As Image) As Byte()
        Dim stream As New MemoryStream()
        image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Return stream.ToArray()
    End Function
    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            Reload("SELECT * FROM student", studentList)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub StdntList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentList.CellContentClick
        stdntID.Text = studentList.CurrentRow.Cells(0).Value
        firstName.Text = studentList.CurrentRow.Cells(1).Value
        lastName.Text = studentList.CurrentRow.Cells(2).Value
        stdntAge.Text = studentList.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Delete("DELETE FROM student WHERE studentID='" & stdntID.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub New_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        stdntID.Text = ""
        firstName.Text = ""
        lastName.Text = ""
        stdntAge.Clear()

    End Sub

    Private Sub UploadQRImageButton_Click(sender As Object, e As EventArgs) Handles UploadQRImageButton.Click
        ' Open file dialog to select QR image file '
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*"
        openFileDialog.Title = "Select QR Image"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get selected image file path '
            Dim imagePath As String = openFileDialog.FileName

            ' Display selected image in PictureBox '
            PictureBoxQR.Image = Image.FromFile(imagePath)

            ' Optional: Save image path to database '
            ' You can save imagePath to your database along with other student information '
        End If
    End Sub
    Private Sub StdntList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentList.CellContentClick
        stdntID.Text = studentList.CurrentRow.Cells(0).Value
        firstName.Text = studentList.CurrentRow.Cells(1).Value
        lastName.Text = studentList.CurrentRow.Cells(2).Value
        stdntAge.Text = studentList.CurrentRow.Cells(3).Value

        ' Check if the retrieved data contains QR image data '
        If Not IsDBNull(studentList.CurrentRow.Cells("qrImage").Value) Then
            ' Convert byte array to Image and assign it to PictureBox '
            Dim qrImageData As Byte() = DirectCast(studentList.CurrentRow.Cells("qrImage").Value, Byte())
            Dim qrImage As Image = ByteArrayToImage(qrImageData)
            PictureBoxQR.Image = qrImage
        Else
            ' If no QR image data, clear the PictureBox '
            PictureBoxQR.Image = Nothing
        End If
    End Sub

    ' Method to convert byte array to Image '
    Private Function ByteArrayToImage(ByVal byteArray As Byte()) As Image
        Using stream As New MemoryStream(byteArray)
            Return Image.FromStream(stream)
        End Using
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub closeStudentCrudClick(sender As Object, e As EventArgs) Handles closeStdntInfo_btn.Click
        Me.Close()
    End Sub


End Class