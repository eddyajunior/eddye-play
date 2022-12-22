# Eddye Playground - Worker Polly Circuit Breaker

## Descrição do Projeto

Worker criado e explicada pelo Renato Groffe a fim de demonstrar a implementação do padrão **Circuit Breaker** em .NET 7, utilizando a biblioteca **Polly** e consumindo uma **API REST**.

## Referências
[Medium - .NET 7 + Polly: implementando o padrão Circuit Breaker no tratamento de falhas](https://renatogroffe.medium.com/net-7-polly-implementando-o-padr%C3%A3o-circuit-breaker-no-tratamento-de-falhas-6690961fb595) por Renato Groffe<br>
[DotNet7-Worker-Polly-CircuitBreaker_ConsumoAPIContagem (Git)](https://github.com/renatogroffe/DotNet7-Worker-Polly-CircuitBreaker_ConsumoAPIContagem)

## Como Usar
1. Executar o projeto EddyePlay.API.Polly.CircuitBreaker<br>
   1.1. Acessar a pasta do projeto API, executar o comando: *dotnet run*<br>
   1.2. A API será executada na porta 5000 (tenha certeza de que a mesma não está sendo utilizada)<br>
   1.3. [Swagger](http://localhost:5000/swagger/index.html)<br>
2. Executar o projeto EddyePlay.Worker.Polly.CircuitBreaker<br>
   2.1. Acessar a pasta do projeto Worker, executar o comando: *dotnet run*<br>
   2.2. Certifique-se de que a API está sendo executada na porta 5000<br>