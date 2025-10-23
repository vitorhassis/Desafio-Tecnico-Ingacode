using System;
using System.Windows.Forms;
using System.Threading;

namespace GeradorSenha
{
    public class Entrada
    {
        private LogicaGerarSenha g1 = new LogicaGerarSenha();
        private string senha { get; set; } //Campo privado
        public string Senha => senha; //Propriedade de leitura, get
        public void MenuPrincipal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== MENU PRINCIPAL ===");
            Console.ResetColor();
            Console.Write("\n1) Quantos caracteres será gerado?: ");
            int qntCaracteres = int.Parse(Console.ReadLine());

            Console.Write("2) Deseja incluir uma letra maiúscula? (S/N): ");
            bool incluirLetraMaiuscula = Console.ReadLine().ToLower() == "s";

            Console.Write("3) Deseja incluir uma letra minúscula? (S/N): ");
            bool incluirLetraMinuscula = Console.ReadLine().ToLower() == "s";

            Console.Write("4) Deseja incluir um número? (S/N): ");
            bool incluirNumero = Console.ReadLine().ToLower() == "s";

            Console.Write("5) Deseja incluir um símbolo? (S/N): ");
            bool incluirSimbolo = Console.ReadLine().ToLower() == "s";

            Console.Write("6) Deseja incluir emojis? (S/N): ");
            bool incluirEmojis = Console.ReadLine().ToLower() == "s";

             senha = g1.GerarSenha(qntCaracteres, incluirLetraMaiuscula, incluirLetraMinuscula, incluirNumero, incluirSimbolo, incluirEmojis);

            Console.Write("\nAguarde! Estamos gerando sua senha... ");
            Thread.Sleep(2000);
            Console.Write("\n\nSenha gerada com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" sucesso! ");
            Console.ResetColor();
            Thread.Sleep(1500);

            MenuSenha();

        }

        public void MenuSenha()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("=== MENU SENHA ===");
                Console.ResetColor();
                Console.WriteLine("\n1) Visualizar Força da senha ");
                Console.WriteLine("2) Visualizar sua senha ");
                Console.WriteLine("3) Copiar a senha para a área de transferência ");
                Console.WriteLine("4) BÔNUS - Salvar senhas num arquivo .txt em sua máquina ");
                Console.WriteLine("0) Sair");
                Console.Write("\n-> ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("=== FORCA SENHA ===");
                        g1.ForcaSenha(senha);
                        Thread.Sleep(1500);
                        Console.Write("\n\nPressione uma tecla para voltar ao Menu... ");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("=== VISUALIZAR SENHA ===");
                        Console.Write($"\nSua senha -> ");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine($"{Senha}");
                        Console.ResetColor();

                        Thread.Sleep(1500);
                        Console.Write("\n\nPressione uma tecla para voltar ao Menu... ");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("=== COPIAR SENHA ===");
                        Clipboard.SetText(senha);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nSenha copiada para a área de transferência! ");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                        Console.Write("\n\nPressione uma tecla para voltar ao Menu... ");
                        Console.ReadKey();
                        break;

                    case "4":
                        bonusSalvarSenha b1 = new bonusSalvarSenha();
                        b1.SalvarSenhaMaquina(senha);
                        Thread.Sleep(1500);
                        Console.Write("\n\nPressione uma tecla para voltar ao Menu... ");
                        Console.ReadKey();
                        break;

                    case "0":
                        return;
                }
            }
        }   
    }
}
