using System;
using System.IO;
using System.Text;
using System.Threading;

namespace GeradorSenha
{
    public class bonusSalvarSenha
    {
        public void SalvarSenhaMaquina(string senha)
        {
            Console.Clear();
            Console.WriteLine("=== SALVAR SENHA ===");
            Console.Write("-Será gerado um arquivo .txt no seguinte caminho: 'GeradorSenha' -> 'bin' -> 'Debug'.");
            Thread.Sleep(1500);
            Console.Write("-\n\nDeseja continuar? (S/N): ");
            bool continuar = Console.ReadLine().ToLower() == "s";

            if(continuar)
            {
                CriandoArquivoComWriter(senha);
            }
        }

        static void CriandoArquivoComWriter(string senhaGerada)
        {
            var caminhoNovoArquivo = "senhas.txt";

            //FileMode.Append para adicionar novas senhas no mesmo arquivo sem apagar.
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Append)) 
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8)) //Como o StreamWriter usa a codificação ANSI, ele não entende caracteres avançados como EMOJIS. Então vamos usar o UTF-8
            {
                escritor.Write($"{senhaGerada} - {DateTime.Now}\n");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nArquivo salvo com sucesso! ");
            Thread.Sleep(1500);
            Console.ResetColor();
        }
    }
}
