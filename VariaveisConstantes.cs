using System;
using System.IO;

namespace LerArquivos
{
    class Program
    {
        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\Users\emers\Desktop\arquivos\arq" + numeroArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\Users\emers\Desktop\arquivos\arq" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }


        }
        public const int SAIDA_PROGRAMA = 2;
        static void Main(string[] args)
        {
            while (true)
            {
               
                Console.WriteLine("Digite " +SAIDA_PROGRAMA+ " para sair do programa");
                int valor = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }

            }
            LerArquivos(1);
            LerArquivos(2);
            
        }
    }
}