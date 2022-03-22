using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste_BNE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo!\n");
            Console.WriteLine("Teste BNE!\n");

            Atd1();
            Atd2();
            Atd3();
            Atd4();
            Atd5();


        }

        /// <summary>
        /// Construa um algoritmo que calcula o tamanho de um edifício com base na altura de cada andar e o número de andares informados pelo usuário. 
        /// </summary>
        static void Atd1()
        {
            Console.WriteLine("Atividade 1");
            Console.WriteLine("Calculando o tamanho de um Edifício.\n");

            Console.WriteLine("Digite a Quantidade de andares: ");
            var quantidadeDeAndares = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a altura de cada andar: ");
            var alturaDosAndares = Convert.ToDouble(Console.ReadLine());

            var resultado = (quantidadeDeAndares * alturaDosAndares);
            Console.WriteLine("Tamanho do edifíco = {0}\n", resultado);
            Console.WriteLine("----------------\n");

        }

        /// <summary>
        /// Construa um algoritmo que receba do usuário 4 números. Imprima o maior, o menor e a média deles.
        /// </summary>
        static void Atd2()
        {
            Console.WriteLine("Atividade 2");
            Console.WriteLine("Identificando quantidades.\n");

            Console.WriteLine("Digite o primeiro número:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            var num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            var num4 = Convert.ToInt32(Console.ReadLine());

            int[] listaNum = { num1, num2, num3, num4 };


            var menorNumero = listaNum.Min();
            var maiorNumero = listaNum.Max();
            var mediaDosNumeros = (listaNum.Sum() / 4);
            Console.WriteLine("Menor número = {0}", menorNumero);
            Console.WriteLine("Maior número = {0}", maiorNumero);
            Console.WriteLine("Média dos números = {0}", mediaDosNumeros);
            Console.WriteLine("----------------\n");

        }

        /// <summary>
        /// Construa um algoritmo que instancia um array de inteiros com os seguintes valores: 1,3,35,40,85,123,121,209,200,305,350. Após, crie uma lógica que separe estes números entre pares e ímpares em outros 2 arrays.
        /// </summary>
        static void Atd3()
        {
            Console.WriteLine("Atividade 3");
            Console.WriteLine("Separando pares e impares.\n");
            Console.WriteLine("Click para dividir em dois arrays estes valores: 1,3,35,40,85,123,121,209,200,305,350");
            int[] listaOriginal = { 1, 3, 35, 40, 85, 123, 121, 209, 200, 305, 350 };

            var listaPar = new List<int>();
            var listaImpar = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                var numeroListaOrinal = listaOriginal[i];
                 
                if (numeroListaOrinal % 2 != 0)
                {
                    listaImpar.Add(numeroListaOrinal);
                }
                else
                {
                    listaPar.Add(numeroListaOrinal);
                }
            }
            Console.ReadLine();
            Console.WriteLine("Lista Original: {0}", string.Join(",", listaOriginal));
            Console.WriteLine("Lista de Pares: {0}", string.Join(",", listaPar));
            Console.WriteLine("Lista de Impares: {0}", string.Join(",", listaImpar));
            Console.WriteLine("----------------\n");

        }

        /// <summary>
        /// Construa um algoritmo que recebe do usuário 5 números. Após recebê-los, retorne a lista de números em ordem decrescente.
        /// </summary>
        static void Atd4()
        {
            Console.WriteLine("Atividade 4");
            Console.WriteLine("Ordenar números.\n");
            Console.WriteLine("Digite o primeiro número:");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número:");
            var num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o quarto número:");
            var num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o quinto número:");
            var num5 = Convert.ToInt32(Console.ReadLine());

            int[] listaNum = { num1, num2, num3, num4, num5 };

            //ordena os números aqui
            Array.Sort(listaNum);
            Array.Reverse(listaNum);

            Console.WriteLine("Lista ordenadas: {0}", string.Join(",", listaNum));

            Console.WriteLine("----------------\n");


        }

        /// <summary>
        /// Construa um algoritmo que identifique a quantidade de vogais a partir de um texto informado pelo usuário.
        /// </summary>
        static void Atd5()
        {
            Console.WriteLine("Atividade 5");
            Console.WriteLine("Contar letras.\n");
            Console.WriteLine("digite uma frase:");
            var frase = Console.ReadLine();

            var numeroDeVogais = frase.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));

            Console.WriteLine("numero de vogais={0}", numeroDeVogais);
            Console.WriteLine("OBRIGADO, ATÉ LOGO!.\n");
            Console.WriteLine("----------------\n");
        }
    }
}