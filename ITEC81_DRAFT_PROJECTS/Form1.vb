Imports System.Collections.Specialized.BitVector32
Imports System.Data.OleDb ' Add this at the very top of Form1.vb

Public Class Form1

    ' CONNECTION STRING: Change this path to where your actual database file is!
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\verwi\source\repos\ITEC81_DRAFT_PROJECTS\ITEC81_DRAFT_PROJECTS\Assets\ITHelpDeskDB.accdb;"

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim user As String = username_tb.Text
        Dim pass As String = password_tb.Text

        ' 1. Basic Validation
        If String.IsNullOrEmpty(user) Or String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Please enter both username and password.")
            Exit Sub
        End If

        ' 2. Database Query
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                ' We select the Role and ID as well, not just count the rows
                Dim sql As String = "SELECT UserID, Role FROM tblUsers WHERE Username = @u AND Password = @p"

                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", user)
                    cmd.Parameters.AddWithValue("@p", pass)

                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.Read() Then
                        ' --- LOGIN SUCCESS! ---

                        ' 3. STORE THE ROLE (This is the RBAC magic)
                        Session.CurrentUserID = reader("UserID")
                        Session.CurrentUserRole = reader("Role").ToString() ' e.g., "Student" or "Admin"
                        Session.CurrentUserName = user

                        MessageBox.Show("Welcome, " & user & "! You are logged in as: " & Session.CurrentUserRole)

                        ' 4. OPEN THE DASHBOARD
                        Me.Hide()
                        Dim dash As New DashboardForm()
                        dash.ShowDialog()
                        Me.Close()
                    Else
                        ' --- LOGIN FAILED ---
                        MessageBox.Show("Invalid Credentials. Please try again.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class