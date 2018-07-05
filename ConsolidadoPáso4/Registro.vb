Imports System.Data.OleDb
Imports System.Data
Public Class Registro
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As New Login
        a.Show()
        Me.Finalize()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtName.Text = "" Or txtApel.Text = "" Or txtDoc.Text = "" Or txt.Text = "" Or txtLog.Text = "" Or txtPsw.Text = "" Then
            MsgBox("Los campos no pueden estar vacios")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FaseFinal\Proyecto\BD\Personal.accdb")
                Dim insert As String = "Insert into Personas values('" & txtDoc.Text & "','" & txtName.Text & "','" & txtApel.Text & "','" & txt.Text & "','" & txtLog.Text & "','" & txtPsw.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro Exitoso")
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If
        txtName.Text = ""
        txtApel.Text = ""
        txtDoc.Text = ""
        txteml.Text = ""
        txtLog.Text = ""
        txtPsw.Text = ""
        txtCPs.Text = ""
    End Sub

    Private Sub txtDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDoc.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cons.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FaseFinal\Proyecto\BD\Personal.accdb")
        Dim orden As New OleDbDataAdapter("select * from Personas", conn)
        Dim tabla As DataSet
        tabla = New DataSet()
        orden.Fill(tabla, "Personas")
        txtName1.Text = tabla.Tables("Personas").Rows(0).Item(1).ToString
        txtApel1.Text = tabla.Tables("Personas").Rows(0).Item(2).ToString
        txteml1.Text = tabla.Tables("Personas").Rows(0).Item(3).ToString
        txtLog1.Text = tabla.Tables("Personas").Rows(0).Item(4).ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FaseFinal\Proyecto\BD\Personal.accdb")
        Dim com As New OleDbCommand("update Personas set Nombres='" & txtName1.Text & "', Apellidos='" & txtApel1.Text & "', Correo='" & txteml1.Text & "', login='" & txtLog1.Text & "', clave='" & txtPsw1.Text & "' where identificación=" & txtDoc1.Text, conn)
        conn.open()
        com.ExecuteNonQuery()
        conn.Close()
        MsgBox("Datos Actualizados con Exito")
        txtName1.Text = ""
        txtApel1.Text = ""
        txtDoc1.Text = ""
        txteml1.Text = ""
        txtLog1.Text = ""
        txtPsw1.Text = ""
        txtCPw1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\FaseFinal\Proyecto\BD\Personal.accdb")
        Dim com As New OleDbCommand("delete from Personas where identificación=" & txtDoc2.Text, conn)
        conn.Open()
        com.ExecuteNonQuery()
        conn.Close()
        MsgBox("Cuenta Eliminada con Exito")
        txtDoc2.Text = ""
    End Sub
End Class