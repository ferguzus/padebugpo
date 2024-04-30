Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form_StudentMain
    Dim da As MySqlDataAdapter
    Dim dt As DataTable


    Private Sub Form_StudentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.dbconn()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub btn_StudentLogin_Click(sender As Object, e As EventArgs) Handles btn_StudentLogin.Click
        If txt_studentID.Text = String.Empty Then
            label_info.Text = "Please Fill Student ID ! "
            label_info.ForeColor = Color.Orange
            Return
        End If

        Try
            Using conn As New MySqlConnection("server=localhost;user=root;password=2474;database=election_database")
                conn.Open()


                ' Check if the student exists
                Using cmd As New MySqlCommand("SELECT * FROM `table_student` WHERE `student_id`=@student_id", conn)
                    cmd.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                    Using da As New MySqlDataAdapter(cmd)
                        Using dt As New DataTable()
                            da.Fill(dt)

                            If dt.Rows.Count > 0 Then
                                ' Check if the student has not voted
                                cmd.CommandText = "SELECT * FROM `table_student` WHERE `student_id`=@student_id AND `status`=@status"
                                cmd.Parameters.Clear()
                                cmd.Parameters.AddWithValue("@student_id", txt_studentID.Text)
                                cmd.Parameters.AddWithValue("@status", "UN-VOTED")

                                dt.Clear()
                                da.Fill(dt)

                                If dt.Rows.Count > 0 Then
                                    With Form_VoteCandidate
                                        .TopLevel = False
                                        Guna2Panel1.Controls.Add(Form_VoteCandidate)
                                        .BringToFront()
                                        .Show()

                                    End With


                                Else
                                    label_info.Text = "Already Voted ! "
                                    label_info.ForeColor = Color.Orange
                                End If
                            Else
                                label_info.Text = "Student Not Found ! "
                                label_info.ForeColor = Color.Red
                            End If
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class