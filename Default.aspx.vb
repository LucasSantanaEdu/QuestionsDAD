Public Class WebForm1
    Inherits System.Web.UI.Page

    <Serializable()>
    Public Class Pergunta
        Public Property Texto As String
        Public Property Opcoes As List(Of String)
        Public Property Valores As List(Of String)
        Public Property RespostaCorreta As String
        Public Property ImagemCorreta As String
        Public Property ImagemErrada As String
    End Class



    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("UsuarioAutenticado") Is Nothing OrElse Not CBool(Session("UsuarioAutenticado")) Then
            Response.Redirect("Login.aspx")
        End If

        If Not IsPostBack Then
            ViewState("Acertos") = 0
            ViewState("Erros") = 0
            Dim perguntas As New List(Of Pergunta)

            perguntas.Add(New Pergunta With {
            .Texto = "Quando eu tinha 6 anos de idade gostava muito de RBD (Rebelde)",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "4",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Meu primo já chamou a polícia pra mim por causa de bagunça",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "3",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })

            perguntas.Add(New Pergunta With {
            .Texto = "Eu tenho 11 aninhos e meu sonho é ser médico(a)",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "2",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Minha mãe foi na escola bater em uma mulher que me chamou de descabelada",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "1",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Fui brincar na praça e voltei com a testa sangrando pois meu primo me jogou uma pedra",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "3",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "O meu sonho é fazer intercâmbio em Londres",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "3",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Se você pisar no chão quando estou passando o pano sou capaz de te matar",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "1",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Eu odeio comer pão ou macarrão",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "1",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Eu amo mudar para o canal ArtAttack",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "3",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Quando criança tinha medo de gato e de cachorro",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "2",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Quando eu era criança pegava as roupas errado, quebrava os cabides até que um dia apanhei de cabidee e aprendi",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "1",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Com 4 anos de idade tomei a minha primeira cerveja",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "4",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })
            perguntas.Add(New Pergunta With {
            .Texto = "Eu uso coque com rendinha para ir pra guarda mirim",
            .Opcoes = New List(Of String) From {
                "a) Bia", "b) Carol", "c) Jéssica", "d) Lucas"},
            .Valores = New List(Of String) From {
                "1", "2", "3", "4"},
            .RespostaCorreta = "3",
            .ImagemCorreta = "~/imagens/",
            .ImagemErrada = "~/imagens/"
        })


            ViewState("Perguntas") = perguntas
            ViewState("IndexAtual") = 0
            ViewState("Acertos") = 0L

            MostrarPergunta(0)
        End If
    End Sub

    Private Sub MostrarPergunta(indice As Integer)
        Dim perguntas = CType(ViewState("Perguntas"), List(Of Pergunta))
        Dim pergunta = perguntas(indice)

        lblPergunta.Text = pergunta.Texto
        rblOpcoes.Items.Clear()

        For i As Integer = 0 To pergunta.Opcoes.Count - 1
            rblOpcoes.Items.Add(New ListItem(pergunta.Opcoes(i), pergunta.Valores(i)))
        Next

        rblOpcoes.ClearSelection()
        rblOpcoes.Enabled = True
        btnConfirmar.Enabled = True
        btnProxima.Visible = False
        lblFeedback.Visible = False
        imgResultado.Visible = False
    End Sub

    Protected Sub btnConfirmar_Click(sender As Object, e As EventArgs)
        Dim perguntas = CType(ViewState("Perguntas"), List(Of Pergunta))
        Dim indice = CInt(ViewState("IndexAtual"))
        Dim perguntaAtual = perguntas(indice)

        If rblOpcoes.SelectedValue = "" Then
            lblFeedback.Text = "Por favor, selecione uma opção."
            lblFeedback.CssClass = "feedback-label erro"
            lblFeedback.Visible = True
            Return
        End If

        If rblOpcoes.SelectedValue = perguntaAtual.RespostaCorreta Then
            lblFeedback.Text = "A resposta está CORRETA!"
            lblFeedback.CssClass = "feedback-label correta"
            imgResultado.ImageUrl = perguntaAtual.ImagemCorreta
            ViewState("Acertos") = CInt(ViewState("Acertos")) + 1
        Else
            lblFeedback.Text = "A resposta está ERRADA!"
            lblFeedback.CssClass = "feedback-label erro"
            imgResultado.ImageUrl = perguntaAtual.ImagemErrada
            ViewState("Erros") = CInt(ViewState("Erros")) + 1
        End If

        imgResultado.Visible = True

        lblFeedback.Visible = True
        rblOpcoes.Enabled = False
        btnConfirmar.Enabled = False

        If indice < perguntas.Count - 1 Then
            btnProxima.Visible = True
        Else
            btnProxima.Visible = False
            MostrarResultadoFinal()
        End If
    End Sub


    Protected Sub btnProxima_Click(sender As Object, e As EventArgs) Handles btnProxima.Click
        Dim proximoIndice As Integer = CInt(ViewState("IndexAtual")) + 1
        ViewState("IndexAtual") = proximoIndice
        MostrarPergunta(proximoIndice)
    End Sub
    Private Sub MostrarResultadoFinal()
        Dim acertos = CInt(ViewState("Acertos"))
        Dim erros = CInt(ViewState("Erros"))

        lblResultadoFinal.Text = $"Você acertou {acertos} de 15 perguntas. É um ótimo pai!<br/>Erros: {erros}"
        lblResultadoFinal.Visible = True
        lblFeedback.Visible = False
        rblOpcoes.Visible = False
        btnConfirmar.Visible = False
    End Sub




End Class