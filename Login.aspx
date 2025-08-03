<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="QuestionsDAD.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <link href="CSS/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <asp:Label Text="Usuário:" runat="server" />
            <asp:TextBox ID="txtUsuario" runat="server" />

            <asp:Label Text="Senha: (Seu filho favorito):" runat="server" />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" />

            <asp:Button ID="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />

            <asp:Label ID="lblErro" runat="server" CssClass="erro" Visible="false" />
        </div>
    </form>
</body>
</html>
