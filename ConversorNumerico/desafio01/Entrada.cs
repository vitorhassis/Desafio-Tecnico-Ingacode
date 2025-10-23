namespace desafio01
{
    public class Entrada
    {
        ConversaoRomano cr = new ConversaoRomano();
        private bool continuar = true;
        public void EntradaDados()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=== CONVERSOR DE NÚMEROS (ROMANO - DECIMAL E VICE-VERSA) ===");
                Console.ResetColor();
                Console.WriteLine("\n1) Conversão Romano -> Decimal");
                Console.WriteLine("2) Conversão Decimal -> Romano");
                Console.WriteLine("0) Sair\n");
                Console.Write("-> ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== Conversão Romano -> Decimal ===");
                        Console.ResetColor();

                        continuar = true;
                        while (continuar)
                        {
                            Console.Write("\nDigite o número Romano: ");
                            string numRom = Console.ReadLine().ToUpper();
                            
                            int numDec = cr.ConverterRomanoParaDecimal(numRom);

                            if(numDec!=0)
                            {
                                Console.WriteLine($"{numRom} = {numDec}");
                            } else
                            {
                                Console.WriteLine("Número romano inválido.");
                                continue;
                            }

                            Console.Write("\nDeseja continuar? (S/N): ");
                            string escolha = Console.ReadLine().ToUpper();

                            if(escolha == "S")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("=== Conversão Romano -> Decimal ===");
                                Console.ResetColor();
                            } else if (escolha == "N")
                            {
                                continuar = false;
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("=== Conversão Decimal -> Romano ===");
                        Console.ResetColor();

                        continuar = true;
                        while(continuar)
                        {
                            Console.Write("\nDigite o número na base Decimal: ");
                            int numDec = int.Parse(Console.ReadLine());

                            string numRom = cr.ConverterDecimalParaRomano(numDec);

                            if(numRom.Length>0)
                            {
                                Console.WriteLine($"{numDec} = {numRom}");
                            } else
                            {
                                Console.WriteLine("Número romano inválido.");
                                continue;
                            }

                            Console.Write("\nDeseja continuar? (S/N): ");
                            string escolha = Console.ReadLine().ToUpper();

                            if (escolha == "S")
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("=== Conversão Decimal -> Romano ===");
                                Console.ResetColor();
                            } else if (escolha == "N")
                            {
                                continuar = false;
                            }
                        }
                        break;

                    case "0":
                        return;
                }
            }
            

        }
    }
}
