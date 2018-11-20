Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As Integer = CInt(TextBox1.Text)
        Dim last As Integer = CInt(TextBox2.Text)
        Dim steps As Integer = CInt(TextBox3.Text)
        Dim message As String = ""

        If steps > 0 Then

            If first < last Then

                For x = first To last Step steps
                    message += x & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้นต้องน้อยกว่าสิ้นสุด")
            End If

        ElseIf steps < 0 Then
            If last < first Then

                For x = first To last Step steps
                    message += x & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้นต้องมากกว่าสิ้นสุด")
            End If
        Else
            MessageBox.Show("เลขเพิ่มลดต้องไม่เท่ากับ 0")
        End If



    End Sub

End Class
