using StreamingFlix.App;

namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
    private readonly PlanoStreamingService _service = new PlanoStreamingService();

    [Theory]
    [InlineData(1, "BÁSICO")]
    [InlineData(2, "PADRÃO")]
    [InlineData(4, "PREMIUM")]
    public void ObterClassificacaoPorQualidade_DeveRetornarPlanoCorreto(int telasSimultaneas, string esperado)
    {
        var resultado = _service.ObterClassificacaoPorQualidade(telasSimultaneas);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(50, 1, 50)]
    [InlineData(50, 6, 45)]
    [InlineData(50, 12, 40)]
    public void CalcularMensalidadeComDesconto_DeveAplicarDescontoPorTempoDeContrato(int valorBase, int mesesContratados, int esperado)
    {
        var resultado = _service.CalcularMensalidadeComDesconto(valorBase, mesesContratados);

        Assert.Equal(esperado, resultado);
    }

    [Theory]
    [InlineData(20, false, true)]
    [InlineData(20, true, false)]
    [InlineData(16, false, false)]
    public void PodeAcessarConteudoAdulto_DeveValidarIdadeEControleParental(int idade, bool controleParentalAtivo, bool esperado)
    {
        var resultado = _service.PodeAcessarConteudoAdulto(idade, controleParentalAtivo);

        Assert.Equal(esperado, resultado);
    }
}
