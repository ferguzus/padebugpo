Public Class form_adminMain
    Private Sub form_adminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ManageUser_Click(sender As Object, e As EventArgs) Handles btn_ManageUser.Click
        form_manageUsers.ShowDialog()

    End Sub

    Private Sub btn_ManageCandidates_Click(sender As Object, e As EventArgs) Handles btn_ManageCandidates.Click
        With Form_ManageCandidate
            .TopLevel = False
            Guna2Panel1.Controls.Add(Form_ManageCandidate)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_ManageStudent_Click(sender As Object, e As EventArgs) Handles btn_ManageStudent.Click
        With form_ManageStudent
            .TopLevel = False
            Guna2Panel1.Controls.Add(form_ManageStudent)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btn_result_Click(sender As Object, e As EventArgs) Handles btn_result.Click

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class