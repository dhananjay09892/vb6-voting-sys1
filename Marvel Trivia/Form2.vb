Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Activated
        rdoDune.Checked = False
        rdoCoda.Checked = False
        rdoKing.Checked = False
        rdoLicorice.Checked = False
        rdoPower.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rdoDune.Checked Then
            dune = dune + 1
        ElseIf rdoCoda.Checked Then
            coda = coda + 1
        ElseIf rdoKing.Checked Then
            king = king + 1
        ElseIf rdoLicorice.Checked Then
            licorice = licorice + 1
        ElseIf rdoPower.Checked Then
            power = power + 1
        Else
            MessageBox.Show("Nothinf Checked", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dune = 0 And coda = 0 And king = 0 And licorice = 0 And power = 0 Then
            MessageBox.Show("Vote At least for One", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Hide()
            Form3.Show()
        End If
    End Sub
End Class