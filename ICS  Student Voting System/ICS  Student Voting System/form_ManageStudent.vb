﻿Imports MySql.Data.MySqlClient
Imports System.IO

Public Class form_ManageStudent

    'ADDED NEW START HERE' txt_name

    Private WithEvents FadeInTimer As New Timer()
    Private WithEvents FadeOutTimer As New Timer()

    ' Specify the full paths to your images
    Private hoverImagePath As String = "C:\Users\Ferg\Desktop\ICS  Student Voting System\remove.png"
    Private originalImagePath As String = "C:\Users\Ferg\Desktop\ICS ICONS\remove.png"

    Private Sub form_ManageStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.dbconn()
        ' Auto_studentID()
        Load_studentData()

        ' Make the data grid view scrollable
        Guna2DataGridView1.ScrollBars = ScrollBars.Both

        ' Add buttons to the DataGridView
        Dim btnApprove As New DataGridViewButtonColumn()
        btnApprove.HeaderText = "Approve"
        btnApprove.Name = "btnApprove"
        btnApprove.Text = "Approve"
        btnApprove.UseColumnTextForButtonValue = True

        Dim btnDecline As New DataGridViewButtonColumn()
        btnDecline.HeaderText = "Decline"
        btnDecline.Name = "btnDecline"
        btnDecline.Text = "Decline"
        btnDecline.UseColumnTextForButtonValue = True

        Guna2DataGridView1.Columns.Add(btnApprove)
        Guna2DataGridView1.Columns.Add(btnDecline)
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

    'END HERE'

    Sub Load_studentData()
        Guna2DataGridView1.Rows.Clear()

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Join the internship table with the activated_employer table to get the employer's name and location
                Using cmd As New MySqlCommand("SELECT i.`internship_ID`, i.`Title`, i.`Description`, i.`Requirements`, i.`Duration`, i.`Status`, e.`name` AS EmployerName, e.`Location` FROM `internship` i JOIN `activated_employer` e ON i.Company_ID = e.Company_ID", conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read
                            Guna2DataGridView1.Rows.Add(Guna2DataGridView1.Rows.Count + 1, dr.Item("internship_ID"), dr.Item("EmployerName"), dr.Item("Title"), dr.Item("Description"), dr.Item("Requirements"), dr.Item("Location"), dr.Item("Duration"), dr.Item("Status"), "Approve", "Decline")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Guna2DataGridView1.Rows.Clear()

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                Dim searchQuery As String = "SELECT i.`internship_ID`, i.`Title`, i.`Description`, i.`Requirements`, i.`Duration`, i.`Status`, e.`name` AS EmployerName, e.`Location` " &
                                        "FROM `internship` i " &
                                        "JOIN `activated_employer` e ON i.Company_ID = e.Company_ID " &
                                        "WHERE i.`Title` LIKE @searchTerm OR e.`name` LIKE @searchTerm OR i.`Description` LIKE @searchTerm OR e.`Location` LIKE @searchTerm"

                Using cmd As New MySqlCommand(searchQuery, conn)
                    cmd.Parameters.AddWithValue("@searchTerm", "%" & txt_search.Text & "%")
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Guna2DataGridView1.Rows.Add(Guna2DataGridView1.Rows.Count + 1, dr.Item("internship_ID"), dr.Item("EmployerName"), dr.Item("Title"), dr.Item("Description"), dr.Item("Requirements"), dr.Item("Duration"), dr.Item("Status"), dr.Item("EmployerName"), dr.Item("Location"), "Approve", "Decline")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub clear()
        password_employer.Clear()
    End Sub

    'Sub Auto_studentID()
    'Dim dr As MySqlDataReader

    'Try
    'Using co'nn As New MySqlConnection("server=localhost;user=root;password=2474;database=election_database")
    'conn.Open()

    'cmd = New MySqlCommand("SELECT * FROM `table_student` ORDER BY id DESC", conn)
    'dr = cmd.ExecuteReader()
    'dr.Read()

    'If dr.HasRows Then
    'txt_name.Text = (Convert.ToInt32(dr.Item("student_id")) + 1).ToString()
    'Else
    'txt_name.Text = Date.Now.ToString("yyyy") & "001"
    'End If'
    'End Using
    'Catch ex As Exception
    'MsgBox(ex.Message)
    'End Try
    'End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Hash the password
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password_employer.Text)

                ' Prepare the SQL command with the active field
                cmd = New MySqlCommand("INSERT INTO `activated_employer`(`name`,`email`, `password`, `active`) VALUES (@Name, @Email, @Password, @Active)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Name", name_employer.Text)
                cmd.Parameters.AddWithValue("@Email", name_employer.Text)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Active", 1)
                i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Employer Register Success!", vbInformation, "REGISTER")
                Else
                    MsgBox("Employer Register Failed!", vbCritical, "REGISTER")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        clear()
        Load_studentData()
    End Sub

    Private Sub btn_student_Click(sender As Object, e As EventArgs) Handles btn_student.Click
        Dim i As Integer
        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Hash the password
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password_student.Text)

                ' Prepare the SQL command with the active field
                cmd = New MySqlCommand("INSERT INTO `activated_student`(`name`,`email`, `password`, `active`) VALUES (@Name, @Email, @Password, @Active)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Name", name_student.Text)
                cmd.Parameters.AddWithValue("@Email", name_student.Text)
                cmd.Parameters.AddWithValue("@Password", hashedPassword)
                cmd.Parameters.AddWithValue("@Active", 1)
                i = cmd.ExecuteNonQuery()

                If i > 0 Then
                    MsgBox("Employer Register Success!", vbInformation, "REGISTER")
                Else
                    MsgBox("Employer Register Failed!", vbCritical, "REGISTER")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        clear()
        Load_studentData()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        If e.ColumnIndex = Guna2DataGridView1.Columns("btnApprove").Index Then
            ' Approve button clicked
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim internshipID As Integer = Convert.ToInt32(selectedRow.Cells("internship_ID").Value)
            Dim employerName As String = selectedRow.Cells("EmployerName").Value.ToString()
            Dim location As String = selectedRow.Cells("Location").Value.ToString()
            UpdateInternshipStatus(internshipID, "Posted", employerName, location)
        ElseIf e.ColumnIndex = Guna2DataGridView1.Columns("btnDecline").Index Then
            ' Decline button clicked
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim internshipID As Integer = Convert.ToInt32(selectedRow.Cells("internship_ID").Value)
            Dim employerName As String = selectedRow.Cells("EmployerName").Value.ToString()
            Dim location As String = selectedRow.Cells("Location").Value.ToString()
            UpdateInternshipStatus(internshipID, "Declined", employerName, location)
        End If
    End Sub


    Private Sub UpdateInternshipStatus(internshipID As Integer, newStatus As String, employerName As String, location As String)
        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                Using cmd As New MySqlCommand("UPDATE `internship` SET `Status` = @Status WHERE `internship_ID` = @internship_ID", conn)
                    cmd.Parameters.AddWithValue("@Status", newStatus)
                    cmd.Parameters.AddWithValue("@internship_ID", internshipID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Status updated to: " & newStatus & vbCrLf & "Employer: " & employerName & vbCrLf & "Location: " & location)
            Load_studentData() ' Refresh the data grid view
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Load_studentData()
    End Sub


End Class
