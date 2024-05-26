Imports MySql.Data.MySqlClient
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
        Load_employerData()
        Load_traineeData()
        Load_applicationData()


        ' Make the data grid view scrollable
        Guna2DataGridView1.ScrollBars = ScrollBars.Both
        Guna2DataGridView2.ScrollBars = ScrollBars.Both
        Guna2DataGridView3.ScrollBars = ScrollBars.Both

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

    Sub Load_employerData()
        Guna2DataGridView2.Rows.Clear()

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Query to select company_id, name, and email from activated_employer table
                Using cmd As New MySqlCommand("SELECT `Company_ID`, `name`, `email` FROM `activated_employer`", conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Guna2DataGridView2.Rows.Add(dr.Item("Company_ID"), dr.Item("name"), dr.Item("email"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Load_traineeData()
        Guna2DataGridView3.Rows.Clear()

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                ' Query to select company_id, name, and email from activated_employer table
                Using cmd As New MySqlCommand("SELECT `id`, `name`, `email` FROM `activated_student`", conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Guna2DataGridView3.Rows.Add(dr.Item("id"), dr.Item("name"), dr.Item("email"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub Load_applicationData()
        Guna2DataGridView4.Rows.Clear()

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=cdm-internship-database")
                conn.Open()

                Using cmd As New MySqlCommand("SELECT `internship_ID`, `student_name`, `student_email`, `student_course`, `title`, `company_name` FROM `application_internship`", conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Guna2DataGridView4.Rows.Add(dr.Item("internship_ID"), dr.Item("student_name"), dr.Item("student_email"), dr.Item("student_course"), dr.Item("title"), dr.Item("company_name"))
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
End Class
