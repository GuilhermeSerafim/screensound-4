# ScreenSound 4

Estudo em C# com aplicação de console para consumir um catálogo de músicas em JSON e praticar consultas com LINQ. O projeto consome dados por HTTP; não disponibiliza um servidor de API.

## Organização

- `ScreenSound4/Program.cs`: consulta o catálogo remoto, desserializa músicas e chama o filtro por tonalidade.
- `ScreenSound4/Filtrar/LinqFilter.cs`: exemplos de consultas por gênero, artista, ano e tonalidade.
- `ScreenSound4/Desafio/`: exercícios adicionais de modelagem e serialização.

O manifesto aponta para .NET 8. O fluxo atual depende de acesso ao catálogo remoto e usa posições fixas da lista, incluindo o índice 1901; uma lista menor ou uma mudança de formato pode interromper o exemplo.
