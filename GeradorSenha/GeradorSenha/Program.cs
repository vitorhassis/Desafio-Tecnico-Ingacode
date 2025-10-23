

using System;

namespace GeradorSenha
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Suporte para os emojis
            Entrada e1 = new Entrada();
            e1.MenuPrincipal();
        }
    }
}
