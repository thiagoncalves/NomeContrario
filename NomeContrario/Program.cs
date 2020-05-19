using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeContrario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nomeInvertido;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine().ToUpper();

            nomeInvertido = ReverterNome(nome);

            Console.Clear();

            Console.WriteLine("Seu nome: " + nomeInvertido);

            Console.ReadLine();
        }

        public static string ReverterNome(string nome)
        {
            char[] nomeinserido = nome.ToCharArray();
            Array.Reverse(nomeinserido);
            return new string(nomeinserido);
        }
    }
}
