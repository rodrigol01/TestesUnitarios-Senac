using System;
using TestesUnitariosServiceFolder.Services;
using Xunit;

namespace CalculadoraTeste.CalculadoraComTestes.Services
{
    public class CalculadoraServiceTest
    {
        private TestesUnitariosService _service;

        private void Setup()
        {
            _service = new TestesUnitariosService();
        }

        [Fact]
        public void Somar_deve_somar()
        {
            Setup();

            //ARRANGE
            var a = 1;
            var b = 1;

            var expected = 2;

            //ACT
            var result = _service.Somar(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Subtrair_deve_subtrair()
        {
            Setup();

            //ARRANGE
            var a = 6;
            var b = 3;

            var expected = 3;

            //ACT
            var result = _service.Subtracao(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Multiplicacao_deve_multiplicar()
        {
            Setup();

            //ARRANGE
            var a = 2;
            var b = 2;

            var expected = 4;

            //ACT
            var result = _service.Multiplicacao(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Divisao_deve_dividir()
        {
            Setup();

            //ARRANGE
            var a = 2;
            var b = 2;

            var expected = 1;

            //ACT
            var result = _service.Divisao(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Divisao_por_zero_deve_retornar_zero()
        {
            Setup();

            //ARRANGE
            var a = 2;
            var b = 0;

            var expected = 0;

            //ACT
            var result = _service.Divisao(a, b);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ConverterRealParaDolar_Deve_Converter()
        {
            Setup();

            var real = 50;
            var dolar = 4.65;

            var expected = 232.5;

            //ACT
            var result = _service.ConverterRealParaDolar(real, dolar);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ConverterRealParaDolar_Nao_Deve_Conter_Zero_Nos_Parametros()
        {
            Setup();

            var real = 0;
            var dolar = 4.65d;

            //ACT
            //ASSERT

            Assert.Throws<Exception>(() => _service.ConverterRealParaDolar(real, dolar));

        }
        
        [Fact]
        public void ConverterDolarParaReal_Deve_Converter()
        {
            Setup();

            var real = 232.5;
            var dolar = 4.65;

            var expected = 50.0;

            //ACT
            var result = _service.ConverterDolarParaReal(real, dolar);

            //ASSERT
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ConverterDolarParaReal_Nao_Deve_Conter_Zero_Nos_Parametros()
        {
            Setup();

            var real = 0;
            var dolar = 4.65d;

            //ACT
            //ASSERT

            Assert.Throws<Exception>(() => _service.ConverterDolarParaReal(real, dolar));
        }
        
        [Fact]
        public void CriptografarCaracteres_Deve_Criptografar()
        {
            Setup();

            var text = "ABCZ";
            
            var expected = "BCDA";
            
            var result = _service.CriptografarCaracteres(text);

            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void CriptografarCaracteres_Deve_Arremessar_Erro_Se_Texto_Inserido_For_NullOrEmpty()
        {
            Setup();

            var text = "";
            
            Assert.Throws<ArgumentNullException>(() => _service.CriptografarCaracteres(text));
        }
        
        [Fact]
        public void CriptografarCaracteres_Deve_Arremessar_Exception_Se_Estiver_Fora_Do_Range_De_Criptografia()
        {
            Setup();

            var text = "1";
            
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.CriptografarCaracteres(text));
        }
        
        [Fact]
        public void CriptografarCaracteres_Deve_Criptografar_z_em_a()
        {
            Setup();

            var text = "z";
            
            var expected = "a";
            
            var result = _service.CriptografarCaracteres(text);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void DecriptografarCaracteres_Deve_Deriptografar()
        {
            Setup();

            var text = "BCDA";
            
            var expected = "ABCZ";
            
            var result = _service.DecriptografarCaracteres(text);

            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void DecriptografarCaracteres_Deve_Deve_Arremessar_Exception_Se_Estiver_Fora_Do_Range_De_Criptografia()
        {
            Setup();

            var text = "1";
            
            Assert.Throws<ArgumentOutOfRangeException>(() => _service.DecriptografarCaracteres(text));
        }
        
        [Fact]
        public void DecriptografarCaracteres_Deve_Arremessar_Erro_Se_Texto_Inserido_For_NullOrEmpty()
        {
            Setup();

            var text = "";
            
            Assert.Throws<ArgumentNullException>(() => _service.DecriptografarCaracteres(text));
        }
        
        [Fact]
        public void DecriptografarCaracteres_Deve_Decriptografar_a_em_z()
        {
            Setup();

            var text = "a";
            
            var expected = "z";
            
            var result = _service.DecriptografarCaracteres(text);

            Assert.Equal(expected, result);
        }
    }
}
