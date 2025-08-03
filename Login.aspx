<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="QuestionsDAD.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Login</title>
    <style>
        body { font-family: Arial; }
        .login-container {
            width: 300px;
            margin: 100px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 8px;
            background-color: #f9f9f9;
        }
        .login-container input, .login-container button {
            width: 100%;
            margin-bottom: 10px;
            padding: 8px;
        }
        .erro {
            color: red;
            text-align: center;
        }
    </style>
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
