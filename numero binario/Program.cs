using System;
using System.Linq;

namespace numero_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n1;
            n = n1 =0;
            string nBinarioInvertido, dnv;
            nBinarioInvertido = dnv = "";

            do
            {
                Console.Clear();
                Console.Write("Insira o número a ser convertido para binário: ");
                int.TryParse(Console.ReadLine(), out n1); n = n1;
                
                nBinarioInvertido = Convert(n1, nBinarioInvertido);
                string nBinario = new string(nBinarioInvertido.Reverse().ToArray()).ToString();

                Linha();
                Console.WriteLine($"{(n).ToString()} em binário: {nBinario}");
                nBinario = nBinarioInvertido = null;

            } while (Convert_Again(dnv) != "n");

            Linha();
            Console.Write("Programa finaizado..");
            Console.ReadKey();
        }

        public static string Convert(int n1, string nBinarioInvertido)
        {
            while (n1 > 0)
            {
                nBinarioInvertido += ((n1 % 2) != 0) ? "1" : "0";
                n1 /= 2;
            }
            return nBinarioInvertido;
        }

        public static string Convert_Again (string dnv)
        {
            do
            {
                Linha();
                Console.Write("Deseja converter outro número? [s/n] ");
                dnv = Console.ReadLine().ToLower();

                switch (dnv)
                {
                    case "s":
                    case "sim":
                        dnv = "s";
                        return dnv;

                    case "n":
                    case "nao":
                    case "não":
                        dnv = "n";
                        return dnv;

                    default:
                        Console.Clear();
                        dnv = "x";
                        Console.WriteLine("Erro!");
                        break;
                }
            } while ((dnv != "s") && (dnv != "n"));
            
            return dnv;
        }

        public static void Linha ()
        {
            Console.WriteLine("--------------------------------------");
        }
    }
}
