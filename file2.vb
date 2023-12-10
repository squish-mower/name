' MainForm.vb
Public Class MainForm
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        DisplayGreeting()
    End Sub

    Private Sub DisplayGreeting()
        Dim userName As String = txtName.Text.Trim()

        If Not String.IsNullOrEmpty(userName) Then
            MessageBox.Show($"Hello, {userName}! Welcome to ???.", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Please enter your name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
