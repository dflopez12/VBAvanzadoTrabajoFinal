Public Class Menu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Dim a As New Login
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Ingles_Click(sender As Object, e As EventArgs) Handles Ingles.Click
        Dim a As New TemaIngles
        a.Show()
        Me.Finalize()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As New TemaMedioAmbiente
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As New TemaScracth
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As New _4_Kodu

        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim a As New _5_TemaRealidadAumentada
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As New _6_InteligenciaArtificial
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim a As New _7_RealidadVirtual
        a.Show()
        Me.Finalize()
    End Sub
End Class