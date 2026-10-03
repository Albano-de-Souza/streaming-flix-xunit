using StreamingFlix.App;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var service = new PlanoStreamingService();

Console.WriteLine("=== StreamingFlix ===");
Console.WriteLine($"Plano para 1 tela: {service.ObterClassificacaoPorQualidade(1)}");
Console.WriteLine($"Plano para 2 telas: {service.ObterClassificacaoPorQualidade(2)}");
Console.WriteLine($"Plano para 4 telas: {service.ObterClassificacaoPorQualidade(4)}");
Console.WriteLine($"Mensalidade de R$ 50 por 1 mês: R$ {service.CalcularMensalidadeComDesconto(50, 1)}");
Console.WriteLine($"Mensalidade de R$ 50 por 6 meses: R$ {service.CalcularMensalidadeComDesconto(50, 6)}");
Console.WriteLine($"Mensalidade de R$ 50 por 12 meses: R$ {service.CalcularMensalidadeComDesconto(50, 12)}");
Console.WriteLine($"20 anos, sem controle parental, acessa conteúdo adulto: {service.PodeAcessarConteudoAdulto(20, false)}");
Console.WriteLine($"20 anos, com controle parental, acessa conteúdo adulto: {service.PodeAcessarConteudoAdulto(20, true)}");
Console.WriteLine($"16 anos, sem controle parental, acessa conteúdo adulto: {service.PodeAcessarConteudoAdulto(16, false)}");
