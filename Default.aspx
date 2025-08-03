<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="QuestionsDAD.WebForm1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Quiz Dia dos Pais</title>
    <link href="CSS/styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="quiz-container">

            <asp:Label ID="lblPergunta" runat="server" CssClass="question-text" />

            <div class="options-container">
                <asp:RadioButtonList ID="rblOpcoes" runat="server" CssClass="options-list" RepeatDirection="Vertical" />
            </div>

            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="confirm-button" OnClick="btnConfirmar_Click" />

            <asp:Label ID="lblFeedback" runat="server" CssClass="feedback-label" Visible="false" />

            <asp:Image ID="imgResultado" runat="server" CssClass="result-image" Visible="false" />

            <asp:Button ID="btnProxima" runat="server" Text="Próxima Pergunta" CssClass="next-button" OnClick="btnProxima_Click" Visible="false" />

            <asp:Label ID="lblResultadoFinal" runat="server" CssClass="result-label" Visible="false" />
        </div>
    </form>
</body>
</html>
