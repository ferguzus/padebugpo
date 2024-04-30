Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form_VoteCandidate
    ' Define a structure or class to hold candidate information
    Private Structure CandidateInfo
        Public Name As String
        Public Image As Byte() ' Change ImagePath to Image
    End Structure

    ' Example candidate information
    Private PresidentCandidates As List(Of CandidateInfo) = New List(Of CandidateInfo)()
    Private VicePresidentCandidates As List(Of CandidateInfo) = New List(Of CandidateInfo)()
    Private SecretaryCandidates As List(Of CandidateInfo) = New List(Of CandidateInfo)()
    Private TreasurerCandidates As List(Of CandidateInfo) = New List(Of CandidateInfo)()

    ' Set your database connection details
    Private ConnectionString As String = "Server=localhost;Database=election_database;User=root;Password=2474;"
    Private conn As New MySqlConnection(ConnectionString)

    Private Sub Form_VoteCandidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load candidate information from the database or any other source
        LoadCandidates()

        ' Populate FlowLayoutPanels with candidate information
        PopulateCandidates(FlowLayoutPresident, PresidentCandidates)
        PopulateCandidates(FlowLayoutVicePresident, VicePresidentCandidates)
        PopulateCandidates(FlowLayoutSecretary, SecretaryCandidates)
        PopulateCandidates(FlowLayoutTreasurer, TreasurerCandidates)
    End Sub

    ' Function to load candidate information from the database
    Private Sub LoadCandidates()
        Try
            ' Open the database connection
            conn.Open()

            ' Example SQL query to retrieve candidate information for each position
            Dim sql As String = "SELECT `name`, `image` FROM table_candidate WHERE `position` = @position"

            ' Load President candidates
            LoadCandidatesForPosition("President", PresidentCandidates, sql)

            ' Load Vice-President candidates
            LoadCandidatesForPosition("Vice President", VicePresidentCandidates, sql)

            ' Load Secretary candidates
            LoadCandidatesForPosition("Secretary", SecretaryCandidates, sql)

            ' Load Treasurer candidates
            LoadCandidatesForPosition("Treasurer", TreasurerCandidates, sql)

            ' Close the connection
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' Function to load candidates for a specific position
    Private Sub LoadCandidatesForPosition(position As String, candidatesList As List(Of CandidateInfo), sql As String)
        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@position", position)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim candidate As New CandidateInfo()
                    candidate.Name = reader("name").ToString()
                    candidate.Image = DirectCast(reader("image"), Byte())
                    candidatesList.Add(candidate)
                End While
            End Using
        End Using
    End Sub

    ' Function to populate FlowLayoutPanel with candidate information
    Private Sub PopulateCandidates(flowLayoutPanel As FlowLayoutPanel, candidates As List(Of CandidateInfo))
        ' Clear existing controls in the FlowLayoutPanel
        flowLayoutPanel.Controls.Clear()

        ' Loop through each candidate and create PictureBox and Label controls
        For Each candidate In candidates
            ' Create a Panel to hold both PictureBox and Name Label
            Dim panel As New Panel()
            panel.Width = 120 ' Adjust the width as needed
            panel.Height = 170 ' Adjust the height as needed

            ' Create PictureBox
            Dim pictureBox As New PictureBox()
            pictureBox.Width = panel.Width - 20 ' Adjust the width as needed
            pictureBox.Height = panel.Height - 30 ' Adjust the height as needed
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom ' Maintain aspect ratio

            ' Convert byte array to Image using MemoryStream
            Using ms As New MemoryStream(candidate.Image)
                pictureBox.Image = Image.FromStream(ms)
            End Using

            ' Create Label for name
            Dim nameLabel As New Label()
            nameLabel.Text = candidate.Name
            nameLabel.TextAlign = ContentAlignment.TopCenter
            nameLabel.Dock = DockStyle.Top

            ' Add PictureBox and Name Label to the Panel
            panel.Controls.Add(nameLabel)
            panel.Controls.Add(pictureBox)

            ' Add the Panel to the FlowLayoutPanel
            flowLayoutPanel.Controls.Add(panel)
        Next
    End Sub



End Class
