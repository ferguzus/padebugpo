Imports MySql.Data.MySqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class form_manageUsers
    ' Other declarations...

    Private WithEvents FadeInTimer As New Timer()
    Private WithEvents FadeOutTimer As New Timer()

    Private originalSize As Size ' Store the original size of the button


    Private Sub form_manageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial opacity to 0 (fully transparent)
        Me.Opacity = 0

        ' Start the timer to fade in the form
        FadeInTimer.Start()

        ' Store the original size of the button when the form loads
        originalSize = btn_register.Size

        DatabaseConnection.dbconn()
    End Sub

    Private Sub FadeInTimer_Tick(sender As Object, e As EventArgs) Handles FadeInTimer.Tick
        ' Increase the opacity gradually (faster)
        If Me.Opacity < 1 Then
            Me.Opacity += 0.3 ' You can adjust the step size as needed
        Else
            ' Stop the timer once opacity reaches 1
            FadeInTimer.Stop()
        End If
    End Sub

    Private Sub pic_close_Click(sender As Object, e As EventArgs) Handles pic_close.Click
        ' Start the timer to fade out the form when closing
        FadeOutTimer.Start()
    End Sub

    Private Sub FadeOutTimer_Tick(sender As Object, e As EventArgs) Handles FadeOutTimer.Tick
        ' Decrease the opacity gradually (faster)
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.3 ' You can adjust the step size as needed
        Else
            ' Close the form once opacity reaches 0
            Me.Close()
        End If
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If


            ' Check if the username or name already exists in the database
            If UserOrNameExists(txt_username.Text, txt_name.Text) Then
                MsgBox("Username or Name already exists. Please choose a different username or name.", vbExclamation, "VOTE")
                Return ' Exit the method without attempting to insert into the database
            End If

            ' If username and name do not exist, proceed with the registration
            cmd = New MySqlCommand("INSERT INTO `table_user`(`name`,`username`,`password`,`role`) VALUES (@name,@username,@password,@role)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", txt_name.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@role", cmb_role.Text)

            Dim i As Integer = cmd.ExecuteNonQuery

            If i > 0 Then
                MsgBox("New User Register Success !", vbInformation, "VOTE")
            Else
                MsgBox("New User Register Failed !", vbExclamation, "VOTE")
            End If

            txt_name.Clear()
            txt_username.Clear()
            txt_password.Clear()
            cmb_role.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Function to check if a username or name already exists in the database
    Private Function UserOrNameExists(username As String, name As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM `table_user` WHERE `username` = @username OR `name` = @name"
        Using checkCmd As New MySqlCommand(query, conn)
            checkCmd.Parameters.AddWithValue("@username", username)
            checkCmd.Parameters.AddWithValue("@name", name)
            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function
End Class