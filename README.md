# Eddye Playground

## Descrição do Projeto/Repositório

Repositório para estudos e testes de novas tecnologias, padrões, POC's, etc.

## Conteúdo
[Estrutura de Pastas e Arquivos](#folders_and_files)<br>
[Tecnologias e Padrões](#technologies)<br>
[Como Usar o Projeto](#how_to_use)<br>
[Licença](#license)<br>
[Versionamento](#version)<br>

<a name="folders_and_files"></a>
## Tecnologias e Padrões
1. Polly
2. Circuit Breaker
3. Worker
4. Web API
5. .NET 7

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
     |___EddyePlay.API.Polly.CircuitBreaker
     |___EddyePlay.Worker.Polly.CircuitBreaker    
```

<a name="how_to_use"></a>
## Como Usar o Projeto
Esse repositório é composto por vários projetos, uns podem ou não depender de outros. Sendo assim, para utilizar algum desses projetos é recomendável que seja feito o clone do repositório e lido o README do respectivo projeto. Existe um README raiz (do repositório) e cada projeto possui um REAME individual com instruções de uso.

<a name="license"></a>
## Licença
Esse projeto está protegido sob licença. Para mais informações consulte o arquivo [LICENSE.md](LICENSE.md).<br>

<a name="version"></a>
## Versionamento

| Versão  | Data | Resumo |
| ------------- | ------------- | ------------- |
| v0.0.0  | 22/12/2022  | Polly Circuit Breaker (API e Worker)  |