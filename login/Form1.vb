Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Los campos se encuentran vacios")
        Else
            If TextBox1.Text = "" Then
                MsgBox("El campo USUARIO se encuentra vacio")
            Else
                If TextBox2.Text = "" Then
                    MsgBox("El campo CONTRASEÑA se encuentra vacio")
                Else
                    If TextBox1.Text = "TuUsuario" And TextBox2.Text = "TuContraseña" Then
                        Me.Hide()
                        form2.show()
                    Else
                        MsgBox("Los datos son incorrectos")
                    End If
                End If
            End If
        End If
    End Sub
End Class
