Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim score As Double = CDbl(TextBox1.Text)
        If score < 0 Or score > 100 Then
            MessageBox.Show("Score Is Out Of Range ...", "Score", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf score > 79 Then
            Label1.Text = "A"
        ElseIf score > 69 Then
            Label1.Text = "B"
        ElseIf score > 59 Then
            Label1.Text = "C"
        ElseIf score > 49 Then
            Label1.Text = "D"
        Else
            Label1.Text = "F"
        End If


    End Sub

End Class
