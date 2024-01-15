using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;
    
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange: Montar o cenário. Somar 5 com 10.
        // Act: Executar a ação de somar
        // Assert: Validar se tudo acima tem o resultado esperado.
    }
}
