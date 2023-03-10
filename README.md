# Eddye Playground 💻

## Descrição do Projeto/Repositório 

Repositório para estudos e testes de novas tecnologias, padrões, POC's, etc.
Em tecnologias, temos 2 tipos de status representados por ícones conforme abaixo:
- 🚧 Em desenvolvimento
- ☑️ Concluído

## Conteúdo
[Estrutura de Pastas e Arquivos](#folders_and_files)<br>
[Tecnologias e Padrões](#technologies)<br>
[Como Usar](#how_to_use)<br>
[Licença](#license)<br>
[Versionamento](#version)<br>

<a name="folders_and_files"></a>
## Tecnologias e Padrões
☑️ Bogus <br>
☑️ Github Actions <br>
☑️ Azure Web App <br>
☑️ Mutation Tests <br>
☑️ JWT <br>
☑️ Polly <br>
☑️ Circuit Breaker <br>
☑️ Worker <br>
☑️ Web API <br>
☑️ .NET 7  <br>

<a name="technologies"></a>
## Estrutura de Pastas e Arquivos
```
eddye-play
|   EddyePlay.sln
|   gitignore
|   LICENSE.md
|   README.md
|
|___src
|    |___EddyePlay.API.General
|    |___EddyePlay.API.JWT
|    |___EddyePlay.API.Polly.CircuitBreaker
|    |___EddyePlay.WebApp.HelloWorld
|    |___EddyePlay.Worker.Polly.CircuitBreaker    
|
|___tests
     |___EddyePlay.Tests.MutationTests
```

<a name="how_to_use"></a>
## Como Usar
Esse repositório é composto por vários projetos, uns podem ou não depender de outros. Sendo assim, para utilizar algum desses projetos é recomendável que seja feito o clone do repositório e lido o README do respectivo projeto. Existe um README raiz (do repositório) e cada projeto possui um REAME individual com instruções de uso.

<a name="license"></a>
## Licença
Esse projeto está protegido sob licença. Para mais informações consulte o arquivo [LICENSE.md](LICENSE.md).<br>

<a name="version"></a>
## Versionamento

| Versão  | Data | Resumo |
| ------------- | ------------- | ------------- |
| v0.4.0  | 08/01/2023  | API General + Bogus  |
| v0.3.0  | 26/12/2022  | .NET Core Web App e Github Actions  |
| v0.2.0  | 23/12/2022  | Mutation Tests (Stryker.NET e xUnit)  |
| v0.1.0  | 23/12/2022  | JWT Token (API)  |
| v0.0.0  | 22/12/2022  | Polly Circuit Breaker (API e Worker)  |