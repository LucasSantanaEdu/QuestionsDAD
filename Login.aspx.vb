Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs)
        Dim usuario = txtUsuario.Text.Trim().ToLower()
        Dim senha = txtSenha.Text.Trim()

        If usuario = "rogerio" And senha = "lucas" Then

            Session("UsuarioAutenticado") = True
            Response.Redirect("Default.aspx")
        Else

            lblErro.Text = "Usuário ou senha incorretos."
            lblErro.Visible = True
        End If
    End Sub
End Class
