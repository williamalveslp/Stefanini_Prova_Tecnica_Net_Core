# Stefanini_Prova_Tecnica_Net_Core

## Objetivo
Inicialmente, este projeto foi uma prova Técnica para Stefanini IT Solutions da filial de Brasília. Após o envio, continuo trabalhando neste repositório efetuando melhorias com o intuito de ser um projeto modelo/consulta para outros novos projetos com estratégias de mercado.

## Stack Utilizada

![](/Images_Stack_Templates/Template.png)

Aplicações em <b>.Net 3.1</b>: <b>Web</b> (Razor Pages, em *Presentation*) e aplicação <b>REST API</b> (integrado com Swagger e Health Checks, em *Service*).

## Instruções

Após fazer o clone do repositório, siga os seguintes passos abaixo:

1 - Acesse a pasta ***Database_Scripts***, e execute todos scripts em banco ***SQL Server***.

2 - Substituindo a connection string: acesse o projeto que está dentro da pasta ***Project***, e localize a classe ***StefDbContext.cs*** (camada de Infra), sendo localizada em: ***/StefaniniCore.Infra.DataStore.SQLServer/Context/StefDbContext.cs***. Basta substituir a connection string pela sua em que executou os scripts de banco de dados.

Pronto, está configurado sua aplicação para ser executada.

* Você pode realizar login utilizando algum dos usuários pré-cadastrados da tabela ***User_System***, ou crie um usuário novo pela aplicação.

 @williamalveslp
