using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Aula04_VatoresMatrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Exe6();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para encerrar.");
            Console.ReadKey();
        }

        private static void Exe1()
        {
            float[] mediaAlunos = new float[5];
            float soma = 0;
            float mediaGeral = 0;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite a média do {0}.° aluno: ", i + 1);
                mediaAlunos[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Média dos alunos: ");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(mediaAlunos[i]);
            }

            for (i = 0; i < 5; i++)
            {
                soma = soma + mediaAlunos[i];
            }

            mediaGeral = soma / 5;

            Console.WriteLine("Media Geral: ", mediaGeral.ToString("F2", CultureInfo.InvariantCulture));

        }

        private static void Exe2()
        {
            /*Ler dez elementos de um vetor A, construir um vetor B de mesmo tipo,
            * levando em consideração que se o valor do vetor for par, o valor deve ser multiplicado
            * por 5, e se for ímpar seve ser somado com 5.*/
            int[] a = new int[10];
            int[] b = new int[10];
            int i;
            int multiplicacao = 0;
            int soma = 0;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0}.° número: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                if (a[i] % 2 == 0)
                {
                    multiplicacao = a[i] * 5;
                    b[i] = multiplicacao;
                }
                else
                {
                    soma = a[i] + 5;
                    b[i] = soma;
                }
            }

            for (i = 0; i < 10; i++)
            {
                Console.Write("a[{0}]) = {1,4} / ", i, a[i]);
                Console.Write("b[{0}]) = {1,4} / ", i, b[i]);
                Console.WriteLine();
            }
        }

        private static void Exe3()
        {
            string[] nome = new string[5];
            int i, j;
            string x;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}.° nome: ", i + 1);
                nome[i] = Console.ReadLine();
            }

            for (i = 0; i < 4; i++)
                for (j = i + 1; j < 5; j++)
                    if (nome[i].CompareTo(nome[j]) > 0)
                    {
                        x = nome[i];
                        nome[i] = nome[j];
                        nome[j] = x;
                    }

            Console.WriteLine();
            Console.WriteLine("Lista de nomes ordenada:");
            Console.WriteLine();

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }

        private static void Exe4()
        {
            int[,] a = new int[3, 3];

            int i, j;

            int lin = 7, col = 0;

            Console.SetCursorPosition(0, 0);
            Console.Write("Digite um valor na coordenada:");
            Console.SetCursorPosition(0, 2);
            Console.Write("Linha...");
            Console.SetCursorPosition(0, 3);
            Console.Write("Coluna...");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("{0}", i + 1);
                    Console.SetCursorPosition(11, 3);
                    Console.Write("{0}", j + 1);
                    Console.SetCursorPosition(0, 5);
                    Console.Write("--> ");

                    a[i, j] = int.Parse(Console.ReadLine());

                    Console.SetCursorPosition(4, 5);
                    Console.Write("   ");
                    Console.SetCursorPosition(col, lin);
                    Console.Write("{0, 4}", a[i, j]);
                    col = col + 6;
                }

                lin = lin + 2;
                col = col - 18;
            }

            Console.SetCursorPosition(0, 13);
            Console.Write("Saída - Diagonal Principal");
            Console.SetCursorPosition(0, 15);

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++) 
                { 
                    if (i == j)
                    {
                        Console.Write("A[{0}, {1}]", i + 1, j + 1);
                        Console.WriteLine(" = {0, 4}", a[i, j]);
                    }
                }
            }
        }

        private static void Exe5()
        {
            /* Efetue a leitura de dois vetores. Vetor A com 5 elementos e
            * vetor B com 7 elementos. Construa uma matriz C, sendo a junção
            * dos vetores. Assim, C deve ter a capacidade de armazenar 12
            * elementos. Apresente a matriz C. */
            int[] a = new int[5];
            int[] b = new int[7];

            int[,] c = new int[3, 4];

            int i, j;

            int x = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Write("Digite o {0}.° número do Vetor A: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i < 7; i++)
            {
                Console.Write("Digite o {0}.° número do Vetor B: ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    if (x < 5)
                    {
                        c[i, j] = a[x];
                        x++;
                    }
                    else
                    {
                        c[i, j] = b[x - 5];
                        x++;
                    } 

                    Console.Write("C[{0}, {1}]", i, j);
                    Console.WriteLine(" = {0, 4}", c[i, j]);
                }
            }
        }

        private static void Exe6()
        {
            /*Leia oito elementos de um vetor A e construa um vetor B com os mesmos elementos de A,
            *que devem estar invertidos.Ou seja, o primeiro elemento de A passa a ser o último de B, 
            *o segundo elemento de A passa a ser o penúltimo de B e assim por diante. Apresente os dois vetores.*/

            int[] a = new int[8];
            int[] b = new int[8];
            int i, j = 0;

            for (i = 0; i < 8; i++)
            {
                Console.Write("Digite o {0}.° número: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            
            for (i = 7; i >= 0; i--)
            {
                if (j < 8)
                {
                    b[j] = a[i];
                }
                j++;
            }

            Console.WriteLine();

            for (i = 0; i < 8; i++)
            {
                Console.Write("a[{0}] = {1,4} / ", i + 1, a[i]);
                Console.Write("b[{0}] = {1,4} / ", i + 1, b[i]);
                Console.WriteLine();
            }
        }
    }
}

