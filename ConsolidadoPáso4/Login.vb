Imports System.Data.OleDb
Imports System.Data

Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As New Menu
        Dim contador As Integer
        Dim uname As String
        Dim pword As String
        Dim pass As String

        If txtLGN.Text = "" And txtPSW.Text = "" Then
            'se realiza validación correcta de user/password
            MsgBox("Los campos no pueden estar en blanco")
            'muestra ventana de confirmación
        Else
            uname = txtLGN.Text
            pword = txtPSW.Text
            Dim querry As String = "Select clave from Personas where login= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FaseFinal\Proyecto\BD\Personal.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()

            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("usaurio no existe")
            End Try
            If (pword = pass) Then
                MsgBox("Ingreso Correcto")
                a.Show()
                Me.Finalize()
            Else
                MsgBox("Ingreso Fallido")
                txtLGN.Clear()
                txtPSW.Clear()
            End If

        End If


        If (contador > 2) Then
            'realiza validación del contador si es superior al máximo permitido
            MsgBox("Ha superado el maximo de intentos permitidos(3)")
            'envia mensajé de error
            txtLGN.Visible = False
            txtPSW.Visible = False
            'oculta los textbox
        Else
            MsgBox("Bienvenido al Sistema")
            'envia mensaje de datos incorrectos
            txtLGN.Text = ""
            txtPSW.Text = ""
            'vuelve textbox en blanco
            contador += 1
            'aumenta contador en 1+
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Registro
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
