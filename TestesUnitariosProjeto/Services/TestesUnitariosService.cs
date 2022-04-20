using System.Text;

namespace TestesUnitariosServiceFolder.Services
{
    public class TestesUnitariosService
    {
        public int Somar(int a, int b) => a + b;

        public int Subtracao(int a, int b) => a - b;

        public int Multiplicacao(int a, int b) => a * b;

        public int Divisao(int a, int b) => b != 0 ? a / b : 0;
        
        public double ConverterRealParaDolar(double real, double dolar)
        {
            if (real == 0 || dolar == 0)
                throw new Exception("não é possível converter");
            
            return ConvertFormatedValueToDouble(real * dolar);
        }
        
        public double ConverterDolarParaReal(double real, double dolar)
        {
            if (real == 0 || dolar == 0)
                throw new Exception("não é possível converter");


            return ConvertFormatedValueToDouble(real / dolar);
        }

        public double ConvertFormatedValueToDouble(double a)
        {
            return Convert.ToDouble(a.ToString("N2"));
        }

        public string CriptografarCaracteres(string text)
        {
            if (string.IsNullOrEmpty(text)) 
                throw new ArgumentNullException("Não é permitido criptografar texto nulo");
            
            var asciiBytes = Encoding.ASCII.GetBytes(text);
            
            string encriptedText = "";
            foreach (var letter in asciiBytes)
            {
                var nextLetter = (byte)(letter + 1);
                
                if (letter < 97 && letter > 90)
                    throw new ArgumentOutOfRangeException($"O caractere {letter} não é permitido");
                if (letter < 65 || letter > 122)
                    throw new ArgumentOutOfRangeException($"O caractere {letter} não é permitido");
                
                if (letter == 90)
                    nextLetter = 65;
                if (letter == 122)
                    nextLetter = 97;
                
                encriptedText += Convert.ToChar(nextLetter);
            }

            return encriptedText;
        }
        
        public string DecriptografarCaracteres(string encriptedText)
        {
            if (string.IsNullOrEmpty(encriptedText)) 
                throw new ArgumentNullException("Não é permitido criptografar texto nulo");
            
            var text = "";
            foreach (var letter in encriptedText)
            {
                var previousLetter = (byte)(letter - 1);
                
                if (letter < 97 && letter > 90)
                    throw new ArgumentOutOfRangeException($"O caractere {letter} não é permitido");
                if (letter < 65 || letter > 122)
                    throw new ArgumentOutOfRangeException($"O caractere {letter} não é permitido");
                
                if (letter == 65)
                    previousLetter = 90;
                if (letter == 97)
                    previousLetter = 122;
        
                text += Convert.ToChar(previousLetter);
            }
            
            return text;
        }
    }
}
