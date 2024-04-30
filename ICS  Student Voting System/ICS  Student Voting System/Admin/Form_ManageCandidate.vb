Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_ManageCandidate
    Private isMouseOver As Boolean = False
    Private isImageSelected As Boolean = False ' Track whether the image is selected

    Private Sub form_ManageCandidates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.dbconn()
    End Sub

    Private Sub pic_close_Click(sender As Object, e As EventArgs) Handles pic_close.Click
        Me.Close()
    End Sub

    Private Sub pic_candidateImg_Click(sender As Object, e As EventArgs) Handles pic_candidateImg.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pic_candidateImg.Image = Image.FromFile(pop.FileName)
            isImageSelected = True ' Set the flag to indicate the image is selected
        End If
    End Sub

    Sub clear()
        txt_name.Clear()
        cmb_course.SelectedIndex = -1
        cmb_year.SelectedIndex = -1
        cmb_position.SelectedIndex = -1
        pic_candidateImg.Image = Nothing
        isImageSelected = False ' Reset the flag when clearing the form
    End Sub

    Private Sub pic_candidateImg_MouseEnter(sender As Object, e As EventArgs) Handles pic_candidateImg.MouseEnter
        If pic_candidateImg.Image Is Nothing Then
            isMouseOver = True
            pic_candidateImg.Invalidate() ' Trigger the Paint event to update the shadow
        End If
    End Sub

    Private Sub pic_candidateImg_MouseLeave(sender As Object, e As EventArgs) Handles pic_candidateImg.MouseLeave
        If pic_candidateImg.Image Is Nothing Then
            isMouseOver = False
            pic_candidateImg.Invalidate() ' Trigger the Paint event to update the shadow
        End If
    End Sub

    Private Sub pic_candidateImg_Paint(sender As Object, e As PaintEventArgs) Handles pic_candidateImg.Paint
        ' Draw the image with 50% opacity when the mouse is over the picture box and the image is not selected
        If isMouseOver And Not isImageSelected Then
            Dim imagePath As String = "C:\Users\Ferg\Desktop\ICS ICONS\bussiness-man.png"
            If File.Exists(imagePath) Then
                Using image As Image = Image.FromFile(imagePath)
                    ' Create an ImageAttributes object to adjust the opacity
                    Using imageAttributes As New Imaging.ImageAttributes()
                        ' Set the opacity to 50%
                        Dim transparency As Single = 0.5F
                        Dim colorMatrix As New Imaging.ColorMatrix()
                        colorMatrix.Matrix33 = transparency
                        imageAttributes.SetColorMatrix(colorMatrix, Imaging.ColorMatrixFlag.Default, Imaging.ColorAdjustType.Bitmap)

                        ' Draw the image with adjusted opacity
                        e.Graphics.DrawImage(image, New Rectangle(0, 0, pic_candidateImg.Width, pic_candidateImg.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes)
                    End Using
                End Using
            End If
        Else
            ' Draw the original image without any modifications
            Dim selectedImage As Image = pic_candidateImg.Image
            If selectedImage IsNot Nothing Then
                e.Graphics.DrawImage(selectedImage, New Rectangle(0, 0, pic_candidateImg.Width, pic_candidateImg.Height))
            End If
        End If
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Try
            ' Check if the connection is closed before opening
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If

            ' Create the MySqlCommand
            cmd = New MySqlCommand("INSERT INTO `table_candidate`(`name`, `course`, `year`, `position`, `image`) VALUES (@name,@course,@year,@position,@image)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@course", cmb_course.Text)
            cmd.Parameters.AddWithValue("@year", cmb_year.Text)
            cmd.Parameters.AddWithValue("@position", cmb_position.Text)

            ' Convert the image to bytes
            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            pic_candidateImg.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.ToArray() ' Use ToArray instead of GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@image", picture).MySqlDbType = MySqlDbType.Blob ' Specify MySqlDbType


            ' Execute the query
            Dim i As Integer = cmd.ExecuteNonQuery

            ' Check the result
            If i > 0 Then
                MsgBox("Candidate Register Success!", vbInformation, "VOTE")
            Else
                MsgBox("Candidate Register Failed!", vbExclamation, "VOTE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ' Close the connection in the finally block to ensure it is closed even if an exception occurs
            conn.Close()
        End Try

        ' Clear the form
        clear()
    End Sub
End Class
