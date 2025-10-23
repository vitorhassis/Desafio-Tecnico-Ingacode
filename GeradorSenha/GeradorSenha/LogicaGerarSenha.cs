using System;
using System.Text;

namespace GeradorSenha
{
    public class LogicaGerarSenha
    {
        string letraMai = "ABCDEFGHIJKMNOPQRSTUVWXZ";
        string letraMin = "abcdefghijklmnopqrstuvwxyz";
        string numeros = "0123456789";
        string simbolos = "!@#$%^&*()-_=+;:',<.>/?";
        string emojis = "😀😁😂🤣😅😊😍🤓😎🥳😜🤖👻💀🔥💫✨🌈🍀🌻🎮";
        public string GerarSenha(int qnt, bool incluirMaiuscula, bool incluirMinuscula, bool incluirNumero, bool incluirSimbolo, bool incluirEmojis)
        {

            StringBuilder conjunto = new StringBuilder();

            if (incluirMaiuscula)
            {
                conjunto.Append(letraMai);
            }

            if (incluirMinuscula)
            {
                conjunto.Append(letraMin);
            }

            if (incluirNumero)
            {
                conjunto.Append(numeros);
            }

            if (incluirSimbolo)
            {
                conjunto.Append(simbolos);
            }

            if (incluirEmojis)
            {
                conjunto.Append(emojis);
            }

            StringBuilder senha = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < qnt; i++)
            {
                int indice = rnd.Next(conjunto.Length); //Escolho um indice aleatório do conjunto 
                senha.Append(conjunto[indice]); //Adiciono o caracter do índice escolhido randomicamente em 'senha'
            }

            return senha.ToString(); //Transforma o conteúdo final em string normal
        }

        public void ForcaSenha(string senha)
        {
            int forcaSenha = 0;

            if (senha.Length >= 8) forcaSenha++;

            if (senha.IndexOfAny(letraMai.ToCharArray()) >= 0)
            {
                forcaSenha++;
            }

            if (senha.IndexOfAny(letraMin.ToCharArray()) >= 0)
            {
                forcaSenha++;
            }

            if (senha.IndexOfAny(numeros.ToCharArray()) >= 0)
            {
                forcaSenha++;
            }

            if (senha.IndexOfAny(simbolos.ToCharArray()) >= 0)
            {
                forcaSenha++;
            }

            if (senha.IndexOfAny(emojis.ToCharArray()) >= 0)
            {
                forcaSenha++;
            }

           if (forcaSenha <= 2) 
           { 
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.Write("\nSenha fraca! "); 
                Console.ResetColor(); 
           } 
            else if (forcaSenha <= 4) 
            {   
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.Write("\nSenha Mediana! "); 
                Console.ResetColor(); 
            } 

            else 
            { 
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.Write("\nSenha Forte! "); 
                Console.ResetColor(); 
            }
        }
    }
}
