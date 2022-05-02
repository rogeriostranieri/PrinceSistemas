Public Class FrmTeste

    Private Sub Show_DTP(target As TextBox)

        Dim rect As Rectangle = target.DisplayRectangle()
        Dim x As Integer = rect.X + target.Left
        Dim y As Integer = rect.Y + target.Top
        Dim width = rect.Width + 4
        Dim height = rect.Height

        With MyDTP
            .SetBounds(x, y, width, height)
            .Visible = True
            .Focus()
        End With

    End Sub

    Private Sub Text_Click(sender As Object, e As EventArgs) Handles TxtTest.Click, Txt2.Click
        Dim Txt As System.Windows.Forms.TextBox = DirectCast(sender, TextBox)
        MyDTP.Visible = False
        Show_DTP(Txt)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyDTP.Visible = False

    End Sub


End Class