Public Class TemaScracth
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Menu
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "D:\Users\Daniel\Downloads\New folder (1)\New folder\Audios_videos\DanielLopez\Videos\Scratch.mp4"
    End Sub

    Private Sub AxWindowsMediaPlayer2_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer2.Enter
        AxWindowsMediaPlayer2.URL = "D:\Users\Daniel\Downloads\New folder (1)\New folder\Audios_videos\DanielLopez\Audios\Sc_Audio1.m4a"
    End Sub

    Private Sub AxWindowsMediaPlayer3_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer3.Enter
        AxWindowsMediaPlayer3.URL = "D:\Users\Daniel\Downloads\New folder (1)\New folder\Audios_videos\DanielLopez\Audios\Sc_Audio2.m4a"
    End Sub
End Class