Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sum As Integer = 0
        Dim message As String = ""
        For x = 1 To CInt(TextNum.Text)

            Dim data As Integer = CInt(InputBox("ป้อนข้อมูล"))
            Sum += data
            message += data & vbNewLine


        Next

        LabelINPUT.Text = message
        LabelSum.Text = Sum
        LabelAVG.Text = Sum / CInt(TextNum.Text)


    End Sub


End Class
