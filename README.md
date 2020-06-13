# Stefanini_Prova_Tecnica_Net_Core

## Características da Aplicação

ASPNET Core 3.1
  - DDD
  - MVC
  - EntityFrameworkCore
  - Injeção de Dependência
  - Autenticação com Claims
  - ActionFilters
  - FluentValidators
  - Swagger
  - Health Checks
  - EntityTypeConfigurations
  - xUnit
  - Ajax
  - Jquery
  - Bootstrap

Aplicação Web (Razor Pages) e REST API (integrado com Swagger e Health Checks).

## Instruções

Após fazer o clone do repositório, siga os seguintes passos abaixo:

1 - Acesse a pasta ***Database_Scripts***, e execute todos scripts em banco ***SQL Server***.

2 - Substituindo a connection string: acesse o projeto que está dentro da pasta ***Project***, e localize a classe ***StefDbContext.cs*** (camada de Infra), sendo localizada em: ***/StefaniniCore.Infra.DataStore.SQLServer/Context/StefDbContext.cs***. Basta substituir a connection string pela sua em que executou os scripts de banco de dados.

Pronto, está configurado sua aplicação para ser executada.

* Você pode realizar login utilizando algum dos usuários pré-cadastrados da tabela ***User_System***, ou crie um usuário novo pela aplicação.
