using Calculadora.Console;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly CalculadoraController _calc;
        
        public CalculadoraTests()
        {
            _calc = new CalculadoraController();
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 5, 9)]
        public void Somar(int num1, int num2, int result)
        {
            int resultadoCalc = _calc.Somar(num1, num2);

            Assert.Equal(result, resultadoCalc);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(3, 2, 1)]
        [InlineData(2, -5, 7)]
        public void Subtrair(int num1, int num2, int result)
        {
            int resultadoCalc = _calc.Subtrair(num1, num2);

            Assert.Equal(result, resultadoCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(2, 5, 10)]
        public void Multiplicar(int num1, int num2, int result)
        {
            int resultadoCalc = _calc.Multiplicar(num1, num2);

            Assert.Equal(result, resultadoCalc);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void Divisao(int num1, int num2, int result)
        {
            int resultadoCalc = _calc.Divisao(num1, num2);

            Assert.Equal(result, resultadoCalc);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Divisao(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Somar(1, 2);
            _calc.Somar(2, 2);
            _calc.Somar(4, 4);
            _calc.Somar(10, 5);

            var list = _calc.historico();

            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }

    }

}