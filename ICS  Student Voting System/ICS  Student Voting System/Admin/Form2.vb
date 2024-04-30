Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatabaseConnection.dbconn()
    End Sub

    Sub Load_studentData()
        Guna2DataGridView1.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `table_student`", conn)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader


            While dr.Read
                Guna2DataGridView1.Rows.Add(Guna2DataGridView1.Rows.Count + 1, dr.Item("student_id"), dr.Item("name"), dr.Item("course"), dr.Item("year"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Guna2DataGridView1.Rows.Clear()

        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `table_student` WHERE student_id LIKE '%" & txt_search.Text & "%' OR Name LIKE '%" & txt_search.Text & "%' OR course LIKE '%" & txt_search.Text & "%' OR status LIKE '%" & txt_search.Text & "%'", conn)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                Guna2DataGridView1.Rows.Add(Guna2DataGridView1.Rows.Count + 1, dr.Item("student_id"), dr.Item("name"), dr.Item("course"), dr.Item("year"), dr.Item("status"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
    End Sub
End Class