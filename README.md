# streaming-flix-xunit

## Visão geral

O StreamingFlix é uma aplicação de console em .NET 10 que reúne as regras de negócio dos planos de streaming e seus respectivos testes unitários.

## Estrutura

- `StreamingFlix.App`: código de produção (classe `PlanoStreamingService`)
- `StreamingFlix.Tests`: testes unitários (classe `PlanoStreamingServiceTests`)

## Regras de negócio

| Método | Retorno | Regra |
|---|---|---|
| `ObterClassificacaoPorQualidade(int telasSimultaneas)` | `string` | `"BÁSICO"` para 1 tela, `"PADRÃO"` para 2 telas e `"PREMIUM"` para 4 ou mais telas. |
| `CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)` | `int` | 10% de desconto para 6 a 11 meses e 20% para 12 meses ou mais. |
| `PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)` | `bool` | `true` apenas para idade >= 18 E controle parental `false`. |

## Requisitos técnicos

- .NET 10 SDK (projetos com `TargetFramework` `net10.0`)
- Git
- xUnit (restaurado automaticamente pelo `dotnet`)

## Como clonar e rodar a aplicação

```bash
git clone https://github.com/Albano-de-Souza/streaming-flix-xunit.git
cd streaming-flix-xunit
dotnet run --project StreamingFlix.App
```

A aplicação imprime no terminal exemplos de cada regra de negócio.

## Como executar os testes unitários

Na pasta raiz do repositório:

```bash
dotnet test
```

Resultado esperado: `total: 9; falhou: 0; bem-sucedido: 9`

## Cobertura dos testes parametrizados

Os testes usam `[Theory]` com `[InlineData]`: cada método de teste recebe parâmetros e é executado para múltiplos cenários. São 3 métodos de teste e 9 cenários, cobrindo os três métodos da classe `PlanoStreamingService`.

| Teste | Dados de entrada | Resultado esperado | Cenário |
|---|---|---|---|
| Classificação de planos | `1` | `"BÁSICO"` | 1 tela |
| Classificação de planos | `2` | `"PADRÃO"` | 2 telas |
| Classificação de planos | `4` | `"PREMIUM"` | 4 telas |
| Cálculo de desconto | `50`, `1` | `50` | Sem desconto |
| Cálculo de desconto | `50`, `6` | `45` | 10% de desconto |
| Cálculo de desconto | `50`, `12` | `40` | 20% de desconto |
| Validação de acesso | `20`, `false` | `true` | Maior de idade, sem restrição |
| Validação de acesso | `20`, `true` | `false` | Maior de idade, com restrição |
| Validação de acesso | `16`, `false` | `false` | Menor de idade |

## Equipe

| Papel | Responsável | Entregas |
|---|---|---|
| Desenvolvedor 1 (Backend / Core) | Albano de Souza | Solução, projetos e `PlanoStreamingService` |
| Desenvolvedor 2 (QA / Testes) | Alice Fernandes Barbosa | `PlanoStreamingServiceTests` com `[Theory]` e `[InlineData]` |
| Desenvolvedor 3 (Documentação / DevOps) | Ana Carolina de Sousa Freitas | Repositório, `.gitignore`, licença MIT e `README.md` |

## Licença

MIT
