Imports ZXing
Imports ZXing.QrCode
Imports System.Drawing.Imaging

Public Class CreateQRCode

    Private Sub GenerateQRCodeButton_Click(sender As Object, e As EventArgs) Handles GenerateQRCodeButton.Click
        ' Get input data from textboxes
        Dim firstName As String = FirstNameTextBox.Text
        Dim lastName As String = LastNameTextBox.Text
        Dim idNumber As String = IDNumberTextBox.Text

        ' Generate QR code bitmap
        Dim qrCodeBitmap As Bitmap = GenerateQRCode(firstName, lastName, idNumber)

        ' Display the generated QR code in PictureBox
        QRCodePictureBox.Image = qrCodeBitmap
    End Sub

    Private Function GenerateQRCode(firstName As String, lastName As String, idNumber As String) As Bitmap
        ' Concatenate input data to form the text for the QR code
        Dim qrText As String = $"First Name: {firstName}, Last Name: {lastName}, ID Number: {idNumber}"

        ' Set up QR code writer
        Dim barcodeWriter As New BarcodeWriter()
        barcodeWriter.Format = BarcodeFormat.QR_CODE
        barcodeWriter.Options = New QrCodeEncodingOptions() With {.DisableECI = True, .CharacterSet = "UTF-8", .Width = 300, .Height = 300}

        ' Generate QR code bitmap
        Dim qrCodeBitmap As Bitmap = barcodeWriter.Write(qrText)

        Return qrCodeBitmap
    End Function

    Private Sub SaveQRCodeButton_Click(sender As Object, e As EventArgs) Handles SaveQRCodeButton.Click
        ' Check if a QR code is generated
        If QRCodePictureBox.Image IsNot Nothing Then
            ' Display SaveFileDialog to select save location
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "PNG files (*.png)|*.png"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.RestoreDirectory = True

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Save the QR code bitmap to the selected location
                    Try
                        QRCodePictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png)
                        MessageBox.Show("QR code saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Error saving QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End Using
        Else
            MessageBox.Show("Please generate a QR code first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub closeQRCreation_btn_Click(sender As Object, e As EventArgs) Handles closeQRCreation_btn.Click
        Me.Close()
    End Sub
End Class
