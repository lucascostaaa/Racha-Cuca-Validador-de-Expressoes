using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidadorExpressoes;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Dois_Mais_Dois()
        {
            var expressaoInicial = "2+2";
            var simbolos = Tradutor.Decodificar(expressaoInicial);
            var expressao = Agrupador.Agrupar(simbolos).Should().Be(4);
        }
    }
}
