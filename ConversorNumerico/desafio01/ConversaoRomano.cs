namespace desafio01
{
    internal class ConversaoRomano
    {
        private Dictionary<int, string> numerosparaRomanos = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        private Dictionary<char, int> numerosParaDecimais = new Dictionary<char, int>
        {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
        };

        public int ConverterRomanoParaDecimal(string numeroRomano)
        {
            int total = 0;
            for (int i = 0; i < numeroRomano.Length; i++)
            {
                int c1 = numerosParaDecimais[numeroRomano[i]]; 
                int c2 = 0; 

                if (i + 1 < numeroRomano.Length)
                {
                    c2 = numerosParaDecimais[numeroRomano[i + 1]];
                }

                if (c1 < c2)
                {
                    total -= c1; 
                }
                else
                {
                    total += c1;
                }
            }
            return total;
        }

        public string ConverterDecimalParaRomano(int numeroDecimal)
        {
            string resultadoRomano = "";
            foreach (var par in numerosparaRomanos)
            {
                while (numeroDecimal >= par.Key)
                {
                    resultadoRomano += par.Value;
                    numeroDecimal -= par.Key;
                }
            }
            return resultadoRomano;
        }

    }
}
