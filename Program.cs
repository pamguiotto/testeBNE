using System;

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
            Console.WriteLine("Tamanho do edifíco = {0}", resultado);

        }

        /// <summary>
        /// Construa um algoritmo que receba do usuário 4 números. Imprima o maior, o menor e a média deles.
        /// </summary>
        static void Atd2()
        {

        }

        /// <summary>
        /// Construa um algoritmo que instancia um array de inteiros com os seguintes valores: 1,3,35,40,85,123,121,209,200,305,350.Após, crie uma lógica que separe estes números entre pares e ímpares em outros 2 arrays.
        /// </summary>
        static void Atd3()
        {

        }

        /// <summary>
        /// Construa um algoritmo que recebe do usuário 5 números. Após recebê-los, retorne a lista de números em ordem decrescente.
        /// </summary>
        static void Atd4()
        {

        }

        /// <summary>
        /// Construa um algoritmo que identifique a quantidade de vogais a partir de um texto informado pelo usuário.
        /// </summary>
        static void Atd5()
        {

        }
    }
}