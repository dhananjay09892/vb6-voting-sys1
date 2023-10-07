Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        If dune > coda And dune > licorice And dune > king And dune > power Then
            lblPic.Text = "Dune"
            lblVote.Text = dune
        ElseIf coda > dune And coda > licorice And coda > king And coda > power Then
            lblPic.Text = "Coda"
            lblVote.Text = coda
        ElseIf licorice > dune And licorice > coda And licorice > king And licorice > power Then
            lblPic.Text = "Licorice Pizza"
            lblVote.Text = licorice
        ElseIf king > dune And king > licorice And king > coda And king > power Then
            lblPic.Text = "King Richards"
            lblVote.Text = king
        ElseIf power > dune And power > licorice And power > king And power > coda Then
            lblPic.Text = "Power of the Dog"
            lblVote.Text = power
        Else
            lblPic.Text = "Something is wrong"
            lblVote.Text = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dune = 0
        coda = 0
        licorice = 0
        king = 0
        power = 0
        Me.Hide()
        Form1.Show()
    End Sub
End Class