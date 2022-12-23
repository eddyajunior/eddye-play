# Eddye Playground - Mutation Tests

## Descrição do Projeto

Projeto de testes utilizando xUnit e Mutation Tests para fins de estudos.

## Como Usar?
1. Clone do repositório
2. Acessar o diretório .\tests\EddyePlay.Tests.MutationTests
3. Executar o comando *dotnet Stryker*
4. Copie a URL gerada e cole no navegador abrir o relatório

![image](https://user-images.githubusercontent.com/18613681/209411924-4b89e5b8-a193-4cf3-9438-383821750f1f.png)

5. Com o relatório aberto no navegador teremos saberemos quantos mutantes foram criados, sobreviveram ou morreram com as mutações criadas e também o score. O importante para nós é a quantidade de mutantes que sobreviveram aos testes, eles indicam que podem estar faltando alguns testes.

![image](https://user-images.githubusercontent.com/18613681/209411964-4d5c290a-1873-4751-b637-c0dd48afbc9b.png)

> Fique atento, nem todas alterações recomendadas atendem nossas necessidades, temos que saber analisar e usar o que for necessário para nossa regra de negócio, assim

## Referências
[Stryker.NET](https://stryker-mutator.io/docs/stryker-net/introduction/)<br>