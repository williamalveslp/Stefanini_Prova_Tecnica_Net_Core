# Stefanini_Prova_Tecnica_Net_Core

## Objetivo
Inicialmente, este projeto foi uma prova Técnica para Stefanini IT Solutions da filial de Brasília. Após o envio, continuo trabalhando neste repositório efetuando melhorias com o intuito de ser um projeto modelo/consulta para outros novos projetos com estratégias de mercado.

## Stack Utilizada

![](/Images_Stack_Templates/Template.png)

Aplicações em <b>.Net 3.1</b>: <b>Web</b> (Razor Pages, em *Presentation*) e aplicação <b>REST API</b> (integrado com Swagger e Health Checks, em *Service*).<br/>
Contemplam Testes Unitários com <b>xUnit</b> e Mocks.

## Testes Cobertos
- Testes de Unidade
- Testes de Integração

## Instruções

Após fazer o clone do repositório, siga os seguintes passos abaixo:

1 - Acesse a pasta ***Database_Scripts***, e execute todos scripts em banco ***SQL Server***.

2 - Para informar dados referente ao banco criado no passo anterior, basta encontrar o arquivo "appsettings.json" que está na raiz da aplicação tanto API quanto Web (sufixo "UI"), e substituir as variáveis ***ConnectionString*** e ***DatabaseName*** pelos dados do seu banco criado.

Pronto, está configurado sua aplicação para ser executada.

* Você pode realizar login utilizando algum dos usuários pré-cadastrados (do arquivo de scripts) da tabela ***User_System***, ou crie um usuário novo pela aplicação.

 @williamalveslp
