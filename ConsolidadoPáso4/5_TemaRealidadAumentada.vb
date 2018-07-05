Public Class _5_TemaRealidadAumentada
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Menu
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(width:=140, height:=95)
        My.Computer.Audio.Play(My.Resources.abriendo_una_lata_de_cerveza, AudioPlayMode.Background)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(width:=121, height:=75)
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Size = New Size(width:=140, height:=95)
        My.Computer.Audio.Play(My.Resources.abriendo_una_lata_de_cerveza, AudioPlayMode.Background)
    End Sub
    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(width:=121, height:=75)
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Size = New Size(width:=140, height:=95)
        My.Computer.Audio.Play(My.Resources.abriendo_una_lata_de_cerveza, AudioPlayMode.Background)
    End Sub
    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(width:=121, height:=75)
    End Sub
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Size = New Size(width:=140, height:=95)
        My.Computer.Audio.Play(My.Resources.abriendo_una_lata_de_cerveza, AudioPlayMode.Background)
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(width:=121, height:=75)
    End Sub

End Class